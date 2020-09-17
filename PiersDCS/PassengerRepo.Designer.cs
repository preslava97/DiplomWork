namespace PiersDCS
{
    partial class PassengerRepo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PiersDCSdatabaseDataSet2 = new PiersDCS.PiersDCSdatabaseDataSet2();
            this.PassengerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PassengerTableTableAdapter = new PiersDCS.PiersDCSdatabaseDataSet2TableAdapters.PassengerTableTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PiersDCSdatabaseDataSet3 = new PiersDCS.PiersDCSdatabaseDataSet3();
            this.Table_ViennaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Table_ViennaTableAdapter = new PiersDCS.PiersDCSdatabaseDataSet3TableAdapters.Table_ViennaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PiersDCSdatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiersDCSdatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_ViennaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PiersDCSdatabaseDataSet2
            // 
            this.PiersDCSdatabaseDataSet2.DataSetName = "PiersDCSdatabaseDataSet2";
            this.PiersDCSdatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PassengerTableBindingSource
            // 
            this.PassengerTableBindingSource.DataMember = "PassengerTable";
            this.PassengerTableBindingSource.DataSource = this.PiersDCSdatabaseDataSet2;
            // 
            // PassengerTableTableAdapter
            // 
            this.PassengerTableTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.PassengerTableBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.Table_ViennaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PiersDCS.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // PiersDCSdatabaseDataSet3
            // 
            this.PiersDCSdatabaseDataSet3.DataSetName = "PiersDCSdatabaseDataSet3";
            this.PiersDCSdatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Table_ViennaBindingSource
            // 
            this.Table_ViennaBindingSource.DataMember = "Table_Vienna";
            this.Table_ViennaBindingSource.DataSource = this.PiersDCSdatabaseDataSet3;
            // 
            // Table_ViennaTableAdapter
            // 
            this.Table_ViennaTableAdapter.ClearBeforeFill = true;
            // 
            // PassengerRepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PassengerRepo";
            this.Text = "PassengerRepo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PassengerRepo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PiersDCSdatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiersDCSdatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_ViennaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource PassengerTableBindingSource;
        private PiersDCSdatabaseDataSet2 PiersDCSdatabaseDataSet2;
        private PiersDCSdatabaseDataSet2TableAdapters.PassengerTableTableAdapter PassengerTableTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Table_ViennaBindingSource;
        private PiersDCSdatabaseDataSet3 PiersDCSdatabaseDataSet3;
        private PiersDCSdatabaseDataSet3TableAdapters.Table_ViennaTableAdapter Table_ViennaTableAdapter;
    }
}