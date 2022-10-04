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
  public partial class MainMenuWorker : Template
  {
    Orders orders;
    public MainMenuWorker()
    {
      InitializeComponent();
      orders = new Orders(this);
    }

    private void MainMenuWorker_Load(object sender, EventArgs e)
    {

    }

    private void OrdersButton_Click(object sender, EventArgs e)
    {
      orders.Show();
      Hide();
    }
  }
}
