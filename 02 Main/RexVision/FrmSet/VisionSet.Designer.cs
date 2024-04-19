namespace RexVision
{
    partial class VisionSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisionSet));
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.uiLink_ProjFile = new Rex.UI.UILinkPath();
            this.uiSymbolLabel2 = new Rex.UI.UISymbolLabel();
            this.ui_NetInterval = new RexControl.CNumericUpDown();
            this.uiSymbolLabel1 = new Rex.UI.UISymbolLabel();
            this.ui_RunInterval = new RexControl.CNumericUpDown();
            this.ui_OpenStart = new Rex.UI.UICheckBox();
            this.ui_AutoRun = new Rex.UI.UICheckBox();
            this.ui_StartLoadProj = new Rex.UI.UICheckBox();
            this.uiPanel1 = new Rex.UI.UIPanel();
            this.uiPanel2 = new Rex.UI.UIPanel();
            this.uibt_Esc = new Rex.UI.UIButton();
            this.uibt_Enter = new Rex.UI.UIButton();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.ui_AutoSaveProj = new Rex.UI.UICheckBox();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.ui_LogSet = new Rex.UI.UIComboBox();
            this.ui_LogDay = new RexControl.CNumericUpDown();
            this.uiSymbolLabel4 = new Rex.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Rex.UI.UISymbolLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbox_Icon.BackgroundImage")));
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(498, 32);
            // 
            // titlelabel
            // 
            this.titlelabel.Size = new System.Drawing.Size(74, 21);
            this.titlelabel.Text = "系统参数";
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uiLink_ProjFile);
            this.uiTitlePanel1.Controls.Add(this.uiSymbolLabel2);
            this.uiTitlePanel1.Controls.Add(this.ui_NetInterval);
            this.uiTitlePanel1.Controls.Add(this.uiSymbolLabel1);
            this.uiTitlePanel1.Controls.Add(this.ui_RunInterval);
            this.uiTitlePanel1.Controls.Add(this.ui_OpenStart);
            this.uiTitlePanel1.Controls.Add(this.ui_AutoRun);
            this.uiTitlePanel1.Controls.Add(this.ui_StartLoadProj);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiTitlePanel1.Location = new System.Drawing.Point(3, 3);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(3, 35, 3, 3);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.RectColor = System.Drawing.Color.Gray;
            this.uiTitlePanel1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiTitlePanel1.ShowCollapse = true;
            this.uiTitlePanel1.Size = new System.Drawing.Size(492, 200);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.StyleCustomMode = true;
            this.uiTitlePanel1.TabIndex = 1;
            this.uiTitlePanel1.Text = "基本设置";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            // 
            // uiLink_ProjFile
            // 
            this.uiLink_ProjFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_ProjFile.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_ProjFile.Location = new System.Drawing.Point(52, 113);
            this.uiLink_ProjFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_ProjFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_ProjFile.Name = "uiLink_ProjFile";
            this.uiLink_ProjFile.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_ProjFile.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_ProjFile.Size = new System.Drawing.Size(417, 24);
            this.uiLink_ProjFile.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_ProjFile.StyleCustomMode = true;
            this.uiLink_ProjFile.TabIndex = 9;
            this.uiLink_ProjFile.Text = "uiLinkPath1";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(25, 169);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(131, 20);
            this.uiSymbolLabel2.Style = Rex.UI.UIStyle.Custom;
            this.uiSymbolLabel2.StyleCustomMode = true;
            this.uiSymbolLabel2.Symbol = 57594;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolLabel2.TabIndex = 7;
            this.uiSymbolLabel2.Text = "数据通讯收发间隔";
            // 
            // ui_NetInterval
            // 
            this.ui_NetInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ui_NetInterval.DecimalPlaces = 0;
            this.ui_NetInterval.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ui_NetInterval.Incremeent = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ui_NetInterval.Location = new System.Drawing.Point(166, 166);
            this.ui_NetInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_NetInterval.MaximumSize = new System.Drawing.Size(300, 26);
            this.ui_NetInterval.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ui_NetInterval.MinimumSize = new System.Drawing.Size(50, 26);
            this.ui_NetInterval.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ui_NetInterval.Name = "ui_NetInterval";
            this.ui_NetInterval.Size = new System.Drawing.Size(111, 26);
            this.ui_NetInterval.TabIndex = 6;
            this.ui_NetInterval.Value = 100D;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(25, 143);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(131, 20);
            this.uiSymbolLabel1.Style = Rex.UI.UIStyle.Custom;
            this.uiSymbolLabel1.StyleCustomMode = true;
            this.uiSymbolLabel1.Symbol = 57389;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolLabel1.TabIndex = 5;
            this.uiSymbolLabel1.Text = "连续运行时间间隔";
            // 
            // ui_RunInterval
            // 
            this.ui_RunInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ui_RunInterval.DecimalPlaces = 0;
            this.ui_RunInterval.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ui_RunInterval.Incremeent = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ui_RunInterval.Location = new System.Drawing.Point(166, 140);
            this.ui_RunInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_RunInterval.MaximumSize = new System.Drawing.Size(300, 26);
            this.ui_RunInterval.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ui_RunInterval.MinimumSize = new System.Drawing.Size(50, 26);
            this.ui_RunInterval.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ui_RunInterval.Name = "ui_RunInterval";
            this.ui_RunInterval.Size = new System.Drawing.Size(111, 26);
            this.ui_RunInterval.TabIndex = 4;
            this.ui_RunInterval.Value = 100D;
            // 
            // ui_OpenStart
            // 
            this.ui_OpenStart.BackColor = System.Drawing.Color.Transparent;
            this.ui_OpenStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_OpenStart.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ui_OpenStart.Location = new System.Drawing.Point(25, 43);
            this.ui_OpenStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_OpenStart.Name = "ui_OpenStart";
            this.ui_OpenStart.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ui_OpenStart.Size = new System.Drawing.Size(150, 18);
            this.ui_OpenStart.Style = Rex.UI.UIStyle.Custom;
            this.ui_OpenStart.StyleCustomMode = true;
            this.ui_OpenStart.TabIndex = 3;
            this.ui_OpenStart.Text = "开机自启";
            // 
            // ui_AutoRun
            // 
            this.ui_AutoRun.BackColor = System.Drawing.Color.Transparent;
            this.ui_AutoRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_AutoRun.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ui_AutoRun.Location = new System.Drawing.Point(25, 91);
            this.ui_AutoRun.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_AutoRun.Name = "ui_AutoRun";
            this.ui_AutoRun.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ui_AutoRun.Size = new System.Drawing.Size(150, 18);
            this.ui_AutoRun.Style = Rex.UI.UIStyle.Custom;
            this.ui_AutoRun.StyleCustomMode = true;
            this.ui_AutoRun.TabIndex = 1;
            this.ui_AutoRun.Text = "启动后自动开始执行";
            // 
            // ui_StartLoadProj
            // 
            this.ui_StartLoadProj.BackColor = System.Drawing.Color.Transparent;
            this.ui_StartLoadProj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_StartLoadProj.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ui_StartLoadProj.Location = new System.Drawing.Point(25, 67);
            this.ui_StartLoadProj.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_StartLoadProj.Name = "ui_StartLoadProj";
            this.ui_StartLoadProj.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ui_StartLoadProj.Size = new System.Drawing.Size(150, 18);
            this.ui_StartLoadProj.Style = Rex.UI.UIStyle.Custom;
            this.ui_StartLoadProj.StyleCustomMode = true;
            this.ui_StartLoadProj.TabIndex = 0;
            this.ui_StartLoadProj.Text = "启动时自动加载项目";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiPanel2);
            this.uiPanel1.Controls.Add(this.uiTitlePanel3);
            this.uiPanel1.Controls.Add(this.uiTitlePanel2);
            this.uiPanel1.Controls.Add(this.uiTitlePanel1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 32);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.uiPanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiPanel1.Size = new System.Drawing.Size(498, 466);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = null;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uibt_Esc);
            this.uiPanel2.Controls.Add(this.uibt_Enter);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiPanel2.Location = new System.Drawing.Point(3, 423);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiPanel2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
            this.uiPanel2.Size = new System.Drawing.Size(492, 40);
            this.uiPanel2.TabIndex = 4;
            this.uiPanel2.Text = null;
            // 
            // uibt_Esc
            // 
            this.uibt_Esc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Esc.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_Esc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Esc.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Esc.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Esc.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Esc.Location = new System.Drawing.Point(383, 7);
            this.uibt_Esc.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Esc.Name = "uibt_Esc";
            this.uibt_Esc.Size = new System.Drawing.Size(100, 30);
            this.uibt_Esc.TabIndex = 1;
            this.uibt_Esc.Text = "取消";
            this.uibt_Esc.Click += new System.EventHandler(this.uibt_Esc_Click);
            // 
            // uibt_Enter
            // 
            this.uibt_Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Enter.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_Enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Enter.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Enter.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Enter.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Enter.Location = new System.Drawing.Point(273, 7);
            this.uibt_Enter.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Enter.Name = "uibt_Enter";
            this.uibt_Enter.Size = new System.Drawing.Size(100, 30);
            this.uibt_Enter.TabIndex = 0;
            this.uibt_Enter.Text = "确定";
            this.uibt_Enter.Click += new System.EventHandler(this.uibt_Enter_Click);
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.ui_AutoSaveProj);
            this.uiTitlePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiTitlePanel3.Location = new System.Drawing.Point(3, 312);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.Padding = new System.Windows.Forms.Padding(3, 35, 3, 3);
            this.uiTitlePanel3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel3.RectColor = System.Drawing.Color.Gray;
            this.uiTitlePanel3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiTitlePanel3.ShowCollapse = true;
            this.uiTitlePanel3.Size = new System.Drawing.Size(492, 151);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.StyleCustomMode = true;
            this.uiTitlePanel3.TabIndex = 3;
            this.uiTitlePanel3.Text = "其他设置";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel3.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            // 
            // ui_AutoSaveProj
            // 
            this.ui_AutoSaveProj.BackColor = System.Drawing.Color.Transparent;
            this.ui_AutoSaveProj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_AutoSaveProj.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ui_AutoSaveProj.Location = new System.Drawing.Point(25, 38);
            this.ui_AutoSaveProj.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_AutoSaveProj.Name = "ui_AutoSaveProj";
            this.ui_AutoSaveProj.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ui_AutoSaveProj.Size = new System.Drawing.Size(192, 18);
            this.ui_AutoSaveProj.Style = Rex.UI.UIStyle.Custom;
            this.ui_AutoSaveProj.StyleCustomMode = true;
            this.ui_AutoSaveProj.TabIndex = 2;
            this.ui_AutoSaveProj.Text = "退出程序时自动保存当前布局";
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.ui_LogSet);
            this.uiTitlePanel2.Controls.Add(this.ui_LogDay);
            this.uiTitlePanel2.Controls.Add(this.uiSymbolLabel4);
            this.uiTitlePanel2.Controls.Add(this.uiSymbolLabel3);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiTitlePanel2.Location = new System.Drawing.Point(3, 203);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(3, 35, 3, 3);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.RectColor = System.Drawing.Color.Gray;
            this.uiTitlePanel2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiTitlePanel2.ShowCollapse = true;
            this.uiTitlePanel2.Size = new System.Drawing.Size(492, 109);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.StyleCustomMode = true;
            this.uiTitlePanel2.TabIndex = 2;
            this.uiTitlePanel2.Text = "日志设置";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            // 
            // ui_LogSet
            // 
            this.ui_LogSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ui_LogSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ui_LogSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ui_LogSet.Items.AddRange(new object[] {
            "Debug",
            "Info",
            "Warn",
            "Error",
            "Fatal"});
            this.ui_LogSet.Location = new System.Drawing.Point(166, 39);
            this.ui_LogSet.Margin = new System.Windows.Forms.Padding(0);
            this.ui_LogSet.MinimumSize = new System.Drawing.Size(63, 0);
            this.ui_LogSet.Name = "ui_LogSet";
            this.ui_LogSet.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.ui_LogSet.Radius = 2;
            this.ui_LogSet.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.ui_LogSet.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ui_LogSet.Size = new System.Drawing.Size(111, 23);
            this.ui_LogSet.Style = Rex.UI.UIStyle.Custom;
            this.ui_LogSet.StyleCustomMode = true;
            this.ui_LogSet.TabIndex = 11;
            this.ui_LogSet.Text = "Debug";
            this.ui_LogSet.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ui_LogDay
            // 
            this.ui_LogDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ui_LogDay.DecimalPlaces = 0;
            this.ui_LogDay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ui_LogDay.Incremeent = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ui_LogDay.Location = new System.Drawing.Point(162, 66);
            this.ui_LogDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_LogDay.MaximumSize = new System.Drawing.Size(300, 26);
            this.ui_LogDay.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ui_LogDay.MinimumSize = new System.Drawing.Size(50, 26);
            this.ui_LogDay.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ui_LogDay.Name = "ui_LogDay";
            this.ui_LogDay.Size = new System.Drawing.Size(115, 26);
            this.ui_LogDay.TabIndex = 10;
            this.ui_LogDay.Value = 100D;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(25, 69);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(76, 20);
            this.uiSymbolLabel4.Style = Rex.UI.UIStyle.Custom;
            this.uiSymbolLabel4.StyleCustomMode = true;
            this.uiSymbolLabel4.Symbol = 61953;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolLabel4.TabIndex = 9;
            this.uiSymbolLabel4.Text = "保存天数";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(25, 42);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(76, 20);
            this.uiSymbolLabel3.Style = Rex.UI.UIStyle.Custom;
            this.uiSymbolLabel3.StyleCustomMode = true;
            this.uiSymbolLabel3.Symbol = 61508;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolLabel3.TabIndex = 8;
            this.uiSymbolLabel3.Text = "日志等级";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VisionSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(498, 498);
            this.Controls.Add(this.uiPanel1);
            this.Name = "VisionSet";
            this.Title = "系统参数";
            this.TitleSize = new System.Drawing.Size(74, 21);
            this.Load += new System.EventHandler(this.VisionSet_Load);
            this.Controls.SetChildIndex(this.titlepanel, 0);
            this.Controls.SetChildIndex(this.uiPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.UI.UIDataGridView dgv_SolList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Rex.UI.UIButton bt_Enter;
        private Rex.UI.UIButton bt_Cancel;
        private Rex.UI.UIButton bt_SelectOpen;
        private Rex.UI.UIButton bt_StartSol;
        private Rex.UI.UIButton bt_AddNow;
        private Rex.UI.UIButton bt_AddExt;
        private Rex.UI.UIButton bt_Delete;
        private Rex.UI.UIButton bt_Down;
        private Rex.UI.UIButton bt_Up;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private Rex.UI.UISymbolLabel uiSymbolLabel2;
        private RexControl.CNumericUpDown ui_NetInterval;
        private Rex.UI.UISymbolLabel uiSymbolLabel1;
        private RexControl.CNumericUpDown ui_RunInterval;
        private Rex.UI.UICheckBox ui_OpenStart;
        private Rex.UI.UICheckBox ui_AutoRun;
        private Rex.UI.UICheckBox ui_StartLoadProj;
        private Rex.UI.UIPanel uiPanel1;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private Rex.UI.UICheckBox ui_AutoSaveProj;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private Rex.UI.UIComboBox ui_LogSet;
        private RexControl.CNumericUpDown ui_LogDay;
        private Rex.UI.UISymbolLabel uiSymbolLabel4;
        private Rex.UI.UISymbolLabel uiSymbolLabel3;
        private Rex.UI.UILinkPath uiLink_ProjFile;
        private Rex.UI.UIPanel uiPanel2;
        private Rex.UI.UIButton uibt_Esc;
        private Rex.UI.UIButton uibt_Enter;
    }
}