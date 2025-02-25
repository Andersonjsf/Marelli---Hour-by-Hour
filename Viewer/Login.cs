﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Marelli___Hour_by_Hour.Controller;
using Marelli___Hour_by_Hour.Model;
using Marelli___Hour_by_Hour.Viewer;
using System.Net;

namespace Marelli___Hour_by_Hour
{
    public partial class Login : Form
    {
        public Login()
        {
           
            InitializeComponent();
        }

        private void Button_Cadastrar_Click(object sender, EventArgs e)
        {
            CadastroUser CadUser = new CadastroUser();
            CadUser.ShowDialog();
        }

        private void Button_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            
            Controle Controle = new Controle();
            Controle.Acess(TxtBox_UserID.Text, TxtBox_Password.Text);
            if (Controle.ExistNoBanco)
            {
                string NomeMarchine = Dns.GetHostName();
                IPAddress[] Adress = Dns.GetHostAddresses(NomeMarchine);
                string IP =  Adress[3].ToString();
                string Date = DateTime.Now.ToString("dd/MM/yyyy'T'HH:mm:ss.fffffff'Z'");

                Controle.Log(TxtBox_UserID.Text,IP,NomeMarchine, Date);
                Close();
                
            }
            else
            {
                MessageBox.Show("Login não encontrado, verifique os dados", "Crenciais Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
    }
}
