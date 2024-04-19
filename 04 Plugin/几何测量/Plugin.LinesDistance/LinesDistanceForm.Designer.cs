namespace Plugin.LinesDistance
{
    partial class LinesDistanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinesDistanceForm));
            this.tabControl1 = new Rex.CTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.uilk_Extract = new RexControl.CTextBox();
            this.uilk_Remov = new RexControl.CTextBox();
            this.uicb_ExtractPer = new Rex.UI.UICheckBox();
            this.uicb_RemovPer = new Rex.UI.UICheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.uilk_PullType = new Rex.UI.UIComboBox();
            this.uilk_ValueMode = new Rex.UI.UIComboBox();
            this.uicb_ConverValue = new Rex.UI.UICheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uiTitlePanel4 = new Rex.UI.UITitlePanel();
            this.uilk_LineR = new Rex.UI.UILinkText();
            this.label1 = new System.Windows.Forms.Label();
            this.uilk_Image = new Rex.UI.UILinkText();
            this.uilk_Line2 = new Rex.UI.UILinkText();
            this.uilk_Line1 = new Rex.UI.UILinkText();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uicb_Result = new Rex.UI.UICheckBox();
            this.uicb_Area = new Rex.UI.UICheckBox();
            this.uicb_Roi = new Rex.UI.UICheckBox();
            this.mWindowH = new RexView.HWindow_HE();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.uiTitlePanel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.mWindowH);
            this.panel_center.Controls.Add(this.tabControl1);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Size = new System.Drawing.Size(189, 23);
            // 
            // cb_Enable
            // 
            this.cb_Enable.Location = new System.Drawing.Point(234, 12);
            // 
            // btn_Save
            // 
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
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
            this.tabControl1.Size = new System.Drawing.Size(280, 473);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.uiTitlePanel2);
            this.tabPage1.Controls.Add(this.uiTitlePanel1);
            this.tabPage1.Controls.Add(this.uiTitlePanel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(272, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.uilk_Extract);
            this.uiTitlePanel2.Controls.Add(this.uilk_Remov);
            this.uiTitlePanel2.Controls.Add(this.uicb_ExtractPer);
            this.uiTitlePanel2.Controls.Add(this.uicb_RemovPer);
            this.uiTitlePanel2.Controls.Add(this.label7);
            this.uiTitlePanel2.Controls.Add(this.label8);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(3, 315);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.Size = new System.Drawing.Size(266, 125);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.StyleCustomMode = true;
            this.uiTitlePanel2.TabIndex = 143;
            this.uiTitlePanel2.Text = "筛选规则";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uilk_Extract
            // 
            this.uilk_Extract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilk_Extract.DefaultText = "";
            this.uilk_Extract.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uilk_Extract.Location = new System.Drawing.Point(71, 81);
            this.uilk_Extract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uilk_Extract.MaximumSize = new System.Drawing.Size(400, 22);
            this.uilk_Extract.MinimumSize = new System.Drawing.Size(20, 22);
            this.uilk_Extract.Name = "uilk_Extract";
            this.uilk_Extract.PasswordChar = false;
            this.uilk_Extract.Size = new System.Drawing.Size(105, 22);
            this.uilk_Extract.TabIndex = 156;
            this.uilk_Extract.TextStr = "100";
            // 
            // uilk_Remov
            // 
            this.uilk_Remov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilk_Remov.DefaultText = "";
            this.uilk_Remov.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uilk_Remov.Location = new System.Drawing.Point(71, 51);
            this.uilk_Remov.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uilk_Remov.MaximumSize = new System.Drawing.Size(400, 22);
            this.uilk_Remov.MinimumSize = new System.Drawing.Size(20, 22);
            this.uilk_Remov.Name = "uilk_Remov";
            this.uilk_Remov.PasswordChar = false;
            this.uilk_Remov.Size = new System.Drawing.Size(105, 22);
            this.uilk_Remov.TabIndex = 155;
            this.uilk_Remov.TextStr = "100";
            // 
            // uicb_ExtractPer
            // 
            this.uicb_ExtractPer.BackColor = System.Drawing.Color.Transparent;
            this.uicb_ExtractPer.Checked = true;
            this.uicb_ExtractPer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_ExtractPer.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_ExtractPer.Location = new System.Drawing.Point(182, 85);
            this.uicb_ExtractPer.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_ExtractPer.Name = "uicb_ExtractPer";
            this.uicb_ExtractPer.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_ExtractPer.Size = new System.Drawing.Size(64, 18);
            this.uicb_ExtractPer.Style = Rex.UI.UIStyle.Custom;
            this.uicb_ExtractPer.TabIndex = 154;
            this.uicb_ExtractPer.Text = "百分比";
            // 
            // uicb_RemovPer
            // 
            this.uicb_RemovPer.BackColor = System.Drawing.Color.Transparent;
            this.uicb_RemovPer.Checked = true;
            this.uicb_RemovPer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_RemovPer.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_RemovPer.Location = new System.Drawing.Point(182, 55);
            this.uicb_RemovPer.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_RemovPer.Name = "uicb_RemovPer";
            this.uicb_RemovPer.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_RemovPer.Size = new System.Drawing.Size(64, 18);
            this.uicb_RemovPer.Style = Rex.UI.UIStyle.Custom;
            this.uicb_RemovPer.TabIndex = 153;
            this.uicb_RemovPer.Text = "百分比";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(17, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 150;
            this.label7.Text = "提取点数:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(17, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 149;
            this.label8.Text = "剔除点数:";
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uilk_PullType);
            this.uiTitlePanel1.Controls.Add(this.uilk_ValueMode);
            this.uiTitlePanel1.Controls.Add(this.uicb_ConverValue);
            this.uiTitlePanel1.Controls.Add(this.label6);
            this.uiTitlePanel1.Controls.Add(this.label5);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(3, 182);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.Size = new System.Drawing.Size(266, 133);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.StyleCustomMode = true;
            this.uiTitlePanel1.TabIndex = 142;
            this.uiTitlePanel1.Text = "测量方法";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uilk_PullType
            // 
            this.uilk_PullType.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uilk_PullType.Items.AddRange(new object[] {
            "全部点数",
            "剔除提取"});
            this.uilk_PullType.Location = new System.Drawing.Point(64, 67);
            this.uilk_PullType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilk_PullType.MaxDropDownItems = 5;
            this.uilk_PullType.MinimumSize = new System.Drawing.Size(63, 0);
            this.uilk_PullType.Name = "uilk_PullType";
            this.uilk_PullType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uilk_PullType.Radius = 2;
            this.uilk_PullType.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_PullType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_PullType.Size = new System.Drawing.Size(182, 23);
            this.uilk_PullType.Style = Rex.UI.UIStyle.Custom;
            this.uilk_PullType.StyleCustomMode = true;
            this.uilk_PullType.TabIndex = 147;
            this.uilk_PullType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uilk_PullType.Watermark = "筛选方法";
            // 
            // uilk_ValueMode
            // 
            this.uilk_ValueMode.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uilk_ValueMode.Items.AddRange(new object[] {
            "平均值",
            "最小值",
            "最大值"});
            this.uilk_ValueMode.Location = new System.Drawing.Point(63, 39);
            this.uilk_ValueMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilk_ValueMode.MaxDropDownItems = 5;
            this.uilk_ValueMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.uilk_ValueMode.Name = "uilk_ValueMode";
            this.uilk_ValueMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uilk_ValueMode.Radius = 2;
            this.uilk_ValueMode.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_ValueMode.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_ValueMode.Size = new System.Drawing.Size(182, 23);
            this.uilk_ValueMode.Style = Rex.UI.UIStyle.Custom;
            this.uilk_ValueMode.StyleCustomMode = true;
            this.uilk_ValueMode.TabIndex = 6;
            this.uilk_ValueMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uilk_ValueMode.Watermark = "模式选择";
            // 
            // uicb_ConverValue
            // 
            this.uicb_ConverValue.BackColor = System.Drawing.Color.Transparent;
            this.uicb_ConverValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_ConverValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_ConverValue.Location = new System.Drawing.Point(182, 97);
            this.uicb_ConverValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_ConverValue.Name = "uicb_ConverValue";
            this.uicb_ConverValue.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_ConverValue.Size = new System.Drawing.Size(63, 18);
            this.uicb_ConverValue.Style = Rex.UI.UIStyle.Custom;
            this.uicb_ConverValue.TabIndex = 149;
            this.uicb_ConverValue.Text = "转换值";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(31, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 148;
            this.label6.Text = "筛选:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(30, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 146;
            this.label5.Text = "模式:";
            // 
            // uiTitlePanel4
            // 
            this.uiTitlePanel4.Controls.Add(this.uilk_LineR);
            this.uiTitlePanel4.Controls.Add(this.label1);
            this.uiTitlePanel4.Controls.Add(this.uilk_Image);
            this.uiTitlePanel4.Controls.Add(this.uilk_Line2);
            this.uiTitlePanel4.Controls.Add(this.uilk_Line1);
            this.uiTitlePanel4.Controls.Add(this.label21);
            this.uiTitlePanel4.Controls.Add(this.label19);
            this.uiTitlePanel4.Controls.Add(this.label20);
            this.uiTitlePanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel4.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel4.Location = new System.Drawing.Point(3, 3);
            this.uiTitlePanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel4.Name = "uiTitlePanel4";
            this.uiTitlePanel4.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel4.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel4.Size = new System.Drawing.Size(266, 179);
            this.uiTitlePanel4.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel4.StyleCustomMode = true;
            this.uiTitlePanel4.TabIndex = 141;
            this.uiTitlePanel4.Text = "参数设置";
            this.uiTitlePanel4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uilk_LineR
            // 
            this.uilk_LineR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilk_LineR.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uilk_LineR.Location = new System.Drawing.Point(63, 130);
            this.uilk_LineR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilk_LineR.MinimumSize = new System.Drawing.Size(1, 1);
            this.uilk_LineR.Name = "uilk_LineR";
            this.uilk_LineR.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_LineR.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_LineR.Size = new System.Drawing.Size(183, 25);
            this.uilk_LineR.Style = Rex.UI.UIStyle.Custom;
            this.uilk_LineR.StyleCustomMode = true;
            this.uilk_LineR.TabIndex = 148;
            this.uilk_LineR.Text = "uiLinkText2";
            this.uilk_LineR.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uilk_BtnAdd);
            this.uilk_LineR.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uilk_BtnDec);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(17, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 145;
            this.label1.Text = "直线-R:";
            // 
            // uilk_Image
            // 
            this.uilk_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilk_Image.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uilk_Image.Location = new System.Drawing.Point(63, 40);
            this.uilk_Image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilk_Image.MinimumSize = new System.Drawing.Size(1, 1);
            this.uilk_Image.Name = "uilk_Image";
            this.uilk_Image.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_Image.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_Image.Size = new System.Drawing.Size(183, 25);
            this.uilk_Image.Style = Rex.UI.UIStyle.Custom;
            this.uilk_Image.StyleCustomMode = true;
            this.uilk_Image.TabIndex = 141;
            this.uilk_Image.Text = "uiLinkText1";
            this.uilk_Image.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uilk_BtnAdd);
            this.uilk_Image.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uilk_BtnDec);
            // 
            // uilk_Line2
            // 
            this.uilk_Line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilk_Line2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uilk_Line2.Location = new System.Drawing.Point(63, 100);
            this.uilk_Line2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilk_Line2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uilk_Line2.Name = "uilk_Line2";
            this.uilk_Line2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_Line2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_Line2.Size = new System.Drawing.Size(183, 25);
            this.uilk_Line2.Style = Rex.UI.UIStyle.Custom;
            this.uilk_Line2.StyleCustomMode = true;
            this.uilk_Line2.TabIndex = 142;
            this.uilk_Line2.Text = "uiLinkText2";
            this.uilk_Line2.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uilk_BtnAdd);
            this.uilk_Line2.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uilk_BtnDec);
            // 
            // uilk_Line1
            // 
            this.uilk_Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilk_Line1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uilk_Line1.Location = new System.Drawing.Point(63, 70);
            this.uilk_Line1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilk_Line1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uilk_Line1.Name = "uilk_Line1";
            this.uilk_Line1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_Line1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_Line1.Size = new System.Drawing.Size(183, 25);
            this.uilk_Line1.Style = Rex.UI.UIStyle.Custom;
            this.uilk_Line1.StyleCustomMode = true;
            this.uilk_Line1.TabIndex = 140;
            this.uilk_Line1.Text = "uiLinkText1";
            this.uilk_Line1.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uilk_BtnAdd);
            this.uilk_Line1.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uilk_BtnDec);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(18, 104);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 17);
            this.label21.TabIndex = 7;
            this.label21.Text = "直线-2:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(6, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 17);
            this.label19.TabIndex = 3;
            this.label19.Text = "输入图像:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(18, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 17);
            this.label20.TabIndex = 4;
            this.label20.Text = "直线-1:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.uicb_Result);
            this.tabPage2.Controls.Add(this.uicb_Area);
            this.tabPage2.Controls.Add(this.uicb_Roi);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(272, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "显示设置";
            // 
            // uicb_Result
            // 
            this.uicb_Result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Result.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Result.Location = new System.Drawing.Point(25, 53);
            this.uicb_Result.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Result.Name = "uicb_Result";
            this.uicb_Result.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Result.Size = new System.Drawing.Size(96, 16);
            this.uicb_Result.TabIndex = 21;
            this.uicb_Result.Text = "是否显示结果";
            // 
            // uicb_Area
            // 
            this.uicb_Area.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Area.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Area.Location = new System.Drawing.Point(25, 85);
            this.uicb_Area.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Area.Name = "uicb_Area";
            this.uicb_Area.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Area.Size = new System.Drawing.Size(120, 16);
            this.uicb_Area.TabIndex = 20;
            this.uicb_Area.Text = "是否显示查找范围";
            // 
            // uicb_Roi
            // 
            this.uicb_Roi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Roi.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Roi.Location = new System.Drawing.Point(25, 21);
            this.uicb_Roi.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Roi.Name = "uicb_Roi";
            this.uicb_Roi.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Roi.Size = new System.Drawing.Size(96, 16);
            this.uicb_Roi.TabIndex = 19;
            this.uicb_Roi.Text = "是否显示ROI";
            // 
            // mWindowH
            // 
            this.mWindowH.BackColor = System.Drawing.Color.Transparent;
            this.mWindowH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mWindowH.Dock = System.Windows.Forms.DockStyle.Right;
            this.mWindowH.DrawModel = false;
            this.mWindowH.Image = null;
            this.mWindowH.Location = new System.Drawing.Point(285, 1);
            this.mWindowH.Name = "mWindowH";
            this.mWindowH.Padding = new System.Windows.Forms.Padding(1);
            this.mWindowH.Size = new System.Drawing.Size(560, 474);
            this.mWindowH.TabIndex = 8;
            // 
            // LinesDistanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LinesDistanceForm";
            this.Load += new System.EventHandler(this.LinesDistanceForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel2.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.uiTitlePanel4.ResumeLayout(false);
            this.uiTitlePanel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.CTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private Rex.UI.UICheckBox uicb_Result;
        private Rex.UI.UICheckBox uicb_Area;
        private Rex.UI.UICheckBox uicb_Roi;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private Rex.UI.UITitlePanel uiTitlePanel4;
        private Rex.UI.UILinkText uilk_LineR;
        private System.Windows.Forms.Label label1;
        private Rex.UI.UILinkText uilk_Image;
        private Rex.UI.UILinkText uilk_Line2;
        private Rex.UI.UILinkText uilk_Line1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private System.Windows.Forms.Label label6;
        private Rex.UI.UIComboBox uilk_PullType;
        private System.Windows.Forms.Label label5;
        private Rex.UI.UIComboBox uilk_ValueMode;
        private Rex.UI.UICheckBox uicb_ConverValue;
        private Rex.UI.UICheckBox uicb_ExtractPer;
        private Rex.UI.UICheckBox uicb_RemovPer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private RexControl.CTextBox uilk_Extract;
        private RexControl.CTextBox uilk_Remov;
        private RexView.HWindow_HE mWindowH;
    }
}