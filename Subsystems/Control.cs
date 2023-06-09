using System;
using System.Collections.Generic;
using System.Data.SQLite;
using ZooManagementSystemEntity;
using ZooManagementSystemBoundary;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Windows.Forms;
using ZMProject;

namespace ZooManagementSystemControl
{
    public class Controller{}

    public class DBConnector : Controller
    {
        public static void initializeDB()
        {           

            /*Method to initialize DB
             * Removes old tables in the DB file
             * Creates new file with new tables
             * Preload information for entities
             * Assume information in the DB is correct
             * Hash passwords to meet requirement
             * Loads the Startup Page*/

            //Code to create the DB file
            SQLiteConnection.CreateFile(@"./zManageDB.db");

            //automates the table creation here
            using (var connection = new SQLiteConnection(@"Data Source = zManageDB.db"))
            {
                connection.Open();

                //String for dropping existing table
                string dropSql = @"BEGIN TRANSACTION; 
                    DROP TABLE IF EXISTS LOG;  
                    DROP TABLE IF EXISTS EMPLOYEE;  
                    DROP TABLE IF EXISTS TASK;  
                    DROP TABLE IF EXISTS ANIMAL; COMMIT;";

                // Table initialization

                //String to create LOG table
                string createLogTableQuery = @"CREATE TABLE IF NOT EXISTS [LOG] ( 
                    [logID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
                    , [logType] TEXT NOT NULL
                    , [dateTime] TEXT NOT NULL
                    , [empID] TEXT NOT NULL
                    , FOREIGN KEY([empID]) REFERENCES [EMPLOYEE]([empID])
                    );";

                //String to create Employee table                
                string createEmployeeTableQuery = @"CREATE TABLE IF NOT EXISTS [EMPLOYEE] (
                    [empID] INTEGER PRIMARY KEY UNIQUE NOT NULL CHECK ([empID]>999 AND [empID]<10000) 
                    , [passwd] TEXT NOT NULL
                    , [empType] TEXT NOT NULL
                    , [firstName] TEXT NOT NULL
                    , [lastName] TEXT NOT NULL
                    );";

                //String to create Task table
                string createTaskTableQuery = @"CREATE TABLE IF NOT EXISTS [TASK] (
                    [taskID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
                    , [date] TEXT NOT NULL
                    , [completion] BOOL NOT NULL
                    , [taskType] TEXT NOT NULL
                    , [empID] INTEGER NOT NULL
                    , [animalID] INTEGER NOT NULL
                    , FOREIGN KEY([empID]) REFERENCES [EMPLOYEE]([empID])
                    , FOREIGN KEY([animalID]) REFERENCES [ANIMAL]([animalID])
                    );";

                //String to create Animal table
                string createAnimalTableQuery = @"CREATE TABLE IF NOT EXISTS [ANIMAL] (
                    [animalID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
                    , [location] TEXT NOT NULL
                    );";

                //String to insert information into the tables                
                string insertString = @"BEGIN TRANSACTION;                    
                    INSERT INTO EMPLOYEE (empID, passwd, empType, firstName, lastName) VALUES (1000, $hashpwd1, 'Admin', 'Ryan', 'Hoang'); 
                    INSERT INTO EMPLOYEE (empID, passwd, empType, firstName, lastName) VALUES (1001, $hashpwd2, 'Employee', 'Andrew', 'Hoang'); 
                    INSERT INTO EMPLOYEE (empID, passwd, empType, firstName, lastName) VALUES (1002, $hashpwd3, 'Employee', 'Elijah', 'Gibson'); 
                    INSERT INTO EMPLOYEE (empID, passwd, empType, firstName, lastName) VALUES (1003, $hashpwd1, 'Employee', 'Eliana', 'Lopez Feliciano'); 
                    INSERT INTO EMPLOYEE (empID, passwd, empType, firstName, lastName) VALUES (1004, $hashpwd2, 'Employee', 'Bethany', 'Sumner'); 
                    INSERT INTO EMPLOYEE (empID, passwd, empType, firstName, lastName) VALUES (1005, $hashpwd3, 'Employee', 'Bob', 'Test'); 
                    INSERT INTO TASK (date, completion, taskType, empID, animalID) VALUES ('4/21/2023 12:00:00 AM', TRUE, 'Refill Food', 1001, 1);
                    INSERT INTO TASK (date, completion, taskType, empID, animalID) VALUES ('4/22/2023 12:00:00 AM', TRUE, 'Enrichment Activity', 1001, 2);
                    INSERT INTO TASK (date, completion, taskType, empID, animalID) VALUES ('4/26/2023 12:00:00 AM', FALSE, 'Clean Habitat', 1001, 1);
                    INSERT INTO TASK (date, completion, taskType, empID, animalID) VALUES ('4/24/2023 12:00:00 AM', FALSE, 'Refill Water', 1001, 2);
                    INSERT INTO TASK (date, completion, taskType, empID, animalID) VALUES ('4/22/2023 12:00:00 AM', FALSE, 'Refill Water', 1001, 1);
                    INSERT INTO ANIMAL (location, animalID) VALUES ('Enclosure 001', 1);
                    INSERT INTO ANIMAL (location, animalID) VALUES ('Enclosure 001', 2);
                    COMMIT;";




                using (var command = new SQLiteCommand(connection))
                {

                    /*command and execute for certain functions
                    one to drop existing tables and others to create 
                    new table */
                    command.CommandText = dropSql;
                    command.ExecuteNonQuery();
                    command.CommandText = createLogTableQuery;
                    command.ExecuteNonQuery();
                    command.CommandText = createEmployeeTableQuery;
                    command.ExecuteNonQuery();
                    command.CommandText = createTaskTableQuery;
                    command.ExecuteNonQuery();
                    command.CommandText = createAnimalTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = insertString;

                    //commands to hash password 
                    string pwd1 = "@Ryan123";
                    string pwd2 = "@Andrew123";
                    string pwd3 = "@Elijah123";
                    int x = pwd1.GetHashCode();
                    int y = pwd2.GetHashCode();
                    int z = pwd3.GetHashCode();

                    //commands to add to the pwd column of the Employee Table
                    command.Parameters.AddWithValue("$hashpwd1", x);
                    command.Parameters.AddWithValue("$hashpwd2", y);
                    command.Parameters.AddWithValue("$hashpwd3", z);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            //code to create a startUp menu and initialize it 
            StartupMenu startUp = new StartupMenu();
            startUp.Show();
            Application.Run();
        }
    
        public static Account getUser(int _usn)
        {
            /*Method to get account formation for a certain user
            * Create an account object to store data from the DB
            * Open a connection into the DB and use the command query to get data
            * Store data into the properties of the account object 
            */

            Account acct = new Account(); 
            using (var connection = new SQLiteConnection(@"Data Source = zManageDB.db"))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    string queryAcct = @"SELECT * FROM EMPLOYEE WHERE (empID == $usn)";
                    command.CommandText = queryAcct;
                    command.Parameters.AddWithValue("$usn", _usn);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            acct.Usn = reader.GetInt32(0);
                            acct.Password = reader.GetString(1);
                            acct.Role = reader.GetString(2);
                            acct.Name = (reader.GetString(3) + " " + reader.GetString(4));
                        }
                    }
                    connection.Close();
                }
                return acct;
            }
        }

        public static List<Task> getTasks(int _usn)
        {

            /* Retrieves task tuples associated with a user ID
             * Stores all retrieved data into a Task object
             * Created Task objects are pushed into a list          
             */

            List<Task> taskList = new List<Task>();
            using (var connection = new SQLiteConnection(@"Data Source = zManageDB.db"))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    // query gets every currently assigned incomplete task for one employee
                    string queryAcct = @"SELECT * FROM TASK WHERE (empID == $usn) and (completion != 1)";
                    command.CommandText = queryAcct;
                    command.Parameters.AddWithValue("$usn", _usn);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Task myTask = new Task();                               
                            myTask.TaskID = reader.GetInt32(0);
                            myTask.Date = reader.GetString(1);
                            myTask.Completion = reader.GetBoolean(2);
                            myTask.TaskType = reader.GetString(3);                                
                            myTask.EmployeeID = reader.GetInt32(4);
                            myTask.AnimalID = reader.GetInt32(5); 
                            taskList.Add(myTask);                                
                        }
                    }
                    connection.Close();
                }
            }
            return taskList;
        }
        public static void save(Task _task) 
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"data source = zManageDB.db"))
            {
                connection.Open();
                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    string insert = @"INSERT INTO TASK (date, completion, taskType, empID, animalID) VALUES ($date, FALSE, $taskType, $empID, $animalID);";

                    command.CommandText = insert;
                    command.Parameters.AddWithValue("$date", _task.Date);
                    command.Parameters.AddWithValue("$taskType", _task.TaskType);
                    command.Parameters.AddWithValue("$empID", _task.EmployeeID);
                    command.Parameters.AddWithValue("$animalID", _task.AnimalID);
                    
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            
        }
        public static void setCompleted(int _taskID)
        {
            string query = @"UPDATE TASK SET completion = 1 WHERE (taskID == $taskID)";
            using (SQLiteConnection connection = new SQLiteConnection(@"data source = zManageDB.db"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("$taskID", _taskID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void saveLogin(int _usn, string _time) 
        { 
            /* Method to save the Login information
             * Sets the connection to the DB file
             * Code used to save the Login information 
             * for a correct user */           
             
            using (SQLiteConnection connection = new SQLiteConnection(@"data source = zManageDB.db"))
            {
                connection.Open();
                string insert = @"INSERT INTO LOG (logType, dateTime, empID) VALUES ($logType, $dateTime, $empID);";
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {                    
                    command.CommandText = insert;
                    command.Parameters.AddWithValue("$logType", "login");
                    command.Parameters.AddWithValue("$dateTime", _time);
                    command.Parameters.AddWithValue("empID", _usn);
                    command.ExecuteNonQuery();
                }
            }        
        
        }
        public static void saveLogout(int _usn, string _time) 
        {
            /* Method to save the Logout information
             * Sets the connection to the DB file
             * Code used to save the Logout information 
             * for a correct user */     
             
            using (SQLiteConnection connection = new SQLiteConnection(@"data source = zManageDB.db"))
            {
                connection.Open();
                string insert = @"INSERT INTO LOG (logType, dateTime, empID) VALUES ($logType, $dateTime, $empID);";
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = insert;
                    command.Parameters.AddWithValue("$logType", "logout");
                    command.Parameters.AddWithValue("$dateTime", _time);
                    command.Parameters.AddWithValue("$empID", _usn);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

    public class LogoutControl : Controller
    {
        public static void logout(int _usn) 
        {
            /*Method used to indicate logout
             * Sends the current time to the 
             * saveLogout method*/
             
            DateTime time = DateTime.Now;
            string strTime = time.ToString();
            DBConnector.saveLogout(_usn, strTime);
        }
    }
    public class addTaskControl : Controller
    {
        public static void submit(Task _Task) 
        {            
            DBConnector.save(_Task);
        }
    }
    public class StartController : Controller
    {
        public static void initiate() 
        {
            DBConnector.initializeDB();

        }
    }

    public class UpdateControl : Controller
    {
        public static void complete(int usn, int taskID) 
        { 
            
             /* This method should call setCompleted to set a specific task's
             * completion field to TRUE. It then refreshes the UpdateMenu
             * through the refresh() method by passing in the updated list
             * of tasks directly from the database.
             */

            DBConnector.setCompleted(taskID);
        }
    }

    public class LoginControl : Controller
    {
        public static void login() 
        {
            /* Method to create and show the loginform*/
            LoginForm loginform = new LoginForm();

            loginform.Show();
        }
        public static bool login(string _usn, string _pwd)
        {
            /* Method to do login validation*/

            //if length is not 4 which is ID specified length, then return false
            if(_usn.Length != 4)
            {               
                return false;
            }
            
            //if not an integer return false, login failure
            if(!Int32.TryParse(_usn, out int usn))
            {
                return false;
            }

            
            //stores the user password and hashes it into a string
            string hashedPwd = _pwd.GetHashCode().ToString();

            //gets the Account from the database
            Account user = DBConnector.getUser(usn);


            /*If true we store the login into the 
             * db and then open the form 
            based on either Admin or Employee */
            if (validate(user, hashedPwd))
            {
                DateTime currTime = DateTime.Now;
                string time = currTime.ToString();
                DBConnector.saveLogin(usn, time);              
                
                if(user.Role == "Admin")
                {
                    addTaskMenu initialAddTask = new addTaskMenu();
                    Form.ActiveForm.Close();     
                    initialAddTask.editID = usn.ToString();
                    initialAddTask.Show();
                }
                else if(user.Role == "Employee")
                {
                    UpdateMenu updateMenu = new UpdateMenu();
                    Form.ActiveForm.Close();
                    updateMenu.currentUserID = usn.ToString();
                    updateMenu.Show();
                    updateMenu.display(usn, DBConnector.getTasks(usn));
                }

                return true;

            }
            //if the pwds do not match return false indicating login failure
            else
            {
                return false;
            }
        }


        public static bool validate(Account user, string pwd) 
        {
            /* Method to compare the user password with the account password*/
            return user.Password == pwd; 
        }
    }
}