using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marelli___Hour_by_Hour.Model;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Data;

namespace Marelli___Hour_by_Hour.Controller

    
{
   
    public class Controle
    {
        Security security = new Security();
        LoginDaoComandos LoginDao = new LoginDaoComandos();

        public bool ExistNoBanco;
        public string Mensagem = "";
        

       


        public bool Acess(String Login, String senha)
        {
          var Hash  = Security.Encrypt(senha);
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            ExistNoBanco = LoginDao.VerificarLogin(Login, Hash);

            if (!LoginDao.Mensagem.Equals(""))
            {
                this.Mensagem = LoginDao.Mensagem;
                
            }
            
            return ExistNoBanco;
        }

        public string Cadastro(String NomeCompleto,String Id, String Senha, String Turno)
        {
            var Hash = Security.Encrypt(Senha);
        
           this.Mensagem = LoginDao.Cadastro(NomeCompleto,Id, Hash, Turno);
            if (LoginDao.ExistNoBanco)
            {
                this.ExistNoBanco = true;
            }
            return Mensagem; 
        }


        public List<string> GetInformacoes(string Id)
        {
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            var Infos = LoginDao.GetInfo(Id);
            return Infos;
        }

      
      public DataTable ListaMotivoParada()
        {
            var MotivoParada = LoginDao.ListaMotivoParada();

            return MotivoParada;
        }


        public string GravaRegistro(List<string> InfosRegistar)
        {
            var ResultadoInsert = LoginDao.GravaRegistro(InfosRegistar);

            return ResultadoInsert;
        }

        public DataTable VerificarReg(string IdRegistro, string Data, string Turno)
        {

            var Registro = LoginDao.VerificarRegistros(IdRegistro, Data, Turno);

           return Registro;

        }

        public void Log(string User, string IP, string Maquina, string Data)
        {
            LoginDao.CadastroLog(User, IP, Maquina, Data);
        }




    }

}
    
