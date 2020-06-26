namespace PiersDCS
{
    partial class SignInForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.piersDCSdatabaseDataSet2 = new PiersDCS.PiersDCSdatabaseDataSet2();
            this.logInTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logInTableTableAdapter = new PiersDCS.PiersDCSdatabaseDataSet2TableAdapters.LogInTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.piersDCSdatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(325, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 82);
            this.label2.TabIndex = 7;
            this.label2.Text = "Welcome !";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Pangolin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username: ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Pangolin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(325, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 44);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password: ";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(462, 160);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(145, 20);
            this.txtUser.TabIndex = 10;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(462, 212);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(146, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLogIn.Font = new System.Drawing.Font("Pangolin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogIn.Location = new System.Drawing.Point(441, 253);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(84, 42);
            this.btnLogIn.TabIndex = 13;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Exit.Font = new System.Drawing.Font("Pangolin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Exit.Location = new System.Drawing.Point(543, 253);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(83, 42);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // piersDCSdatabaseDataSet2
            // 
            this.piersDCSdatabaseDataSet2.DataSetName = "PiersDCSdatabaseDataSet2";
            this.piersDCSdatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logInTableBindingSource
            // 
            this.logInTableBindingSource.DataMember = "LogInTable";
            this.logInTableBindingSource.DataSource = this.piersDCSdatabaseDataSet2;
            // 
            // logInTableTableAdapter
            // 
            this.logInTableTableAdapter.ClearBeforeFill = true;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PiersDCS.Properties.Resources.airplane_plane_flight_900;
            this.ClientSize = new System.Drawing.Size(906, 474);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignInForm";
            this.Text = "Piers DCS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piersDCSdatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Exit;
        private PiersDCSdatabaseDataSet2 piersDCSdatabaseDataSet2;
        private System.Windows.Forms.BindingSource logInTableBindingSource;
        private PiersDCSdatabaseDataSet2TableAdapters.LogInTableTableAdapter logInTableTableAdapter;
    }
}

