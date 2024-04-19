namespace Plugin.MeasCircle
{
    partial class MeasCircleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeasCircleForm));
            this.tabControl1 = new Rex.CTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.nudRadus = new Rex.UI.UIDoubleUpDownB();
            this.nudCenterX = new Rex.UI.UIDoubleUpDownB();
            this.uiLabel2 = new Rex.UI.UILabel();
            this.uiLabel3 = new Rex.UI.UILabel();
            this.nudCenterY = new Rex.UI.UIDoubleUpDownB();
            this.uiLabel4 = new Rex.UI.UILabel();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.uiLabel1 = new Rex.UI.UILabel();
            this.label17 = new Rex.UI.UILabel();
            this.label14 = new Rex.UI.UILabel();
            this.label12 = new Rex.UI.UILabel();
            this.label11 = new Rex.UI.UILabel();
            this.label4 = new Rex.UI.UILabel();
            this.label2 = new Rex.UI.UILabel();
            this.uiLink_Coord = new Rex.UI.UILinkText();
            this.label1 = new Rex.UI.UILabel();
            this.RexMeas1 = new VisionCore.RexMeas();
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
            this.panel_bottom.Location = new System.Drawing.Point(1, 512);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_bottom.Size = new System.Drawing.Size(846, 35);
            // 
            // panel_center
            // 
            this.panel_center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.panel_center.Controls.Add(this.mWindowH);
            this.panel_center.Controls.Add(this.tabControl1);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.Size = new System.Drawing.Size(846, 479);
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Location = new System.Drawing.Point(62, 7);
            this.uitb_Remark.Size = new System.Drawing.Size(158, 23);
            // 
            // cb_Enable
            // 
            this.cb_Enable.Location = new System.Drawing.Point(284, 9);
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
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.tabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(280, 477);
            this.tabControl1.TabIndex = 35;
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
            this.tabPage1.Size = new System.Drawing.Size(272, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.nudRadus);
            this.uiTitlePanel3.Controls.Add(this.nudCenterX);
            this.uiTitlePanel3.Controls.Add(this.uiLabel2);
            this.uiTitlePanel3.Controls.Add(this.uiLabel3);
            this.uiTitlePanel3.Controls.Add(this.nudCenterY);
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
            this.uiTitlePanel3.Size = new System.Drawing.Size(272, 112);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.StyleCustomMode = true;
            this.uiTitlePanel3.TabIndex = 157;
            this.uiTitlePanel3.Text = "输出结果";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTitlePanel3.TitleInterval = 5;
            // 
            // nudRadus
            // 
            this.nudRadus.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.nudRadus.Location = new System.Drawing.Point(76, 80);
            this.nudRadus.Margin = new System.Windows.Forms.Padding(0);
            this.nudRadus.MinimumSize = new System.Drawing.Size(100, 0);
            this.nudRadus.Name = "nudRadus";
            this.nudRadus.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.nudRadus.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.nudRadus.Size = new System.Drawing.Size(174, 24);
            this.nudRadus.StyleCustomMode = true;
            this.nudRadus.TabIndex = 34;
            this.nudRadus.Text = null;
            this.nudRadus.Value = 0D;
            // 
            // nudCenterX
            // 
            this.nudCenterX.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.nudCenterX.Location = new System.Drawing.Point(76, 28);
            this.nudCenterX.Margin = new System.Windows.Forms.Padding(0);
            this.nudCenterX.MinimumSize = new System.Drawing.Size(100, 0);
            this.nudCenterX.Name = "nudCenterX";
            this.nudCenterX.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.nudCenterX.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.nudCenterX.Size = new System.Drawing.Size(174, 24);
            this.nudCenterX.StyleCustomMode = true;
            this.nudCenterX.TabIndex = 32;
            this.nudCenterX.Text = null;
            this.nudCenterX.Value = 0D;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLabel2.Location = new System.Drawing.Point(37, 84);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(43, 17);
            this.uiLabel2.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 31;
            this.uiLabel2.Text = "半径R:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLabel3.Location = new System.Drawing.Point(37, 32);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(43, 17);
            this.uiLabel3.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 30;
            this.uiLabel3.Text = "圆心X:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudCenterY
            // 
            this.nudCenterY.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.nudCenterY.Location = new System.Drawing.Point(76, 54);
            this.nudCenterY.Margin = new System.Windows.Forms.Padding(0);
            this.nudCenterY.MinimumSize = new System.Drawing.Size(100, 0);
            this.nudCenterY.Name = "nudCenterY";
            this.nudCenterY.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.nudCenterY.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.nudCenterY.Size = new System.Drawing.Size(174, 24);
            this.nudCenterY.StyleCustomMode = true;
            this.nudCenterY.TabIndex = 33;
            this.nudCenterY.Text = null;
            this.nudCenterY.Value = 0D;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLabel4.Location = new System.Drawing.Point(38, 58);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(42, 17);
            this.uiLabel4.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 35;
            this.uiLabel4.Text = "圆心Y:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uiLabel1);
            this.uiTitlePanel1.Controls.Add(this.label17);
            this.uiTitlePanel1.Controls.Add(this.label14);
            this.uiTitlePanel1.Controls.Add(this.label12);
            this.uiTitlePanel1.Controls.Add(this.label11);
            this.uiTitlePanel1.Controls.Add(this.label4);
            this.uiTitlePanel1.Controls.Add(this.label2);
            this.uiTitlePanel1.Controls.Add(this.uiLink_Coord);
            this.uiTitlePanel1.Controls.Add(this.label1);
            this.uiTitlePanel1.Controls.Add(this.RexMeas1);
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
            this.uiTitlePanel1.TabIndex = 156;
            this.uiTitlePanel1.Text = "参数设置";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTitlePanel1.TitleInterval = 5;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(45, 96);
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
            this.label17.Location = new System.Drawing.Point(45, 238);
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
            this.label14.Location = new System.Drawing.Point(45, 210);
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
            this.label12.Location = new System.Drawing.Point(45, 182);
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
            this.label11.Location = new System.Drawing.Point(45, 154);
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
            this.label4.Location = new System.Drawing.Point(45, 125);
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
            this.label2.Location = new System.Drawing.Point(45, 67);
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
            this.uiLink_Coord.Location = new System.Drawing.Point(77, 34);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.Style = Rex.UI.UIStyle.Custom;
            this.label1.TabIndex = 3;
            this.label1.Text = "参考坐标:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RexMeas1
            // 
            this.RexMeas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.RexMeas1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RexMeas1.Location = new System.Drawing.Point(40, 59);
            this.RexMeas1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RexMeas1.Name = "RexMeas1";
            this.RexMeas1.Size = new System.Drawing.Size(211, 208);
            this.RexMeas1.TabIndex = 39;
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
            this.uiTitlePanel2.TabIndex = 155;
            this.uiTitlePanel2.Text = "输入设置";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTitlePanel2.TitleInterval = 5;
            // 
            // uiLink_Image
            // 
            this.uiLink_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_Image.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_Image.Location = new System.Drawing.Point(76, 32);
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
            this.label19.Location = new System.Drawing.Point(20, 37);
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
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(272, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "显示设置";
            // 
            // uicb_Result
            // 
            this.uicb_Result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Result.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Result.Location = new System.Drawing.Point(17, 53);
            this.uicb_Result.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Result.Name = "uicb_Result";
            this.uicb_Result.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Result.Size = new System.Drawing.Size(99, 21);
            this.uicb_Result.TabIndex = 18;
            this.uicb_Result.Text = "是否显示结果";
            // 
            // uicb_Area
            // 
            this.uicb_Area.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Area.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Area.Location = new System.Drawing.Point(17, 85);
            this.uicb_Area.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Area.Name = "uicb_Area";
            this.uicb_Area.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Area.Size = new System.Drawing.Size(123, 21);
            this.uicb_Area.TabIndex = 17;
            this.uicb_Area.Text = "是否显示查找范围";
            // 
            // uicb_Roi
            // 
            this.uicb_Roi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Roi.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Roi.Location = new System.Drawing.Point(17, 21);
            this.uicb_Roi.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Roi.Name = "uicb_Roi";
            this.uicb_Roi.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Roi.Size = new System.Drawing.Size(97, 21);
            this.uicb_Roi.TabIndex = 16;
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
            this.mWindowH.Size = new System.Drawing.Size(560, 477);
            this.mWindowH.TabIndex = 36;
            // 
            // MeasCircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeasCircleForm";
            this.Load += new System.EventHandler(this.ModForm_Load);
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
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.CTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Rex.UI.UICheckBox uicb_Result;
        private Rex.UI.UICheckBox uicb_Area;
        private Rex.UI.UICheckBox uicb_Roi;
        private RexView.HWindow_HE mWindowH;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private Rex.UI.UILabel label17;
        private Rex.UI.UILabel label14;
        private Rex.UI.UILabel label12;
        private Rex.UI.UILabel label11;
        private Rex.UI.UILabel label4;
        private Rex.UI.UILabel label2;
        private Rex.UI.UILinkText uiLink_Coord;
        private Rex.UI.UILabel label1;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private Rex.UI.UILinkText uiLink_Image;
        private Rex.UI.UILabel label19;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private Rex.UI.UIDoubleUpDownB nudCenterX;
        private Rex.UI.UILabel uiLabel3;
        private Rex.UI.UIDoubleUpDownB nudCenterY;
        private Rex.UI.UILabel uiLabel4;
        private Rex.UI.UILabel uiLabel1;
        private VisionCore.RexMeas RexMeas1;
        private Rex.UI.UIDoubleUpDownB nudRadus;
        private Rex.UI.UILabel uiLabel2;
    }
}