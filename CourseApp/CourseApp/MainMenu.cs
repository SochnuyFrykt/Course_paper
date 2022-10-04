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
        InformationAboutObjects info;
        Monitoring monitoring;
        SalaryCalculation salary;
        Orders orders;
        Docs docs;
        public MainMenu()
        {
            InitializeComponent();
            info = new InformationAboutObjects(this);
            monitoring = new Monitoring(this);
            salary = new SalaryCalculation(this);
            orders = new Orders(this);
            docs = new Docs(this);
        }

        private void InfoAboutObjects_Click(object sender, EventArgs e)
        {
            info.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monitoring.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salary.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orders.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            docs.Show();
            Hide();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
