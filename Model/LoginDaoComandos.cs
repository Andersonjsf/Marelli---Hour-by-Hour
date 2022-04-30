using System;
using System.Collections.Generic;
using System.Data;
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
                cmd.Dispose();
            }
            catch (SqlException e)
            {

                this.Mensagem = "Erro com o banco de dados " + e;
            }

            return ExistNoBanco;
        }

        public string Cadastro(String NomeCompleto,String Id, String Senha, String Turno)
        {
            ExistNoBanco = false;
            cmd.CommandText = "INSERT INTO [dbo].[Tb_Users] VALUES(@NomeCompleto, @Login,@Senha,@Turno)";
            cmd.Parameters.AddWithValue("@NomeCompleto", NomeCompleto);
            cmd.Parameters.AddWithValue("@Login", Id);
            cmd.Parameters.AddWithValue("@Senha", Senha);
            cmd.Parameters.AddWithValue("@Turno", Turno);
            
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
                        string FullName = s.GetString(1).ToString().Trim();
                        InfosUser.Add(FullName);

                        string User = s.GetString(2).ToString().Trim();
                        InfosUser.Add(User);

                        string Turno = s.GetString(4).ToString().Trim();
                        InfosUser.Add(Turno);
                    }
                    r.Close();
                }
                cmd.Dispose();
                con.desconect();
              
            }
            catch (SqlException e)
            {

                this.Mensagem = "Erro com o banco de dados " + e;
            }

            return InfosUser;
        }

        public DataTable VerificarRegistros(string IdRegistro, string Data, string Turno)
        {
            DataTable Registros = new DataTable();
            cmd.CommandText = "SELECT * FROM Tb_HistoricoRegistro WHERE DataRegistro = @DataRegistro AND Id = @IdRegistro AND Turno = @Turno";
            cmd.Parameters.AddWithValue("@DataRegistro", Data);
            cmd.Parameters.AddWithValue("@IdRegistro", IdRegistro);
            cmd.Parameters.AddWithValue("@Turno", Turno);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Registros.Load(dr);

                }
                cmd.Parameters.Clear();
                cmd.Dispose();
                con.desconect();
                dr.Close();
            }
            catch (SqlException e)
            {

                this.Mensagem = "Erro com o banco de dados " + e;
            }
            return Registros;
        }

        public string GravaRegistro(List<string> InfosRegistar)
        {
                ExistNoBanco = false;
                string DtRegistro = InfosRegistar[0].Trim();
                string Id = InfosRegistar[1].Trim();
                string HoraInicio = InfosRegistar[2].Trim();
                string HoraFim = InfosRegistar[3].Trim();
                string CodParada = InfosRegistar[4].Trim();
                string DescricaoParada = InfosRegistar[5].Trim();
                string Producao = InfosRegistar[6].Trim();
                string Retrabalho = InfosRegistar[7].Trim();
                string Equipamento = InfosRegistar[8].Trim();
                string Tempo = InfosRegistar[9].Trim();
                string Turno = InfosRegistar[10].Trim();


                cmd.CommandText = "INSERT INTO [dbo].[Tb_HistoricoRegistro] VALUES( @DtaRegistro, @Id, @HoraInicio, @HoraFim, @CodParada ,@DescricaoParada, @Producao, @Retrabalho, @Equipamento, @Tempo, @Turno)";
                cmd.Parameters.AddWithValue("@DtaRegistro", DtRegistro);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@HoraInicio", HoraInicio);
                cmd.Parameters.AddWithValue("@HoraFim", HoraFim);
                cmd.Parameters.AddWithValue("@CodParada", CodParada);
                cmd.Parameters.AddWithValue("@DescricaoParada", DescricaoParada);
                cmd.Parameters.AddWithValue("@Producao", Producao);
                cmd.Parameters.AddWithValue("@Retrabalho", Retrabalho);
                cmd.Parameters.AddWithValue("@Equipamento", Equipamento);
                cmd.Parameters.AddWithValue("@Tempo", Tempo);
                cmd.Parameters.AddWithValue("@Turno", Turno);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconect();
                cmd.Parameters.Clear();
                this.Mensagem = "Registros adicionados com sucesso.";
                ExistNoBanco = true;
            }
            catch (SqlException e)
            {

                this.Mensagem = "Erro com o banco de dados " + e;
            }
            return Mensagem;
        }

        public DataTable ListaMotivoParada()
        {
            DataTable MotivoParada = new DataTable();

            cmd.CommandText = "Select * From [Tb_MotivoParada]";

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MotivoParada.Load(dr);
               
                }
                cmd.Dispose();
                con.desconect();
                dr.Close();
            }
            catch (SqlException e)
            {

                this.Mensagem = "Erro com o banco de dados " + e;
            }
            return MotivoParada;
        }

           
        }


    }


