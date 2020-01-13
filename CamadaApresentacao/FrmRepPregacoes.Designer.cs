namespace CamadaApresentacao
{
    partial class FrmRepPregacoes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepPregacoes));
            this.programaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbpregacoesDataSet = new CamadaApresentacao.dbpregacoesDataSet();
            this.programaTableAdapter = new CamadaApresentacao.dbpregacoesDataSetTableAdapters.programaTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbpregacoesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // programaBindingSource
            // 
            this.programaBindingSource.DataMember = "programa";
            this.programaBindingSource.DataSource = this.dbpregacoesDataSet;
            // 
            // dbpregacoesDataSet
            // 
            this.dbpregacoesDataSet.DataSetName = "dbpregacoesDataSet";
            this.dbpregacoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programaTableAdapter
            // 
            this.programaTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.IsDocumentMapWidthFixed = true;
            reportDataSource1.Name = "dbPregacoesDataSet";
            reportDataSource1.Value = this.programaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Pregações.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // FrmRepPregacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRepPregacoes";
            this.Text = "Pregações de Paiva Netto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRepPregacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbpregacoesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource programaBindingSource;
        private dbpregacoesDataSet dbpregacoesDataSet;
        private dbpregacoesDataSetTableAdapters.programaTableAdapter programaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}