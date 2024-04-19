namespace Plugin.Matching
{
    partial class MatchingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchingForm));
            this.tabControl1 = new Rex.CTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel4 = new Rex.UI.UITitlePanel();
            this.uiLink_Panel = new Rex.UI.UIPanel();
            this.uiLink_StartX = new Rex.UI.UILinkText();
            this.label4 = new System.Windows.Forms.Label();
            this.uiLink_EndY = new Rex.UI.UILinkText();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uiLink_EndX = new Rex.UI.UILinkText();
            this.uiLink_StartY = new Rex.UI.UILinkText();
            this.label2 = new System.Windows.Forms.Label();
            this.uiLink_LinkRoi = new Rex.UI.UILinkText();
            this.uirb_LinkType = new Rex.UI.UIRadioButtonGroup();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.uirb_ModeType = new Rex.UI.UIRadioButtonGroup();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.label19 = new System.Windows.Forms.Label();
            this.uiLink_Image = new Rex.UI.UILinkText();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel5 = new Rex.UI.UITitlePanel();
            this.uicb_SortType = new Rex.UI.UIComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uidd_MaxOverl = new Rex.UI.UIDoubleUpDownB();
            this.uidd_MatchNum = new Rex.UI.UIDoubleUpDownB();
            this.uidd_GreedDeg = new Rex.UI.UIDoubleUpDownB();
            this.uidd_MatchScore = new Rex.UI.UIDoubleUpDownB();
            this.label7 = new System.Windows.Forms.Label();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.uibt_Esc = new Rex.UI.UISymbolButton();
            this.uibt_Enter = new Rex.UI.UISymbolButton();
            this.uibt_Edit = new Rex.UI.UISymbolButton();
            this.uibt_Study = new Rex.UI.UISymbolButton();
            this.hWindow_HE1 = new RexView.HWindow_HE();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel7 = new Rex.UI.UITitlePanel();
            this.uicb_Roi = new Rex.UI.UICheckBox();
            this.uicb_Area = new Rex.UI.UICheckBox();
            this.uicb_Result = new Rex.UI.UICheckBox();
            this.uiTitlePanel6 = new Rex.UI.UITitlePanel();
            this.uitb_R = new Rex.UI.UITextBox();
            this.uitb_Y = new Rex.UI.UITextBox();
            this.uitb_X = new Rex.UI.UITextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mWindowH = new RexView.HWindow_HE();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.uiTitlePanel4.SuspendLayout();
            this.uiLink_Panel.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.uiTitlePanel5.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.uiTitlePanel7.SuspendLayout();
            this.uiTitlePanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.tabControl1);
            this.panel_center.Controls.Add(this.mWindowH);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Size = new System.Drawing.Size(176, 23);
            // 
            // cb_Enable
            // 
            this.cb_Enable.Location = new System.Drawing.Point(228, 10);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Click += new System.EventHandler(this.bt_Run_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.tabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.tabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(285, 474);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uiTitlePanel4);
            this.tabPage1.Controls.Add(this.uiTitlePanel3);
            this.tabPage1.Controls.Add(this.uiTitlePanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(277, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            // 
            // uiTitlePanel4
            // 
            this.uiTitlePanel4.Controls.Add(this.uiLink_Panel);
            this.uiTitlePanel4.Controls.Add(this.uiLink_LinkRoi);
            this.uiTitlePanel4.Controls.Add(this.uirb_LinkType);
            this.uiTitlePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel4.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel4.Location = new System.Drawing.Point(3, 128);
            this.uiTitlePanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel4.Name = "uiTitlePanel4";
            this.uiTitlePanel4.Padding = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.uiTitlePanel4.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel4.Size = new System.Drawing.Size(271, 313);
            this.uiTitlePanel4.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel4.StyleCustomMode = true;
            this.uiTitlePanel4.TabIndex = 159;
            this.uiTitlePanel4.Text = "创建信息";
            this.uiTitlePanel4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTitlePanel4.TitleInterval = 5;
            // 
            // uiLink_Panel
            // 
            this.uiLink_Panel.Controls.Add(this.uiLink_StartX);
            this.uiLink_Panel.Controls.Add(this.label4);
            this.uiLink_Panel.Controls.Add(this.uiLink_EndY);
            this.uiLink_Panel.Controls.Add(this.label1);
            this.uiLink_Panel.Controls.Add(this.label5);
            this.uiLink_Panel.Controls.Add(this.uiLink_EndX);
            this.uiLink_Panel.Controls.Add(this.uiLink_StartY);
            this.uiLink_Panel.Controls.Add(this.label2);
            this.uiLink_Panel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_Panel.Location = new System.Drawing.Point(3, 88);
            this.uiLink_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.uiLink_Panel.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_Panel.Name = "uiLink_Panel";
            this.uiLink_Panel.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_Panel.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiLink_Panel.Size = new System.Drawing.Size(265, 175);
            this.uiLink_Panel.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_Panel.TabIndex = 158;
            this.uiLink_Panel.Text = null;
            // 
            // uiLink_StartX
            // 
            this.uiLink_StartX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_StartX.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_StartX.Location = new System.Drawing.Point(62, 3);
            this.uiLink_StartX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_StartX.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_StartX.Name = "uiLink_StartX";
            this.uiLink_StartX.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_StartX.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_StartX.Size = new System.Drawing.Size(191, 25);
            this.uiLink_StartX.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_StartX.StyleCustomMode = true;
            this.uiLink_StartX.TabIndex = 151;
            this.uiLink_StartX.Text = "uiLinkText1";
            this.uiLink_StartX.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.uiLink_StartX.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            this.uiLink_StartX.Chang += new Rex.UI.UILinkText.TexcHandle(this.uiLink_Chang);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(18, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 149;
            this.label4.Text = "起点-X:";
            // 
            // uiLink_EndY
            // 
            this.uiLink_EndY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_EndY.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_EndY.Location = new System.Drawing.Point(62, 92);
            this.uiLink_EndY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_EndY.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_EndY.Name = "uiLink_EndY";
            this.uiLink_EndY.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_EndY.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_EndY.Size = new System.Drawing.Size(191, 25);
            this.uiLink_EndY.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_EndY.StyleCustomMode = true;
            this.uiLink_EndY.TabIndex = 156;
            this.uiLink_EndY.Text = "uiLinkText2";
            this.uiLink_EndY.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.uiLink_EndY.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            this.uiLink_EndY.Chang += new Rex.UI.UILinkText.TexcHandle(this.uiLink_Chang);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 150;
            this.label1.Text = "起点-Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(18, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 153;
            this.label5.Text = "终点-X:";
            // 
            // uiLink_EndX
            // 
            this.uiLink_EndX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_EndX.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_EndX.Location = new System.Drawing.Point(62, 62);
            this.uiLink_EndX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_EndX.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_EndX.Name = "uiLink_EndX";
            this.uiLink_EndX.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_EndX.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_EndX.Size = new System.Drawing.Size(191, 25);
            this.uiLink_EndX.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_EndX.StyleCustomMode = true;
            this.uiLink_EndX.TabIndex = 155;
            this.uiLink_EndX.Text = "uiLinkText1";
            this.uiLink_EndX.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.uiLink_EndX.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            this.uiLink_EndX.Chang += new Rex.UI.UILinkText.TexcHandle(this.uiLink_Chang);
            // 
            // uiLink_StartY
            // 
            this.uiLink_StartY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_StartY.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_StartY.Location = new System.Drawing.Point(62, 33);
            this.uiLink_StartY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_StartY.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_StartY.Name = "uiLink_StartY";
            this.uiLink_StartY.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_StartY.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_StartY.Size = new System.Drawing.Size(191, 25);
            this.uiLink_StartY.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_StartY.StyleCustomMode = true;
            this.uiLink_StartY.TabIndex = 152;
            this.uiLink_StartY.Text = "uiLinkText2";
            this.uiLink_StartY.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.uiLink_StartY.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            this.uiLink_StartY.Chang += new Rex.UI.UILinkText.TexcHandle(this.uiLink_Chang);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 154;
            this.label2.Text = "终点-Y:";
            // 
            // uiLink_LinkRoi
            // 
            this.uiLink_LinkRoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_LinkRoi.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_LinkRoi.Location = new System.Drawing.Point(65, 61);
            this.uiLink_LinkRoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_LinkRoi.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_LinkRoi.Name = "uiLink_LinkRoi";
            this.uiLink_LinkRoi.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_LinkRoi.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_LinkRoi.Size = new System.Drawing.Size(191, 25);
            this.uiLink_LinkRoi.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_LinkRoi.StyleCustomMode = true;
            this.uiLink_LinkRoi.TabIndex = 157;
            this.uiLink_LinkRoi.Text = "uiLinkText1";
            this.uiLink_LinkRoi.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.uiLink_LinkRoi.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // uirb_LinkType
            // 
            this.uirb_LinkType.ColumnCount = 2;
            this.uirb_LinkType.Dock = System.Windows.Forms.DockStyle.Top;
            this.uirb_LinkType.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uirb_LinkType.Items.AddRange(new object[] {
            "手动输入",
            "链接区域"});
            this.uirb_LinkType.ItemSize = new System.Drawing.Size(100, 20);
            this.uirb_LinkType.Location = new System.Drawing.Point(3, 25);
            this.uirb_LinkType.Margin = new System.Windows.Forms.Padding(0);
            this.uirb_LinkType.MinimumSize = new System.Drawing.Size(1, 1);
            this.uirb_LinkType.Name = "uirb_LinkType";
            this.uirb_LinkType.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.uirb_LinkType.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uirb_LinkType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uirb_LinkType.Size = new System.Drawing.Size(265, 30);
            this.uirb_LinkType.StartPos = new System.Drawing.Point(40, -10);
            this.uirb_LinkType.Style = Rex.UI.UIStyle.Custom;
            this.uirb_LinkType.TabIndex = 153;
            this.uirb_LinkType.Text = null;
            this.uirb_LinkType.ValueChanged += new Rex.UI.UIRadioButtonGroup.OnValueChanged(this.uirb_LinkType_ValueChanged);
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.uirb_ModeType);
            this.uiTitlePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel3.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Location = new System.Drawing.Point(3, 71);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.Padding = new System.Windows.Forms.Padding(2, 25, 2, 2);
            this.uiTitlePanel3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel3.Size = new System.Drawing.Size(271, 57);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.StyleCustomMode = true;
            this.uiTitlePanel3.TabIndex = 161;
            this.uiTitlePanel3.Text = "创建形状";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTitlePanel3.TitleInterval = 5;
            // 
            // uirb_ModeType
            // 
            this.uirb_ModeType.ColumnCount = 2;
            this.uirb_ModeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uirb_ModeType.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uirb_ModeType.Items.AddRange(new object[] {
            "形状匹配",
            "灰度匹配"});
            this.uirb_ModeType.ItemSize = new System.Drawing.Size(100, 20);
            this.uirb_ModeType.Location = new System.Drawing.Point(2, 25);
            this.uirb_ModeType.Margin = new System.Windows.Forms.Padding(0);
            this.uirb_ModeType.MinimumSize = new System.Drawing.Size(1, 1);
            this.uirb_ModeType.Name = "uirb_ModeType";
            this.uirb_ModeType.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.uirb_ModeType.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uirb_ModeType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uirb_ModeType.Size = new System.Drawing.Size(267, 30);
            this.uirb_ModeType.StartPos = new System.Drawing.Point(40, -10);
            this.uirb_ModeType.Style = Rex.UI.UIStyle.Custom;
            this.uirb_ModeType.TabIndex = 0;
            this.uirb_ModeType.Text = null;
            this.uirb_ModeType.ValueChanged += new Rex.UI.UIRadioButtonGroup.OnValueChanged(this.uirb_ModeType_ValueChanged);
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.label19);
            this.uiTitlePanel2.Controls.Add(this.uiLink_Image);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(3, 3);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.Size = new System.Drawing.Size(271, 68);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.StyleCustomMode = true;
            this.uiTitlePanel2.TabIndex = 160;
            this.uiTitlePanel2.Text = "输入图像";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTitlePanel2.TitleInterval = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(10, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 17);
            this.label19.TabIndex = 3;
            this.label19.Text = "输入图像:";
            // 
            // uiLink_Image
            // 
            this.uiLink_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_Image.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_Image.Location = new System.Drawing.Point(65, 32);
            this.uiLink_Image.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_Image.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_Image.Name = "uiLink_Image";
            this.uiLink_Image.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_Image.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_Image.Size = new System.Drawing.Size(191, 25);
            this.uiLink_Image.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_Image.StyleCustomMode = true;
            this.uiLink_Image.TabIndex = 141;
            this.uiLink_Image.Text = "uiLinkText1";
            this.uiLink_Image.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.uiLink_Image.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.uiTitlePanel5);
            this.tabPage3.Controls.Add(this.uiTitlePanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(277, 444);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "参数设置";
            // 
            // uiTitlePanel5
            // 
            this.uiTitlePanel5.Controls.Add(this.uicb_SortType);
            this.uiTitlePanel5.Controls.Add(this.label12);
            this.uiTitlePanel5.Controls.Add(this.label11);
            this.uiTitlePanel5.Controls.Add(this.label10);
            this.uiTitlePanel5.Controls.Add(this.label8);
            this.uiTitlePanel5.Controls.Add(this.uidd_MaxOverl);
            this.uiTitlePanel5.Controls.Add(this.uidd_MatchNum);
            this.uiTitlePanel5.Controls.Add(this.uidd_GreedDeg);
            this.uiTitlePanel5.Controls.Add(this.uidd_MatchScore);
            this.uiTitlePanel5.Controls.Add(this.label7);
            this.uiTitlePanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel5.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel5.Location = new System.Drawing.Point(3, 206);
            this.uiTitlePanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel5.Name = "uiTitlePanel5";
            this.uiTitlePanel5.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel5.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel5.Size = new System.Drawing.Size(271, 235);
            this.uiTitlePanel5.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel5.StyleCustomMode = true;
            this.uiTitlePanel5.TabIndex = 162;
            this.uiTitlePanel5.Text = "模板参数";
            this.uiTitlePanel5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTitlePanel5.TitleInterval = 5;
            // 
            // uicb_SortType
            // 
            this.uicb_SortType.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_SortType.Items.AddRange(new object[] {
            "分数",
            "X",
            "Y"});
            this.uicb_SortType.Location = new System.Drawing.Point(74, 156);
            this.uicb_SortType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uicb_SortType.MaxDropDownItems = 5;
            this.uicb_SortType.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicb_SortType.Name = "uicb_SortType";
            this.uicb_SortType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicb_SortType.Radius = 2;
            this.uicb_SortType.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicb_SortType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicb_SortType.Size = new System.Drawing.Size(180, 23);
            this.uicb_SortType.Style = Rex.UI.UIStyle.Custom;
            this.uicb_SortType.StyleCustomMode = true;
            this.uicb_SortType.TabIndex = 137;
            this.uicb_SortType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uicb_SortType.Watermark = "选择排序方法";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(15, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 136;
            this.label12.Text = "最大重叠:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(15, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 135;
            this.label11.Text = "贪婪度数:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(15, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 134;
            this.label10.Text = "结果排序:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(15, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 133;
            this.label8.Text = "匹配个数:";
            // 
            // uidd_MaxOverl
            // 
            this.uidd_MaxOverl.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_MaxOverl.HasMaximum = true;
            this.uidd_MaxOverl.HasMinimum = true;
            this.uidd_MaxOverl.Location = new System.Drawing.Point(74, 127);
            this.uidd_MaxOverl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uidd_MaxOverl.Maximum = 1D;
            this.uidd_MaxOverl.Minimum = 0.1D;
            this.uidd_MaxOverl.MinimumSize = new System.Drawing.Size(100, 0);
            this.uidd_MaxOverl.Name = "uidd_MaxOverl";
            this.uidd_MaxOverl.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_MaxOverl.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_MaxOverl.Size = new System.Drawing.Size(180, 24);
            this.uidd_MaxOverl.Style = Rex.UI.UIStyle.LightBlue;
            this.uidd_MaxOverl.StyleCustomMode = true;
            this.uidd_MaxOverl.TabIndex = 132;
            this.uidd_MaxOverl.Text = null;
            this.uidd_MaxOverl.Value = 0.5D;
            // 
            // uidd_MatchNum
            // 
            this.uidd_MatchNum.Decimal = 0;
            this.uidd_MatchNum.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_MatchNum.HasMaximum = true;
            this.uidd_MatchNum.HasMinimum = true;
            this.uidd_MatchNum.Location = new System.Drawing.Point(74, 69);
            this.uidd_MatchNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uidd_MatchNum.Minimum = 1D;
            this.uidd_MatchNum.MinimumSize = new System.Drawing.Size(100, 0);
            this.uidd_MatchNum.Name = "uidd_MatchNum";
            this.uidd_MatchNum.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_MatchNum.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_MatchNum.Size = new System.Drawing.Size(180, 24);
            this.uidd_MatchNum.Step = 1D;
            this.uidd_MatchNum.Style = Rex.UI.UIStyle.LightBlue;
            this.uidd_MatchNum.StyleCustomMode = true;
            this.uidd_MatchNum.TabIndex = 132;
            this.uidd_MatchNum.Text = null;
            this.uidd_MatchNum.Value = 1D;
            // 
            // uidd_GreedDeg
            // 
            this.uidd_GreedDeg.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_GreedDeg.HasMaximum = true;
            this.uidd_GreedDeg.HasMinimum = true;
            this.uidd_GreedDeg.Location = new System.Drawing.Point(74, 98);
            this.uidd_GreedDeg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uidd_GreedDeg.Maximum = 1D;
            this.uidd_GreedDeg.Minimum = 0.1D;
            this.uidd_GreedDeg.MinimumSize = new System.Drawing.Size(100, 0);
            this.uidd_GreedDeg.Name = "uidd_GreedDeg";
            this.uidd_GreedDeg.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_GreedDeg.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_GreedDeg.Size = new System.Drawing.Size(180, 24);
            this.uidd_GreedDeg.Style = Rex.UI.UIStyle.LightBlue;
            this.uidd_GreedDeg.StyleCustomMode = true;
            this.uidd_GreedDeg.TabIndex = 132;
            this.uidd_GreedDeg.Text = null;
            this.uidd_GreedDeg.Value = 0.9D;
            // 
            // uidd_MatchScore
            // 
            this.uidd_MatchScore.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_MatchScore.HasMaximum = true;
            this.uidd_MatchScore.HasMinimum = true;
            this.uidd_MatchScore.Location = new System.Drawing.Point(74, 40);
            this.uidd_MatchScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uidd_MatchScore.Maximum = 1D;
            this.uidd_MatchScore.Minimum = 0.1D;
            this.uidd_MatchScore.MinimumSize = new System.Drawing.Size(100, 0);
            this.uidd_MatchScore.Name = "uidd_MatchScore";
            this.uidd_MatchScore.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_MatchScore.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_MatchScore.Size = new System.Drawing.Size(180, 24);
            this.uidd_MatchScore.Style = Rex.UI.UIStyle.LightBlue;
            this.uidd_MatchScore.StyleCustomMode = true;
            this.uidd_MatchScore.TabIndex = 131;
            this.uidd_MatchScore.Text = null;
            this.uidd_MatchScore.Value = 0.1D;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(15, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 130;
            this.label7.Text = "匹配分数:";
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uibt_Esc);
            this.uiTitlePanel1.Controls.Add(this.uibt_Enter);
            this.uiTitlePanel1.Controls.Add(this.uibt_Edit);
            this.uiTitlePanel1.Controls.Add(this.uibt_Study);
            this.uiTitlePanel1.Controls.Add(this.hWindow_HE1);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(3, 3);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(2, 27, 2, 1);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.Size = new System.Drawing.Size(271, 203);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.StyleCustomMode = true;
            this.uiTitlePanel1.TabIndex = 161;
            this.uiTitlePanel1.Text = "模板设置";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTitlePanel1.TitleInterval = 5;
            // 
            // uibt_Esc
            // 
            this.uibt_Esc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Esc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibt_Esc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Esc.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Esc.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Esc.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Esc.Location = new System.Drawing.Point(207, 86);
            this.uibt_Esc.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Esc.Name = "uibt_Esc";
            this.uibt_Esc.Size = new System.Drawing.Size(60, 26);
            this.uibt_Esc.Style = Rex.UI.UIStyle.Custom;
            this.uibt_Esc.Symbol = 61539;
            this.uibt_Esc.SymbolSize = 1;
            this.uibt_Esc.TabIndex = 149;
            this.uibt_Esc.Text = "取消";
            this.uibt_Esc.Click += new System.EventHandler(this.uibt_Press_Click);
            // 
            // uibt_Enter
            // 
            this.uibt_Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Enter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibt_Enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Enter.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Enter.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Enter.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Enter.Location = new System.Drawing.Point(207, 54);
            this.uibt_Enter.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Enter.Name = "uibt_Enter";
            this.uibt_Enter.Size = new System.Drawing.Size(60, 26);
            this.uibt_Enter.Style = Rex.UI.UIStyle.Custom;
            this.uibt_Enter.Symbol = 61539;
            this.uibt_Enter.SymbolSize = 1;
            this.uibt_Enter.TabIndex = 148;
            this.uibt_Enter.Text = "确定";
            this.uibt_Enter.Click += new System.EventHandler(this.uibt_Press_Click);
            // 
            // uibt_Edit
            // 
            this.uibt_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Edit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibt_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Edit.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Edit.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Edit.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Edit.Location = new System.Drawing.Point(207, 169);
            this.uibt_Edit.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Edit.Name = "uibt_Edit";
            this.uibt_Edit.Size = new System.Drawing.Size(60, 26);
            this.uibt_Edit.Style = Rex.UI.UIStyle.Custom;
            this.uibt_Edit.Symbol = 61539;
            this.uibt_Edit.SymbolSize = 1;
            this.uibt_Edit.TabIndex = 147;
            this.uibt_Edit.Text = "编辑";
            this.uibt_Edit.Click += new System.EventHandler(this.uibt_Press_Click);
            // 
            // uibt_Study
            // 
            this.uibt_Study.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Study.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibt_Study.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Study.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Study.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Study.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Study.Location = new System.Drawing.Point(207, 137);
            this.uibt_Study.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Study.Name = "uibt_Study";
            this.uibt_Study.Size = new System.Drawing.Size(60, 26);
            this.uibt_Study.Style = Rex.UI.UIStyle.Custom;
            this.uibt_Study.Symbol = 61539;
            this.uibt_Study.SymbolSize = 1;
            this.uibt_Study.TabIndex = 146;
            this.uibt_Study.Text = "学习";
            this.uibt_Study.Click += new System.EventHandler(this.uibt_Press_Click);
            // 
            // hWindow_HE1
            // 
            this.hWindow_HE1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hWindow_HE1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hWindow_HE1.BackgroundImage")));
            this.hWindow_HE1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hWindow_HE1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hWindow_HE1.Dock = System.Windows.Forms.DockStyle.Left;
            this.hWindow_HE1.DrawModel = false;
            this.hWindow_HE1.Image = null;
            this.hWindow_HE1.Location = new System.Drawing.Point(2, 27);
            this.hWindow_HE1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hWindow_HE1.Name = "hWindow_HE1";
            this.hWindow_HE1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hWindow_HE1.Size = new System.Drawing.Size(200, 175);
            this.hWindow_HE1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uiTitlePanel7);
            this.tabPage2.Controls.Add(this.uiTitlePanel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(277, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "显示设置";
            // 
            // uiTitlePanel7
            // 
            this.uiTitlePanel7.Controls.Add(this.uicb_Roi);
            this.uiTitlePanel7.Controls.Add(this.uicb_Area);
            this.uiTitlePanel7.Controls.Add(this.uicb_Result);
            this.uiTitlePanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel7.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel7.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel7.Location = new System.Drawing.Point(3, 205);
            this.uiTitlePanel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel7.Name = "uiTitlePanel7";
            this.uiTitlePanel7.Padding = new System.Windows.Forms.Padding(2, 25, 2, 2);
            this.uiTitlePanel7.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel7.Size = new System.Drawing.Size(271, 236);
            this.uiTitlePanel7.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel7.StyleCustomMode = true;
            this.uiTitlePanel7.TabIndex = 163;
            this.uiTitlePanel7.Text = "显示设置";
            this.uiTitlePanel7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTitlePanel7.TitleInterval = 5;
            // 
            // uicb_Roi
            // 
            this.uicb_Roi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Roi.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Roi.Location = new System.Drawing.Point(38, 42);
            this.uicb_Roi.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Roi.Name = "uicb_Roi";
            this.uicb_Roi.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Roi.Size = new System.Drawing.Size(144, 21);
            this.uicb_Roi.Style = Rex.UI.UIStyle.Custom;
            this.uicb_Roi.TabIndex = 13;
            this.uicb_Roi.Text = "是否显示ROI";
            // 
            // uicb_Area
            // 
            this.uicb_Area.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Area.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Area.Location = new System.Drawing.Point(38, 110);
            this.uicb_Area.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Area.Name = "uicb_Area";
            this.uicb_Area.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Area.Size = new System.Drawing.Size(144, 21);
            this.uicb_Area.Style = Rex.UI.UIStyle.Custom;
            this.uicb_Area.TabIndex = 14;
            this.uicb_Area.Text = "是否显示查找范围";
            // 
            // uicb_Result
            // 
            this.uicb_Result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Result.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Result.Location = new System.Drawing.Point(38, 76);
            this.uicb_Result.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Result.Name = "uicb_Result";
            this.uicb_Result.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Result.Size = new System.Drawing.Size(144, 21);
            this.uicb_Result.Style = Rex.UI.UIStyle.Custom;
            this.uicb_Result.TabIndex = 15;
            this.uicb_Result.Text = "是否显示结果";
            // 
            // uiTitlePanel6
            // 
            this.uiTitlePanel6.Controls.Add(this.uitb_R);
            this.uiTitlePanel6.Controls.Add(this.uitb_Y);
            this.uiTitlePanel6.Controls.Add(this.uitb_X);
            this.uiTitlePanel6.Controls.Add(this.label9);
            this.uiTitlePanel6.Controls.Add(this.label6);
            this.uiTitlePanel6.Controls.Add(this.label3);
            this.uiTitlePanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel6.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel6.Location = new System.Drawing.Point(3, 3);
            this.uiTitlePanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel6.Name = "uiTitlePanel6";
            this.uiTitlePanel6.Padding = new System.Windows.Forms.Padding(2, 25, 2, 2);
            this.uiTitlePanel6.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel6.Size = new System.Drawing.Size(271, 202);
            this.uiTitlePanel6.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel6.StyleCustomMode = true;
            this.uiTitlePanel6.TabIndex = 162;
            this.uiTitlePanel6.Text = "结果数据";
            this.uiTitlePanel6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTitlePanel6.TitleInterval = 5;
            // 
            // uitb_R
            // 
            this.uitb_R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitb_R.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uitb_R.Location = new System.Drawing.Point(54, 118);
            this.uitb_R.Margin = new System.Windows.Forms.Padding(0);
            this.uitb_R.Maximum = 2147483647D;
            this.uitb_R.Minimum = -2147483648D;
            this.uitb_R.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitb_R.Name = "uitb_R";
            this.uitb_R.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitb_R.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitb_R.Size = new System.Drawing.Size(191, 23);
            this.uitb_R.Style = Rex.UI.UIStyle.Custom;
            this.uitb_R.TabIndex = 149;
            this.uitb_R.Text = "0";
            // 
            // uitb_Y
            // 
            this.uitb_Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitb_Y.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uitb_Y.Location = new System.Drawing.Point(54, 88);
            this.uitb_Y.Margin = new System.Windows.Forms.Padding(0);
            this.uitb_Y.Maximum = 2147483647D;
            this.uitb_Y.Minimum = -2147483648D;
            this.uitb_Y.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitb_Y.Name = "uitb_Y";
            this.uitb_Y.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitb_Y.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitb_Y.Size = new System.Drawing.Size(191, 23);
            this.uitb_Y.Style = Rex.UI.UIStyle.Custom;
            this.uitb_Y.TabIndex = 148;
            this.uitb_Y.Text = "0";
            // 
            // uitb_X
            // 
            this.uitb_X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitb_X.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uitb_X.Location = new System.Drawing.Point(54, 58);
            this.uitb_X.Margin = new System.Windows.Forms.Padding(0);
            this.uitb_X.Maximum = 2147483647D;
            this.uitb_X.Minimum = -2147483648D;
            this.uitb_X.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitb_X.Name = "uitb_X";
            this.uitb_X.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitb_X.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitb_X.Size = new System.Drawing.Size(191, 23);
            this.uitb_X.Style = Rex.UI.UIStyle.Custom;
            this.uitb_X.TabIndex = 147;
            this.uitb_X.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(33, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 17);
            this.label9.TabIndex = 145;
            this.label9.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(32, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 144;
            this.label6.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 146;
            this.label3.Text = "R:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // mWindowH
            // 
            this.mWindowH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mWindowH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mWindowH.BackgroundImage")));
            this.mWindowH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mWindowH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mWindowH.Dock = System.Windows.Forms.DockStyle.Right;
            this.mWindowH.DrawModel = false;
            this.mWindowH.Image = null;
            this.mWindowH.Location = new System.Drawing.Point(285, 1);
            this.mWindowH.Margin = new System.Windows.Forms.Padding(5);
            this.mWindowH.Name = "mWindowH";
            this.mWindowH.Padding = new System.Windows.Forms.Padding(3);
            this.mWindowH.Size = new System.Drawing.Size(560, 474);
            this.mWindowH.TabIndex = 7;
            // 
            // MatchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MatchingForm";
            this.Load += new System.EventHandler(this.MatchingForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.uiTitlePanel4.ResumeLayout(false);
            this.uiLink_Panel.ResumeLayout(false);
            this.uiLink_Panel.PerformLayout();
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.uiTitlePanel5.ResumeLayout(false);
            this.uiTitlePanel5.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.uiTitlePanel7.ResumeLayout(false);
            this.uiTitlePanel6.ResumeLayout(false);
            this.uiTitlePanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.CTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Rex.UI.UICheckBox uicb_Result;
        private Rex.UI.UICheckBox uicb_Area;
        private Rex.UI.UICheckBox uicb_Roi;
        private System.Windows.Forms.Button button1;
        private RexView.HWindow_HE mWindowH;
        private System.Windows.Forms.TabPage tabPage3;
        private Rex.UI.UITitlePanel uiTitlePanel4;
        private Rex.UI.UILinkText uiLink_LinkRoi;
        private Rex.UI.UILinkText uiLink_EndY;
        private Rex.UI.UIRadioButtonGroup uirb_LinkType;
        private Rex.UI.UILinkText uiLink_EndX;
        private System.Windows.Forms.Label label2;
        private Rex.UI.UILinkText uiLink_StartY;
        private System.Windows.Forms.Label label5;
        private Rex.UI.UILinkText uiLink_StartX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private Rex.UI.UIRadioButtonGroup uirb_ModeType;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private System.Windows.Forms.Label label19;
        private Rex.UI.UILinkText uiLink_Image;
        private Rex.UI.UITitlePanel uiTitlePanel5;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private RexView.HWindow_HE hWindow_HE1;
        private Rex.UI.UISymbolButton uibt_Edit;
        private Rex.UI.UISymbolButton uibt_Study;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private Rex.UI.UIDoubleUpDownB uidd_MaxOverl;
        private Rex.UI.UIDoubleUpDownB uidd_MatchNum;
        private Rex.UI.UIDoubleUpDownB uidd_GreedDeg;
        private Rex.UI.UIDoubleUpDownB uidd_MatchScore;
        private System.Windows.Forms.Label label7;
        private Rex.UI.UIComboBox uicb_SortType;
        private Rex.UI.UITitlePanel uiTitlePanel7;
        private Rex.UI.UITitlePanel uiTitlePanel6;
        private Rex.UI.UISymbolButton uibt_Esc;
        private Rex.UI.UISymbolButton uibt_Enter;
        private Rex.UI.UIPanel uiLink_Panel;
        private Rex.UI.UITextBox uitb_R;
        private Rex.UI.UITextBox uitb_Y;
        private Rex.UI.UITextBox uitb_X;
    }
}