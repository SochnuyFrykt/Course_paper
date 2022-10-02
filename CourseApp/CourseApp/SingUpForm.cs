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
	public partial class SingUpForm : Form
	{
		public SingUpForm()
		{
			InitializeComponent();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void CloseButton_MouseEnter(object sender, EventArgs e)
		{
			CloseButton.ForeColor = Color.FromArgb(149, 149, 149);
		}

		private void CloseButton_MouseLeave(object sender, EventArgs e)
		{
			CloseButton.ForeColor = Color.White;
		}

		private void HideButton_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void HideButton_MouseEnter(object sender, EventArgs e)
		{
			HideButton.ForeColor = Color.FromArgb(149, 149, 149);
		}

		private void HideButton_MouseLeave(object sender, EventArgs e)
		{
			HideButton.ForeColor = Color.White;
		}

		private void ButtonBack_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			form1.Show();
		}
	}
}
