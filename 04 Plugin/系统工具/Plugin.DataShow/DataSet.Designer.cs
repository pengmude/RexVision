namespace Plugin.DataShow
{
    partial class DataSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSet));
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.uiLink_X = new Rex.UI.UILinkText();
            this.uiLink_Y = new Rex.UI.UILinkText();
            this.uiLink_Status = new Rex.UI.UILinkText();
            this.uiLink_Msg = new Rex.UI.UILinkText();
            this.uicb_Align = new Rex.UI.UIComboBox();
            this.uicp_OK = new Rex.UI.UIColorPicker();
            this.uicp_NG = new Rex.UI.UIColorPicker();
            this.uitb_Prefix = new Rex.UI.UITextBox();
            this.uitb_Suffix = new Rex.UI.UITextBox();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Location = new System.Drawing.Point(1, 359);
            this.panel_bottom.Size = new System.Drawing.Size(296, 38);
            // 
            // panel_center
            // 
            this.panel_center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.panel_center.Controls.Add(this.uitb_Suffix);
            this.panel_center.Controls.Add(this.uitb_Prefix);
            this.panel_center.Controls.Add(this.uicp_NG);
            this.panel_center.Controls.Add(this.uicp_OK);
            this.panel_center.Controls.Add(this.uicb_Align);
            this.panel_center.Controls.Add(this.uiLink_Msg);
            this.panel_center.Controls.Add(this.uiLink_Status);
            this.panel_center.Controls.Add(this.uiLink_Y);
            this.panel_center.Controls.Add(this.uiLink_X);
            this.panel_center.Controls.Add(this.label9);
            this.panel_center.Controls.Add(this.label5);
            this.panel_center.Controls.Add(this.label6);
            this.panel_center.Controls.Add(this.label7);
            this.panel_center.Controls.Add(this.label8);
            this.panel_center.Controls.Add(this.label3);
            this.panel_center.Controls.Add(this.label4);
            this.panel_center.Controls.Add(this.label1);
            this.panel_center.Controls.Add(this.label10);
            this.panel_center.Size = new System.Drawing.Size(296, 326);
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Location = new System.Drawing.Point(24, 9);
            this.uitb_Remark.Size = new System.Drawing.Size(10, 23);
            this.uitb_Remark.Visible = false;
            // 
            // uIlb_describle
            // 
            this.uIlb_describle.Visible = false;
            // 
            // cb_Enable
            // 
            this.cb_Enable.Location = new System.Drawing.Point(5, 11);
            this.cb_Enable.Visible = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(190, 6);
            this.btn_Cancel.Size = new System.Drawing.Size(90, 26);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(92, 6);
            this.btn_Save.Size = new System.Drawing.Size(90, 26);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(-1076, 6);
            this.btn_Run.Size = new System.Drawing.Size(1, 26);
            this.btn_Run.Visible = false;
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(296, 32);
            // 
            // titlelabel
            // 
            this.titlelabel.Location = new System.Drawing.Point(35, 5);
            this.titlelabel.Size = new System.Drawing.Size(74, 21);
            this.titlelabel.Text = "文本设置";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(17, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 169;
            this.label9.Text = "NG 颜色:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(18, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 168;
            this.label5.Text = "OK 颜色:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(40, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 167;
            this.label6.Text = "后缀:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(40, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 166;
            this.label7.Text = "前缀:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(16, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 165;
            this.label8.Text = "显示内容:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 164;
            this.label3.Text = "状态链接:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(25, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 163;
            this.label4.Text = " 位置 Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 162;
            this.label1.Text = " 位置 X:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(16, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 161;
            this.label10.Text = "对齐方式:";
            // 
            // uiLink_X
            // 
            this.uiLink_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_X.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_X.Location = new System.Drawing.Point(75, 48);
            this.uiLink_X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLink_X.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_X.Name = "uiLink_X";
            this.uiLink_X.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_X.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_X.Size = new System.Drawing.Size(215, 25);
            this.uiLink_X.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_X.StyleCustomMode = true;
            this.uiLink_X.TabIndex = 170;
            this.uiLink_X.Text = "uiLinkText1";
            this.uiLink_X.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uilk_BtnAdd);
            this.uiLink_X.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uilk_BtnDec);
            // 
            // uiLink_Y
            // 
            this.uiLink_Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_Y.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_Y.Location = new System.Drawing.Point(75, 79);
            this.uiLink_Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLink_Y.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_Y.Name = "uiLink_Y";
            this.uiLink_Y.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_Y.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_Y.Size = new System.Drawing.Size(215, 25);
            this.uiLink_Y.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_Y.StyleCustomMode = true;
            this.uiLink_Y.TabIndex = 142;
            this.uiLink_Y.Text = "uiLinkText1";
            this.uiLink_Y.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uilk_BtnAdd);
            this.uiLink_Y.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uilk_BtnDec);
            // 
            // uiLink_Status
            // 
            this.uiLink_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_Status.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_Status.Location = new System.Drawing.Point(75, 110);
            this.uiLink_Status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLink_Status.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_Status.Name = "uiLink_Status";
            this.uiLink_Status.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_Status.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_Status.Size = new System.Drawing.Size(215, 25);
            this.uiLink_Status.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_Status.StyleCustomMode = true;
            this.uiLink_Status.TabIndex = 142;
            this.uiLink_Status.Text = "uiLinkText1";
            this.uiLink_Status.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uilk_BtnAdd);
            this.uiLink_Status.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uilk_BtnDec);
            // 
            // uiLink_Msg
            // 
            this.uiLink_Msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_Msg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_Msg.Location = new System.Drawing.Point(75, 141);
            this.uiLink_Msg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLink_Msg.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_Msg.Name = "uiLink_Msg";
            this.uiLink_Msg.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_Msg.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_Msg.Size = new System.Drawing.Size(215, 25);
            this.uiLink_Msg.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_Msg.StyleCustomMode = true;
            this.uiLink_Msg.TabIndex = 142;
            this.uiLink_Msg.Text = "uiLinkText1";
            this.uiLink_Msg.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uilk_BtnAdd);
            this.uiLink_Msg.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uilk_BtnDec);
            // 
            // uicb_Align
            // 
            this.uicb_Align.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Align.Items.AddRange(new object[] {
            "左边",
            "中间",
            "右边"});
            this.uicb_Align.Location = new System.Drawing.Point(75, 18);
            this.uicb_Align.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uicb_Align.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicb_Align.Name = "uicb_Align";
            this.uicb_Align.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicb_Align.Radius = 2;
            this.uicb_Align.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicb_Align.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicb_Align.Size = new System.Drawing.Size(215, 23);
            this.uicb_Align.Style = Rex.UI.UIStyle.Custom;
            this.uicb_Align.StyleCustomMode = true;
            this.uicb_Align.TabIndex = 173;
            this.uicb_Align.Text = "左边";
            this.uicb_Align.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uicp_OK
            // 
            this.uicp_OK.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.uicp_OK.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicp_OK.Location = new System.Drawing.Point(75, 242);
            this.uicp_OK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uicp_OK.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicp_OK.Name = "uicp_OK";
            this.uicp_OK.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicp_OK.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicp_OK.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicp_OK.Size = new System.Drawing.Size(215, 23);
            this.uicp_OK.Style = Rex.UI.UIStyle.Custom;
            this.uicp_OK.StyleCustomMode = true;
            this.uicp_OK.TabIndex = 176;
            this.uicp_OK.Text = "uiColorPicker1";
            this.uicp_OK.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uicp_OK.Value = System.Drawing.Color.Cyan;
            // 
            // uicp_NG
            // 
            this.uicp_NG.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.uicp_NG.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicp_NG.Location = new System.Drawing.Point(75, 273);
            this.uicp_NG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uicp_NG.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicp_NG.Name = "uicp_NG";
            this.uicp_NG.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicp_NG.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicp_NG.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicp_NG.Size = new System.Drawing.Size(215, 23);
            this.uicp_NG.Style = Rex.UI.UIStyle.Custom;
            this.uicp_NG.StyleCustomMode = true;
            this.uicp_NG.TabIndex = 177;
            this.uicp_NG.Text = "uiColorPicker2";
            this.uicp_NG.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uicp_NG.Value = System.Drawing.Color.Red;
            // 
            // uitb_Prefix
            // 
            this.uitb_Prefix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitb_Prefix.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uitb_Prefix.Location = new System.Drawing.Point(75, 172);
            this.uitb_Prefix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitb_Prefix.Maximum = 2147483647D;
            this.uitb_Prefix.Minimum = -2147483648D;
            this.uitb_Prefix.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitb_Prefix.Name = "uitb_Prefix";
            this.uitb_Prefix.Padding = new System.Windows.Forms.Padding(5);
            this.uitb_Prefix.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitb_Prefix.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitb_Prefix.Size = new System.Drawing.Size(215, 23);
            this.uitb_Prefix.StyleCustomMode = true;
            this.uitb_Prefix.TabIndex = 178;
            this.uitb_Prefix.Watermark = "如：X=";
            // 
            // uitb_Suffix
            // 
            this.uitb_Suffix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitb_Suffix.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uitb_Suffix.Location = new System.Drawing.Point(75, 205);
            this.uitb_Suffix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitb_Suffix.Maximum = 2147483647D;
            this.uitb_Suffix.Minimum = -2147483648D;
            this.uitb_Suffix.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitb_Suffix.Name = "uitb_Suffix";
            this.uitb_Suffix.Padding = new System.Windows.Forms.Padding(5);
            this.uitb_Suffix.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitb_Suffix.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitb_Suffix.Size = new System.Drawing.Size(215, 23);
            this.uitb_Suffix.StyleCustomMode = true;
            this.uitb_Suffix.TabIndex = 179;
            this.uitb_Suffix.Watermark = "如：。";
            // 
            // DataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 398);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 400);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "DataSet";
            this.Title = "文本设置";
            this.TitleSize = new System.Drawing.Size(74, 21);
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

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private Rex.UI.UIComboBox uicb_Align;
        private Rex.UI.UILinkText uiLink_Msg;
        private Rex.UI.UILinkText uiLink_Status;
        private Rex.UI.UILinkText uiLink_Y;
        private Rex.UI.UILinkText uiLink_X;
        private Rex.UI.UIColorPicker uicp_NG;
        private Rex.UI.UIColorPicker uicp_OK;
        private Rex.UI.UITextBox uitb_Suffix;
        private Rex.UI.UITextBox uitb_Prefix;
    }
}