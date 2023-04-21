using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SQLiteDemo;


namespace ZooManagementSystem.Control
{
    public static class DBConnector
    {
        public static void initializeDB()
        {

            /*Things to finish
             * 1. Ask about the primary key constraint thing
             * 2. Finish putting hash password
             * 3. Ask what values to store in what tables and if we need to do all the tables
             * 
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






                //String for creating Tables for the Zoo Management System

                //String to create LOG table
                string createLogTableQuery = @"CREATE TABLE IF NOT EXISTS [LOG] ( 
                    [lodID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
                    , [logType] TEXT NOT NULL
                    , [dateType] TEXT NOT NULL
                    , [empID] TEXT NOT NULL
                    , FOREIGN KEY([empID]) REFERENCES [EMPLOYEE]([empID])
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
                    , [empID] TEXT NOT NULL
                    , [animalID] TEXT NOT NULL
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
                string insertString = @"BEGIN TRANSACTION;
                    INSERT INTO LOG (logType, dateType, empID) VALUES ('Admin', '05', '1');
                    INSERT INTO EMPLOYEE (passwd, empType, firstName, lastName) VALUES ($hashpwd1, 'Admin', 'Ryan', 'Hoang'); 
                    INSERT INTO EMPLOYEE (passwd, empType, firstName, lastName) VALUES ($hashpwd2, 'Admin', 'Andrew', 'Hoang'); 
                    INSERT INTO TASK (date, completion, taskType, empID, animalID) VALUES ('06', 'T', 'Feed','1','2');
                    INSERT INTO ANIMAL (location) VALUES ('here');
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

        public static Account getUser(string _usn) { }

        public static ItemList getItems(string _usn) { }
        public static void save(Task _task) { }
        public static void setCompleted(int _taskID) { }

        public static void saveLogin(string _usn, string _time) { }
        public static void saveLogout(string _usn, string _time) { }
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

    public class UpdateControl
    {

    }
    public class LoginControl
    {

    }
}