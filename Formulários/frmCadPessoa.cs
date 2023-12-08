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
    public partial class frmCadPessoa : Form
    {
        public frmCadPessoa()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.locadora_JogosDataSet);

        }

        private void frmCadPessoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locadora_JogosDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.locadora_JogosDataSet.Cliente);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirmar exlcusão?",
                               "Excluindo registro",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                clienteBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.locadora_JogosDataSet);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu.limiteDeTelasInstaciadas = false;
            Close();
        }
    }
}
