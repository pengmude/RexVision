namespace Plugin.AffineTrans
{
    partial class AffineTransForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffineTransForm));
            this.uipl_SetInPut = new Rex.UI.UITitlePanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uiLink_ToR = new Rex.UI.UILinkText();
            this.uiLink_FormR = new Rex.UI.UILinkText();
            this.uiLink_ToY = new Rex.UI.UILinkText();
            this.label3 = new System.Windows.Forms.Label();
            this.uiLink_ToX = new Rex.UI.UILinkText();
            this.label4 = new System.Windows.Forms.Label();
            this.uiLink_FormY = new Rex.UI.UILinkText();
            this.uiLink_FormX = new Rex.UI.UILinkText();
            this.uicb_AffineTrans = new Rex.UI.UIComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_inX = new System.Windows.Forms.Label();
            this.lbl_inY = new System.Windows.Forms.Label();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.uirt_MapMultiPoint = new Rex.UI.UIRadioButton();
            this.uirt_MapPoint = new Rex.UI.UIRadioButton();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.uilk_MapPointY = new Rex.UI.UILinkText();
            this.uilk_MapPointX = new Rex.UI.UILinkText();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.uitb_TranslY = new Rex.UI.UITextBox();
            this.uitb_TranslX = new Rex.UI.UITextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uipl_SetInPut.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Location = new System.Drawing.Point(1, 507);
            this.panel_bottom.Size = new System.Drawing.Size(291, 40);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.uiTitlePanel3);
            this.panel_center.Controls.Add(this.uiTitlePanel2);
            this.panel_center.Controls.Add(this.uiTitlePanel1);
            this.panel_center.Controls.Add(this.uipl_SetInPut);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.Size = new System.Drawing.Size(291, 474);
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Font = new System.Drawing.Font("微软雅黑", 1F);
            this.uitb_Remark.Location = new System.Drawing.Point(10, -70);
            this.uitb_Remark.Size = new System.Drawing.Size(13, 9);
            // 
            // uIlb_describle
            // 
            this.uIlb_describle.AutoSize = false;
            this.uIlb_describle.Visible = false;
            // 
            // cb_Enable
            // 
            this.cb_Enable.Font = new System.Drawing.Font("微软雅黑", 1F);
            this.cb_Enable.Location = new System.Drawing.Point(2, -73);
            this.cb_Enable.Size = new System.Drawing.Size(25, 14);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(200, 8);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(105, 8);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(7, 8);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(291, 32);
            // 
            // titlelabel
            // 
            this.titlelabel.Size = new System.Drawing.Size(74, 21);
            this.titlelabel.Text = "仿射变换";
            // 
            // uipl_SetInPut
            // 
            this.uipl_SetInPut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uipl_SetInPut.Controls.Add(this.label6);
            this.uipl_SetInPut.Controls.Add(this.label5);
            this.uipl_SetInPut.Controls.Add(this.uiLink_ToR);
            this.uipl_SetInPut.Controls.Add(this.uiLink_FormR);
            this.uipl_SetInPut.Controls.Add(this.uiLink_ToY);
            this.uipl_SetInPut.Controls.Add(this.label3);
            this.uipl_SetInPut.Controls.Add(this.uiLink_ToX);
            this.uipl_SetInPut.Controls.Add(this.label4);
            this.uipl_SetInPut.Controls.Add(this.uiLink_FormY);
            this.uipl_SetInPut.Controls.Add(this.uiLink_FormX);
            this.uipl_SetInPut.Controls.Add(this.uicb_AffineTrans);
            this.uipl_SetInPut.Controls.Add(this.label1);
            this.uipl_SetInPut.Controls.Add(this.lbl_inX);
            this.uipl_SetInPut.Controls.Add(this.lbl_inY);
            this.uipl_SetInPut.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uipl_SetInPut.ForeColor = System.Drawing.Color.White;
            this.uipl_SetInPut.Location = new System.Drawing.Point(0, 0);
            this.uipl_SetInPut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uipl_SetInPut.MinimumSize = new System.Drawing.Size(1, 1);
            this.uipl_SetInPut.Name = "uipl_SetInPut";
            this.uipl_SetInPut.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uipl_SetInPut.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uipl_SetInPut.Size = new System.Drawing.Size(291, 250);
            this.uipl_SetInPut.Style = Rex.UI.UIStyle.Custom;
            this.uipl_SetInPut.StyleCustomMode = true;
            this.uipl_SetInPut.TabIndex = 120;
            this.uipl_SetInPut.Text = "参数";
            this.uipl_SetInPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uipl_SetInPut.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(32, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 141;
            this.label6.Text = "ToR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(17, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 140;
            this.label5.Text = "FormR:";
            // 
            // uiLink_ToR
            // 
            this.uiLink_ToR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_ToR.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_ToR.Location = new System.Drawing.Point(68, 209);
            this.uiLink_ToR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLink_ToR.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_ToR.Name = "uiLink_ToR";
            this.uiLink_ToR.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_ToR.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_ToR.Size = new System.Drawing.Size(214, 25);
            this.uiLink_ToR.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_ToR.StyleCustomMode = true;
            this.uiLink_ToR.TabIndex = 139;
            this.uiLink_ToR.Text = "uiLinkText2";
            this.uiLink_ToR.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_ToR_BtnAdd);
            this.uiLink_ToR.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_ToR_BtnDec);
            // 
            // uiLink_FormR
            // 
            this.uiLink_FormR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_FormR.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_FormR.Location = new System.Drawing.Point(68, 125);
            this.uiLink_FormR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLink_FormR.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_FormR.Name = "uiLink_FormR";
            this.uiLink_FormR.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_FormR.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_FormR.Size = new System.Drawing.Size(214, 25);
            this.uiLink_FormR.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_FormR.StyleCustomMode = true;
            this.uiLink_FormR.TabIndex = 136;
            this.uiLink_FormR.Text = "uiLinkText2";
            this.uiLink_FormR.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_ToR_BtnAdd);
            this.uiLink_FormR.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_ToR_BtnDec);
            // 
            // uiLink_ToY
            // 
            this.uiLink_ToY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_ToY.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_ToY.Location = new System.Drawing.Point(68, 181);
            this.uiLink_ToY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLink_ToY.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_ToY.Name = "uiLink_ToY";
            this.uiLink_ToY.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_ToY.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_ToY.Size = new System.Drawing.Size(214, 25);
            this.uiLink_ToY.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_ToY.StyleCustomMode = true;
            this.uiLink_ToY.TabIndex = 138;
            this.uiLink_ToY.Text = "uiLinkText2";
            this.uiLink_ToY.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_ToR_BtnAdd);
            this.uiLink_ToY.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_ToR_BtnDec);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(32, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 136;
            this.label3.Text = "ToX:";
            // 
            // uiLink_ToX
            // 
            this.uiLink_ToX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_ToX.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_ToX.Location = new System.Drawing.Point(68, 153);
            this.uiLink_ToX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLink_ToX.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_ToX.Name = "uiLink_ToX";
            this.uiLink_ToX.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_ToX.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_ToX.Size = new System.Drawing.Size(214, 25);
            this.uiLink_ToX.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_ToX.StyleCustomMode = true;
            this.uiLink_ToX.TabIndex = 137;
            this.uiLink_ToX.Text = "uiLinkText1";
            this.uiLink_ToX.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_ToR_BtnAdd);
            this.uiLink_ToX.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_ToR_BtnDec);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(33, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 137;
            this.label4.Text = "ToY:";
            // 
            // uiLink_FormY
            // 
            this.uiLink_FormY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_FormY.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_FormY.Location = new System.Drawing.Point(68, 97);
            this.uiLink_FormY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLink_FormY.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_FormY.Name = "uiLink_FormY";
            this.uiLink_FormY.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_FormY.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_FormY.Size = new System.Drawing.Size(214, 25);
            this.uiLink_FormY.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_FormY.StyleCustomMode = true;
            this.uiLink_FormY.TabIndex = 135;
            this.uiLink_FormY.Text = "uiLinkText2";
            this.uiLink_FormY.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_ToR_BtnAdd);
            this.uiLink_FormY.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_ToR_BtnDec);
            // 
            // uiLink_FormX
            // 
            this.uiLink_FormX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_FormX.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLink_FormX.Location = new System.Drawing.Point(68, 69);
            this.uiLink_FormX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLink_FormX.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_FormX.Name = "uiLink_FormX";
            this.uiLink_FormX.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_FormX.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_FormX.Size = new System.Drawing.Size(214, 25);
            this.uiLink_FormX.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_FormX.StyleCustomMode = true;
            this.uiLink_FormX.TabIndex = 124;
            this.uiLink_FormX.Text = "uiLinkText1";
            this.uiLink_FormX.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_ToR_BtnAdd);
            this.uiLink_FormX.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_ToR_BtnDec);
            // 
            // uicb_AffineTrans
            // 
            this.uicb_AffineTrans.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_AffineTrans.Location = new System.Drawing.Point(68, 35);
            this.uicb_AffineTrans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uicb_AffineTrans.MaxDropDownItems = 5;
            this.uicb_AffineTrans.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicb_AffineTrans.Name = "uicb_AffineTrans";
            this.uicb_AffineTrans.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicb_AffineTrans.Radius = 2;
            this.uicb_AffineTrans.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicb_AffineTrans.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicb_AffineTrans.Size = new System.Drawing.Size(214, 23);
            this.uicb_AffineTrans.Style = Rex.UI.UIStyle.Custom;
            this.uicb_AffineTrans.StyleCustomMode = true;
            this.uicb_AffineTrans.TabIndex = 122;
            this.uicb_AffineTrans.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uicb_AffineTrans.Watermark = "数据链接";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 121;
            this.label1.Text = "仿射方法:";
            // 
            // lbl_inX
            // 
            this.lbl_inX.AutoSize = true;
            this.lbl_inX.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inX.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_inX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_inX.Location = new System.Drawing.Point(17, 73);
            this.lbl_inX.Name = "lbl_inX";
            this.lbl_inX.Size = new System.Drawing.Size(49, 17);
            this.lbl_inX.TabIndex = 5;
            this.lbl_inX.Text = "FormX:";
            // 
            // lbl_inY
            // 
            this.lbl_inY.AutoSize = true;
            this.lbl_inY.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inY.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_inY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_inY.Location = new System.Drawing.Point(18, 101);
            this.lbl_inY.Name = "lbl_inY";
            this.lbl_inY.Size = new System.Drawing.Size(48, 17);
            this.lbl_inY.TabIndex = 6;
            this.lbl_inY.Text = "FormY:";
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uiTitlePanel1.Controls.Add(this.uirt_MapMultiPoint);
            this.uiTitlePanel1.Controls.Add(this.uirt_MapPoint);
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(0, 245);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.Size = new System.Drawing.Size(291, 79);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.StyleCustomMode = true;
            this.uiTitlePanel1.TabIndex = 137;
            this.uiTitlePanel1.Text = "映射方式";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uirt_MapMultiPoint
            // 
            this.uirt_MapMultiPoint.BackColor = System.Drawing.Color.Transparent;
            this.uirt_MapMultiPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uirt_MapMultiPoint.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uirt_MapMultiPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uirt_MapMultiPoint.Location = new System.Drawing.Point(170, 34);
            this.uirt_MapMultiPoint.MinimumSize = new System.Drawing.Size(1, 1);
            this.uirt_MapMultiPoint.Name = "uirt_MapMultiPoint";
            this.uirt_MapMultiPoint.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uirt_MapMultiPoint.Size = new System.Drawing.Size(63, 18);
            this.uirt_MapMultiPoint.Style = Rex.UI.UIStyle.Custom;
            this.uirt_MapMultiPoint.StyleCustomMode = true;
            this.uirt_MapMultiPoint.TabIndex = 136;
            this.uirt_MapMultiPoint.Text = "点集";
            this.uirt_MapMultiPoint.ValueChanged += new Rex.UI.UIRadioButton.OnValueChanged(this.uiRadioButton1_ValueChanged);
            // 
            // uirt_MapPoint
            // 
            this.uirt_MapPoint.BackColor = System.Drawing.Color.Transparent;
            this.uirt_MapPoint.Checked = true;
            this.uirt_MapPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uirt_MapPoint.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uirt_MapPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uirt_MapPoint.Location = new System.Drawing.Point(68, 34);
            this.uirt_MapPoint.MinimumSize = new System.Drawing.Size(1, 1);
            this.uirt_MapPoint.Name = "uirt_MapPoint";
            this.uirt_MapPoint.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uirt_MapPoint.Size = new System.Drawing.Size(50, 18);
            this.uirt_MapPoint.Style = Rex.UI.UIStyle.Custom;
            this.uirt_MapPoint.StyleCustomMode = true;
            this.uirt_MapPoint.TabIndex = 135;
            this.uirt_MapPoint.Text = "点";
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uiTitlePanel2.Controls.Add(this.uilk_MapPointY);
            this.uiTitlePanel2.Controls.Add(this.uilk_MapPointX);
            this.uiTitlePanel2.Controls.Add(this.label9);
            this.uiTitlePanel2.Controls.Add(this.label10);
            this.uiTitlePanel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(0, 306);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.Size = new System.Drawing.Size(291, 90);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.StyleCustomMode = true;
            this.uiTitlePanel2.TabIndex = 138;
            this.uiTitlePanel2.Text = "映射点";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uilk_MapPointY
            // 
            this.uilk_MapPointY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilk_MapPointY.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uilk_MapPointY.Location = new System.Drawing.Point(68, 54);
            this.uilk_MapPointY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilk_MapPointY.MinimumSize = new System.Drawing.Size(1, 1);
            this.uilk_MapPointY.Name = "uilk_MapPointY";
            this.uilk_MapPointY.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_MapPointY.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_MapPointY.Size = new System.Drawing.Size(214, 25);
            this.uilk_MapPointY.Style = Rex.UI.UIStyle.Custom;
            this.uilk_MapPointY.StyleCustomMode = true;
            this.uilk_MapPointY.TabIndex = 135;
            this.uilk_MapPointY.Text = "uiLinkText2";
            this.uilk_MapPointY.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_ToR_BtnAdd);
            this.uilk_MapPointY.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_ToR_BtnDec);
            // 
            // uilk_MapPointX
            // 
            this.uilk_MapPointX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilk_MapPointX.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uilk_MapPointX.Location = new System.Drawing.Point(68, 29);
            this.uilk_MapPointX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilk_MapPointX.MinimumSize = new System.Drawing.Size(1, 1);
            this.uilk_MapPointX.Name = "uilk_MapPointX";
            this.uilk_MapPointX.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_MapPointX.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_MapPointX.Size = new System.Drawing.Size(214, 25);
            this.uilk_MapPointX.Style = Rex.UI.UIStyle.Custom;
            this.uilk_MapPointX.StyleCustomMode = true;
            this.uilk_MapPointX.TabIndex = 124;
            this.uilk_MapPointX.Text = "uiLinkText1";
            this.uilk_MapPointX.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_ToR_BtnAdd);
            this.uilk_MapPointX.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_ToR_BtnDec);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(11, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "输入点X:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(13, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "输入点Y:";
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uiTitlePanel3.Controls.Add(this.uitb_TranslY);
            this.uiTitlePanel3.Controls.Add(this.uitb_TranslX);
            this.uiTitlePanel3.Controls.Add(this.label45);
            this.uiTitlePanel3.Controls.Add(this.label44);
            this.uiTitlePanel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel3.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Location = new System.Drawing.Point(0, 390);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel3.Size = new System.Drawing.Size(291, 90);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.StyleCustomMode = true;
            this.uiTitlePanel3.TabIndex = 139;
            this.uiTitlePanel3.Text = "输出";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uitb_TranslY
            // 
            this.uitb_TranslY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitb_TranslY.DecLength = 3;
            this.uitb_TranslY.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uitb_TranslY.Location = new System.Drawing.Point(68, 55);
            this.uitb_TranslY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitb_TranslY.Maximum = 2147483647D;
            this.uitb_TranslY.Minimum = -2147483648D;
            this.uitb_TranslY.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitb_TranslY.Name = "uitb_TranslY";
            this.uitb_TranslY.Padding = new System.Windows.Forms.Padding(5);
            this.uitb_TranslY.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitb_TranslY.ReadOnly = true;
            this.uitb_TranslY.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitb_TranslY.Size = new System.Drawing.Size(214, 23);
            this.uitb_TranslY.Style = Rex.UI.UIStyle.Custom;
            this.uitb_TranslY.StyleCustomMode = true;
            this.uitb_TranslY.TabIndex = 132;
            this.uitb_TranslY.Text = "0.000";
            this.uitb_TranslY.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uitb_TranslY.Type = Rex.UI.UITextBox.UIEditType.Double;
            this.uitb_TranslY.Watermark = "";
            // 
            // uitb_TranslX
            // 
            this.uitb_TranslX.BackColor = System.Drawing.Color.Transparent;
            this.uitb_TranslX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitb_TranslX.DecLength = 3;
            this.uitb_TranslX.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uitb_TranslX.Location = new System.Drawing.Point(68, 30);
            this.uitb_TranslX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitb_TranslX.Maximum = 2147483647D;
            this.uitb_TranslX.Minimum = -2147483648D;
            this.uitb_TranslX.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitb_TranslX.Name = "uitb_TranslX";
            this.uitb_TranslX.Padding = new System.Windows.Forms.Padding(5);
            this.uitb_TranslX.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitb_TranslX.ReadOnly = true;
            this.uitb_TranslX.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitb_TranslX.Size = new System.Drawing.Size(214, 23);
            this.uitb_TranslX.Style = Rex.UI.UIStyle.Custom;
            this.uitb_TranslX.StyleCustomMode = true;
            this.uitb_TranslX.TabIndex = 131;
            this.uitb_TranslX.Text = "0.000";
            this.uitb_TranslX.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uitb_TranslX.Type = Rex.UI.UITextBox.UIEditType.Double;
            this.uitb_TranslX.Watermark = "";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label45.Location = new System.Drawing.Point(12, 33);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(55, 17);
            this.label45.TabIndex = 129;
            this.label45.Text = "输出点X:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label44.Location = new System.Drawing.Point(12, 58);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(54, 17);
            this.label44.TabIndex = 130;
            this.label44.Text = "输出点Y:";
            // 
            // AffineTransForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(295, 550);
            this.MinimumSize = new System.Drawing.Size(295, 550);
            this.Name = "AffineTransForm";
            this.Title = "仿射变换";
            this.TitleSize = new System.Drawing.Size(74, 21);
            this.Load += new System.EventHandler(this.AffineTransForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uipl_SetInPut.ResumeLayout(false);
            this.uipl_SetInPut.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel2.PerformLayout();
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.UI.UITitlePanel uipl_SetInPut;
        private Rex.UI.UILinkText uiLink_FormY;
        private Rex.UI.UILinkText uiLink_FormX;
        private System.Windows.Forms.Label lbl_inX;
        private System.Windows.Forms.Label lbl_inY;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private Rex.UI.UILinkText uilk_MapPointY;
        private Rex.UI.UILinkText uilk_MapPointX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private Rex.UI.UIRadioButton uirt_MapMultiPoint;
        private Rex.UI.UIRadioButton uirt_MapPoint;
        private Rex.UI.UIComboBox uicb_AffineTrans;
        private System.Windows.Forms.Label label1;
        private Rex.UI.UITextBox uitb_TranslY;
        private Rex.UI.UITextBox uitb_TranslX;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Rex.UI.UILinkText uiLink_ToR;
        private Rex.UI.UILinkText uiLink_FormR;
        private Rex.UI.UILinkText uiLink_ToY;
        private Rex.UI.UILinkText uiLink_ToX;
    }
}