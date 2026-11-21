using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoursesLibraryElectornic
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblAlreadyAccount_Click(object sender, EventArgs e)
        {

        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
       string.IsNullOrWhiteSpace(txtEmail.Text) ||
       string.IsNullOrWhiteSpace(txtPhone.Text) ||
       string.IsNullOrWhiteSpace(txtPassword.Text) ||
       string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            MessageBox.Show("All data is valid!");
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            FrmLodin login = new FrmLodin();
            login.Show();
            this.Hide();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
