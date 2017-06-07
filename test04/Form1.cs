using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test04
{
    public partial class Form1 : Form
    {
        Random r;
        public Form1()
        {
            InitializeComponent();
             r = new Random();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            int v = r.Next()%6;
            label1.Text = v.ToString();

        }
    }
}
