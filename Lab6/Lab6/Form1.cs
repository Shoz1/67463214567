using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double t = 2+2;
            double d = t + t;
            double f = d + d;
            double s = f + f;
            double q = s + s;
            double g = q + q;
            double w = g + g;
            double h = w + w;
            double result = h + h;

            textBox1.Text = Convert.ToString(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double c = 2;
            

            double result = 1;
            for (int i = 0; i < 10; i++)
            {
                result *= 2;

                c = result;
            }

            textBox1.Text = Convert.ToString(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double c = Math.Pow(2, 10);

            textBox1.Text = Convert.ToString(c);
        }
    }
}
