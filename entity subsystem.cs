using System;
using System.Collections.Generic;

namespace ZooManagementSystemEntity                 // change stuff in here according to feedback! :D
{
    public class Account
    {
        public Account() { }
        public Account(int _usn, string _fname, string _lname, string _role, string _password)
        {
            Usn = _usn;
            Name = _fname + " " + _lname;
            Role = _role;
            Password = _password;
        }      

        private int usn;
        public int Usn {get;set;}

        private string role;        
        public string Role {get;set;}
        
        private string password;
        public string Password {get;set;}  

        private string name;
        public string Name {get;set;}    
    }
    public class Task
    {
        public Task(int _taskID, int _animalID, string _taskType, int _employeeID) // update class diagram to reflect empid and tasktype
        {    
            TaskID = _taskID;
            AnimalID = _animalID;
            TaskType = _taskType;
            EmployeeID = _employeeID;
        }

        private int taskID;
        public int TaskID 
        {
            get { return taskID; }
            set 
            { 
                if (value >= 1 && value < int.MaxValue)
                {
                    taskID = value;
                }
            }
        } 
        
        private int animalID;
        public int AnimalID {get;set;}

        private string taskType;
        public string TaskType {get;set;}

        private int employeeID;
        public int EmployeeID {get;set;}
    }
    public class Animal
    {
        public Animal(int _animalID)
        {
            AnimalID = _animalID;
        }

        private int animalID;
        public int AnimalID {get;set;}       
        
    }
}
