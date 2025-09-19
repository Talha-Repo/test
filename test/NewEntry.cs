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
    public partial class NewEntry : Form
    {
        public NewEntry()
        {
            InitializeComponent();
        }

        private void NewEntry_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            if (txtTitle.Text == "Enter Title")
            {
                txtTitle.Text = "";
                txtTitle.StateCommon.Content.Color1 = Color.FromArgb(90, 70, 55);
                txtTitle.StateCommon.Content.Font = new Font("Georgia", 14, FontStyle.Bold);
            }     
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                txtTitle.Text = "Enter Title";
                txtTitle.StateCommon.Content.Color1 = Color.FromArgb(140, 110, 90);
                txtTitle.StateCommon.Content.Font = new Font("Georgia", 15, FontStyle.Bold);
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
            if (!string.IsNullOrEmpty(txtMainWrite.SelectedText))
            {
                txtMainWrite.SelectedText = ""; // remove selection
            }
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
    }
}
