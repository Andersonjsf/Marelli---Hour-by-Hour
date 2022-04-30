using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Marelli___Hour_by_Hour.Controller;
using System.Data.SqlClient;

namespace Marelli___Hour_by_Hour
{
    public partial class Home : Form
    {
        List<string> InformacoesUser;
        Controle control = new Controle();


        public Home()
        {
            InitializeComponent();
          
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Login LoginScreen = new Login();
           

            LoginScreen.ShowDialog();
            this.Visible = true;
            InformacoesUser = control.GetInformacoes(LoginScreen.TxtBox_UserID.Text);
            Lb_user.Text = "-  Usuário " + InformacoesUser[1]; 
            
           
            Lb_DateToday.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Lb_OperadorNome.Text = InformacoesUser[0];     
            
        }

        private void ComboBox_Turno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string turno = ComboBox_Turno.Text;
            if(InformacoesUser[2] != turno)
            {
                var Result = MessageBox.Show("Você não pertence a este turno, quer continuar mesmo assim?","Alertar de Turno", MessageBoxButtons.OKCancel);
                if(Result == DialogResult.Cancel)
                {
                    ComboBox_Turno.Text = "";
                }
               
            }
            SelecionaTurno(turno);

        }

       
       
        private void CBBox_Cod1_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod1_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao1_Manha.SelectedIndex = CBBox_Cod1_Manha.SelectedIndex;

            }

        }

        private void CBBox_Descricao1_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao1_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod1_Manha.SelectedIndex = CBBox_Descricao1_Manha.SelectedIndex;
            }

        }



        public void SelecionaTurno(string Turno)
        {
          
           

            switch (Turno)
            {
                case "Manhã":
                    //Limpa Variaveis

                    DataTable Registro1H = null;
                    DataTable Registro2H = null;
                    DataTable Registro3H = null;
                    DataTable Registro4H = null;
                    DataTable Registro5H = null;
                    DataTable Registro6H = null;
                    DataTable Registro7H = null;
                    DataTable Registro8H = null; 
                    DataTable Registro9H = null;
                    DataTable Registro10H = null;

                    //Instancia Code

                    CBBox_Cod1_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Cod1_Manha.DisplayMember = "Cod";
                    CBBox_Cod1_Manha.ValueMember = "Cod";
                    CBBox_Descricao1_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao1_Manha.DisplayMember = "Descricao";
                    CBBox_Descricao1_Manha.ValueMember = "Descricao";

                    //Verifica Dados
                    Registro1H = control.VerificarReg("1", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if(Registro1H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio1_Manha.Enabled = false;
                        TxtBox_HoraFim1_Manha.Enabled = false;
                        CBBox_Cod1_Manha.Text = Registro1H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod1_Manha.Enabled = false;
                        CBBox_Descricao1_Manha.Text = Registro1H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao1_Manha.Enabled = false;
                        TxtBox_Producao1_Manha.Text = Registro1H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao1_Manha.Enabled = false;
                        TxtBox_Retrabalho1_Manha.Text = Registro1H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho1_Manha.Enabled = false;
                        TxtBox_Equipamento1_Manha.Text = Registro1H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento1_Manha.Enabled = false;
                        TxtBox_Tempo1_Manha.Text = Registro1H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo1_Manha.Enabled = false;
                        ButtonSalvar1_Manha.Enabled = false;

                    }
                    else
                    {
                      
                        //CBBox_Cod1_Manha.Text = Registro1H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod1_Manha.Enabled = true;
                     //   CBBox_Descricao1_Manha.Text = Registro1H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao1_Manha.Enabled = true;
                        TxtBox_Producao1_Manha.Text = "";
                        TxtBox_Producao1_Manha.Enabled = true;
                        TxtBox_Retrabalho1_Manha.Text  = "";
                        TxtBox_Retrabalho1_Manha.Enabled = true;
                        TxtBox_Equipamento1_Manha.Text = "";
                        TxtBox_Equipamento1_Manha.Enabled = true;
                        TxtBox_Tempo1_Manha.Text = "";
                        TxtBox_Tempo1_Manha.Enabled = true;
                        ButtonSalvar1_Manha.Enabled = true;

                    }
                     Registro2H = control.VerificarReg("2", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                     Registro3H = control.VerificarReg("3", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                     Registro4H = control.VerificarReg("4", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                     Registro5H = control.VerificarReg("5", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                     Registro6H = control.VerificarReg("6", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                     Registro7H = control.VerificarReg("7", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                     Registro8H = control.VerificarReg("8", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                     Registro9H = control.VerificarReg("9", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                     Registro10H = control.VerificarReg("10", DateTime.Now.ToString("dd/MM/yyyy"), Turno);


                    break;





                    
            }
        }

        private void ButtonSalvar1_Manha_Click(object sender, EventArgs e)
        {
         var ResultPopup =   MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("1");
                Informações.Add(TxtBox_HoraIncio1_Manha.Text.Trim());
                Informações.Add(TxtBox_HoraFim1_Manha.Text.Trim());
                Informações.Add(CBBox_Cod1_Manha.Text.Trim());
                Informações.Add(CBBox_Descricao1_Manha.Text.Trim());
                Informações.Add(TxtBox_Producao1_Manha.Text.Trim());
                Informações.Add(TxtBox_Retrabalho1_Manha.Text.Trim());
                Informações.Add(TxtBox_Equipamento1_Manha.Text.Trim());
                Informações.Add(TxtBox_Tempo1_Manha.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }
           

        }
    }
}
