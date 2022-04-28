using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marelli___Hour_by_Hour.Model
{
   public class Conexão_DB
    {
        SqlConnection con = new SqlConnection();
        public Conexão_DB()
        {
            con.ConnectionString = @"Data Source=WINAPFAPLOKWZE7;Initial Catalog=DB_MARELLI_DEV;Integrated Security=True";
        }
        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconect()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
