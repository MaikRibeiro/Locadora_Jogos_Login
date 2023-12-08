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
    public partial class frmConsultaPessoa : Form
    {
        public frmConsultaPessoa()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.locadora_JogosDataSet);

        }

        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.locadora_JogosDataSet);

        }

        private void frmConsultaPessoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locadora_JogosDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.locadora_JogosDataSet.Cliente);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string coluna, procurar, texto, filtro;

            coluna = cmbColuna.Text;
            procurar = cmbProcurar.Text;
            texto = txtPesquisa.Text;
            filtro = coluna;

            if(procurar == "Que começa com")
            {
                filtro += " like '" + texto + "%'";
            }
            else if(procurar == "Que contém")
            {
                filtro += " like '%" + texto + "%'";
            }
            else if(procurar == "Que termina com")
            {
                filtro += " like '%" + texto + "'";
            }
            else if(procurar == "Igual a")
            {
                filtro += " =' " + texto + "'";
            }
            else
            {
                filtro = "";
            }

            clienteBindingSource.Filter = filtro;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.limiteDeTelasInstaciadas = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbColuna.SelectedIndex = -1;
            cmbProcurar.SelectedIndex = -1;
            txtPesquisa.Text = "";
        }
    }
}
