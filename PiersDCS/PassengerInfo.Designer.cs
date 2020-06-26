namespace PiersDCS
{
    partial class PassengerInfo
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
            this.txtDest = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.cmGender = new System.Windows.Forms.ComboBox();
            this.mstxtBirth = new System.Windows.Forms.MaskedTextBox();
            this.mstxtDoc = new System.Windows.Forms.MaskedTextBox();
            this.mstxtseat1 = new System.Windows.Forms.MaskedTextBox();
            this.txtBagW = new System.Windows.Forms.TextBox();
            this.txtBagP = new System.Windows.Forms.TextBox();
            this.txtNat = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gboxRemark = new System.Windows.Forms.GroupBox();
            this.chDEAF = new System.Windows.Forms.CheckBox();
            this.chBLIND = new System.Windows.Forms.CheckBox();
            this.chWCHC = new System.Windows.Forms.CheckBox();
            this.chBChair = new System.Windows.Forms.CheckBox();
            this.chMAAS = new System.Windows.Forms.CheckBox();
            this.chPETS = new System.Windows.Forms.CheckBox();
            this.chUMNR = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gboxRemark.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(139, 27);
            this.txtDest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(171, 27);
            this.txtDest.TabIndex = 411;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Font = new System.Drawing.Font("Pangolin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label49.Location = new System.Drawing.Point(26, 27);
            this.label49.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(103, 24);
            this.label49.TabIndex = 410;
            this.label49.Text = "Destination:";
            // 
            // cmGender
            // 
            this.cmGender.FormattingEnabled = true;
            this.cmGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmGender.Location = new System.Drawing.Point(94, 122);
            this.cmGender.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmGender.Name = "cmGender";
            this.cmGender.Size = new System.Drawing.Size(126, 32);
            this.cmGender.TabIndex = 408;
            // 
            // mstxtBirth
            // 
            this.mstxtBirth.Location = new System.Drawing.Point(139, 221);
            this.mstxtBirth.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mstxtBirth.Mask = "00/00/0000";
            this.mstxtBirth.Name = "mstxtBirth";
            this.mstxtBirth.Size = new System.Drawing.Size(182, 27);
            this.mstxtBirth.TabIndex = 407;
            this.mstxtBirth.ValidatingType = typeof(System.DateTime);
            // 
            // mstxtDoc
            // 
            this.mstxtDoc.Location = new System.Drawing.Point(418, 127);
            this.mstxtDoc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mstxtDoc.Mask = "0000000000";
            this.mstxtDoc.Name = "mstxtDoc";
            this.mstxtDoc.Size = new System.Drawing.Size(182, 27);
            this.mstxtDoc.TabIndex = 406;
            this.mstxtDoc.ValidatingType = typeof(int);
            // 
            // mstxtseat1
            // 
            this.mstxtseat1.Location = new System.Drawing.Point(388, 27);
            this.mstxtseat1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mstxtseat1.Mask = "###";
            this.mstxtseat1.Name = "mstxtseat1";
            this.mstxtseat1.Size = new System.Drawing.Size(52, 27);
            this.mstxtseat1.TabIndex = 404;
            this.mstxtseat1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mstxtseat1_MaskInputRejected);
            // 
            // txtBagW
            // 
            this.txtBagW.Location = new System.Drawing.Point(477, 221);
            this.txtBagW.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBagW.Name = "txtBagW";
            this.txtBagW.Size = new System.Drawing.Size(123, 27);
            this.txtBagW.TabIndex = 403;
            // 
            // txtBagP
            // 
            this.txtBagP.Location = new System.Drawing.Point(477, 172);
            this.txtBagP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBagP.Name = "txtBagP";
            this.txtBagP.Size = new System.Drawing.Size(123, 27);
            this.txtBagP.TabIndex = 402;
            // 
            // txtNat
            // 
            this.txtNat.Location = new System.Drawing.Point(139, 172);
            this.txtNat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNat.Name = "txtNat";
            this.txtNat.Size = new System.Drawing.Size(182, 27);
            this.txtNat.TabIndex = 401;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 78);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(356, 27);
            this.txtName.TabIndex = 400;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Pangolin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(373, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 24);
            this.label8.TabIndex = 398;
            this.label8.Text = "Bag weight:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Pangolin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(373, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 397;
            this.label7.Text = "Bag pieces:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Pangolin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(26, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 396;
            this.label6.Text = "Date of birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Pangolin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(26, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 395;
            this.label5.Text = "Nationality:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Pangolin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(254, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 24);
            this.label4.TabIndex = 394;
            this.label4.Text = "Document Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Pangolin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 393;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Pangolin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(337, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 392;
            this.label2.Text = "Seat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pangolin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 391;
            this.label1.Text = "Name:";
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnADD.ForeColor = System.Drawing.Color.Black;
            this.btnADD.Location = new System.Drawing.Point(40, 349);
            this.btnADD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(180, 41);
            this.btnADD.TabIndex = 412;
            this.btnADD.Text = "Add Passenger";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(245, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 41);
            this.button1.TabIndex = 413;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // gboxRemark
            // 
            this.gboxRemark.BackColor = System.Drawing.Color.Transparent;
            this.gboxRemark.Controls.Add(this.chDEAF);
            this.gboxRemark.Controls.Add(this.chBLIND);
            this.gboxRemark.Controls.Add(this.chWCHC);
            this.gboxRemark.Controls.Add(this.chBChair);
            this.gboxRemark.Controls.Add(this.chMAAS);
            this.gboxRemark.Controls.Add(this.chPETS);
            this.gboxRemark.Controls.Add(this.chUMNR);
            this.gboxRemark.Location = new System.Drawing.Point(620, 27);
            this.gboxRemark.Name = "gboxRemark";
            this.gboxRemark.Size = new System.Drawing.Size(164, 321);
            this.gboxRemark.TabIndex = 414;
            this.gboxRemark.TabStop = false;
            this.gboxRemark.Text = "Special remarks";
            // 
            // chDEAF
            // 
            this.chDEAF.AutoSize = true;
            this.chDEAF.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chDEAF.Location = new System.Drawing.Point(5, 208);
            this.chDEAF.Name = "chDEAF";
            this.chDEAF.Size = new System.Drawing.Size(56, 22);
            this.chDEAF.TabIndex = 6;
            this.chDEAF.Text = "Deaf";
            this.chDEAF.UseVisualStyleBackColor = true;
            this.chDEAF.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // chBLIND
            // 
            this.chBLIND.AutoSize = true;
            this.chBLIND.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBLIND.Location = new System.Drawing.Point(5, 180);
            this.chBLIND.Name = "chBLIND";
            this.chBLIND.Size = new System.Drawing.Size(57, 22);
            this.chBLIND.TabIndex = 5;
            this.chBLIND.Text = "Blind";
            this.chBLIND.UseVisualStyleBackColor = true;
            // 
            // chWCHC
            // 
            this.chWCHC.AutoSize = true;
            this.chWCHC.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chWCHC.Location = new System.Drawing.Point(6, 152);
            this.chWCHC.Name = "chWCHC";
            this.chWCHC.Size = new System.Drawing.Size(92, 22);
            this.chWCHC.TabIndex = 4;
            this.chWCHC.Text = "Wheelchair";
            this.chWCHC.UseVisualStyleBackColor = true;
            // 
            // chBChair
            // 
            this.chBChair.AutoSize = true;
            this.chBChair.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBChair.Location = new System.Drawing.Point(6, 123);
            this.chBChair.Name = "chBChair";
            this.chBChair.Size = new System.Drawing.Size(89, 22);
            this.chBChair.TabIndex = 3;
            this.chBChair.Text = "Baby Chair";
            this.chBChair.UseVisualStyleBackColor = true;
            // 
            // chMAAS
            // 
            this.chMAAS.AutoSize = true;
            this.chMAAS.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chMAAS.Location = new System.Drawing.Point(6, 95);
            this.chMAAS.Name = "chMAAS";
            this.chMAAS.Size = new System.Drawing.Size(92, 22);
            this.chMAAS.TabIndex = 2;
            this.chMAAS.Text = "Assistance";
            this.chMAAS.UseVisualStyleBackColor = true;
            // 
            // chPETS
            // 
            this.chPETS.AutoSize = true;
            this.chPETS.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chPETS.Location = new System.Drawing.Point(6, 66);
            this.chPETS.Name = "chPETS";
            this.chPETS.Size = new System.Drawing.Size(58, 22);
            this.chPETS.TabIndex = 1;
            this.chPETS.Text = "PETS";
            this.chPETS.UseVisualStyleBackColor = true;
            // 
            // chUMNR
            // 
            this.chUMNR.AutoSize = true;
            this.chUMNR.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chUMNR.Location = new System.Drawing.Point(6, 38);
            this.chUMNR.Name = "chUMNR";
            this.chUMNR.Size = new System.Drawing.Size(160, 22);
            this.chUMNR.TabIndex = 0;
            this.chUMNR.Text = "Unaccompanied Minor";
            this.chUMNR.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Location = new System.Drawing.Point(428, 349);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 41);
            this.btnClose.TabIndex = 415;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // PassengerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PiersDCS.Properties.Resources.airplane_plane_flight_900;
            this.ClientSize = new System.Drawing.Size(785, 431);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gboxRemark);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.cmGender);
            this.Controls.Add(this.mstxtBirth);
            this.Controls.Add(this.mstxtDoc);
            this.Controls.Add(this.mstxtseat1);
            this.Controls.Add(this.txtBagW);
            this.Controls.Add(this.txtBagP);
            this.Controls.Add(this.txtNat);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Pangolin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "PassengerInfo";
            this.Text = "PassengerInfo";
            this.Load += new System.EventHandler(this.PassengerInfo_Load);
            this.gboxRemark.ResumeLayout(false);
            this.gboxRemark.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.ComboBox cmGender;
        private System.Windows.Forms.MaskedTextBox mstxtBirth;
        private System.Windows.Forms.MaskedTextBox mstxtDoc;
        private System.Windows.Forms.MaskedTextBox mstxtseat1;
        private System.Windows.Forms.TextBox txtBagW;
        private System.Windows.Forms.TextBox txtBagP;
        private System.Windows.Forms.TextBox txtNat;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gboxRemark;
        private System.Windows.Forms.CheckBox chDEAF;
        private System.Windows.Forms.CheckBox chBLIND;
        private System.Windows.Forms.CheckBox chWCHC;
        private System.Windows.Forms.CheckBox chBChair;
        private System.Windows.Forms.CheckBox chMAAS;
        private System.Windows.Forms.CheckBox chPETS;
        private System.Windows.Forms.CheckBox chUMNR;
        private System.Windows.Forms.Button btnClose;
    }
}