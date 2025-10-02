using Krypton.Toolkit;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        private int currentUserId;
        public Search(int userId)
        {
            InitializeComponent();
            currentUserId = userId; 
        }

        private KryptonPanel CreateSearchCard(string title, DateTime date, string content)
        {
            KryptonPanel card = new KryptonPanel();
            card.Size = new Size(400, 280);
            card.Margin = new Padding(10);
            card.StateCommon.Color1 = Color.Bisque;
            card.StateCommon.Color2 = Color.Bisque;

            // Rounded corners
            int radius = 12;
            var gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddArc(0, 0, radius, radius, 180, 90);
            gp.AddArc(card.Width - radius, 0, radius, radius, 270, 90);
            gp.AddArc(card.Width - radius, card.Height - radius, radius, radius, 0, 90);
            gp.AddArc(0, card.Height - radius, radius, radius, 90, 90);
            gp.CloseFigure();
            card.Region = new Region(gp);

            // Title
            KryptonLabel lblTitle = new KryptonLabel();
            lblTitle.Dock = DockStyle.Top;
            lblTitle.StateCommon.ShortText.Font = new Font("Book Antiqua", 14, FontStyle.Bold);
            lblTitle.StateCommon.ShortText.Color1 = Color.FromArgb(50, 30, 20);
            lblTitle.MaximumSize = new Size(380, 0);
            lblTitle.Text = title;

            // Date (bigger font for readability)
            KryptonLabel lblDate = new KryptonLabel();
            lblDate.Dock = DockStyle.Top;
            lblDate.StateCommon.ShortText.Font = new Font("Book Antiqua", 12, FontStyle.Bold);
            lblDate.StateCommon.ShortText.Color1 = Color.DarkSlateGray;
            lblDate.Text = date.ToString("dd MMM yyyy");

            // Preview Content
            KryptonLabel lblPreview = new KryptonLabel();
            lblPreview.Dock = DockStyle.Fill;
            lblPreview.AutoSize = false;
            lblPreview.Padding = new Padding(8, 4, 8, 4); // add spacing inside
            lblPreview.StateCommon.ShortText.Font = new Font("Book Antiqua", 11, FontStyle.Regular);
            lblPreview.StateCommon.ShortText.Color1 = Color.FromArgb(70, 50, 40);
            lblPreview.StateCommon.ShortText.MultiLine = InheritBool.True;
            lblPreview.StateCommon.ShortText.MultiLineH = PaletteRelativeAlign.Near;

            // show up to 500 chars (adjust as needed)
            lblPreview.Text = content.Length > 250 ? content.Substring(0, 250) + "..." : content;

            // Read More button
            KryptonButton btnReadMore = new KryptonButton();
            btnReadMore.Text = "Read More / Edit";
            btnReadMore.Dock = DockStyle.Bottom;
            btnReadMore.Size = new Size(380, 35);
            btnReadMore.StateCommon.Content.ShortText.Font = new Font("Book Antiqua", 11, FontStyle.Bold);
            btnReadMore.StateCommon.Back.Color1 = Color.FromArgb(235, 200, 160);
            btnReadMore.StateCommon.Back.Color2 = Color.FromArgb(235, 200, 160);
            btnReadMore.StateCommon.Border.Rounding = 8;

            btnReadMore.Click += (s, e) =>
            {
                MessageBox.Show("Open full entry: " + title + "\n\n" + content);
            };

            // Add controls
            card.Controls.Add(btnReadMore);
            card.Controls.Add(lblPreview);
            card.Controls.Add(lblDate);
            card.Controls.Add(lblTitle);

            return card;
        }
        private string GetPlainTextFromRtf(string rtf)
        {
            using (RichTextBox rtb = new RichTextBox())
            {
                rtb.Rtf = rtf;
                return rtb.Text;
            }
        }
        private void btnSearchEntries_Click(object sender, EventArgs e)
        {
            FlowPanelSE.Controls.Clear(); // Clear old results

            using (var conn = DataBase.Connection())
            {
                conn.Open();
                string query = @"SELECT Title, EntryDate, Content 
                     FROM DiaryEntries 
                     WHERE UserID=@uid AND Title LIKE @title";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    // ✅ Add both filters
                    cmd.Parameters.AddWithValue("@uid", currentUserId);
                    cmd.Parameters.AddWithValue("@title", "%" + txtEntertitleSE.Text.Trim() + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string title = reader.GetString("Title");
                            DateTime date = reader.GetDateTime("EntryDate");
                            string rawContent = reader.GetString("Content");

                            // Convert RTF to plain text for preview
                            string plainContent = GetPlainTextFromRtf(rawContent);

                            FlowPanelSE.Controls.Add(CreateSearchCard(title, date, plainContent));
                        }
                    }
                }
            }

        }

        private void txtEntertitleSE_Enter(object sender, EventArgs e)
        {
            if (txtEntertitleSE.Text == "Enter Title ")
            {
                txtEntertitleSE.Text = "";
                txtEntertitleSE.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);
                txtEntertitleSE.StateCommon.Content.Font = new Font("Georgia", 14, FontStyle.Bold);
            }
        }

        private void txtEntertitleSE_Leave(object sender, EventArgs e)
        {
            if (txtEntertitleSE.Text == "")
            {
                txtEntertitleSE.Text = "Enter Title ";
                txtEntertitleSE.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtEntertitleSE.StateCommon.Content.Font = new Font("Georgia", 15, FontStyle.Bold);
            }
        }
    }
}
