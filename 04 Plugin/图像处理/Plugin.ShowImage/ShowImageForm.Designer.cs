namespace Plugin.ShowImage
{
    partial class ShowImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowImageForm));
            this.mWindow = new RexView.HWindow_Fit();
            this.timer1 = new System.Windows.Forms.Timer();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Screen = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new Rex.CTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmb_CurrentImgName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.mWindow);
            this.panel_center.Controls.Add(this.tabControl1);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(740, 5);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(642, 5);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(543, 5);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // mWindow
            // 
            this.mWindow.BackColor = System.Drawing.Color.Transparent;
            this.mWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.mWindow.ForeColor = System.Drawing.SystemColors.Control;
            this.mWindow.Image = null;
            this.mWindow.Location = new System.Drawing.Point(305, 1);
            this.mWindow.Name = "mWindow";
            this.mWindow.Size = new System.Drawing.Size(540, 474);
            this.mWindow.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "屏幕编号：";
            // 
            // cmb_Screen
            // 
            this.cmb_Screen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Screen.FormattingEnabled = true;
            this.cmb_Screen.Items.AddRange(new object[] {
            "无",
            "1号屏显示",
            "2号屏显示",
            "3号屏显示",
            "4号屏显示",
            "5号屏显示",
            "6号屏显示",
            "7号屏显示",
            "8号屏显示",
            "9号屏显示"});
            this.cmb_Screen.Location = new System.Drawing.Point(74, 68);
            this.cmb_Screen.Name = "cmb_Screen";
            this.cmb_Screen.Size = new System.Drawing.Size(154, 20);
            this.cmb_Screen.TabIndex = 36;
            this.cmb_Screen.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.tabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.tabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 471);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmb_CurrentImgName);
            this.tabPage1.Controls.Add(this.cmb_Screen);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(280, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmb_CurrentImgName
            // 
            this.cmb_CurrentImgName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CurrentImgName.FormattingEnabled = true;
            this.cmb_CurrentImgName.Location = new System.Drawing.Point(74, 32);
            this.cmb_CurrentImgName.Name = "cmb_CurrentImgName";
            this.cmb_CurrentImgName.Size = new System.Drawing.Size(154, 20);
            this.cmb_CurrentImgName.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "图像列表：";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(280, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "辅助设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ShowImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowImageForm";
            this.Load += new System.EventHandler(this.ShowImageForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RexView.HWindow_Fit mWindow;
        private System.Windows.Forms.Timer timer1;
        //private System.Windows.Forms.Button button1;
        private Rex.CTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.ComboBox cmb_Screen;
        protected System.Windows.Forms.ComboBox cmb_CurrentImgName;
        private System.Windows.Forms.Label label1;
    }
}