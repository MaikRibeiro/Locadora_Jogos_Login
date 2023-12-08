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
    public partial class VisualizaClienteJogos : Form
    {
        public VisualizaClienteJogos()
        {
            InitializeComponent();
        }

        private void VisualizaClienteJogos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Locadora_Jogos.Jogos_Clientes' table. You can move, or remove it, as needed.
            this.jogos_ClientesTableAdapter.Fill(this.dataSet_Locadora_Jogos.Jogos_Clientes);
            // TODO: This line of code loads data into the 'dataSet1.Clientes_Jogos' table. You can move, or remove it, as needed.
            this.clientes_JogosTableAdapter.Fill(this.dataSet1.Clientes_Jogos);
            // TODO: This line of code loads data into the 'locadora_JogosDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.locadora_JogosDataSet.Cliente);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Jogo_locado", cmbJogo.Text));
            this.reportViewer1.RefreshReport();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Jogo_locado", (string)null));
            this.reportViewer1.RefreshReport();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu.limiteDeTelasInstaciadas = false;
            Close();
        }
    }
}
