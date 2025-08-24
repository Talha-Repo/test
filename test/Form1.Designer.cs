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
            this.kryptonCheckBox2 = new Krypton.Toolkit.KryptonCheckBox();
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
            this.kryptonCheckBox1.Location = new System.Drawing.Point(710, 287);
            this.kryptonCheckBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(244, 37);
            this.kryptonCheckBox1.TabIndex = 0;
            this.kryptonCheckBox1.Values.Text = "kryptonCheckBox1";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(138, 198);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(180, 48);
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonCheckBox2
            // 
            this.kryptonCheckBox2.Location = new System.Drawing.Point(275, 342);
            this.kryptonCheckBox2.Name = "kryptonCheckBox2";
            this.kryptonCheckBox2.Size = new System.Drawing.Size(244, 37);
            this.kryptonCheckBox2.TabIndex = 2;
            this.kryptonCheckBox2.Values.Text = "kryptonCheckBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 873);
            this.Controls.Add(this.kryptonCheckBox2);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonCheckBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonColorDialog kryptonColorDialog1;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox2;
    }
}

