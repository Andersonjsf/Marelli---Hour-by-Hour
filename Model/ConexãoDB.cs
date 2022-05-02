using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void TestConnection()
        {
            try
            {
                con.Open();
                MessageBox.Show("Conexão realizada com Sucesso.");
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel se conectar com o banco");
            }
        }
    }
}
