namespace Plugin.DataShow
{
    partial class DataShowForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataShowForm));
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.uitb_NG = new RexControl.CTextBox();
            this.uitb_OK = new RexControl.CTextBox();
            this.uidd_Size = new Rex.UI.UIDoubleUpDownB();
            this.uidd_Dic = new Rex.UI.UIDoubleUpDownB();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uiTitlePanel4 = new Rex.UI.UITitlePanel();
            this.dgv_File = new Rex.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uibt_Chang = new Rex.UI.UIButton();
            this.uibt_Remov = new Rex.UI.UIButton();
            this.uibt_Add = new Rex.UI.UIButton();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.uilk_Image = new Rex.UI.UILinkText();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_L = new RexControl.CTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Y = new RexControl.CTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_X = new RexControl.CTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mWindowH = new RexView.HWindow_HE();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.uiPanel1 = new Rex.UI.UIPanel();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.uiTitlePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_File)).BeginInit();
            this.uiTitlePanel2.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.uiPanel1);
            this.panel_center.Controls.Add(this.mWindowH);
            this.panel_center.Margin = new System.Windows.Forms.Padding(3);
            this.panel_center.Padding = new System.Windows.Forms.Padding(3);
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
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uitb_NG);
            this.uiTitlePanel1.Controls.Add(this.uitb_OK);
            this.uiTitlePanel1.Controls.Add(this.uidd_Size);
            this.uiTitlePanel1.Controls.Add(this.uidd_Dic);
            this.uiTitlePanel1.Controls.Add(this.label20);
            this.uiTitlePanel1.Controls.Add(this.label3);
            this.uiTitlePanel1.Controls.Add(this.label21);
            this.uiTitlePanel1.Controls.Add(this.label4);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(0, 308);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.Size = new System.Drawing.Size(285, 162);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.StyleCustomMode = true;
            this.uiTitlePanel1.TabIndex = 142;
            this.uiTitlePanel1.Text = "共同信息";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uitb_NG
            // 
            this.uitb_NG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uitb_NG.DefaultText = "";
            this.uitb_NG.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitb_NG.Location = new System.Drawing.Point(79, 116);
            this.uitb_NG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uitb_NG.MaximumSize = new System.Drawing.Size(400, 22);
            this.uitb_NG.MinimumSize = new System.Drawing.Size(20, 22);
            this.uitb_NG.Name = "uitb_NG";
            this.uitb_NG.PasswordChar = false;
            this.uitb_NG.Size = new System.Drawing.Size(185, 22);
            this.uitb_NG.TabIndex = 155;
            this.uitb_NG.TextStr = "NG";
            // 
            // uitb_OK
            // 
            this.uitb_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uitb_OK.DefaultText = "";
            this.uitb_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitb_OK.Location = new System.Drawing.Point(79, 91);
            this.uitb_OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uitb_OK.MaximumSize = new System.Drawing.Size(400, 22);
            this.uitb_OK.MinimumSize = new System.Drawing.Size(20, 22);
            this.uitb_OK.Name = "uitb_OK";
            this.uitb_OK.PasswordChar = false;
            this.uitb_OK.Size = new System.Drawing.Size(185, 22);
            this.uitb_OK.TabIndex = 154;
            this.uitb_OK.TextStr = "OK";
            // 
            // uidd_Size
            // 
            this.uidd_Size.Decimal = 0;
            this.uidd_Size.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_Size.Location = new System.Drawing.Point(81, 65);
            this.uidd_Size.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uidd_Size.Maximum = 50D;
            this.uidd_Size.Minimum = 5D;
            this.uidd_Size.MinimumSize = new System.Drawing.Size(100, 0);
            this.uidd_Size.Name = "uidd_Size";
            this.uidd_Size.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_Size.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_Size.Size = new System.Drawing.Size(181, 24);
            this.uidd_Size.Step = 2D;
            this.uidd_Size.Style = Rex.UI.UIStyle.Custom;
            this.uidd_Size.StyleCustomMode = true;
            this.uidd_Size.TabIndex = 153;
            this.uidd_Size.Text = "uiDoubleUpDownA2";
            this.uidd_Size.Value = 20D;
            // 
            // uidd_Dic
            // 
            this.uidd_Dic.Decimal = 0;
            this.uidd_Dic.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_Dic.Location = new System.Drawing.Point(81, 40);
            this.uidd_Dic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uidd_Dic.Maximum = 10D;
            this.uidd_Dic.Minimum = 0D;
            this.uidd_Dic.MinimumSize = new System.Drawing.Size(100, 0);
            this.uidd_Dic.Name = "uidd_Dic";
            this.uidd_Dic.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_Dic.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_Dic.Size = new System.Drawing.Size(181, 24);
            this.uidd_Dic.Step = 1D;
            this.uidd_Dic.Style = Rex.UI.UIStyle.Custom;
            this.uidd_Dic.StyleCustomMode = true;
            this.uidd_Dic.TabIndex = 152;
            this.uidd_Dic.Text = "uiDoubleUpDownA1";
            this.uidd_Dic.Value = 4D;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(23, 96);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 17);
            this.label20.TabIndex = 4;
            this.label20.Text = "结尾标记:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 150;
            this.label3.Text = "文字大小:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(20, 119);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 17);
            this.label21.TabIndex = 7;
            this.label21.Text = "NG  标记:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(23, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 149;
            this.label4.Text = "小数位数:";
            // 
            // uiTitlePanel4
            // 
            this.uiTitlePanel4.Controls.Add(this.dgv_File);
            this.uiTitlePanel4.Controls.Add(this.uibt_Chang);
            this.uiTitlePanel4.Controls.Add(this.uibt_Remov);
            this.uiTitlePanel4.Controls.Add(this.uibt_Add);
            this.uiTitlePanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel4.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel4.Location = new System.Drawing.Point(0, 70);
            this.uiTitlePanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel4.Name = "uiTitlePanel4";
            this.uiTitlePanel4.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel4.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel4.Size = new System.Drawing.Size(285, 238);
            this.uiTitlePanel4.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel4.StyleCustomMode = true;
            this.uiTitlePanel4.TabIndex = 141;
            this.uiTitlePanel4.Text = "参数设置";
            this.uiTitlePanel4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_File.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_File.EnableHeadersVisualStyles = false;
            this.dgv_File.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_File.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_File.Location = new System.Drawing.Point(0, 59);
            this.dgv_File.MultiSelect = false;
            this.dgv_File.Name = "dgv_File";
            this.dgv_File.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_File.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_File.RowHeadersVisible = false;
            this.dgv_File.RowHeadersWidth = 25;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_File.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_File.RowTemplate.Height = 29;
            this.dgv_File.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_File.SelectedIndex = -1;
            this.dgv_File.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_File.ShowGridLine = true;
            this.dgv_File.Size = new System.Drawing.Size(285, 179);
            this.dgv_File.StripeEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_File.Style = Rex.UI.UIStyle.Custom;
            this.dgv_File.StyleCustomMode = true;
            this.dgv_File.TabIndex = 51;
            this.dgv_File.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_File_CellMouseDoubleClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.FillWeight = 2F;
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // uibt_Chang
            // 
            this.uibt_Chang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Chang.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_Chang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Chang.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Chang.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Chang.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Chang.Location = new System.Drawing.Point(193, 30);
            this.uibt_Chang.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Chang.Name = "uibt_Chang";
            this.uibt_Chang.Size = new System.Drawing.Size(71, 24);
            this.uibt_Chang.Style = Rex.UI.UIStyle.Custom;
            this.uibt_Chang.TabIndex = 2;
            this.uibt_Chang.Text = "修改";
            this.uibt_Chang.Click += new System.EventHandler(this.uibt_Click);
            // 
            // uibt_Remov
            // 
            this.uibt_Remov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Remov.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_Remov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Remov.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Remov.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Remov.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Remov.Location = new System.Drawing.Point(102, 30);
            this.uibt_Remov.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Remov.Name = "uibt_Remov";
            this.uibt_Remov.Size = new System.Drawing.Size(71, 24);
            this.uibt_Remov.Style = Rex.UI.UIStyle.Custom;
            this.uibt_Remov.TabIndex = 1;
            this.uibt_Remov.Text = "删除";
            this.uibt_Remov.Click += new System.EventHandler(this.uibt_Click);
            // 
            // uibt_Add
            // 
            this.uibt_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Add.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Add.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Add.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Add.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Add.Location = new System.Drawing.Point(11, 30);
            this.uibt_Add.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Add.Name = "uibt_Add";
            this.uibt_Add.Size = new System.Drawing.Size(71, 24);
            this.uibt_Add.Style = Rex.UI.UIStyle.Custom;
            this.uibt_Add.TabIndex = 0;
            this.uibt_Add.Text = "添加";
            this.uibt_Add.Click += new System.EventHandler(this.uibt_Click);
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.uilk_Image);
            this.uiTitlePanel2.Controls.Add(this.label19);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.Size = new System.Drawing.Size(285, 70);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.StyleCustomMode = true;
            this.uiTitlePanel2.TabIndex = 154;
            this.uiTitlePanel2.Text = "输入图像";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uilk_Image
            // 
            this.uilk_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilk_Image.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uilk_Image.Location = new System.Drawing.Point(62, 36);
            this.uilk_Image.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uilk_Image.MinimumSize = new System.Drawing.Size(1, 1);
            this.uilk_Image.Name = "uilk_Image";
            this.uilk_Image.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uilk_Image.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uilk_Image.Size = new System.Drawing.Size(217, 24);
            this.uilk_Image.Style = Rex.UI.UIStyle.Custom;
            this.uilk_Image.StyleCustomMode = true;
            this.uilk_Image.TabIndex = 4;
            this.uilk_Image.Text = "uiLinkText1";
            this.uilk_Image.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uilk_BtnAdd);
            this.uilk_Image.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uilk_BtnDec);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(5, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 17);
            this.label19.TabIndex = 3;
            this.label19.Text = "输入图像:";
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
            this.tb_L.Size = new System.Drawing.Size(199, 22);
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
            this.tb_Y.Size = new System.Drawing.Size(199, 22);
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
            this.tb_X.Size = new System.Drawing.Size(199, 22);
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
            // mWindowH
            // 
            this.mWindowH.BackColor = System.Drawing.Color.Transparent;
            this.mWindowH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mWindowH.BackgroundImage")));
            this.mWindowH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mWindowH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mWindowH.Dock = System.Windows.Forms.DockStyle.Right;
            this.mWindowH.DrawModel = false;
            this.mWindowH.Image = null;
            this.mWindowH.Location = new System.Drawing.Point(291, 3);
            this.mWindowH.Margin = new System.Windows.Forms.Padding(5);
            this.mWindowH.Name = "mWindowH";
            this.mWindowH.Padding = new System.Windows.Forms.Padding(1);
            this.mWindowH.Size = new System.Drawing.Size(552, 470);
            this.mWindowH.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(192, 70);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(192, 70);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiTitlePanel1);
            this.uiPanel1.Controls.Add(this.uiTitlePanel4);
            this.uiPanel1.Controls.Add(this.uiTitlePanel2);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiPanel1.Location = new System.Drawing.Point(3, 3);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiPanel1.Size = new System.Drawing.Size(285, 470);
            this.uiPanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiPanel1.StyleCustomMode = true;
            this.uiPanel1.TabIndex = 9;
            this.uiPanel1.Text = null;
            // 
            // DataShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataShowForm";
            this.Load += new System.EventHandler(this.DataShowForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.uiTitlePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_File)).EndInit();
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel2.PerformLayout();
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private Rex.UI.UITitlePanel uiTitlePanel4;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Rex.UI.UIButton uibt_Chang;
        private Rex.UI.UIButton uibt_Remov;
        private Rex.UI.UIButton uibt_Add;
        private Rex.UI.UIDataGridView dgv_File;
        private Rex.UI.UIPanel uiPanel1;
        private RexControl.CTextBox uitb_NG;
        private RexControl.CTextBox uitb_OK;
        private Rex.UI.UIDoubleUpDownB uidd_Size;
        private Rex.UI.UIDoubleUpDownB uidd_Dic;
        private Rex.UI.UILinkText uilk_Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}