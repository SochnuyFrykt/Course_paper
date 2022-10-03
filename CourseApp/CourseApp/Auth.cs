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
    public partial class Auth : AuthAndRegTemplate
    {
        public Auth()
        {
            InitializeComponent();
        }
        public override void ButtonBack_Click(object sender, EventArgs e)
        {
            var auth = new SignInForm();
            auth.Show();
            Close();
        }
    }
}
