namespace test
{
    partial class Search
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
            this.PanelSearch = new Krypton.Toolkit.KryptonPanel();
            this.lblSearch = new Krypton.Toolkit.KryptonLabel();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.txtEntertitle = new Krypton.Toolkit.KryptonTextBox();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.DataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PanelSearch)).BeginInit();
            this.PanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSearch
            // 
            this.PanelSearch.Controls.Add(this.DataGridView1);
            this.PanelSearch.Controls.Add(this.btnSearch);
            this.PanelSearch.Controls.Add(this.txtEntertitle);
            this.PanelSearch.Controls.Add(this.btnClose);
            this.PanelSearch.Controls.Add(this.lblSearch);
            this.PanelSearch.Location = new System.Drawing.Point(285, 84);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(900, 780);
            this.PanelSearch.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.PanelSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(369, 3);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(196, 48);
            this.lblSearch.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 5);
            this.lblSearch.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.lblSearch.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.lblSearch.StateCommon.ShortText.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Values.Text = "Search Entries";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(739, 80);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnClose.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnClose.OverrideDefault.Back.ColorAngle = 0F;
            this.btnClose.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnClose.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnClose.OverrideDefault.Border.Rounding = 20F;
            this.btnClose.OverrideDefault.Border.Width = 2;
            this.btnClose.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClose.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnClose.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Georgia", 18F);
            this.btnClose.Size = new System.Drawing.Size(130, 35);
            this.btnClose.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnClose.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnClose.StateCommon.Back.ColorAngle = 0F;
            this.btnClose.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnClose.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnClose.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnClose.StateCommon.Border.ColorAngle = 0F;
            this.btnClose.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 20F;
            this.btnClose.StateCommon.Border.Width = 2;
            this.btnClose.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClose.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Georgia", 18F);
            this.btnClose.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnClose.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnClose.StateNormal.Back.ColorAngle = 0F;
            this.btnClose.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnClose.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnClose.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnClose.StateNormal.Border.ColorAngle = 0F;
            this.btnClose.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnClose.StateNormal.Border.Rounding = 20F;
            this.btnClose.StateNormal.Border.Width = 2;
            this.btnClose.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClose.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnClose.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(130)))));
            this.btnClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnClose.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnClose.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnClose.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnClose.StatePressed.Border.ColorAngle = 0F;
            this.btnClose.StatePressed.Border.Rounding = 20F;
            this.btnClose.StatePressed.Border.Width = 2;
            this.btnClose.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClose.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnClose.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Georgia", 18F);
            this.btnClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnClose.StateTracking.Back.ColorAngle = 0F;
            this.btnClose.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnClose.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnClose.StateTracking.Border.ColorAngle = 0F;
            this.btnClose.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnClose.StateTracking.Border.Rounding = 20F;
            this.btnClose.StateTracking.Border.Width = 2;
            this.btnClose.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClose.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnClose.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Georgia", 18F);
            this.btnClose.TabIndex = 16;
            this.btnClose.TabStop = false;
            this.btnClose.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClose.Values.Text = "Close";
            // 
            // txtEntertitle
            // 
            this.txtEntertitle.Location = new System.Drawing.Point(20, 80);
            this.txtEntertitle.Multiline = true;
            this.txtEntertitle.Name = "txtEntertitle";
            this.txtEntertitle.Size = new System.Drawing.Size(530, 35);
            this.txtEntertitle.StateCommon.Back.Color1 = System.Drawing.Color.PapayaWhip;
            this.txtEntertitle.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.txtEntertitle.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.txtEntertitle.StateCommon.Border.Rounding = 20F;
            this.txtEntertitle.StateCommon.Border.Width = 2;
            this.txtEntertitle.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.txtEntertitle.StateCommon.Content.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntertitle.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0, 0, 0, -7);
            this.txtEntertitle.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtEntertitle.TabIndex = 17;
            this.txtEntertitle.TabStop = false;
            this.txtEntertitle.Text = "Enter Title ";
            this.txtEntertitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(584, 80);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSearch.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSearch.OverrideDefault.Back.ColorAngle = 0F;
            this.btnSearch.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnSearch.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnSearch.OverrideDefault.Border.Rounding = 20F;
            this.btnSearch.OverrideDefault.Border.Width = 2;
            this.btnSearch.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSearch.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Georgia", 18F);
            this.btnSearch.Size = new System.Drawing.Size(130, 35);
            this.btnSearch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSearch.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSearch.StateCommon.Back.ColorAngle = 0F;
            this.btnSearch.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSearch.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnSearch.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnSearch.StateCommon.Border.ColorAngle = 0F;
            this.btnSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StateCommon.Border.Rounding = 20F;
            this.btnSearch.StateCommon.Border.Width = 2;
            this.btnSearch.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSearch.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Georgia", 18F);
            this.btnSearch.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSearch.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSearch.StateNormal.Back.ColorAngle = 0F;
            this.btnSearch.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSearch.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnSearch.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnSearch.StateNormal.Border.ColorAngle = 0F;
            this.btnSearch.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearch.StateNormal.Border.Rounding = 20F;
            this.btnSearch.StateNormal.Border.Width = 2;
            this.btnSearch.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSearch.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(130)))));
            this.btnSearch.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSearch.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSearch.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnSearch.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnSearch.StatePressed.Border.ColorAngle = 0F;
            this.btnSearch.StatePressed.Border.Rounding = 20F;
            this.btnSearch.StatePressed.Border.Width = 2;
            this.btnSearch.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSearch.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Georgia", 18F);
            this.btnSearch.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSearch.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.btnSearch.StateTracking.Back.ColorAngle = 0F;
            this.btnSearch.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnSearch.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.btnSearch.StateTracking.Border.ColorAngle = 0F;
            this.btnSearch.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearch.StateTracking.Border.Rounding = 20F;
            this.btnSearch.StateTracking.Border.Width = 2;
            this.btnSearch.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSearch.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Georgia", 18F);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.TabStop = false;
            this.btnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSearch.Values.Text = "Search";
            // 
            // DataGridView1
            // 
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(20, 140);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365Silver;
            this.DataGridView1.Size = new System.Drawing.Size(860, 614);
            this.DataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.AntiqueWhite;
            this.DataGridView1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.DataGridView1.TabIndex = 19;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.PanelSearch);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.PanelSearch)).EndInit();
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel PanelSearch;
        private Krypton.Toolkit.KryptonLabel lblSearch;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonTextBox txtEntertitle;
        private Krypton.Toolkit.KryptonDataGridView DataGridView1;
    }
}