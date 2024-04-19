namespace Plugin.DataSave
{
    partial class DataSaveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSaveForm));
            this.uiPanel1 = new Rex.UI.UIPanel();
            this.uiLink_FilePath = new Rex.UI.UILinkPath();
            this.uiTitlePanel4 = new Rex.UI.UITitlePanel();
            this.uibt_Down = new Rex.UI.UIButton();
            this.dgv_File = new Rex.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uibt_Up = new Rex.UI.UIButton();
            this.uibt_Remov = new Rex.UI.UIButton();
            this.uibt_Add = new Rex.UI.UIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.label6 = new System.Windows.Forms.Label();
            this.uicb_AutoRemov = new Rex.UI.UICheckBox();
            this.uicb_AddTime = new Rex.UI.UICheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uiLink_FileName = new Rex.UI.UILinkText();
            this.uitb_False = new RexControl.CTextBox();
            this.uitb_True = new RexControl.CTextBox();
            this.uidd_SaveDay = new Rex.UI.UIDoubleUpDownB();
            this.uidd_Dic = new Rex.UI.UIDoubleUpDownB();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.uiTitlePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_File)).BeginInit();
            this.uiTitlePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.uiPanel1);
            this.panel_center.Controls.Add(this.uiTitlePanel1);
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
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiLink_FilePath);
            this.uiPanel1.Controls.Add(this.uiTitlePanel4);
            this.uiPanel1.Controls.Add(this.label1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiPanel1.Location = new System.Drawing.Point(286, 1);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiPanel1.Size = new System.Drawing.Size(559, 474);
            this.uiPanel1.TabIndex = 146;
            this.uiPanel1.Text = null;
            // 
            // uiLink_FilePath
            // 
            this.uiLink_FilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_FilePath.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_FilePath.Location = new System.Drawing.Point(68, 17);
            this.uiLink_FilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_FilePath.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_FilePath.Name = "uiLink_FilePath";
            this.uiLink_FilePath.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_FilePath.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_FilePath.Size = new System.Drawing.Size(408, 24);
            this.uiLink_FilePath.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_FilePath.StyleCustomMode = true;
            this.uiLink_FilePath.TabIndex = 151;
            this.uiLink_FilePath.Text = "uiLinkPath1";
            this.uiLink_FilePath.BtnAdd += new Rex.UI.UILinkPath.BtnAddHandle(this.uiLink_FilePath_BtnAdd);
            // 
            // uiTitlePanel4
            // 
            this.uiTitlePanel4.Controls.Add(this.uibt_Down);
            this.uiTitlePanel4.Controls.Add(this.dgv_File);
            this.uiTitlePanel4.Controls.Add(this.uibt_Up);
            this.uiTitlePanel4.Controls.Add(this.uibt_Remov);
            this.uiTitlePanel4.Controls.Add(this.uibt_Add);
            this.uiTitlePanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiTitlePanel4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel4.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel4.Location = new System.Drawing.Point(0, 56);
            this.uiTitlePanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel4.Name = "uiTitlePanel4";
            this.uiTitlePanel4.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel4.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel4.Size = new System.Drawing.Size(559, 418);
            this.uiTitlePanel4.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel4.StyleCustomMode = true;
            this.uiTitlePanel4.TabIndex = 143;
            this.uiTitlePanel4.Text = "内容设置";
            this.uiTitlePanel4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uibt_Down
            // 
            this.uibt_Down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Down.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_Down.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Down.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Down.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Down.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Down.Location = new System.Drawing.Point(482, 226);
            this.uibt_Down.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Down.Name = "uibt_Down";
            this.uibt_Down.Size = new System.Drawing.Size(71, 24);
            this.uibt_Down.Style = Rex.UI.UIStyle.Custom;
            this.uibt_Down.TabIndex = 52;
            this.uibt_Down.Text = "下移";
            this.uibt_Down.Click += new System.EventHandler(this.uibt_Click);
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
            this.Column2,
            this.Column3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_File.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_File.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_File.EnableHeadersVisualStyles = false;
            this.dgv_File.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_File.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_File.Location = new System.Drawing.Point(0, 25);
            this.dgv_File.MultiSelect = false;
            this.dgv_File.Name = "dgv_File";
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
            this.dgv_File.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_File.ShowGridLine = true;
            this.dgv_File.Size = new System.Drawing.Size(476, 393);
            this.dgv_File.StripeEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_File.Style = Rex.UI.UIStyle.Custom;
            this.dgv_File.StyleCustomMode = true;
            this.dgv_File.TabIndex = 51;
            this.dgv_File.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_File_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Index";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.FillWeight = 1F;
            this.Column1.HeaderText = "索引";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.FillWeight = 2F;
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Msg";
            this.Column3.HeaderText = "链接";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // uibt_Up
            // 
            this.uibt_Up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Up.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_Up.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Up.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Up.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Up.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Up.Location = new System.Drawing.Point(482, 179);
            this.uibt_Up.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Up.Name = "uibt_Up";
            this.uibt_Up.Size = new System.Drawing.Size(71, 24);
            this.uibt_Up.Style = Rex.UI.UIStyle.Custom;
            this.uibt_Up.TabIndex = 2;
            this.uibt_Up.Text = "上移";
            this.uibt_Up.Click += new System.EventHandler(this.uibt_Click);
            // 
            // uibt_Remov
            // 
            this.uibt_Remov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Remov.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_Remov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Remov.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Remov.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Remov.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Remov.Location = new System.Drawing.Point(482, 124);
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
            this.uibt_Add.Location = new System.Drawing.Point(482, 79);
            this.uibt_Add.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Add.Name = "uibt_Add";
            this.uibt_Add.Size = new System.Drawing.Size(71, 24);
            this.uibt_Add.Style = Rex.UI.UIStyle.Custom;
            this.uibt_Add.TabIndex = 0;
            this.uibt_Add.Text = "添加";
            this.uibt_Add.Click += new System.EventHandler(this.uibt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 150;
            this.label1.Text = "保存路径:";
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.label6);
            this.uiTitlePanel1.Controls.Add(this.uicb_AutoRemov);
            this.uiTitlePanel1.Controls.Add(this.uicb_AddTime);
            this.uiTitlePanel1.Controls.Add(this.label5);
            this.uiTitlePanel1.Controls.Add(this.uiLink_FileName);
            this.uiTitlePanel1.Controls.Add(this.uitb_False);
            this.uiTitlePanel1.Controls.Add(this.uitb_True);
            this.uiTitlePanel1.Controls.Add(this.uidd_SaveDay);
            this.uiTitlePanel1.Controls.Add(this.uidd_Dic);
            this.uiTitlePanel1.Controls.Add(this.label20);
            this.uiTitlePanel1.Controls.Add(this.label3);
            this.uiTitlePanel1.Controls.Add(this.label21);
            this.uiTitlePanel1.Controls.Add(this.label4);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(1, 1);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.Size = new System.Drawing.Size(285, 474);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.StyleCustomMode = true;
            this.uiTitlePanel1.TabIndex = 144;
            this.uiTitlePanel1.Text = "选型设置";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(56, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 160;
            this.label6.Text = "备注:  保存时自动创建写入";
            // 
            // uicb_AutoRemov
            // 
            this.uicb_AutoRemov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uicb_AutoRemov.Checked = true;
            this.uicb_AutoRemov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_AutoRemov.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_AutoRemov.Location = new System.Drawing.Point(88, 180);
            this.uicb_AutoRemov.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_AutoRemov.Name = "uicb_AutoRemov";
            this.uicb_AutoRemov.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_AutoRemov.Size = new System.Drawing.Size(182, 17);
            this.uicb_AutoRemov.Style = Rex.UI.UIStyle.Custom;
            this.uicb_AutoRemov.TabIndex = 159;
            this.uicb_AutoRemov.Text = "自动清理";
            // 
            // uicb_AddTime
            // 
            this.uicb_AddTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uicb_AddTime.Checked = true;
            this.uicb_AddTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_AddTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_AddTime.Location = new System.Drawing.Point(88, 153);
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
            this.label5.Location = new System.Drawing.Point(32, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 157;
            this.label5.Text = "文件名称:";
            // 
            // uiLink_FileName
            // 
            this.uiLink_FileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLink_FileName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLink_FileName.Location = new System.Drawing.Point(88, 119);
            this.uiLink_FileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLink_FileName.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLink_FileName.Name = "uiLink_FileName";
            this.uiLink_FileName.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiLink_FileName.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiLink_FileName.Size = new System.Drawing.Size(182, 24);
            this.uiLink_FileName.Style = Rex.UI.UIStyle.Custom;
            this.uiLink_FileName.StyleCustomMode = true;
            this.uiLink_FileName.TabIndex = 156;
            this.uiLink_FileName.Text = "uiLink_FileName";
            this.uiLink_FileName.BtnAdd += new Rex.UI.UILinkText.BtnAddHandle(this.uiLink_FileName_BtnAdd);
            this.uiLink_FileName.BtnDec += new Rex.UI.UILinkText.BtnDecHandle(this.uiLink_FileName_BtnDec);
            // 
            // uitb_False
            // 
            this.uitb_False.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uitb_False.DefaultText = "";
            this.uitb_False.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitb_False.Location = new System.Drawing.Point(88, 63);
            this.uitb_False.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uitb_False.MaximumSize = new System.Drawing.Size(400, 22);
            this.uitb_False.MinimumSize = new System.Drawing.Size(20, 22);
            this.uitb_False.Name = "uitb_False";
            this.uitb_False.PasswordChar = false;
            this.uitb_False.Size = new System.Drawing.Size(182, 22);
            this.uitb_False.TabIndex = 155;
            this.uitb_False.TextStr = "NG";
            // 
            // uitb_True
            // 
            this.uitb_True.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uitb_True.DefaultText = "";
            this.uitb_True.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitb_True.Location = new System.Drawing.Point(88, 36);
            this.uitb_True.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uitb_True.MaximumSize = new System.Drawing.Size(400, 22);
            this.uitb_True.MinimumSize = new System.Drawing.Size(20, 22);
            this.uitb_True.Name = "uitb_True";
            this.uitb_True.PasswordChar = false;
            this.uitb_True.Size = new System.Drawing.Size(182, 22);
            this.uitb_True.TabIndex = 154;
            this.uitb_True.TextStr = "OK";
            // 
            // uidd_SaveDay
            // 
            this.uidd_SaveDay.Decimal = 0;
            this.uidd_SaveDay.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_SaveDay.Location = new System.Drawing.Point(88, 203);
            this.uidd_SaveDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uidd_SaveDay.Maximum = 50D;
            this.uidd_SaveDay.Minimum = 5D;
            this.uidd_SaveDay.MinimumSize = new System.Drawing.Size(100, 0);
            this.uidd_SaveDay.Name = "uidd_SaveDay";
            this.uidd_SaveDay.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_SaveDay.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_SaveDay.Size = new System.Drawing.Size(182, 24);
            this.uidd_SaveDay.Step = 1D;
            this.uidd_SaveDay.Style = Rex.UI.UIStyle.Custom;
            this.uidd_SaveDay.StyleCustomMode = true;
            this.uidd_SaveDay.TabIndex = 153;
            this.uidd_SaveDay.Text = "uiDoubleUpDownA2";
            this.uidd_SaveDay.Value = 10D;
            // 
            // uidd_Dic
            // 
            this.uidd_Dic.Decimal = 0;
            this.uidd_Dic.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_Dic.Location = new System.Drawing.Point(88, 90);
            this.uidd_Dic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uidd_Dic.Maximum = 10D;
            this.uidd_Dic.Minimum = 0D;
            this.uidd_Dic.MinimumSize = new System.Drawing.Size(100, 0);
            this.uidd_Dic.Name = "uidd_Dic";
            this.uidd_Dic.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_Dic.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_Dic.Size = new System.Drawing.Size(182, 24);
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
            this.label20.Location = new System.Drawing.Point(14, 39);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 17);
            this.label20.TabIndex = 4;
            this.label20.Text = "True 值替换:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(32, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 150;
            this.label3.Text = "保留天数:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(11, 66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 17);
            this.label21.TabIndex = 7;
            this.label21.Text = "False 值替换:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(32, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 149;
            this.label4.Text = "小数位数:";
            // 
            // DataSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataSaveForm";
            this.Load += new System.EventHandler(this.DataSaveForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.uiTitlePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_File)).EndInit();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.UI.UIPanel uiPanel1;
        private System.Windows.Forms.Label label1;
        private Rex.UI.UITitlePanel uiTitlePanel4;
        private Rex.UI.UIDataGridView dgv_File;
        private Rex.UI.UIButton uibt_Up;
        private Rex.UI.UIButton uibt_Remov;
        private Rex.UI.UIButton uibt_Add;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private RexControl.CTextBox uitb_False;
        private RexControl.CTextBox uitb_True;
        private Rex.UI.UIDoubleUpDownB uidd_SaveDay;
        private Rex.UI.UIDoubleUpDownB uidd_Dic;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Rex.UI.UILinkText uiLink_FileName;
        private Rex.UI.UIButton uibt_Down;
        private System.Windows.Forms.Label label6;
        private Rex.UI.UICheckBox uicb_AutoRemov;
        private Rex.UI.UICheckBox uicb_AddTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Rex.UI.UILinkPath uiLink_FilePath;
    }
}