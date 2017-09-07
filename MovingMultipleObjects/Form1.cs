using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingMultipleObjects
{
    public partial class Form1 : Form
    {
        //Global Variables
        int L1x = 5;
        int L1y = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += L1x;
            label1.Top += L1y;
        }
    }
}
