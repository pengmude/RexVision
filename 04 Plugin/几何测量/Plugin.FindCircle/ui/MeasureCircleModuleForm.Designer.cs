namespace Plugin.MeasureCircle
{
    partial class MeasureCircleModuleForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.num_MeasureDis = new System.Windows.Forms.NumericUpDown();
            this.num_Threshold = new System.Windows.Forms.NumericUpDown();
            this.num_Length2 = new System.Windows.Forms.NumericUpDown();
            this.num_Length1 = new System.Windows.Forms.NumericUpDown();
            this.cb_Select = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_Direction = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_Transition = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_Color = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_CurrentImg = new System.Windows.Forms.ComboBox();
            this.chkCorrect = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_Paint = new System.Windows.Forms.Button();
            this.bt_draw = new System.Windows.Forms.Button();
            this.cmb_PositionUnitID = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nudRadus = new System.Windows.Forms.NumericUpDown();
            this.nudCenterY = new System.Windows.Forms.NumericUpDown();
            this.nudCenterX = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.show结果 = new System.Windows.Forms.CheckBox();
            this.show_范围 = new System.Windows.Forms.CheckBox();
            this.show_roi = new System.Windows.Forms.CheckBox();
            this.hWindow_Fit = new ShowControl.HWindow_Fit();
            this.panel_center.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MeasureDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Length2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Length1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCenterY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCenterX)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.tabControl1);
            this.panel_center.Controls.Add(this.hWindow_Fit);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.Size = new System.Drawing.Size(851, 476);
            // 
            // button_run
            // 
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // button_save
            // 
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // panel_bottom
            // 
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.num_MeasureDis);
            this.groupBox3.Controls.Add(this.num_Threshold);
            this.groupBox3.Controls.Add(this.num_Length2);
            this.groupBox3.Controls.Add(this.num_Length1);
            this.groupBox3.Controls.Add(this.cb_Select);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cb_Direction);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cb_Transition);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.bt_Color);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 325);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // num_MeasureDis
            // 
            this.num_MeasureDis.Location = new System.Drawing.Point(48, 176);
            this.num_MeasureDis.Margin = new System.Windows.Forms.Padding(2);
            this.num_MeasureDis.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_MeasureDis.Name = "num_MeasureDis";
            this.num_MeasureDis.Size = new System.Drawing.Size(80, 21);
            this.num_MeasureDis.TabIndex = 35;
            this.num_MeasureDis.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // num_Threshold
            // 
            this.num_Threshold.Location = new System.Drawing.Point(48, 137);
            this.num_Threshold.Margin = new System.Windows.Forms.Padding(2);
            this.num_Threshold.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Threshold.Name = "num_Threshold";
            this.num_Threshold.Size = new System.Drawing.Size(80, 21);
            this.num_Threshold.TabIndex = 34;
            this.num_Threshold.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // num_Length2
            // 
            this.num_Length2.Location = new System.Drawing.Point(48, 100);
            this.num_Length2.Margin = new System.Windows.Forms.Padding(2);
            this.num_Length2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Length2.Name = "num_Length2";
            this.num_Length2.Size = new System.Drawing.Size(80, 21);
            this.num_Length2.TabIndex = 33;
            this.num_Length2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // num_Length1
            // 
            this.num_Length1.Location = new System.Drawing.Point(48, 62);
            this.num_Length1.Margin = new System.Windows.Forms.Padding(2);
            this.num_Length1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Length1.Name = "num_Length1";
            this.num_Length1.Size = new System.Drawing.Size(80, 21);
            this.num_Length1.TabIndex = 32;
            this.num_Length1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // cb_Select
            // 
            this.cb_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Select.FormattingEnabled = true;
            this.cb_Select.Items.AddRange(new object[] {
            "First",
            "Last",
            "All",
            "Strongest"});
            this.cb_Select.Location = new System.Drawing.Point(48, 287);
            this.cb_Select.Name = "cb_Select";
            this.cb_Select.Size = new System.Drawing.Size(80, 20);
            this.cb_Select.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 30;
            this.label10.Text = "筛选：";
            // 
            // cb_Direction
            // 
            this.cb_Direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Direction.FormattingEnabled = true;
            this.cb_Direction.Items.AddRange(new object[] {
            "默认值",
            "顺时针",
            "逆时针"});
            this.cb_Direction.Location = new System.Drawing.Point(48, 246);
            this.cb_Direction.Name = "cb_Direction";
            this.cb_Direction.Size = new System.Drawing.Size(80, 20);
            this.cb_Direction.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = "方向：";
            // 
            // cb_Transition
            // 
            this.cb_Transition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Transition.FormattingEnabled = true;
            this.cb_Transition.Items.AddRange(new object[] {
            "由白到黑",
            "由黑到白",
            "所有",
            "规格一致"});
            this.cb_Transition.Location = new System.Drawing.Point(48, 210);
            this.cb_Transition.Name = "cb_Transition";
            this.cb_Transition.Size = new System.Drawing.Size(80, 20);
            this.cb_Transition.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "模式：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "间隔：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "阈值：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "高度：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "宽度：";
            // 
            // bt_Color
            // 
            this.bt_Color.BackColor = System.Drawing.Color.Red;
            this.bt_Color.ForeColor = System.Drawing.Color.White;
            this.bt_Color.Location = new System.Drawing.Point(48, 20);
            this.bt_Color.Name = "bt_Color";
            this.bt_Color.Size = new System.Drawing.Size(80, 25);
            this.bt_Color.TabIndex = 13;
            this.bt_Color.UseVisualStyleBackColor = false;
            this.bt_Color.Click += new System.EventHandler(this.bt_Color_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "颜色：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_CurrentImg);
            this.groupBox2.Controls.Add(this.chkCorrect);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.bt_Paint);
            this.groupBox2.Controls.Add(this.bt_draw);
            this.groupBox2.Controls.Add(this.cmb_PositionUnitID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(155, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 325);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // cmb_CurrentImg
            // 
            this.cmb_CurrentImg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CurrentImg.FormattingEnabled = true;
            this.cmb_CurrentImg.Location = new System.Drawing.Point(69, 133);
            this.cmb_CurrentImg.Name = "cmb_CurrentImg";
            this.cmb_CurrentImg.Size = new System.Drawing.Size(82, 20);
            this.cmb_CurrentImg.TabIndex = 32;
            this.cmb_CurrentImg.SelectedIndexChanged += new System.EventHandler(this.cmb_CurrentImg_SelectedIndexChanged);
            // 
            // chkCorrect
            // 
            this.chkCorrect.AutoSize = true;
            this.chkCorrect.Location = new System.Drawing.Point(57, 287);
            this.chkCorrect.Margin = new System.Windows.Forms.Padding(2);
            this.chkCorrect.Name = "chkCorrect";
            this.chkCorrect.Size = new System.Drawing.Size(96, 16);
            this.chkCorrect.TabIndex = 44;
            this.chkCorrect.Text = "涂抹启用补正";
            this.chkCorrect.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 33;
            this.label12.Text = "当前图像：";
            // 
            // bt_Paint
            // 
            this.bt_Paint.Location = new System.Drawing.Point(69, 247);
            this.bt_Paint.Name = "bt_Paint";
            this.bt_Paint.Size = new System.Drawing.Size(84, 23);
            this.bt_Paint.TabIndex = 43;
            this.bt_Paint.Text = "涂抹绘制";
            this.bt_Paint.UseVisualStyleBackColor = true;
            this.bt_Paint.Click += new System.EventHandler(this.bt_Paint_Click);
            // 
            // bt_draw
            // 
            this.bt_draw.Location = new System.Drawing.Point(69, 210);
            this.bt_draw.Name = "bt_draw";
            this.bt_draw.Size = new System.Drawing.Size(84, 23);
            this.bt_draw.TabIndex = 37;
            this.bt_draw.Text = "绘制";
            this.bt_draw.UseVisualStyleBackColor = true;
            this.bt_draw.Click += new System.EventHandler(this.bt_draw_Click);
            // 
            // cmb_PositionUnitID
            // 
            this.cmb_PositionUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PositionUnitID.FormattingEnabled = true;
            this.cmb_PositionUnitID.Location = new System.Drawing.Point(69, 174);
            this.cmb_PositionUnitID.Name = "cmb_PositionUnitID";
            this.cmb_PositionUnitID.Size = new System.Drawing.Size(82, 20);
            this.cmb_PositionUnitID.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 32;
            this.label11.Text = "参考位置：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(146, 384);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 12);
            this.label13.TabIndex = 29;
            this.label13.Text = "圆心Y（mm）：";
            // 
            // nudRadus
            // 
            this.nudRadus.DecimalPlaces = 3;
            this.nudRadus.Location = new System.Drawing.Point(224, 408);
            this.nudRadus.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRadus.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudRadus.Name = "nudRadus";
            this.nudRadus.Size = new System.Drawing.Size(82, 21);
            this.nudRadus.TabIndex = 28;
            this.nudRadus.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudCenterY
            // 
            this.nudCenterY.DecimalPlaces = 3;
            this.nudCenterY.Location = new System.Drawing.Point(224, 379);
            this.nudCenterY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCenterY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudCenterY.Name = "nudCenterY";
            this.nudCenterY.Size = new System.Drawing.Size(82, 21);
            this.nudCenterY.TabIndex = 27;
            // 
            // nudCenterX
            // 
            this.nudCenterX.DecimalPlaces = 3;
            this.nudCenterX.Location = new System.Drawing.Point(224, 350);
            this.nudCenterX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCenterX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudCenterX.Name = "nudCenterX";
            this.nudCenterX.Size = new System.Drawing.Size(82, 21);
            this.nudCenterX.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(145, 413);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 12);
            this.label16.TabIndex = 25;
            this.label16.Text = "半径R（mm）：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(145, 352);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 12);
            this.label15.TabIndex = 24;
            this.label15.Text = "圆心X（mm）：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(335, 476);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nudCenterX);
            this.tabPage1.Controls.Add(this.nudRadus);
            this.tabPage1.Controls.Add(this.nudCenterY);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(327, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.show结果);
            this.tabPage2.Controls.Add(this.show_范围);
            this.tabPage2.Controls.Add(this.show_roi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(327, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "显示设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // show结果
            // 
            this.show结果.AutoSize = true;
            this.show结果.Location = new System.Drawing.Point(76, 142);
            this.show结果.Name = "show结果";
            this.show结果.Size = new System.Drawing.Size(96, 16);
            this.show结果.TabIndex = 18;
            this.show结果.Text = "是否显示结果";
            this.show结果.UseVisualStyleBackColor = true;
            this.show结果.CheckedChanged += new System.EventHandler(this.show结果_CheckedChanged);
            // 
            // show_范围
            // 
            this.show_范围.AutoSize = true;
            this.show_范围.Location = new System.Drawing.Point(76, 108);
            this.show_范围.Name = "show_范围";
            this.show_范围.Size = new System.Drawing.Size(120, 16);
            this.show_范围.TabIndex = 17;
            this.show_范围.Text = "是否显示查找范围";
            this.show_范围.UseVisualStyleBackColor = true;
            this.show_范围.CheckedChanged += new System.EventHandler(this.show_范围_CheckedChanged);
            // 
            // show_roi
            // 
            this.show_roi.AutoSize = true;
            this.show_roi.Location = new System.Drawing.Point(76, 77);
            this.show_roi.Name = "show_roi";
            this.show_roi.Size = new System.Drawing.Size(90, 16);
            this.show_roi.TabIndex = 16;
            this.show_roi.Text = "是否显示ROI";
            this.show_roi.UseVisualStyleBackColor = true;
            this.show_roi.CheckedChanged += new System.EventHandler(this.show_roi_CheckedChanged);
            // 
            // hWindow_Fit
            // 
            this.hWindow_Fit.BackColor = System.Drawing.Color.Transparent;
            this.hWindow_Fit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hWindow_Fit.Dock = System.Windows.Forms.DockStyle.Right;
            this.hWindow_Fit.ForeColor = System.Drawing.SystemColors.Control;
            this.hWindow_Fit.Image = null;
            this.hWindow_Fit.Location = new System.Drawing.Point(359, 0);
            this.hWindow_Fit.Name = "hWindow_Fit";
            this.hWindow_Fit.Size = new System.Drawing.Size(492, 476);
            this.hWindow_Fit.TabIndex = 34;
            // 
            // MeasureCircleModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeasureCircleModuleForm";
            this.Load += new System.EventHandler(this.ModuleForm_Load);
            this.panel_center.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MeasureDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Length2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Length1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCenterY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCenterX)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown num_MeasureDis;
        private System.Windows.Forms.NumericUpDown num_Threshold;
        private System.Windows.Forms.NumericUpDown num_Length2;
        private System.Windows.Forms.NumericUpDown num_Length1;
        protected System.Windows.Forms.ComboBox cb_Select;
        private System.Windows.Forms.Label label10;
        protected System.Windows.Forms.ComboBox cb_Direction;
        private System.Windows.Forms.Label label9;
        protected System.Windows.Forms.ComboBox cb_Transition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Button bt_Color;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkCorrect;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bt_Paint;
        private System.Windows.Forms.NumericUpDown nudRadus;
        protected System.Windows.Forms.Button bt_draw;
        private System.Windows.Forms.NumericUpDown nudCenterY;
        protected System.Windows.Forms.ComboBox cmb_PositionUnitID;
        private System.Windows.Forms.NumericUpDown nudCenterX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        protected System.Windows.Forms.ComboBox cmb_CurrentImg;
        private ShowControl.HWindow_Fit hWindow_Fit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox show结果;
        private System.Windows.Forms.CheckBox show_范围;
        private System.Windows.Forms.CheckBox show_roi;
    }
}