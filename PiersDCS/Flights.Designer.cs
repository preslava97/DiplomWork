namespace PiersDCS
{
    partial class Flights
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
            this.btnMap = new System.Windows.Forms.Button();
            this.btnFlights = new System.Windows.Forms.Button();
            this.FlightdataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piersDCSdatabaseDataSet = new PiersDCS.PiersDCSdatabaseDataSet();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flightTableTableAdapter1 = new PiersDCS.PiersDCSdatabaseDataSetTableAdapters.FlightTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FlightdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piersDCSdatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMap.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.Location = new System.Drawing.Point(102, 0);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(79, 37);
            this.btnMap.TabIndex = 20;
            this.btnMap.Text = "Seatmap";
            this.btnMap.UseVisualStyleBackColor = false;
            // 
            // btnFlights
            // 
            this.btnFlights.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFlights.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlights.Location = new System.Drawing.Point(34, 0);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.Size = new System.Drawing.Size(71, 37);
            this.btnFlights.TabIndex = 19;
            this.btnFlights.Text = "Flights";
            this.btnFlights.UseVisualStyleBackColor = false;
            this.btnFlights.Click += new System.EventHandler(this.btnFlights_Click);
            // 
            // FlightdataGridView1
            // 
            this.FlightdataGridView1.AllowUserToOrderColumns = true;
            this.FlightdataGridView1.AutoGenerateColumns = false;
            this.FlightdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.FlightdataGridView1.DataSource = this.flightTableBindingSource;
            this.FlightdataGridView1.Location = new System.Drawing.Point(12, 66);
            this.FlightdataGridView1.Name = "FlightdataGridView1";
            this.FlightdataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FlightdataGridView1.Size = new System.Drawing.Size(643, 231);
            this.FlightdataGridView1.TabIndex = 24;
            this.FlightdataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightDGV_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Flight Number";
            this.dataGridViewTextBoxColumn6.HeaderText = "Flight Number";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Destination";
            this.dataGridViewTextBoxColumn7.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn8.HeaderText = "City";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn9.HeaderText = "Time";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Check In Desk";
            this.dataGridViewTextBoxColumn10.HeaderText = "Check In Desk";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Gate";
            this.dataGridViewTextBoxColumn11.HeaderText = "Gate";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // flightTableBindingSource
            // 
            this.flightTableBindingSource.DataMember = "FlightTable";
            this.flightTableBindingSource.DataSource = this.piersDCSdatabaseDataSet;
            // 
            // piersDCSdatabaseDataSet
            // 
            this.piersDCSdatabaseDataSet.DataSetName = "PiersDCSdatabaseDataSet";
            this.piersDCSdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.BackgroundImage = global::PiersDCS.Properties.Resources.катинар1;
            this.btnLogout.Location = new System.Drawing.Point(178, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(31, 37);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::PiersDCS.Properties.Resources.final;
            this.btnHome.Location = new System.Drawing.Point(-2, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(38, 37);
            this.btnHome.TabIndex = 18;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Pangolin", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(25, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 42);
            this.button2.TabIndex = 25;
            this.button2.Text = "GET Flight";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flightTableTableAdapter1
            // 
            this.flightTableTableAdapter1.ClearBeforeFill = true;
            // 
            // Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::PiersDCS.Properties.Resources.airplane_plane_flight_900;
            this.ClientSize = new System.Drawing.Size(686, 407);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FlightdataGridView1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnFlights);
            this.Controls.Add(this.btnHome);
            this.Name = "Flights";
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.Flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piersDCSdatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnFlights;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView FlightdataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gateDataGridViewTextBoxColumn;
        private PiersDCSdatabaseDataSet1 piersDCSdatabaseDataSet1;
        private PiersDCSdatabaseDataSet1TableAdapters.FlightTableTableAdapter flightTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDeskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private PiersDCSdatabaseDataSet piersDCSdatabaseDataSet;
        private System.Windows.Forms.BindingSource flightTableBindingSource;
        private PiersDCSdatabaseDataSetTableAdapters.FlightTableTableAdapter flightTableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}