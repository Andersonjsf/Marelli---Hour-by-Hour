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

        public void Home_Load(object sender, EventArgs e)
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

        public void ComboBox_Turno_SelectedIndexChanged(object sender, EventArgs e)
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
                    GroupTurno_Manha.BringToFront();
                    GroupTurno_Tarde.Visible = false;
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
                    //
                    CBBox_Cod9_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Cod9_Manha.DisplayMember = "Cod";
                    CBBox_Cod9_Manha.ValueMember = "Cod";
                    CBBox_Descricao9_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao9_Manha.DisplayMember = "Descricao";
                    CBBox_Descricao9_Manha.ValueMember = "Descricao";

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
                    if (Registro9H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio9_Manha.Enabled = false;
                        TxtBox_HoraFim9_Manha.Enabled = false;
                        CBBox_Cod9_Manha.Text = Registro9H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod9_Manha.Enabled = false;
                        CBBox_Descricao9_Manha.Text = Registro9H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao9_Manha.Enabled = false;
                        TxtBox_Producao9_Manha.Text = Registro9H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao9_Manha.Enabled = false;
                        TxtBox_Retrabalho9_Manha.Text = Registro9H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho9_Manha.Enabled = false;
                        TxtBox_Equipamento9_Manha.Text = Registro9H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Equipamento9_Manha.Enabled = false;
                        TxtBox_Tempo9_Manha.Text = Registro9H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo9_Manha.Enabled = false;
                        ButtonSalvar9_Manha.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod9_Manha.Enabled = true;
                        CBBox_Descricao9_Manha.Enabled = true;
                        TxtBox_Producao9_Manha.Text = "";
                        TxtBox_Producao9_Manha.Enabled = true;
                        TxtBox_Retrabalho9_Manha.Text = "";
                        TxtBox_Retrabalho9_Manha.Enabled = true;
                        TxtBox_Equipamento9_Manha.Text = "";
                        TxtBox_Equipamento9_Manha.Enabled = true;
                        TxtBox_Tempo9_Manha.Text = "";
                        TxtBox_Tempo9_Manha.Enabled = true;
                        ButtonSalvar9_Manha.Enabled = true;
                    }

                        break;

                    case "Tarde":
                    GroupTurno_Tarde.Visible = true;
                    GroupTurno_Tarde.BringToFront();
                    GroupTurno_Manha.Visible = false;

                    //Instancia Code
                    CBBox_Cod1_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Cod1_Tarde.DisplayMember = "Cod";
                    CBBox_Cod1_Tarde.ValueMember = "Cod";
                    CBBox_Descricao1_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao1_Tarde.DisplayMember = "Descricao";
                    CBBox_Descricao1_Tarde.ValueMember = "Descricao";
                    //
                    CBBox_Cod2_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Cod2_Tarde.DisplayMember = "Cod";
                    CBBox_Cod2_Tarde.ValueMember = "Cod";
                    CBBox_Descricao2_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao2_Tarde.DisplayMember = "Descricao";
                    CBBox_Descricao2_Tarde.ValueMember = "Descricao";
                    //
                    CBBox_Cod3_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Cod3_Tarde.DisplayMember = "Cod";
                    CBBox_Cod3_Tarde.ValueMember = "Cod";
                    CBBox_Descricao3_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao3_Tarde.DisplayMember = "Descricao";
                    CBBox_Descricao3_Tarde.ValueMember = "Descricao";
                    //
                    CBBox_Cod4_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Cod4_Tarde.DisplayMember = "Cod";
                    CBBox_Cod4_Tarde.ValueMember = "Cod";
                    CBBox_Descricao4_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao4_Tarde.DisplayMember = "Descricao";
                    CBBox_Descricao4_Tarde.ValueMember = "Descricao";
                    //
                    CBBox_Cod5_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Cod5_Tarde.DisplayMember = "Cod";
                    CBBox_Cod5_Tarde.ValueMember = "Cod";
                    CBBox_Descricao5_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao5_Tarde.DisplayMember = "Descricao";
                    CBBox_Descricao5_Tarde.ValueMember = "Descricao";
                    //
                    CBBox_Cod6_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Cod6_Tarde.DisplayMember = "Cod";
                    CBBox_Cod6_Tarde.ValueMember = "Cod";
                    CBBox_Descricao6_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao6_Tarde.DisplayMember = "Descricao";
                    CBBox_Descricao6_Tarde.ValueMember = "Descricao";
                    //
                    CBBox_Cod7_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Cod7_Tarde.DisplayMember = "Cod";
                    CBBox_Cod7_Tarde.ValueMember = "Cod";
                    CBBox_Descricao7_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao7_Tarde.DisplayMember = "Descricao";
                    CBBox_Descricao7_Tarde.ValueMember = "Descricao";
                    //
                    CBBox_Cod8_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Cod8_Tarde.DisplayMember = "Cod";
                    CBBox_Cod8_Tarde.ValueMember = "Cod";
                    CBBox_Descricao8_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao8_Tarde.DisplayMember = "Descricao";
                    CBBox_Descricao8_Tarde.ValueMember = "Descricao";
                    //
                    CBBox_Cod9_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Cod9_Tarde.DisplayMember = "Cod";
                    CBBox_Cod9_Tarde.ValueMember = "Cod";
                    CBBox_Descricao9_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao9_Tarde.DisplayMember = "Descricao";
                    CBBox_Descricao9_Tarde.ValueMember = "Descricao";
                    //
                    CBBox_Cod10_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Cod10_Tarde.DisplayMember = "Cod";
                    CBBox_Cod10_Tarde.ValueMember = "Cod";
                    CBBox_Descricao10_Tarde.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao10_Tarde.DisplayMember = "Descricao";
                    CBBox_Descricao10_Tarde.ValueMember = "Descricao";

                    //Verifica Dados
                    Registro1H = control.VerificarReg("1", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro1H.Rows.Count != 0)
                    {

                        CBBox_Cod1_Tarde.Text = Registro1H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod1_Tarde.Enabled = false;
                        CBBox_Descricao1_Tarde.Text = Registro1H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao1_Tarde.Enabled = false;
                        TxtBox_Producao1_Tarde.Text = Registro1H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao1_Tarde.Enabled = false;
                        TxtBox_Retrabalho1_Tarde.Text = Registro1H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho1_Tarde.Enabled = false;
                        TxtBox_Equipamento1_Tarde.Text = Registro1H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento1_Tarde.Enabled = false;
                        TxtBox_Tempo1_Tarde.Text = Registro1H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo1_Tarde.Enabled = false;
                        ButtonSalvar1_Tarde.Enabled = false;

                    }
                    else
                    {
                        TxtBox_HoraIncio1_Tarde.Enabled = true;
                        TxtBox_HoraFim1_Tarde.Enabled = true;
                        TxtBox_Producao1_Tarde.Text = "";
                        TxtBox_Producao1_Tarde.Enabled = true;
                        TxtBox_Retrabalho1_Tarde.Text = "";
                        TxtBox_Retrabalho1_Tarde.Enabled = true;
                        TxtBox_Equipamento1_Tarde.Text = "";
                        TxtBox_Equipamento1_Tarde.Enabled = true;
                        TxtBox_Tempo1_Tarde.Text = "";
                        TxtBox_Tempo1_Tarde.Enabled = true;
                        ButtonSalvar1_Tarde.Enabled = true;

                    }
                    Registro2H = control.VerificarReg("2", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro2H.Rows.Count != 0)
                    {
                        
                        CBBox_Cod2_Tarde.Text = Registro2H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod2_Tarde.Enabled = false;
                        CBBox_Descricao2_Tarde.Text = Registro2H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao2_Tarde.Enabled = false;
                        TxtBox_Producao2_Tarde.Text = Registro2H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao2_Tarde.Enabled = false;
                        TxtBox_Retrabalho2_Tarde.Text = Registro2H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho2_Tarde.Enabled = false;
                        TxtBox_Equipamento2_Tarde.Text = Registro2H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento2_Tarde.Enabled = false;
                        TxtBox_Tempo2_Tarde.Text = Registro2H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo2_Tarde.Enabled = false;
                        ButtonSalvar2_Tarde.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod2_Tarde.Enabled = true;
                        CBBox_Descricao2_Tarde.Enabled = true;
                        TxtBox_Producao2_Tarde.Text = "";
                        TxtBox_Producao2_Tarde.Enabled = true;
                        TxtBox_Retrabalho2_Tarde.Text = "";
                        TxtBox_Retrabalho2_Tarde.Enabled = true;
                        TxtBox_Equipamento2_Tarde.Text = "";
                        TxtBox_Equipamento2_Tarde.Enabled = true;
                        TxtBox_Tempo2_Tarde.Text = "";
                        TxtBox_Tempo2_Tarde.Enabled = true;
                        ButtonSalvar2_Tarde.Enabled = true;
                    }
                    Registro3H = control.VerificarReg("3", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro3H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio3_Tarde.Enabled = false;
                        TxtBox_HoraFim3_Tarde.Enabled = false;
                        CBBox_Cod3_Tarde.Text = Registro3H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod3_Tarde.Enabled = false;
                        CBBox_Descricao3_Tarde.Text = Registro3H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao3_Tarde.Enabled = false;
                        TxtBox_Producao3_Tarde.Text = Registro3H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao3_Tarde.Enabled = false;
                        TxtBox_Retrabalho3_Tarde.Text = Registro3H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho3_Tarde.Enabled = false;
                        TxtBox_Equipamento3_Tarde.Text = Registro3H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento3_Tarde.Enabled = false;
                        TxtBox_Tempo3_Tarde.Text = Registro3H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo3_Tarde.Enabled = false;
                        ButtonSalvar3_Tarde.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod3_Tarde.Enabled = true;
                        CBBox_Descricao3_Tarde.Enabled = true;
                        TxtBox_Producao3_Tarde.Text = "";
                        TxtBox_Producao3_Tarde.Enabled = true;
                        TxtBox_Retrabalho3_Tarde.Text = "";
                        TxtBox_Retrabalho3_Tarde.Enabled = true;
                        TxtBox_Equipamento3_Tarde.Text = "";
                        TxtBox_Equipamento3_Tarde.Enabled = true;
                        TxtBox_Tempo3_Tarde.Text = "";
                        TxtBox_Tempo3_Tarde.Enabled = true;
                        ButtonSalvar3_Tarde.Enabled = true;
                    }
                    Registro4H = control.VerificarReg("4", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro4H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio4_Tarde.Enabled = false;
                        TxtBox_HoraFim4_Tarde.Enabled = false;
                        CBBox_Cod4_Tarde.Text = Registro4H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod4_Tarde.Enabled = false;
                        CBBox_Descricao4_Tarde.Text = Registro4H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao4_Tarde.Enabled = false;
                        TxtBox_Producao4_Tarde.Text = Registro4H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao4_Tarde.Enabled = false;
                        TxtBox_Retrabalho4_Tarde.Text = Registro4H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho4_Tarde.Enabled = false;
                        TxtBox_Equipamento4_Tarde.Text = Registro4H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento4_Tarde.Enabled = false;
                        TxtBox_Tempo4_Tarde.Text = Registro4H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo4_Tarde.Enabled = false;
                        ButtonSalvar4_Tarde.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod4_Tarde.Enabled = true;
                        CBBox_Descricao4_Tarde.Enabled = true;
                        TxtBox_Producao4_Tarde.Text = "";
                        TxtBox_Producao4_Tarde.Enabled = true;
                        TxtBox_Retrabalho4_Tarde.Text = "";
                        TxtBox_Retrabalho4_Tarde.Enabled = true;
                        TxtBox_Equipamento4_Tarde.Text = "";
                        TxtBox_Equipamento4_Tarde.Enabled = true;
                        TxtBox_Tempo4_Tarde.Text = "";
                        TxtBox_Tempo4_Tarde.Enabled = true;
                        ButtonSalvar4_Tarde.Enabled = true;
                    }
                    Registro5H = control.VerificarReg("5", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro5H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio5_Tarde.Enabled = false;
                        TxtBox_HoraFim5_Tarde.Enabled = false;
                        CBBox_Cod5_Tarde.Text = Registro5H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod5_Tarde.Enabled = false;
                        CBBox_Descricao5_Tarde.Text = Registro5H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao5_Tarde.Enabled = false;
                        TxtBox_Producao5_Tarde.Text = Registro5H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao5_Tarde.Enabled = false;
                        TxtBox_Retrabalho5_Tarde.Text = Registro5H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho5_Tarde.Enabled = false;
                        TxtBox_Equipamento5_Tarde.Text = Registro5H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento5_Tarde.Enabled = false;
                        TxtBox_Tempo5_Tarde.Text = Registro5H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo5_Tarde.Enabled = false;
                        ButtonSalvar5_Tarde.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod5_Tarde.Enabled = true;
                        CBBox_Descricao5_Tarde.Enabled = true;
                        TxtBox_Producao5_Tarde.Text = "";
                        TxtBox_Producao5_Tarde.Enabled = true;
                        TxtBox_Retrabalho5_Tarde.Text = "";
                        TxtBox_Retrabalho5_Tarde.Enabled = true;
                        TxtBox_Equipamento5_Tarde.Text = "";
                        TxtBox_Equipamento5_Tarde.Enabled = true;
                        TxtBox_Tempo5_Tarde.Text = "";
                        TxtBox_Tempo5_Tarde.Enabled = true;
                        ButtonSalvar5_Tarde.Enabled = true;
                    }
                    Registro6H = control.VerificarReg("6", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro6H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio6_Tarde.Enabled = false;
                        TxtBox_HoraFim6_Tarde.Enabled = false;
                        CBBox_Cod6_Tarde.Text = Registro6H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod6_Tarde.Enabled = false;
                        CBBox_Descricao6_Tarde.Text = Registro6H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao6_Tarde.Enabled = false;
                        TxtBox_Producao6_Tarde.Text = Registro6H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao6_Tarde.Enabled = false;
                        TxtBox_Retrabalho6_Tarde.Text = Registro6H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho6_Tarde.Enabled = false;
                        TxtBox_Equipamento6_Tarde.Text = Registro6H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento6_Tarde.Enabled = false;
                        TxtBox_Tempo6_Tarde.Text = Registro6H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo6_Tarde.Enabled = false;
                        ButtonSalvar6_Tarde.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod6_Tarde.Enabled = true;
                        CBBox_Descricao6_Tarde.Enabled = true;
                        TxtBox_Producao6_Tarde.Text = "";
                        TxtBox_Producao6_Tarde.Enabled = true;
                        TxtBox_Retrabalho6_Tarde.Text = "";
                        TxtBox_Retrabalho6_Tarde.Enabled = true;
                        TxtBox_Equipamento6_Tarde.Text = "";
                        TxtBox_Equipamento6_Tarde.Enabled = true;
                        TxtBox_Tempo6_Tarde.Text = "";
                        TxtBox_Tempo6_Tarde.Enabled = true;
                        ButtonSalvar6_Tarde.Enabled = true;
                    }
                    Registro7H = control.VerificarReg("7", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro7H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio7_Tarde.Enabled = false;
                        TxtBox_HoraFim7_Tarde.Enabled = false;
                        CBBox_Cod7_Tarde.Text = Registro7H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod7_Tarde.Enabled = false;
                        CBBox_Descricao7_Tarde.Text = Registro7H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao7_Tarde.Enabled = false;
                        TxtBox_Producao7_Tarde.Text = Registro7H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao7_Tarde.Enabled = false;
                        TxtBox_Retrabalho7_Tarde.Text = Registro7H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho7_Tarde.Enabled = false;
                        TxtBox_Equipamento7_Tarde.Text = Registro7H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento7_Tarde.Enabled = false;
                        TxtBox_Tempo7_Tarde.Text = Registro7H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo7_Tarde.Enabled = false;
                        ButtonSalvar7_Tarde.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod7_Tarde.Enabled = true;
                        CBBox_Descricao7_Tarde.Enabled = true;
                        TxtBox_Producao7_Tarde.Text = "";
                        TxtBox_Producao7_Tarde.Enabled = true;
                        TxtBox_Retrabalho7_Tarde.Text = "";
                        TxtBox_Retrabalho7_Tarde.Enabled = true;
                        TxtBox_Equipamento7_Tarde.Text = "";
                        TxtBox_Equipamento7_Tarde.Enabled = true;
                        TxtBox_Tempo7_Tarde.Text = "";
                        TxtBox_Tempo7_Tarde.Enabled = true;
                        ButtonSalvar7_Tarde.Enabled = true;
                    }
                    Registro8H = control.VerificarReg("8", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro8H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio6_Tarde.Enabled = false;
                        TxtBox_HoraFim8_Tarde.Enabled = false;
                        CBBox_Cod8_Tarde.Text = Registro8H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod8_Tarde.Enabled = false;
                        CBBox_Descricao8_Tarde.Text = Registro8H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao8_Tarde.Enabled = false;
                        TxtBox_Producao8_Tarde.Text = Registro8H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao8_Tarde.Enabled = false;
                        TxtBox_Retrabalho8_Tarde.Text = Registro8H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho8_Tarde.Enabled = false;
                        TxtBox_Equipamento8_Tarde.Text = Registro8H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento8_Tarde.Enabled = false;
                        TxtBox_Tempo8_Tarde.Text = Registro8H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo8_Tarde.Enabled = false;
                        ButtonSalvar8_Tarde.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod8_Tarde.Enabled = true;
                        CBBox_Descricao8_Tarde.Enabled = true;
                        TxtBox_Producao8_Tarde.Text = "";
                        TxtBox_Producao8_Tarde.Enabled = true;
                        TxtBox_Retrabalho8_Tarde.Text = "";
                        TxtBox_Retrabalho8_Tarde.Enabled = true;
                        TxtBox_Equipamento8_Tarde.Text = "";
                        TxtBox_Equipamento8_Tarde.Enabled = true;
                        TxtBox_Tempo8_Tarde.Text = "";
                        TxtBox_Tempo8_Tarde.Enabled = true;
                        ButtonSalvar8_Tarde.Enabled = true;
                    }
                    Registro9H = control.VerificarReg("9", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro9H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio6_Tarde.Enabled = false;
                        TxtBox_HoraFim9_Tarde.Enabled = false;
                        CBBox_Cod9_Tarde.Text = Registro9H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod9_Tarde.Enabled = false;
                        CBBox_Descricao9_Tarde.Text = Registro9H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao9_Tarde.Enabled = false;
                        TxtBox_Producao9_Tarde.Text = Registro9H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao9_Tarde.Enabled = false;
                        TxtBox_Retrabalho9_Tarde.Text = Registro9H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho9_Tarde.Enabled = false;
                        TxtBox_Equipamento9_Tarde.Text = Registro9H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Equipamento9_Tarde.Enabled = false;
                        TxtBox_Tempo9_Tarde.Text = Registro9H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo9_Tarde.Enabled = false;
                        ButtonSalvar9_Tarde.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod9_Tarde.Enabled = true;
                        CBBox_Descricao9_Tarde.Enabled = true;
                        TxtBox_Producao9_Tarde.Text = "";
                        TxtBox_Producao9_Tarde.Enabled = true;
                        TxtBox_Retrabalho9_Tarde.Text = "";
                        TxtBox_Retrabalho9_Tarde.Enabled = true;
                        TxtBox_Equipamento9_Tarde.Text = "";
                        TxtBox_Equipamento9_Tarde.Enabled = true;
                        TxtBox_Tempo9_Tarde.Text = "";
                        TxtBox_Tempo9_Tarde.Enabled = true;
                        ButtonSalvar9_Tarde.Enabled = true;
                    }
                    Registro10H = control.VerificarReg("10", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro10H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio6_Tarde.Enabled = false;
                        TxtBox_HoraFim10_Tarde.Enabled = false;
                        CBBox_Cod10_Tarde.Text = Registro10H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod10_Tarde.Enabled = false;
                        CBBox_Descricao10_Tarde.Text = Registro10H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao10_Tarde.Enabled = false;
                        TxtBox_Producao10_Tarde.Text = Registro10H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao10_Tarde.Enabled = false;
                        TxtBox_Retrabalho10_Tarde.Text = Registro10H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho10_Tarde.Enabled = false;
                        TxtBox_Equipamento10_Tarde.Text = Registro10H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento10_Tarde.Enabled = false;
                        TxtBox_Tempo10_Tarde.Text = Registro10H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo10_Tarde.Enabled = false;
                        ButtonSalvar10_Tarde.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod10_Tarde.Enabled = true;
                        CBBox_Descricao10_Tarde.Enabled = true;
                        TxtBox_Producao10_Tarde.Text = "";
                        TxtBox_Producao10_Tarde.Enabled = true;
                        TxtBox_Retrabalho10_Tarde.Text = "";
                        TxtBox_Retrabalho10_Tarde.Enabled = true;
                        TxtBox_Equipamento10_Tarde.Text = "";
                        TxtBox_Equipamento10_Tarde.Enabled = true;
                        TxtBox_Tempo10_Tarde.Text = "";
                        TxtBox_Tempo10_Tarde.Enabled = true;
                        ButtonSalvar10_Tarde.Enabled = true;
                    }
                    break;

                case "Noite":
                    GroupTurno_Noite.Visible = true;
                    GroupTurno_Noite.BringToFront();
                   // GroupTurno_Manha.Visible = false;
                  //  GroupTurno_Tarde.Visible = false;

                    //Instancia Code
                    CBBox_Cod1_Noite.DataSource = control.ListaMotivoParada();
                    CBBox_Cod1_Noite.DisplayMember = "Cod";
                    CBBox_Cod1_Noite.ValueMember = "Cod";
                    CBBox_Descricao1_Noite.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao1_Noite.DisplayMember = "Descricao";
                    CBBox_Descricao1_Noite.ValueMember = "Descricao";
                    //
                    CBBox_Cod2_Noite.DataSource = control.ListaMotivoParada();
                    CBBox_Cod2_Noite.DisplayMember = "Cod";
                    CBBox_Cod2_Noite.ValueMember = "Cod";
                    CBBox_Descricao2_Noite.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao2_Noite.DisplayMember = "Descricao";
                    CBBox_Descricao2_Noite.ValueMember = "Descricao";
                    //
                    CBBox_Cod3_Noite.DataSource = control.ListaMotivoParada();
                    CBBox_Cod3_Noite.DisplayMember = "Cod";
                    CBBox_Cod3_Noite.ValueMember = "Cod";
                    CBBox_Descricao3_Noite.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao3_Noite.DisplayMember = "Descricao";
                    CBBox_Descricao3_Noite.ValueMember = "Descricao";
                    //
                    CBBox_Cod4_Noite.DataSource = control.ListaMotivoParada();
                    CBBox_Cod4_Noite.DisplayMember = "Cod";
                    CBBox_Cod4_Noite.ValueMember = "Cod";
                    CBBox_Descricao4_Noite.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao4_Noite.DisplayMember = "Descricao";
                    CBBox_Descricao4_Noite.ValueMember = "Descricao";
                    //
                    CBBox_Cod5_Noite.DataSource = control.ListaMotivoParada();
                    CBBox_Cod5_Noite.DisplayMember = "Cod";
                    CBBox_Cod5_Noite.ValueMember = "Cod";
                    CBBox_Descricao5_Noite.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao5_Noite.DisplayMember = "Descricao";
                    CBBox_Descricao5_Noite.ValueMember = "Descricao";

                    //Verifica Dados
                    Registro1H = control.VerificarReg("1", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro1H.Rows.Count != 0)
                    {

                        CBBox_Cod1_Noite.Text = Registro1H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod1_Noite.Enabled = false;
                        CBBox_Descricao1_Noite.Text = Registro1H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao1_Noite.Enabled = false;
                        TxtBox_Producao1_Noite.Text = Registro1H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao1_Noite.Enabled = false;
                        TxtBox_Retrabalho1_Noite.Text = Registro1H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho1_Noite.Enabled = false;
                        TxtBox_Equipamento1_Noite.Text = Registro1H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento1_Noite.Enabled = false;
                        TxtBox_Tempo1_Noite.Text = Registro1H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo1_Noite.Enabled = false;
                        ButtonSalvar1_Noite.Enabled = false;

                    }
                    else
                    {
                        TxtBox_HoraIncio1_Noite.Enabled = true;
                        TxtBox_HoraFim1_Noite.Enabled = true;
                        TxtBox_Producao1_Noite.Text = "";
                        TxtBox_Producao1_Noite.Enabled = true;
                        TxtBox_Retrabalho1_Noite.Text = "";
                        TxtBox_Retrabalho1_Noite.Enabled = true;
                        TxtBox_Equipamento1_Noite.Text = "";
                        TxtBox_Equipamento1_Noite.Enabled = true;
                        TxtBox_Tempo1_Noite.Text = "";
                        TxtBox_Tempo1_Noite.Enabled = true;
                        ButtonSalvar1_Noite.Enabled = true;

                    }
                    Registro2H = control.VerificarReg("2", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro2H.Rows.Count != 0)
                    {

                        CBBox_Cod2_Noite.Text = Registro2H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod2_Noite.Enabled = false;
                        CBBox_Descricao2_Noite.Text = Registro2H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao2_Noite.Enabled = false;
                        TxtBox_Producao2_Noite.Text = Registro2H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao2_Noite.Enabled = false;
                        TxtBox_Retrabalho2_Noite.Text = Registro2H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho2_Noite.Enabled = false;
                        TxtBox_Equipamento2_Noite.Text = Registro2H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento2_Noite.Enabled = false;
                        TxtBox_Tempo2_Noite.Text = Registro2H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo2_Noite.Enabled = false;
                        ButtonSalvar2_Noite.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod2_Noite.Enabled = true;
                        CBBox_Descricao2_Noite.Enabled = true;
                        TxtBox_Producao2_Noite.Text = "";
                        TxtBox_Producao2_Noite.Enabled = true;
                        TxtBox_Retrabalho2_Noite.Text = "";
                        TxtBox_Retrabalho2_Noite.Enabled = true;
                        TxtBox_Equipamento2_Noite.Text = "";
                        TxtBox_Equipamento2_Noite.Enabled = true;
                        TxtBox_Tempo2_Noite.Text = "";
                        TxtBox_Tempo2_Noite.Enabled = true;
                        ButtonSalvar2_Noite.Enabled = true;
                    }
                    Registro3H = control.VerificarReg("3", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro3H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio3_Noite.Enabled = false;
                        TxtBox_HoraFim3_Noite.Enabled = false;
                        CBBox_Cod3_Noite.Text = Registro3H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod3_Noite.Enabled = false;
                        CBBox_Descricao3_Noite.Text = Registro3H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao3_Noite.Enabled = false;
                        TxtBox_Producao3_Noite.Text = Registro3H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao3_Noite.Enabled = false;
                        TxtBox_Retrabalho3_Noite.Text = Registro3H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho3_Noite.Enabled = false;
                        TxtBox_Equipamento3_Noite.Text = Registro3H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento3_Noite.Enabled = false;
                        TxtBox_Tempo3_Noite.Text = Registro3H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo3_Noite.Enabled = false;
                        ButtonSalvar3_Noite.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod3_Noite.Enabled = true;
                        CBBox_Descricao3_Noite.Enabled = true;
                        TxtBox_Producao3_Noite.Text = "";
                        TxtBox_Producao3_Noite.Enabled = true;
                        TxtBox_Retrabalho3_Noite.Text = "";
                        TxtBox_Retrabalho3_Noite.Enabled = true;
                        TxtBox_Equipamento3_Noite.Text = "";
                        TxtBox_Equipamento3_Noite.Enabled = true;
                        TxtBox_Tempo3_Noite.Text = "";
                        TxtBox_Tempo3_Noite.Enabled = true;
                        ButtonSalvar3_Noite.Enabled = true;
                    }
                    Registro4H = control.VerificarReg("4", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro4H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio4_Noite.Enabled = false;
                        TxtBox_HoraFim4_Noite.Enabled = false;
                        CBBox_Cod4_Noite.Text = Registro4H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod4_Noite.Enabled = false;
                        CBBox_Descricao4_Noite.Text = Registro4H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao4_Noite.Enabled = false;
                        TxtBox_Producao4_Noite.Text = Registro4H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao4_Noite.Enabled = false;
                        TxtBox_Retrabalho4_Noite.Text = Registro4H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho4_Noite.Enabled = false;
                        TxtBox_Equipamento4_Noite.Text = Registro4H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento4_Noite.Enabled = false;
                        TxtBox_Tempo4_Noite.Text = Registro4H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo4_Noite.Enabled = false;
                        ButtonSalvar4_Noite.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod4_Noite.Enabled = true;
                        CBBox_Descricao4_Noite.Enabled = true;
                        TxtBox_Producao4_Noite.Text = "";
                        TxtBox_Producao4_Noite.Enabled = true;
                        TxtBox_Retrabalho4_Noite.Text = "";
                        TxtBox_Retrabalho4_Noite.Enabled = true;
                        TxtBox_Equipamento4_Noite.Text = "";
                        TxtBox_Equipamento4_Noite.Enabled = true;
                        TxtBox_Tempo4_Noite.Text = "";
                        TxtBox_Tempo4_Noite.Enabled = true;
                        ButtonSalvar4_Noite.Enabled = true;
                    }
                    Registro5H = control.VerificarReg("5", DateTime.Now.ToString("dd/MM/yyyy"), Turno);
                    if (Registro5H.Rows.Count != 0)
                    {
                        TxtBox_HoraIncio5_Noite.Enabled = false;
                        TxtBox_HoraFim5_Noite.Enabled = false;
                        CBBox_Cod5_Noite.Text = Registro5H.Rows[0].ItemArray[4].ToString();
                        CBBox_Cod5_Noite.Enabled = false;
                        CBBox_Descricao5_Noite.Text = Registro5H.Rows[0].ItemArray[5].ToString();
                        CBBox_Descricao5_Noite.Enabled = false;
                        TxtBox_Producao5_Noite.Text = Registro5H.Rows[0].ItemArray[6].ToString();
                        TxtBox_Producao5_Noite.Enabled = false;
                        TxtBox_Retrabalho5_Noite.Text = Registro5H.Rows[0].ItemArray[7].ToString();
                        TxtBox_Retrabalho5_Noite.Enabled = false;
                        TxtBox_Equipamento5_Noite.Text = Registro5H.Rows[0].ItemArray[8].ToString();
                        TxtBox_Equipamento5_Noite.Enabled = false;
                        TxtBox_Tempo5_Noite.Text = Registro5H.Rows[0].ItemArray[9].ToString();
                        TxtBox_Tempo5_Noite.Enabled = false;
                        ButtonSalvar5_Noite.Enabled = false;

                    }
                    else
                    {
                        CBBox_Cod5_Noite.Enabled = true;
                        CBBox_Descricao5_Noite.Enabled = true;
                        TxtBox_Producao5_Noite.Text = "";
                        TxtBox_Producao5_Noite.Enabled = true;
                        TxtBox_Retrabalho5_Noite.Text = "";
                        TxtBox_Retrabalho5_Noite.Enabled = true;
                        TxtBox_Equipamento5_Noite.Text = "";
                        TxtBox_Equipamento5_Noite.Enabled = true;
                        TxtBox_Tempo5_Noite.Text = "";
                        TxtBox_Tempo5_Noite.Enabled = true;
                        ButtonSalvar5_Noite.Enabled = true;
                    }

                    break;






            }
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Deseja fazer logout?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                this.Close();
              
            }
            
        }

        #region TURNOMANHA


        public void ButtonSalvar1_Manha_Click(object sender, EventArgs e)
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
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }


        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {
            CodigoMotivo CodMot = new CodigoMotivo();
            CodMot.Show();
        }

        public void ButtonSalvar2_Manha_Click(object sender, EventArgs e)
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
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar3_Manha_Click(object sender, EventArgs e)
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
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar4_Manha_Click(object sender, EventArgs e)
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
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar5_Manha_Click(object sender, EventArgs e)
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
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar6_Manha_Click(object sender, EventArgs e)
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
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar7_Manha_Click(object sender, EventArgs e)
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
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar8_Manha_Click(object sender, EventArgs e)
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
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }
        public void ButtonSalvar9_Manha_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("9");
                Informações.Add(TxtBox_HoraIncio8_Manha.Text.Trim());
                Informações.Add(TxtBox_HoraFim8_Manha.Text.Trim());
                Informações.Add(CBBox_Cod8_Manha.Text.Trim());
                Informações.Add(CBBox_Descricao8_Manha.Text.Trim());
                Informações.Add(TxtBox_Producao8_Manha.Text.Trim());
                Informações.Add(TxtBox_Retrabalho8_Manha.Text.Trim());
                Informações.Add(TxtBox_Equipamento8_Manha.Text.Trim());
                Informações.Add(TxtBox_Tempo8_Manha.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void CBBox_Cod1_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod1_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao1_Manha.SelectedIndex = CBBox_Cod1_Manha.SelectedIndex;

            }

        }

        public void CBBox_Descricao1_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao1_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod1_Manha.SelectedIndex = CBBox_Descricao1_Manha.SelectedIndex;
            }

        }

        public void CBBox_Cod2_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod2_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao2_Manha.SelectedIndex = CBBox_Cod2_Manha.SelectedIndex;

            }

        }

        public void CBBox_Descricao2_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao2_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod2_Manha.SelectedIndex = CBBox_Descricao2_Manha.SelectedIndex;
            }

        }
        public void CBBox_Cod3_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod3_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao3_Manha.SelectedIndex = CBBox_Cod3_Manha.SelectedIndex;

            }

        }

        public void CBBox_Descricao3_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao3_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod3_Manha.SelectedIndex = CBBox_Descricao3_Manha.SelectedIndex;
            }

        }
        public void CBBox_Cod4_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod4_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao4_Manha.SelectedIndex = CBBox_Cod4_Manha.SelectedIndex;

            }

        }

        public void CBBox_Descricao4_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao4_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod4_Manha.SelectedIndex = CBBox_Descricao4_Manha.SelectedIndex;
            }

        }
        public void CBBox_Cod5_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod5_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao5_Manha.SelectedIndex = CBBox_Cod5_Manha.SelectedIndex;

            }

        }

        public void CBBox_Descricao5_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao5_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod5_Manha.SelectedIndex = CBBox_Descricao5_Manha.SelectedIndex;
            }

        }
        public void CBBox_Cod6_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod6_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao6_Manha.SelectedIndex = CBBox_Cod6_Manha.SelectedIndex;

            }

        }

        public void CBBox_Descricao6_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao6_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod6_Manha.SelectedIndex = CBBox_Descricao6_Manha.SelectedIndex;
            }

        }
        public void CBBox_Cod7_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod7_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao7_Manha.SelectedIndex = CBBox_Cod7_Manha.SelectedIndex;

            }

        }

        public void CBBox_Descricao7_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao7_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod7_Manha.SelectedIndex = CBBox_Descricao7_Manha.SelectedIndex;
            }

        }

        public void CBBox_Cod8_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod8_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao8_Manha.SelectedIndex = CBBox_Cod8_Manha.SelectedIndex;

            }

        }

        public void CBBox_Descricao8_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao8_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod8_Manha.SelectedIndex = CBBox_Descricao8_Manha.SelectedIndex;
            }

        }

        public void CBBox_Cod9_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod9_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao9_Manha.SelectedIndex = CBBox_Cod9_Manha.SelectedIndex;

            }

        }

        public void CBBox_Descricao9_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao9_Manha.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod9_Manha.SelectedIndex = CBBox_Descricao9_Manha.SelectedIndex;
            }

        }

        #endregion TURNOMANHA

        #region TURNOTARDE


        public void ButtonSalvar1_Tarde_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("1");
                Informações.Add(TxtBox_HoraIncio1_Tarde.Text.Trim());
                Informações.Add(TxtBox_HoraFim1_Tarde.Text.Trim());
                Informações.Add(CBBox_Cod1_Tarde.Text.Trim());
                Informações.Add(CBBox_Descricao1_Tarde.Text.Trim());
                Informações.Add(TxtBox_Producao1_Tarde.Text.Trim());
                Informações.Add(TxtBox_Retrabalho1_Tarde.Text.Trim());
                Informações.Add(TxtBox_Equipamento1_Tarde.Text.Trim());
                Informações.Add(TxtBox_Tempo1_Tarde.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }


        }

        public void ButtonSalvar2_Tarde_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("2");
                Informações.Add(TxtBox_HoraIncio2_Tarde.Text.Trim());
                Informações.Add(TxtBox_HoraFim2_Tarde.Text.Trim());
                Informações.Add(CBBox_Cod2_Tarde.Text.Trim());
                Informações.Add(CBBox_Descricao2_Tarde.Text.Trim());
                Informações.Add(TxtBox_Producao2_Tarde.Text.Trim());
                Informações.Add(TxtBox_Retrabalho2_Tarde.Text.Trim());
                Informações.Add(TxtBox_Equipamento2_Tarde.Text.Trim());
                Informações.Add(TxtBox_Tempo2_Tarde.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar3_Tarde_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("3");
                Informações.Add(TxtBox_HoraIncio3_Tarde.Text.Trim());
                Informações.Add(TxtBox_HoraFim3_Tarde.Text.Trim());
                Informações.Add(CBBox_Cod3_Tarde.Text.Trim());
                Informações.Add(CBBox_Descricao3_Tarde.Text.Trim());
                Informações.Add(TxtBox_Producao3_Tarde.Text.Trim());
                Informações.Add(TxtBox_Retrabalho3_Tarde.Text.Trim());
                Informações.Add(TxtBox_Equipamento3_Tarde.Text.Trim());
                Informações.Add(TxtBox_Tempo3_Tarde.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar4_Tarde_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("4");
                Informações.Add(TxtBox_HoraIncio4_Tarde.Text.Trim());
                Informações.Add(TxtBox_HoraFim4_Tarde.Text.Trim());
                Informações.Add(CBBox_Cod4_Tarde.Text.Trim());
                Informações.Add(CBBox_Descricao4_Tarde.Text.Trim());
                Informações.Add(TxtBox_Producao4_Tarde.Text.Trim());
                Informações.Add(TxtBox_Retrabalho4_Tarde.Text.Trim());
                Informações.Add(TxtBox_Equipamento4_Tarde.Text.Trim());
                Informações.Add(TxtBox_Tempo4_Tarde.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar5_Tarde_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("5");
                Informações.Add(TxtBox_HoraIncio5_Tarde.Text.Trim());
                Informações.Add(TxtBox_HoraFim5_Tarde.Text.Trim());
                Informações.Add(CBBox_Cod5_Tarde.Text.Trim());
                Informações.Add(CBBox_Descricao5_Tarde.Text.Trim());
                Informações.Add(TxtBox_Producao5_Tarde.Text.Trim());
                Informações.Add(TxtBox_Retrabalho5_Tarde.Text.Trim());
                Informações.Add(TxtBox_Equipamento5_Tarde.Text.Trim());
                Informações.Add(TxtBox_Tempo5_Tarde.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar6_Tarde_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("6");
                Informações.Add(TxtBox_HoraIncio6_Tarde.Text.Trim());
                Informações.Add(TxtBox_HoraFim6_Tarde.Text.Trim());
                Informações.Add(CBBox_Cod6_Tarde.Text.Trim());
                Informações.Add(CBBox_Descricao6_Tarde.Text.Trim());
                Informações.Add(TxtBox_Producao6_Tarde.Text.Trim());
                Informações.Add(TxtBox_Retrabalho6_Tarde.Text.Trim());
                Informações.Add(TxtBox_Equipamento6_Tarde.Text.Trim());
                Informações.Add(TxtBox_Tempo6_Tarde.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar7_Tarde_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("7");
                Informações.Add(TxtBox_HoraIncio7_Tarde.Text.Trim());
                Informações.Add(TxtBox_HoraFim7_Tarde.Text.Trim());
                Informações.Add(CBBox_Cod7_Tarde.Text.Trim());
                Informações.Add(CBBox_Descricao7_Tarde.Text.Trim());
                Informações.Add(TxtBox_Producao7_Tarde.Text.Trim());
                Informações.Add(TxtBox_Retrabalho7_Tarde.Text.Trim());
                Informações.Add(TxtBox_Equipamento7_Tarde.Text.Trim());
                Informações.Add(TxtBox_Tempo7_Tarde.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar8_Tarde_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("8");
                Informações.Add(TxtBox_HoraIncio6_Tarde.Text.Trim());
                Informações.Add(TxtBox_HoraFim8_Tarde.Text.Trim());
                Informações.Add(CBBox_Cod8_Tarde.Text.Trim());
                Informações.Add(CBBox_Descricao8_Tarde.Text.Trim());
                Informações.Add(TxtBox_Producao8_Tarde.Text.Trim());
                Informações.Add(TxtBox_Retrabalho8_Tarde.Text.Trim());
                Informações.Add(TxtBox_Equipamento8_Tarde.Text.Trim());
                Informações.Add(TxtBox_Tempo8_Tarde.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar9_Tarde_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("9");
                Informações.Add(TxtBox_HoraIncio6_Tarde.Text.Trim());
                Informações.Add(TxtBox_HoraFim8_Tarde.Text.Trim());
                Informações.Add(CBBox_Cod8_Tarde.Text.Trim());
                Informações.Add(CBBox_Descricao8_Tarde.Text.Trim());
                Informações.Add(TxtBox_Producao8_Tarde.Text.Trim());
                Informações.Add(TxtBox_Retrabalho8_Tarde.Text.Trim());
                Informações.Add(TxtBox_Equipamento8_Tarde.Text.Trim());
                Informações.Add(TxtBox_Tempo8_Tarde.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar10_Tarde_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("10");
                Informações.Add(TxtBox_HoraIncio6_Tarde.Text.Trim());
                Informações.Add(TxtBox_HoraFim8_Tarde.Text.Trim());
                Informações.Add(CBBox_Cod8_Tarde.Text.Trim());
                Informações.Add(CBBox_Descricao8_Tarde.Text.Trim());
                Informações.Add(TxtBox_Producao8_Tarde.Text.Trim());
                Informações.Add(TxtBox_Retrabalho8_Tarde.Text.Trim());
                Informações.Add(TxtBox_Equipamento8_Tarde.Text.Trim());
                Informações.Add(TxtBox_Tempo8_Tarde.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }


        public void CBBox_Cod1_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod1_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao1_Tarde.SelectedIndex = CBBox_Cod1_Tarde.SelectedIndex;

            }

        }

        public void CBBox_Descricao1_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao1_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod1_Tarde.SelectedIndex = CBBox_Descricao1_Tarde.SelectedIndex;
            }

        }

        public void CBBox_Cod2_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod2_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao2_Tarde.SelectedIndex = CBBox_Cod2_Tarde.SelectedIndex;

            }

        }

        public void CBBox_Descricao2_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao2_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod2_Tarde.SelectedIndex = CBBox_Descricao2_Tarde.SelectedIndex;
            }

        }
        public void CBBox_Cod3_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod3_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao3_Tarde.SelectedIndex = CBBox_Cod3_Tarde.SelectedIndex;

            }

        }

        public void CBBox_Descricao3_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao3_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod3_Tarde.SelectedIndex = CBBox_Descricao3_Tarde.SelectedIndex;
            }

        }
        public void CBBox_Cod4_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod4_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao4_Tarde.SelectedIndex = CBBox_Cod4_Tarde.SelectedIndex;

            }

        }

        public void CBBox_Descricao4_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao4_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod4_Tarde.SelectedIndex = CBBox_Descricao4_Tarde.SelectedIndex;
            }

        }
        public void CBBox_Cod5_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod5_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao5_Tarde.SelectedIndex = CBBox_Cod5_Tarde.SelectedIndex;

            }

        }

        public void CBBox_Descricao5_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao5_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod5_Tarde.SelectedIndex = CBBox_Descricao5_Tarde.SelectedIndex;
            }

        }
        public void CBBox_Cod6_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod6_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao6_Tarde.SelectedIndex = CBBox_Cod6_Tarde.SelectedIndex;

            }

        }

        public void CBBox_Descricao6_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao6_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod6_Tarde.SelectedIndex = CBBox_Descricao6_Tarde.SelectedIndex;
            }

        }
        public void CBBox_Cod7_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod7_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao7_Tarde.SelectedIndex = CBBox_Cod7_Tarde.SelectedIndex;

            }

        }

        public void CBBox_Descricao7_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao7_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod7_Tarde.SelectedIndex = CBBox_Descricao7_Tarde.SelectedIndex;
            }

        }

        public void CBBox_Cod8_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod8_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao8_Tarde.SelectedIndex = CBBox_Cod8_Tarde.SelectedIndex;

            }

        }

        public void CBBox_Descricao8_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao8_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod8_Tarde.SelectedIndex = CBBox_Descricao8_Tarde.SelectedIndex;
            }

        }
        public void CBBox_Cod9_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod9_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao9_Tarde.SelectedIndex = CBBox_Cod9_Tarde.SelectedIndex;

            }

        }

        public void CBBox_Descricao9_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao9_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod9_Tarde.SelectedIndex = CBBox_Descricao9_Tarde.SelectedIndex;
            }

        }
        public void CBBox_Cod10_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod8_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao10_Tarde.SelectedIndex = CBBox_Cod10_Tarde.SelectedIndex;

            }

        }

        public void CBBox_Descricao10_Tarde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao10_Tarde.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod10_Tarde.SelectedIndex = CBBox_Descricao10_Tarde.SelectedIndex;
            }

        }

        #endregion TURNOTarde

        #region TURNONoite


        public void ButtonSalvar1_Noite_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("1");
                Informações.Add(TxtBox_HoraIncio1_Noite.Text.Trim());
                Informações.Add(TxtBox_HoraFim1_Noite.Text.Trim());
                Informações.Add(CBBox_Cod1_Noite.Text.Trim());
                Informações.Add(CBBox_Descricao1_Noite.Text.Trim());
                Informações.Add(TxtBox_Producao1_Noite.Text.Trim());
                Informações.Add(TxtBox_Retrabalho1_Noite.Text.Trim());
                Informações.Add(TxtBox_Equipamento1_Noite.Text.Trim());
                Informações.Add(TxtBox_Tempo1_Noite.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }


        }

        public void ButtonSalvar2_Noite_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("2");
                Informações.Add(TxtBox_HoraIncio2_Noite.Text.Trim());
                Informações.Add(TxtBox_HoraFim2_Noite.Text.Trim());
                Informações.Add(CBBox_Cod2_Noite.Text.Trim());
                Informações.Add(CBBox_Descricao2_Noite.Text.Trim());
                Informações.Add(TxtBox_Producao2_Noite.Text.Trim());
                Informações.Add(TxtBox_Retrabalho2_Noite.Text.Trim());
                Informações.Add(TxtBox_Equipamento2_Noite.Text.Trim());
                Informações.Add(TxtBox_Tempo2_Noite.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar3_Noite_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("3");
                Informações.Add(TxtBox_HoraIncio3_Noite.Text.Trim());
                Informações.Add(TxtBox_HoraFim3_Noite.Text.Trim());
                Informações.Add(CBBox_Cod3_Noite.Text.Trim());
                Informações.Add(CBBox_Descricao3_Noite.Text.Trim());
                Informações.Add(TxtBox_Producao3_Noite.Text.Trim());
                Informações.Add(TxtBox_Retrabalho3_Noite.Text.Trim());
                Informações.Add(TxtBox_Equipamento3_Noite.Text.Trim());
                Informações.Add(TxtBox_Tempo3_Noite.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar4_Noite_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("4");
                Informações.Add(TxtBox_HoraIncio4_Noite.Text.Trim());
                Informações.Add(TxtBox_HoraFim4_Noite.Text.Trim());
                Informações.Add(CBBox_Cod4_Noite.Text.Trim());
                Informações.Add(CBBox_Descricao4_Noite.Text.Trim());
                Informações.Add(TxtBox_Producao4_Noite.Text.Trim());
                Informações.Add(TxtBox_Retrabalho4_Noite.Text.Trim());
                Informações.Add(TxtBox_Equipamento4_Noite.Text.Trim());
                Informações.Add(TxtBox_Tempo4_Noite.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }

        public void ButtonSalvar5_Noite_Click(object sender, EventArgs e)
        {
            var ResultPopup = MessageBox.Show("Os dados serão salvos, deseja continuar", "Gravar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ResultPopup.Equals(DialogResult.OK))
            {
                List<string> Informações = new List<string>();

                Informações.Add(Lb_DateToday.Text.Trim());
                Informações.Add("5");
                Informações.Add(TxtBox_HoraIncio5_Noite.Text.Trim());
                Informações.Add(TxtBox_HoraFim5_Noite.Text.Trim());
                Informações.Add(CBBox_Cod5_Noite.Text.Trim());
                Informações.Add(CBBox_Descricao5_Noite.Text.Trim());
                Informações.Add(TxtBox_Producao5_Noite.Text.Trim());
                Informações.Add(TxtBox_Retrabalho5_Noite.Text.Trim());
                Informações.Add(TxtBox_Equipamento5_Noite.Text.Trim());
                Informações.Add(TxtBox_Tempo5_Noite.Text.Trim());
                Informações.Add(ComboBox_Turno.Text.Trim()); Informações.Add(InformacoesUser[0].Trim());

                control.GravaRegistro(Informações);
                SelecionaTurno(ComboBox_Turno.Text.Trim());
            }

        }


        public void CBBox_Cod1_Noite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod1_Noite.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao1_Noite.SelectedIndex = CBBox_Cod1_Noite.SelectedIndex;

            }

        }

        public void CBBox_Descricao1_Noite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao1_Noite.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod1_Noite.SelectedIndex = CBBox_Descricao1_Noite.SelectedIndex;
            }

        }

        public void CBBox_Cod2_Noite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod2_Noite.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao2_Noite.SelectedIndex = CBBox_Cod2_Noite.SelectedIndex;

            }

        }

        public void CBBox_Descricao2_Noite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao2_Noite.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod2_Noite.SelectedIndex = CBBox_Descricao2_Noite.SelectedIndex;
            }

        }
        public void CBBox_Cod3_Noite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod3_Noite.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao3_Noite.SelectedIndex = CBBox_Cod3_Noite.SelectedIndex;

            }

        }

        public void CBBox_Descricao3_Noite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao3_Noite.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod3_Noite.SelectedIndex = CBBox_Descricao3_Noite.SelectedIndex;
            }

        }
        public void CBBox_Cod4_Noite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod4_Noite.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao4_Noite.SelectedIndex = CBBox_Cod4_Noite.SelectedIndex;

            }

        }

        public void CBBox_Descricao4_Noite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao4_Noite.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod4_Noite.SelectedIndex = CBBox_Descricao4_Noite.SelectedIndex;
            }

        }
        public void CBBox_Cod5_Noite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod5_Noite.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Descricao5_Noite.SelectedIndex = CBBox_Cod5_Noite.SelectedIndex;

            }

        }

        public void CBBox_Descricao5_Noite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Descricao5_Noite.SelectedIndex == 0)
            {
            }
            else
            {
                CBBox_Cod5_Noite.SelectedIndex = CBBox_Descricao5_Noite.SelectedIndex;
            }

        }


        #endregion TURNONoite

       
    }






}
