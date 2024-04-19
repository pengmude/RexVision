namespace Plugin.SendData
{
    partial class SendDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendDataForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ui_PortSelect = new Rex.UI.UIComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ui_EndChar = new Rex.UI.UITextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ui_Describle = new Rex.UI.UITextBox();
            this.ui_SendText = new Rex.UI.UILinkData();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Location = new System.Drawing.Point(1, 227);
            this.panel_bottom.Size = new System.Drawing.Size(256, 40);
            // 
            // panel_center
            // 
            this.panel_center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.panel_center.Controls.Add(this.label9);
            this.panel_center.Controls.Add(this.label8);
            this.panel_center.Controls.Add(this.label7);
            this.panel_center.Controls.Add(this.label6);
            this.panel_center.Controls.Add(this.ui_SendText);
            this.panel_center.Controls.Add(this.ui_Describle);
            this.panel_center.Controls.Add(this.label5);
            this.panel_center.Controls.Add(this.ui_EndChar);
            this.panel_center.Controls.Add(this.label4);
            this.panel_center.Controls.Add(this.ui_PortSelect);
            this.panel_center.Controls.Add(this.label3);
            this.panel_center.Controls.Add(this.label1);
            this.panel_center.Size = new System.Drawing.Size(256, 194);
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Location = new System.Drawing.Point(1, 9);
            this.uitb_Remark.Size = new System.Drawing.Size(1, 23);
            this.uitb_Remark.Visible = false;
            // 
            // uIlb_describle
            // 
            this.uIlb_describle.AutoSize = false;
            this.uIlb_describle.Location = new System.Drawing.Point(5, 3);
            this.uIlb_describle.Size = new System.Drawing.Size(10, 17);
            this.uIlb_describle.Visible = false;
            // 
            // cb_Enable
            // 
            this.cb_Enable.Location = new System.Drawing.Point(7, 9);
            this.cb_Enable.Size = new System.Drawing.Size(49, 17);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(192, 6);
            this.btn_Cancel.Size = new System.Drawing.Size(57, 26);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(127, 6);
            this.btn_Save.Size = new System.Drawing.Size(57, 26);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(62, 6);
            this.btn_Run.Size = new System.Drawing.Size(57, 26);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(256, 32);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(4, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "发送内容:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "通讯选择:";
            // 
            // ui_PortSelect
            // 
            this.ui_PortSelect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ui_PortSelect.Location = new System.Drawing.Point(59, 9);
            this.ui_PortSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ui_PortSelect.MinimumSize = new System.Drawing.Size(63, 0);
            this.ui_PortSelect.Name = "ui_PortSelect";
            this.ui_PortSelect.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.ui_PortSelect.Radius = 2;
            this.ui_PortSelect.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.ui_PortSelect.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ui_PortSelect.Size = new System.Drawing.Size(189, 23);
            this.ui_PortSelect.StyleCustomMode = true;
            this.ui_PortSelect.TabIndex = 16;
            this.ui_PortSelect.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ui_PortSelect.Watermark = "发送端口";
            this.ui_PortSelect.SelectedIndexChanged += new System.EventHandler(this.ui_PortSelect_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(4, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "结束字符:";
            // 
            // ui_EndChar
            // 
            this.ui_EndChar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ui_EndChar.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ui_EndChar.Location = new System.Drawing.Point(59, 98);
            this.ui_EndChar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ui_EndChar.Maximum = 2147483647D;
            this.ui_EndChar.Minimum = -2147483648D;
            this.ui_EndChar.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_EndChar.Name = "ui_EndChar";
            this.ui_EndChar.Padding = new System.Windows.Forms.Padding(5);
            this.ui_EndChar.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.ui_EndChar.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ui_EndChar.Size = new System.Drawing.Size(189, 23);
            this.ui_EndChar.Style = Rex.UI.UIStyle.LightBlue;
            this.ui_EndChar.StyleCustomMode = true;
            this.ui_EndChar.TabIndex = 20;
            this.ui_EndChar.Text = "\\r\\n";
            this.ui_EndChar.Watermark = "默认为空";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(4, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "通讯备注:";
            // 
            // ui_Describle
            // 
            this.ui_Describle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ui_Describle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ui_Describle.Location = new System.Drawing.Point(59, 38);
            this.ui_Describle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ui_Describle.Maximum = 2147483647D;
            this.ui_Describle.Minimum = -2147483648D;
            this.ui_Describle.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_Describle.Name = "ui_Describle";
            this.ui_Describle.Padding = new System.Windows.Forms.Padding(5);
            this.ui_Describle.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.ui_Describle.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ui_Describle.Size = new System.Drawing.Size(189, 23);
            this.ui_Describle.Style = Rex.UI.UIStyle.LightBlue;
            this.ui_Describle.StyleCustomMode = true;
            this.ui_Describle.TabIndex = 22;
            this.ui_Describle.Watermark = "默认为空";
            this.ui_Describle.TextChanged += new System.EventHandler(this.ui_Describle_TextChanged);
            // 
            // ui_SendText
            // 
            this.ui_SendText.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ui_SendText.Location = new System.Drawing.Point(59, 68);
            this.ui_SendText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ui_SendText.MinimumSize = new System.Drawing.Size(100, 0);
            this.ui_SendText.Name = "ui_SendText";
            this.ui_SendText.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.ui_SendText.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ui_SendText.Size = new System.Drawing.Size(189, 24);
            this.ui_SendText.Style = Rex.UI.UIStyle.LightBlue;
            this.ui_SendText.StyleCustomMode = true;
            this.ui_SendText.TabIndex = 23;
            this.ui_SendText.Text = null;
            this.ui_SendText.BtnAdd += new Rex.UI.UILinkData.BtnAddHandle(this.ui_SendText_BtnAdd);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(4, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "字符说明:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(59, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "\"\\r\"    换行";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(59, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "\"\\n\"    回车";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(59, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "\"\\r\\n\"  回车换行";
            // 
            // SendDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(258, 268);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(260, 270);
            this.MinimumSize = new System.Drawing.Size(260, 270);
            this.Name = "SendDataForm";
            this.Load += new System.EventHandler(this.SendDataModForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Rex.UI.UILinkData ui_SendText;
        private Rex.UI.UITextBox ui_Describle;
        private System.Windows.Forms.Label label5;
        private Rex.UI.UITextBox ui_EndChar;
        private System.Windows.Forms.Label label4;
        private Rex.UI.UIComboBox ui_PortSelect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;

        #endregion

        //private System.Windows.Forms.GroupBox groupBox1;
        //private System.Windows.Forms.ComboBox comboBox1;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label4;
        //private System.Windows.Forms.TreeView treeView1;
        //private System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.Label label3;
    }
}