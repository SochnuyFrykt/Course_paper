using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CourseApp
{
  public class Methods
  {
    public static void SwitchColorButton(Label button)
    {
      button.MouseEnter += (s, n) =>
        button.ForeColor = Color.FromArgb(149, 149, 149);
      button.MouseLeave += (s, n) =>
        button.ForeColor = Color.White;
    }
	}
}
