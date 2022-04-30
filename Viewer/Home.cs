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
            AlimentaMotivoParada(turno);

        }

       
       
        private void CBBox_Cod1_Manha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBox_Cod1_Manha.SelectedIndex == 0)
            {
                // CBBox_Descricao1_Manha.SelectedIndex = 1;
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
                // CBBox_Descricao1_Manha.SelectedIndex = 1;
            }
            else
            {
                CBBox_Cod1_Manha.SelectedIndex = CBBox_Descricao1_Manha.SelectedIndex;

            }

        }






        public void AlimentaMotivoParada(string Turno)
        {

            switch (Turno)
            {
                case "Manhã":
                
                    CBBox_Cod1_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Cod1_Manha.DisplayMember = "Cod";
                    CBBox_Cod1_Manha.ValueMember = "Cod";
                    CBBox_Descricao1_Manha.DataSource = control.ListaMotivoParada();
                    CBBox_Descricao1_Manha.DisplayMember = "Descricao";
                    CBBox_Descricao1_Manha.ValueMember = "Descricao";
                    break;

                    //   case "Tarde":
                    //       CBBox_Cod1_Manha.Items.Clear();
                    //     CBBox_Cod2_Manha.DataSource = control.ListaMotivoParada();
                    //       CBBox_Cod3_Manha.DisplayMember = "Cod";
                    //      CBBox_Cod4_Manha.ValueMember = "Cod";
                    //       break;
            }
        }

       
    }
}
