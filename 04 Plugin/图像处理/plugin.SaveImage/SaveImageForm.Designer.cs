namespace Plugin.SaveImage
{
    partial class SaveImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveImageForm));
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.label6 = new System.Windows.Forms.Label();
            this.uiLink_SaveDay = new Rex.UI.UILinkText();
            this.uicb_AutoRemov = new Rex.UI.UICheckBox();
            this.uicb_SaveType = new Rex.UI.UIComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uiLink_FilePath = new Rex.UI.UILinkPath();
            this.label3 = new System.Windows.Forms.Label();
            this.uicb_AutoFileGroup = new Rex.UI.UICheckBox();
            this.uicb_AddTime = new Rex.UI.UICheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uiLink_SaveName = new Rex.UI.UILinkText();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.uicb_SaveOffLine = new Rex.UI.UICheckBox();
            this.uicb_SaveRoiTxt = new Rex.UI.UICheckBox();
            this.uicb_SaveEnable = new Rex.UI.UICheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiLink_Image = new Rex.UI.UILinkText();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Location = new System.Drawing.Point(1, 459);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_bottom.Size = new System.Drawing.Size(346, 38);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.uiTitlePanel1);
            this.panel_center.Controls.Add(this.uiTitlePanel2);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.Size = new System.Drawing.Size(346, 426);
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Location = new System.Drawing.Point(2, 6);
            this.uitb_Remark.Margin = new System.Windows.Forms.Padding(2);
            this.uitb_Remark.Size = new System.Drawing.Size(10, 23);
            this.uitb_Remark.Visible = false;
            // 
            // uIlb_describle
            // 
            this.uIlb_describle.AutoSize = false;
            this.uIlb_describle.Location = new System.Drawing.Point(2, 9);
            this.uIlb_describle.Size = new System.Drawing.Size(10, 17);
            this.uIlb_describle.Visible = false;
            // 
            // cb_Enable
            // 
            this.cb_Enable.Location = new System.Drawing.Point(12, 9);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(256, 6);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(166, 6);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(76, 6);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(346, 32);
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.label6);
            this.uiTitlePanel1.Controls.Add(this.uiLink_SaveDay);
            this.uiTitlePanel1.Controls.Add(this.uicb_AutoRemov);
            this.uiTitlePanel1.Controls.Add(this.uicb_SaveType);
            this.uiTitlePanel1.Controls.Add(this.label4);
            this.uiTitlePanel1.Controls.Add(this.uiLink_FilePath);
            this.uiTitlePanel1.Controls.Add(this.label3);
            this.uiTitlePanel1.Controls.Add(this.uicb_AutoFileGroup);
            this.uiTitlePanel1.Controls.Add(this.uicb_AddTime);
            this.uiTitlePanel1.Controls.Add(this.label5);
            this.uiTitlePanel1.Controls.Add(this.uiLink_SaveName);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(1, 166);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.Size = new System.Drawing.Size(344, 259);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.StyleCustomMode = true;
            this.uiTitlePanel1.TabIndex = 145;
            this.uiTitlePanel1.Text = "文件设置";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(18, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 166;
            this.label6.Text = "存储天数:";
            // 
            // uiLink_SaveDay
            // 
            this.uiLink_SaveDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_SaveDay.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_SaveDay.Location = new System.Drawing.Point(74, 137);
            this.uiLink_SaveDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_SaveDay.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_SaveDay.Name = "uiLink_SaveDay";
            this.uiLink_SaveDay.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_SaveDay.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_SaveDay.Size = new System.Drawing.Size(250, 24);
            this.uiLink_SaveDay.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_SaveDay.StyleCustomMode = true;
            this.uiLink_SaveDay.TabIndex = 165;
            this.uiLink_SaveDay.Text = "uiLinkText2";
            this.uiLink_SaveDay.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.uiLink_SaveDay.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // uicb_AutoRemov
            // 
            this.uicb_AutoRemov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uicb_AutoRemov.Checked = true;
            this.uicb_AutoRemov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_AutoRemov.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_AutoRemov.Location = new System.Drawing.Point(74, 194);
            this.uicb_AutoRemov.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_AutoRemov.Name = "uicb_AutoRemov";
            this.uicb_AutoRemov.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_AutoRemov.Size = new System.Drawing.Size(182, 17);
            this.uicb_AutoRemov.Style = Rex.UI.UIStyle.Custom;
            this.uicb_AutoRemov.TabIndex = 164;
            this.uicb_AutoRemov.Text = "自动清理过期文件夹";
            // 
            // uicb_SaveType
            // 
            this.uicb_SaveType.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_SaveType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uicb_SaveType.Items.AddRange(new object[] {
            "jpg",
            "png",
            "bmp",
            "tiff",
            "gif",
            "he"});
            this.uicb_SaveType.Location = new System.Drawing.Point(74, 72);
            this.uicb_SaveType.Margin = new System.Windows.Forms.Padding(0);
            this.uicb_SaveType.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicb_SaveType.Name = "uicb_SaveType";
            this.uicb_SaveType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicb_SaveType.Radius = 2;
            this.uicb_SaveType.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicb_SaveType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicb_SaveType.Size = new System.Drawing.Size(250, 23);
            this.uicb_SaveType.Style = Rex.UI.UIStyle.Custom;
            this.uicb_SaveType.StyleCustomMode = true;
            this.uicb_SaveType.TabIndex = 163;
            this.uicb_SaveType.Text = "jpg";
            this.uicb_SaveType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(18, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 162;
            this.label4.Text = "存储格式:";
            // 
            // uiLink_FilePath
            // 
            this.uiLink_FilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_FilePath.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_FilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiLink_FilePath.Location = new System.Drawing.Point(74, 39);
            this.uiLink_FilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_FilePath.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_FilePath.Name = "uiLink_FilePath";
            this.uiLink_FilePath.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_FilePath.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_FilePath.Size = new System.Drawing.Size(250, 24);
            this.uiLink_FilePath.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_FilePath.StyleCustomMode = true;
            this.uiLink_FilePath.TabIndex = 161;
            this.uiLink_FilePath.Text = "uiLink_SavePath";
            this.uiLink_FilePath.BtnAdd += new Rex.UI.UILinkPath.BtnAddHandle(this.uiLink_SavePath_BtnAdd);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(18, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 160;
            this.label3.Text = "存储路径:";
            // 
            // uicb_AutoFileGroup
            // 
            this.uicb_AutoFileGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uicb_AutoFileGroup.Checked = true;
            this.uicb_AutoFileGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_AutoFileGroup.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_AutoFileGroup.Location = new System.Drawing.Point(74, 219);
            this.uicb_AutoFileGroup.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_AutoFileGroup.Name = "uicb_AutoFileGroup";
            this.uicb_AutoFileGroup.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_AutoFileGroup.Size = new System.Drawing.Size(182, 17);
            this.uicb_AutoFileGroup.Style = Rex.UI.UIStyle.Custom;
            this.uicb_AutoFileGroup.TabIndex = 159;
            this.uicb_AutoFileGroup.Text = "使用日期文件夹归类";
            // 
            // uicb_AddTime
            // 
            this.uicb_AddTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uicb_AddTime.Checked = true;
            this.uicb_AddTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_AddTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_AddTime.Location = new System.Drawing.Point(74, 170);
            this.uicb_AddTime.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_AddTime.Name = "uicb_AddTime";
            this.uicb_AddTime.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_AddTime.Size = new System.Drawing.Size(182, 17);
            this.uicb_AddTime.Style = Rex.UI.UIStyle.Custom;
            this.uicb_AddTime.TabIndex = 158;
            this.uicb_AddTime.Text = "文件名自动添加时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(18, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 157;
            this.label5.Text = "文件名称:";
            // 
            // uiLink_SaveName
            // 
            this.uiLink_SaveName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_SaveName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_SaveName.Location = new System.Drawing.Point(74, 104);
            this.uiLink_SaveName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_SaveName.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_SaveName.Name = "uiLink_SaveName";
            this.uiLink_SaveName.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_SaveName.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_SaveName.Size = new System.Drawing.Size(250, 24);
            this.uiLink_SaveName.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_SaveName.StyleCustomMode = true;
            this.uiLink_SaveName.TabIndex = 156;
            this.uiLink_SaveName.Text = "uiLink_SaveName";
            this.uiLink_SaveName.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.uiLink_SaveName.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.uicb_SaveOffLine);
            this.uiTitlePanel2.Controls.Add(this.uicb_SaveRoiTxt);
            this.uiTitlePanel2.Controls.Add(this.uicb_SaveEnable);
            this.uiTitlePanel2.Controls.Add(this.label1);
            this.uiTitlePanel2.Controls.Add(this.uiLink_Image);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(1, 1);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.Size = new System.Drawing.Size(344, 165);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.StyleCustomMode = true;
            this.uiTitlePanel2.TabIndex = 146;
            this.uiTitlePanel2.Text = "图像设置";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uicb_SaveOffLine
            // 
            this.uicb_SaveOffLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uicb_SaveOffLine.Checked = true;
            this.uicb_SaveOffLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_SaveOffLine.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_SaveOffLine.Location = new System.Drawing.Point(75, 124);
            this.uicb_SaveOffLine.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_SaveOffLine.Name = "uicb_SaveOffLine";
            this.uicb_SaveOffLine.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_SaveOffLine.Size = new System.Drawing.Size(182, 17);
            this.uicb_SaveOffLine.Style = Rex.UI.UIStyle.Custom;
            this.uicb_SaveOffLine.TabIndex = 160;
            this.uicb_SaveOffLine.Text = "保存离线图片";
            // 
            // uicb_SaveRoiTxt
            // 
            this.uicb_SaveRoiTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uicb_SaveRoiTxt.Checked = true;
            this.uicb_SaveRoiTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_SaveRoiTxt.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_SaveRoiTxt.Location = new System.Drawing.Point(75, 99);
            this.uicb_SaveRoiTxt.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_SaveRoiTxt.Name = "uicb_SaveRoiTxt";
            this.uicb_SaveRoiTxt.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_SaveRoiTxt.Size = new System.Drawing.Size(182, 17);
            this.uicb_SaveRoiTxt.Style = Rex.UI.UIStyle.Custom;
            this.uicb_SaveRoiTxt.TabIndex = 159;
            this.uicb_SaveRoiTxt.Text = "保存文字图框";
            // 
            // uicb_SaveEnable
            // 
            this.uicb_SaveEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uicb_SaveEnable.Checked = true;
            this.uicb_SaveEnable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_SaveEnable.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_SaveEnable.Location = new System.Drawing.Point(75, 75);
            this.uicb_SaveEnable.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_SaveEnable.Name = "uicb_SaveEnable";
            this.uicb_SaveEnable.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_SaveEnable.Size = new System.Drawing.Size(182, 17);
            this.uicb_SaveEnable.Style = Rex.UI.UIStyle.Custom;
            this.uicb_SaveEnable.TabIndex = 158;
            this.uicb_SaveEnable.Text = "保存图像启用";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 157;
            this.label1.Text = "存储图像:";
            // 
            // uiLink_Image
            // 
            this.uiLink_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_Image.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_Image.Location = new System.Drawing.Point(75, 41);
            this.uiLink_Image.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_Image.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_Image.Name = "uiLink_Image";
            this.uiLink_Image.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_Image.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_Image.Size = new System.Drawing.Size(250, 24);
            this.uiLink_Image.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_Image.StyleCustomMode = true;
            this.uiLink_Image.TabIndex = 156;
            this.uiLink_Image.Text = "uiLinkText1";
            this.uiLink_Image.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.uiLink_Image.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // SaveImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 498);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(350, 500);
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "SaveImageForm";
            this.Load += new System.EventHandler(this.DelayModForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.UI.UITitlePanel uiTitlePanel1;
        private System.Windows.Forms.Label label6;
        private Rex.UI.UILinkText uiLink_SaveDay;
        private Rex.UI.UICheckBox uicb_AutoRemov;
        private Rex.UI.UIComboBox uicb_SaveType;
        private System.Windows.Forms.Label label4;
        private Rex.UI.UILinkPath uiLink_FilePath;
        private System.Windows.Forms.Label label3;
        private Rex.UI.UICheckBox uicb_AutoFileGroup;
        private Rex.UI.UICheckBox uicb_AddTime;
        private System.Windows.Forms.Label label5;
        private Rex.UI.UILinkText uiLink_SaveName;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private Rex.UI.UICheckBox uicb_SaveOffLine;
        private Rex.UI.UICheckBox uicb_SaveRoiTxt;
        private Rex.UI.UICheckBox uicb_SaveEnable;
        private System.Windows.Forms.Label label1;
        private Rex.UI.UILinkText uiLink_Image;
    }
}