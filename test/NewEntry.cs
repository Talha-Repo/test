using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class NewEntry : Form
    {
        public NewEntry()
        {
            InitializeComponent();
        }
        private int currentUserId;
        public NewEntry(int userId)
        {
            InitializeComponent();
            currentUserId = userId; // store for insert query
        }

        private void NewEntry_Load(object sender, EventArgs e)
        {
            lblDateNE.Text = DateTime.Now.ToString("dddd, dd MMM yyyy");
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            if (txtTitleNE.Text == "Enter Title")
            {
                txtTitleNE.Text = "";
                txtTitleNE.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);
                txtTitleNE.StateCommon.Content.Font = new Font("Georgia", 14, FontStyle.Bold);
            }     
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            if (txtTitleNE.Text == "")
            {
                txtTitleNE.Text = "Enter Title";
                txtTitleNE.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtTitleNE.StateCommon.Content.Font = new Font("Georgia", 15, FontStyle.Bold);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (txtMainWrite.SelectionFont != null)
            {
                Font currentFont = txtMainWrite.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Bold;
                txtMainWrite.SelectionFont = new Font("Book Antiqua", 14.25f, newFontStyle);
            }
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (txtMainWrite.SelectionFont != null)
            {
                Font currentFont = txtMainWrite.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Italic;
                txtMainWrite.SelectionFont = new Font("Book Antiqua", 14.25f, newFontStyle);
            }
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (txtMainWrite.SelectionFont != null)
            {
                Font currentFont = txtMainWrite.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Underline;
                txtMainWrite.SelectionFont = new Font("Book Antiqua", 14.25f, newFontStyle);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtMainWrite.SelectionBullet = !txtMainWrite.SelectionBullet;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all text?",
                       "Confirm Clear",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                txtMainWrite.Clear(); // empty the whole box
            }
        }

        private void btnSaveNE_Click(object sender, EventArgs e)
        {
            if (txtTitleNE.Text.Trim() == "" || txtTitleNE.Text == "Enter Title")
            {
                MessageBox.Show("Please enter a title for your diary entry.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var conn = DataBase.Connection())
                {
                    conn.Open();
                    string query = @"INSERT INTO DiaryEntries (Title, EntryDate, Content, UserID)  
                         VALUES(@title, @date, @content, @uid)";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", txtTitleNE.Text.Trim());
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@content", txtMainWrite.Rtf);
                        cmd.Parameters.AddWithValue("@uid", currentUserId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Entry saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving entry:\n" + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
