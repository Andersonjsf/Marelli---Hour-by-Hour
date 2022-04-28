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

namespace Marelli___Hour_by_Hour.Viewer
{
    public partial class CadastroUser : Form
    {
        public CadastroUser()
        {
            InitializeComponent();
        }

        private void Button_Cad_Click(object sender, EventArgs e)
        {
            Controle Controle = new Controle();
          string mensagem =  Controle.Cadastro(TxtBox_UserID.Text, TxtBox_Password.Text, TxtBox_Turno.Text, TxtBox_Funcao.Text);
            if (Controle.ExistNoBanco)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show(Controle.Mensagem);

            }
        }

        private void Button_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
