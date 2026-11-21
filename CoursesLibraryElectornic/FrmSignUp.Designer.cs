namespace CoursesLibraryElectornic
{
    partial class FrmSignUp
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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            btnSignUp = new Button();
            lblAlreadyAccount = new Label();
            lblLogin = new Label();
            lblTitle2 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Maroon;
            lblTitle.Location = new Point(476, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(366, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CREATE ACCOUNT";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.Maroon;
            lblFirstName.Location = new Point(25, 105);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(110, 28);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            lblFirstName.Click += lblFirstName_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(24, 136);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(482, 38);
            txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.Maroon;
            lblLastName.Location = new Point(25, 192);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(108, 28);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name";
            lblLastName.Click += lblLastName_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(24, 223);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(478, 35);
            txtLastName.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Maroon;
            lblEmail.Location = new Point(27, 272);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(139, 28);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email Address";
            lblEmail.Click += lblEmail_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(27, 303);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(476, 37);
            txtEmail.TabIndex = 6;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.Maroon;
            lblPhone.Location = new Point(25, 353);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(152, 28);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone Number";
            lblPhone.Click += lblPhone_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(25, 384);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(478, 35);
            txtPhone.TabIndex = 8;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Maroon;
            lblPassword.Location = new Point(25, 433);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 28);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password";
            lblPassword.Click += lblPassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(25, 464);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(477, 37);
            txtPassword.TabIndex = 10;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(25, 517);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(176, 28);
            lblConfirmPassword.TabIndex = 11;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(25, 548);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(473, 35);
            txtConfirmPassword.TabIndex = 12;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // btnSignUp
            // 
            btnSignUp.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(348, 606);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(574, 44);
            btnSignUp.TabIndex = 13;
            btnSignUp.Text = "Create Account";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lblAlreadyAccount
            // 
            lblAlreadyAccount.AutoSize = true;
            lblAlreadyAccount.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlreadyAccount.Location = new Point(476, 670);
            lblAlreadyAccount.Name = "lblAlreadyAccount";
            lblAlreadyAccount.Size = new Size(222, 21);
            lblAlreadyAccount.TabIndex = 14;
            lblAlreadyAccount.Text = "Already have an account?";
            lblAlreadyAccount.Click += lblAlreadyAccount_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(706, 670);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(56, 21);
            lblLogin.TabIndex = 15;
            lblLogin.Text = "Login";
            lblLogin.Click += lblLogin_Click;
            // 
            // lblTitle2
            // 
            lblTitle2.AutoSize = true;
            lblTitle2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle2.ForeColor = Color.Peru;
            lblTitle2.Location = new Point(557, 74);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new Size(205, 22);
            lblTitle2.TabIndex = 16;
            lblTitle2.Text = "Join Us and Start Learning";
            // 
            // FrmSignUp
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(1007, 702);
            Controls.Add(lblTitle2);
            Controls.Add(lblLogin);
            Controls.Add(lblAlreadyAccount);
            Controls.Add(btnSignUp);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Maroon;
            Name = "FrmSignUp";
            Text = "FrmSignUp";
            Load += FrmSignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Button btnSignUp;
        private Label lblAlreadyAccount;
        private Label lblLogin;
        private Label lblTitle2;
    }
}