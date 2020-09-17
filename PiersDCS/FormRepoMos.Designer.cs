namespace PiersDCS
{
    partial class FormRepoMos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PiersDCSdatabaseDataSet4 = new PiersDCS.PiersDCSdatabaseDataSet4();
            this.Table_MosscowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Table_MosscowTableAdapter = new PiersDCS.PiersDCSdatabaseDataSet4TableAdapters.Table_MosscowTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PiersDCSdatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_MosscowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Table_MosscowBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PiersDCS.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // PiersDCSdatabaseDataSet4
            // 
            this.PiersDCSdatabaseDataSet4.DataSetName = "PiersDCSdatabaseDataSet4";
            this.PiersDCSdatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Table_MosscowBindingSource
            // 
            this.Table_MosscowBindingSource.DataMember = "Table_Mosscow";
            this.Table_MosscowBindingSource.DataSource = this.PiersDCSdatabaseDataSet4;
            // 
            // Table_MosscowTableAdapter
            // 
            this.Table_MosscowTableAdapter.ClearBeforeFill = true;
            // 
            // FormRepoMos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRepoMos";
            this.Text = "FormRepoMos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRepoMos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PiersDCSdatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_MosscowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Table_MosscowBindingSource;
        private PiersDCSdatabaseDataSet4 PiersDCSdatabaseDataSet4;
        private PiersDCSdatabaseDataSet4TableAdapters.Table_MosscowTableAdapter Table_MosscowTableAdapter;
    }
}