﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADV
{
    public partial class Form1 : Form
    {
        int startPoint = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void Loading_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            ProgressBar.Value = startPoint;
            if (ProgressBar.Value == 100)
            {
                startPoint = 0;
                timer1.Stop();
                Login MyLogin = new Login();
                this.Hide();
                MyLogin.Show();
            }
        }
    }
}
