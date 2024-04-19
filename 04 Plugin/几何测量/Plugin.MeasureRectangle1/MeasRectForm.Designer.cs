namespace Plugin.MeasRect
{
    partial class MeasRectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeasRectForm));
            this.tabControl1 = new Rex.CTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.uidd_EndX = new Rex.UI.UIDoubleUpDownB();
            this.uiLabel2 = new Rex.UI.UILabel();
            this.uidd_StartX = new Rex.UI.UIDoubleUpDownB();
            this.uidd_EndY = new Rex.UI.UIDoubleUpDownB();
            this.uiLabel3 = new Rex.UI.UILabel();
            this.uiLabel6 = new Rex.UI.UILabel();
            this.uidd_StartY = new Rex.UI.UIDoubleUpDownB();
            this.uiLabel4 = new Rex.UI.UILabel();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.RexMeas1 = new VisionCore.RexMeas();
            this.uiLabel1 = new Rex.UI.UILabel();
            this.label17 = new Rex.UI.UILabel();
            this.label14 = new Rex.UI.UILabel();
            this.label12 = new Rex.UI.UILabel();
            this.label11 = new Rex.UI.UILabel();
            this.label4 = new Rex.UI.UILabel();
            this.label2 = new Rex.UI.UILabel();
            this.uiLink_Coord = new Rex.UI.UILinkText();
            this.uiLabel5 = new Rex.UI.UILabel();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.uiLink_Image = new Rex.UI.UILinkText();
            this.label19 = new Rex.UI.UILabel();
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
            this.uiTitlePanel3.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(280, 474);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uiTitlePanel3);
            this.tabPage1.Controls.Add(this.uiTitlePanel1);
            this.tabPage1.Controls.Add(this.uiTitlePanel2);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(272, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.uidd_EndX);
            this.uiTitlePanel3.Controls.Add(this.uiLabel2);
            this.uiTitlePanel3.Controls.Add(this.uidd_StartX);
            this.uiTitlePanel3.Controls.Add(this.uidd_EndY);
            this.uiTitlePanel3.Controls.Add(this.uiLabel3);
            this.uiTitlePanel3.Controls.Add(this.uiLabel6);
            this.uiTitlePanel3.Controls.Add(this.uidd_StartY);
            this.uiTitlePanel3.Controls.Add(this.uiLabel4);
            this.uiTitlePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel3.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Location = new System.Drawing.Point(0, 335);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel3.Size = new System.Drawing.Size(272, 109);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.StyleCustomMode = true;
            this.uiTitlePanel3.TabIndex = 162;
            this.uiTitlePanel3.Text = "输出结果";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTitlePanel3.TitleInterval = 5;
            // 
            // uidd_EndX
            // 
            this.uidd_EndX.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_EndX.Location = new System.Drawing.Point(176, 41);
            this.uidd_EndX.Margin = new System.Windows.Forms.Padding(0);
            this.uidd_EndX.MinimumSize = new System.Drawing.Size(50, 0);
            this.uidd_EndX.Name = "uidd_EndX";
            this.uidd_EndX.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_EndX.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_EndX.Size = new System.Drawing.Size(90, 24);
            this.uidd_EndX.StyleCustomMode = true;
            this.uidd_EndX.TabIndex = 37;
            this.uidd_EndX.Text = null;
            this.uidd_EndX.Value = 0D;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLabel2.Location = new System.Drawing.Point(137, 45);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(43, 17);
            this.uiLabel2.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 36;
            this.uiLabel2.Text = "终点X:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uidd_StartX
            // 
            this.uidd_StartX.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_StartX.Location = new System.Drawing.Point(42, 41);
            this.uidd_StartX.Margin = new System.Windows.Forms.Padding(0);
            this.uidd_StartX.MinimumSize = new System.Drawing.Size(50, 0);
            this.uidd_StartX.Name = "uidd_StartX";
            this.uidd_StartX.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_StartX.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_StartX.Size = new System.Drawing.Size(90, 24);
            this.uidd_StartX.StyleCustomMode = true;
            this.uidd_StartX.TabIndex = 32;
            this.uidd_StartX.Text = null;
            this.uidd_StartX.Value = 0D;
            // 
            // uidd_EndY
            // 
            this.uidd_EndY.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_EndY.Location = new System.Drawing.Point(176, 70);
            this.uidd_EndY.Margin = new System.Windows.Forms.Padding(0);
            this.uidd_EndY.MinimumSize = new System.Drawing.Size(50, 0);
            this.uidd_EndY.Name = "uidd_EndY";
            this.uidd_EndY.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_EndY.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_EndY.Size = new System.Drawing.Size(90, 24);
            this.uidd_EndY.StyleCustomMode = true;
            this.uidd_EndY.TabIndex = 38;
            this.uidd_EndY.Text = null;
            this.uidd_EndY.Value = 0D;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLabel3.Location = new System.Drawing.Point(3, 45);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(43, 17);
            this.uiLabel3.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 30;
            this.uiLabel3.Text = "起点X:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLabel6.Location = new System.Drawing.Point(138, 75);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(42, 17);
            this.uiLabel6.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 39;
            this.uiLabel6.Text = "终点Y:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uidd_StartY
            // 
            this.uidd_StartY.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_StartY.Location = new System.Drawing.Point(42, 70);
            this.uidd_StartY.Margin = new System.Windows.Forms.Padding(0);
            this.uidd_StartY.MinimumSize = new System.Drawing.Size(50, 0);
            this.uidd_StartY.Name = "uidd_StartY";
            this.uidd_StartY.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_StartY.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_StartY.Size = new System.Drawing.Size(90, 24);
            this.uidd_StartY.StyleCustomMode = true;
            this.uidd_StartY.TabIndex = 33;
            this.uidd_StartY.Text = null;
            this.uidd_StartY.Value = 0D;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLabel4.Location = new System.Drawing.Point(4, 74);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(42, 17);
            this.uiLabel4.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 35;
            this.uiLabel4.Text = "起点Y:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.RexMeas1);
            this.uiTitlePanel1.Controls.Add(this.uiLabel1);
            this.uiTitlePanel1.Controls.Add(this.label17);
            this.uiTitlePanel1.Controls.Add(this.label14);
            this.uiTitlePanel1.Controls.Add(this.label12);
            this.uiTitlePanel1.Controls.Add(this.label11);
            this.uiTitlePanel1.Controls.Add(this.label4);
            this.uiTitlePanel1.Controls.Add(this.label2);
            this.uiTitlePanel1.Controls.Add(this.uiLink_Coord);
            this.uiTitlePanel1.Controls.Add(this.uiLabel5);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(0, 65);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.Size = new System.Drawing.Size(272, 270);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.StyleCustomMode = true;
            this.uiTitlePanel1.TabIndex = 161;
            this.uiTitlePanel1.Text = "参数设置";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTitlePanel1.TitleInterval = 5;
            // 
            // RexMeas1
            // 
            this.RexMeas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.RexMeas1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RexMeas1.Location = new System.Drawing.Point(40, 61);
            this.RexMeas1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RexMeas1.Name = "RexMeas1";
            this.RexMeas1.Size = new System.Drawing.Size(211, 200);
            this.RexMeas1.TabIndex = 39;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(45, 98);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(35, 17);
            this.uiLabel1.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 38;
            this.uiLabel1.Text = "宽度:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(45, 240);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 17);
            this.label17.Style = Rex.UI.UIStyle.Custom;
            this.label17.TabIndex = 37;
            this.label17.Text = "筛选:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(45, 212);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 17);
            this.label14.Style = Rex.UI.UIStyle.Custom;
            this.label14.TabIndex = 36;
            this.label14.Text = "方向:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(45, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 17);
            this.label12.Style = Rex.UI.UIStyle.Custom;
            this.label12.TabIndex = 35;
            this.label12.Text = "模式:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(45, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.Style = Rex.UI.UIStyle.Custom;
            this.label11.TabIndex = 34;
            this.label11.Text = "间隔:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(45, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.Style = Rex.UI.UIStyle.Custom;
            this.label4.TabIndex = 33;
            this.label4.Text = "阈值:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(45, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.Style = Rex.UI.UIStyle.Custom;
            this.label2.TabIndex = 5;
            this.label2.Text = "高度:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLink_Coord
            // 
            this.uiLink_Coord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_Coord.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_Coord.Location = new System.Drawing.Point(77, 36);
            this.uiLink_Coord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_Coord.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_Coord.Name = "uiLink_Coord";
            this.uiLink_Coord.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_Coord.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_Coord.Size = new System.Drawing.Size(174, 24);
            this.uiLink_Coord.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_Coord.StyleCustomMode = true;
            this.uiLink_Coord.TabIndex = 4;
            this.uiLink_Coord.Text = "uiLinkText1";
            this.uiLink_Coord.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.uiLink_Coord.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(21, 40);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(59, 17);
            this.uiLabel5.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 3;
            this.uiLabel5.Text = "参考坐标:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.uiLink_Image);
            this.uiTitlePanel2.Controls.Add(this.label19);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.Size = new System.Drawing.Size(272, 65);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.StyleCustomMode = true;
            this.uiTitlePanel2.TabIndex = 160;
            this.uiTitlePanel2.Text = "输入设置";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTitlePanel2.TitleInterval = 5;
            // 
            // uiLink_Image
            // 
            this.uiLink_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_Image.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_Image.Location = new System.Drawing.Point(76, 33);
            this.uiLink_Image.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_Image.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_Image.Name = "uiLink_Image";
            this.uiLink_Image.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_Image.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_Image.Size = new System.Drawing.Size(174, 24);
            this.uiLink_Image.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_Image.StyleCustomMode = true;
            this.uiLink_Image.TabIndex = 4;
            this.uiLink_Image.Text = "uiLinkText1";
            this.uiLink_Image.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.uiLink_Image.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(20, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 17);
            this.label19.Style = Rex.UI.UIStyle.Custom;
            this.label19.TabIndex = 3;
            this.label19.Text = "输入图像:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uicb_Result);
            this.tabPage2.Controls.Add(this.uicb_Area);
            this.tabPage2.Controls.Add(this.uicb_Roi);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(272, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "显示设置";
            // 
            // uicb_Result
            // 
            this.uicb_Result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Result.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uicb_Result.Location = new System.Drawing.Point(19, 104);
            this.uicb_Result.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Result.Name = "uicb_Result";
            this.uicb_Result.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Result.Size = new System.Drawing.Size(136, 21);
            this.uicb_Result.Style = Rex.UI.UIStyle.Custom;
            this.uicb_Result.TabIndex = 24;
            this.uicb_Result.Text = "是否显示结果";
            // 
            // uicb_Area
            // 
            this.uicb_Area.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Area.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Area.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uicb_Area.Location = new System.Drawing.Point(19, 70);
            this.uicb_Area.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Area.Name = "uicb_Area";
            this.uicb_Area.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Area.Size = new System.Drawing.Size(136, 21);
            this.uicb_Area.Style = Rex.UI.UIStyle.Custom;
            this.uicb_Area.TabIndex = 23;
            this.uicb_Area.Text = "是否显示查找范围";
            // 
            // uicb_Roi
            // 
            this.uicb_Roi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Roi.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Roi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uicb_Roi.Location = new System.Drawing.Point(19, 39);
            this.uicb_Roi.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Roi.Name = "uicb_Roi";
            this.uicb_Roi.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Roi.Size = new System.Drawing.Size(136, 21);
            this.uicb_Roi.Style = Rex.UI.UIStyle.Custom;
            this.uicb_Roi.TabIndex = 22;
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
            // MeasRectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeasRectForm";
            this.Load += new System.EventHandler(this.MeasRectForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel3.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.CTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private Rex.UI.UICheckBox uicb_Result;
        private Rex.UI.UICheckBox uicb_Area;
        private Rex.UI.UICheckBox uicb_Roi;
        private System.Windows.Forms.TabPage tabPage1;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private VisionCore.RexMeas RexMeas1;
        private Rex.UI.UILabel uiLabel1;
        private Rex.UI.UILabel label17;
        private Rex.UI.UILabel label14;
        private Rex.UI.UILabel label12;
        private Rex.UI.UILabel label11;
        private Rex.UI.UILabel label4;
        private Rex.UI.UILabel label2;
        private Rex.UI.UILinkText uiLink_Coord;
        private Rex.UI.UILabel uiLabel5;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private Rex.UI.UILinkText uiLink_Image;
        private Rex.UI.UILabel label19;
        private RexView.HWindow_HE mWindowH;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private Rex.UI.UIDoubleUpDownB uidd_EndX;
        private Rex.UI.UILabel uiLabel2;
        private Rex.UI.UIDoubleUpDownB uidd_StartX;
        private Rex.UI.UIDoubleUpDownB uidd_EndY;
        private Rex.UI.UILabel uiLabel3;
        private Rex.UI.UILabel uiLabel6;
        private Rex.UI.UIDoubleUpDownB uidd_StartY;
        private Rex.UI.UILabel uiLabel4;
    }
}