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


        public Home()
        {
            InitializeComponent();
          
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Login LoginScreen = new Login();
            Controle Control = new Controle();

            LoginScreen.ShowDialog();
            this.Visible = true;
            Lb_user.Text = "-  Usuário " + LoginScreen.TxtBox_UserID.Text;
            
            InformacoesUser = Control.GetInformacoes(LoginScreen.TxtBox_UserID.Text);
            Lb_DateToday.Text = DateTime.Now.ToString("dd/MM/yyyy");
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

        }

       
    }
}
