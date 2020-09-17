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
            this.label49 = new System.Windows.Forms.Label();
            this.cmGender = new System.Windows.Forms.ComboBox();
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
            this.gboxRemark = new System.Windows.Forms.GroupBox();
            this.checkVisa = new System.Windows.Forms.CheckBox();
            this.chDEAF = new System.Windows.Forms.CheckBox();
            this.chBLIND = new System.Windows.Forms.CheckBox();
            this.chWCHC = new System.Windows.Forms.CheckBox();
            this.chBChair = new System.Windows.Forms.CheckBox();
            this.chMAAS = new System.Windows.Forms.CheckBox();
            this.chPETS = new System.Windows.Forms.CheckBox();
            this.chUMNR = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShAll = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gboxRemark.SuspendLayout();
            this.SuspendLayout();
            // 
            // label49
            // 
            this.label49.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label49.Location = new System.Drawing.Point(207, 52);
            this.label49.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(98, 23);
            this.label49.TabIndex = 410;
            this.label49.Text = "Destination:";
            // 
            // cmGender
            // 
            this.cmGender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmGender.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmGender.FormattingEnabled = true;
            this.cmGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmGender.Location = new System.Drawing.Point(149, 130);
            this.cmGender.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmGender.Name = "cmGender";
            this.cmGender.Size = new System.Drawing.Size(91, 26);
            this.cmGender.TabIndex = 408;
            // 
            // mstxtDoc
            // 
            this.mstxtDoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mstxtDoc.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mstxtDoc.Location = new System.Drawing.Point(540, 132);
            this.mstxtDoc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mstxtDoc.Mask = "00000000";
            this.mstxtDoc.Name = "mstxtDoc";
            this.mstxtDoc.Size = new System.Drawing.Size(107, 22);
            this.mstxtDoc.TabIndex = 406;
            this.mstxtDoc.ValidatingType = typeof(int);
            this.mstxtDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mstxtDoc_KeyPress);
            // 
            // mstxtseat1
            // 
            this.mstxtseat1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mstxtseat1.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mstxtseat1.Location = new System.Drawing.Point(595, 59);
            this.mstxtseat1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mstxtseat1.Mask = "##L";
            this.mstxtseat1.Name = "mstxtseat1";
            this.mstxtseat1.Size = new System.Drawing.Size(52, 22);
            this.mstxtseat1.TabIndex = 404;
            this.mstxtseat1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mstxtseat1_MaskInputRejected);
            // 
            // txtBagW
            // 
            this.txtBagW.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBagW.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBagW.Location = new System.Drawing.Point(595, 211);
            this.txtBagW.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBagW.Name = "txtBagW";
            this.txtBagW.Size = new System.Drawing.Size(52, 22);
            this.txtBagW.TabIndex = 403;
            // 
            // txtBagP
            // 
            this.txtBagP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBagP.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBagP.Location = new System.Drawing.Point(595, 177);
            this.txtBagP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBagP.Name = "txtBagP";
            this.txtBagP.Size = new System.Drawing.Size(52, 22);
            this.txtBagP.TabIndex = 402;
            // 
            // txtNat
            // 
            this.txtNat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNat.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNat.Location = new System.Drawing.Point(179, 177);
            this.txtNat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNat.Name = "txtNat";
            this.txtNat.Size = new System.Drawing.Size(182, 22);
            this.txtNat.TabIndex = 401;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(149, 90);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(356, 22);
            this.txtName.TabIndex = 400;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(507, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 23);
            this.label8.TabIndex = 398;
            this.label8.Text = "Bag weight:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(507, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 397;
            this.label7.Text = "Bag pieces:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(90, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 396;
            this.label6.Text = "Date of birth:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(90, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 395;
            this.label5.Text = "Nationality:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(396, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 394;
            this.label4.Text = "Document Number:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(89, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 393;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(549, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 392;
            this.label2.Text = "Seat:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(91, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 391;
            this.label1.Text = "Name:";
            // 
            // btnADD
            // 
            this.btnADD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnADD.AutoSize = true;
            this.btnADD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnADD.ForeColor = System.Drawing.Color.Black;
            this.btnADD.Location = new System.Drawing.Point(162, 437);
            this.btnADD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(123, 36);
            this.btnADD.TabIndex = 412;
            this.btnADD.Text = "Add Passenger";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click_1);
            // 
            // gboxRemark
            // 
            this.gboxRemark.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gboxRemark.BackColor = System.Drawing.Color.Transparent;
            this.gboxRemark.Controls.Add(this.checkVisa);
            this.gboxRemark.Controls.Add(this.chDEAF);
            this.gboxRemark.Controls.Add(this.chBLIND);
            this.gboxRemark.Controls.Add(this.chWCHC);
            this.gboxRemark.Controls.Add(this.chBChair);
            this.gboxRemark.Controls.Add(this.chMAAS);
            this.gboxRemark.Controls.Add(this.chPETS);
            this.gboxRemark.Controls.Add(this.chUMNR);
            this.gboxRemark.Location = new System.Drawing.Point(168, 260);
            this.gboxRemark.Name = "gboxRemark";
            this.gboxRemark.Size = new System.Drawing.Size(378, 168);
            this.gboxRemark.TabIndex = 414;
            this.gboxRemark.TabStop = false;
            this.gboxRemark.Text = "Special Remark";
            this.gboxRemark.Enter += new System.EventHandler(this.gboxRemark_Enter);
            // 
            // checkVisa
            // 
            this.checkVisa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkVisa.AutoSize = true;
            this.checkVisa.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkVisa.Location = new System.Drawing.Point(204, 133);
            this.checkVisa.Name = "checkVisa";
            this.checkVisa.Size = new System.Drawing.Size(59, 27);
            this.checkVisa.TabIndex = 7;
            this.checkVisa.Text = "Visa";
            this.checkVisa.UseVisualStyleBackColor = true;
            this.checkVisa.CheckedChanged += new System.EventHandler(this.checkVisa_CheckedChanged);
            // 
            // chDEAF
            // 
            this.chDEAF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chDEAF.AutoSize = true;
            this.chDEAF.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chDEAF.Location = new System.Drawing.Point(204, 104);
            this.chDEAF.Name = "chDEAF";
            this.chDEAF.Size = new System.Drawing.Size(62, 27);
            this.chDEAF.TabIndex = 6;
            this.chDEAF.Text = "Deaf";
            this.chDEAF.UseVisualStyleBackColor = true;
            this.chDEAF.CheckedChanged += new System.EventHandler(this.chDEAF_CheckedChanged);
            // 
            // chBLIND
            // 
            this.chBLIND.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chBLIND.AutoSize = true;
            this.chBLIND.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBLIND.Location = new System.Drawing.Point(204, 76);
            this.chBLIND.Name = "chBLIND";
            this.chBLIND.Size = new System.Drawing.Size(64, 27);
            this.chBLIND.TabIndex = 5;
            this.chBLIND.Text = "Blind";
            this.chBLIND.UseVisualStyleBackColor = true;
            this.chBLIND.CheckedChanged += new System.EventHandler(this.chBLIND_CheckedChanged);
            // 
            // chWCHC
            // 
            this.chWCHC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chWCHC.AutoSize = true;
            this.chWCHC.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chWCHC.Location = new System.Drawing.Point(204, 48);
            this.chWCHC.Name = "chWCHC";
            this.chWCHC.Size = new System.Drawing.Size(107, 27);
            this.chWCHC.TabIndex = 4;
            this.chWCHC.Text = "Wheelchair";
            this.chWCHC.UseVisualStyleBackColor = true;
            this.chWCHC.CheckedChanged += new System.EventHandler(this.chWCHC_CheckedChanged);
            // 
            // chBChair
            // 
            this.chBChair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chBChair.AutoSize = true;
            this.chBChair.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBChair.Location = new System.Drawing.Point(11, 133);
            this.chBChair.Name = "chBChair";
            this.chBChair.Size = new System.Drawing.Size(101, 27);
            this.chBChair.TabIndex = 3;
            this.chBChair.Text = "Baby Chair";
            this.chBChair.UseVisualStyleBackColor = true;
            this.chBChair.CheckedChanged += new System.EventHandler(this.chBChair_CheckedChanged);
            // 
            // chMAAS
            // 
            this.chMAAS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chMAAS.AutoSize = true;
            this.chMAAS.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chMAAS.Location = new System.Drawing.Point(11, 105);
            this.chMAAS.Name = "chMAAS";
            this.chMAAS.Size = new System.Drawing.Size(109, 27);
            this.chMAAS.TabIndex = 2;
            this.chMAAS.Text = "Assistance";
            this.chMAAS.UseVisualStyleBackColor = true;
            this.chMAAS.CheckedChanged += new System.EventHandler(this.chMAAS_CheckedChanged);
            // 
            // chPETS
            // 
            this.chPETS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chPETS.AutoSize = true;
            this.chPETS.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chPETS.Location = new System.Drawing.Point(11, 76);
            this.chPETS.Name = "chPETS";
            this.chPETS.Size = new System.Drawing.Size(66, 27);
            this.chPETS.TabIndex = 1;
            this.chPETS.Text = "PETS";
            this.chPETS.UseVisualStyleBackColor = true;
            this.chPETS.CheckedChanged += new System.EventHandler(this.chPETS_CheckedChanged);
            // 
            // chUMNR
            // 
            this.chUMNR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chUMNR.AutoSize = true;
            this.chUMNR.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chUMNR.Location = new System.Drawing.Point(11, 48);
            this.chUMNR.Name = "chUMNR";
            this.chUMNR.Size = new System.Drawing.Size(187, 27);
            this.chUMNR.TabIndex = 0;
            this.chUMNR.Text = "Unaccompanied Minor";
            this.chUMNR.UseVisualStyleBackColor = true;
            this.chUMNR.CheckedChanged += new System.EventHandler(this.chUMNR_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Location = new System.Drawing.Point(630, 437);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 36);
            this.btnClose.TabIndex = 415;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShAll
            // 
            this.btnShAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShAll.AutoSize = true;
            this.btnShAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShAll.FlatAppearance.BorderSize = 0;
            this.btnShAll.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShAll.ForeColor = System.Drawing.Color.Black;
            this.btnShAll.Location = new System.Drawing.Point(515, 437);
            this.btnShAll.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnShAll.Name = "btnShAll";
            this.btnShAll.Size = new System.Drawing.Size(96, 36);
            this.btnShAll.TabIndex = 417;
            this.btnShAll.Text = "Show All ";
            this.btnShAll.UseVisualStyleBackColor = false;
            this.btnShAll.Click += new System.EventHandler(this.btnShAll_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(89, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 23);
            this.label9.TabIndex = 418;
            this.label9.Text = "Num:";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtID.Location = new System.Drawing.Point(149, 57);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(30, 22);
            this.txtID.TabIndex = 419;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnMap
            // 
            this.btnMap.AutoSize = true;
            this.btnMap.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMap.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.Location = new System.Drawing.Point(36, -1);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(103, 37);
            this.btnMap.TabIndex = 421;
            this.btnMap.Text = "Boarding";
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::PiersDCS.Properties.Resources.final;
            this.btnHome.Location = new System.Drawing.Point(0, -1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(38, 37);
            this.btnHome.TabIndex = 420;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(303, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 24);
            this.label10.TabIndex = 422;
            this.label10.Text = " ";
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Update.AutoSize = true;
            this.btn_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.Location = new System.Drawing.Point(295, 437);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(96, 36);
            this.btn_Update.TabIndex = 423;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Delete.AutoSize = true;
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(409, 437);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(96, 36);
            this.btn_Delete.TabIndex = 424;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 27);
            this.textBox1.TabIndex = 425;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(36, 437);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 36);
            this.btnSearch.TabIndex = 426;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // PassengerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PiersDCS.Properties.Resources.FinallyBack;
            this.ClientSize = new System.Drawing.Size(750, 481);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnShAll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gboxRemark);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.cmGender);
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
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnShAll;
        public System.Windows.Forms.MaskedTextBox mstxtseat1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cmGender;
        public System.Windows.Forms.MaskedTextBox mstxtDoc;
        public System.Windows.Forms.TextBox txtBagW;
        public System.Windows.Forms.TextBox txtBagP;
        public System.Windows.Forms.TextBox txtNat;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.GroupBox gboxRemark;
        public System.Windows.Forms.CheckBox chDEAF;
        public System.Windows.Forms.CheckBox chBLIND;
        public System.Windows.Forms.CheckBox chWCHC;
        public System.Windows.Forms.CheckBox chBChair;
        public System.Windows.Forms.CheckBox chMAAS;
        public System.Windows.Forms.CheckBox chPETS;
        public System.Windows.Forms.CheckBox chUMNR;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        public System.Windows.Forms.CheckBox checkVisa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
    }
}