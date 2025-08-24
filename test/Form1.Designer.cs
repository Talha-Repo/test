namespace test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonColorDialog1 = new Krypton.Toolkit.KryptonColorDialog();
            this.kryptonCheckBox1 = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonTaskDialog1 = new Krypton.Toolkit.KryptonTaskDialog();
            this.kryptonThemeListBox1 = new Krypton.Toolkit.KryptonThemeListBox();
            this.SuspendLayout();
            // 
            // kryptonColorDialog1
            // 
            this.kryptonColorDialog1.Color = System.Drawing.Color.Black;
            this.kryptonColorDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("kryptonColorDialog1.Icon")));
            this.kryptonColorDialog1.Title = null;
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(355, 149);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(125, 20);
            this.kryptonCheckBox1.TabIndex = 0;
            this.kryptonCheckBox1.Values.Text = "kryptonCheckBox1";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(69, 103);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonTaskDialog1
            // 
            this.kryptonTaskDialog1.CheckboxText = null;
            this.kryptonTaskDialog1.Content = null;
            this.kryptonTaskDialog1.DefaultRadioButton = null;
            this.kryptonTaskDialog1.FooterHyperlink = null;
            this.kryptonTaskDialog1.FooterText = null;
            this.kryptonTaskDialog1.MainInstruction = null;
            this.kryptonTaskDialog1.TextExtra = "Ctrl+C to copy";
            this.kryptonTaskDialog1.UseNativeOSIcons = false;
            this.kryptonTaskDialog1.WindowTitle = null;
            // 
            // kryptonThemeListBox1
            // 
            this.kryptonThemeListBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Microsoft365Blue;
            this.kryptonThemeListBox1.Location = new System.Drawing.Point(152, 246);
            this.kryptonThemeListBox1.Name = "kryptonThemeListBox1";
            this.kryptonThemeListBox1.Size = new System.Drawing.Size(120, 96);
            this.kryptonThemeListBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonThemeListBox1);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonCheckBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonColorDialog kryptonColorDialog1;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonTaskDialog kryptonTaskDialog1;
        private Krypton.Toolkit.KryptonThemeListBox kryptonThemeListBox1;
    }
}

