namespace PiersDCS
{
    partial class SecondPreview
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDpassngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagPiecesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotherPassngTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piersDCSdatabaseDataSet5 = new PiersDCS.PiersDCSdatabaseDataSet5();
            this.anotherPassngTableTableAdapter = new PiersDCS.PiersDCSdatabaseDataSet5TableAdapters.AnotherPassngTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anotherPassngTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piersDCSdatabaseDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDpassngDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.seatDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.documentNumberDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn,
            this.bagPiecesDataGridViewTextBoxColumn,
            this.bagWeightDataGridViewTextBoxColumn,
            this.specialDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.anotherPassngTableBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.Location = new System.Drawing.Point(66, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(787, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDpassngDataGridViewTextBoxColumn
            // 
            this.iDpassngDataGridViewTextBoxColumn.DataPropertyName = "ID_passng";
            this.iDpassngDataGridViewTextBoxColumn.HeaderText = "ID_passng";
            this.iDpassngDataGridViewTextBoxColumn.Name = "iDpassngDataGridViewTextBoxColumn";
            this.iDpassngDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // seatDataGridViewTextBoxColumn
            // 
            this.seatDataGridViewTextBoxColumn.DataPropertyName = "Seat";
            this.seatDataGridViewTextBoxColumn.HeaderText = "Seat";
            this.seatDataGridViewTextBoxColumn.Name = "seatDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // documentNumberDataGridViewTextBoxColumn
            // 
            this.documentNumberDataGridViewTextBoxColumn.DataPropertyName = "Document Number";
            this.documentNumberDataGridViewTextBoxColumn.HeaderText = "Document Number";
            this.documentNumberDataGridViewTextBoxColumn.Name = "documentNumberDataGridViewTextBoxColumn";
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            // 
            // birthDataGridViewTextBoxColumn
            // 
            this.birthDataGridViewTextBoxColumn.DataPropertyName = "Birth";
            this.birthDataGridViewTextBoxColumn.HeaderText = "Birth";
            this.birthDataGridViewTextBoxColumn.Name = "birthDataGridViewTextBoxColumn";
            // 
            // bagPiecesDataGridViewTextBoxColumn
            // 
            this.bagPiecesDataGridViewTextBoxColumn.DataPropertyName = "Bag Pieces";
            this.bagPiecesDataGridViewTextBoxColumn.HeaderText = "Bag Pieces";
            this.bagPiecesDataGridViewTextBoxColumn.Name = "bagPiecesDataGridViewTextBoxColumn";
            // 
            // bagWeightDataGridViewTextBoxColumn
            // 
            this.bagWeightDataGridViewTextBoxColumn.DataPropertyName = "Bag Weight";
            this.bagWeightDataGridViewTextBoxColumn.HeaderText = "Bag Weight";
            this.bagWeightDataGridViewTextBoxColumn.Name = "bagWeightDataGridViewTextBoxColumn";
            // 
            // specialDataGridViewTextBoxColumn
            // 
            this.specialDataGridViewTextBoxColumn.DataPropertyName = "Special";
            this.specialDataGridViewTextBoxColumn.HeaderText = "Special";
            this.specialDataGridViewTextBoxColumn.Name = "specialDataGridViewTextBoxColumn";
            // 
            // anotherPassngTableBindingSource
            // 
            this.anotherPassngTableBindingSource.DataMember = "AnotherPassngTable";
            this.anotherPassngTableBindingSource.DataSource = this.piersDCSdatabaseDataSet5;
            // 
            // piersDCSdatabaseDataSet5
            // 
            this.piersDCSdatabaseDataSet5.DataSetName = "PiersDCSdatabaseDataSet5";
            this.piersDCSdatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anotherPassngTableTableAdapter
            // 
            this.anotherPassngTableTableAdapter.ClearBeforeFill = true;
            // 
            // SecondPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PiersDCS.Properties.Resources.FinallyBack;
            this.ClientSize = new System.Drawing.Size(939, 488);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SecondPreview";
            this.Text = "SecondPreview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SecondPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anotherPassngTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piersDCSdatabaseDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PiersDCSdatabaseDataSet5 piersDCSdatabaseDataSet5;
        private System.Windows.Forms.BindingSource anotherPassngTableBindingSource;
        private PiersDCSdatabaseDataSet5TableAdapters.AnotherPassngTableTableAdapter anotherPassngTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpassngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagPiecesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialDataGridViewTextBoxColumn;
    }
}