using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoursesLibraryElectornic
{
    public partial class FrmForgetPassword : Form
    {
        public FrmForgetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRecovery.Text))
            {
                MessageBox.Show("Please enter your Email or Mobile Number");
            }
            else
            {
                MessageBox.Show("Please check your entered information");
            }
        }

        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbEmail_CheckedChanged(object sender, EventArgs e)
        {
            lblRecovery.Text = "Email Address";
            txtRecovery.Clear();
        }

        private void rbMobile_CheckedChanged(object sender, EventArgs e)
        {
            lblRecovery.Text = "Mobile Number";
            txtRecovery.Clear();
        }

        private void txtRecovery_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void FrmForgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void lblRecovery_Click(object sender, EventArgs e)
        {

        }
    }
}
