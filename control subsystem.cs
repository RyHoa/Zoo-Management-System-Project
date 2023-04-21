using System;
using System.Collections.Generic;
using ZooManagementSystem.Entity;
using ZooManagementSystem.Boundary;
using System.Data.SQLite;


namespace ZooManagementSystem.Control
{
    public static class DBConnector
    {
        public void initializeDB()
        {

            /*Things to finish
             * 1. Ask about the primary key constraint thing
             * 2. Finish putting hash password
             * 3. Ask what values to store in what tables and if we need to do all the tables
             * 
             * 
             */



           //Only creates the DB if the file isn't there 
           if(!File.Exists(@"./zManageDB.db"))
           {
                //May need the actual path but it creates the db file here
                SQLiteConnection.CreateFile(@"./zManageDB.db"); 

                //automates the table creation here
                using(var connection = new SQLiteConnection(@"Data Source = zManageDB.db"))
                {
                    connection.Open();

                    //String for dropping existing table
                    string dropSql = @"BEGIN TRANSACTION; 
                    DROP TABLE IF EXISTS LOG;  
                    DROP TABLE IF EXISTS EMPLOYEE;  
                    DROP TABLE IF EXISTS TASK;  
                    DROP TABLE IF EXISTS ANIMAL; COMMIT;";     
                    
                   
                    



                    //String for creating Tables for the Zoo Management System

                    //String to create LOG table
                    string createLogTableQuery = @"CREATE TABLE IF NOT EXISTS [LOG] ( 
                    [lodID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
                    , [logType] TEXT NOT NULL
                    , [dateType] TEXT NOT NULL
                    , FOREIGN KEY([empID]) REFERENCE [EMPLOYEE]([empID])
                    );";

                    //String to create Employee table

                    //Check bout passwd
                    string createEmployeeTableQuery = @"CREATE TABLE IF NOT EXISTS [EMPLOYEE] (
                    [empID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
                    , [passwd] TEXT NOT NULL
                    , [empType] TEXT NOT NULL
                    , [firstName] TEXT NOT NULL
                    , [lastName] TEXT NOT NULL
                    );";

                    //String to create Task table
                    string createTaskTableQuery = @"CREATE TABLE IF NOT EXISTS [TASK] (
                    [tasksID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
                    , [date] TEXT NOT NULL
                    , [completion] TEXT NOT NULL
                    , [taskType] TEXT NOT NULL
                    , FOREIGN KEY([empID]) REFERENCES [EMPLOYEE]([empID])
                    , FOREIGN KEY([animalID)] REFERENCES [ANIMAL]([animalID])
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
                    string insertString = @"BEGIN TRANSACTION;
                    INSERT INTO LOG (logType, dateType) VALUES ();
                    INSERT INTO EMPLOYEE (passwd, empType, firstName, lastName) VALUES (); 
                    INSERT INTO TASK (date, completion, taskType) VALUES ();
                    INSERT INTO ANIMAL (location) VALUES ();
                    COMMIT;";


                    

                    using(var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = createLogTableQuery;
                        command.ExecuteNonQuerty();
                        command.CommandText = createEmployeeTableQuery;
                        command.ExecuteNonQuerty();
                        command.CommandText = createTaskTableQuery;
                        command.ExecuteNonQuerty();
                        command.CommandText = createAnimalTableQuery;
                        command.ExecuteNonQuerty();
                        command.CommandText = insertString;

                        //finish here
                        string pwd1 = "";
                        string pwd2 = "";

                        int x = pwd1.GetHashCode();
                        int y = pwd2.GetHashCode();

                        //finish here
                        command.Parameters.AddWithValue("", x);
                        command.Parameters.AddWithValue("", y);
                        command.ExecuteNonQuerty();
                        connection.Close();
                    }



                }
           }

        }
        public Account getUser(string _usn) {}
        public void saveLogin(string _usn, string _time) {}
        public ItemList getItems(string _usn){}
        public void save(Task _task){}
        public void setCompleted(int _taskID) {}
        public void saveLogout(string _usn, string _time){}
    }
    public class LogoutControl
    {
        
    }
    public class addTaskControl
    {

    }
    public class StartController
    {

    }
    public class addTaskControl
    {

    }
    public class UpdateControl
    {

    }
    public class LoginControl
    {
        
    }
}