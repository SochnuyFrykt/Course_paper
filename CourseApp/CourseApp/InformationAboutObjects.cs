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
    public partial class InformationAboutObjects : Template
    {
        Form formtoopen;
        public InformationAboutObjects(MainMenu form)
        {
            InitializeComponent();
            formtoopen = form;
        }
        public override void ButtonBack_Click(object sender, EventArgs e)
        {
            formtoopen.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
