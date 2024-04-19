namespace Plugin.Corde2D
{
    partial class Corde2DModForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Corde2DModForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkUseZxing = new System.Windows.Forms.CheckBox();
            this.chkUseTextCompare = new System.Windows.Forms.CheckBox();
            this.groupBoxStrSub = new System.Windows.Forms.GroupBox();
            this.com_CordNum = new System.Windows.Forms.ComboBox();
            this.txtModelKeyName = new System.Windows.Forms.TextBox();
            this.cbxCodeTypeWant = new System.Windows.Forms.ComboBox();
            this.cmbFindMode = new System.Windows.Forms.ComboBox();
            this.UpDownLength = new System.Windows.Forms.NumericUpDown();
            this.UpDownStartIndex = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_CurrentImg = new System.Windows.Forms.ComboBox();
            this.bt_Color1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_Shape1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkCorrect = new System.Windows.Forms.CheckBox();
            this.bt_Paint = new System.Windows.Forms.Button();
            this.btnModelCreate = new System.Windows.Forms.Button();
            this.bt_draw = new System.Windows.Forms.Button();
            this.TestModelButton = new System.Windows.Forms.Button();
            this.cmb_PositionUnitID = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxStrSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownStartIndex)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(322, 438);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkUseZxing);
            this.groupBox3.Controls.Add(this.chkUseTextCompare);
            this.groupBox3.Controls.Add(this.groupBoxStrSub);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 424);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // chkUseZxing
            // 
            this.chkUseZxing.AutoSize = true;
            this.chkUseZxing.Location = new System.Drawing.Point(24, 358);
            this.chkUseZxing.Name = "chkUseZxing";
            this.chkUseZxing.Size = new System.Drawing.Size(132, 16);
            this.chkUseZxing.TabIndex = 94;
            this.chkUseZxing.Text = "使用深度查找(耗时)";
            this.chkUseZxing.UseVisualStyleBackColor = true;
            // 
            // chkUseTextCompare
            // 
            this.chkUseTextCompare.AutoSize = true;
            this.chkUseTextCompare.Location = new System.Drawing.Point(24, 384);
            this.chkUseTextCompare.Name = "chkUseTextCompare";
            this.chkUseTextCompare.Size = new System.Drawing.Size(120, 16);
            this.chkUseTextCompare.TabIndex = 93;
            this.chkUseTextCompare.Text = "使用模板文字对比";
            this.chkUseTextCompare.UseVisualStyleBackColor = true;
            // 
            // groupBoxStrSub
            // 
            this.groupBoxStrSub.Controls.Add(this.com_CordNum);
            this.groupBoxStrSub.Controls.Add(this.txtModelKeyName);
            this.groupBoxStrSub.Controls.Add(this.cbxCodeTypeWant);
            this.groupBoxStrSub.Controls.Add(this.cmbFindMode);
            this.groupBoxStrSub.Controls.Add(this.UpDownLength);
            this.groupBoxStrSub.Controls.Add(this.UpDownStartIndex);
            this.groupBoxStrSub.Controls.Add(this.label9);
            this.groupBoxStrSub.Controls.Add(this.label7);
            this.groupBoxStrSub.Controls.Add(this.label5);
            this.groupBoxStrSub.Controls.Add(this.label1);
            this.groupBoxStrSub.Controls.Add(this.label4);
            this.groupBoxStrSub.Controls.Add(this.label3);
            this.groupBoxStrSub.Location = new System.Drawing.Point(3, 11);
            this.groupBoxStrSub.Name = "groupBoxStrSub";
            this.groupBoxStrSub.Size = new System.Drawing.Size(160, 320);
            this.groupBoxStrSub.TabIndex = 92;
            this.groupBoxStrSub.TabStop = false;
            this.groupBoxStrSub.Text = "参数设置";
            // 
            // com_CordNum
            // 
            this.com_CordNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_CordNum.FormattingEnabled = true;
            this.com_CordNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.com_CordNum.Location = new System.Drawing.Point(71, 153);
            this.com_CordNum.Name = "com_CordNum";
            this.com_CordNum.Size = new System.Drawing.Size(83, 20);
            this.com_CordNum.TabIndex = 106;
            this.com_CordNum.SelectedIndexChanged += new System.EventHandler(this.com_CordNum_SelectedIndexChanged);
            // 
            // txtModelKeyName
            // 
            this.txtModelKeyName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtModelKeyName.Location = new System.Drawing.Point(71, 231);
            this.txtModelKeyName.Name = "txtModelKeyName";
            this.txtModelKeyName.ReadOnly = true;
            this.txtModelKeyName.Size = new System.Drawing.Size(83, 21);
            this.txtModelKeyName.TabIndex = 103;
            this.txtModelKeyName.Text = "默认";
            // 
            // cbxCodeTypeWant
            // 
            this.cbxCodeTypeWant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCodeTypeWant.FormattingEnabled = true;
            this.cbxCodeTypeWant.Items.AddRange(new object[] {
            "auto",
            "QR Code",
            "Data Matrix ECC 200",
            "Aztec Code",
            "GS1 Aztec Code",
            "GS1 DataMatrix",
            "GS1 QR Code",
            "Micro QR Code",
            "PDF417"});
            this.cbxCodeTypeWant.Location = new System.Drawing.Point(71, 205);
            this.cbxCodeTypeWant.Name = "cbxCodeTypeWant";
            this.cbxCodeTypeWant.Size = new System.Drawing.Size(83, 20);
            this.cbxCodeTypeWant.TabIndex = 102;
            this.cbxCodeTypeWant.SelectedIndexChanged += new System.EventHandler(this.cbxCodeTypeWant_SelectedIndexChanged);
            // 
            // cmbFindMode
            // 
            this.cmbFindMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFindMode.FormattingEnabled = true;
            this.cmbFindMode.Location = new System.Drawing.Point(71, 179);
            this.cmbFindMode.Name = "cmbFindMode";
            this.cmbFindMode.Size = new System.Drawing.Size(83, 20);
            this.cmbFindMode.TabIndex = 100;
            this.cmbFindMode.SelectedIndexChanged += new System.EventHandler(this.cmbFindMode_SelectedIndexChanged);
            // 
            // UpDownLength
            // 
            this.UpDownLength.Location = new System.Drawing.Point(71, 126);
            this.UpDownLength.Name = "UpDownLength";
            this.UpDownLength.Size = new System.Drawing.Size(83, 21);
            this.UpDownLength.TabIndex = 80;
            // 
            // UpDownStartIndex
            // 
            this.UpDownStartIndex.Location = new System.Drawing.Point(72, 102);
            this.UpDownStartIndex.Name = "UpDownStartIndex";
            this.UpDownStartIndex.Size = new System.Drawing.Size(83, 21);
            this.UpDownStartIndex.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 105;
            this.label9.Text = "查找数量：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 104;
            this.label7.Text = "编码模板：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 101;
            this.label5.Text = "编码格式：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 99;
            this.label1.Text = "查找模式：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 82;
            this.label4.Text = "字符结束位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 81;
            this.label3.Text = "字符起始位：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_CurrentImg);
            this.groupBox2.Controls.Add(this.bt_Color1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cmb_Shape1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.chkCorrect);
            this.groupBox2.Controls.Add(this.bt_Paint);
            this.groupBox2.Controls.Add(this.btnModelCreate);
            this.groupBox2.Controls.Add(this.bt_draw);
            this.groupBox2.Controls.Add(this.TestModelButton);
            this.groupBox2.Controls.Add(this.cmb_PositionUnitID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(169, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 424);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // cmb_CurrentImg
            // 
            this.cmb_CurrentImg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CurrentImg.FormattingEnabled = true;
            this.cmb_CurrentImg.Location = new System.Drawing.Point(64, 114);
            this.cmb_CurrentImg.Name = "cmb_CurrentImg";
            this.cmb_CurrentImg.Size = new System.Drawing.Size(84, 20);
            this.cmb_CurrentImg.TabIndex = 32;
            // 
            // bt_Color1
            // 
            this.bt_Color1.BackColor = System.Drawing.Color.Lime;
            this.bt_Color1.ForeColor = System.Drawing.Color.White;
            this.bt_Color1.Location = new System.Drawing.Point(64, 137);
            this.bt_Color1.Name = "bt_Color1";
            this.bt_Color1.Size = new System.Drawing.Size(84, 21);
            this.bt_Color1.TabIndex = 107;
            this.bt_Color1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 106;
            this.label6.Text = "画笔颜色：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 33;
            this.label12.Text = "当前图像：";
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
            this.cmb_Shape1.Location = new System.Drawing.Point(64, 190);
            this.cmb_Shape1.Name = "cmb_Shape1";
            this.cmb_Shape1.Size = new System.Drawing.Size(84, 20);
            this.cmb_Shape1.TabIndex = 105;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 104;
            this.label8.Text = "区域形状：";
            // 
            // chkCorrect
            // 
            this.chkCorrect.AutoSize = true;
            this.chkCorrect.Location = new System.Drawing.Point(52, 268);
            this.chkCorrect.Margin = new System.Windows.Forms.Padding(2);
            this.chkCorrect.Name = "chkCorrect";
            this.chkCorrect.Size = new System.Drawing.Size(96, 16);
            this.chkCorrect.TabIndex = 44;
            this.chkCorrect.Text = "涂抹启用补正";
            this.chkCorrect.UseVisualStyleBackColor = true;
            // 
            // bt_Paint
            // 
            this.bt_Paint.Location = new System.Drawing.Point(64, 240);
            this.bt_Paint.Name = "bt_Paint";
            this.bt_Paint.Size = new System.Drawing.Size(84, 23);
            this.bt_Paint.TabIndex = 43;
            this.bt_Paint.Text = "涂抹绘制";
            this.bt_Paint.UseVisualStyleBackColor = true;
            this.bt_Paint.Click += new System.EventHandler(this.bt_Paint_Click);
            // 
            // btnModelCreate
            // 
            this.btnModelCreate.Location = new System.Drawing.Point(39, 376);
            this.btnModelCreate.Name = "btnModelCreate";
            this.btnModelCreate.Size = new System.Drawing.Size(84, 30);
            this.btnModelCreate.TabIndex = 102;
            this.btnModelCreate.Text = "模板生成";
            this.btnModelCreate.Click += new System.EventHandler(this.btnModelCreate_Click);
            // 
            // bt_draw
            // 
            this.bt_draw.Location = new System.Drawing.Point(64, 214);
            this.bt_draw.Name = "bt_draw";
            this.bt_draw.Size = new System.Drawing.Size(84, 23);
            this.bt_draw.TabIndex = 37;
            this.bt_draw.Text = "绘制";
            this.bt_draw.UseVisualStyleBackColor = true;
            this.bt_draw.Click += new System.EventHandler(this.bt_draw_Click);
            // 
            // TestModelButton
            // 
            this.TestModelButton.Location = new System.Drawing.Point(39, 344);
            this.TestModelButton.Name = "TestModelButton";
            this.TestModelButton.Size = new System.Drawing.Size(84, 30);
            this.TestModelButton.TabIndex = 100;
            this.TestModelButton.Text = "训练图像";
            // 
            // cmb_PositionUnitID
            // 
            this.cmb_PositionUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PositionUnitID.FormattingEnabled = true;
            this.cmb_PositionUnitID.Location = new System.Drawing.Point(64, 164);
            this.cmb_PositionUnitID.Name = "cmb_PositionUnitID";
            this.cmb_PositionUnitID.Size = new System.Drawing.Size(84, 20);
            this.cmb_PositionUnitID.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 32;
            this.label11.Text = "参考位置：";
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
            this.tabControl1.Size = new System.Drawing.Size(336, 474);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(328, 444);
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
            this.tabPage2.Size = new System.Drawing.Size(328, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "显示设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uicb_Result
            // 
            this.uicb_Result.AutoSize = true;
            this.uicb_Result.Location = new System.Drawing.Point(76, 142);
            this.uicb_Result.Name = "uicb_Result";
            this.uicb_Result.Size = new System.Drawing.Size(96, 16);
            this.uicb_Result.TabIndex = 18;
            this.uicb_Result.Text = "是否显示结果";
            this.uicb_Result.UseVisualStyleBackColor = true;
            this.uicb_Result.CheckedChanged += new System.EventHandler(this.uicb_Result_CheckedChanged);
            // 
            // uicb_Area
            // 
            this.uicb_Area.AutoSize = true;
            this.uicb_Area.Location = new System.Drawing.Point(76, 108);
            this.uicb_Area.Name = "uicb_Area";
            this.uicb_Area.Size = new System.Drawing.Size(120, 16);
            this.uicb_Area.TabIndex = 17;
            this.uicb_Area.Text = "是否显示查找范围";
            this.uicb_Area.UseVisualStyleBackColor = true;
            this.uicb_Area.CheckedChanged += new System.EventHandler(this.uicb_Area_CheckedChanged);
            // 
            // uicb_Roi
            // 
            this.uicb_Roi.AutoSize = true;
            this.uicb_Roi.Location = new System.Drawing.Point(76, 77);
            this.uicb_Roi.Name = "uicb_Roi";
            this.uicb_Roi.Size = new System.Drawing.Size(90, 16);
            this.uicb_Roi.TabIndex = 16;
            this.uicb_Roi.Text = "是否显示ROI";
            this.uicb_Roi.UseVisualStyleBackColor = true;
            this.uicb_Roi.CheckedChanged += new System.EventHandler(this.show_roi_CheckedChanged);
            // 
            // mWindow
            // 
            this.mWindow.BackColor = System.Drawing.Color.Transparent;
            this.mWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.mWindow.ForeColor = System.Drawing.SystemColors.Control;
            this.mWindow.Image = null;
            this.mWindow.Location = new System.Drawing.Point(348, 1);
            this.mWindow.Name = "mWindow";
            this.mWindow.Size = new System.Drawing.Size(497, 474);
            this.mWindow.TabIndex = 34;
            // 
            // Corde2DModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Corde2DModForm";
            this.Load += new System.EventHandler(this.ModForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxStrSub.ResumeLayout(false);
            this.groupBoxStrSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownStartIndex)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        protected System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkCorrect;
        private System.Windows.Forms.Button bt_Paint;
        protected System.Windows.Forms.Button bt_draw;
        protected System.Windows.Forms.ComboBox cmb_PositionUnitID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        protected System.Windows.Forms.ComboBox cmb_CurrentImg;
        private RexView.HWindow_Fit mWindow;
        private Rex.CTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox uicb_Result;
        private System.Windows.Forms.CheckBox uicb_Area;
        private System.Windows.Forms.CheckBox uicb_Roi;
        private System.Windows.Forms.CheckBox chkUseZxing;
        private System.Windows.Forms.CheckBox chkUseTextCompare;
        private System.Windows.Forms.GroupBox groupBoxStrSub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModelKeyName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCodeTypeWant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFindMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown UpDownLength;
        private System.Windows.Forms.NumericUpDown UpDownStartIndex;
        private System.Windows.Forms.Button btnModelCreate;
        private System.Windows.Forms.Button TestModelButton;
        private System.Windows.Forms.ComboBox cmb_Shape1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_Color1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox com_CordNum;
    }
}