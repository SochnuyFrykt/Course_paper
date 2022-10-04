﻿using System;
using System.IO;
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
  public partial class SalaryCalculation : Template
  {
    Form formtoopen;
    public SalaryCalculation(MainMenu form)
    {
      InitializeComponent();
      formtoopen = form;
    }
    public override void ButtonBack_Click(object sender, EventArgs e)
    {
      formtoopen.Show();
      Hide();
    }

    private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      object st = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
      File.WriteAllText(@"D:\c#\CourseApp\test.txt", st.ToString()); //Тестирую вывод введенной информации в файл
    }
  }
}
