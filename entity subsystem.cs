using System;
using System.Collections.Generic;

namespace ZooManagementSystemEntity
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

        public int Usn {get;set;}
        public string Role {get;set;}
        public string Password {get;set;}
        public string Name {get;set;}    
    }
    public class Task
    {
        public Task() { }
        public Task(string _date, int _taskID, int _animalID, string _taskType, int _employeeID, char _Completion)
        {
            Date = _date;
            TaskID = _taskID;
            AnimalID = _animalID;
            TaskType = _taskType;
            EmployeeID = _employeeID;
            Completion = _Completion;
        }
        public char Completion { get;set;}

        public string Date { get;set;}

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
        
        public int AnimalID {get;set;}        
        public string TaskType {get;set;}        
        public int EmployeeID {get;set;}
    }
    public class Animal
    {
        public Animal(int _animalID)
        {
            AnimalID = _animalID;
        }        
        public int AnimalID {get;set;}       
        
    }
}
