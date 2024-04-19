namespace Plugin.MeasureLine
{
    partial class MeasureLineModuleForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_CurrentImg = new System.Windows.Forms.ComboBox();
            this.cmb_PositionUnitID = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkCorrect = new System.Windows.Forms.CheckBox();
            this.bt_Paint = new System.Windows.Forms.Button();
            this.bt_draw = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_MeasureDis = new System.Windows.Forms.NumericUpDown();
            this.bt_Color = new System.Windows.Forms.Button();
            this.num_Threshold = new System.Windows.Forms.NumericUpDown();
            this.num_Length2 = new System.Windows.Forms.NumericUpDown();
            this.num_Length1 = new System.Windows.Forms.NumericUpDown();
            this.cb_Select = new System.Windows.Forms.ComboBox();
            this.cb_Direction = new System.Windows.Forms.ComboBox();
            this.cb_Transition = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nud_EndY = new System.Windows.Forms.NumericUpDown();
            this.nud_EndX = new System.Windows.Forms.NumericUpDown();
            this.nud_StartY = new System.Windows.Forms.NumericUpDown();
            this.nudStartX = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.show结果 = new System.Windows.Forms.CheckBox();
            this.show_范围 = new System.Windows.Forms.CheckBox();
            this.show_roi = new System.Windows.Forms.CheckBox();
            this.hWindow_Fit1 = new ShowControl.HWindow_Fit();
            this.panel_center.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).BeginInit();
            //this.titlepanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MeasureDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Length2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Length1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_EndY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_EndX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_StartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.hWindow_Fit1);
            this.panel_center.Controls.Add(this.tabControl1);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(331, 513);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(323, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_CurrentImg);
            this.groupBox2.Controls.Add(this.cmb_PositionUnitID);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.chkCorrect);
            this.groupBox2.Controls.Add(this.bt_Paint);
            this.groupBox2.Controls.Add(this.bt_draw);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(151, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 306);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            // 
            // cmb_CurrentImg
            // 
            this.cmb_CurrentImg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CurrentImg.FormattingEnabled = true;
            this.cmb_CurrentImg.Location = new System.Drawing.Point(68, 144);
            this.cmb_CurrentImg.Name = "cmb_CurrentImg";
            this.cmb_CurrentImg.Size = new System.Drawing.Size(82, 20);
            this.cmb_CurrentImg.TabIndex = 36;
            this.cmb_CurrentImg.SelectedIndexChanged += new System.EventHandler(this.cmb_CurrentImg_SelectedIndexChanged);
            // 
            // cmb_PositionUnitID
            // 
            this.cmb_PositionUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PositionUnitID.FormattingEnabled = true;
            this.cmb_PositionUnitID.Location = new System.Drawing.Point(68, 176);
            this.cmb_PositionUnitID.Name = "cmb_PositionUnitID";
            this.cmb_PositionUnitID.Size = new System.Drawing.Size(82, 20);
            this.cmb_PositionUnitID.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 37;
            this.label12.Text = "当前图像：";
            // 
            // chkCorrect
            // 
            this.chkCorrect.AutoSize = true;
            this.chkCorrect.Location = new System.Drawing.Point(56, 279);
            this.chkCorrect.Margin = new System.Windows.Forms.Padding(2);
            this.chkCorrect.Name = "chkCorrect";
            this.chkCorrect.Size = new System.Drawing.Size(96, 16);
            this.chkCorrect.TabIndex = 49;
            this.chkCorrect.Text = "涂抹启用补正";
            this.chkCorrect.UseVisualStyleBackColor = true;
            // 
            // bt_Paint
            // 
            this.bt_Paint.Location = new System.Drawing.Point(68, 241);
            this.bt_Paint.Name = "bt_Paint";
            this.bt_Paint.Size = new System.Drawing.Size(82, 23);
            this.bt_Paint.TabIndex = 48;
            this.bt_Paint.Text = "涂抹绘制";
            this.bt_Paint.UseVisualStyleBackColor = true;
            this.bt_Paint.Click += new System.EventHandler(this.bt_Paint_Click);
            // 
            // bt_draw
            // 
            this.bt_draw.Location = new System.Drawing.Point(68, 208);
            this.bt_draw.Name = "bt_draw";
            this.bt_draw.Size = new System.Drawing.Size(82, 23);
            this.bt_draw.TabIndex = 47;
            this.bt_draw.Text = "绘制";
            this.bt_draw.UseVisualStyleBackColor = true;
            this.bt_draw.Click += new System.EventHandler(this.bt_draw_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 45;
            this.label11.Text = "参考位置：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_MeasureDis);
            this.groupBox1.Controls.Add(this.bt_Color);
            this.groupBox1.Controls.Add(this.num_Threshold);
            this.groupBox1.Controls.Add(this.num_Length2);
            this.groupBox1.Controls.Add(this.num_Length1);
            this.groupBox1.Controls.Add(this.cb_Select);
            this.groupBox1.Controls.Add(this.cb_Direction);
            this.groupBox1.Controls.Add(this.cb_Transition);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 306);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // num_MeasureDis
            // 
            this.num_MeasureDis.Location = new System.Drawing.Point(47, 177);
            this.num_MeasureDis.Margin = new System.Windows.Forms.Padding(2);
            this.num_MeasureDis.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_MeasureDis.Name = "num_MeasureDis";
            this.num_MeasureDis.Size = new System.Drawing.Size(75, 21);
            this.num_MeasureDis.TabIndex = 51;
            this.num_MeasureDis.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // bt_Color
            // 
            this.bt_Color.BackColor = System.Drawing.Color.Red;
            this.bt_Color.ForeColor = System.Drawing.Color.White;
            this.bt_Color.Location = new System.Drawing.Point(45, 33);
            this.bt_Color.Name = "bt_Color";
            this.bt_Color.Size = new System.Drawing.Size(80, 29);
            this.bt_Color.TabIndex = 37;
            this.bt_Color.UseVisualStyleBackColor = false;
            // 
            // num_Threshold
            // 
            this.num_Threshold.Location = new System.Drawing.Point(47, 143);
            this.num_Threshold.Margin = new System.Windows.Forms.Padding(2);
            this.num_Threshold.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Threshold.Name = "num_Threshold";
            this.num_Threshold.Size = new System.Drawing.Size(75, 21);
            this.num_Threshold.TabIndex = 50;
            this.num_Threshold.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // num_Length2
            // 
            this.num_Length2.Location = new System.Drawing.Point(47, 109);
            this.num_Length2.Margin = new System.Windows.Forms.Padding(2);
            this.num_Length2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Length2.Name = "num_Length2";
            this.num_Length2.Size = new System.Drawing.Size(75, 21);
            this.num_Length2.TabIndex = 49;
            this.num_Length2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // num_Length1
            // 
            this.num_Length1.Location = new System.Drawing.Point(47, 75);
            this.num_Length1.Margin = new System.Windows.Forms.Padding(2);
            this.num_Length1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Length1.Name = "num_Length1";
            this.num_Length1.Size = new System.Drawing.Size(75, 21);
            this.num_Length1.TabIndex = 48;
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
            this.cb_Select.Location = new System.Drawing.Point(47, 277);
            this.cb_Select.Name = "cb_Select";
            this.cb_Select.Size = new System.Drawing.Size(75, 20);
            this.cb_Select.TabIndex = 47;
            // 
            // cb_Direction
            // 
            this.cb_Direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Direction.FormattingEnabled = true;
            this.cb_Direction.Items.AddRange(new object[] {
            "默认值",
            "顺时针",
            "逆时针"});
            this.cb_Direction.Location = new System.Drawing.Point(47, 244);
            this.cb_Direction.Name = "cb_Direction";
            this.cb_Direction.Size = new System.Drawing.Size(75, 20);
            this.cb_Direction.TabIndex = 45;
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
            this.cb_Transition.Location = new System.Drawing.Point(47, 211);
            this.cb_Transition.Name = "cb_Transition";
            this.cb_Transition.Size = new System.Drawing.Size(75, 20);
            this.cb_Transition.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 36;
            this.label4.Text = "颜色：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 38;
            this.label7.Text = "宽度：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 39;
            this.label6.Text = "高度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 40;
            this.label3.Text = "阈值：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "间隔：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 46;
            this.label10.Text = "筛选：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 42;
            this.label8.Text = "模式：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 44;
            this.label9.Text = "方向：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nud_EndY);
            this.groupBox3.Controls.Add(this.nud_EndX);
            this.groupBox3.Controls.Add(this.nud_StartY);
            this.groupBox3.Controls.Add(this.nudStartX);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(7, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 124);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "直线信息";
            // 
            // nud_EndY
            // 
            this.nud_EndY.DecimalPlaces = 3;
            this.nud_EndY.Location = new System.Drawing.Point(144, 95);
            this.nud_EndY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_EndY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nud_EndY.Name = "nud_EndY";
            this.nud_EndY.Size = new System.Drawing.Size(88, 21);
            this.nud_EndY.TabIndex = 23;
            this.nud_EndY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //this.nud_EndY.ValueChanged += new System.EventHandler(this.nud_EndY_ValueChanged);
            // 
            // nud_EndX
            // 
            this.nud_EndX.DecimalPlaces = 3;
            this.nud_EndX.Location = new System.Drawing.Point(144, 71);
            this.nud_EndX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_EndX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nud_EndX.Name = "nud_EndX";
            this.nud_EndX.Size = new System.Drawing.Size(88, 21);
            this.nud_EndX.TabIndex = 22;
            this.nud_EndX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_StartY
            // 
            this.nud_StartY.DecimalPlaces = 3;
            this.nud_StartY.Location = new System.Drawing.Point(144, 47);
            this.nud_StartY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_StartY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nud_StartY.Name = "nud_StartY";
            this.nud_StartY.Size = new System.Drawing.Size(88, 21);
            this.nud_StartY.TabIndex = 21;
            this.nud_StartY.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            //this.nud_StartY.ValueChanged += new System.EventHandler(this.nud_StartY_ValueChanged);
            // 
            // nudStartX
            // 
            this.nudStartX.DecimalPlaces = 3;
            this.nudStartX.Location = new System.Drawing.Point(144, 23);
            this.nudStartX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStartX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudStartX.Name = "nudStartX";
            this.nudStartX.Size = new System.Drawing.Size(88, 21);
            this.nudStartX.TabIndex = 20;
            this.nudStartX.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            //this.nudStartX.ValueChanged += new System.EventHandler(this.nudStartX_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(79, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "终点Y(mm)：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "起点Y(mm)：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(79, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 12);
            this.label16.TabIndex = 19;
            this.label16.Text = "终点X(mm)：";
            //this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(79, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 12);
            this.label15.TabIndex = 18;
            this.label15.Text = "起点X(mm)：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.show结果);
            this.tabPage2.Controls.Add(this.show_范围);
            this.tabPage2.Controls.Add(this.show_roi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(323, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "显示设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // show结果
            // 
            this.show结果.AutoSize = true;
            this.show结果.Location = new System.Drawing.Point(76, 111);
            this.show结果.Name = "show结果";
            this.show结果.Size = new System.Drawing.Size(96, 16);
            this.show结果.TabIndex = 24;
            this.show结果.Text = "是否显示结果";
            this.show结果.UseVisualStyleBackColor = true;
            this.show结果.CheckedChanged += new System.EventHandler(this.show结果_CheckedChanged);
            // 
            // show_范围
            // 
            this.show_范围.AutoSize = true;
            this.show_范围.Location = new System.Drawing.Point(76, 77);
            this.show_范围.Name = "show_范围";
            this.show_范围.Size = new System.Drawing.Size(120, 16);
            this.show_范围.TabIndex = 23;
            this.show_范围.Text = "是否显示查找范围";
            this.show_范围.UseVisualStyleBackColor = true;
            this.show_范围.CheckedChanged += new System.EventHandler(this.show_范围_CheckedChanged_1);
            // 
            // show_roi
            // 
            this.show_roi.AutoSize = true;
            this.show_roi.Location = new System.Drawing.Point(76, 46);
            this.show_roi.Name = "show_roi";
            this.show_roi.Size = new System.Drawing.Size(90, 16);
            this.show_roi.TabIndex = 22;
            this.show_roi.Text = "是否显示ROI";
            this.show_roi.UseVisualStyleBackColor = true;
            this.show_roi.CheckedChanged += new System.EventHandler(this.show_roi_CheckedChanged_1);
            // 
            // hWindow_Fit1
            // 
            this.hWindow_Fit1.BackColor = System.Drawing.Color.Transparent;
            this.hWindow_Fit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hWindow_Fit1.Dock = System.Windows.Forms.DockStyle.Right;
            this.hWindow_Fit1.ForeColor = System.Drawing.SystemColors.Control;
            this.hWindow_Fit1.Image = null;
            this.hWindow_Fit1.Location = new System.Drawing.Point(351, 0);
            this.hWindow_Fit1.Name = "hWindow_Fit1";
            this.hWindow_Fit1.Size = new System.Drawing.Size(497, 513);
            this.hWindow_Fit1.TabIndex = 7;
            // 
            // MeasureLineModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeasureLineModuleForm";
            this.Load += new System.EventHandler(this.MeasureLineModuleForm_Load);
            this.panel_center.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).EndInit();
            //this.titlepanel.ResumeLayout(false);
            //this.titlepanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MeasureDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Length2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Length1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_EndY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_EndX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_StartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private ShowControl.HWindow_Fit hWindow_Fit1;
        private System.Windows.Forms.Label label12;
        protected System.Windows.Forms.ComboBox cmb_CurrentImg;
        private System.Windows.Forms.CheckBox show结果;
        private System.Windows.Forms.CheckBox show_范围;
        private System.Windows.Forms.CheckBox show_roi;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nud_EndY;
        private System.Windows.Forms.NumericUpDown nud_EndX;
        private System.Windows.Forms.NumericUpDown nud_StartY;
        private System.Windows.Forms.NumericUpDown nudStartX;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkCorrect;
        private System.Windows.Forms.Button bt_Paint;
        protected System.Windows.Forms.Button bt_draw;
        protected System.Windows.Forms.ComboBox cmb_PositionUnitID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
    }
}