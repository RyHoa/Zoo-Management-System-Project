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
        
    }
    class Account
    {

        //ask if we are storing user input information into the account object, if we do we need error checking, if not then delete all the set stuff

        public Account(int usn, string name, string role, string pwd)
        {
            Usn = usn;
            Name = name;
            Role = role;
            Password = pwd;
        }

        private int usn;
        public int Usn //ask if he wants these get /set methods or actual get set method
        { 
            get 
            { 
                return usn; 
            } 
            set
            {
                if (value >= 0 && value <= 9999)
                {
                    usn = value;
                }
                else
                {
                    throw new Exception("Error: Something went wrong.");
                }
            } 
        }
        private string role;
        
        public string Role 
        { 
            get 
            { 
                return role; 
            } 
            set 
            { 
                if(value.ToLower() == "admin")
                {
                    role = value;
                }
                else if (value.ToLower() == "employee")
                {
                    role = value;
                }
                else
                {
                    throw new Exception("Error: Something went wrong.");
                }
            } 
        }
        private string password
        ;
        public string Password 
        { 
            get 
            { 
                return password; 
            } 
            set 
            { 
                password = value; 
            }
        }

        //use string builder class to touch up, combine the first name and last name
        private string name;
        public string Name //change on class diagram to have first name and last name
        {
            get 
            { 
                return name; 
            }
            set 
            { 
                Regex reg = new Regex(value);

                if (!(reg.IsMatch(@"\d")))
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Error: Something went wrong.");

                }
                
            }
        }


    }
    class Task
    {
        public Task(int taskID, int animalID, int taskType, int employeeID)
        {    
            TaskID = taskID;
            AnimalID = animalID;
            TaskType = taskType;
            EmployeeID = employeeID;


        }

        private int taskID;
        public int TaskID 
        {
            get { return taskID; }
            set 
            {
                bool validTaskID = int.TryParse(value, out int );
                if (validTaskID && input >= 0 && input <= 9999)
                {
                    usn = value;
                }
                else
                {
                    return;
                }
            }
        }
        private int animalID;
        private int taskType;
        private int employeeID;
    }
    class Animal
    {
        private int animalID;
        
    }
}
