using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marelli___Hour_by_Hour.Model
{
    class LoginDaoComandos
    {
        public bool ExistNoBanco = false;
        public string Mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexão_DB con = new Conexão_DB();
        SqlDataReader dr;
        public bool VerificarLogin(string Login, String senha)
        {
            cmd.CommandText = "Select * From Tb_Users where UserID = @Login AND Password = @senha";
            cmd.Parameters.AddWithValue("@Login", Login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    ExistNoBanco = true;
                }
            }
            catch (SqlException e)
            {

                this.Mensagem = "Erro com o banco de dados " + e;
            }

            return ExistNoBanco;
        }

        public string Cadastro(String Id, String Senha, String Turno, String Funcao)
        {
            return Mensagem;
        }
    }
}
