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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gboxRemark = new System.Windows.Forms.GroupBox();
            this.chDEAF = new System.Windows.Forms.CheckBox();
            this.chBLIND = new System.Windows.Forms.CheckBox();
            this.chWCHC = new System.Windows.Forms.CheckBox();
            this.chBChair = new System.Windows.Forms.CheckBox();
            this.chMAAS = new System.Windows.Forms.CheckBox();
            this.chPETS = new System.Windows.Forms.CheckBox();
            this.chUMNR = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lvPrev = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShAll = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.gboxRemark.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDest
            // 
            this.txtDest.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDest.Location = new System.Drawing.Point(168, 53);
            this.txtDest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(171, 22);
            this.txtDest.TabIndex = 411;
            this.txtDest.TextChanged += new System.EventHandler(this.txtDest_TextChanged);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label49.Location = new System.Drawing.Point(88, 53);
            this.label49.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(82, 18);
            this.label49.TabIndex = 410;
            this.label49.Text = "Destination:";
            // 
            // cmGender
            // 
            this.cmGender.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmGender.FormattingEnabled = true;
            this.cmGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmGender.Location = new System.Drawing.Point(72, 117);
            this.cmGender.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmGender.Name = "cmGender";
            this.cmGender.Size = new System.Drawing.Size(91, 26);
            this.cmGender.TabIndex = 408;
            // 
            // mstxtBirth
            // 
            this.mstxtBirth.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mstxtBirth.Location = new System.Drawing.Point(102, 198);
            this.mstxtBirth.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mstxtBirth.Mask = "00/00/0000";
            this.mstxtBirth.Name = "mstxtBirth";
            this.mstxtBirth.Size = new System.Drawing.Size(94, 22);
            this.mstxtBirth.TabIndex = 407;
            this.mstxtBirth.ValidatingType = typeof(System.DateTime);
            this.mstxtBirth.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mstxtBirth_MaskInputRejected);
            // 
            // mstxtDoc
            // 
            this.mstxtDoc.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mstxtDoc.Location = new System.Drawing.Point(321, 120);
            this.mstxtDoc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mstxtDoc.Mask = "00000000";
            this.mstxtDoc.Name = "mstxtDoc";
            this.mstxtDoc.Size = new System.Drawing.Size(107, 22);
            this.mstxtDoc.TabIndex = 406;
            this.mstxtDoc.ValidatingType = typeof(int);
            // 
            // mstxtseat1
            // 
            this.mstxtseat1.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mstxtseat1.Location = new System.Drawing.Point(376, 53);
            this.mstxtseat1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mstxtseat1.Mask = "##L";
            this.mstxtseat1.Name = "mstxtseat1";
            this.mstxtseat1.Size = new System.Drawing.Size(52, 22);
            this.mstxtseat1.TabIndex = 404;
            this.mstxtseat1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mstxtseat1_MaskInputRejected);
            // 
            // txtBagW
            // 
            this.txtBagW.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBagW.Location = new System.Drawing.Point(376, 198);
            this.txtBagW.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBagW.Name = "txtBagW";
            this.txtBagW.Size = new System.Drawing.Size(52, 22);
            this.txtBagW.TabIndex = 403;
            // 
            // txtBagP
            // 
            this.txtBagP.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBagP.Location = new System.Drawing.Point(376, 163);
            this.txtBagP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBagP.Name = "txtBagP";
            this.txtBagP.Size = new System.Drawing.Size(52, 22);
            this.txtBagP.TabIndex = 402;
            // 
            // txtNat
            // 
            this.txtNat.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNat.Location = new System.Drawing.Point(93, 159);
            this.txtNat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNat.Name = "txtNat";
            this.txtNat.Size = new System.Drawing.Size(182, 22);
            this.txtNat.TabIndex = 401;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(72, 87);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(356, 22);
            this.txtName.TabIndex = 400;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(304, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 398;
            this.label8.Text = "Bag weight:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(304, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 397;
            this.label7.Text = "Bag pieces:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 396;
            this.label6.Text = "Date of birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 395;
            this.label5.Text = "Nationality:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(194, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 394;
            this.label4.Text = "Document Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 393;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(339, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 392;
            this.label2.Text = "Seat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
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
            this.btnADD.Location = new System.Drawing.Point(16, 406);
            this.btnADD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(123, 36);
            this.btnADD.TabIndex = 412;
            this.btnADD.Text = "Add Passenger";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(262, 406);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 36);
            this.btnUpdate.TabIndex = 413;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.gboxRemark.Location = new System.Drawing.Point(17, 229);
            this.gboxRemark.Name = "gboxRemark";
            this.gboxRemark.Size = new System.Drawing.Size(303, 153);
            this.gboxRemark.TabIndex = 414;
            this.gboxRemark.TabStop = false;
            this.gboxRemark.Text = "Special Remark";
            this.gboxRemark.Enter += new System.EventHandler(this.gboxRemark_Enter);
            // 
            // chDEAF
            // 
            this.chDEAF.AutoSize = true;
            this.chDEAF.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chDEAF.Location = new System.Drawing.Point(166, 94);
            this.chDEAF.Name = "chDEAF";
            this.chDEAF.Size = new System.Drawing.Size(56, 22);
            this.chDEAF.TabIndex = 6;
            this.chDEAF.Text = "Deaf";
            this.chDEAF.UseVisualStyleBackColor = true;
            this.chDEAF.CheckedChanged += new System.EventHandler(this.chDEAF_CheckedChanged);
            // 
            // chBLIND
            // 
            this.chBLIND.AutoSize = true;
            this.chBLIND.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBLIND.Location = new System.Drawing.Point(166, 66);
            this.chBLIND.Name = "chBLIND";
            this.chBLIND.Size = new System.Drawing.Size(57, 22);
            this.chBLIND.TabIndex = 5;
            this.chBLIND.Text = "Blind";
            this.chBLIND.UseVisualStyleBackColor = true;
            this.chBLIND.CheckedChanged += new System.EventHandler(this.chBLIND_CheckedChanged);
            // 
            // chWCHC
            // 
            this.chWCHC.AutoSize = true;
            this.chWCHC.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chWCHC.Location = new System.Drawing.Point(166, 38);
            this.chWCHC.Name = "chWCHC";
            this.chWCHC.Size = new System.Drawing.Size(92, 22);
            this.chWCHC.TabIndex = 4;
            this.chWCHC.Text = "Wheelchair";
            this.chWCHC.UseVisualStyleBackColor = true;
            this.chWCHC.CheckedChanged += new System.EventHandler(this.chWCHC_CheckedChanged);
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
            this.chBChair.CheckedChanged += new System.EventHandler(this.chBChair_CheckedChanged);
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
            this.chMAAS.CheckedChanged += new System.EventHandler(this.chMAAS_CheckedChanged);
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
            this.chPETS.CheckedChanged += new System.EventHandler(this.chPETS_CheckedChanged);
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
            this.chUMNR.CheckedChanged += new System.EventHandler(this.chUMNR_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Location = new System.Drawing.Point(376, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 36);
            this.btnClose.TabIndex = 415;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lvPrev
            // 
            this.lvPrev.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvPrev.Font = new System.Drawing.Font("Pangolin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvPrev.GridLines = true;
            this.lvPrev.HideSelection = false;
            this.lvPrev.Location = new System.Drawing.Point(511, 53);
            this.lvPrev.Name = "lvPrev";
            this.lvPrev.Size = new System.Drawing.Size(333, 367);
            this.lvPrev.TabIndex = 416;
            this.lvPrev.UseCompatibleStateImageBehavior = false;
            this.lvPrev.View = System.Windows.Forms.View.Details;
            this.lvPrev.SelectedIndexChanged += new System.EventHandler(this.lvPrev_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Number";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Seat";
            // 
            // btnShAll
            // 
            this.btnShAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShAll.FlatAppearance.BorderSize = 0;
            this.btnShAll.Font = new System.Drawing.Font("Pangolin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShAll.ForeColor = System.Drawing.Color.Black;
            this.btnShAll.Location = new System.Drawing.Point(149, 406);
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
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(13, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 18);
            this.label9.TabIndex = 418;
            this.label9.Text = "Num:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Pangolin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtID.Location = new System.Drawing.Point(51, 53);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(30, 22);
            this.txtID.TabIndex = 419;
            // 
            // btnMap
            // 
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
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::PiersDCS.Properties.Resources.final;
            this.btnHome.Location = new System.Drawing.Point(0, -1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(38, 37);
            this.btnHome.TabIndex = 420;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // PassengerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PiersDCS.Properties.Resources.airplane_plane_flight_900;
            this.ClientSize = new System.Drawing.Size(874, 456);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnShAll);
            this.Controls.Add(this.lvPrev);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gboxRemark);
            this.Controls.Add(this.btnUpdate);
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Button btnShAll;
        public System.Windows.Forms.MaskedTextBox mstxtseat1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ComboBox cmGender;
        public System.Windows.Forms.MaskedTextBox mstxtBirth;
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
        public System.Windows.Forms.ListView lvPrev;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnHome;
    }
}