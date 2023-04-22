using System;
using System.Collections.Generic;
using System.Data.SQLite;
using ZooManagementSystem.Entity;
using ZooManagementSystem.Boundary;
using System.Security.Cryptography;

namespace ZooManagementSystem.Control
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
        }

        //public static Account getUser(string _usn) 
        //{
            
        //}

        //public static ItemList getItems(string _usn) { }
        //public static void save(Task _task) { }
        public static void setCompleted(int _taskID) { }

        public static void saveLogin(string _usn, string _time) 
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
        public static void saveLogout(string _usn, string _time) 
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
        public static void logout(string _usn) 
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
        public static void complete(string usn, int taskID) 
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
        //public static void login(string usn, string pwd) // Make sure to change the class diagram to reflect void and not bool
        //{
        //    int hashedPwd = pwd.GetHashCode();
        //    Account user = DBConnector.getUser(usn);
        //    bool isValid = validate(user, hashedPwd);
        //    if (isValid)
        //    {
        //        // go through
        //        // not done
        //        DateTime currTime = DateTime.Now;
        //        string time = currTime.ToString();
        //        DBConnector.saveLogin(usn, time);
        //    }
        //    else
        //    {
        //        // display error
        //    }
        //}
        //public static bool validate(Account user, string pwd) // Make sure to change the class diagram to reflect returning a bool
        //{ 
        //    return user.Password == pwd;
        //}
    }
}