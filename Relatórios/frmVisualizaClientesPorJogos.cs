using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LocadoraJogos.Relatórios
{
    public partial class frmVisualizaClientesPorJogos : Form
    {
        public frmVisualizaClientesPorJogos()
        {
            InitializeComponent();
        }

        private void frmVisualizaClientesPorJogos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu.limiteDeTelasInstaciadas = false;
            Close();
        }
    }
}
