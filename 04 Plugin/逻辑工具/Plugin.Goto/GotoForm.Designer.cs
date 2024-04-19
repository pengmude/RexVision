namespace Plugin.Goto
{
    partial class GotoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GotoForm));
            this.uiRadioButton1 = new Rex.UI.UIRadioButton();
            this.uiRadioButton2 = new Rex.UI.UIRadioButton();
            this.uiLink_Go = new Rex.UI.UILinkText();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uicomb_FuncData = new Rex.UI.UIComboBox();
            this.uicomb_FuncType = new Rex.UI.UIComboBox();
            this.uiLabel1 = new Rex.UI.UILabel();
            this.uiLink_FuncStr = new Rex.UI.UILinkText();
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
            this.panel_center.Controls.Add(this.uicomb_FuncData);
            this.panel_center.Controls.Add(this.uicomb_FuncType);
            this.panel_center.Controls.Add(this.uiLabel1);
            this.panel_center.Controls.Add(this.uiLink_FuncStr);
            this.panel_center.Controls.Add(this.label4);
            this.panel_center.Controls.Add(this.label3);
            this.panel_center.Controls.Add(this.label1);
            this.panel_center.Controls.Add(this.uiLink_Go);
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
            // uiLink_Go
            // 
            this.uiLink_Go.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_Go.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_Go.Location = new System.Drawing.Point(79, 83);
            this.uiLink_Go.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_Go.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_Go.Name = "uiLink_Go";
            this.uiLink_Go.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_Go.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_Go.Size = new System.Drawing.Size(374, 24);
            this.uiLink_Go.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_Go.StyleCustomMode = true;
            this.uiLink_Go.TabIndex = 135;
            this.uiLink_Go.Text = "uiLinkText1";
            this.uiLink_Go.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLinkText1_BtnAdd);
            this.uiLink_Go.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLinkText1_BtnDec);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(83, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 136;
            this.label1.Text = "如果:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(43, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 137;
            this.label3.Text = "跳转:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(4, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 138;
            this.label4.Text = "注意:目前只支持向下跳转!";
            // 
            // uicomb_FuncData
            // 
            this.uicomb_FuncData.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicomb_FuncData.Items.AddRange(new object[] {
            "1",
            "0",
            "true",
            "false"});
            this.uicomb_FuncData.Location = new System.Drawing.Point(366, 52);
            this.uicomb_FuncData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uicomb_FuncData.MaxDropDownItems = 5;
            this.uicomb_FuncData.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicomb_FuncData.Name = "uicomb_FuncData";
            this.uicomb_FuncData.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicomb_FuncData.Radius = 2;
            this.uicomb_FuncData.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicomb_FuncData.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicomb_FuncData.Size = new System.Drawing.Size(87, 23);
            this.uicomb_FuncData.Style = Rex.UI.UIStyle.Custom;
            this.uicomb_FuncData.StyleCustomMode = true;
            this.uicomb_FuncData.TabIndex = 142;
            this.uicomb_FuncData.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uicomb_FuncData.Watermark = "判断条件";
            // 
            // uicomb_FuncType
            // 
            this.uicomb_FuncType.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicomb_FuncType.Items.AddRange(new object[] {
            "等于",
            "不等于",
            "大于",
            "大于等于",
            "小于",
            "小于等于",
            "包含",
            "不包含"});
            this.uicomb_FuncType.Location = new System.Drawing.Point(263, 52);
            this.uicomb_FuncType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uicomb_FuncType.MaxDropDownItems = 5;
            this.uicomb_FuncType.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicomb_FuncType.Name = "uicomb_FuncType";
            this.uicomb_FuncType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicomb_FuncType.Radius = 2;
            this.uicomb_FuncType.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicomb_FuncType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicomb_FuncType.Size = new System.Drawing.Size(95, 23);
            this.uicomb_FuncType.Style = Rex.UI.UIStyle.Custom;
            this.uicomb_FuncType.StyleCustomMode = true;
            this.uicomb_FuncType.TabIndex = 141;
            this.uicomb_FuncType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uicomb_FuncType.Watermark = "运算符号";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiLabel1.Location = new System.Drawing.Point(43, 55);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(35, 17);
            this.uiLabel1.TabIndex = 140;
            this.uiLabel1.Text = "如果:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLink_FuncStr
            // 
            this.uiLink_FuncStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_FuncStr.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_FuncStr.Location = new System.Drawing.Point(79, 51);
            this.uiLink_FuncStr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_FuncStr.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_FuncStr.Name = "uiLink_FuncStr";
            this.uiLink_FuncStr.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_FuncStr.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_FuncStr.Size = new System.Drawing.Size(177, 24);
            this.uiLink_FuncStr.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_FuncStr.StyleCustomMode = true;
            this.uiLink_FuncStr.TabIndex = 139;
            this.uiLink_FuncStr.Text = "uiLink_FuncStr";
            this.uiLink_FuncStr.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLinkText1_BtnAdd);
            this.uiLink_FuncStr.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLinkText1_BtnDec);
            // 
            // GotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 198);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(500, 200);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "GotoForm";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Rex.UI.UILinkText uiLink_Go;
        private System.Windows.Forms.Label label4;
        private Rex.UI.UIComboBox uicomb_FuncData;
        private Rex.UI.UIComboBox uicomb_FuncType;
        public Rex.UI.UILabel uiLabel1;
        private Rex.UI.UILinkText uiLink_FuncStr;
    }
}