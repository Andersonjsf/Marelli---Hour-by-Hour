using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marelli___Hour_by_Hour.Model;
using System.Data.SqlClient;

namespace Marelli___Hour_by_Hour.Controller
{
    public class Controle
    {

        public bool ExistNoBanco;
        public string Mensagem = "";
        

        LoginDaoComandos LoginDao = new LoginDaoComandos();


        public bool Acess(String Login, String senha)
        {
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            ExistNoBanco = LoginDao.VerificarLogin(Login, senha);

            if (!LoginDao.Mensagem.Equals(""))
            {
                this.Mensagem = LoginDao.Mensagem;
                
            }
            
            return ExistNoBanco;
        }

        public string Cadastro(String Id, String Senha, String Turno, String Funcao)
        {
            this.Mensagem = LoginDao.Cadastro(Id, Senha, Turno, Funcao);
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
       

  
    }
}
