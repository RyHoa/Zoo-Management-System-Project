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
           //Only creates the DB if the file isn't there 
           if(!File.Exists(@"./zManageDB.db"))
           {
                //May need the actual path but it creates the db file here
                SQLiteConnection.CreateFile(@"./zManageDB.db"); 

                //automates the table creation here
                using(connection = new SQLiteConnection(@"Data Source = zManageDB.db"))
                {
                    connection.Open();

                    //String for dropping existing table
                    string dropSql = "@BEGIN TRANSACTION;DROP TABLE IF EXISTS LOG; DROP TABLE IF EXISTS EMPLOYEE; DROP TABLE IF EXISTS TASK; DROP TABLE IF EXISTS ANIMAL; COMMIT;";          




                    //String for creating Tables for the Zoo Management System
                    string createLogTableQuery = @"CREATE TABLE IF NOT EXISTS log ( lodID INTEGER PRIMARY KEY AUTOINCREMENT, logType TEXT NOT NULL, dateType TEXT NOT NULL)";
                    string createEmployeeTableQuery;
                    string createTaskTableQuery;
                    string AnimalTaskTableQuery;
                    
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