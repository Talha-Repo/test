using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
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

        private void LogIn_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void LoginPanel_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
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

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            signup signup = new signup();
            signup.Show();
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

        private void lblForgotPass_MouseEnter(object sender, EventArgs e)
        {

            lblForgotPass.StateCommon.ShortText.Font = new Font(
                lblForgotPass.StateCommon.ShortText.Font,
                FontStyle.Underline
            );
        }

        private void lblForgotPass_MouseLeave(object sender, EventArgs e)
        {
            lblForgotPass.StateCommon.ShortText.Font = new Font(
        lblForgotPass.StateCommon.ShortText.Font,
        FontStyle.Regular 
    );
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DataBase.Connection())
            {
                conn.Open();

                // ✅ Also select UserID along with ProfilePic
                string query = "SELECT UserID, ProfilePic FROM Users WHERE UserName = @UserName AND Password = @Password";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // ✅ UserID from DB (important for saving entries later)
                            int userId = reader.GetInt32("UserID");

                            // Username from login form
                            string userName = txtUserName.Text.Trim();

                            // Profile pic from DB
                            byte[] imageBytes = reader["ProfilePic"] as byte[];
                            Image profileImage = null;

                            if (imageBytes != null && imageBytes.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    profileImage = Image.FromStream(ms);
                                }
                            }

                            // ✅ Send UserID, Username, ProfilePic to HomePage
                            HomePage home = new HomePage(userId, userName, profileImage);
                            home.Show();
                            
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }


        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            PanelForgetPass.Show();
            LoginPanel.Hide();

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            LoginPanel.Show();
            PanelForgetPass.Hide();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            PanelForgetPass.Hide();
        }
    }
}
