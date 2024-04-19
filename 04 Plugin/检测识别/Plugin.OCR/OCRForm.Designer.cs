namespace Plugin.OCR
{
    partial class OCRForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OCRForm));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_Color1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_PositionUnitID = new System.Windows.Forms.ComboBox();
            this.cmb_Shape1 = new System.Windows.Forms.ComboBox();
            this.chkCorrect = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_Paint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Draw1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_CurrentImg = new System.Windows.Forms.ComboBox();
            this.mWindow = new RexView.HWindow_Fit();
            this.cbxFileName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxOcrSelect = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new Rex.CTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonFragments = new System.Windows.Forms.RadioButton();
            this.radioButtonDotPrint = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonBoth = new System.Windows.Forms.RadioButton();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.radioButtonWhite = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtLineSeparators = new System.Windows.Forms.TextBox();
            this.txtLineStructure = new System.Windows.Forms.TextBox();
            this.UpDownMinStrokeWidth = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.UpDownMaxStrokeWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.UpDownMinCharWidth = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.UpDownMaxCharWidth = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.UpDownMinCharHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.UpDownMaxCharHeight = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.UpDownMinContrast = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMinStrokeWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMaxStrokeWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMinCharWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMaxCharWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMinCharHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMaxCharHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMinContrast)).BeginInit();
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
            this.panel_center.MaximumSize = new System.Drawing.Size(848, 473);
            this.panel_center.MinimumSize = new System.Drawing.Size(848, 473);
            this.panel_center.Size = new System.Drawing.Size(848, 473);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_Color1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmb_PositionUnitID);
            this.groupBox3.Controls.Add(this.cmb_Shape1);
            this.groupBox3.Controls.Add(this.chkCorrect);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.bt_Paint);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.bt_Draw1);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cmb_CurrentImg);
            this.groupBox3.Location = new System.Drawing.Point(7, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 130);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "处理区域";
            // 
            // bt_Color1
            // 
            this.bt_Color1.BackColor = System.Drawing.Color.Lime;
            this.bt_Color1.ForeColor = System.Drawing.Color.White;
            this.bt_Color1.Location = new System.Drawing.Point(76, 87);
            this.bt_Color1.Name = "bt_Color1";
            this.bt_Color1.Size = new System.Drawing.Size(92, 20);
            this.bt_Color1.TabIndex = 25;
            this.bt_Color1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 50;
            this.label6.Text = "画笔颜色：";
            // 
            // cmb_PositionUnitID
            // 
            this.cmb_PositionUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PositionUnitID.FormattingEnabled = true;
            this.cmb_PositionUnitID.Location = new System.Drawing.Point(76, 34);
            this.cmb_PositionUnitID.Name = "cmb_PositionUnitID";
            this.cmb_PositionUnitID.Size = new System.Drawing.Size(92, 20);
            this.cmb_PositionUnitID.TabIndex = 46;
            // 
            // cmb_Shape1
            // 
            this.cmb_Shape1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Shape1.FormattingEnabled = true;
            this.cmb_Shape1.Items.AddRange(new object[] {
            "普通矩形",
            "旋转矩形",
            "圆",
            "椭圆",
            "涂抹区域"});
            this.cmb_Shape1.Location = new System.Drawing.Point(76, 62);
            this.cmb_Shape1.Name = "cmb_Shape1";
            this.cmb_Shape1.Size = new System.Drawing.Size(92, 20);
            this.cmb_Shape1.TabIndex = 21;
            // 
            // chkCorrect
            // 
            this.chkCorrect.Location = new System.Drawing.Point(192, 89);
            this.chkCorrect.Margin = new System.Windows.Forms.Padding(2);
            this.chkCorrect.Name = "chkCorrect";
            this.chkCorrect.Size = new System.Drawing.Size(92, 20);
            this.chkCorrect.TabIndex = 49;
            this.chkCorrect.Text = "涂抹启用补正";
            this.chkCorrect.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 45;
            this.label11.Text = "参考位置：";
            // 
            // bt_Paint
            // 
            this.bt_Paint.Location = new System.Drawing.Point(192, 62);
            this.bt_Paint.Name = "bt_Paint";
            this.bt_Paint.Size = new System.Drawing.Size(92, 20);
            this.bt_Paint.TabIndex = 22;
            this.bt_Paint.Text = "涂抹绘制";
            this.bt_Paint.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "区域形状：";
            // 
            // bt_Draw1
            // 
            this.bt_Draw1.Location = new System.Drawing.Point(192, 34);
            this.bt_Draw1.Name = "bt_Draw1";
            this.bt_Draw1.Size = new System.Drawing.Size(92, 20);
            this.bt_Draw1.TabIndex = 23;
            this.bt_Draw1.Text = "绘制";
            this.bt_Draw1.UseVisualStyleBackColor = true;
            this.bt_Draw1.Click += new System.EventHandler(this.bt_Draw1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(131, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 49;
            this.label12.Text = "当前图像:";
            // 
            // cmb_CurrentImg
            // 
            this.cmb_CurrentImg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CurrentImg.FormattingEnabled = true;
            this.cmb_CurrentImg.Location = new System.Drawing.Point(192, 14);
            this.cmb_CurrentImg.Name = "cmb_CurrentImg";
            this.cmb_CurrentImg.Size = new System.Drawing.Size(115, 20);
            this.cmb_CurrentImg.TabIndex = 48;
            // 
            // mWindow
            // 
            this.mWindow.BackColor = System.Drawing.Color.Transparent;
            this.mWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.mWindow.ForeColor = System.Drawing.SystemColors.Control;
            this.mWindow.Image = null;
            this.mWindow.Location = new System.Drawing.Point(350, 1);
            this.mWindow.Name = "mWindow";
            this.mWindow.Size = new System.Drawing.Size(497, 471);
            this.mWindow.TabIndex = 47;
            // 
            // cbxFileName
            // 
            this.cbxFileName.AutoCompleteCustomSource.AddRange(new string[] {
            "Document_A-Z+_NoRej.omc",
            "Document_0-9A-Z_NoRej.omc",
            "Document_0-9_NoRej.omc",
            "Document_NoRej.omc",
            "Document_A-Z+_Rej.omc",
            "Document_0-9A-Z_Rej.omc",
            "Document_0-9_Rej.omc",
            "Document_Rej.omc",
            "DotPrint_A-Z+.omc",
            "DotPrint_0-9A-Z.omc",
            "DotPrint_0-9.omc",
            "DotPrint_0-9+.omc",
            "DotPrint.omc",
            "HandWritten_0-9.omc",
            "Industrial_A-Z+_NoRej.omc",
            "Industrial_0-9A-Z_NoRej.omc",
            "Industrial_0-9_NoRej.omc",
            "Industrial_0-9+_NoRej.omc",
            "Industrial_NoRej.omc",
            "Industrial_A-Z+_Rej.omc",
            "Industrial_0-9A-Z_Rej.omc",
            "Industrial_0-9_Rej.omc",
            "Industrial_0-9+_Rej.omc",
            "Industrial_Rej.omc",
            "MICR.omc",
            "OCRB_A-Z+.omc",
            "OCRA_0-9A-Z.omc",
            "OCRA_0-9.omc",
            "OCRA.omc",
            "OCRB_A-Z+.omc",
            "OCRB_0-9A-Z.omc",
            "OCRB_0-9.omc",
            "OCRB.omc",
            "OCRB_passport.omc",
            "Pharma_0-9A-Z.omc",
            "Pharma_0-9.omc",
            "Pharma_0-9+.omc",
            "Pharma.omc",
            "SEMI.omc"});
            this.cbxFileName.FormattingEnabled = true;
            this.cbxFileName.Location = new System.Drawing.Point(99, 136);
            this.cbxFileName.Name = "cbxFileName";
            this.cbxFileName.Size = new System.Drawing.Size(196, 20);
            this.cbxFileName.TabIndex = 73;
            this.cbxFileName.Text = "Industrial_0-9A-Z_NoRej.omc";
            this.cbxFileName.SelectedIndexChanged += new System.EventHandler(this.cbxFileName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 72;
            this.label1.Text = "训练文件：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 75;
            this.label7.Text = "识别模式：";
            // 
            // cbxOcrSelect
            // 
            this.cbxOcrSelect.FormattingEnabled = true;
            this.cbxOcrSelect.Items.AddRange(new object[] {
            "一般字符",
            "一般字符光照不均匀",
            "喷码点状字符"});
            this.cbxOcrSelect.Location = new System.Drawing.Point(99, 162);
            this.cbxOcrSelect.Name = "cbxOcrSelect";
            this.cbxOcrSelect.Size = new System.Drawing.Size(197, 20);
            this.cbxOcrSelect.TabIndex = 74;
            this.cbxOcrSelect.Text = "一般字符";
            // 
            // tabControl1
            // 
            this.tabControl1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.tabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.tabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(335, 473);
            this.tabControl1.TabIndex = 76;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(327, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(327, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "显示设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonFragments);
            this.panel1.Controls.Add(this.radioButtonDotPrint);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtExpression);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtLineSeparators);
            this.panel1.Controls.Add(this.txtLineStructure);
            this.panel1.Controls.Add(this.UpDownMinStrokeWidth);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.UpDownMaxStrokeWidth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.UpDownMinCharWidth);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.UpDownMaxCharWidth);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.UpDownMinCharHeight);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.UpDownMaxCharHeight);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.UpDownMinContrast);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxFileName);
            this.panel1.Controls.Add(this.cbxOcrSelect);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 441);
            this.panel1.TabIndex = 0;
            // 
            // radioButtonFragments
            // 
            this.radioButtonFragments.AutoSize = true;
            this.radioButtonFragments.Location = new System.Drawing.Point(225, 417);
            this.radioButtonFragments.Name = "radioButtonFragments";
            this.radioButtonFragments.Size = new System.Drawing.Size(89, 16);
            this.radioButtonFragments.TabIndex = 98;
            this.radioButtonFragments.TabStop = true;
            this.radioButtonFragments.Text = "是否识别(i)";
            this.radioButtonFragments.UseVisualStyleBackColor = true;
            // 
            // radioButtonDotPrint
            // 
            this.radioButtonDotPrint.AutoSize = true;
            this.radioButtonDotPrint.Location = new System.Drawing.Point(225, 395);
            this.radioButtonDotPrint.Name = "radioButtonDotPrint";
            this.radioButtonDotPrint.Size = new System.Drawing.Size(71, 16);
            this.radioButtonDotPrint.TabIndex = 97;
            this.radioButtonDotPrint.TabStop = true;
            this.radioButtonDotPrint.Text = "是否点阵";
            this.radioButtonDotPrint.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonBoth);
            this.groupBox1.Controls.Add(this.radioButtonBlack);
            this.groupBox1.Controls.Add(this.radioButtonWhite);
            this.groupBox1.Location = new System.Drawing.Point(3, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 43);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "字符颜色";
            // 
            // radioButtonBoth
            // 
            this.radioButtonBoth.AutoSize = true;
            this.radioButtonBoth.Location = new System.Drawing.Point(135, 20);
            this.radioButtonBoth.Name = "radioButtonBoth";
            this.radioButtonBoth.Size = new System.Drawing.Size(59, 16);
            this.radioButtonBoth.TabIndex = 2;
            this.radioButtonBoth.Text = "不区分";
            this.radioButtonBoth.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.Location = new System.Drawing.Point(74, 21);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(47, 16);
            this.radioButtonBlack.TabIndex = 1;
            this.radioButtonBlack.Text = "黑色";
            this.radioButtonBlack.UseVisualStyleBackColor = true;
            // 
            // radioButtonWhite
            // 
            this.radioButtonWhite.AutoSize = true;
            this.radioButtonWhite.Checked = true;
            this.radioButtonWhite.Location = new System.Drawing.Point(7, 21);
            this.radioButtonWhite.Name = "radioButtonWhite";
            this.radioButtonWhite.Size = new System.Drawing.Size(47, 16);
            this.radioButtonWhite.TabIndex = 0;
            this.radioButtonWhite.TabStop = true;
            this.radioButtonWhite.Text = "白色";
            this.radioButtonWhite.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 370);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 12);
            this.label15.TabIndex = 96;
            this.label15.Text = "匹配正则表达式";
            // 
            // txtExpression
            // 
            this.txtExpression.Location = new System.Drawing.Point(98, 367);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(216, 21);
            this.txtExpression.TabIndex = 95;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(180, 328);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 93;
            this.label16.Text = "分隔符";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 327);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 94;
            this.label17.Text = "文本结构";
            // 
            // txtLineSeparators
            // 
            this.txtLineSeparators.Location = new System.Drawing.Point(238, 324);
            this.txtLineSeparators.Name = "txtLineSeparators";
            this.txtLineSeparators.Size = new System.Drawing.Size(76, 21);
            this.txtLineSeparators.TabIndex = 91;
            // 
            // txtLineStructure
            // 
            this.txtLineStructure.Location = new System.Drawing.Point(98, 324);
            this.txtLineStructure.Name = "txtLineStructure";
            this.txtLineStructure.Size = new System.Drawing.Size(76, 21);
            this.txtLineStructure.TabIndex = 92;
            // 
            // UpDownMinStrokeWidth
            // 
            this.UpDownMinStrokeWidth.Location = new System.Drawing.Point(104, 269);
            this.UpDownMinStrokeWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UpDownMinStrokeWidth.Name = "UpDownMinStrokeWidth";
            this.UpDownMinStrokeWidth.Size = new System.Drawing.Size(51, 21);
            this.UpDownMinStrokeWidth.TabIndex = 89;
            this.UpDownMinStrokeWidth.ValueChanged += new System.EventHandler(this.ValueChanged控件值变更);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 88;
            this.label10.Text = "笔画最小宽度";
            // 
            // UpDownMaxStrokeWidth
            // 
            this.UpDownMaxStrokeWidth.Location = new System.Drawing.Point(244, 269);
            this.UpDownMaxStrokeWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UpDownMaxStrokeWidth.Name = "UpDownMaxStrokeWidth";
            this.UpDownMaxStrokeWidth.Size = new System.Drawing.Size(51, 21);
            this.UpDownMaxStrokeWidth.TabIndex = 87;
            this.UpDownMaxStrokeWidth.ValueChanged += new System.EventHandler(this.ValueChanged控件值变更);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 86;
            this.label3.Text = "笔画最大宽度";
            // 
            // UpDownMinCharWidth
            // 
            this.UpDownMinCharWidth.Location = new System.Drawing.Point(105, 210);
            this.UpDownMinCharWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UpDownMinCharWidth.Name = "UpDownMinCharWidth";
            this.UpDownMinCharWidth.Size = new System.Drawing.Size(51, 21);
            this.UpDownMinCharWidth.TabIndex = 85;
            this.UpDownMinCharWidth.ValueChanged += new System.EventHandler(this.ValueChanged控件值变更);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 84;
            this.label8.Text = "文字最小宽度";
            // 
            // UpDownMaxCharWidth
            // 
            this.UpDownMaxCharWidth.Location = new System.Drawing.Point(245, 210);
            this.UpDownMaxCharWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UpDownMaxCharWidth.Name = "UpDownMaxCharWidth";
            this.UpDownMaxCharWidth.Size = new System.Drawing.Size(51, 21);
            this.UpDownMaxCharWidth.TabIndex = 83;
            this.UpDownMaxCharWidth.ValueChanged += new System.EventHandler(this.ValueChanged控件值变更);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 82;
            this.label9.Text = "文字最大宽度";
            // 
            // UpDownMinCharHeight
            // 
            this.UpDownMinCharHeight.Location = new System.Drawing.Point(104, 237);
            this.UpDownMinCharHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UpDownMinCharHeight.Name = "UpDownMinCharHeight";
            this.UpDownMinCharHeight.Size = new System.Drawing.Size(51, 21);
            this.UpDownMinCharHeight.TabIndex = 81;
            this.UpDownMinCharHeight.ValueChanged += new System.EventHandler(this.ValueChanged控件值变更);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 80;
            this.label5.Text = "文字最小高度";
            // 
            // UpDownMaxCharHeight
            // 
            this.UpDownMaxCharHeight.Location = new System.Drawing.Point(244, 237);
            this.UpDownMaxCharHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UpDownMaxCharHeight.Name = "UpDownMaxCharHeight";
            this.UpDownMaxCharHeight.Size = new System.Drawing.Size(51, 21);
            this.UpDownMaxCharHeight.TabIndex = 79;
            this.UpDownMaxCharHeight.ValueChanged += new System.EventHandler(this.ValueChanged控件值变更);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(161, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 78;
            this.label13.Text = "文字最大高度";
            // 
            // UpDownMinContrast
            // 
            this.UpDownMinContrast.DecimalPlaces = 1;
            this.UpDownMinContrast.Location = new System.Drawing.Point(104, 188);
            this.UpDownMinContrast.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.UpDownMinContrast.Name = "UpDownMinContrast";
            this.UpDownMinContrast.Size = new System.Drawing.Size(51, 21);
            this.UpDownMinContrast.TabIndex = 77;
            this.UpDownMinContrast.ValueChanged += new System.EventHandler(this.ValueChanged控件值变更);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 76;
            this.label14.Text = "最小对比度";
            // 
            // OCRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OCRForm";
            this.Load += new System.EventHandler(this.ModForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMinStrokeWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMaxStrokeWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMinCharWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMaxCharWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMinCharHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMaxCharHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMinContrast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RexView.HWindow_Fit mWindow;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_Color1;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.ComboBox cmb_PositionUnitID;
        private System.Windows.Forms.ComboBox cmb_Shape1;
        private System.Windows.Forms.CheckBox chkCorrect;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_Paint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Draw1;
        private System.Windows.Forms.ComboBox cbxFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxOcrSelect;
        protected System.Windows.Forms.ComboBox cmb_CurrentImg;
        private System.Windows.Forms.Label label12;
        private Rex.CTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonBoth;
        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.RadioButton radioButtonWhite;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtLineSeparators;
        private System.Windows.Forms.TextBox txtLineStructure;
        private System.Windows.Forms.NumericUpDown UpDownMinStrokeWidth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown UpDownMaxStrokeWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown UpDownMinCharWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown UpDownMaxCharWidth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown UpDownMinCharHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown UpDownMaxCharHeight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown UpDownMinContrast;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radioButtonDotPrint;
        private System.Windows.Forms.RadioButton radioButtonFragments;
    }
}