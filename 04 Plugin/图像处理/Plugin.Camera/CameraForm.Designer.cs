namespace Plugin.Camera
{
    partial class CameraForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraForm));
            this.tabControl1 = new Rex.CTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pl_Camera = new Rex.UI.UITitlePanel();
            this.ui_LikeMeasCal = new Rex.UI.UILinkText();
            this.label1 = new System.Windows.Forms.Label();
            this.ui_LikeDistCal = new Rex.UI.UILinkText();
            this.ui_SelectCamera = new Rex.UI.UIComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ui_SelectScreen = new Rex.UI.UIComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pl_Path = new Rex.UI.UITitlePanel();
            this.uiLink_ImagePath = new Rex.UI.UILinkPath();
            this.pl_File = new Rex.UI.UITitlePanel();
            this.uiLink_FilePath = new Rex.UI.UILinkPath();
            this.dgv_File = new Rex.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ui_ForRead = new Rex.UI.UICheckBox();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.uirb_ImageSource = new Rex.UI.UIRadioButtonGroup();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.uicb_ShowText = new Rex.UI.UICheckBox();
            this.uitx_X = new Rex.UI.UIDoubleUpDownB();
            this.label8 = new System.Windows.Forms.Label();
            this.uitx_Y = new Rex.UI.UIDoubleUpDownB();
            this.label6 = new System.Windows.Forms.Label();
            this.uitx_Size = new Rex.UI.UIDoubleUpDownB();
            this.label4 = new System.Windows.Forms.Label();
            this.uitx_Prefix = new Rex.UI.UITextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uitx_Color = new Rex.UI.UIColorPicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.mWindowH = new RexView.HWindow_HE();
            this.OpenImage = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pl_Camera.SuspendLayout();
            this.pl_Path.SuspendLayout();
            this.pl_File.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_File)).BeginInit();
            this.uiTitlePanel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.mWindowH);
            this.panel_center.Controls.Add(this.tabControl1);
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Location = new System.Drawing.Point(41, 8);
            // 
            // cb_Enable
            // 
            this.cb_Enable.Location = new System.Drawing.Point(202, 9);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(739, 6);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(641, 6);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(543, 6);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
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
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 22);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(285, 474);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.pl_Camera);
            this.tabPage1.Controls.Add(this.pl_Path);
            this.tabPage1.Controls.Add(this.pl_File);
            this.tabPage1.Controls.Add(this.uiTitlePanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(277, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            // 
            // pl_Camera
            // 
            this.pl_Camera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.pl_Camera.Controls.Add(this.ui_LikeMeasCal);
            this.pl_Camera.Controls.Add(this.label1);
            this.pl_Camera.Controls.Add(this.ui_LikeDistCal);
            this.pl_Camera.Controls.Add(this.ui_SelectCamera);
            this.pl_Camera.Controls.Add(this.label5);
            this.pl_Camera.Controls.Add(this.label3);
            this.pl_Camera.Controls.Add(this.ui_SelectScreen);
            this.pl_Camera.Controls.Add(this.label10);
            this.pl_Camera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Camera.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.pl_Camera.ForeColor = System.Drawing.Color.White;
            this.pl_Camera.Location = new System.Drawing.Point(0, 344);
            this.pl_Camera.Margin = new System.Windows.Forms.Padding(0);
            this.pl_Camera.MinimumSize = new System.Drawing.Size(1, 1);
            this.pl_Camera.Name = "pl_Camera";
            this.pl_Camera.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.pl_Camera.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pl_Camera.Size = new System.Drawing.Size(277, 100);
            this.pl_Camera.Style = Rex.UI.UIStyle.Custom;
            this.pl_Camera.StyleCustomMode = true;
            this.pl_Camera.TabIndex = 15;
            this.pl_Camera.Text = "相机模式";
            this.pl_Camera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ui_LikeMeasCal
            // 
            this.ui_LikeMeasCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ui_LikeMeasCal.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ui_LikeMeasCal.Location = new System.Drawing.Point(73, 118);
            this.ui_LikeMeasCal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_LikeMeasCal.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_LikeMeasCal.Name = "ui_LikeMeasCal";
            this.ui_LikeMeasCal.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.ui_LikeMeasCal.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ui_LikeMeasCal.Size = new System.Drawing.Size(193, 24);
            this.ui_LikeMeasCal.Style = Rex.UI.UIStyle.Custom;
            this.ui_LikeMeasCal.StyleCustomMode = true;
            this.ui_LikeMeasCal.TabIndex = 41;
            this.ui_LikeMeasCal.Text = "测量";
            this.ui_LikeMeasCal.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.ui_LikeMeasCal_BtnAdd);
            this.ui_LikeMeasCal.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.ui_LikeMeasCal_BtnDec);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(14, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "测量标定:";
            // 
            // ui_LikeDistCal
            // 
            this.ui_LikeDistCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ui_LikeDistCal.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ui_LikeDistCal.Location = new System.Drawing.Point(73, 88);
            this.ui_LikeDistCal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_LikeDistCal.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_LikeDistCal.Name = "ui_LikeDistCal";
            this.ui_LikeDistCal.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.ui_LikeDistCal.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ui_LikeDistCal.Size = new System.Drawing.Size(193, 24);
            this.ui_LikeDistCal.Style = Rex.UI.UIStyle.Custom;
            this.ui_LikeDistCal.StyleCustomMode = true;
            this.ui_LikeDistCal.TabIndex = 39;
            this.ui_LikeDistCal.Text = "畸变";
            this.ui_LikeDistCal.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.ui_LikeMeasCal_BtnAdd);
            this.ui_LikeDistCal.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.ui_LikeMeasCal_BtnDec);
            // 
            // ui_SelectCamera
            // 
            this.ui_SelectCamera.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ui_SelectCamera.Location = new System.Drawing.Point(73, 32);
            this.ui_SelectCamera.Margin = new System.Windows.Forms.Padding(0);
            this.ui_SelectCamera.MinimumSize = new System.Drawing.Size(63, 0);
            this.ui_SelectCamera.Name = "ui_SelectCamera";
            this.ui_SelectCamera.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.ui_SelectCamera.Radius = 2;
            this.ui_SelectCamera.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.ui_SelectCamera.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ui_SelectCamera.Size = new System.Drawing.Size(193, 23);
            this.ui_SelectCamera.Style = Rex.UI.UIStyle.Custom;
            this.ui_SelectCamera.StyleCustomMode = true;
            this.ui_SelectCamera.TabIndex = 38;
            this.ui_SelectCamera.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ui_SelectCamera.SelectedIndexChanged += new System.EventHandler(this.ui_SelectCamera_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(14, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "屏幕编号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "选择相机:";
            // 
            // ui_SelectScreen
            // 
            this.ui_SelectScreen.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ui_SelectScreen.FormattingEnabled = true;
            this.ui_SelectScreen.Items.AddRange(new object[] {
            "None",
            "1号屏显示",
            "2号屏显示",
            "3号屏显示",
            "4号屏显示",
            "5号屏显示",
            "6号屏显示",
            "7号屏显示",
            "8号屏显示",
            "9号屏显示"});
            this.ui_SelectScreen.Location = new System.Drawing.Point(73, 61);
            this.ui_SelectScreen.Margin = new System.Windows.Forms.Padding(0);
            this.ui_SelectScreen.MinimumSize = new System.Drawing.Size(63, 0);
            this.ui_SelectScreen.Name = "ui_SelectScreen";
            this.ui_SelectScreen.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.ui_SelectScreen.Radius = 2;
            this.ui_SelectScreen.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.ui_SelectScreen.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ui_SelectScreen.Size = new System.Drawing.Size(193, 23);
            this.ui_SelectScreen.Style = Rex.UI.UIStyle.Custom;
            this.ui_SelectScreen.StyleCustomMode = true;
            this.ui_SelectScreen.TabIndex = 36;
            this.ui_SelectScreen.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(14, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "畸变校正:";
            // 
            // pl_Path
            // 
            this.pl_Path.Controls.Add(this.uiLink_ImagePath);
            this.pl_Path.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_Path.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.pl_Path.ForeColor = System.Drawing.Color.White;
            this.pl_Path.Location = new System.Drawing.Point(0, 282);
            this.pl_Path.Margin = new System.Windows.Forms.Padding(0);
            this.pl_Path.MinimumSize = new System.Drawing.Size(1, 1);
            this.pl_Path.Name = "pl_Path";
            this.pl_Path.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.pl_Path.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pl_Path.Size = new System.Drawing.Size(277, 62);
            this.pl_Path.Style = Rex.UI.UIStyle.Custom;
            this.pl_Path.TabIndex = 16;
            this.pl_Path.Text = "图像路径";
            this.pl_Path.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // uiLink_ImagePath
            // 
            this.uiLink_ImagePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_ImagePath.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_ImagePath.Location = new System.Drawing.Point(60, 32);
            this.uiLink_ImagePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_ImagePath.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_ImagePath.Name = "uiLink_ImagePath";
            this.uiLink_ImagePath.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_ImagePath.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_ImagePath.Size = new System.Drawing.Size(202, 24);
            this.uiLink_ImagePath.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_ImagePath.StyleCustomMode = true;
            this.uiLink_ImagePath.TabIndex = 52;
            this.uiLink_ImagePath.Text = "uiLinkPath1";
            this.uiLink_ImagePath.BtnAdd += new Rex.UI.UILinkPath.BtnAddHandle(this.uiLink_ImagePath_BtnAdd);
            this.uiLink_ImagePath.BtnDec += new Rex.UI.UILinkPath.BtnDecHandle(this.ui_LikeMeasCal_BtnDec);
            // 
            // pl_File
            // 
            this.pl_File.Controls.Add(this.uiLink_FilePath);
            this.pl_File.Controls.Add(this.dgv_File);
            this.pl_File.Controls.Add(this.ui_ForRead);
            this.pl_File.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_File.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.pl_File.ForeColor = System.Drawing.Color.White;
            this.pl_File.Location = new System.Drawing.Point(0, 62);
            this.pl_File.Margin = new System.Windows.Forms.Padding(0);
            this.pl_File.MinimumSize = new System.Drawing.Size(1, 1);
            this.pl_File.Name = "pl_File";
            this.pl_File.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.pl_File.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pl_File.Size = new System.Drawing.Size(277, 220);
            this.pl_File.Style = Rex.UI.UIStyle.Custom;
            this.pl_File.TabIndex = 14;
            this.pl_File.Text = "文件目录";
            this.pl_File.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // uiLink_FilePath
            // 
            this.uiLink_FilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_FilePath.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_FilePath.Location = new System.Drawing.Point(64, 33);
            this.uiLink_FilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_FilePath.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_FilePath.Name = "uiLink_FilePath";
            this.uiLink_FilePath.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_FilePath.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_FilePath.Size = new System.Drawing.Size(202, 24);
            this.uiLink_FilePath.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_FilePath.StyleCustomMode = true;
            this.uiLink_FilePath.TabIndex = 51;
            this.uiLink_FilePath.Text = "uiLinkPath1";
            this.uiLink_FilePath.BtnAdd += new Rex.UI.UILinkPath.BtnAddHandle(this.ui_LikeFile_BtnAdd);
            this.uiLink_FilePath.BtnDec += new Rex.UI.UILinkPath.BtnDecHandle(this.ui_LikeMeasCal_BtnDec);
            // 
            // dgv_File
            // 
            this.dgv_File.AllowUserToAddRows = false;
            this.dgv_File.AllowUserToDeleteRows = false;
            this.dgv_File.AllowUserToResizeColumns = false;
            this.dgv_File.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_File.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_File.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_File.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_File.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_File.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_File.ColumnHeadersHeight = 25;
            this.dgv_File.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_File.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_File.EnableHeadersVisualStyles = false;
            this.dgv_File.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_File.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_File.Location = new System.Drawing.Point(0, 62);
            this.dgv_File.MultiSelect = false;
            this.dgv_File.Name = "dgv_File";
            this.dgv_File.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_File.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_File.RowHeadersVisible = false;
            this.dgv_File.RowHeadersWidth = 25;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_File.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_File.RowTemplate.Height = 29;
            this.dgv_File.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_File.SelectedIndex = -1;
            this.dgv_File.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_File.ShowGridLine = true;
            this.dgv_File.Size = new System.Drawing.Size(277, 158);
            this.dgv_File.StripeEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_File.Style = Rex.UI.UIStyle.Custom;
            this.dgv_File.StyleCustomMode = true;
            this.dgv_File.TabIndex = 50;
            this.dgv_File.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_File_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 1F;
            this.Column1.HeaderText = "索引";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 44;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 2F;
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ui_ForRead
            // 
            this.ui_ForRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ui_ForRead.Checked = true;
            this.ui_ForRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_ForRead.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ui_ForRead.ImageSize = 14;
            this.ui_ForRead.Location = new System.Drawing.Point(9, 37);
            this.ui_ForRead.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_ForRead.Name = "ui_ForRead";
            this.ui_ForRead.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ui_ForRead.Size = new System.Drawing.Size(49, 16);
            this.ui_ForRead.Style = Rex.UI.UIStyle.Custom;
            this.ui_ForRead.TabIndex = 16;
            this.ui_ForRead.Text = "循环";
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uirb_ImageSource);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.Size = new System.Drawing.Size(277, 62);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.TabIndex = 13;
            this.uiTitlePanel1.Text = "采集模式";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // uirb_ImageSource
            // 
            this.uirb_ImageSource.ColumnCount = 3;
            this.uirb_ImageSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uirb_ImageSource.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uirb_ImageSource.Items.AddRange(new object[] {
            "指定图像",
            "文件目录",
            "相机采集"});
            this.uirb_ImageSource.ItemSize = new System.Drawing.Size(90, 20);
            this.uirb_ImageSource.Location = new System.Drawing.Point(3, 25);
            this.uirb_ImageSource.Margin = new System.Windows.Forms.Padding(0);
            this.uirb_ImageSource.MinimumSize = new System.Drawing.Size(1, 1);
            this.uirb_ImageSource.Name = "uirb_ImageSource";
            this.uirb_ImageSource.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.uirb_ImageSource.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uirb_ImageSource.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uirb_ImageSource.Size = new System.Drawing.Size(271, 37);
            this.uirb_ImageSource.StartPos = new System.Drawing.Point(5, -5);
            this.uirb_ImageSource.Style = Rex.UI.UIStyle.Custom;
            this.uirb_ImageSource.TabIndex = 15;
            this.uirb_ImageSource.Text = null;
            this.uirb_ImageSource.TitleInterval = 5;
            this.uirb_ImageSource.ValueChanged += new Rex.UI.UIRadioButtonGroup.OnValueChanged(this.uirb_ImageSource_ValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.uiTitlePanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(277, 444);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "采集信息";
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.uicb_ShowText);
            this.uiTitlePanel3.Controls.Add(this.uitx_X);
            this.uiTitlePanel3.Controls.Add(this.label8);
            this.uiTitlePanel3.Controls.Add(this.uitx_Y);
            this.uiTitlePanel3.Controls.Add(this.label6);
            this.uiTitlePanel3.Controls.Add(this.uitx_Size);
            this.uiTitlePanel3.Controls.Add(this.label4);
            this.uiTitlePanel3.Controls.Add(this.uitx_Prefix);
            this.uiTitlePanel3.Controls.Add(this.label7);
            this.uiTitlePanel3.Controls.Add(this.uitx_Color);
            this.uiTitlePanel3.Controls.Add(this.label2);
            this.uiTitlePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel3.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel3.Size = new System.Drawing.Size(277, 444);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.TabIndex = 15;
            this.uiTitlePanel3.Text = "信息参数";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // uicb_ShowText
            // 
            this.uicb_ShowText.Checked = true;
            this.uicb_ShowText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_ShowText.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_ShowText.Location = new System.Drawing.Point(69, 192);
            this.uicb_ShowText.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_ShowText.Name = "uicb_ShowText";
            this.uicb_ShowText.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_ShowText.Size = new System.Drawing.Size(181, 21);
            this.uicb_ShowText.Style = Rex.UI.UIStyle.Custom;
            this.uicb_ShowText.TabIndex = 189;
            this.uicb_ShowText.Text = "是否显示";
            // 
            // uitx_X
            // 
            this.uitx_X.Decimal = 0;
            this.uitx_X.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uitx_X.Location = new System.Drawing.Point(69, 34);
            this.uitx_X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitx_X.Maximum = 5000D;
            this.uitx_X.Minimum = 0D;
            this.uitx_X.MinimumSize = new System.Drawing.Size(100, 0);
            this.uitx_X.Name = "uitx_X";
            this.uitx_X.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitx_X.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitx_X.Size = new System.Drawing.Size(181, 24);
            this.uitx_X.Step = 2D;
            this.uitx_X.Style = Rex.UI.UIStyle.Custom;
            this.uitx_X.StyleCustomMode = true;
            this.uitx_X.TabIndex = 155;
            this.uitx_X.Text = "uiDoubleUpDownA2";
            this.uitx_X.Value = 10D;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(26, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 154;
            this.label8.Text = "位置X:";
            // 
            // uitx_Y
            // 
            this.uitx_Y.Decimal = 0;
            this.uitx_Y.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uitx_Y.Location = new System.Drawing.Point(69, 63);
            this.uitx_Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitx_Y.Maximum = 5000D;
            this.uitx_Y.Minimum = 0D;
            this.uitx_Y.MinimumSize = new System.Drawing.Size(100, 0);
            this.uitx_Y.Name = "uitx_Y";
            this.uitx_Y.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitx_Y.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitx_Y.Size = new System.Drawing.Size(181, 24);
            this.uitx_Y.Step = 2D;
            this.uitx_Y.Style = Rex.UI.UIStyle.Custom;
            this.uitx_Y.StyleCustomMode = true;
            this.uitx_Y.TabIndex = 188;
            this.uitx_Y.Text = "uiDoubleUpDownA2";
            this.uitx_Y.Value = 20D;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(27, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 187;
            this.label6.Text = "位置Y:";
            // 
            // uitx_Size
            // 
            this.uitx_Size.Decimal = 0;
            this.uitx_Size.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uitx_Size.Location = new System.Drawing.Point(69, 93);
            this.uitx_Size.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitx_Size.Maximum = 50D;
            this.uitx_Size.Minimum = 1D;
            this.uitx_Size.MinimumSize = new System.Drawing.Size(100, 0);
            this.uitx_Size.Name = "uitx_Size";
            this.uitx_Size.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitx_Size.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitx_Size.Size = new System.Drawing.Size(181, 24);
            this.uitx_Size.Step = 2D;
            this.uitx_Size.Style = Rex.UI.UIStyle.Custom;
            this.uitx_Size.StyleCustomMode = true;
            this.uitx_Size.TabIndex = 186;
            this.uitx_Size.Text = "uiDoubleUpDownA2";
            this.uitx_Size.Value = 20D;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(34, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 185;
            this.label4.Text = "大小:";
            // 
            // uitx_Prefix
            // 
            this.uitx_Prefix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitx_Prefix.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uitx_Prefix.Location = new System.Drawing.Point(69, 123);
            this.uitx_Prefix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitx_Prefix.Maximum = 2147483647D;
            this.uitx_Prefix.Minimum = -2147483648D;
            this.uitx_Prefix.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitx_Prefix.Name = "uitx_Prefix";
            this.uitx_Prefix.Padding = new System.Windows.Forms.Padding(5);
            this.uitx_Prefix.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitx_Prefix.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitx_Prefix.Size = new System.Drawing.Size(181, 23);
            this.uitx_Prefix.StyleCustomMode = true;
            this.uitx_Prefix.TabIndex = 184;
            this.uitx_Prefix.Watermark = "如：相机名称";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(34, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 183;
            this.label7.Text = "前缀:";
            // 
            // uitx_Color
            // 
            this.uitx_Color.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.uitx_Color.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uitx_Color.Location = new System.Drawing.Point(69, 156);
            this.uitx_Color.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitx_Color.MinimumSize = new System.Drawing.Size(63, 0);
            this.uitx_Color.Name = "uitx_Color";
            this.uitx_Color.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uitx_Color.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitx_Color.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitx_Color.Size = new System.Drawing.Size(181, 23);
            this.uitx_Color.Style = Rex.UI.UIStyle.Custom;
            this.uitx_Color.StyleCustomMode = true;
            this.uitx_Color.TabIndex = 182;
            this.uitx_Color.Text = "uiColorPicker1";
            this.uitx_Color.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uitx_Color.Value = System.Drawing.Color.Lime;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(34, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 181;
            this.label2.Text = "颜色:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.uiTitlePanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(277, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "辅助设置";
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.Size = new System.Drawing.Size(277, 444);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.TabIndex = 14;
            this.uiTitlePanel2.Text = "光源参数";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mWindowH
            // 
            this.mWindowH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mWindowH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mWindowH.BackgroundImage")));
            this.mWindowH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mWindowH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mWindowH.Dock = System.Windows.Forms.DockStyle.Right;
            this.mWindowH.DrawModel = false;
            this.mWindowH.Image = null;
            this.mWindowH.Location = new System.Drawing.Point(290, 1);
            this.mWindowH.Margin = new System.Windows.Forms.Padding(5);
            this.mWindowH.Name = "mWindowH";
            this.mWindowH.Padding = new System.Windows.Forms.Padding(1);
            this.mWindowH.Size = new System.Drawing.Size(555, 474);
            this.mWindowH.TabIndex = 14;
            // 
            // OpenImage
            // 
            this.OpenImage.FileName = "OpenImage";
            this.OpenImage.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenImage_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CameraForm";
            this.Load += new System.EventHandler(this.ModForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pl_Camera.ResumeLayout(false);
            this.pl_Camera.PerformLayout();
            this.pl_Path.ResumeLayout(false);
            this.pl_File.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_File)).EndInit();
            this.uiTitlePanel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.CTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private Rex.UI.UITitlePanel pl_File;
        private Rex.UI.UICheckBox ui_ForRead;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private System.Windows.Forms.Label label5;
        protected Rex.UI.UIComboBox ui_SelectScreen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private Rex.UI.UITitlePanel pl_Camera;
        private Rex.UI.UIComboBox ui_SelectCamera;
        private Rex.UI.UILinkText ui_LikeDistCal;
        private Rex.UI.UIDataGridView dgv_File;
        private Rex.UI.UILinkText ui_LikeMeasCal;
        private System.Windows.Forms.Label label1;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Rex.UI.UILinkPath uiLink_FilePath;
        private RexView.HWindow_HE mWindowH;
        private System.Windows.Forms.TabPage tabPage3;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private Rex.UI.UIColorPicker uitx_Color;
        private System.Windows.Forms.Label label2;
        private Rex.UI.UITextBox uitx_Prefix;
        private System.Windows.Forms.Label label7;
        private Rex.UI.UIDoubleUpDownB uitx_X;
        private System.Windows.Forms.Label label8;
        private Rex.UI.UIDoubleUpDownB uitx_Y;
        private System.Windows.Forms.Label label6;
        private Rex.UI.UIDoubleUpDownB uitx_Size;
        private System.Windows.Forms.Label label4;
        private Rex.UI.UICheckBox uicb_ShowText;
        private Rex.UI.UIRadioButtonGroup uirb_ImageSource;
        private System.Windows.Forms.OpenFileDialog OpenImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Rex.UI.UITitlePanel pl_Path;
        private Rex.UI.UILinkPath uiLink_ImagePath;
    }
}