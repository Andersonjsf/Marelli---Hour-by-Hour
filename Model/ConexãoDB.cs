using System;
using System.Collections.Generic;
using System.Configuration;
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
            string connString2 = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            con.ConnectionString = @connString2;
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
