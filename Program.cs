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
using System.Threading;

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

            //// Eliana's scratch work
            //DBConnector.initializeDB();
            //StartupMenu initialStart = new StartupMenu();  // create new startup form to display
            //Application.Run(initialStart);          // run the form

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

            // Initializing Database: version that sorta works at least::::
            //DBConnector.initializeDB();
            //Console.ReadKey();
            //LoginForm initialStart2 = new LoginForm();
            //Application.Run(initialStart2);


            ////kinda works
            //Form myForm = new Form();
            //addTaskMenu test = new addTaskMenu();
            //LoginForm initialStart2 = new LoginForm();
            ////Application.Run(initialStart2);
            //test.Show();
            //initialStart2.Show();
            //initialStart2.Visible = true;
            //test.Visible = false;


            //Application.Run();
            //Console.ReadKey();
            //Console.WriteLine("hi");
            
            //initialStart2.Visible = false;
            //test.Visible = true;
            //Console.ReadKey();
            //test.Close();




            //// bethany's scratch work: 
            //LoginForm intialStart3 = new LoginForm();
            //DialogResult loginResult = initialStart3.ShowDialog()
            //using(LoginForm log = new LoginForm())
            //{
            //    if (log.ShowDialog() == DialogResult.OK)
            //        Application.Run(new Form());
            //}
            //.DialogResult = DialogResult.OK;


            // another test lol 
            LoginForm login = new LoginForm();
            DialogResult loginResult = login.ShowDialog();
            if (loginResult == DialogResult.OK)
            {
                login.Close();
                addTaskMenu addTask = new addTaskMenu();
                Application.Run(new addTaskMenu());
            }

        }
    }
}
