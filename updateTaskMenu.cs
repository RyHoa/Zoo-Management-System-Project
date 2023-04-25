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

        private void logout_Click(object sender, EventArgs e)
        {
            LogoutForm logoutform = new LogoutForm(); 
            LogoutControl.logout(Convert.ToInt32(this.editID));
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

        public string editID
        {
            get { return idLabel.Text; }
            set { idLabel.Text = value; }
        }
    }
}
