using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlConn;
using MySql.Data.MySqlClient;

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

        private void SingInButton_Click(object sender, EventArgs e)
        {

            string login = textBox4.Text;
            string password = textBox1.Text;

            DBMySQLUtils DBMySQLUtils = new DBMySQLUtils();
            MySqlConnection con = new MySqlConnection("database=coursedb");
            con.Open();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP",con);
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count>0)
            {
                var main = new MainMenu();
                main.Show();
                Close();
            }    
            else
                MessageBox.Show("Sosi pisю");
            con.Close();
        }
    }
}
