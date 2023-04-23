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

        //private void LoginForm_Load(object sender, EventArgs e)
        //{
        //        
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //which button is this?

        }


        
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
           
            
            if (!LoginControl.login(txtbxEmpID.Text, txtbxPass.Text))
            {
                ErrorMessage.Visible = true;
            }
            //need to start moving to next form based on admin or employee
            //need to display error
        }
    }
}
