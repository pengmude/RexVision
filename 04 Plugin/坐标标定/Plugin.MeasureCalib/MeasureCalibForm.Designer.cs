namespace Plugin.MeasCalib
{
    partial class MeasCalibForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeasCalibForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lRMS = new System.Windows.Forms.Label();
            this.lScaleY = new System.Windows.Forms.Label();
            this.lScaleX = new System.Windows.Forms.Label();
            this.bt_disableRegion = new System.Windows.Forms.Button();
            this.bt_ROI = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_BoardType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mWindow = new RexView.HWindow_Fit();
            this.cmb_registerImg = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new Rex.CTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.tabControl1);
            this.panel_center.Controls.Add(this.mWindow);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lRMS);
            this.groupBox1.Controls.Add(this.lScaleY);
            this.groupBox1.Controls.Add(this.lScaleX);
            this.groupBox1.Location = new System.Drawing.Point(6, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 107);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "标定结果";
            // 
            // lRMS
            // 
            this.lRMS.AutoSize = true;
            this.lRMS.Location = new System.Drawing.Point(67, 80);
            this.lRMS.Name = "lRMS";
            this.lRMS.Size = new System.Drawing.Size(29, 12);
            this.lRMS.TabIndex = 2;
            this.lRMS.Text = "RMS=";
            // 
            // lScaleY
            // 
            this.lScaleY.AutoSize = true;
            this.lScaleY.Location = new System.Drawing.Point(79, 56);
            this.lScaleY.Name = "lScaleY";
            this.lScaleY.Size = new System.Drawing.Size(17, 12);
            this.lScaleY.TabIndex = 1;
            this.lScaleY.Text = "Y=";
            // 
            // lScaleX
            // 
            this.lScaleX.AutoSize = true;
            this.lScaleX.Location = new System.Drawing.Point(79, 28);
            this.lScaleX.Name = "lScaleX";
            this.lScaleX.Size = new System.Drawing.Size(17, 12);
            this.lScaleX.TabIndex = 0;
            this.lScaleX.Text = "X=";
            // 
            // bt_disableRegion
            // 
            this.bt_disableRegion.Location = new System.Drawing.Point(83, 307);
            this.bt_disableRegion.Name = "bt_disableRegion";
            this.bt_disableRegion.Size = new System.Drawing.Size(81, 25);
            this.bt_disableRegion.TabIndex = 19;
            this.bt_disableRegion.Text = "屏蔽区域";
            this.bt_disableRegion.UseVisualStyleBackColor = true;
            this.bt_disableRegion.Click += new System.EventHandler(this.bt_ROI_Click);
            // 
            // bt_ROI
            // 
            this.bt_ROI.Location = new System.Drawing.Point(170, 307);
            this.bt_ROI.Name = "bt_ROI";
            this.bt_ROI.Size = new System.Drawing.Size(81, 25);
            this.bt_ROI.TabIndex = 18;
            this.bt_ROI.Text = "兴趣区域";
            this.bt_ROI.UseVisualStyleBackColor = true;
            this.bt_ROI.Click += new System.EventHandler(this.bt_ROI_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(170, 261);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(81, 21);
            this.numericUpDown.TabIndex = 17;
            this.numericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "物理间距(mm)：";
            // 
            // cmb_BoardType
            // 
            this.cmb_BoardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_BoardType.FormattingEnabled = true;
            this.cmb_BoardType.Items.AddRange(new object[] {
            "孔板",
            "棋盘格"});
            this.cmb_BoardType.Location = new System.Drawing.Point(170, 222);
            this.cmb_BoardType.Name = "cmb_BoardType";
            this.cmb_BoardType.Size = new System.Drawing.Size(81, 20);
            this.cmb_BoardType.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "标定板类型：";
            // 
            // mWindow
            // 
            this.mWindow.AutoScroll = true;
            this.mWindow.BackColor = System.Drawing.Color.Transparent;
            this.mWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.mWindow.ForeColor = System.Drawing.SystemColors.Control;
            this.mWindow.Image = null;
            this.mWindow.Location = new System.Drawing.Point(348, 1);
            this.mWindow.Name = "mWindow";
            this.mWindow.Size = new System.Drawing.Size(497, 474);
            this.mWindow.TabIndex = 21;
            // 
            // cmb_registerImg
            // 
            this.cmb_registerImg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_registerImg.FormattingEnabled = true;
            this.cmb_registerImg.Location = new System.Drawing.Point(170, 179);
            this.cmb_registerImg.Name = "cmb_registerImg";
            this.cmb_registerImg.Size = new System.Drawing.Size(81, 20);
            this.cmb_registerImg.TabIndex = 34;
            this.cmb_registerImg.SelectedIndexChanged += new System.EventHandler(this.cmb_registerImg_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "需要标定的图像：";
            // 
            // tabControl1
            // 
            this.tabControl1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.tabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.tabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(331, 474);
            this.tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmb_registerImg);
            this.tabPage1.Controls.Add(this.bt_ROI);
            this.tabPage1.Controls.Add(this.numericUpDown);
            this.tabPage1.Controls.Add(this.cmb_BoardType);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.bt_disableRegion);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(323, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 25);
            this.button2.TabIndex = 39;
            this.button2.Text = "显示标定图像";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 25);
            this.button1.TabIndex = 38;
            this.button1.Text = "更新标定图像";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(83, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 44);
            this.button3.TabIndex = 37;
            this.button3.Text = "标定";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 14);
            this.label1.TabIndex = 36;
            this.label1.Text = "注：不允许孤立点";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(323, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "辅助设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MeasCalibForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeasCalibForm";
            this.Load += new System.EventHandler(this.ModForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lScaleY;
        private System.Windows.Forms.Label lScaleX;
        private System.Windows.Forms.Button bt_disableRegion;
        private System.Windows.Forms.Button bt_ROI;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_BoardType;
        private System.Windows.Forms.Label label3;
        private RexView.HWindow_Fit mWindow;
        protected System.Windows.Forms.ComboBox cmb_registerImg;
        private System.Windows.Forms.Label label5;
        private Rex.CTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lRMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}