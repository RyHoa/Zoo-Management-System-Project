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
            StartController.initiate();
        }
    }
}
