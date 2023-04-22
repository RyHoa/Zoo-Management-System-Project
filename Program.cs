using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagementSystemEntity;
using ZooManagementSystemBoundary;
using ZooManagementSystemControl;
using System.Windows.Forms;
using System.Diagnostics;

namespace ZMProject
{
    internal class Program
    {
        public static void Main()
        {
            //Console.WriteLine("1");
            //DBConnector.initializeDB();
            //Console.WriteLine("2");
            //Console.ReadKey();
            //DateTime t = new DateTime();
            //string y = t.ToString();
            //DBConnector.saveLogout("1000", y);
            //Console.WriteLine("3");
            //DBConnector.saveLogin("1000", y);
            //Console.WriteLine("4");

            // Eliana's scratch work
            DBConnector.initializeDB();
            StartupMenu initialStart = new StartupMenu();  // create new startup form to display
            Application.Run(initialStart);          // run the form

            // Login control debug
            //DBConnector.initializeDB();
            //Account testacc = DBConnector.getUser(1001);
            //Console.WriteLine(testacc.Usn);
            //Console.WriteLine(testacc.Password);
            //Console.WriteLine(testacc.Role);
            //Console.WriteLine(testacc.Name);
            //Console.ReadKey();
            //LoginControl.login(1001, "bye");
            //Console.ReadKey();
            //LoginControl.login(1001, "hciouehf189yh");
            //Console.ReadKey();
        }
    }
}
