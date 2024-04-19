namespace Plugin.CreateROI
{
    partial class CreateROIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateROIForm));
            this.tabControl1 = new Rex.CTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel4 = new Rex.UI.UITitlePanel();
            this.uiLink_CentreY = new Rex.UI.UILinkText();
            this.uiLink_CentreX = new Rex.UI.UILinkText();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.uirb_RoiType = new Rex.UI.UIRadioButtonGroup();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.uiLink_Coord = new Rex.UI.UILinkText();
            this.label1 = new Rex.UI.UILabel();
            this.uicb_CropImage = new Rex.UI.UICheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.uiLink_Image = new Rex.UI.UILinkText();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uicb_Result = new Rex.UI.UICheckBox();
            this.uicb_Area = new Rex.UI.UICheckBox();
            this.uicb_Roi = new Rex.UI.UICheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Color1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_Draw1 = new System.Windows.Forms.Button();
            this.cmb_CurrentImg = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mWindowH = new RexView.HWindow_HE();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.uiTitlePanel4.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // panel_center
            // 
            this.panel_center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.panel_center.Controls.Add(this.mWindowH);
            this.panel_center.Controls.Add(this.tabControl1);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.MaximumSize = new System.Drawing.Size(848, 473);
            this.panel_center.MinimumSize = new System.Drawing.Size(848, 473);
            this.panel_center.Size = new System.Drawing.Size(848, 473);
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Margin = new System.Windows.Forms.Padding(2);
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
            this.tabControl1.Size = new System.Drawing.Size(285, 471);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uiTitlePanel4);
            this.tabPage1.Controls.Add(this.uiTitlePanel3);
            this.tabPage1.Controls.Add(this.uiTitlePanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(277, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            // 
            // uiTitlePanel4
            // 
            this.uiTitlePanel4.Controls.Add(this.uiLink_CentreY);
            this.uiTitlePanel4.Controls.Add(this.uiLink_CentreX);
            this.uiTitlePanel4.Controls.Add(this.label3);
            this.uiTitlePanel4.Controls.Add(this.label4);
            this.uiTitlePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel4.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel4.Location = new System.Drawing.Point(0, 174);
            this.uiTitlePanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel4.Name = "uiTitlePanel4";
            this.uiTitlePanel4.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel4.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel4.Size = new System.Drawing.Size(277, 267);
            this.uiTitlePanel4.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel4.StyleCustomMode = true;
            this.uiTitlePanel4.TabIndex = 155;
            this.uiTitlePanel4.Text = "创建信息";
            this.uiTitlePanel4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTitlePanel4.TitleInterval = 5;
            // 
            // uiLink_CentreY
            // 
            this.uiLink_CentreY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_CentreY.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_CentreY.Location = new System.Drawing.Point(66, 64);
            this.uiLink_CentreY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLink_CentreY.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_CentreY.Name = "uiLink_CentreY";
            this.uiLink_CentreY.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_CentreY.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_CentreY.Size = new System.Drawing.Size(200, 25);
            this.uiLink_CentreY.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_CentreY.StyleCustomMode = true;
            this.uiLink_CentreY.TabIndex = 152;
            this.uiLink_CentreY.Text = "uiLinkText2";
            this.uiLink_CentreY.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.uiLink_CentreY.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // uiLink_CentreX
            // 
            this.uiLink_CentreX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_CentreX.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_CentreX.Location = new System.Drawing.Point(66, 35);
            this.uiLink_CentreX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLink_CentreX.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_CentreX.Name = "uiLink_CentreX";
            this.uiLink_CentreX.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_CentreX.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_CentreX.Size = new System.Drawing.Size(200, 25);
            this.uiLink_CentreX.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_CentreX.StyleCustomMode = true;
            this.uiLink_CentreX.TabIndex = 151;
            this.uiLink_CentreX.Text = "uiLinkText1";
            this.uiLink_CentreX.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.uiLink_CentreX.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(22, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 150;
            this.label3.Text = "中心-Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(21, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 149;
            this.label4.Text = "中心-X:";
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.uirb_RoiType);
            this.uiTitlePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel3.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Location = new System.Drawing.Point(0, 117);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.Padding = new System.Windows.Forms.Padding(2, 25, 2, 2);
            this.uiTitlePanel3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel3.Size = new System.Drawing.Size(277, 57);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.StyleCustomMode = true;
            this.uiTitlePanel3.TabIndex = 158;
            this.uiTitlePanel3.Text = "创建形状";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTitlePanel3.TitleInterval = 5;
            // 
            // uirb_RoiType
            // 
            this.uirb_RoiType.ColumnCount = 2;
            this.uirb_RoiType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uirb_RoiType.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uirb_RoiType.Items.AddRange(new object[] {
            "矩形",
            "圆形"});
            this.uirb_RoiType.ItemSize = new System.Drawing.Size(100, 20);
            this.uirb_RoiType.Location = new System.Drawing.Point(2, 25);
            this.uirb_RoiType.Margin = new System.Windows.Forms.Padding(0);
            this.uirb_RoiType.MinimumSize = new System.Drawing.Size(1, 1);
            this.uirb_RoiType.Name = "uirb_RoiType";
            this.uirb_RoiType.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.uirb_RoiType.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uirb_RoiType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uirb_RoiType.Size = new System.Drawing.Size(273, 30);
            this.uirb_RoiType.StartPos = new System.Drawing.Point(20, -10);
            this.uirb_RoiType.Style = Rex.UI.UIStyle.Custom;
            this.uirb_RoiType.TabIndex = 0;
            this.uirb_RoiType.Text = null;
            this.uirb_RoiType.ValueChanged += new Rex.UI.UIRadioButtonGroup.OnValueChanged(this.uirb_RoiType_ValueChanged);
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.uiLink_Coord);
            this.uiTitlePanel2.Controls.Add(this.label1);
            this.uiTitlePanel2.Controls.Add(this.uicb_CropImage);
            this.uiTitlePanel2.Controls.Add(this.label19);
            this.uiTitlePanel2.Controls.Add(this.uiLink_Image);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.Size = new System.Drawing.Size(277, 117);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.StyleCustomMode = true;
            this.uiTitlePanel2.TabIndex = 157;
            this.uiTitlePanel2.Text = "输入图像";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTitlePanel2.TitleInterval = 5;
            // 
            // uiLink_Coord
            // 
            this.uiLink_Coord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_Coord.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_Coord.Location = new System.Drawing.Point(66, 87);
            this.uiLink_Coord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_Coord.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_Coord.Name = "uiLink_Coord";
            this.uiLink_Coord.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_Coord.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_Coord.Size = new System.Drawing.Size(200, 24);
            this.uiLink_Coord.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_Coord.StyleCustomMode = true;
            this.uiLink_Coord.TabIndex = 144;
            this.uiLink_Coord.Text = "uiLinkText1";
            this.uiLink_Coord.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.uiLink_Coord.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.Style = Rex.UI.UIStyle.Custom;
            this.label1.TabIndex = 143;
            this.label1.Text = "参考坐标:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uicb_CropImage
            // 
            this.uicb_CropImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_CropImage.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_CropImage.ImageSize = 14;
            this.uicb_CropImage.Location = new System.Drawing.Point(66, 64);
            this.uicb_CropImage.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_CropImage.Name = "uicb_CropImage";
            this.uicb_CropImage.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.uicb_CropImage.Size = new System.Drawing.Size(189, 16);
            this.uicb_CropImage.Style = Rex.UI.UIStyle.Custom;
            this.uicb_CropImage.TabIndex = 142;
            this.uicb_CropImage.Text = "输出ROI裁切图像";
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
            this.uiLink_Image.Location = new System.Drawing.Point(66, 33);
            this.uiLink_Image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLink_Image.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_Image.Name = "uiLink_Image";
            this.uiLink_Image.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_Image.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_Image.Size = new System.Drawing.Size(200, 25);
            this.uiLink_Image.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_Image.StyleCustomMode = true;
            this.uiLink_Image.TabIndex = 141;
            this.uiLink_Image.Text = "uiLinkText1";
            this.uiLink_Image.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.uiLink_Image.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uicb_Result);
            this.tabPage2.Controls.Add(this.uicb_Area);
            this.tabPage2.Controls.Add(this.uicb_Roi);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(277, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "参数设置";
            // 
            // uicb_Result
            // 
            this.uicb_Result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Result.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Result.Location = new System.Drawing.Point(17, 62);
            this.uicb_Result.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Result.Name = "uicb_Result";
            this.uicb_Result.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Result.Size = new System.Drawing.Size(99, 21);
            this.uicb_Result.TabIndex = 21;
            this.uicb_Result.Text = "是否显示结果";
            // 
            // uicb_Area
            // 
            this.uicb_Area.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Area.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Area.Location = new System.Drawing.Point(17, 94);
            this.uicb_Area.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Area.Name = "uicb_Area";
            this.uicb_Area.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Area.Size = new System.Drawing.Size(123, 21);
            this.uicb_Area.TabIndex = 20;
            this.uicb_Area.Text = "是否显示查找范围";
            // 
            // uicb_Roi
            // 
            this.uicb_Roi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Roi.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Roi.Location = new System.Drawing.Point(17, 30);
            this.uicb_Roi.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Roi.Name = "uicb_Roi";
            this.uicb_Roi.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Roi.Size = new System.Drawing.Size(97, 21);
            this.uicb_Roi.TabIndex = 19;
            this.uicb_Roi.Text = "是否显示ROI";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Color1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bt_Draw1);
            this.panel1.Controls.Add(this.cmb_CurrentImg);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 441);
            this.panel1.TabIndex = 0;
            // 
            // bt_Color1
            // 
            this.bt_Color1.Location = new System.Drawing.Point(0, 0);
            this.bt_Color1.Name = "bt_Color1";
            this.bt_Color1.Size = new System.Drawing.Size(75, 23);
            this.bt_Color1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 1;
            // 
            // bt_Draw1
            // 
            this.bt_Draw1.Location = new System.Drawing.Point(0, 0);
            this.bt_Draw1.Name = "bt_Draw1";
            this.bt_Draw1.Size = new System.Drawing.Size(75, 23);
            this.bt_Draw1.TabIndex = 2;
            // 
            // cmb_CurrentImg
            // 
            this.cmb_CurrentImg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CurrentImg.FormattingEnabled = true;
            this.cmb_CurrentImg.Location = new System.Drawing.Point(85, 26);
            this.cmb_CurrentImg.Name = "cmb_CurrentImg";
            this.cmb_CurrentImg.Size = new System.Drawing.Size(149, 20);
            this.cmb_CurrentImg.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 35;
            this.label12.Text = "当前图像：";
            // 
            // mWindowH
            // 
            this.mWindowH.BackColor = System.Drawing.Color.Transparent;
            this.mWindowH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mWindowH.BackgroundImage")));
            this.mWindowH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mWindowH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mWindowH.Dock = System.Windows.Forms.DockStyle.Right;
            this.mWindowH.DrawModel = false;
            this.mWindowH.Image = null;
            this.mWindowH.Location = new System.Drawing.Point(287, 1);
            this.mWindowH.Margin = new System.Windows.Forms.Padding(5);
            this.mWindowH.Name = "mWindowH";
            this.mWindowH.Padding = new System.Windows.Forms.Padding(1);
            this.mWindowH.Size = new System.Drawing.Size(560, 471);
            this.mWindowH.TabIndex = 9;
            // 
            // CreateROIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateROIForm";
            this.Load += new System.EventHandler(this.CreateROIForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.uiTitlePanel4.ResumeLayout(false);
            this.uiTitlePanel4.PerformLayout();
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.CTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.ComboBox cmb_CurrentImg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bt_Draw1;
        private System.Windows.Forms.Button bt_Color1;
        private System.Windows.Forms.Label label6;
        private Rex.UI.UITitlePanel uiTitlePanel4;
        private Rex.UI.UILinkText uiLink_CentreY;
        private Rex.UI.UILinkText uiLink_CentreX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private Rex.UI.UIRadioButtonGroup uirb_RoiType;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private System.Windows.Forms.Label label19;
        private Rex.UI.UILinkText uiLink_Image;
        private Rex.UI.UICheckBox uicb_CropImage;
        private RexView.HWindow_HE mWindowH;
        private Rex.UI.UILinkText uiLink_Coord;
        private Rex.UI.UILabel label1;
        private Rex.UI.UICheckBox uicb_Result;
        private Rex.UI.UICheckBox uicb_Area;
        private Rex.UI.UICheckBox uicb_Roi;
    }
}