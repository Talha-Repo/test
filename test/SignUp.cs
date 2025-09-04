using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();

         


        }
        private void txtFullName_MouseEnter_1(object sender, EventArgs e)
        {
            txtFullName.StateCommon.Border.Color1 = Color.FromArgb(121, 85, 72);
            txtFullName.StateCommon.Border.Color2 = Color.FromArgb(193, 154, 107);
            txtFullName.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            txtFullName.StateCommon.Border.Rounding = 20;
            txtFullName.StateCommon.Border.Width = 2;
            txtFullName.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);
        }

        private void txtFullName_MouseLeave(object sender, EventArgs e)
        {
            txtFullName.StateCommon.Border.Color1 = Color.FromArgb(200, 180, 150);
            txtFullName.StateCommon.Border.Width = 2;
            if (txtFullName.Text == "Full Name")
            {

                txtFullName.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtFullName.StateCommon.Content.Font = new Font("Segoe Script", 14, FontStyle.Bold);
            }



        }

        private void txtUserName_MouseEnter(object sender, EventArgs e)
        {
            txtUserName.StateCommon.Border.Color1 = Color.FromArgb(121, 85, 72);
            txtUserName.StateCommon.Border.Color2 = Color.FromArgb(193, 154, 107);
            txtUserName.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            txtUserName.StateCommon.Border.Rounding = 20;
            txtUserName.StateCommon.Border.Width = 2;
            txtUserName.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);

        }

        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            txtUserName.StateCommon.Border.Color1 = Color.FromArgb(200, 180, 150);
            txtUserName.StateCommon.Border.Width = 2;
            if (txtUserName.Text == "User Name")
            {
                txtUserName.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtUserName.StateCommon.Content.Font = new Font("Segoe Script", 14, FontStyle.Bold);
            }

        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.StateCommon.Border.Color1 = Color.FromArgb(121, 85, 72);
            txtPassword.StateCommon.Border.Color2 = Color.FromArgb(193, 154, 107);
            txtPassword.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            txtPassword.StateCommon.Border.Rounding = 20;
            txtPassword.StateCommon.Border.Width = 2;
            txtPassword.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);


        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.StateCommon.Border.Color1 = Color.FromArgb(200, 180, 150);
            txtPassword.StateCommon.Border.Width = 2;
            if (txtPassword.Text == "Password")
            {
                txtPassword.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtPassword.StateCommon.Content.Font = new Font("Segoe Script", 14, FontStyle.Bold);
            }


        }

        private void txtConfirmPass_MouseEnter(object sender, EventArgs e)
        {
            txtConfirmPass.StateCommon.Border.Color1 = Color.FromArgb(121, 85, 72);
            txtConfirmPass.StateCommon.Border.Color2 = Color.FromArgb(193, 154, 107);
            txtConfirmPass.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            txtConfirmPass.StateCommon.Border.Rounding = 20;
            txtConfirmPass.StateCommon.Border.Width = 2;
            txtConfirmPass.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);

        }

        private void txtConfirmPass_MouseLeave(object sender, EventArgs e)
        {
            txtConfirmPass.StateCommon.Border.Color1 = Color.FromArgb(200, 180, 150);
            txtConfirmPass.StateCommon.Border.Width = 2;
            if (txtConfirmPass.Text == "Confirm Password")
            {
                txtConfirmPass.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtConfirmPass.StateCommon.Content.Font = new Font("Segoe Script", 14, FontStyle.Bold);
            }


        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Full Name")
            {
                txtFullName.Text = "";
                txtFullName.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);
                txtFullName.StateCommon.Content.Font = new Font("Georgia", 14, FontStyle.Bold);
            }
        }
        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                txtFullName.Text = "Full Name";
                txtFullName.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtFullName.StateCommon.Content.Font = new Font("Segoe Script", 14, FontStyle.Bold);
            }
        }
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "User Name")
            {
                txtUserName.Text = "";
                txtUserName.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);
                txtUserName.StateCommon.Content.Font = new Font("Georgia", 14, FontStyle.Bold);
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.Text = "User Name";
                txtUserName.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtUserName.StateCommon.Content.Font = new Font("Segoe Script", 14, FontStyle.Bold);
            }

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
                txtPassword.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
                txtPassword.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtPassword.StateCommon.Content.Font = new Font("Segoe Script", 14, FontStyle.Bold);

            }
        }

        private void txtConfirmPass_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text == "Confirm Password")
            {
                txtConfirmPass.Text = "";
                txtConfirmPass.PasswordChar = '*';
                txtConfirmPass.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);

            }

        }

        private void txtConfirmPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPass.Text))
            {
                txtConfirmPass.Text = "Confirm Password";
                txtConfirmPass.PasswordChar = '\0';
                txtConfirmPass.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtConfirmPass.StateCommon.Content.Font = new Font("Segoe Script", 14, FontStyle.Bold);

            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }

        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void SignUpPanel_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }

        private void lblSignUp_MouseEnter(object sender, EventArgs e)
        {
            lblSignUp.StateCommon.ShortText.Font = new Font(
        lblSignUp.StateCommon.ShortText.Font,
        FontStyle.Underline
             );
        }

        private void lblSignUp_MouseLeave(object sender, EventArgs e)
        {
            lblSignUp.StateCommon.ShortText.Font = new Font(
        lblSignUp.StateCommon.ShortText.Font,
        FontStyle.Regular
             );
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPass.Text;
            byte[] imageBytes = null;

            if (ProfilePic.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    ProfilePic.Image.Save(ms, ProfilePic.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }
            }

                if (!Regex.IsMatch(txtFullName.Text, @"^[A-Z,a-z\s]+$"))
                {
                    MessageBox.Show("Full Name should contain only letters and spaces.", "Invalid Full Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (String.IsNullOrWhiteSpace(fullName))
                {
                    MessageBox.Show("Full Name cannot be empty.", "Invalid Full Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (String.IsNullOrWhiteSpace(userName))
                {
                    MessageBox.Show("User Name cannot be empty.", "Invalid User Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (String.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Password cannot be empty.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (password != confirmPassword)
                {
                    MessageBox.Show("Password and Confirm Password Must me same .", "validation", MessageBoxButtons.OK);
                }
                if (ProfilePic.Image == null)
                {
                    MessageBox.Show("Please upload a picture.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
    }
}
