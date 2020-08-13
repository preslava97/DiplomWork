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
            this.dgvPrevPassenger = new System.Windows.Forms.DataGridView();
            this.iDpassengerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.passengerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piersDCSdatabaseDataSet6 = new PiersDCS.PiersDCSdatabaseDataSet6();
            this.btnClose = new System.Windows.Forms.Button();
            this.passengerTableTableAdapter = new PiersDCS.PiersDCSdatabaseDataSet6TableAdapters.PassengerTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevPassenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piersDCSdatabaseDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrevPassenger
            // 
            this.dgvPrevPassenger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrevPassenger.AutoGenerateColumns = false;
            this.dgvPrevPassenger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrevPassenger.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvPrevPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrevPassenger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDpassengerDataGridViewTextBoxColumn,
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
            this.dgvPrevPassenger.DataSource = this.passengerTableBindingSource;
            this.dgvPrevPassenger.GridColor = System.Drawing.Color.Turquoise;
            this.dgvPrevPassenger.Location = new System.Drawing.Point(28, 23);
            this.dgvPrevPassenger.Name = "dgvPrevPassenger";
            this.dgvPrevPassenger.Size = new System.Drawing.Size(1011, 333);
            this.dgvPrevPassenger.TabIndex = 0;
            this.dgvPrevPassenger.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrevPassenger_CellContentClick);
            // 
            // iDpassengerDataGridViewTextBoxColumn
            // 
            this.iDpassengerDataGridViewTextBoxColumn.DataPropertyName = "ID_passenger";
            this.iDpassengerDataGridViewTextBoxColumn.HeaderText = "ID_passenger";
            this.iDpassengerDataGridViewTextBoxColumn.Name = "iDpassengerDataGridViewTextBoxColumn";
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
            this.documentNumberDataGridViewTextBoxColumn.DataPropertyName = "DocumentNumber";
            this.documentNumberDataGridViewTextBoxColumn.HeaderText = "DocumentNumber";
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
            this.bagPiecesDataGridViewTextBoxColumn.DataPropertyName = "BagPieces";
            this.bagPiecesDataGridViewTextBoxColumn.HeaderText = "BagPieces";
            this.bagPiecesDataGridViewTextBoxColumn.Name = "bagPiecesDataGridViewTextBoxColumn";
            // 
            // bagWeightDataGridViewTextBoxColumn
            // 
            this.bagWeightDataGridViewTextBoxColumn.DataPropertyName = "BagWeight";
            this.bagWeightDataGridViewTextBoxColumn.HeaderText = "BagWeight";
            this.bagWeightDataGridViewTextBoxColumn.Name = "bagWeightDataGridViewTextBoxColumn";
            // 
            // specialDataGridViewTextBoxColumn
            // 
            this.specialDataGridViewTextBoxColumn.DataPropertyName = "Special";
            this.specialDataGridViewTextBoxColumn.HeaderText = "Special";
            this.specialDataGridViewTextBoxColumn.Name = "specialDataGridViewTextBoxColumn";
            // 
            // passengerTableBindingSource
            // 
            this.passengerTableBindingSource.DataMember = "PassengerTable";
            this.passengerTableBindingSource.DataSource = this.piersDCSdatabaseDataSet6;
            // 
            // piersDCSdatabaseDataSet6
            // 
            this.piersDCSdatabaseDataSet6.DataSetName = "PiersDCSdatabaseDataSet6";
            this.piersDCSdatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.Font = new System.Drawing.Font("Pangolin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(28, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // passengerTableTableAdapter
            // 
            this.passengerTableTableAdapter.ClearBeforeFill = true;
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PiersDCS.Properties.Resources.FinallyBack;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvPrevPassenger);
            this.Name = "Preview";
            this.Text = "Preview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Preview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevPassenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piersDCSdatabaseDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.DataGridView dgvPrevPassenger;
        private PiersDCSdatabaseDataSet6 piersDCSdatabaseDataSet6;
        private System.Windows.Forms.BindingSource passengerTableBindingSource;
        private PiersDCSdatabaseDataSet6TableAdapters.PassengerTableTableAdapter passengerTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpassengerDataGridViewTextBoxColumn;
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