using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace entity
{
    class ItemList
    {
        public ItemList()
        {
            //not done
        }
    }
    class Account
    {   
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
    class Task
    {
        public Task(int _taskID, int _animalID, int _taskType, int _employeeID)
        {    
            TaskID = _taskID;
            AnimalID = _animalID;
            TaskType = _taskType;
            EmployeeID = _employeeID;
        }

        private int taskID;
        public int TaskID {get;set;} 
        
        private int animalID;
        public int AnimalID {get;set;}

        private int taskType;
        public int TaskType {get;set;}

        private int employeeID;
        public int EmployeeID {get;set;}
    }
    class Animal
    {
        public Animal(int _animalID)
        {
            AnimalID = _animalID;
        }

        private int animalID;
        public int AnimalID {get;set;}       
        
    }
}
