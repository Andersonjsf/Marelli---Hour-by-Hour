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
    public partial class CodigoMotivo : Form
    {
        public CodigoMotivo()
        {
            InitializeComponent();
        }

        private void CodigoMotivo_Load(object sender, EventArgs e)
        {
            Controle control = new Controle();
            var DtTable = control.ListaMotivoParada();
            DataGridMotivos.DataSource = DtTable;

        }
    }
}
