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
    public partial class Orders : Template
    {
        Form formtoopen;
        public Orders(MainMenu form)
        {
            InitializeComponent();
            formtoopen = form;
        }
        public override void ButtonBack_Click(object sender, EventArgs e)
        {
            formtoopen.Show();
            Close();
        }
    }
}
