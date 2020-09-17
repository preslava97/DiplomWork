namespace PiersDCS
{
    partial class FlightReport
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
            this.PassengerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PiersDCSdatabaseDataSet2 = new PiersDCS.PiersDCSdatabaseDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PassengerTableTableAdapter = new PiersDCS.PiersDCSdatabaseDataSet2TableAdapters.PassengerTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiersDCSdatabaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // PassengerTableBindingSource
            // 
            this.PassengerTableBindingSource.DataMember = "PassengerTable";
            this.PassengerTableBindingSource.DataSource = this.PiersDCSdatabaseDataSet2;
            // 
            // PiersDCSdatabaseDataSet2
            // 
            this.PiersDCSdatabaseDataSet2.DataSetName = "PiersDCSdatabaseDataSet2";
            this.PiersDCSdatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PassengerTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PiersDCS.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // PassengerTableTableAdapter
            // 
            this.PassengerTableTableAdapter.ClearBeforeFill = true;
            // 
            // FlightReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FlightReport";
            this.Text = "FlightReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FlightReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PassengerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiersDCSdatabaseDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PassengerTableBindingSource;
        private PiersDCSdatabaseDataSet2 PiersDCSdatabaseDataSet2;
        private PiersDCSdatabaseDataSet2TableAdapters.PassengerTableTableAdapter PassengerTableTableAdapter;
    }
}