using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooManagementSystemEntity;
using ZooManagementSystemControl;

namespace ZooManagementSystemBoundary
{
    public partial class LogoutForm : Form
    {
        public LogoutForm()
        {
            InitializeComponent();
        }

        private void formLogout_Load(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            StartupMenu returnHome = new StartupMenu();    // create 
            this.Close();                     // close the logout form
            Application.Run(returnHome);            // open startup menu again
        }
    }
}
