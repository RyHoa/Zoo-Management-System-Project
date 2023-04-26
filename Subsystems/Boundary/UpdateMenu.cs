using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooManagementSystemControl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ZooManagementSystemEntity;

namespace ZooManagementSystemBoundary
{
    public partial class UpdateMenu : Form
    {
        private List<ZooManagementSystemEntity.Task> TaskList; 
        private int taskPointer = 0;
        public UpdateMenu()
        {
            InitializeComponent();
        }

        private void logout(object sender, EventArgs e)
        {
            LogoutForm logoutform = new LogoutForm(); 
            LogoutControl.logout(Convert.ToInt32(this.currentUserID));
            this.Close();             
            logoutform.Show();        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public string currentUserID
        {
            get { return idLabel.Text; }
            set { idLabel.Text = value; }
        }

        public string currentTaskID;

        private void markComplete(object sender, EventArgs e)
        {
            Int32.TryParse(currentUserID, out int usn);
            Int32.TryParse(currentTaskID, out int taskID);
            UpdateControl.complete(usn, taskID);
            refresh();
            display(usn, TaskList);
        }
        public void display(int usn, List<ZooManagementSystemEntity.Task> _items, int taskptr = 0)
        {
            /*
             * Is first called upon instantiation of the UpdateMenu
             * Will get a list of tasks corresponding to the given userID
             * and display the first one in that list.
             * 
             * Is also called when moving between tasks on the UpdateMenu
             * page. Will update a current task object and change text
             * on the page to be set appropriately.
             */

            this.TaskList = _items;

            if (TaskList.Count == 0)
            {
                taskType.Text = "";
                taskAnimal.Text = "";
                taskDate.Text = "";
                currentTaskID = "";
                TaskNo.Text = "X/X";
            }
            else
            {
                ZooManagementSystemEntity.Task myTask = new ZooManagementSystemEntity.Task();
                myTask = _items.ElementAt(taskptr); //change

                taskType.Text = myTask.TaskType;
                taskAnimal.Text = myTask.AnimalID.ToString();
                taskDate.Text = myTask.Date;
                currentTaskID = myTask.TaskID.ToString();

                TaskNo.Text = $"{taskPointer + 1}/{TaskList.Count}";
            }
            
        }

        public void refresh()
        {
            // This method should, once markComplete is called, refresh the list of active tasks.
            TaskList = DBConnector.getTasks(Convert.ToInt32(currentUserID));
        }

        private void nextTask_Click(object sender, EventArgs e)
        {
            if (taskPointer < TaskList.Count - 1)
            {
                this.taskPointer++;
                display(Convert.ToInt32(currentUserID), this.TaskList, taskPointer);
            }
        }

        private void previousTask_Click(object sender, EventArgs e)
        {
            if (taskPointer > 0)
            {
                this.taskPointer--;
                display(Convert.ToInt32(currentUserID), this.TaskList, taskPointer);
            }
        }
    }
}
