using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test01
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kazu = int.Parse(textBox1.Text);
            int kazu2 = int.Parse(textBox2.Text);
            label3.Text = String.Format("{0}",kazu + kazu2);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                int kazu = int.Parse(textBox1.Text);
                int kazu2 = int.Parse(textBox2.Text);
                label3.Text = String.Format("{0}", kazu + kazu2);
        }
      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int kazu = int.Parse(textBox1.Text);
            int kazu2 = int.Parse(textBox2.Text);
            label3.Text = String.Format("{0}", kazu + kazu2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            int kazu = int.Parse(textBox1.Text);
            int kazu2 = int.Parse(textBox2.Text);
            label3.Text = String.Format("{0}", kazu + kazu2);
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            int kazu = int.Parse(textBox1.Text);
            int kazu2 = int.Parse(textBox2.Text);
            label3.Text = String.Format("{0}", kazu + kazu2);
        }
    }
}
