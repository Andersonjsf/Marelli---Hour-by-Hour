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
using Marelli___Hour_by_Hour.Viewer;

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
            if (InformacoesUser[2] != turno)
            {
                var Result = MessageBox.Show("Você não pertence a este turno, quer continuar mesmo assim?", "Alertar de Turno", MessageBoxButtons.OKCancel);
                if (Result == DialogResult.Cancel)
                {
                    ComboBox_Turno.Text = "";
                }

            }
            SelecionaTurno(turno);

        }

        public void SelecionaTurno(string Turno)
        {
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


            switch (Turno)
            {
                case "Manhã":

                    GrupBox_TurnoTarde.Visible = false;
                  //  GrupBox_TurnoNoite.Visible = false;
                    GroupTurno_Manha.Visible = true;
                    //Instancia Code
                    CBBox_Cod1_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Cod1_Manha.DisplayMember = "Cod";
                    CBBox_Cod1_Manha.ValueMember = "Cod";
                    CBBox_Descricao1_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao1_Manha.DisplayMember = "Descricao";
                    CBBox_Descricao1_Manha.ValueMember = "Descricao";
                    //
                    CBBox_Cod2_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Cod2_Manha.DisplayMember = "Cod";
                    CBBox_Cod2_Manha.ValueMember = "Cod";
                    CBBox_Descricao2_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao2_Manha.DisplayMember = "Descricao";
                    CBBox_Descricao2_Manha.ValueMember = "Descricao";
                    //
                    CBBox_Cod3_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Cod3_Manha.DisplayMember = "Cod";
                    CBBox_Cod3_Manha.ValueMember = "Cod";
                    CBBox_Descricao3_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao3_Manha.DisplayMember = "Descricao";
                    CBBox_Descricao3_Manha.ValueMember = "Descricao";
                    //
                    CBBox_Cod4_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Cod4_Manha.DisplayMember = "Cod";
                    CBBox_Cod4_Manha.ValueMember = "Cod";
                    CBBox_Descricao4_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao4_Manha.DisplayMember = "Descricao";
                    CBBox_Descricao4_Manha.ValueMember = "Descricao";
                    //
                    CBBox_Cod5_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Cod5_Manha.DisplayMember = "Cod";
                    CBBox_Cod5_Manha.ValueMember = "Cod";
                    CBBox_Descricao5_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao5_Manha.DisplayMember = "Descricao";
                    CBBox_Descricao5_Manha.ValueMember = "Descricao";
                    //
                    CBBox_Cod6_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Cod6_Manha.DisplayMember = "Cod";
                    CBBox_Cod6_Manha.ValueMember = "Cod";
                    CBBox_Descricao6_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao6_Manha.DisplayMember = "Descricao";
                    CBBox_Descricao6_Manha.ValueMember = "Descricao";
                    //
                    CBBox_Cod7_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Cod7_Manha.DisplayMember = "Cod";
                    CBBox_Cod7_Manha.ValueMember = "Cod";
                    CBBox_Descricao7_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao7_Manha.DisplayMember = "Descricao";
                    CBBox_Descricao7_Manha.ValueMember = "Descricao";
                    //
                    CBBox_Cod8_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Cod8_Manha.DisplayMember = "Cod";
                    CBBox_Cod8_Manha.ValueMember = "Cod";
                    CBBox_Descricao8_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao8_Manha.DisplayMember = "Descricao";
                    CBBox_Descricao8_Manha.ValueMember = "Descricao";

                    //Verifica Dados
                    Registro1H = control.VerificarReg("1", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro1H.Rows.Count != 0)
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
                        CBBox_Cod1_Manha.Enabled = true;
                        CBBox_Descricao1_Manha.Enabled = true;
                        TxtBox_Producao1_Manha.Text = "";
                        TxtBox_Producao1_Manha.Enabled = true;
                        TxtBox_Retrabalho1_Manha.Text = "";
                        TxtBox_Retrabalho1_Manha.Enabled = true;
                        TxtBox_Equipamento1_Manha.Text = "";
                        TxtBox_Equipamento1_Manha.Enabled = true;
                        TxtBox_Tempo1_Manha.Text = "";
                        TxtBox_Tempo1_Manha.Enabled = true;
                        ButtonSalvar1_Manha.Enabled = true;

                    }
                    Registro2H = control.VerificarReg("2", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro2H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio2_Manha.Enabled = false;
                        TxtBox_HoraFim2_Manha.Enabled = false;
                        CBBox_Cod2_Manha.Text = Registro2H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod2_Manha.Enabled = false;
                        CBBox_Descricao2_Manha.Text = Registro2H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao2_Manha.Enabled = false;
                        TxtBox_Producao2_Manha.Text = Registro2H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao2_Manha.Enabled = false;
                        TxtBox_Retrabalho2_Manha.Text = Registro2H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho2_Manha.Enabled = false;
                        TxtBox_Equipamento2_Manha.Text = Registro2H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento2_Manha.Enabled = false;
                        TxtBox_Tempo2_Manha.Text = Registro2H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo2_Manha.Enabled = false;
                        ButtonSalvar2_Manha.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod2_Manha.Enabled = true;
                        CBBox_Descricao2_Manha.Enabled = true;
                        TxtBox_Producao2_Manha.Text = "";
                        TxtBox_Producao2_Manha.Enabled = true;
                        TxtBox_Retrabalho2_Manha.Text = "";
                        TxtBox_Retrabalho2_Manha.Enabled = true;
                        TxtBox_Equipamento2_Manha.Text = "";
                        TxtBox_Equipamento2_Manha.Enabled = true;
                        TxtBox_Tempo2_Manha.Text = "";
                        TxtBox_Tempo2_Manha.Enabled = true;
                        ButtonSalvar2_Manha.Enabled = true;
                    }
                    Registro3H = control.VerificarReg("3", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro3H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio3_Manha.Enabled = false;
                        TxtBox_HoraFim3_Manha.Enabled = false;
                        CBBox_Cod3_Manha.Text = Registro3H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod3_Manha.Enabled = false;
                        CBBox_Descricao3_Manha.Text = Registro3H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao3_Manha.Enabled = false;
                        TxtBox_Producao3_Manha.Text = Registro3H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao3_Manha.Enabled = false;
                        TxtBox_Retrabalho3_Manha.Text = Registro3H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho3_Manha.Enabled = false;
                        TxtBox_Equipamento3_Manha.Text = Registro3H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento3_Manha.Enabled = false;
                        TxtBox_Tempo3_Manha.Text = Registro3H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo3_Manha.Enabled = false;
                        ButtonSalvar3_Manha.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod3_Manha.Enabled = true;
                        CBBox_Descricao3_Manha.Enabled = true;
                        TxtBox_Producao3_Manha.Text = "";
                        TxtBox_Producao3_Manha.Enabled = true;
                        TxtBox_Retrabalho3_Manha.Text = "";
                        TxtBox_Retrabalho3_Manha.Enabled = true;
                        TxtBox_Equipamento3_Manha.Text = "";
                        TxtBox_Equipamento3_Manha.Enabled = true;
                        TxtBox_Tempo3_Manha.Text = "";
                        TxtBox_Tempo3_Manha.Enabled = true;
                        ButtonSalvar3_Manha.Enabled = true;
                    }
                    Registro4H = control.VerificarReg("4", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro4H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio4_Manha.Enabled = false;
                        TxtBox_HoraFim4_Manha.Enabled = false;
                        CBBox_Cod4_Manha.Text = Registro4H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod4_Manha.Enabled = false;
                        CBBox_Descricao4_Manha.Text = Registro4H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao4_Manha.Enabled = false;
                        TxtBox_Producao4_Manha.Text = Registro4H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao4_Manha.Enabled = false;
                        TxtBox_Retrabalho4_Manha.Text = Registro4H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho4_Manha.Enabled = false;
                        TxtBox_Equipamento4_Manha.Text = Registro4H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento4_Manha.Enabled = false;
                        TxtBox_Tempo4_Manha.Text = Registro4H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo4_Manha.Enabled = false;
                        ButtonSalvar4_Manha.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod4_Manha.Enabled = true;
                        CBBox_Descricao4_Manha.Enabled = true;
                        TxtBox_Producao4_Manha.Text = "";
                        TxtBox_Producao4_Manha.Enabled = true;
                        TxtBox_Retrabalho4_Manha.Text = "";
                        TxtBox_Retrabalho4_Manha.Enabled = true;
                        TxtBox_Equipamento4_Manha.Text = "";
                        TxtBox_Equipamento4_Manha.Enabled = true;
                        TxtBox_Tempo4_Manha.Text = "";
                        TxtBox_Tempo4_Manha.Enabled = true;
                        ButtonSalvar4_Manha.Enabled = true;
                    }
                    Registro5H = control.VerificarReg("5", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro5H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio5_Manha.Enabled = false;
                        TxtBox_HoraFim5_Manha.Enabled = false;
                        CBBox_Cod5_Manha.Text = Registro5H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod5_Manha.Enabled = false;
                        CBBox_Descricao5_Manha.Text = Registro5H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao5_Manha.Enabled = false;
                        TxtBox_Producao5_Manha.Text = Registro5H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao5_Manha.Enabled = false;
                        TxtBox_Retrabalho5_Manha.Text = Registro5H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho5_Manha.Enabled = false;
                        TxtBox_Equipamento5_Manha.Text = Registro5H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento5_Manha.Enabled = false;
                        TxtBox_Tempo5_Manha.Text = Registro5H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo5_Manha.Enabled = false;
                        ButtonSalvar5_Manha.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod5_Manha.Enabled = true;
                        CBBox_Descricao5_Manha.Enabled = true;
                        TxtBox_Producao5_Manha.Text = "";
                        TxtBox_Producao5_Manha.Enabled = true;
                        TxtBox_Retrabalho5_Manha.Text = "";
                        TxtBox_Retrabalho5_Manha.Enabled = true;
                        TxtBox_Equipamento5_Manha.Text = "";
                        TxtBox_Equipamento5_Manha.Enabled = true;
                        TxtBox_Tempo5_Manha.Text = "";
                        TxtBox_Tempo5_Manha.Enabled = true;
                        ButtonSalvar5_Manha.Enabled = true;
                    }
                    Registro6H = control.VerificarReg("6", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro6H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio6_Manha.Enabled = false;
                        TxtBox_HoraFim6_Manha.Enabled = false;
                        CBBox_Cod6_Manha.Text = Registro6H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod6_Manha.Enabled = false;
                        CBBox_Descricao6_Manha.Text = Registro6H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao6_Manha.Enabled = false;
                        TxtBox_Producao6_Manha.Text = Registro6H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao6_Manha.Enabled = false;
                        TxtBox_Retrabalho6_Manha.Text = Registro6H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho6_Manha.Enabled = false;
                        TxtBox_Equipamento6_Manha.Text = Registro6H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento6_Manha.Enabled = false;
                        TxtBox_Tempo6_Manha.Text = Registro6H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo6_Manha.Enabled = false;
                        ButtonSalvar6_Manha.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod6_Manha.Enabled = true;
                        CBBox_Descricao6_Manha.Enabled = true;
                        TxtBox_Producao6_Manha.Text = "";
                        TxtBox_Producao6_Manha.Enabled = true;
                        TxtBox_Retrabalho6_Manha.Text = "";
                        TxtBox_Retrabalho6_Manha.Enabled = true;
                        TxtBox_Equipamento6_Manha.Text = "";
                        TxtBox_Equipamento6_Manha.Enabled = true;
                        TxtBox_Tempo6_Manha.Text = "";
                        TxtBox_Tempo6_Manha.Enabled = true;
                        ButtonSalvar6_Manha.Enabled = true;
                    }
                    Registro7H = control.VerificarReg("7", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro7H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio7_Manha.Enabled = false;
                        TxtBox_HoraFim7_Manha.Enabled = false;
                        CBBox_Cod7_Manha.Text = Registro7H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod7_Manha.Enabled = false;
                        CBBox_Descricao7_Manha.Text = Registro7H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao7_Manha.Enabled = false;
                        TxtBox_Producao7_Manha.Text = Registro7H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao7_Manha.Enabled = false;
                        TxtBox_Retrabalho7_Manha.Text = Registro7H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho7_Manha.Enabled = false;
                        TxtBox_Equipamento7_Manha.Text = Registro7H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento7_Manha.Enabled = false;
                        TxtBox_Tempo7_Manha.Text = Registro7H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo7_Manha.Enabled = false;
                        ButtonSalvar7_Manha.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod7_Manha.Enabled = true;
                        CBBox_Descricao7_Manha.Enabled = true;
                        TxtBox_Producao7_Manha.Text = "";
                        TxtBox_Producao7_Manha.Enabled = true;
                        TxtBox_Retrabalho7_Manha.Text = "";
                        TxtBox_Retrabalho7_Manha.Enabled = true;
                        TxtBox_Equipamento7_Manha.Text = "";
                        TxtBox_Equipamento7_Manha.Enabled = true;
                        TxtBox_Tempo7_Manha.Text = "";
                        TxtBox_Tempo7_Manha.Enabled = true;
                        ButtonSalvar7_Manha.Enabled = true;
                    }
                    Registro8H = control.VerificarReg("8", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro8H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio8_Manha.Enabled = false;
                        TxtBox_HoraFim8_Manha.Enabled = false;
                        CBBox_Cod8_Manha.Text = Registro8H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod8_Manha.Enabled = false;
                        CBBox_Descricao8_Manha.Text = Registro8H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao8_Manha.Enabled = false;
                        TxtBox_Producao8_Manha.Text = Registro8H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao8_Manha.Enabled = false;
                        TxtBox_Retrabalho8_Manha.Text = Registro8H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho8_Manha.Enabled = false;
                        TxtBox_Equipamento8_Manha.Text = Registro8H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento8_Manha.Enabled = false;
                        TxtBox_Tempo8_Manha.Text = Registro8H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo8_Manha.Enabled = false;
                        ButtonSalvar8_Manha.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod8_Manha.Enabled = true;
                        CBBox_Descricao8_Manha.Enabled = true;
                        TxtBox_Producao8_Manha.Text = "";
                        TxtBox_Producao8_Manha.Enabled = true;
                        TxtBox_Retrabalho8_Manha.Text = "";
                        TxtBox_Retrabalho8_Manha.Enabled = true;
                        TxtBox_Equipamento8_Manha.Text = "";
                        TxtBox_Equipamento8_Manha.Enabled = true;
                        TxtBox_Tempo8_Manha.Text = "";
                        TxtBox_Tempo8_Manha.Enabled = true;
                        ButtonSalvar8_Manha.Enabled = true;
                    }
                    Registro9H = control.VerificarReg("9", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    Registro10H = control.VerificarReg("10", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    break;

                 //   case "Tarde":







            }
        }
        #region TURNOMANHA


        private void ButtonSalvar1_Manha_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CodigoMotivo CodMot = new CodigoMotivo();
            CodMot.Show();
        }

        private void ButtonSalvar2_Manha_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("2");
                Informações.Add(TxtBox_HoraIncio2_Manha.Text.Trim());
                Informações.Add(TxtBox_HoraFim2_Manha.Text.Trim());
                Informações.Add(CBBox_Cod2_Manha.Text.Trim());
                Informações.Add(CBBox_Descricao2_Manha.Text.Trim());
                Informações.Add(TxtBox_Producao2_Manha.Text.Trim());
                Informações.Add(TxtBox_Retrabalho2_Manha.Text.Trim());
                Informações.Add(TxtBox_Equipamento2_Manha.Text.Trim());
                Informações.Add(TxtBox_Tempo2_Manha.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        private void ButtonSalvar3_Manha_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("3");
                Informações.Add(TxtBox_HoraIncio3_Manha.Text.Trim());
                Informações.Add(TxtBox_HoraFim3_Manha.Text.Trim());
                Informações.Add(CBBox_Cod3_Manha.Text.Trim());
                Informações.Add(CBBox_Descricao3_Manha.Text.Trim());
                Informações.Add(TxtBox_Producao3_Manha.Text.Trim());
                Informações.Add(TxtBox_Retrabalho3_Manha.Text.Trim());
                Informações.Add(TxtBox_Equipamento3_Manha.Text.Trim());
                Informações.Add(TxtBox_Tempo3_Manha.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        private void ButtonSalvar4_Manha_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("4");
                Informações.Add(TxtBox_HoraIncio4_Manha.Text.Trim());
                Informações.Add(TxtBox_HoraFim4_Manha.Text.Trim());
                Informações.Add(CBBox_Cod4_Manha.Text.Trim());
                Informações.Add(CBBox_Descricao4_Manha.Text.Trim());
                Informações.Add(TxtBox_Producao4_Manha.Text.Trim());
                Informações.Add(TxtBox_Retrabalho4_Manha.Text.Trim());
                Informações.Add(TxtBox_Equipamento4_Manha.Text.Trim());
                Informações.Add(TxtBox_Tempo4_Manha.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        private void ButtonSalvar5_Manha_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("5");
                Informações.Add(TxtBox_HoraIncio5_Manha.Text.Trim());
                Informações.Add(TxtBox_HoraFim5_Manha.Text.Trim());
                Informações.Add(CBBox_Cod5_Manha.Text.Trim());
                Informações.Add(CBBox_Descricao5_Manha.Text.Trim());
                Informações.Add(TxtBox_Producao5_Manha.Text.Trim());
                Informações.Add(TxtBox_Retrabalho5_Manha.Text.Trim());
                Informações.Add(TxtBox_Equipamento5_Manha.Text.Trim());
                Informações.Add(TxtBox_Tempo5_Manha.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        private void ButtonSalvar6_Manha_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("6");
                Informações.Add(TxtBox_HoraIncio6_Manha.Text.Trim());
                Informações.Add(TxtBox_HoraFim6_Manha.Text.Trim());
                Informações.Add(CBBox_Cod6_Manha.Text.Trim());
                Informações.Add(CBBox_Descricao6_Manha.Text.Trim());
                Informações.Add(TxtBox_Producao6_Manha.Text.Trim());
                Informações.Add(TxtBox_Retrabalho6_Manha.Text.Trim());
                Informações.Add(TxtBox_Equipamento6_Manha.Text.Trim());
                Informações.Add(TxtBox_Tempo6_Manha.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        private void ButtonSalvar7_Manha_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("7");
                Informações.Add(TxtBox_HoraIncio7_Manha.Text.Trim());
                Informações.Add(TxtBox_HoraFim7_Manha.Text.Trim());
                Informações.Add(CBBox_Cod7_Manha.Text.Trim());
                Informações.Add(CBBox_Descricao7_Manha.Text.Trim());
                Informações.Add(TxtBox_Producao7_Manha.Text.Trim());
                Informações.Add(TxtBox_Retrabalho7_Manha.Text.Trim());
                Informações.Add(TxtBox_Equipamento7_Manha.Text.Trim());
                Informações.Add(TxtBox_Tempo7_Manha.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        private void ButtonSalvar8_Manha_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("8");
                Informações.Add(TxtBox_HoraIncio8_Manha.Text.Trim());
                Informações.Add(TxtBox_HoraFim8_Manha.Text.Trim());
                Informações.Add(CBBox_Cod8_Manha.Text.Trim());
                Informações.Add(CBBox_Descricao8_Manha.Text.Trim());
                Informações.Add(TxtBox_Producao8_Manha.Text.Trim());
                Informações.Add(TxtBox_Retrabalho8_Manha.Text.Trim());
                Informações.Add(TxtBox_Equipamento8_Manha.Text.Trim());
                Informações.Add(TxtBox_Tempo8_Manha.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

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

        private void CBBox_Cod2_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod2_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao2_Manha.SelectedIndex = CBBox_Cod2_Manha.SelectedIndex;

            }

        }

        private void CBBox_Descricao2_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao2_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod2_Manha.SelectedIndex = CBBox_Descricao2_Manha.SelectedIndex;
            }

        }
        private void CBBox_Cod3_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod3_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao3_Manha.SelectedIndex = CBBox_Cod3_Manha.SelectedIndex;

            }

        }

        private void CBBox_Descricao3_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao3_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod3_Manha.SelectedIndex = CBBox_Descricao3_Manha.SelectedIndex;
            }

        }
        private void CBBox_Cod4_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod4_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao4_Manha.SelectedIndex = CBBox_Cod4_Manha.SelectedIndex;

            }

        }

        private void CBBox_Descricao4_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao4_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod4_Manha.SelectedIndex = CBBox_Descricao4_Manha.SelectedIndex;
            }

        }
        private void CBBox_Cod5_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod5_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao5_Manha.SelectedIndex = CBBox_Cod5_Manha.SelectedIndex;

            }

        }

        private void CBBox_Descricao5_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao5_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod5_Manha.SelectedIndex = CBBox_Descricao5_Manha.SelectedIndex;
            }

        }
        private void CBBox_Cod6_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod6_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao6_Manha.SelectedIndex = CBBox_Cod6_Manha.SelectedIndex;

            }

        }

        private void CBBox_Descricao6_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao6_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod6_Manha.SelectedIndex = CBBox_Descricao6_Manha.SelectedIndex;
            }

        }
        private void CBBox_Cod7_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod7_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao7_Manha.SelectedIndex = CBBox_Cod7_Manha.SelectedIndex;

            }

        }

        private void CBBox_Descricao7_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao7_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod7_Manha.SelectedIndex = CBBox_Descricao7_Manha.SelectedIndex;
            }

        }

        private void CBBox_Cod8_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod8_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao8_Manha.SelectedIndex = CBBox_Cod8_Manha.SelectedIndex;

            }

        }

        private void CBBox_Descricao8_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao8_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod8_Manha.SelectedIndex = CBBox_Descricao8_Manha.SelectedIndex;
            }

        }




    
    }
    #endregion TURNOMANHA




}
