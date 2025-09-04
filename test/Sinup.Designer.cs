namespace test
{
    partial class signup
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
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.btnBrowse = new Krypton.Toolkit.KryptonButton();
            this.txtCnfrmPass = new Krypton.Toolkit.KryptonTextBox();
            this.txtFullName = new Krypton.Toolkit.KryptonTextBox();
            this.lblCreateAcc = new Krypton.Toolkit.KryptonLabel();
            this.lblLogIn = new Krypton.Toolkit.KryptonLabel();
            this.lblPicture = new Krypton.Toolkit.KryptonLabel();
            this.btnSignUp = new Krypton.Toolkit.KryptonButton();
            this.txtPassword = new Krypton.Toolkit.KryptonTextBox();
            this.txtUserName = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPanel)).BeginInit();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginPanel.AutoSize = true;
            this.LoginPanel.Controls.Add(this.kryptonPictureBox1);
            this.LoginPanel.Controls.Add(this.btnBrowse);
            this.LoginPanel.Controls.Add(this.txtCnfrmPass);
            this.LoginPanel.Controls.Add(this.txtFullName);
            this.LoginPanel.Controls.Add(this.lblCreateAcc);
            this.LoginPanel.Controls.Add(this.lblLogIn);
            this.LoginPanel.Controls.Add(this.lblPicture);
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
            this.LoginPanel.TabIndex = 2;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.BackgroundImage = global::test.Properties.Resources.PROFILEBG;
            this.kryptonPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kryptonPictureBox1.Location = new System.Drawing.Point(113, 372);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kryptonPictureBox1.TabIndex = 14;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Location = new System.Drawing.Point(252, 401);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnBrowse.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnBrowse.OverrideDefault.Back.ColorAngle = 0F;
            this.btnBrowse.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnBrowse.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnBrowse.OverrideDefault.Border.Rounding = 10F;
            this.btnBrowse.OverrideDefault.Border.Width = 2;
            this.btnBrowse.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBrowse.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnBrowse.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.btnBrowse.Size = new System.Drawing.Size(141, 35);
            this.btnBrowse.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnBrowse.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnBrowse.StateCommon.Back.ColorAngle = 0F;
            this.btnBrowse.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnBrowse.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnBrowse.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnBrowse.StateCommon.Border.ColorAngle = 0F;
            this.btnBrowse.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBrowse.StateCommon.Border.Rounding = 10F;
            this.btnBrowse.StateCommon.Border.Width = 2;
            this.btnBrowse.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBrowse.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.btnBrowse.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnBrowse.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnBrowse.StateNormal.Back.ColorAngle = 0F;
            this.btnBrowse.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnBrowse.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnBrowse.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnBrowse.StateNormal.Border.ColorAngle = 0F;
            this.btnBrowse.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBrowse.StateNormal.Border.Rounding = 10F;
            this.btnBrowse.StateNormal.Border.Width = 2;
            this.btnBrowse.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBrowse.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnBrowse.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(130)))));
            this.btnBrowse.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnBrowse.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnBrowse.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnBrowse.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnBrowse.StatePressed.Border.ColorAngle = 0F;
            this.btnBrowse.StatePressed.Border.Rounding = 10F;
            this.btnBrowse.StatePressed.Border.Width = 2;
            this.btnBrowse.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBrowse.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnBrowse.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.btnBrowse.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnBrowse.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnBrowse.StateTracking.Back.ColorAngle = 0F;
            this.btnBrowse.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnBrowse.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnBrowse.StateTracking.Border.ColorAngle = 0F;
            this.btnBrowse.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBrowse.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBrowse.StateTracking.Border.Rounding = 10F;
            this.btnBrowse.StateTracking.Border.Width = 2;
            this.btnBrowse.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBrowse.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnBrowse.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.TabStop = false;
            this.btnBrowse.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBrowse.Values.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtCnfrmPass
            // 
            this.txtCnfrmPass.Location = new System.Drawing.Point(100, 280);
            this.txtCnfrmPass.Multiline = true;
            this.txtCnfrmPass.Name = "txtCnfrmPass";
            this.txtCnfrmPass.Size = new System.Drawing.Size(300, 40);
            this.txtCnfrmPass.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.txtCnfrmPass.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.txtCnfrmPass.StateCommon.Border.Rounding = 20F;
            this.txtCnfrmPass.StateCommon.Border.Width = 2;
            this.txtCnfrmPass.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.txtCnfrmPass.StateCommon.Content.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnfrmPass.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0, 0, 0, -7);
            this.txtCnfrmPass.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtCnfrmPass.TabIndex = 12;
            this.txtCnfrmPass.TabStop = false;
            this.txtCnfrmPass.Text = "Confirm Password";
            this.txtCnfrmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCnfrmPass.Enter += new System.EventHandler(this.txtCnfrmPass_Enter);
            this.txtCnfrmPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnfrmPass_KeyPress);
            this.txtCnfrmPass.Leave += new System.EventHandler(this.txtCnfrmPass_Leave);
            this.txtCnfrmPass.MouseEnter += new System.EventHandler(this.txtCnfrmPass_MouseEnter);
            this.txtCnfrmPass.MouseLeave += new System.EventHandler(this.txtCnfrmPass_MouseLeave);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(100, 100);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(300, 40);
            this.txtFullName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.txtFullName.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.txtFullName.StateCommon.Border.Rounding = 20F;
            this.txtFullName.StateCommon.Border.Width = 2;
            this.txtFullName.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.txtFullName.StateCommon.Content.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtFullName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0, 0, 0, -7);
            this.txtFullName.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtFullName.TabIndex = 11;
            this.txtFullName.TabStop = false;
            this.txtFullName.Text = "Full Name";
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFullName.Enter += new System.EventHandler(this.txtFullName_Enter);
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            this.txtFullName.MouseEnter += new System.EventHandler(this.txtFullName_MouseEnter);
            this.txtFullName.MouseLeave += new System.EventHandler(this.txtFullName_MouseLeave);
            // 
            // lblCreateAcc
            // 
            this.lblCreateAcc.Location = new System.Drawing.Point(125, 30);
            this.lblCreateAcc.Name = "lblCreateAcc";
            this.lblCreateAcc.Size = new System.Drawing.Size(246, 47);
            this.lblCreateAcc.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 10);
            this.lblCreateAcc.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.lblCreateAcc.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.lblCreateAcc.StateCommon.ShortText.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAcc.TabIndex = 10;
            this.lblCreateAcc.Values.Text = "Create Account Here!";
            // 
            // lblLogIn
            // 
            this.lblLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogIn.Location = new System.Drawing.Point(156, 556);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(202, 22);
            this.lblLogIn.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.lblLogIn.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.lblLogIn.StateCommon.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblLogIn.TabIndex = 9;
            this.lblLogIn.Values.Text = "Already have acc? LogIn";
            this.lblLogIn.Click += new System.EventHandler(this.lblLogIn_Click);
            this.lblLogIn.MouseEnter += new System.EventHandler(this.lblLogIn_MouseEnter);
            this.lblLogIn.MouseLeave += new System.EventHandler(this.lblLogIn_MouseLeave);
            // 
            // lblPicture
            // 
            this.lblPicture.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblPicture.Location = new System.Drawing.Point(163, 328);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(183, 25);
            this.lblPicture.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.lblPicture.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.lblPicture.StateCommon.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblPicture.TabIndex = 1;
            this.lblPicture.TabStop = false;
            this.lblPicture.Values.Text = "Upload profile Picture\n";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Location = new System.Drawing.Point(100, 499);
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
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
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
            this.txtUserName.Location = new System.Drawing.Point(100, 160);
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
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test.Properties.Resources._1755186696637;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.LoginPanel);
            this.Name = "signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinup";
            this.Click += new System.EventHandler(this.signup_Click);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPanel)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel LoginPanel;
        private Krypton.Toolkit.KryptonLabel lblCreateAcc;
        private Krypton.Toolkit.KryptonLabel lblLogIn;
        private Krypton.Toolkit.KryptonLabel lblPicture;
        private Krypton.Toolkit.KryptonButton btnSignUp;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private Krypton.Toolkit.KryptonTextBox txtUserName;
        private Krypton.Toolkit.KryptonTextBox txtFullName;
        private Krypton.Toolkit.KryptonTextBox txtCnfrmPass;
        private Krypton.Toolkit.KryptonButton btnBrowse;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
    }
}