using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kadai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, f, g;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            // a = Double.Parse(textBox1.Text);
            // b = Double.Parse(textBox2.Text);
            c = a + b;
            d = a - b;
            f = a * b;
            g = a / b;
            label1.Text = c.ToString();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c, d, f, g;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            // a = Double.Parse(textBox1.Text);
            // b = Double.Parse(textBox2.Text);
            c = a + b;
            d = a - b;
            f = a * b;
            g = a / b;
            label1.Text = d.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, c, d, f, g;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            // a = Double.Parse(textBox1.Text);
            // b = Double.Parse(textBox2.Text);
            c = a + b;
            d = a - b;
            f = a * b;
            g = a / b;
            label1.Text = f.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, c, d, f, g;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            // a = Double.Parse(textBox1.Text);
            // b = Double.Parse(textBox2.Text);
            c = a + b;
            d = a - b;
            f = a * b;
            g = a / b;
            label1.Text = g.ToString();
        }
    }
}
