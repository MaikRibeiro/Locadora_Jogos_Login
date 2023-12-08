using Projeto_LocadoraJogos.Formulários;
using Projeto_LocadoraJogos.Relatórios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LocadoraJogos
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        public static Boolean limiteDeTelasInstaciadas = false;

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!limiteDeTelasInstaciadas)
            {
                limiteDeTelasInstaciadas = true;
                frmCadPessoa cadPessoa = new frmCadPessoa();
                cadPessoa.MdiParent = this;
                cadPessoa.Show();
            }
            else
            {
                MessageBox.Show("Já existe uma tela em execução",
                    "Desculpe",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!limiteDeTelasInstaciadas)
            {
                limiteDeTelasInstaciadas = true;
                frmConsultaPessoa consPessoa = new frmConsultaPessoa();
                consPessoa.MdiParent = this;
                consPessoa.Show();
            }
            else
            {
                MessageBox.Show("Já existe uma tela em execução",
                    "Desculpe",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
<<<<<<< Updated upstream
=======

        private void relatórioClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!limiteDeTelasInstaciadas)
            {
                limiteDeTelasInstaciadas = true;
                frmVisualizaClientes relatorio = new frmVisualizaClientes();
                relatorio.MdiParent = this;
                relatorio.Show();
            }
            else
            {
                MessageBox.Show("Já existe uma tela em execução",
                    "Desculpe",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void clientesPorJogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!limiteDeTelasInstaciadas)
            {
                limiteDeTelasInstaciadas = true;
                VisualizaClienteJogos relatorio = new VisualizaClienteJogos();
                relatorio.MdiParent = this;
                relatorio.Show();
            }
            else
            {
                MessageBox.Show("Já existe uma tela em execução",
                    "Desculpe",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
>>>>>>> Stashed changes
    }
}
