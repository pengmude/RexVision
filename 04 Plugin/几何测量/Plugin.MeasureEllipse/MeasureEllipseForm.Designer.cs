namespace Plugin.MeasEllipse
{
    partial class MeasEllipseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeasEllipseForm));
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_CurrentImg = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_PositionUnitID = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.num_MeasDis = new System.Windows.Forms.NumericUpDown();
            this.num_Threshold = new System.Windows.Forms.NumericUpDown();
            this.num_Length2 = new System.Windows.Forms.NumericUpDown();
            this.num_Length1 = new System.Windows.Forms.NumericUpDown();
            this.cb_筛选 = new System.Windows.Forms.ComboBox();
            this.cb_方向 = new System.Windows.Forms.ComboBox();
            this.cb_模式 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_Phi = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.nudRadius2 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nudRadius1 = new System.Windows.Forms.NumericUpDown();
            this.nudCenterY = new System.Windows.Forms.NumericUpDown();
            this.nudCenterX = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1 = new Rex.CTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uicb_Result = new System.Windows.Forms.CheckBox();
            this.uicb_Area = new System.Windows.Forms.CheckBox();
            this.uicb_Roi = new System.Windows.Forms.CheckBox();
            this.mWindow = new RexView.HWindow_Fit();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MeasDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Length2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Length1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Phi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCenterY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCenterX)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.mWindow);
            this.panel_center.Controls.Add(this.tabControl1);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Margin = new System.Windows.Forms.Padding(2);
            this.uitb_Remark.Size = new System.Drawing.Size(167, 23);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 35;
            this.label12.Text = "当前图像：";
            // 
            // cmb_CurrentImg
            // 
            this.cmb_CurrentImg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CurrentImg.FormattingEnabled = true;
            this.cmb_CurrentImg.Location = new System.Drawing.Point(85, 16);
            this.cmb_CurrentImg.Name = "cmb_CurrentImg";
            this.cmb_CurrentImg.Size = new System.Drawing.Size(82, 20);
            this.cmb_CurrentImg.TabIndex = 34;
            this.cmb_CurrentImg.SelectedIndexChanged += new System.EventHandler(this.cmb_CurrentImg_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_PositionUnitID);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cmb_CurrentImg);
            this.groupBox3.Controls.Add(this.num_MeasDis);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.num_Threshold);
            this.groupBox3.Controls.Add(this.num_Length2);
            this.groupBox3.Controls.Add(this.num_Length1);
            this.groupBox3.Controls.Add(this.cb_筛选);
            this.groupBox3.Controls.Add(this.cb_方向);
            this.groupBox3.Controls.Add(this.cb_模式);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 297);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // cmb_PositionUnitID
            // 
            this.cmb_PositionUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PositionUnitID.FormattingEnabled = true;
            this.cmb_PositionUnitID.Location = new System.Drawing.Point(85, 47);
            this.cmb_PositionUnitID.Name = "cmb_PositionUnitID";
            this.cmb_PositionUnitID.Size = new System.Drawing.Size(82, 20);
            this.cmb_PositionUnitID.TabIndex = 33;
            this.cmb_PositionUnitID.SelectedIndexChanged += new System.EventHandler(this.cmb_PositionUnitID_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 32;
            this.label11.Text = "参考位置：";
            // 
            // num_MeasDis
            // 
            this.num_MeasDis.Location = new System.Drawing.Point(86, 174);
            this.num_MeasDis.Margin = new System.Windows.Forms.Padding(2);
            this.num_MeasDis.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_MeasDis.Name = "num_MeasDis";
            this.num_MeasDis.Size = new System.Drawing.Size(80, 21);
            this.num_MeasDis.TabIndex = 35;
            this.num_MeasDis.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // num_Threshold
            // 
            this.num_Threshold.Location = new System.Drawing.Point(86, 142);
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
            this.num_Length2.Location = new System.Drawing.Point(86, 110);
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
            this.num_Length1.Location = new System.Drawing.Point(86, 78);
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
            // cb_筛选
            // 
            this.cb_筛选.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_筛选.FormattingEnabled = true;
            this.cb_筛选.Items.AddRange(new object[] {
            "第一点",
            "最末点",
            "所有点",
            "最强点"});
            this.cb_筛选.Location = new System.Drawing.Point(86, 268);
            this.cb_筛选.Name = "cb_筛选";
            this.cb_筛选.Size = new System.Drawing.Size(80, 20);
            this.cb_筛选.TabIndex = 31;
            // 
            // cb_方向
            // 
            this.cb_方向.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_方向.FormattingEnabled = true;
            this.cb_方向.Items.AddRange(new object[] {
            "默认值",
            "顺时针",
            "逆时针"});
            this.cb_方向.Location = new System.Drawing.Point(86, 237);
            this.cb_方向.Name = "cb_方向";
            this.cb_方向.Size = new System.Drawing.Size(80, 20);
            this.cb_方向.TabIndex = 29;
            // 
            // cb_模式
            // 
            this.cb_模式.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_模式.FormattingEnabled = true;
            this.cb_模式.Items.AddRange(new object[] {
            "由白到黑",
            "由黑到白",
            "所有",
            "规格一致"});
            this.cb_模式.Location = new System.Drawing.Point(86, 206);
            this.cb_模式.Name = "cb_模式";
            this.cb_模式.Size = new System.Drawing.Size(80, 20);
            this.cb_模式.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 30;
            this.label10.Text = "筛选：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = "方向：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "模式：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "间隔：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "阈值：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "高度：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "宽度：";
            // 
            // nud_Phi
            // 
            this.nud_Phi.DecimalPlaces = 3;
            this.nud_Phi.Location = new System.Drawing.Point(88, 420);
            this.nud_Phi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_Phi.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nud_Phi.Name = "nud_Phi";
            this.nud_Phi.Size = new System.Drawing.Size(82, 21);
            this.nud_Phi.TabIndex = 54;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(53, 423);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 53;
            this.label17.Text = "角度：";
            // 
            // nudRadius2
            // 
            this.nudRadius2.DecimalPlaces = 3;
            this.nudRadius2.Location = new System.Drawing.Point(88, 395);
            this.nudRadius2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRadius2.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudRadius2.Name = "nudRadius2";
            this.nudRadius2.Size = new System.Drawing.Size(82, 21);
            this.nudRadius2.TabIndex = 52;
            this.nudRadius2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 400);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 51;
            this.label14.Text = "短半径R(mm)：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 12);
            this.label13.TabIndex = 50;
            this.label13.Text = "椭圆心Y(mm)：";
            // 
            // nudRadius1
            // 
            this.nudRadius1.DecimalPlaces = 3;
            this.nudRadius1.Location = new System.Drawing.Point(88, 371);
            this.nudRadius1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRadius1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudRadius1.Name = "nudRadius1";
            this.nudRadius1.Size = new System.Drawing.Size(82, 21);
            this.nudRadius1.TabIndex = 49;
            this.nudRadius1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudCenterY
            // 
            this.nudCenterY.DecimalPlaces = 3;
            this.nudCenterY.Location = new System.Drawing.Point(88, 348);
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
            this.nudCenterY.TabIndex = 48;
            // 
            // nudCenterX
            // 
            this.nudCenterX.DecimalPlaces = 3;
            this.nudCenterX.Location = new System.Drawing.Point(88, 324);
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
            this.nudCenterX.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 376);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 12);
            this.label16.TabIndex = 46;
            this.label16.Text = "长半径R(mm)：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 12);
            this.label15.TabIndex = 45;
            this.label15.Text = "椭圆心X(mm)：";
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
            this.tabControl1.Size = new System.Drawing.Size(239, 474);
            this.tabControl1.TabIndex = 38;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nudCenterX);
            this.tabPage1.Controls.Add(this.nudCenterY);
            this.tabPage1.Controls.Add(this.nudRadius1);
            this.tabPage1.Controls.Add(this.nudRadius2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.nud_Phi);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(231, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uicb_Result);
            this.tabPage2.Controls.Add(this.uicb_Area);
            this.tabPage2.Controls.Add(this.uicb_Roi);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(231, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "显示设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uicb_Result
            // 
            this.uicb_Result.AutoSize = true;
            this.uicb_Result.Location = new System.Drawing.Point(12, 97);
            this.uicb_Result.Name = "uicb_Result";
            this.uicb_Result.Size = new System.Drawing.Size(96, 16);
            this.uicb_Result.TabIndex = 21;
            this.uicb_Result.Text = "是否显示结果";
            this.uicb_Result.UseVisualStyleBackColor = true;
            // 
            // uicb_Area
            // 
            this.uicb_Area.AutoSize = true;
            this.uicb_Area.Location = new System.Drawing.Point(12, 63);
            this.uicb_Area.Name = "uicb_Area";
            this.uicb_Area.Size = new System.Drawing.Size(120, 16);
            this.uicb_Area.TabIndex = 20;
            this.uicb_Area.Text = "是否显示查找范围";
            this.uicb_Area.UseVisualStyleBackColor = true;
            // 
            // uicb_Roi
            // 
            this.uicb_Roi.AutoSize = true;
            this.uicb_Roi.Location = new System.Drawing.Point(12, 32);
            this.uicb_Roi.Name = "uicb_Roi";
            this.uicb_Roi.Size = new System.Drawing.Size(90, 16);
            this.uicb_Roi.TabIndex = 19;
            this.uicb_Roi.Text = "是否显示ROI";
            this.uicb_Roi.UseVisualStyleBackColor = true;
            // 
            // mWindow
            // 
            this.mWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mWindow.BackColor = System.Drawing.Color.Transparent;
            this.mWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mWindow.ForeColor = System.Drawing.SystemColors.Control;
            this.mWindow.Image = null;
            this.mWindow.Location = new System.Drawing.Point(245, 0);
            this.mWindow.Name = "mWindow";
            this.mWindow.Size = new System.Drawing.Size(600, 473);
            this.mWindow.TabIndex = 39;
            // 
            // MeasEllipseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeasEllipseForm";
            this.Load += new System.EventHandler(this.ModForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MeasDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Length2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Length1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Phi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCenterY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCenterX)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        protected System.Windows.Forms.ComboBox cmb_CurrentImg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown num_MeasDis;
        private System.Windows.Forms.NumericUpDown num_Threshold;
        private System.Windows.Forms.NumericUpDown num_Length2;
        private System.Windows.Forms.NumericUpDown num_Length1;
        protected System.Windows.Forms.ComboBox cb_筛选;
        private System.Windows.Forms.Label label10;
        protected System.Windows.Forms.ComboBox cb_方向;
        private System.Windows.Forms.Label label9;
        protected System.Windows.Forms.ComboBox cb_模式;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.ComboBox cmb_PositionUnitID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nud_Phi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nudRadius2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudRadius1;
        private System.Windows.Forms.NumericUpDown nudCenterY;
        private System.Windows.Forms.NumericUpDown nudCenterX;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private Rex.CTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox uicb_Result;
        private System.Windows.Forms.CheckBox uicb_Area;
        private System.Windows.Forms.CheckBox uicb_Roi;
        private RexView.HWindow_Fit mWindow;
    }
}