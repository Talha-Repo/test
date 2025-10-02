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
    public partial class ViewAll : Form
    {
        public ViewAll()
        {
            InitializeComponent();
        }
        private int currentUserId;
        public ViewAll(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private KryptonPanel CreateEntryCard(string title, DateTime date, string content)
        {
            KryptonPanel card = new KryptonPanel();
            card.Size = new Size(400, 220);   // 2 cards per row in 860 width
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
            lblTitle.StateCommon.ShortText.Font = new Font("Book Antiqua", 13, FontStyle.Bold);
            lblTitle.StateCommon.ShortText.Color1 = Color.FromArgb(90, 70, 55);
            lblTitle.StateCommon.ShortText.Trim = PaletteTextTrim.EllipsisCharacter;
            lblTitle.MaximumSize = new Size(380, 0);
            lblTitle.Text = title;

            // Date
            KryptonLabel lblDate = new KryptonLabel();
            lblDate.Dock = DockStyle.Top;
            lblDate.StateCommon.ShortText.Font = new Font("Book Antiqua", 11, FontStyle.Italic);
            lblDate.StateCommon.ShortText.Color1 = Color.DimGray;
            lblDate.Text = date.ToString("dd MMM yyyy");

            // Preview Content
            KryptonLabel lblPreview = new KryptonLabel();
            lblPreview.Dock = DockStyle.Fill;
            lblPreview.AutoSize = false;
            lblPreview.Padding = new Padding(8, 4, 8, 4);
            lblPreview.StateCommon.ShortText.Font = new Font("Book Antiqua", 11, FontStyle.Regular);
            lblPreview.StateCommon.ShortText.Color1 = Color.FromArgb(70, 50, 40);
            lblPreview.StateCommon.ShortText.MultiLine = InheritBool.True;
            lblPreview.StateCommon.ShortText.MultiLineH = PaletteRelativeAlign.Near;
            lblPreview.Text = content.Length > 300 ? content.Substring(0, 300) + "..." : content;

            // Read More Button
            KryptonButton btnReadMore = new KryptonButton();
            btnReadMore.Text = "Read More";
            btnReadMore.Dock = DockStyle.Bottom;
            btnReadMore.Size = new Size(160, 32);
            btnReadMore.StateCommon.Content.ShortText.Font = new Font("Book Antiqua", 10, FontStyle.Bold);
            btnReadMore.StateCommon.Back.Color1 = Color.FromArgb(235, 200, 160);
            btnReadMore.StateCommon.Back.Color2 = Color.FromArgb(235, 200, 160);
            btnReadMore.StateCommon.Border.Rounding = 8;

            btnReadMore.Click += (s, e) =>
            {
                MessageBox.Show("Open full entry: " + title + "\n\n" + content);
            };

            // Add to card
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
                try
                {
                    rtb.Rtf = rtf;  // load the RTF
                    return rtb.Text; // extract plain text
                }
                catch
                {
                    return rtf; // fallback if string was not RTF
                }
            }
        }
        private void ViewAll_Load(object sender, EventArgs e)
        {
            using (var conn = DataBase.Connection())
            {
                conn.Open();
                string query = @"SELECT Title, EntryDate, Content 
                     FROM DiaryEntries 
                     WHERE UserID = @uid 
                     ORDER BY EntryDate DESC";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", currentUserId); // ✅ only current user's entries

                    using (var reader = cmd.ExecuteReader())
                    {
                        flowPanelViewAll.Controls.Clear();

                        while (reader.Read())
                        {
                            string title = reader.GetString("Title");
                            DateTime date = reader.GetDateTime("EntryDate");
                            string content = reader.GetString("Content");

                            // if stored as RTF, convert before showing preview
                            string plainContent = GetPlainTextFromRtf(content);

                            flowPanelViewAll.Controls.Add(CreateEntryCard(title, date, plainContent));
                        }
                    }
                }
            }
        }
    }
}
