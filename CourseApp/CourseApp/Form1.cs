using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseApp;

namespace CourseApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Methods.SwitchColorButton(CloseButton);
			Methods.SwitchColorButton(HideButton);
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
			Hide();
		}

		private void SingUpBottom_Click(object sender, EventArgs e)
		{
			SingUpForm singUpForm = new SingUpForm();
			singUpForm.Show();
			Hide();
		}

		Point lastPoint;
		private void panel2_MouseMove(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				Left += e.X - lastPoint.X;
				Top += e.Y - lastPoint.Y;
			}
		}

		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		public Help help = new Help();
		private void ButtonHelp_Click(object sender, EventArgs e)
		{
			help.Show();
		}
	}
}
