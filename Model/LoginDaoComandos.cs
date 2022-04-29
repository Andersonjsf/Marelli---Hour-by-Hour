using System;
using System.Collections.Generic;
using System.Data.Common;
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
        public string user = "";
        public bool VerificarLogin(string Login, String senha)
        {
            cmd.CommandText = "Select * From Tb_Users where UserID = @Login AND Password = @senha";
            cmd.Parameters.AddWithValue("@Login", Login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                   
                    user = dr.GetString(dr.GetOrdinal("UserID")).Trim();
                    ExistNoBanco = true;
                }
                con.desconect();
                dr.Close();
            }
            catch (SqlException e)
            {

                this.Mensagem = "Erro com o banco de dados " + e;
            }

            return ExistNoBanco;
        }

        public string Cadastro(String Id, String Senha, String Turno, String Funcao)
        {
            ExistNoBanco = false;
            cmd.CommandText ="INSERT INTO [dbo].[Tb_Users] VALUES( @Login,@Senha,@Turno,@Funcao)";
            cmd.Parameters.AddWithValue("@Login", Id);
            cmd.Parameters.AddWithValue("@Senha", Senha);
            cmd.Parameters.AddWithValue("@Turno", Turno);
            cmd.Parameters.AddWithValue("@Funcao", Funcao);
            try
            {
                 cmd.Connection = con.Conectar();
                 cmd.ExecuteNonQuery();
                 con.desconect();
                 this.Mensagem = "Usuario " + Id + " Cadastrado com Sucesso";
                 ExistNoBanco = true;
            }
            catch (SqlException e)
            {

                this.Mensagem = "Erro com o banco de dados " + e;
            }
            return Mensagem;
        }

        public List<string> GetInfo(string Login)
        {
            List<string> InfosUser = new List<string>();

            cmd.CommandText = "Select * From Tb_Users where UserID = @Login";
            cmd.Parameters.AddWithValue("@Login", Login);

            try
            {
               
                cmd.Connection = con.Conectar();
                
                using (var r = cmd.ExecuteReader())
                {
                    foreach (DbDataRecord s in r)
                    {
                       
                       
                        string User = s.GetString(1).ToString().Trim();
                        InfosUser.Add(User);
                        string Turno = s.GetString(2).ToString().Trim();
                        InfosUser.Add(Turno);
                        string Func = s.GetString(3).ToString().Trim();
                        InfosUser.Add(Func);
                    }
                    r.Close();
                }

                con.desconect();
              
            }
            catch (SqlException e)
            {

                this.Mensagem = "Erro com o banco de dados " + e;
            }

            return InfosUser;
        }

    }
}

