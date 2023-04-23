using System;
using System.Collections.Generic;
using System.Data.SQLite;
using ZooManagementSystemEntity;
using ZooManagementSystemBoundary;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Windows.Forms;

namespace ZooManagementSystemControl
{

    public class Controller
    {
        //attributes to include form, list, controller, task
        //add constructor
        
        

    }

    public class DBConnector : Controller
    {
        public static void initializeDB()
        {

            /*Things to finish
             * 1. Ask about the primary key constraint thing
             * 2. Finish putting hash password
             * 3. Ask what values to store in what tables and if we need to do all the tables
             * 4. Make EMP ID Integer and test it out
             * 
             */



            //Only creates the DB if the file isn't there 
            //if (!File.Exists(@"./zManageDB.db"))
            //{
            //May need the actual path but it creates the db file here
            SQLiteConnection.CreateFile(@"./zManageDB.db");
            System.Console.WriteLine("DB file is created");

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

                // go back into class diagram and change -usn:string to -usn:int
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
                //Don't include PK and FK?
                //Skip LOG and Task for now?
                //Remember to put hash values for password

                //not done need values and why do we not insert primary keys?
                //prob dont need the log stuff
                string insertString = @"BEGIN TRANSACTION;
                    INSERT INTO LOG (logType, dateTime, empID) VALUES ('logout', '2021-02-05', 1000);
                    INSERT INTO EMPLOYEE (empID, passwd, empType, firstName, lastName) VALUES (1000, $hashpwd1, 'Admin', 'Ryan', 'Hoang'); 
                    INSERT INTO EMPLOYEE (empID, passwd, empType, firstName, lastName) VALUES (1001, $hashpwd2, 'Employee', 'Andrew', 'Hoang'); 
                    INSERT INTO TASK (date, completion, taskType, empID, animalID) VALUES ('2022-09-01', True, 'Feed', 1001, 1);
                    INSERT INTO ANIMAL (location, animalID) VALUES ('Enclosure 001', 1);
                    COMMIT;";




                using (var command = new SQLiteCommand(connection))
                {

                    command.CommandText = createLogTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = createEmployeeTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = createTaskTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = createAnimalTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = insertString;




                    //commands to hash password and add it to the Employee Password column
                    string pwd1 = "hi";
                    string pwd2 = "bye";
                    int x = pwd1.GetHashCode();
                    int y = pwd2.GetHashCode();
                    command.Parameters.AddWithValue("$hashpwd1", x);
                    command.Parameters.AddWithValue("$hashpwd2", y);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            StartupMenu startUp = new StartupMenu();
            startUp.Show();
            Application.Run();
        }
    
    public static Account getUser(int _usn)
    {
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

        //public static ItemList getItems(string _usn) { }
        //public static void save(Task _task) { }
        public static void setCompleted(int _taskID) { }

        public static void saveLogin(int _usn, string _time) 
        { 
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
            using (SQLiteConnection connection = new SQLiteConnection(@"data source = zManageDB.db"))
            {
                connection.Open();
                string insert = @"INSERT INTO LOG (logType, dateTime, empID) VALUES ($logType, $dateTime, $empID);";
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = insert;
                    command.Parameters.AddWithValue("$logType", "logout");
                    command.Parameters.AddWithValue("$dateTime", _time);
                    command.Parameters.AddWithValue("empID", _usn);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

    public class LogoutControl : Controller
    {
        public static void logout(int _usn) 
        { 
            DateTime time = DateTime.Now;
            string strTime = time.ToString();
            DBConnector.saveLogout(_usn, strTime);
        }
    }
    public class addTaskControl : Controller
    {
        //public static void submit(Task x) 
        //{
        //    DBConnector.save(x);
        //}
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
            DBConnector.setCompleted(taskID);
            //var items = DBConnector.getItems(usn);
        }
    }
    public class LoginControl : Controller
    {
        public static void login() 
        { 
            //display login form
        }
        public static bool login(string _usn, string _pwd)
        {
            
            
            if(!Int32.TryParse(_usn, out int usn))
            {
                return false;
            }

            string hashedPwd = _pwd.GetHashCode().ToString();
            Account user = DBConnector.getUser(usn);
            if (validate(user, hashedPwd))
            {
                DateTime currTime = DateTime.Now;
                string time = currTime.ToString();
                DBConnector.saveLogin(usn, time);

                // Eliana's scratch work
                //we need a way to differentiate account type 
                // assuming every user is an admin ( for testing ):
                //addTaskMenu initialAddTask = new addTaskMenu();
                //initialAddTask.Activate();
                //close login form also
                Console.WriteLine("Pass"); //delete later
                if(user.Role == "Admin")
                {
                    System.Console.WriteLine("test");
                    addTaskMenu initialAddTask = new addTaskMenu();
                    Form.ActiveForm.Close();                                //this should close whatever previous form is open        
                    initialAddTask.Show();
                    
                    
                    
                }
                else if(user.Role == "Employee")
                {
                    //open updateTaskMenu
                }

                return true;

            }
            else
            {
                return false;
            }
        }
        public static bool validate(Account user, string pwd) // Make sure to change the class diagram to reflect returning a bool
        {
            return user.Password == pwd; 
        }
    }
}