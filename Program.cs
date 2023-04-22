using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagementSystem.Entity;
using ZooManagementSystem.Boundary;
using ZooManagementSystem.Control;

namespace ZMProject
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("1");
            DBConnector.initializeDB();
            Console.WriteLine("2");
            Console.ReadKey();
            DateTime t = new DateTime();
            string y = t.ToString();
            DBConnector.saveLogout("1000", y);
            Console.WriteLine("3");
            DBConnector.saveLogin("1000", y);
            Console.WriteLine("4");
        }
    }
}
