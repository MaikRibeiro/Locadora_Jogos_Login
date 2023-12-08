using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LocadoraJogos.Formulários
{
    public partial class frmVisualizaClientes : Form
    {
        public frmVisualizaClientes()
        {
            InitializeComponent();
        }

        private void frmVisualizaClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locadora_JogosDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.locadora_JogosDataSet.Cliente);

            this.reportViewer1.RefreshReport();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu.limiteDeTelasInstaciadas = false;
            Close();    
        }
    }
}
