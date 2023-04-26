using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooManagementSystemControl;
using ZooManagementSystemEntity;

namespace ZooManagementSystemBoundary
{
    public partial class addTaskMenu : Form
    {
        public addTaskMenu()
        {
            InitializeComponent();
            this.addTaskCal.MinDate = DateTime.Now;
        }


        private void formAddTask_1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpID_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // submit button
        // on click, check if any field is null, if none, then show green text. Otherwise, nothing.
        private void button1_Click(object sender, EventArgs e)
        {
            int errorCtrl = 0;
            foreach (ComboBox c in this.Controls)
            {
                ComboBox textBox = (ComboBox)c;

                if (textBox.Text == "" || c.SelectedItem == null)
                {
                    errorCtrl++;
                    MessageBox.Show("error");
                    break;
                }
                else { break; }
            }

            if (errorCtrl == 0)
            {
                MessageBox.Show("you've successfully submitted a task!");
                ReloadForm();
            }

        }

        private void ReloadForm()
        {
            comboAnID.ResetText();
            comboEmpID.ResetText();
            comboTaskType.ResetText();
            addTaskCal.SelectionStart = addTaskCal.MinDate;
        }

        private void comboEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // do nothing
        }

        private void addTaskCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            // do nothing
        }

        private void submit(object sender, EventArgs e)
        {
            /* Parsing text boxes to create a Task object.
             * 
             * If a the text boxes are only partially filled, the
             * task object is not created and nothing is submitted
             * to the database.
             */

            Int32.TryParse(comboEmpID.Text, out int empID);
            Int32.TryParse(comboAnID.Text, out int anID);
            string taskType = comboTaskType.Text;
            string calDate = addTaskCal.SelectionStart.ToString();
            
            if (calDate != null && anID != default && empID != default && taskType != null)
            {
                ZooManagementSystemEntity.Task myTask = new ZooManagementSystemEntity.Task(calDate, default, anID, taskType, empID, false);
                addTaskControl.submit(myTask);                
                myTask = new ZooManagementSystemEntity.Task();
                this.reset();
                SuccessMessage.Visible = true;
            }
                
        }
        private void reset()
        {
            /* Method to reset the text boxes in the 
             * AddTaskMenu form i.e. makes them empty
             */
            comboEmpID.ResetText();
            comboAnID.ResetText();
            comboTaskType.ResetText();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // show logout page

            LogoutForm logoutform = new LogoutForm(); // create new logout page
            LogoutControl.logout(Convert.ToInt32(this.editID));
            this.Close();             // close addtask page
            logoutform.Show();        // run logout page
        }
        public string editID
        {
            get { return idLabel.Text; }
            set { idLabel.Text = value; }
        }

        private void comboEmpID_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboAnID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboTaskType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addTaskCal_DateChanged_1(object sender, DateRangeEventArgs e)
        {

        }
    }
}
