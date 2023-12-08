namespace Projeto_LocadoraJogos.Formulários
{
    partial class frmVisualizaClientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locadora_JogosDataSet = new Projeto_LocadoraJogos.Locadora_JogosDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Locadora_Jogos = new Projeto_LocadoraJogos.Dados.DataSet_Locadora_Jogos();
            this.dataSetLocadoraJogosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Projeto_LocadoraJogos.Locadora_JogosDataSetTableAdapters.ClienteTableAdapter();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locadora_JogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Locadora_Jogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLocadoraJogosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.locadora_JogosDataSet;
            // 
            // locadora_JogosDataSet
            // 
            this.locadora_JogosDataSet.DataSetName = "Locadora_JogosDataSet";
            this.locadora_JogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet_Pessoas";
            reportDataSource4.Value = this.clienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_LocadoraJogos.Relatórios.RelatorioPessoas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(735, 313);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Locadora_Jogos
            // 
            this.dataSet_Locadora_Jogos.DataSetName = "DataSet_Locadora_Jogos";
            this.dataSet_Locadora_Jogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetLocadoraJogosBindingSource
            // 
            this.dataSetLocadoraJogosBindingSource.DataSource = this.dataSet_Locadora_Jogos;
            this.dataSetLocadoraJogosBindingSource.Position = 0;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Brown;
            this.btnSair.Location = new System.Drawing.Point(652, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 27);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair (esc)";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmVisualizaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 313);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVisualizaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualiza Clientes";
            this.Load += new System.EventHandler(this.frmVisualizaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locadora_JogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Locadora_Jogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLocadoraJogosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Dados.DataSet_Locadora_Jogos dataSet_Locadora_Jogos;
        private System.Windows.Forms.BindingSource dataSetLocadoraJogosBindingSource;
        private Locadora_JogosDataSet locadora_JogosDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Locadora_JogosDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button btnSair;
    }
}