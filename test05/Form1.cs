using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test05
{
    public partial class Form1 : Form
    {
        Random  r;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (r.Next() % 2 == 0)
            {
                label1.Text = "デスソース";
            }
            else
            {
                label1.Text = "シュネッケン";
            }
        }
    }
}
