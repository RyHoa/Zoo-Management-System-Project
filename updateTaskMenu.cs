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

namespace ZooManagementSystemBoundary
{
    public partial class updateTaskMenu : Form
    {
        public updateTaskMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogoutForm logoutform = new LogoutForm(); // create new logout page
            LogoutControl.logout(Convert.ToInt32(this.editID));
            this.Close();             // close addtask page
            logoutform.Show();        // run logout page
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

        public string editID
        {
            get { return idLabel.Text; }
            set { idLabel.Text = value; }
        }
    }
}
