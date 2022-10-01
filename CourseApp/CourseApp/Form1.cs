using System;
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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void HideButton_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void SingInButton_Click(object sender, EventArgs e)
		{
			SignInForm signInForm = new SignInForm();
			signInForm.Show();
			this.Hide();
		}

		private void SingUpBottom_Click(object sender, EventArgs e)
		{
			SingUpForm singUpForm = new SingUpForm();
			singUpForm.Show();
			this.Hide();
		}
	}
}
