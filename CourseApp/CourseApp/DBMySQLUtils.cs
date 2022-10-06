using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SqlConn
{
  class DBMySQLUtils
  {
    MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=coursedb;user=sereb");

    public void openConnection()
    {
      if (connection.State == System.Data.ConnectionState.Closed)
        connection.Open();
    }
    public void closeConnection()
    {
      if (connection.State == System.Data.ConnectionState.Open)
        connection.Close();
    }
    public MySqlConnection GetConnection() => connection;
  }
}