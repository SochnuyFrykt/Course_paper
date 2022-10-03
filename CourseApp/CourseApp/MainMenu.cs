﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseApp
{
    public partial class MainMenu : Template
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
        private void SingInButton_Click(object sender, EventArgs e)
        {
            var info = new InformationAboutObjects();
            info.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var monitoring = new Monitoring();
            monitoring.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var salary = new SalaryCalculation();
            salary.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var orders = new Orders();
            orders.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var docs = new Docs();
            docs.Show();
            Hide();

        }
    }
}