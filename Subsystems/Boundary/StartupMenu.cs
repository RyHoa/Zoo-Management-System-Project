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
    public partial class StartupMenu : Form
    {
   

        public StartupMenu()
        {
            InitializeComponent();
        }

        private void login(object sender, EventArgs e)
        {
            LoginControl.login();
            this.Close();
        }
    }
}
