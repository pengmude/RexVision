namespace Plugin.IF
{
    partial class IFForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IFForm));
            this.uiRadioButton1 = new Rex.UI.UIRadioButton();
            this.uiRadioButton2 = new Rex.UI.UIRadioButton();
            this.uiLink_FuncStr1 = new Rex.UI.UILinkText();
            this.uiLabel1 = new Rex.UI.UILabel();
            this.uicomb_FuncType1 = new Rex.UI.UIComboBox();
            this.uicomb_FuncData1 = new Rex.UI.UIComboBox();
            this.uicomb_FuncData2 = new Rex.UI.UIComboBox();
            this.uicomb_FuncType2 = new Rex.UI.UIComboBox();
            this.uiLink_FuncStr2 = new Rex.UI.UILinkText();
            this.uiLabel2 = new Rex.UI.UILabel();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Location = new System.Drawing.Point(1, 159);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_bottom.Size = new System.Drawing.Size(496, 38);
            // 
            // panel_center
            // 
            this.panel_center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.panel_center.Controls.Add(this.uiLabel2);
            this.panel_center.Controls.Add(this.uicomb_FuncData2);
            this.panel_center.Controls.Add(this.uicomb_FuncType2);
            this.panel_center.Controls.Add(this.uiLink_FuncStr2);
            this.panel_center.Controls.Add(this.uicomb_FuncData1);
            this.panel_center.Controls.Add(this.uicomb_FuncType1);
            this.panel_center.Controls.Add(this.uiLabel1);
            this.panel_center.Controls.Add(this.uiLink_FuncStr1);
            this.panel_center.Controls.Add(this.uiRadioButton2);
            this.panel_center.Controls.Add(this.uiRadioButton1);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.Size = new System.Drawing.Size(496, 126);
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Margin = new System.Windows.Forms.Padding(2);
            this.uitb_Remark.Size = new System.Drawing.Size(128, 23);
            // 
            // cb_Enable
            // 
            this.cb_Enable.Location = new System.Drawing.Point(170, 8);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(408, 6);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(321, 6);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(234, 6);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(496, 32);
            // 
            // uiRadioButton1
            // 
            this.uiRadioButton1.Checked = true;
            this.uiRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiRadioButton1.Location = new System.Drawing.Point(128, 24);
            this.uiRadioButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton1.Name = "uiRadioButton1";
            this.uiRadioButton1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton1.Size = new System.Drawing.Size(113, 21);
            this.uiRadioButton1.TabIndex = 1;
            this.uiRadioButton1.Text = "Bool数据链接";
            // 
            // uiRadioButton2
            // 
            this.uiRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiRadioButton2.Location = new System.Drawing.Point(276, 24);
            this.uiRadioButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton2.Name = "uiRadioButton2";
            this.uiRadioButton2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton2.Size = new System.Drawing.Size(84, 21);
            this.uiRadioButton2.TabIndex = 2;
            this.uiRadioButton2.Text = "计算表达式";
            // 
            // uiLink_FuncStr1
            // 
            this.uiLink_FuncStr1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_FuncStr1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_FuncStr1.Location = new System.Drawing.Point(64, 52);
            this.uiLink_FuncStr1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_FuncStr1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_FuncStr1.Name = "uiLink_FuncStr1";
            this.uiLink_FuncStr1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_FuncStr1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_FuncStr1.Size = new System.Drawing.Size(177, 24);
            this.uiLink_FuncStr1.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_FuncStr1.StyleCustomMode = true;
            this.uiLink_FuncStr1.TabIndex = 3;
            this.uiLink_FuncStr1.Text = "uiLink_FuncStr";
            this.uiLink_FuncStr1.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLinkText1_BtnAdd);
            this.uiLink_FuncStr1.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLinkText1_BtnDec);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiLabel1.Location = new System.Drawing.Point(28, 56);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(35, 17);
            this.uiLabel1.TabIndex = 13;
            this.uiLabel1.Text = "如果:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uicomb_FuncType1
            // 
            this.uicomb_FuncType1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicomb_FuncType1.Items.AddRange(new object[] {
            "等于",
            "不等于",
            "大于",
            "大于等于",
            "小于",
            "小于等于",
            "包含",
            "不包含"});
            this.uicomb_FuncType1.Location = new System.Drawing.Point(248, 53);
            this.uicomb_FuncType1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uicomb_FuncType1.MaxDropDownItems = 5;
            this.uicomb_FuncType1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicomb_FuncType1.Name = "uicomb_FuncType1";
            this.uicomb_FuncType1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicomb_FuncType1.Radius = 2;
            this.uicomb_FuncType1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicomb_FuncType1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicomb_FuncType1.Size = new System.Drawing.Size(95, 23);
            this.uicomb_FuncType1.Style = Rex.UI.UIStyle.Custom;
            this.uicomb_FuncType1.StyleCustomMode = true;
            this.uicomb_FuncType1.TabIndex = 14;
            this.uicomb_FuncType1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uicomb_FuncType1.Watermark = "运算符号";
            // 
            // uicomb_FuncData1
            // 
            this.uicomb_FuncData1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicomb_FuncData1.Items.AddRange(new object[] {
            "1",
            "0",
            "true",
            "false"});
            this.uicomb_FuncData1.Location = new System.Drawing.Point(351, 53);
            this.uicomb_FuncData1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uicomb_FuncData1.MaxDropDownItems = 5;
            this.uicomb_FuncData1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicomb_FuncData1.Name = "uicomb_FuncData1";
            this.uicomb_FuncData1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicomb_FuncData1.Radius = 2;
            this.uicomb_FuncData1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicomb_FuncData1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicomb_FuncData1.Size = new System.Drawing.Size(87, 23);
            this.uicomb_FuncData1.Style = Rex.UI.UIStyle.Custom;
            this.uicomb_FuncData1.StyleCustomMode = true;
            this.uicomb_FuncData1.TabIndex = 15;
            this.uicomb_FuncData1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uicomb_FuncData1.Watermark = "判断条件";
            // 
            // uicomb_FuncData2
            // 
            this.uicomb_FuncData2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicomb_FuncData2.Items.AddRange(new object[] {
            "1",
            "0",
            "true",
            "false"});
            this.uicomb_FuncData2.Location = new System.Drawing.Point(351, 85);
            this.uicomb_FuncData2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uicomb_FuncData2.MaxDropDownItems = 5;
            this.uicomb_FuncData2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicomb_FuncData2.Name = "uicomb_FuncData2";
            this.uicomb_FuncData2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicomb_FuncData2.Radius = 2;
            this.uicomb_FuncData2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicomb_FuncData2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicomb_FuncData2.Size = new System.Drawing.Size(87, 23);
            this.uicomb_FuncData2.Style = Rex.UI.UIStyle.Custom;
            this.uicomb_FuncData2.StyleCustomMode = true;
            this.uicomb_FuncData2.TabIndex = 18;
            this.uicomb_FuncData2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uicomb_FuncData2.Watermark = "判断条件";
            // 
            // uicomb_FuncType2
            // 
            this.uicomb_FuncType2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicomb_FuncType2.Items.AddRange(new object[] {
            "等于",
            "不等于",
            "大于",
            "大于等于",
            "小于",
            "小于等于",
            "包含",
            "不包含"});
            this.uicomb_FuncType2.Location = new System.Drawing.Point(248, 85);
            this.uicomb_FuncType2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uicomb_FuncType2.MaxDropDownItems = 5;
            this.uicomb_FuncType2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicomb_FuncType2.Name = "uicomb_FuncType2";
            this.uicomb_FuncType2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicomb_FuncType2.Radius = 2;
            this.uicomb_FuncType2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicomb_FuncType2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicomb_FuncType2.Size = new System.Drawing.Size(95, 23);
            this.uicomb_FuncType2.Style = Rex.UI.UIStyle.Custom;
            this.uicomb_FuncType2.StyleCustomMode = true;
            this.uicomb_FuncType2.TabIndex = 17;
            this.uicomb_FuncType2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uicomb_FuncType2.Watermark = "运算符号";
            // 
            // uiLink_FuncStr2
            // 
            this.uiLink_FuncStr2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_FuncStr2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_FuncStr2.Location = new System.Drawing.Point(64, 84);
            this.uiLink_FuncStr2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_FuncStr2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_FuncStr2.Name = "uiLink_FuncStr2";
            this.uiLink_FuncStr2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_FuncStr2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_FuncStr2.Size = new System.Drawing.Size(177, 24);
            this.uiLink_FuncStr2.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_FuncStr2.StyleCustomMode = true;
            this.uiLink_FuncStr2.TabIndex = 16;
            this.uiLink_FuncStr2.Text = "uiLinkText1";
            this.uiLink_FuncStr2.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLinkText1_BtnAdd);
            this.uiLink_FuncStr2.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLinkText1_BtnDec);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiLabel2.Location = new System.Drawing.Point(40, 87);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(23, 17);
            this.uiLabel2.TabIndex = 19;
            this.uiLabel2.Text = "与:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 198);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(500, 200);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "IFForm";
            this.Load += new System.EventHandler(this.DelayModForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.UI.UIRadioButton uiRadioButton2;
        private Rex.UI.UIRadioButton uiRadioButton1;
        private Rex.UI.UILinkText uiLink_FuncStr1;
        public Rex.UI.UILabel uiLabel1;
        private Rex.UI.UIComboBox uicomb_FuncData1;
        private Rex.UI.UIComboBox uicomb_FuncType1;
        public Rex.UI.UILabel uiLabel2;
        private Rex.UI.UIComboBox uicomb_FuncData2;
        private Rex.UI.UIComboBox uicomb_FuncType2;
        private Rex.UI.UILinkText uiLink_FuncStr2;
    }
}