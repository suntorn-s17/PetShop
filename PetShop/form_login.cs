using PetShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void Login()
        {
            Login login = new Login(tbUsername.Text.Trim(), tbPassword.Text.Trim());

            if (login.Authenticate())
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form_main mainForm = new form_main(tbUsername.Text.Trim());
                mainForm.Show();
                this.Hide();
            }
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                if (string.IsNullOrEmpty(tbUsername.Text.Trim()))
                {
                    tbUsername.Focus();
                }
                else
                {
                    tbPassword.Focus();
                }
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                if (string.IsNullOrEmpty(tbPassword.Text.Trim()))
                {
                    tbPassword.Focus();
                }
                else
                {
                    Login();
                }
            }
        }
    }
}
