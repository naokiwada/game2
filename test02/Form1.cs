﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //回数の取得
                int kazu = int.Parse(textBox1.Text);
                //テキストのクリア
                label1.Text = "";
                //ループ
                for (int i = 0; i < kazu; i++)
                    label1.Text += "あ";
            }
            catch
            {
                label1.Text = "エラー";
            }
        }
    }
}
