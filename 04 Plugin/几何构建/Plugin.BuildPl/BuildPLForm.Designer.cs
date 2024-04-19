namespace Plugin.BuildPL
{
    partial class BuildPLForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildPLForm));
            this.tabControl1 = new Rex.CTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.tb_L = new RexControl.CTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Y = new RexControl.CTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_X = new RexControl.CTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uiTitlePanel4 = new Rex.UI.UITitlePanel();
            this.uilk_PointY = new Rex.UI.UILinkText();
            this.uilk_PointX = new Rex.UI.UILinkText();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uilk_LineR = new Rex.UI.UILinkText();
            this.label1 = new System.Windows.Forms.Label();
            this.uilk_Line2 = new Rex.UI.UILinkText();
            this.uilk_Line1 = new Rex.UI.UILinkText();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.label19 = new System.Windows.Forms.Label();
            this.uilk_Image = new Rex.UI.UILinkText();
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
            this.uiTitlePanel1.SuspendLayout();
            this.uiTitlePanel4.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(285, 473);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.uiTitlePanel1);
            this.tabPage1.Controls.Add(this.uiTitlePanel4);
            this.tabPage1.Controls.Add(this.uiTitlePanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(277, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.tb_L);
            this.uiTitlePanel1.Controls.Add(this.label7);
            this.uiTitlePanel1.Controls.Add(this.tb_Y);
            this.uiTitlePanel1.Controls.Add(this.label6);
            this.uiTitlePanel1.Controls.Add(this.tb_X);
            this.uiTitlePanel1.Controls.Add(this.label5);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(3, 276);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.Size = new System.Drawing.Size(271, 164);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.StyleCustomMode = true;
            this.uiTitlePanel1.TabIndex = 142;
            this.uiTitlePanel1.Text = "输出数据";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_L
            // 
            this.tb_L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tb_L.DefaultText = "";
            this.tb_L.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_L.Location = new System.Drawing.Point(62, 106);
            this.tb_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_L.MaximumSize = new System.Drawing.Size(400, 22);
            this.tb_L.MinimumSize = new System.Drawing.Size(20, 22);
            this.tb_L.Name = "tb_L";
            this.tb_L.PasswordChar = false;
            this.tb_L.Size = new System.Drawing.Size(193, 22);
            this.tb_L.TabIndex = 153;
            this.tb_L.TextStr = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(30, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 152;
            this.label7.Text = "距离:";
            // 
            // tb_Y
            // 
            this.tb_Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tb_Y.DefaultText = "";
            this.tb_Y.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Y.Location = new System.Drawing.Point(62, 76);
            this.tb_Y.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Y.MaximumSize = new System.Drawing.Size(400, 22);
            this.tb_Y.MinimumSize = new System.Drawing.Size(20, 22);
            this.tb_Y.Name = "tb_Y";
            this.tb_Y.PasswordChar = false;
            this.tb_Y.Size = new System.Drawing.Size(193, 22);
            this.tb_Y.TabIndex = 151;
            this.tb_Y.TextStr = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(23, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 150;
            this.label6.Text = "垂足Y:";
            // 
            // tb_X
            // 
            this.tb_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tb_X.DefaultText = "";
            this.tb_X.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_X.Location = new System.Drawing.Point(62, 46);
            this.tb_X.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_X.MaximumSize = new System.Drawing.Size(400, 22);
            this.tb_X.MinimumSize = new System.Drawing.Size(20, 22);
            this.tb_X.Name = "tb_X";
            this.tb_X.PasswordChar = false;
            this.tb_X.Size = new System.Drawing.Size(193, 22);
            this.tb_X.TabIndex = 149;
            this.tb_X.TextStr = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(22, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 146;
            this.label5.Text = "垂足X:";
            // 
            // uiTitlePanel4
            // 
            this.uiTitlePanel4.Controls.Add(this.uilk_PointY);
            this.uiTitlePanel4.Controls.Add(this.uilk_PointX);
            this.uiTitlePanel4.Controls.Add(this.label3);
            this.uiTitlePanel4.Controls.Add(this.label4);
            this.uiTitlePanel4.Controls.Add(this.uilk_LineR);
            this.uiTitlePanel4.Controls.Add(this.label1);
            this.uiTitlePanel4.Controls.Add(this.uilk_Line2);
            this.uiTitlePanel4.Controls.Add(this.uilk_Line1);
            this.uiTitlePanel4.Controls.Add(this.label21);
            this.uiTitlePanel4.Controls.Add(this.label20);
            this.uiTitlePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel4.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel4.Location = new System.Drawing.Point(3, 83);
            this.uiTitlePanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel4.Name = "uiTitlePanel4";
            this.uiTitlePanel4.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel4.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel4.Size = new System.Drawing.Size(271, 357);
            this.uiTitlePanel4.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel4.StyleCustomMode = true;
            this.uiTitlePanel4.TabIndex = 141;
            this.uiTitlePanel4.Text = "参数设置";
            this.uiTitlePanel4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uilk_PointY
            // 
            this.uilk_PointY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilk_PointY.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uilk_PointY.Location = new System.Drawing.Point(61, 71);
            this.uilk_PointY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilk_PointY.MinimumSize = new System.Drawing.Size(1, 1);
            this.uilk_PointY.Name = "uilk_PointY";
            this.uilk_PointY.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_PointY.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_PointY.Size = new System.Drawing.Size(194, 25);
            this.uilk_PointY.Style = Rex.UI.UIStyle.Custom;
            this.uilk_PointY.StyleCustomMode = true;
            this.uilk_PointY.TabIndex = 152;
            this.uilk_PointY.Text = "uiLinkText2";
            this.uilk_PointY.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uilk_BtnAdd);
            this.uilk_PointY.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uilk_BtnDec);
            // 
            // uilk_PointX
            // 
            this.uilk_PointX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilk_PointX.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uilk_PointX.Location = new System.Drawing.Point(61, 41);
            this.uilk_PointX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilk_PointX.MinimumSize = new System.Drawing.Size(1, 1);
            this.uilk_PointX.Name = "uilk_PointX";
            this.uilk_PointX.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_PointX.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_PointX.Size = new System.Drawing.Size(194, 25);
            this.uilk_PointX.Style = Rex.UI.UIStyle.Custom;
            this.uilk_PointX.StyleCustomMode = true;
            this.uilk_PointX.TabIndex = 151;
            this.uilk_PointX.Text = "uiLinkText1";
            this.uilk_PointX.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uilk_BtnAdd);
            this.uilk_PointX.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uilk_BtnDec);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(28, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 150;
            this.label3.Text = "点-Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(28, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 149;
            this.label4.Text = "点-X:";
            // 
            // uilk_LineR
            // 
            this.uilk_LineR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilk_LineR.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uilk_LineR.Location = new System.Drawing.Point(61, 157);
            this.uilk_LineR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilk_LineR.MinimumSize = new System.Drawing.Size(1, 1);
            this.uilk_LineR.Name = "uilk_LineR";
            this.uilk_LineR.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_LineR.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_LineR.Size = new System.Drawing.Size(194, 25);
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
            this.label1.Location = new System.Drawing.Point(28, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 145;
            this.label1.Text = "线-R:";
            // 
            // uilk_Line2
            // 
            this.uilk_Line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilk_Line2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uilk_Line2.Location = new System.Drawing.Point(61, 127);
            this.uilk_Line2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilk_Line2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uilk_Line2.Name = "uilk_Line2";
            this.uilk_Line2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_Line2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_Line2.Size = new System.Drawing.Size(194, 25);
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
            this.uilk_Line1.Location = new System.Drawing.Point(61, 97);
            this.uilk_Line1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilk_Line1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uilk_Line1.Name = "uilk_Line1";
            this.uilk_Line1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_Line1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_Line1.Size = new System.Drawing.Size(194, 25);
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
            this.label21.Location = new System.Drawing.Point(28, 130);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 17);
            this.label21.TabIndex = 7;
            this.label21.Text = "线-Y:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(28, 100);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 17);
            this.label20.TabIndex = 4;
            this.label20.Text = "线-X:";
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.label19);
            this.uiTitlePanel2.Controls.Add(this.uilk_Image);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(3, 3);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.Size = new System.Drawing.Size(271, 80);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.StyleCustomMode = true;
            this.uiTitlePanel2.TabIndex = 154;
            this.uiTitlePanel2.Text = "输入图像";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(5, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 17);
            this.label19.TabIndex = 3;
            this.label19.Text = "输入图像:";
            // 
            // uilk_Image
            // 
            this.uilk_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilk_Image.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uilk_Image.Location = new System.Drawing.Point(61, 34);
            this.uilk_Image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilk_Image.MinimumSize = new System.Drawing.Size(1, 1);
            this.uilk_Image.Name = "uilk_Image";
            this.uilk_Image.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_Image.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_Image.Size = new System.Drawing.Size(194, 25);
            this.uilk_Image.Style = Rex.UI.UIStyle.Custom;
            this.uilk_Image.StyleCustomMode = true;
            this.uilk_Image.TabIndex = 141;
            this.uilk_Image.Text = "uiLinkText1";
            this.uilk_Image.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uilk_BtnAdd);
            this.uilk_Image.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uilk_BtnDec);
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
            this.tabPage2.Size = new System.Drawing.Size(277, 443);
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
            // BuildPLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuildPLForm";
            this.Load += new System.EventHandler(this.LinesDistanceForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.uiTitlePanel4.ResumeLayout(false);
            this.uiTitlePanel4.PerformLayout();
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel2.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private RexView.HWindow_HE mWindowH;
        private RexControl.CTextBox tb_L;
        private System.Windows.Forms.Label label7;
        private RexControl.CTextBox tb_Y;
        private System.Windows.Forms.Label label6;
        private RexControl.CTextBox tb_X;
        private Rex.UI.UILinkText uilk_PointY;
        private Rex.UI.UILinkText uilk_PointX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Rex.UI.UITitlePanel uiTitlePanel2;
    }
}