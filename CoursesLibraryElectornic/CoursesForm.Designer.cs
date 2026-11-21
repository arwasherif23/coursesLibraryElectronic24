namespace CoursesLibraryElectornic
{
    partial class FrmLodin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLodin));
            PniImage = new Panel();
            pnllmage = new Panel();
            pictureBox1 = new PictureBox();
            pniLogin = new Panel();
            picLogo = new PictureBox();
            label2 = new Label();
            lblDecoration = new Label();
            lblSignUp = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblUser = new Label();
            txtUser = new TextBox();
            lblForgot = new Label();
            btnLogin = new Button();
            chkRemember = new CheckBox();
            lblAccount = new Label();
            label1 = new Label();
            PniImage.SuspendLayout();
            pnllmage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pniLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // PniImage
            // 
            PniImage.BackColor = Color.BlanchedAlmond;
            PniImage.Controls.Add(pnllmage);
            PniImage.Dock = DockStyle.Left;
            PniImage.Location = new Point(0, 0);
            PniImage.Name = "PniImage";
            PniImage.Size = new Size(443, 620);
            PniImage.TabIndex = 0;
            // 
            // pnllmage
            // 
            pnllmage.Controls.Add(pictureBox1);
            pnllmage.Dock = DockStyle.Fill;
            pnllmage.Location = new Point(0, 0);
            pnllmage.Name = "pnllmage";
            pnllmage.Size = new Size(443, 620);
            pnllmage.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 620);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pniLogin
            // 
            pniLogin.BackColor = Color.BlanchedAlmond;
            pniLogin.Controls.Add(picLogo);
            pniLogin.Controls.Add(label2);
            pniLogin.Controls.Add(lblDecoration);
            pniLogin.Controls.Add(lblSignUp);
            pniLogin.Controls.Add(txtPassword);
            pniLogin.Controls.Add(lblPassword);
            pniLogin.Controls.Add(lblUser);
            pniLogin.Controls.Add(txtUser);
            pniLogin.Controls.Add(lblForgot);
            pniLogin.Controls.Add(btnLogin);
            pniLogin.Controls.Add(chkRemember);
            pniLogin.Controls.Add(lblAccount);
            pniLogin.Controls.Add(label1);
            pniLogin.Dock = DockStyle.Right;
            pniLogin.Location = new Point(449, 0);
            pniLogin.Name = "pniLogin";
            pniLogin.Size = new Size(660, 620);
            pniLogin.TabIndex = 1;
            pniLogin.Paint += pniLogin_Paint;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.BlanchedAlmond;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(208, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(241, 144);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 14;
            picLogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(174, 150);
            label2.Name = "label2";
            label2.Size = new Size(325, 48);
            label2.TabIndex = 13;
            label2.Text = "COURSE LIBRARY ";
            label2.Click += label2_Click_1;
            // 
            // lblDecoration
            // 
            lblDecoration.AutoSize = true;
            lblDecoration.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDecoration.ForeColor = Color.Maroon;
            lblDecoration.Location = new Point(121, 163);
            lblDecoration.Name = "lblDecoration";
            lblDecoration.Size = new Size(432, 45);
            lblDecoration.TabIndex = 12;
            lblDecoration.Text = "✦ ___________________________✦";
            lblDecoration.Click += lblDecoration_Click;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignUp.ForeColor = Color.IndianRed;
            lblSignUp.Location = new Point(525, 536);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(78, 25);
            lblSignUp.TabIndex = 11;
            lblSignUp.Text = "Sign Up";
            lblSignUp.Click += lblSignUp_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(174, 375);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(320, 31);
            txtPassword.TabIndex = 10;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Maroon;
            lblPassword.Location = new Point(174, 347);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 25);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password";
            lblPassword.Click += lblPassword_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.Maroon;
            lblUser.Location = new Point(174, 270);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(50, 25);
            lblUser.TabIndex = 8;
            lblUser.Text = "User";
            lblUser.Click += lblUser_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(174, 298);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(320, 31);
            txtUser.TabIndex = 7;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // lblForgot
            // 
            lblForgot.AutoSize = true;
            lblForgot.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblForgot.ForeColor = Color.IndianRed;
            lblForgot.Location = new Point(478, 429);
            lblForgot.Name = "lblForgot";
            lblForgot.Size = new Size(159, 25);
            lblForgot.TabIndex = 6;
            lblForgot.Text = "Forgot Password?";
            lblForgot.Click += label3_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Maroon;
            btnLogin.Location = new Point(276, 473);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(154, 38);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += lblTitle_Click;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkRemember.ForeColor = Color.Maroon;
            chkRemember.Location = new Point(63, 425);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(161, 29);
            chkRemember.TabIndex = 4;
            chkRemember.Text = "Remember Me";
            chkRemember.UseVisualStyleBackColor = true;
            chkRemember.CheckedChanged += chkRemember_CheckedChanged;
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccount.ForeColor = Color.Maroon;
            lblAccount.Location = new Point(48, 536);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(203, 25);
            lblAccount.TabIndex = 1;
            lblAccount.Text = "Don't have an account?";
            lblAccount.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(208, 208);
            label1.Name = "label1";
            label1.Size = new Size(263, 53);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // FrmLodin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1109, 620);
            Controls.Add(pniLogin);
            Controls.Add(PniImage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLodin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ok";
            Load += FrmLodin_Load;
            PniImage.ResumeLayout(false);
            pnllmage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pniLogin.ResumeLayout(false);
            pniLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PniImage;
        private Panel pniLogin;
        private Label lblAccount;
        private Label label1;
        private Panel pnllmage;
        private PictureBox pictureBox1;
        private Label lblForgot;
        private Button btnLogin;
        private CheckBox chkRemember;
        private TextBox txtUser;
        private Label lblPassword;
        private Label lblUser;
        private TextBox txtPassword;
        private Label lblSignUp;
        private Label lblDecoration;
        private Label label2;
        private PictureBox picLogo;
    }
}