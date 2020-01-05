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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbpregacoesDataSet = new CamadaApresentacao.dbpregacoesDataSet();
            this.programaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programaTableAdapter = new CamadaApresentacao.dbpregacoesDataSetTableAdapters.programaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbpregacoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dbPregacoesDataSet";
            reportDataSource1.Value = this.programaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbpregacoesDataSet
            // 
            this.dbpregacoesDataSet.DataSetName = "dbpregacoesDataSet";
            this.dbpregacoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programaBindingSource
            // 
            this.programaBindingSource.DataMember = "programa";
            this.programaBindingSource.DataSource = this.dbpregacoesDataSet;
            // 
            // programaTableAdapter
            // 
            this.programaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRepPregacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRepPregacoes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmRepPregacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbpregacoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource programaBindingSource;
        private dbpregacoesDataSet dbpregacoesDataSet;
        private dbpregacoesDataSetTableAdapters.programaTableAdapter programaTableAdapter;
    }
}