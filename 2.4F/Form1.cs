using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._4F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void But_Click(object sender, EventArgs e)
        {
            int n = 1;
            for (int i = 0; i <= 5; i++, V.Text += Environment.NewLine)
            {
                for (int j = 0; j <= 5 - n; j++)
                    V.Text +=j + " ";
                n++;
            }

        }
    }
}
