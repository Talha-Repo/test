using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class HomePage : Form
    {
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

        private void HomePage_Load(object sender, EventArgs e)
        {
            MakePictureBoxCircular(ProfilePic);
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();

        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            NewEntry newEntry = new NewEntry();
            newEntry.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }
    }
}
