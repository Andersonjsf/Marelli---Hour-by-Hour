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

        public string Cadastro(String Id, String Senha, String Turno, String Funcao)
        {
            var Hash = Security.Encrypt(Senha);
        
           this.Mensagem = LoginDao.Cadastro(Id, Hash, Turno, Funcao);
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

    }

}
    
