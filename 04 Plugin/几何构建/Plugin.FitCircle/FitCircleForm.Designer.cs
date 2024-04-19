namespace Plugin.FitCircle
{
    partial class FitCircleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FitCircleForm));
            this.mWindow = new RexView.HWindow_Fit();
            this.tabControl1 = new Rex.CTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.tb_Radius = new RexControl.CTextBox();
            this.tb_CoreY = new RexControl.CTextBox();
            this.tb_CoreX = new RexControl.CTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.ui_P3Y = new Rex.UI.UILinkText();
            this.ui_P3X = new Rex.UI.UILinkText();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ui_P2Y = new Rex.UI.UILinkText();
            this.ui_P2X = new Rex.UI.UILinkText();
            this.ui_P1Y = new Rex.UI.UILinkText();
            this.ui_P1X = new Rex.UI.UILinkText();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.uipl_SetInPut = new Rex.UI.UITitlePanel();
            this.ui_Image = new Rex.UI.UILinkData();
            this.label34 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
            this.uipl_SetInPut.SuspendLayout();
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
            // uitb_Remark
            // 
            this.uitb_Remark.TextChanged += new System.EventHandler(this.tb_Describle_TextChanged);
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
            // mWindow
            // 
            this.mWindow.BackColor = System.Drawing.Color.Transparent;
            this.mWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.mWindow.ForeColor = System.Drawing.SystemColors.Control;
            this.mWindow.Image = null;
            this.mWindow.Location = new System.Drawing.Point(285, 1);
            this.mWindow.Name = "mWindow";
            this.mWindow.Padding = new System.Windows.Forms.Padding(3);
            this.mWindow.Size = new System.Drawing.Size(560, 474);
            this.mWindow.TabIndex = 2;
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
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(285, 474);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.uiTitlePanel2);
            this.tabPage1.Controls.Add(this.uiTitlePanel3);
            this.tabPage1.Controls.Add(this.uipl_SetInPut);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(277, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.tb_Radius);
            this.uiTitlePanel2.Controls.Add(this.tb_CoreY);
            this.uiTitlePanel2.Controls.Add(this.tb_CoreX);
            this.uiTitlePanel2.Controls.Add(this.label1);
            this.uiTitlePanel2.Controls.Add(this.label4);
            this.uiTitlePanel2.Controls.Add(this.label9);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(0, 315);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.Size = new System.Drawing.Size(277, 129);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.StyleCustomMode = true;
            this.uiTitlePanel2.TabIndex = 122;
            this.uiTitlePanel2.Text = "输出数据";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Radius
            // 
            this.tb_Radius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tb_Radius.DefaultText = "";
            this.tb_Radius.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Radius.Location = new System.Drawing.Point(73, 100);
            this.tb_Radius.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Radius.MaximumSize = new System.Drawing.Size(400, 22);
            this.tb_Radius.MinimumSize = new System.Drawing.Size(20, 22);
            this.tb_Radius.Name = "tb_Radius";
            this.tb_Radius.PasswordChar = false;
            this.tb_Radius.Size = new System.Drawing.Size(192, 22);
            this.tb_Radius.TabIndex = 143;
            this.tb_Radius.TextStr = "";
            // 
            // tb_CoreY
            // 
            this.tb_CoreY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tb_CoreY.DefaultText = "";
            this.tb_CoreY.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_CoreY.Location = new System.Drawing.Point(73, 70);
            this.tb_CoreY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_CoreY.MaximumSize = new System.Drawing.Size(400, 22);
            this.tb_CoreY.MinimumSize = new System.Drawing.Size(20, 22);
            this.tb_CoreY.Name = "tb_CoreY";
            this.tb_CoreY.PasswordChar = false;
            this.tb_CoreY.Size = new System.Drawing.Size(192, 22);
            this.tb_CoreY.TabIndex = 142;
            this.tb_CoreY.TextStr = "";
            // 
            // tb_CoreX
            // 
            this.tb_CoreX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tb_CoreX.DefaultText = "";
            this.tb_CoreX.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_CoreX.Location = new System.Drawing.Point(73, 40);
            this.tb_CoreX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_CoreX.MaximumSize = new System.Drawing.Size(400, 22);
            this.tb_CoreX.MinimumSize = new System.Drawing.Size(20, 22);
            this.tb_CoreX.Name = "tb_CoreX";
            this.tb_CoreX.PasswordChar = false;
            this.tb_CoreX.Size = new System.Drawing.Size(192, 22);
            this.tb_CoreX.TabIndex = 141;
            this.tb_CoreX.TextStr = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(32, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 140;
            this.label1.Text = "半径R:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(32, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 138;
            this.label4.Text = "中心X:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(33, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 139;
            this.label9.Text = "中心Y:";
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.ui_P3Y);
            this.uiTitlePanel3.Controls.Add(this.ui_P3X);
            this.uiTitlePanel3.Controls.Add(this.label3);
            this.uiTitlePanel3.Controls.Add(this.label5);
            this.uiTitlePanel3.Controls.Add(this.ui_P2Y);
            this.uiTitlePanel3.Controls.Add(this.ui_P2X);
            this.uiTitlePanel3.Controls.Add(this.ui_P1Y);
            this.uiTitlePanel3.Controls.Add(this.ui_P1X);
            this.uiTitlePanel3.Controls.Add(this.label10);
            this.uiTitlePanel3.Controls.Add(this.label11);
            this.uiTitlePanel3.Controls.Add(this.label12);
            this.uiTitlePanel3.Controls.Add(this.label13);
            this.uiTitlePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel3.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Location = new System.Drawing.Point(0, 91);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel3.Size = new System.Drawing.Size(277, 224);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.StyleCustomMode = true;
            this.uiTitlePanel3.TabIndex = 123;
            this.uiTitlePanel3.Text = "构建参数";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ui_P3Y
            // 
            this.ui_P3Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ui_P3Y.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ui_P3Y.Location = new System.Drawing.Point(73, 186);
            this.ui_P3Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ui_P3Y.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_P3Y.Name = "ui_P3Y";
            this.ui_P3Y.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.ui_P3Y.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ui_P3Y.Size = new System.Drawing.Size(192, 25);
            this.ui_P3Y.Style = Rex.UI.UIStyle.Custom;
            this.ui_P3Y.StyleCustomMode = true;
            this.ui_P3Y.TabIndex = 147;
            this.ui_P3Y.Text = "uiLinkText2";
            this.ui_P3Y.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.ui_P3Y.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // ui_P3X
            // 
            this.ui_P3X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ui_P3X.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ui_P3X.Location = new System.Drawing.Point(73, 157);
            this.ui_P3X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ui_P3X.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_P3X.Name = "ui_P3X";
            this.ui_P3X.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.ui_P3X.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ui_P3X.Size = new System.Drawing.Size(192, 25);
            this.ui_P3X.Style = Rex.UI.UIStyle.Custom;
            this.ui_P3X.StyleCustomMode = true;
            this.ui_P3X.TabIndex = 146;
            this.ui_P3X.Text = "uiLinkText1";
            this.ui_P3X.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.ui_P3X.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(37, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 144;
            this.label3.Text = "点3X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(38, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 145;
            this.label5.Text = "点3Y:";
            // 
            // ui_P2Y
            // 
            this.ui_P2Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ui_P2Y.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ui_P2Y.Location = new System.Drawing.Point(73, 128);
            this.ui_P2Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ui_P2Y.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_P2Y.Name = "ui_P2Y";
            this.ui_P2Y.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.ui_P2Y.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ui_P2Y.Size = new System.Drawing.Size(192, 25);
            this.ui_P2Y.Style = Rex.UI.UIStyle.Custom;
            this.ui_P2Y.StyleCustomMode = true;
            this.ui_P2Y.TabIndex = 143;
            this.ui_P2Y.Text = "uiLinkText2";
            this.ui_P2Y.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.ui_P2Y.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // ui_P2X
            // 
            this.ui_P2X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ui_P2X.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ui_P2X.Location = new System.Drawing.Point(73, 99);
            this.ui_P2X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ui_P2X.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_P2X.Name = "ui_P2X";
            this.ui_P2X.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.ui_P2X.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ui_P2X.Size = new System.Drawing.Size(192, 25);
            this.ui_P2X.Style = Rex.UI.UIStyle.Custom;
            this.ui_P2X.StyleCustomMode = true;
            this.ui_P2X.TabIndex = 142;
            this.ui_P2X.Text = "uiLinkText1";
            this.ui_P2X.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.ui_P2X.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // ui_P1Y
            // 
            this.ui_P1Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ui_P1Y.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ui_P1Y.Location = new System.Drawing.Point(73, 70);
            this.ui_P1Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ui_P1Y.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_P1Y.Name = "ui_P1Y";
            this.ui_P1Y.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.ui_P1Y.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ui_P1Y.Size = new System.Drawing.Size(192, 25);
            this.ui_P1Y.Style = Rex.UI.UIStyle.Custom;
            this.ui_P1Y.StyleCustomMode = true;
            this.ui_P1Y.TabIndex = 135;
            this.ui_P1Y.Text = "uiLinkText2";
            this.ui_P1Y.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.ui_P1Y.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // ui_P1X
            // 
            this.ui_P1X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ui_P1X.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ui_P1X.Location = new System.Drawing.Point(73, 41);
            this.ui_P1X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ui_P1X.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_P1X.Name = "ui_P1X";
            this.ui_P1X.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.ui_P1X.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ui_P1X.Size = new System.Drawing.Size(192, 25);
            this.ui_P1X.Style = Rex.UI.UIStyle.Custom;
            this.ui_P1X.StyleCustomMode = true;
            this.ui_P1X.TabIndex = 124;
            this.ui_P1X.Text = "uiLinkText1";
            this.ui_P1X.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.ui_P1X.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(37, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 140;
            this.label10.Text = "点2X:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(38, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 141;
            this.label11.Text = "点2Y:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(37, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 17);
            this.label12.TabIndex = 138;
            this.label12.Text = "点1X:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(38, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 139;
            this.label13.Text = "点1Y:";
            // 
            // uipl_SetInPut
            // 
            this.uipl_SetInPut.Controls.Add(this.ui_Image);
            this.uipl_SetInPut.Controls.Add(this.label34);
            this.uipl_SetInPut.Dock = System.Windows.Forms.DockStyle.Top;
            this.uipl_SetInPut.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uipl_SetInPut.ForeColor = System.Drawing.Color.White;
            this.uipl_SetInPut.Location = new System.Drawing.Point(0, 0);
            this.uipl_SetInPut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uipl_SetInPut.MinimumSize = new System.Drawing.Size(1, 1);
            this.uipl_SetInPut.Name = "uipl_SetInPut";
            this.uipl_SetInPut.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uipl_SetInPut.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uipl_SetInPut.Size = new System.Drawing.Size(277, 91);
            this.uipl_SetInPut.Style = Rex.UI.UIStyle.Custom;
            this.uipl_SetInPut.StyleCustomMode = true;
            this.uipl_SetInPut.TabIndex = 120;
            this.uipl_SetInPut.Text = "图像设置";
            this.uipl_SetInPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uipl_SetInPut.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ui_Image
            // 
            this.ui_Image.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ui_Image.Location = new System.Drawing.Point(73, 46);
            this.ui_Image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ui_Image.MinimumSize = new System.Drawing.Size(100, 0);
            this.ui_Image.Name = "ui_Image";
            this.ui_Image.Radius = 0;
            this.ui_Image.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.ui_Image.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ui_Image.Size = new System.Drawing.Size(192, 25);
            this.ui_Image.StyleCustomMode = true;
            this.ui_Image.TabIndex = 135;
            this.ui_Image.Tag = "九点标定";
            this.ui_Image.Text = "九点标定";
            this.ui_Image.BtnAdd += new Rex.UI.UILinkData.BtnAddHandle(this.uiLink_BtnAdd);
            this.ui_Image.BtnDec += new Rex.UI.UILinkData.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label34.Location = new System.Drawing.Point(16, 50);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 17);
            this.label34.TabIndex = 3;
            this.label34.Text = "输入图像:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(277, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "显示设置";
            // 
            // FitCircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FitCircleForm";
            this.Load += new System.EventHandler(this.ModForm_Load);
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
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel3.PerformLayout();
            this.uipl_SetInPut.ResumeLayout(false);
            this.uipl_SetInPut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RexView.HWindow_Fit mWindow;
        private Rex.CTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private Rex.UI.UILinkText ui_P2Y;
        private Rex.UI.UILinkText ui_P2X;
        private Rex.UI.UILinkText ui_P1Y;
        private Rex.UI.UILinkText ui_P1X;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Rex.UI.UITitlePanel uipl_SetInPut;
        private Rex.UI.UILinkData ui_Image;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TabPage tabPage2;
        private Rex.UI.UILinkText ui_P3Y;
        private Rex.UI.UILinkText ui_P3X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private RexControl.CTextBox tb_Radius;
        private RexControl.CTextBox tb_CoreY;
        private RexControl.CTextBox tb_CoreX;
    }
}