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
            // Label 1 Movement Logic
            label1.Left += L1x;
            label1.Top += L1y;

            // Inverts Direction if the label hits the border Width from left to right
            if (label1.Left + label1.Width > ClientSize.Width || label1.Left < 0)
            {
                L1x = -L1x;
            }

            // Inverts Direction if the labe hits the border Height from top to bottom
            if (label1.Top + label1.Height > ClientSize.Height || label1.Top < 0)
            {
                L1y = -L1y;
            }
        }
    }
}
