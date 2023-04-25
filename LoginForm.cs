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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void submit(object sender, EventArgs e)
        {
            if (!LoginControl.login(txtbxEmpID.Text, txtbxPass.Text))
            {
                display();
            }
        }
        private void display()
        {
            ErrorMessage.Visible = true;
        }
    }
}
