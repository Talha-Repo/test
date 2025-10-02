using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace test
{
    public partial class EditProfile : Form
    {
        private string currentUser;  // store username (or UserID if you switch later)
        public EditProfile(string username)
        {
            InitializeComponent();
            currentUser = username;
        }
        public EditProfile()
        {
            InitializeComponent();
           
        }

        private void txtFullName_MouseEnter(object sender, EventArgs e)
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
           
        }

        private void txtCnfrmPass_MouseEnter(object sender, EventArgs e)
        {
            txtCnfrmPass.StateCommon.Border.Color1 = Color.FromArgb(121, 85, 72);
            txtCnfrmPass.StateCommon.Border.Color2 = Color.FromArgb(193, 154, 107);
            txtCnfrmPass.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            txtCnfrmPass.StateCommon.Border.Rounding = 20;
            txtCnfrmPass.StateCommon.Border.Width = 2;
            txtCnfrmPass.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);
        }

        private void txtCnfrmPass_MouseLeave(object sender, EventArgs e)
        {
            txtCnfrmPass.StateCommon.Border.Color1 = Color.FromArgb(200, 180, 150);
            txtCnfrmPass.StateCommon.Border.Width = 2;
            
        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            
                txtFullName.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);
                txtFullName.StateCommon.Content.Font = new Font("Georgia", 14, FontStyle.Bold);
            
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            
                txtFullName.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtFullName.StateCommon.Content.Font = new Font("Georgia", 14, FontStyle.Bold);
         }
        

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            
               
                txtUserName.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);
                txtUserName.StateCommon.Content.Font = new Font("Georgia", 14, FontStyle.Bold);
            
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            
                txtUserName.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtUserName.StateCommon.Content.Font = new Font("Georgia", 14, FontStyle.Bold);
            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
           
               
               
                txtPassword.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);
            txtPassword.StateCommon.Content.Font = new Font("Georgia", 14, FontStyle.Bold);

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
           
            
  
                txtPassword.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtPassword.StateCommon.Content.Font = new Font("Georgia", 14, FontStyle.Bold);

            
        }

        private void txtCnfrmPass_Enter(object sender, EventArgs e)
        {
            
                txtCnfrmPass.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);
            txtCnfrmPass.PasswordChar = '*';


        }

        private void txtCnfrmPass_Leave(object sender, EventArgs e)
        {
           
                txtCnfrmPass.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtCnfrmPass.StateCommon.Content.Font = new Font("Georgia", 14, FontStyle.Bold);

            
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

        private void txtCnfrmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void EditPanel_Paint(object sender, PaintEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void EditProfile_Load(object sender, EventArgs e )
        {
            this.ActiveControl = null;
           

            using (MySqlConnection conn = DataBase.Connection())
            {
                conn.Open();
                string query = "SELECT FullName, UserName, Password, ProfilePic " +
                               "FROM Users WHERE UserName = @UserName";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", currentUser);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtFullName.Text = reader["FullName"].ToString();
                            txtUserName.Text = reader["UserName"].ToString();
                            txtPassword.Text = reader["Password"].ToString();
                            txtCnfrmPass.Text = reader["Password"].ToString();

                            if (reader["ProfilePic"] != DBNull.Value)
                            {
                                byte[] imgBytes = (byte[])reader["ProfilePic"];
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    kryptonPictureBox1.Image = Image.FromStream(ms);
                                    kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string userName = txtUserName.Text.Trim(); // used as ID in WHERE
            string password = txtPassword.Text;
            string confirmPassword = txtCnfrmPass.Text;
            byte[] imageBytes = null;

            // Convert image to bytes if uploaded
            if (kryptonPictureBox1.Image == null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    kryptonPictureBox1.Image.Save(ms, kryptonPictureBox1.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }
            }

            // Validation
            if (!Regex.IsMatch(fullName, @"^[A-Z,a-z\s]+$"))
            {
                MessageBox.Show("Full Name should contain only letters and spaces.", "Invalid Full Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(fullName) ||
                String.IsNullOrWhiteSpace(userName) ||
                String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields must be filled.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password must match.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Database update
            using (MySqlConnection conn = DataBase.Connection())
            {
                conn.Open();

                string query = "UPDATE Users " +
                               "SET FullName = @FullName, " +
                               "Password = @Password, " +
                               "ProfilePic = @ProfilePic " +
                               "WHERE UserName = @UserName";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@ProfilePic", imageBytes);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No matching user found.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
