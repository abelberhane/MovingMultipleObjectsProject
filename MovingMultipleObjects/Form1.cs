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

        int L2x = 5;
        int L2y = 5;

        int L3x = 5;
        int L3y = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Label 1 Movement Logic Begins
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
            // Label 1 Movement Logic Complete



            // Label 2 Movement Logic Begins
            label2.Left += L2x;
            label2.Top += L2y;

            // Inverts Direction if the label hits the border Width from left to right
            if (label2.Left + label2.Width > ClientSize.Width || label2.Left < 0)
            {
                L2x = -L2x;
            }

            // Inverts Direction if the labe hits the border Height from top to bottom
            if (label2.Top + label2.Height > ClientSize.Height || label2.Top < 0)
            {
                L2y = -L2y;
            }
            // Label 2 Movement Logic Complete



            // Label 3 Movement Logic Begins
            label3.Left += L3x;
            label3.Top += L3y;

            // Inverts Direction if the label hits the border Width from left to right
            if (label3.Left + label3.Width > ClientSize.Width || label3.Left < 0)
            {
                L3x = -L3x;
            }

            // Inverts Direction if the labe hits the border Height from top to bottom
            if (label3.Top + label3.Height > ClientSize.Height || label3.Top < 0)
            {
                L3y = -L3y;
            }
            // Label 3 Movement Logic Complete
        }
    }
}
