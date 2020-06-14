namespace PiersDCS
{
    partial class Preview
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
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.piersDCSdatabaseDataSet3 = new PiersDCS.PiersDCSdatabaseDataSet3();
            this.passengerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passengerTableTableAdapter = new PiersDCS.PiersDCSdatabaseDataSet3TableAdapters.PassengerTableTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatRowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatColumnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagPiecesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piersDCSdatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreview
            // 
            this.dgvPreview.AllowUserToAddRows = false;
            this.dgvPreview.AllowUserToDeleteRows = false;
            this.dgvPreview.AutoGenerateColumns = false;
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.seatRowDataGridViewTextBoxColumn,
            this.seatColumnDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.documentNumberDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.bagPiecesDataGridViewTextBoxColumn,
            this.bagWeightDataGridViewTextBoxColumn,
            this.specialDataGridViewTextBoxColumn});
            this.dgvPreview.DataSource = this.passengerTableBindingSource;
            this.dgvPreview.Location = new System.Drawing.Point(66, 12);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.Size = new System.Drawing.Size(998, 369);
            this.dgvPreview.TabIndex = 0;
            this.dgvPreview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreview_CellContentClick);
            // 
            // piersDCSdatabaseDataSet3
            // 
            this.piersDCSdatabaseDataSet3.DataSetName = "PiersDCSdatabaseDataSet3";
            this.piersDCSdatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passengerTableBindingSource
            // 
            this.passengerTableBindingSource.DataMember = "PassengerTable";
            this.passengerTableBindingSource.DataSource = this.piersDCSdatabaseDataSet3;
            // 
            // passengerTableTableAdapter
            // 
            this.passengerTableTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // seatRowDataGridViewTextBoxColumn
            // 
            this.seatRowDataGridViewTextBoxColumn.DataPropertyName = "SeatRow";
            this.seatRowDataGridViewTextBoxColumn.HeaderText = "SeatRow";
            this.seatRowDataGridViewTextBoxColumn.Name = "seatRowDataGridViewTextBoxColumn";
            // 
            // seatColumnDataGridViewTextBoxColumn
            // 
            this.seatColumnDataGridViewTextBoxColumn.DataPropertyName = "SeatColumn";
            this.seatColumnDataGridViewTextBoxColumn.HeaderText = "SeatColumn";
            this.seatColumnDataGridViewTextBoxColumn.Name = "seatColumnDataGridViewTextBoxColumn";
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
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date of birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPreview);
            this.Name = "Preview";
            this.Text = "Preview";
            this.Load += new System.EventHandler(this.Preview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piersDCSdatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreview;
        private PiersDCSdatabaseDataSet3 piersDCSdatabaseDataSet3;
        private System.Windows.Forms.BindingSource passengerTableBindingSource;
        private PiersDCSdatabaseDataSet3TableAdapters.PassengerTableTableAdapter passengerTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatRowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatColumnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagPiecesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}