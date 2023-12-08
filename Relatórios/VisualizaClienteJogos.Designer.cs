namespace Projeto_LocadoraJogos.Relatórios
{
    partial class VisualizaClienteJogos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.locadora_JogosDataSet = new Projeto_LocadoraJogos.Locadora_JogosDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Projeto_LocadoraJogos.Locadora_JogosDataSetTableAdapters.ClienteTableAdapter();
            this.cmbJogo = new System.Windows.Forms.ComboBox();
            this.jogosClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Locadora_Jogos = new Projeto_LocadoraJogos.Dados.DataSet_Locadora_Jogos();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Projeto_LocadoraJogos.Dados.DataSet1();
            this.clientesJogosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientes_JogosTableAdapter = new Projeto_LocadoraJogos.Dados.DataSet1TableAdapters.Clientes_JogosTableAdapter();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.jogos_ClientesTableAdapter = new Projeto_LocadoraJogos.Dados.DataSet_Locadora_JogosTableAdapters.Jogos_ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locadora_JogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogosClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Locadora_Jogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesJogosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataMember = "Cliente";
            this.clienteBindingSource2.DataSource = this.locadora_JogosDataSet;
            // 
            // locadora_JogosDataSet
            // 
            this.locadora_JogosDataSet.DataSetName = "Locadora_JogosDataSet";
            this.locadora_JogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.clienteBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_LocadoraJogos.Relatórios.RelatorioClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 72);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(864, 441);
            this.reportViewer1.TabIndex = 0;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.locadora_JogosDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // cmbJogo
            // 
            this.cmbJogo.DataSource = this.jogosClientesBindingSource;
            this.cmbJogo.DisplayMember = "Jogo_locado";
            this.cmbJogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJogo.FormattingEnabled = true;
            this.cmbJogo.Location = new System.Drawing.Point(32, 24);
            this.cmbJogo.Name = "cmbJogo";
            this.cmbJogo.Size = new System.Drawing.Size(139, 21);
            this.cmbJogo.TabIndex = 1;
            this.cmbJogo.ValueMember = "Jogo_locado";
            // 
            // jogosClientesBindingSource
            // 
            this.jogosClientesBindingSource.DataMember = "Jogos_Clientes";
            this.jogosClientesBindingSource.DataSource = this.dataSet_Locadora_Jogos;
            // 
            // dataSet_Locadora_Jogos
            // 
            this.dataSet_Locadora_Jogos.DataSetName = "DataSet_Locadora_Jogos";
            this.dataSet_Locadora_Jogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por Jogo Locado:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(200, 15);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 37);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "&Localizar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.locadora_JogosDataSet;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesJogosBindingSource
            // 
            this.clientesJogosBindingSource.DataMember = "Clientes_Jogos";
            this.clientesJogosBindingSource.DataSource = this.dataSet1;
            // 
            // clientes_JogosTableAdapter
            // 
            this.clientes_JogosTableAdapter.ClearBeforeFill = true;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(302, 15);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 37);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.Text = "&Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(768, 15);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(84, 37);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = " Sair ";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(813, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "(ESC)";
            // 
            // jogos_ClientesTableAdapter
            // 
            this.jogos_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // VisualizaClienteJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(864, 513);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbJogo);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VisualizaClienteJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualiza Cliente Jogos";
            this.Load += new System.EventHandler(this.VisualizaClienteJogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locadora_JogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogosClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Locadora_Jogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesJogosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Locadora_JogosDataSet locadora_JogosDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Locadora_JogosDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.ComboBox cmbJogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private Dados.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource clientesJogosBindingSource;
        private Dados.DataSet1TableAdapters.Clientes_JogosTableAdapter clientes_JogosTableAdapter;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label2;
        private Dados.DataSet_Locadora_Jogos dataSet_Locadora_Jogos;
        private System.Windows.Forms.BindingSource jogosClientesBindingSource;
        private Dados.DataSet_Locadora_JogosTableAdapters.Jogos_ClientesTableAdapter jogos_ClientesTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
    }
}