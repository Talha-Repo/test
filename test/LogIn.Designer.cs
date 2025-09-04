namespace test
{
    partial class LogIn
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
            this.LoginPanel = new Krypton.Toolkit.KryptonPanel();
            this.lblWelcomeBack = new Krypton.Toolkit.KryptonLabel();
            this.lblSignUp = new Krypton.Toolkit.KryptonLabel();
            this.lblForgotPass = new Krypton.Toolkit.KryptonLabel();
            this.btnSignUp = new Krypton.Toolkit.KryptonButton();
            this.txtPassword = new Krypton.Toolkit.KryptonTextBox();
            this.txtUserName = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPanel)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginPanel.AutoSize = true;
            this.LoginPanel.Controls.Add(this.lblWelcomeBack);
            this.LoginPanel.Controls.Add(this.lblSignUp);
            this.LoginPanel.Controls.Add(this.lblForgotPass);
            this.LoginPanel.Controls.Add(this.btnSignUp);
            this.LoginPanel.Controls.Add(this.txtPassword);
            this.LoginPanel.Controls.Add(this.txtUserName);
            this.LoginPanel.Location = new System.Drawing.Point(350, 127);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(500, 606);
            this.LoginPanel.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.LoginPanel.StateCommon.Color2 = System.Drawing.Color.AntiqueWhite;
            this.LoginPanel.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.LoginPanel.StateCommon.ColorAngle = -90F;
            this.LoginPanel.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding2;
            this.LoginPanel.TabIndex = 1;
            this.LoginPanel.Click += new System.EventHandler(this.LoginPanel_Click);
            // 
            // lblWelcomeBack
            // 
            this.lblWelcomeBack.Location = new System.Drawing.Point(156, 58);
            this.lblWelcomeBack.Name = "lblWelcomeBack";
            this.lblWelcomeBack.Size = new System.Drawing.Size(179, 47);
            this.lblWelcomeBack.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 10);
            this.lblWelcomeBack.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.lblWelcomeBack.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.lblWelcomeBack.StateCommon.ShortText.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeBack.TabIndex = 10;
            this.lblWelcomeBack.Values.Text = "Welcome back!";
            // 
            // lblSignUp
            // 
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.Location = new System.Drawing.Point(165, 380);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(177, 22);
            this.lblSignUp.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.lblSignUp.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.lblSignUp.StateCommon.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblSignUp.TabIndex = 9;
            this.lblSignUp.Values.Text = "Don\'t have acc? SigIn";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            this.lblSignUp.MouseEnter += new System.EventHandler(this.lblSignUp_MouseEnter);
            this.lblSignUp.MouseLeave += new System.EventHandler(this.lblSignUp_MouseLeave);
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPass.Location = new System.Drawing.Point(175, 419);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(153, 45);
            this.lblForgotPass.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.lblForgotPass.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.lblForgotPass.StateCommon.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblForgotPass.TabIndex = 1;
            this.lblForgotPass.TabStop = false;
            this.lblForgotPass.Values.Text = "Forgot Password?\r\n\r\n";
            this.lblForgotPass.MouseEnter += new System.EventHandler(this.lblForgotPass_MouseEnter);
            this.lblForgotPass.MouseLeave += new System.EventHandler(this.lblForgotPass_MouseLeave);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Location = new System.Drawing.Point(100, 300);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSignUp.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSignUp.OverrideDefault.Back.ColorAngle = 0F;
            this.btnSignUp.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnSignUp.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnSignUp.OverrideDefault.Border.Rounding = 20F;
            this.btnSignUp.OverrideDefault.Border.Width = 2;
            this.btnSignUp.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSignUp.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnSignUp.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.btnSignUp.Size = new System.Drawing.Size(300, 45);
            this.btnSignUp.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSignUp.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSignUp.StateCommon.Back.ColorAngle = 0F;
            this.btnSignUp.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSignUp.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnSignUp.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnSignUp.StateCommon.Border.ColorAngle = 0F;
            this.btnSignUp.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignUp.StateCommon.Border.Rounding = 20F;
            this.btnSignUp.StateCommon.Border.Width = 2;
            this.btnSignUp.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSignUp.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnSignUp.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.btnSignUp.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSignUp.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSignUp.StateNormal.Back.ColorAngle = 0F;
            this.btnSignUp.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSignUp.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnSignUp.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnSignUp.StateNormal.Border.ColorAngle = 0F;
            this.btnSignUp.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSignUp.StateNormal.Border.Rounding = 20F;
            this.btnSignUp.StateNormal.Border.Width = 2;
            this.btnSignUp.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSignUp.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnSignUp.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(130)))));
            this.btnSignUp.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSignUp.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSignUp.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnSignUp.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnSignUp.StatePressed.Border.ColorAngle = 0F;
            this.btnSignUp.StatePressed.Border.Rounding = 20F;
            this.btnSignUp.StatePressed.Border.Width = 2;
            this.btnSignUp.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSignUp.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnSignUp.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.btnSignUp.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSignUp.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSignUp.StateTracking.Back.ColorAngle = 0F;
            this.btnSignUp.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnSignUp.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnSignUp.StateTracking.Border.ColorAngle = 0F;
            this.btnSignUp.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignUp.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSignUp.StateTracking.Border.Rounding = 20F;
            this.btnSignUp.StateTracking.Border.Width = 2;
            this.btnSignUp.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSignUp.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnSignUp.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.TabStop = false;
            this.btnSignUp.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSignUp.Values.Text = "SignUp";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 220);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 40);
            this.txtPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.txtPassword.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.txtPassword.StateCommon.Border.Rounding = 20F;
            this.txtPassword.StateCommon.Border.Width = 2;
            this.txtPassword.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.txtPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0, 0, 0, -7);
            this.txtPassword.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.MouseEnter += new System.EventHandler(this.txtPassword_MouseEnter);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(100, 150);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(300, 40);
            this.txtUserName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.txtUserName.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.txtUserName.StateCommon.Border.Rounding = 20F;
            this.txtUserName.StateCommon.Border.Width = 2;
            this.txtUserName.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.txtUserName.StateCommon.Content.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtUserName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0, 0, 0, -7);
            this.txtUserName.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtUserName.TabIndex = 2;
            this.txtUserName.TabStop = false;
            this.txtUserName.Text = "User Name";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            this.txtUserName.MouseEnter += new System.EventHandler(this.txtUserName_MouseEnter);
            this.txtUserName.MouseLeave += new System.EventHandler(this.txtUserName_MouseLeave);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test.Properties.Resources._1755186696637;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.LoginPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Click += new System.EventHandler(this.LogIn_Click);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPanel)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel LoginPanel;
        private Krypton.Toolkit.KryptonLabel lblWelcomeBack;
        private Krypton.Toolkit.KryptonLabel lblSignUp;
        private Krypton.Toolkit.KryptonLabel lblForgotPass;
        private Krypton.Toolkit.KryptonButton btnSignUp;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private Krypton.Toolkit.KryptonTextBox txtUserName;
    }
}