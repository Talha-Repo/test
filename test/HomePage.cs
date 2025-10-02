using Krypton.Toolkit;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace test
{
    public partial class HomePage : Form
    {
        private int currentUserId;
        public HomePage(int userId,string userName, Image profilePic)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome " + userName;
            if (profilePic != null)
            {
                ProfilePic.Image = profilePic;   // PictureBox in your header panel
                ProfilePic.SizeMode = PictureBoxSizeMode.Zoom;

            }
            string[] quotes =
             {
                "Believe in yourself and all that you are.",
                "Success begins with a single step forward.",
                "Dream big, work hard, stay focused, succeed.",
                "Every day is a chance to improve yourself.",
                "Push yourself, because no one else will.",
                "Great things never come from comfort zones.",
                "Do something today that your future self will thank you for.",
                "The harder you work, the luckier you get.",
                "Don’t stop until you’re proud of yourself.",
                "Discipline is the bridge between goals and success.",
                "Your only limit is your own mindset.",
                "Fall seven times and stand up eight.",
                "Keep moving forward no matter how small.",
                "Opportunities don’t happen, you create them daily.",
                "Work hard in silence, let success speak.",
                "Stay patient and trust the journey ahead.",
                "Turn your wounds into your greatest strength.",
                "Success is the sum of small efforts repeated daily.",
                "Dreams don’t work unless you do.",
                "Start where you are. Use what you have.",
                "Doubt kills more dreams than failure ever will.",
                "Be stronger than your excuses every day.",
                "Small progress each day adds up to big results.",
                "Your attitude determines your direction in life.",
                "Hard work beats talent when talent doesn’t work hard.",
                "Don’t limit your challenges, challenge your limits.",
                "A little progress each day adds up to success.",
                "Consistency turns ordinary into extraordinary results.",
                "Stay focused and never lose your vision.",
                "Great achievements take time, keep going forward."
            };

            int day = DateTime.Now.Day;
            string todayQuote = quotes[day % quotes.Length];
            lblQuotes.Text = todayQuote;
            currentUserId = userId;

        } 
        public HomePage()
        {
            InitializeComponent();
        }

        private void MakePictureBoxCircular(PictureBox pb)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width - 3, pb.Height - 3);
            pb.Region = new Region(gp);
        }
        private KryptonPanel CreateEntryCard(string title, DateTime date, string content)
        {
            KryptonPanel card = new KryptonPanel();
            card.Size = new Size(260, 180);   // fits 2 per row inside 584 panel
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
            lblTitle.StateCommon.ShortText.Font = new Font("Book Antiqua", 12, FontStyle.Bold);
            lblTitle.StateCommon.ShortText.Color1 = Color.FromArgb(60, 40, 30);
            lblTitle.MaximumSize = new Size(250, 0);
            lblTitle.Text = title;

            // Date (bigger & bold so it’s readable)
            KryptonLabel lblDate = new KryptonLabel();
            lblDate.Dock = DockStyle.Top;
            lblDate.StateCommon.ShortText.Font = new Font("Book Antiqua", 11, FontStyle.Bold);
            lblDate.StateCommon.ShortText.Color1 = Color.DarkSlateGray;
            lblDate.Text = date.ToString("dd MMM yyyy");

            // Content preview
            KryptonLabel lblPreview = new KryptonLabel();
            lblPreview.Dock = DockStyle.Fill;
            lblPreview.StateCommon.ShortText.Font = new Font("Book Antiqua", 10, FontStyle.Regular);
            lblPreview.StateCommon.ShortText.Color1 = Color.FromArgb(70, 50, 40);
            lblPreview.StateCommon.ShortText.MultiLine = InheritBool.True;
            lblPreview.StateCommon.ShortText.MultiLineH = PaletteRelativeAlign.Near;
            lblPreview.MaximumSize = new Size(250, 100);
            lblPreview.Text = content.Length > 140 ? content.Substring(0, 140) + "..." : content;

            // Read More button
            KryptonButton btnReadMore = new KryptonButton();
            btnReadMore.Text = "Read More / Edit";
            btnReadMore.Dock = DockStyle.Bottom;
            btnReadMore.Size = new Size(250, 28);
            btnReadMore.StateCommon.Content.ShortText.Font = new Font("Book Antiqua", 10, FontStyle.Bold);
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
                return rtb.Text;   // plain text without formatting
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            MakePictureBoxCircular(ProfilePic);
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy");
            using (var conn = DataBase.Connection())
            {
                conn.Open();
                string query = "SELECT TaskText, IsCompleted FROM Todos WHERE UserID=@uid";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", currentUserId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string taskText = reader.GetString("TaskText");
                            bool isCompleted = reader.GetBoolean("IsCompleted");

                            AddTodoToUI(taskText, isCompleted);
                        }
                    }
                }
            }

            // ✅ Load Diary Entries for current user
            using (var conn = DataBase.Connection())
            {
                conn.Open();
                string query = "SELECT Title, EntryDate, Content  FROM DiaryEntries WHERE UserID = @uid ORDER BY EntryDate DESC LIMIT 4";
               
            
    using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", currentUserId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string title = reader.GetString("Title");
                            DateTime date = reader.GetDateTime("EntryDate");
                            string rawContent = reader.GetString("Content");
                            string plainContent = GetPlainTextFromRtf(rawContent);

                            FlowPanelrecententries.Controls.Add(CreateEntryCard(title, date, plainContent));
                        }
                    }
                }
            }
        }
        


        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();

        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            NewEntry newEntry = new NewEntry(currentUserId);
            newEntry.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search(currentUserId);
            search.Show();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ViewAll viewAll = new ViewAll(currentUserId);
            viewAll.Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            string userName = lblWelcome.Text.Replace("Welcome ", "");
            EditProfile editProfile = new EditProfile(userName);
            editProfile.Show();
        }
        private void AddTodoToUI(string taskText, bool isCompleted)
        {
            KryptonPanel todoRow = new KryptonPanel();
            todoRow.Size = new Size(550, 45);
            todoRow.StateCommon.Color1 = Color.Bisque;
            todoRow.StateCommon.Color2 = Color.Bisque;
            todoRow.Margin = new Padding(5);

            KryptonCheckBox chkTodo = new KryptonCheckBox();
            chkTodo.Text = taskText;
            chkTodo.Checked = isCompleted;
            chkTodo.StateCommon.ShortText.Font = new Font("Book Antiqua", 12, isCompleted ? FontStyle.Strikeout : FontStyle.Bold);
            chkTodo.Location = new Point(15, 10);

            KryptonButton btnDelete = new KryptonButton();
            btnDelete.Text = "✖";
            btnDelete.Size = new Size(35, 30);
            btnDelete.Location = new Point(510, 7);
            btnDelete.StateCommon.Content.ShortText.Font = new Font("Book Antiqua", 12, FontStyle.Bold);
            btnDelete.StateCommon.Content.ShortText.Color1 = Color.Red;
            btnDelete.StateCommon.Border.Rounding = 8;
            btnDelete.StateCommon.Back.Color1 = Color.FromArgb(235, 200, 160);
            btnDelete.StateCommon.Back.Color2 = Color.FromArgb(235, 200, 160);

            // ⭐ Checkbox event = update DB
            chkTodo.CheckedChanged += (s, args) =>
            {
                chkTodo.StateCommon.ShortText.Font = new Font("Book Antiqua", 12,
                    chkTodo.Checked ? FontStyle.Strikeout : FontStyle.Bold);

                using (var conn = DataBase.Connection())
                {
                    conn.Open();
                    string query = "UPDATE Todos SET IsCompleted=@c WHERE TaskText=@t AND UserID=@uid LIMIT 1";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c", chkTodo.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@t", chkTodo.Text);
                        cmd.Parameters.AddWithValue("@uid", currentUserId); // ✅ important
                        cmd.ExecuteNonQuery();
                    }
                }
            };

            // ⭐ Delete event = remove from DB + UI
            btnDelete.Click += (s, args) =>
            {
                using (var conn = DataBase.Connection())
                {
                    conn.Open();
                    string query = "DELETE FROM Todos WHERE TaskText=@t AND UserID=@uid LIMIT 1";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@t", chkTodo.Text);
                        cmd.Parameters.AddWithValue("@uid", currentUserId); // ✅ important
                        cmd.ExecuteNonQuery();
                    }
                }

                flowTodos.Controls.Remove(todoRow);
            };

            todoRow.Controls.Add(chkTodo);
            todoRow.Controls.Add(btnDelete);
            flowTodos.Controls.Add(todoRow);
        }
        private void btnAddTodo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddTodo.Text) || txtAddTodo.Text == "Add Tasks") return;

            using (var conn = DataBase.Connection())
            {
                conn.Open();
                string query = "INSERT INTO Todos (TaskText, IsCompleted, UserID) VALUES (@t, 0, @uid)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@t", txtAddTodo.Text.Trim());
                    cmd.Parameters.AddWithValue("@uid", currentUserId); // ✅ store user id
                    cmd.ExecuteNonQuery();
                }
            }

            // Add to UI
            AddTodoToUI(txtAddTodo.Text.Trim(), false);

            // Reset textbox
            txtAddTodo.Text = "Add Tasks";

        }

        private void txtAddTodo_MouseEnter(object sender, EventArgs e)
        {
            txtAddTodo.StateCommon.Border.Color1 = Color.FromArgb(121, 85, 72);
            txtAddTodo.StateCommon.Border.Color2 = Color.FromArgb(193, 154, 107);
            txtAddTodo.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            txtAddTodo.StateCommon.Border.Rounding = 20;
            txtAddTodo.StateCommon.Border.Width = 2;
            txtAddTodo.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);
        }

        private void txtAddTodo_MouseLeave(object sender, EventArgs e)
        {
            txtAddTodo.StateCommon.Border.Color1 = Color.FromArgb(200, 180, 150);
            txtAddTodo.StateCommon.Border.Width = 2;
            if (txtAddTodo.Text == "Add Tasks")
            {

                txtAddTodo.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtAddTodo.StateCommon.Content.Font = new Font("Book Antiqua", 14, FontStyle.Bold);
            }
        }

        private void txtAddTodo_Enter(object sender, EventArgs e)
        {
            if (txtAddTodo.Text == "Add Tasks")
            {
                txtAddTodo.Text = "";
                txtAddTodo.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);
                txtAddTodo.StateCommon.Content.Font = new Font("Book Antiqua", 14, FontStyle.Bold);
            }
        }

        private void txtAddTodo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddTodo.Text))
            {
                txtAddTodo.Text = "Add Tasks";
                txtAddTodo.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtAddTodo.StateCommon.Content.Font = new Font("Book Antiqua", 14, FontStyle.Bold);
            }
        }

        private void txtAddTodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}
    

