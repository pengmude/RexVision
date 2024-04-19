namespace Plugin.LumaCheck
{
    partial class LumaCheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LumaCheckForm));
            this.tabControl1 = new Rex.CTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.uitb_Range = new Rex.UI.UITextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uitb_Max = new Rex.UI.UITextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uitb_Min = new Rex.UI.UITextBox();
            this.uitb_Mean = new Rex.UI.UITextBox();
            this.uitb_Area = new Rex.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.uidd_MaxThreshold = new Rex.UI.UIDoubleUpDownB();
            this.uidd_MinThreshold = new Rex.UI.UIDoubleUpDownB();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.uilk_Roi = new Rex.UI.UILinkText();
            this.label12 = new System.Windows.Forms.Label();
            this.uipl_SetInPut = new Rex.UI.UITitlePanel();
            this.uilk_Image = new Rex.UI.UILinkData();
            this.label34 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mWindowH = new RexView.HWindow_HE();
            this.uicb_Result = new Rex.UI.UICheckBox();
            this.uicb_Area = new Rex.UI.UICheckBox();
            this.uicb_Roi = new Rex.UI.UICheckBox();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
            this.uipl_SetInPut.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.uiTitlePanel1);
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
            this.uiTitlePanel2.Controls.Add(this.uitb_Range);
            this.uiTitlePanel2.Controls.Add(this.label6);
            this.uiTitlePanel2.Controls.Add(this.uitb_Max);
            this.uiTitlePanel2.Controls.Add(this.label2);
            this.uiTitlePanel2.Controls.Add(this.uitb_Min);
            this.uiTitlePanel2.Controls.Add(this.uitb_Mean);
            this.uiTitlePanel2.Controls.Add(this.uitb_Area);
            this.uiTitlePanel2.Controls.Add(this.label1);
            this.uiTitlePanel2.Controls.Add(this.label4);
            this.uiTitlePanel2.Controls.Add(this.label9);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(0, 252);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.Size = new System.Drawing.Size(277, 192);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.StyleCustomMode = true;
            this.uiTitlePanel2.TabIndex = 122;
            this.uiTitlePanel2.Text = "查找结果";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uitb_Range
            // 
            this.uitb_Range.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uitb_Range.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitb_Range.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitb_Range.Location = new System.Drawing.Point(73, 160);
            this.uitb_Range.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uitb_Range.Maximum = 2147483647D;
            this.uitb_Range.MaximumSize = new System.Drawing.Size(400, 22);
            this.uitb_Range.Minimum = -2147483648D;
            this.uitb_Range.MinimumSize = new System.Drawing.Size(20, 22);
            this.uitb_Range.Name = "uitb_Range";
            this.uitb_Range.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitb_Range.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitb_Range.Size = new System.Drawing.Size(192, 22);
            this.uitb_Range.Style = Rex.UI.UIStyle.Custom;
            this.uitb_Range.TabIndex = 147;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(40, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 146;
            this.label6.Text = "范围:";
            // 
            // uitb_Max
            // 
            this.uitb_Max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uitb_Max.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitb_Max.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitb_Max.Location = new System.Drawing.Point(73, 130);
            this.uitb_Max.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uitb_Max.Maximum = 2147483647D;
            this.uitb_Max.MaximumSize = new System.Drawing.Size(400, 22);
            this.uitb_Max.Minimum = -2147483648D;
            this.uitb_Max.MinimumSize = new System.Drawing.Size(20, 22);
            this.uitb_Max.Name = "uitb_Max";
            this.uitb_Max.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitb_Max.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitb_Max.Size = new System.Drawing.Size(192, 22);
            this.uitb_Max.Style = Rex.UI.UIStyle.Custom;
            this.uitb_Max.TabIndex = 145;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(40, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 144;
            this.label2.Text = "最大:";
            // 
            // uitb_Min
            // 
            this.uitb_Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uitb_Min.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitb_Min.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitb_Min.Location = new System.Drawing.Point(73, 100);
            this.uitb_Min.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uitb_Min.Maximum = 2147483647D;
            this.uitb_Min.MaximumSize = new System.Drawing.Size(400, 22);
            this.uitb_Min.Minimum = -2147483648D;
            this.uitb_Min.MinimumSize = new System.Drawing.Size(20, 22);
            this.uitb_Min.Name = "uitb_Min";
            this.uitb_Min.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitb_Min.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitb_Min.Size = new System.Drawing.Size(192, 22);
            this.uitb_Min.Style = Rex.UI.UIStyle.Custom;
            this.uitb_Min.TabIndex = 143;
            // 
            // uitb_Mean
            // 
            this.uitb_Mean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uitb_Mean.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitb_Mean.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitb_Mean.Location = new System.Drawing.Point(73, 70);
            this.uitb_Mean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uitb_Mean.Maximum = 2147483647D;
            this.uitb_Mean.MaximumSize = new System.Drawing.Size(400, 22);
            this.uitb_Mean.Minimum = -2147483648D;
            this.uitb_Mean.MinimumSize = new System.Drawing.Size(20, 22);
            this.uitb_Mean.Name = "uitb_Mean";
            this.uitb_Mean.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitb_Mean.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitb_Mean.Size = new System.Drawing.Size(192, 22);
            this.uitb_Mean.Style = Rex.UI.UIStyle.Custom;
            this.uitb_Mean.TabIndex = 142;
            // 
            // uitb_Area
            // 
            this.uitb_Area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uitb_Area.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitb_Area.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitb_Area.Location = new System.Drawing.Point(73, 40);
            this.uitb_Area.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uitb_Area.Maximum = 2147483647D;
            this.uitb_Area.MaximumSize = new System.Drawing.Size(400, 22);
            this.uitb_Area.Minimum = -2147483648D;
            this.uitb_Area.MinimumSize = new System.Drawing.Size(20, 22);
            this.uitb_Area.Name = "uitb_Area";
            this.uitb_Area.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitb_Area.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitb_Area.Size = new System.Drawing.Size(192, 22);
            this.uitb_Area.Style = Rex.UI.UIStyle.Custom;
            this.uitb_Area.TabIndex = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(40, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 140;
            this.label1.Text = "最小:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(40, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 138;
            this.label4.Text = "面积:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(40, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 139;
            this.label9.Text = "平均:";
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uidd_MaxThreshold);
            this.uiTitlePanel1.Controls.Add(this.uidd_MinThreshold);
            this.uiTitlePanel1.Controls.Add(this.label3);
            this.uiTitlePanel1.Controls.Add(this.label5);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(0, 142);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.Size = new System.Drawing.Size(277, 110);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.StyleCustomMode = true;
            this.uiTitlePanel1.TabIndex = 124;
            this.uiTitlePanel1.Text = "查找参数";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uidd_MaxThreshold
            // 
            this.uidd_MaxThreshold.Decimal = 0;
            this.uidd_MaxThreshold.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_MaxThreshold.HasMaximum = true;
            this.uidd_MaxThreshold.HasMinimum = true;
            this.uidd_MaxThreshold.Location = new System.Drawing.Point(73, 68);
            this.uidd_MaxThreshold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uidd_MaxThreshold.Maximum = 200D;
            this.uidd_MaxThreshold.Minimum = 1D;
            this.uidd_MaxThreshold.MinimumSize = new System.Drawing.Size(100, 0);
            this.uidd_MaxThreshold.Name = "uidd_MaxThreshold";
            this.uidd_MaxThreshold.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_MaxThreshold.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_MaxThreshold.Size = new System.Drawing.Size(192, 24);
            this.uidd_MaxThreshold.Step = 1D;
            this.uidd_MaxThreshold.Style = Rex.UI.UIStyle.LightBlue;
            this.uidd_MaxThreshold.StyleCustomMode = true;
            this.uidd_MaxThreshold.TabIndex = 150;
            this.uidd_MaxThreshold.Text = null;
            this.uidd_MaxThreshold.Value = 1D;
            // 
            // uidd_MinThreshold
            // 
            this.uidd_MinThreshold.Decimal = 0;
            this.uidd_MinThreshold.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_MinThreshold.HasMaximum = true;
            this.uidd_MinThreshold.HasMinimum = true;
            this.uidd_MinThreshold.Location = new System.Drawing.Point(73, 38);
            this.uidd_MinThreshold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uidd_MinThreshold.Maximum = 200D;
            this.uidd_MinThreshold.Minimum = 1D;
            this.uidd_MinThreshold.MinimumSize = new System.Drawing.Size(100, 0);
            this.uidd_MinThreshold.Name = "uidd_MinThreshold";
            this.uidd_MinThreshold.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_MinThreshold.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_MinThreshold.Size = new System.Drawing.Size(192, 24);
            this.uidd_MinThreshold.Step = 1D;
            this.uidd_MinThreshold.Style = Rex.UI.UIStyle.LightBlue;
            this.uidd_MinThreshold.StyleCustomMode = true;
            this.uidd_MinThreshold.TabIndex = 149;
            this.uidd_MinThreshold.Text = null;
            this.uidd_MinThreshold.Value = 1D;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(16, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 138;
            this.label3.Text = "最小阈值:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(16, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 139;
            this.label5.Text = "最大阈值:";
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.uilk_Roi);
            this.uiTitlePanel3.Controls.Add(this.label12);
            this.uiTitlePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel3.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Location = new System.Drawing.Point(0, 71);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel3.Size = new System.Drawing.Size(277, 71);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.StyleCustomMode = true;
            this.uiTitlePanel3.TabIndex = 123;
            this.uiTitlePanel3.Text = "检测区域";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uilk_Roi
            // 
            this.uilk_Roi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilk_Roi.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uilk_Roi.Location = new System.Drawing.Point(73, 33);
            this.uilk_Roi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilk_Roi.MinimumSize = new System.Drawing.Size(1, 1);
            this.uilk_Roi.Name = "uilk_Roi";
            this.uilk_Roi.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_Roi.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_Roi.Size = new System.Drawing.Size(192, 25);
            this.uilk_Roi.Style = Rex.UI.UIStyle.Custom;
            this.uilk_Roi.StyleCustomMode = true;
            this.uilk_Roi.TabIndex = 124;
            this.uilk_Roi.Text = "uiLinkText1";
            this.uilk_Roi.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_BtnAdd);
            this.uilk_Roi.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(16, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 138;
            this.label12.Text = "链接区域:";
            // 
            // uipl_SetInPut
            // 
            this.uipl_SetInPut.Controls.Add(this.uilk_Image);
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
            this.uipl_SetInPut.Size = new System.Drawing.Size(277, 71);
            this.uipl_SetInPut.Style = Rex.UI.UIStyle.Custom;
            this.uipl_SetInPut.StyleCustomMode = true;
            this.uipl_SetInPut.TabIndex = 120;
            this.uipl_SetInPut.Text = "图像设置";
            this.uipl_SetInPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uipl_SetInPut.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uilk_Image
            // 
            this.uilk_Image.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uilk_Image.Location = new System.Drawing.Point(73, 34);
            this.uilk_Image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilk_Image.MinimumSize = new System.Drawing.Size(100, 0);
            this.uilk_Image.Name = "uilk_Image";
            this.uilk_Image.Radius = 0;
            this.uilk_Image.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_Image.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_Image.Size = new System.Drawing.Size(192, 25);
            this.uilk_Image.StyleCustomMode = true;
            this.uilk_Image.TabIndex = 135;
            this.uilk_Image.Tag = "九点标定";
            this.uilk_Image.Text = "九点标定";
            this.uilk_Image.BtnAdd += new Rex.UI.UILinkData.BtnAddHandle(this.uiLink_BtnAdd);
            this.uilk_Image.BtnDec += new Rex.UI.UILinkData.BtnDecHandle(this.uiLink_BtnDec);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label34.Location = new System.Drawing.Point(16, 38);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 17);
            this.label34.TabIndex = 3;
            this.label34.Text = "输入图像:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.tabPage2.Controls.Add(this.uicb_Result);
            this.tabPage2.Controls.Add(this.uicb_Area);
            this.tabPage2.Controls.Add(this.uicb_Roi);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(277, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "显示设置";
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
            this.mWindowH.TabIndex = 15;
            // 
            // uicb_Result
            // 
            this.uicb_Result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Result.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Result.Location = new System.Drawing.Point(17, 55);
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
            this.uicb_Area.Location = new System.Drawing.Point(17, 87);
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
            this.uicb_Roi.Location = new System.Drawing.Point(17, 23);
            this.uicb_Roi.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Roi.Name = "uicb_Roi";
            this.uicb_Roi.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Roi.Size = new System.Drawing.Size(97, 21);
            this.uicb_Roi.TabIndex = 19;
            this.uicb_Roi.Text = "是否显示ROI";
            // 
            // LumaCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LumaCheckForm";
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
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel3.PerformLayout();
            this.uipl_SetInPut.ResumeLayout(false);
            this.uipl_SetInPut.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.CTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private Rex.UI.UILinkText uilk_Roi;
        private System.Windows.Forms.Label label12;
        private Rex.UI.UITitlePanel uipl_SetInPut;
        private Rex.UI.UILinkData uilk_Image;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TabPage tabPage2;
        private Rex.UI.UITextBox uitb_Min;
        private Rex.UI.UITextBox uitb_Mean;
        private Rex.UI.UITextBox uitb_Area;
        private RexView.HWindow_HE mWindowH;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Rex.UI.UIDoubleUpDownB uidd_MaxThreshold;
        private Rex.UI.UIDoubleUpDownB uidd_MinThreshold;
        private Rex.UI.UITextBox uitb_Range;
        private System.Windows.Forms.Label label6;
        private Rex.UI.UITextBox uitb_Max;
        private System.Windows.Forms.Label label2;
        private Rex.UI.UICheckBox uicb_Result;
        private Rex.UI.UICheckBox uicb_Area;
        private Rex.UI.UICheckBox uicb_Roi;
    }
}