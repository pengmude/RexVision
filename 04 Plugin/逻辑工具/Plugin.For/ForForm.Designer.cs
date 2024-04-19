namespace Plugin.For
{
    partial class ForForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForForm));
            this.uiLink_StarStr = new Rex.UI.UILinkText();
            this.uiLink_OverStr = new Rex.UI.UILinkText();
            this.uicb_ForMode = new Rex.UI.UIComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panel_center.Controls.Add(this.label3);
            this.panel_center.Controls.Add(this.label2);
            this.panel_center.Controls.Add(this.label1);
            this.panel_center.Controls.Add(this.uicb_ForMode);
            this.panel_center.Controls.Add(this.uiLink_OverStr);
            this.panel_center.Controls.Add(this.uiLink_StarStr);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.Size = new System.Drawing.Size(496, 126);
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Margin = new System.Windows.Forms.Padding(2);
            this.uitb_Remark.Size = new System.Drawing.Size(133, 23);
            // 
            // cb_Enable
            // 
            this.cb_Enable.Location = new System.Drawing.Point(175, 8);
            this.cb_Enable.Size = new System.Drawing.Size(54, 21);
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
            // uiLink_StarStr
            // 
            this.uiLink_StarStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_StarStr.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_StarStr.Location = new System.Drawing.Point(140, 52);
            this.uiLink_StarStr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_StarStr.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_StarStr.Name = "uiLink_StarStr";
            this.uiLink_StarStr.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_StarStr.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_StarStr.Size = new System.Drawing.Size(250, 24);
            this.uiLink_StarStr.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_StarStr.StyleCustomMode = true;
            this.uiLink_StarStr.TabIndex = 3;
            this.uiLink_StarStr.Text = "uiLink_IF";
            this.uiLink_StarStr.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLinkText1_BtnAdd);
            this.uiLink_StarStr.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLinkText1_BtnDec);
            // 
            // uiLink_OverStr
            // 
            this.uiLink_OverStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_OverStr.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_OverStr.Location = new System.Drawing.Point(140, 84);
            this.uiLink_OverStr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_OverStr.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_OverStr.Name = "uiLink_OverStr";
            this.uiLink_OverStr.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_OverStr.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_OverStr.Size = new System.Drawing.Size(250, 24);
            this.uiLink_OverStr.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_OverStr.StyleCustomMode = true;
            this.uiLink_OverStr.TabIndex = 135;
            this.uiLink_OverStr.Text = "uiLinkText1";
            this.uiLink_OverStr.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLinkText1_BtnAdd);
            this.uiLink_OverStr.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLinkText1_BtnDec);
            // 
            // uicb_ForMode
            // 
            this.uicb_ForMode.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_ForMode.Items.AddRange(new object[] {
            "递增（起始+1到结束）",
            "递减（结束 -1 到起始）",
            "无限循环"});
            this.uicb_ForMode.Location = new System.Drawing.Point(140, 20);
            this.uicb_ForMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uicb_ForMode.MaxDropDownItems = 5;
            this.uicb_ForMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicb_ForMode.Name = "uicb_ForMode";
            this.uicb_ForMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicb_ForMode.Radius = 2;
            this.uicb_ForMode.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicb_ForMode.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicb_ForMode.Size = new System.Drawing.Size(250, 23);
            this.uicb_ForMode.Style = Rex.UI.UIStyle.Custom;
            this.uicb_ForMode.StyleCustomMode = true;
            this.uicb_ForMode.TabIndex = 136;
            this.uicb_ForMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uicb_ForMode.Watermark = "选择循环方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 137;
            this.label1.Text = "循环方式:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(88, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 138;
            this.label2.Text = "起始值:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(88, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 139;
            this.label3.Text = "结束值:";
            // 
            // ForForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 198);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(500, 200);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "ForForm";
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
        private Rex.UI.UILinkText uiLink_StarStr;
        private Rex.UI.UILinkText uiLink_OverStr;
        private Rex.UI.UIComboBox uicb_ForMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}