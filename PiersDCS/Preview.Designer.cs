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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.passengerTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Back = new System.Windows.Forms.Button();
            this.btnDEL = new System.Windows.Forms.Button();
            this.passengerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piersDCSdatabaseDataSet4 = new PiersDCS.PiersDCSdatabaseDataSet4();
            this.passengerTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.passengerTableTableAdapter = new PiersDCS.PiersDCSdatabaseDataSet4TableAdapters.PassengerTableTableAdapter();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piersDCSdatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreview
            // 
            this.dgvPreview.AllowUserToAddRows = false;
            this.dgvPreview.AllowUserToOrderColumns = true;
            this.dgvPreview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvPreview.AutoGenerateColumns = false;
            this.dgvPreview.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dgvPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPreview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.destinationDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.seatDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvPreview.DataSource = this.passengerTableBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Pangolin", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPreview.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPreview.Location = new System.Drawing.Point(56, 12);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.Size = new System.Drawing.Size(1017, 369);
            this.dgvPreview.TabIndex = 0;
            this.dgvPreview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreview_CellContentClick);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Pangolin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Back.Location = new System.Drawing.Point(32, 394);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(91, 36);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDEL
            // 
            this.btnDEL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDEL.FlatAppearance.BorderSize = 0;
            this.btnDEL.Font = new System.Drawing.Font("Pangolin", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDEL.ForeColor = System.Drawing.Color.Black;
            this.btnDEL.Location = new System.Drawing.Point(139, 395);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(159, 35);
            this.btnDEL.TabIndex = 39;
            this.btnDEL.Text = "Delete Passenger";
            this.btnDEL.UseVisualStyleBackColor = false;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // piersDCSdatabaseDataSet4
            // 
            this.piersDCSdatabaseDataSet4.DataSetName = "PiersDCSdatabaseDataSet4";
            this.piersDCSdatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passengerTableBindingSource1
            // 
            this.passengerTableBindingSource1.DataMember = "PassengerTable";
            this.passengerTableBindingSource1.DataSource = this.piersDCSdatabaseDataSet4;
            // 
            // passengerTableTableAdapter
            // 
            this.passengerTableTableAdapter.ClearBeforeFill = true;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // seatDataGridViewTextBoxColumn
            // 
            this.seatDataGridViewTextBoxColumn.DataPropertyName = "Seat";
            this.seatDataGridViewTextBoxColumn.HeaderText = "Seat";
            this.seatDataGridViewTextBoxColumn.Name = "seatDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn2.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Document Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Document Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nationality";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nationality";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date of birth";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date of birth";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Bag Pieces";
            this.dataGridViewTextBoxColumn6.HeaderText = "Bag Pieces";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Bag Weight";
            this.dataGridViewTextBoxColumn7.HeaderText = "Bag Weight";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Special";
            this.dataGridViewTextBoxColumn8.HeaderText = "Special";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PiersDCS.Properties.Resources.airplane_plane_flight_900;
            this.ClientSize = new System.Drawing.Size(1103, 435);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dgvPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Preview";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Preview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piersDCSdatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreview;
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
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.BindingSource passengerTableBindingSource;
        private System.Windows.Forms.BindingSource passengerTableBindingSource3;
        private PiersDCSdatabaseDataSet4 piersDCSdatabaseDataSet4;
        private System.Windows.Forms.BindingSource passengerTableBindingSource1;
        private PiersDCSdatabaseDataSet4TableAdapters.PassengerTableTableAdapter passengerTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}