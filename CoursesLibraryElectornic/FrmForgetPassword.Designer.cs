namespace CoursesLibraryElectornic
{
    partial class FrmForgetPassword
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
            lblTitle = new Label();
            lblDescription = new Label();
            rbEmail = new RadioButton();
            rbMobile = new RadioButton();
            txtRecovery = new TextBox();
            btnContinue = new Button();
            lblBackToLogin = new Label();
            lblRecovery = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.SaddleBrown;
            lblTitle.Location = new Point(293, 32);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(390, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Forgot Password?";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Brown;
            lblDescription.Location = new Point(360, 118);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(276, 28);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Choose your recovery method";
            // 
            // rbEmail
            // 
            rbEmail.AutoSize = true;
            rbEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbEmail.ForeColor = Color.Maroon;
            rbEmail.ImageAlign = ContentAlignment.MiddleLeft;
            rbEmail.Location = new Point(47, 164);
            rbEmail.Margin = new Padding(4, 3, 4, 3);
            rbEmail.Name = "rbEmail";
            rbEmail.Size = new Size(170, 32);
            rbEmail.TabIndex = 2;
            rbEmail.TabStop = true;
            rbEmail.Text = " Email Address";
            rbEmail.UseVisualStyleBackColor = true;
            rbEmail.CheckedChanged += rbEmail_CheckedChanged;
            // 
            // rbMobile
            // 
            rbMobile.AutoSize = true;
            rbMobile.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbMobile.ForeColor = Color.Maroon;
            rbMobile.Location = new Point(47, 230);
            rbMobile.Margin = new Padding(4, 3, 4, 3);
            rbMobile.Name = "rbMobile";
            rbMobile.Size = new Size(187, 32);
            rbMobile.TabIndex = 3;
            rbMobile.TabStop = true;
            rbMobile.Text = " Mobile Number";
            rbMobile.UseVisualStyleBackColor = true;
            rbMobile.CheckedChanged += rbMobile_CheckedChanged;
            // 
            // txtRecovery
            // 
            txtRecovery.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRecovery.Location = new Point(211, 314);
            txtRecovery.Margin = new Padding(4, 3, 4, 3);
            txtRecovery.Name = "txtRecovery";
            txtRecovery.Size = new Size(617, 37);
            txtRecovery.TabIndex = 4;
            txtRecovery.TextChanged += txtRecovery_TextChanged;
            // 
            // btnContinue
            // 
            btnContinue.Cursor = Cursors.Hand;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.Location = new Point(360, 390);
            btnContinue.Margin = new Padding(4, 3, 4, 3);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(390, 50);
            btnContinue.TabIndex = 5;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += button1_Click;
            // 
            // lblBackToLogin
            // 
            lblBackToLogin.AutoSize = true;
            lblBackToLogin.Cursor = Cursors.Hand;
            lblBackToLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBackToLogin.ForeColor = Color.Maroon;
            lblBackToLogin.Location = new Point(867, 466);
            lblBackToLogin.Name = "lblBackToLogin";
            lblBackToLogin.Size = new Size(136, 28);
            lblBackToLogin.TabIndex = 6;
            lblBackToLogin.Text = "Back to Login";
            lblBackToLogin.Click += lblBackToLogin_Click;
            // 
            // lblRecovery
            // 
            lblRecovery.AutoSize = true;
            lblRecovery.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecovery.ForeColor = Color.Maroon;
            lblRecovery.Location = new Point(211, 283);
            lblRecovery.Name = "lblRecovery";
            lblRecovery.Size = new Size(139, 28);
            lblRecovery.TabIndex = 7;
            lblRecovery.Text = "Email Address";
            lblRecovery.Click += lblRecovery_Click;
            // 
            // FrmForgetPassword
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(1054, 553);
            Controls.Add(lblRecovery);
            Controls.Add(lblBackToLogin);
            Controls.Add(btnContinue);
            Controls.Add(txtRecovery);
            Controls.Add(rbMobile);
            Controls.Add(rbEmail);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.SaddleBrown;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmForgetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmForgetPassword";
            Load += FrmForgetPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDescription;
        private RadioButton rbEmail;
        private RadioButton rbMobile;
        private TextBox txtRecovery;
        private Button btnContinue;
        private Label lblBackToLogin;
        private Label lblRecovery;
    }
}