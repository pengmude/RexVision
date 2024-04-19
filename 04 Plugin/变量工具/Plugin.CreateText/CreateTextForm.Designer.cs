namespace Plugin.CreateText
{
    partial class CreateTextForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTextForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_Var = new Rex.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.tb_OutFalse = new Rex.UI.UITextBox();
            this.tb_OutTrue = new Rex.UI.UITextBox();
            this.label5 = new Rex.UI.UILabel();
            this.label1 = new Rex.UI.UILabel();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.tb_OutDouble = new Rex.UI.UIDoubleUpDownB();
            this.label4 = new Rex.UI.UILabel();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.tb_OutStrSplit = new Rex.UI.UITextBox();
            this.label6 = new Rex.UI.UILabel();
            this.uiTitlePanel4 = new Rex.UI.UITitlePanel();
            this.label7 = new Rex.UI.UILabel();
            this.tb_OutNGStr = new Rex.UI.UITextBox();
            this.uiCheckBox2 = new Rex.UI.UICheckBox();
            this.uiTitlePanel6 = new Rex.UI.UITitlePanel();
            this.tb_OutStr = new Rex.UI.UITextBox();
            this.uiTitlePanel7 = new Rex.UI.UITitlePanel();
            this.btn_Down = new Rex.UI.UISymbolButton();
            this.btn_Up = new Rex.UI.UISymbolButton();
            this.btn_Delete = new Rex.UI.UISymbolButton();
            this.btn_VarAdd = new Rex.UI.UISymbolButton();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Var)).BeginInit();
            this.uiTitlePanel1.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
            this.uiTitlePanel4.SuspendLayout();
            this.uiTitlePanel6.SuspendLayout();
            this.uiTitlePanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.uiTitlePanel7);
            this.panel_center.Controls.Add(this.uiTitlePanel6);
            this.panel_center.Controls.Add(this.uiTitlePanel3);
            this.panel_center.Controls.Add(this.uiTitlePanel4);
            this.panel_center.Controls.Add(this.uiTitlePanel2);
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
            // textInfoBindingSource
            // 
            this.textInfoBindingSource.DataSource = typeof(VisionCore.Text_Info);
            // 
            // dgv_Var
            // 
            this.dgv_Var.AllowUserToAddRows = false;
            this.dgv_Var.AllowUserToDeleteRows = false;
            this.dgv_Var.AllowUserToResizeColumns = false;
            this.dgv_Var.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Var.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Var.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_Var.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Var.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Var.ColumnHeadersHeight = 25;
            this.dgv_Var.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Var.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Var.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_Var.EnableHeadersVisualStyles = false;
            this.dgv_Var.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_Var.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_Var.Location = new System.Drawing.Point(0, 25);
            this.dgv_Var.MultiSelect = false;
            this.dgv_Var.Name = "dgv_Var";
            this.dgv_Var.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Var.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Var.RowHeadersVisible = false;
            this.dgv_Var.RowHeadersWidth = 25;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Var.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Var.RowTemplate.Height = 29;
            this.dgv_Var.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Var.SelectedIndex = -1;
            this.dgv_Var.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Var.ShowGridLine = true;
            this.dgv_Var.Size = new System.Drawing.Size(429, 365);
            this.dgv_Var.StripeEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_Var.Style = Rex.UI.UIStyle.Custom;
            this.dgv_Var.StyleCustomMode = true;
            this.dgv_Var.TabIndex = 49;
            this.dgv_Var.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_VarList_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            this.Column1.FillWeight = 1F;
            this.Column1.HeaderText = "名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Likes";
            this.Column2.FillWeight = 2F;
            this.Column2.HeaderText = "数据链接";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Value";
            this.Column3.FillWeight = 2F;
            this.Column3.HeaderText = "计算结果";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.tb_OutFalse);
            this.uiTitlePanel1.Controls.Add(this.tb_OutTrue);
            this.uiTitlePanel1.Controls.Add(this.label5);
            this.uiTitlePanel1.Controls.Add(this.label1);
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(510, 2);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.Size = new System.Drawing.Size(333, 127);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.StyleCustomMode = true;
            this.uiTitlePanel1.TabIndex = 135;
            this.uiTitlePanel1.Text = "Bool值替换";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_OutFalse
            // 
            this.tb_OutFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tb_OutFalse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_OutFalse.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_OutFalse.Location = new System.Drawing.Point(67, 81);
            this.tb_OutFalse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_OutFalse.Maximum = 2147483647D;
            this.tb_OutFalse.MaximumSize = new System.Drawing.Size(500, 22);
            this.tb_OutFalse.Minimum = -2147483648D;
            this.tb_OutFalse.MinimumSize = new System.Drawing.Size(20, 22);
            this.tb_OutFalse.Name = "tb_OutFalse";
            this.tb_OutFalse.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tb_OutFalse.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.tb_OutFalse.Size = new System.Drawing.Size(257, 22);
            this.tb_OutFalse.Style = Rex.UI.UIStyle.Custom;
            this.tb_OutFalse.TabIndex = 140;
            this.tb_OutFalse.Text = "0";
            // 
            // tb_OutTrue
            // 
            this.tb_OutTrue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tb_OutTrue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_OutTrue.DoubleValue = 1D;
            this.tb_OutTrue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_OutTrue.IntValue = 1;
            this.tb_OutTrue.Location = new System.Drawing.Point(67, 50);
            this.tb_OutTrue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_OutTrue.Maximum = 2147483647D;
            this.tb_OutTrue.MaximumSize = new System.Drawing.Size(500, 22);
            this.tb_OutTrue.Minimum = -2147483648D;
            this.tb_OutTrue.MinimumSize = new System.Drawing.Size(20, 22);
            this.tb_OutTrue.Name = "tb_OutTrue";
            this.tb_OutTrue.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tb_OutTrue.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.tb_OutTrue.Size = new System.Drawing.Size(257, 22);
            this.tb_OutTrue.Style = Rex.UI.UIStyle.Custom;
            this.tb_OutTrue.TabIndex = 139;
            this.tb_OutTrue.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label5.Location = new System.Drawing.Point(5, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.Style = Rex.UI.UIStyle.Custom;
            this.label5.TabIndex = 18;
            this.label5.Text = "False替换:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.Style = Rex.UI.UIStyle.Custom;
            this.label1.TabIndex = 8;
            this.label1.Text = "True替换:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.tb_OutDouble);
            this.uiTitlePanel2.Controls.Add(this.label4);
            this.uiTitlePanel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(510, 128);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.Size = new System.Drawing.Size(333, 74);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.StyleCustomMode = true;
            this.uiTitlePanel2.TabIndex = 136;
            this.uiTitlePanel2.Text = "Double小数位";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_OutDouble
            // 
            this.tb_OutDouble.Decimal = 0;
            this.tb_OutDouble.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tb_OutDouble.Location = new System.Drawing.Point(67, 37);
            this.tb_OutDouble.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_OutDouble.MinimumSize = new System.Drawing.Size(100, 0);
            this.tb_OutDouble.Name = "tb_OutDouble";
            this.tb_OutDouble.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tb_OutDouble.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.tb_OutDouble.Size = new System.Drawing.Size(150, 24);
            this.tb_OutDouble.Step = 1D;
            this.tb_OutDouble.Style = Rex.UI.UIStyle.LightBlue;
            this.tb_OutDouble.StyleCustomMode = true;
            this.tb_OutDouble.TabIndex = 129;
            this.tb_OutDouble.Text = null;
            this.tb_OutDouble.Value = 0D;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label4.Location = new System.Drawing.Point(22, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.Style = Rex.UI.UIStyle.Custom;
            this.label4.TabIndex = 8;
            this.label4.Text = "小数位:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.tb_OutStrSplit);
            this.uiTitlePanel3.Controls.Add(this.label6);
            this.uiTitlePanel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel3.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Location = new System.Drawing.Point(510, 201);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel3.Size = new System.Drawing.Size(333, 74);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.StyleCustomMode = true;
            this.uiTitlePanel3.TabIndex = 137;
            this.uiTitlePanel3.Text = "数组元素拼接";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_OutStrSplit
            // 
            this.tb_OutStrSplit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tb_OutStrSplit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_OutStrSplit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_OutStrSplit.Location = new System.Drawing.Point(67, 42);
            this.tb_OutStrSplit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_OutStrSplit.Maximum = 2147483647D;
            this.tb_OutStrSplit.MaximumSize = new System.Drawing.Size(500, 22);
            this.tb_OutStrSplit.Minimum = -2147483648D;
            this.tb_OutStrSplit.MinimumSize = new System.Drawing.Size(20, 22);
            this.tb_OutStrSplit.Name = "tb_OutStrSplit";
            this.tb_OutStrSplit.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tb_OutStrSplit.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.tb_OutStrSplit.Size = new System.Drawing.Size(257, 22);
            this.tb_OutStrSplit.Style = Rex.UI.UIStyle.Custom;
            this.tb_OutStrSplit.TabIndex = 138;
            this.tb_OutStrSplit.Watermark = "为空时默认“,”";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label6.Location = new System.Drawing.Point(22, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.Style = Rex.UI.UIStyle.Custom;
            this.label6.TabIndex = 8;
            this.label6.Text = "分隔符:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTitlePanel4
            // 
            this.uiTitlePanel4.Controls.Add(this.label7);
            this.uiTitlePanel4.Controls.Add(this.tb_OutNGStr);
            this.uiTitlePanel4.Controls.Add(this.uiCheckBox2);
            this.uiTitlePanel4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel4.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel4.Location = new System.Drawing.Point(510, 275);
            this.uiTitlePanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel4.Name = "uiTitlePanel4";
            this.uiTitlePanel4.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel4.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel4.Size = new System.Drawing.Size(333, 117);
            this.uiTitlePanel4.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel4.StyleCustomMode = true;
            this.uiTitlePanel4.TabIndex = 138;
            this.uiTitlePanel4.Text = "失败替换文本";
            this.uiTitlePanel4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label7.Location = new System.Drawing.Point(10, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.Style = Rex.UI.UIStyle.Custom;
            this.label7.TabIndex = 138;
            this.label7.Text = "失败文本:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_OutNGStr
            // 
            this.tb_OutNGStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tb_OutNGStr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_OutNGStr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_OutNGStr.Location = new System.Drawing.Point(67, 78);
            this.tb_OutNGStr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_OutNGStr.Maximum = 2147483647D;
            this.tb_OutNGStr.MaximumSize = new System.Drawing.Size(500, 22);
            this.tb_OutNGStr.Minimum = -2147483648D;
            this.tb_OutNGStr.MinimumSize = new System.Drawing.Size(20, 22);
            this.tb_OutNGStr.Name = "tb_OutNGStr";
            this.tb_OutNGStr.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tb_OutNGStr.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.tb_OutNGStr.Size = new System.Drawing.Size(257, 22);
            this.tb_OutNGStr.Style = Rex.UI.UIStyle.Custom;
            this.tb_OutNGStr.TabIndex = 137;
            this.tb_OutNGStr.Watermark = "-999,-999,-999,-999";
            // 
            // uiCheckBox2
            // 
            this.uiCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiCheckBox2.Location = new System.Drawing.Point(61, 48);
            this.uiCheckBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox2.Name = "uiCheckBox2";
            this.uiCheckBox2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox2.Size = new System.Drawing.Size(263, 18);
            this.uiCheckBox2.Style = Rex.UI.UIStyle.Custom;
            this.uiCheckBox2.TabIndex = 136;
            this.uiCheckBox2.Text = "启用(链接变量失败后强制使用此结果输出)";
            // 
            // uiTitlePanel6
            // 
            this.uiTitlePanel6.Controls.Add(this.tb_OutStr);
            this.uiTitlePanel6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel6.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel6.Location = new System.Drawing.Point(1, 394);
            this.uiTitlePanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel6.Name = "uiTitlePanel6";
            this.uiTitlePanel6.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel6.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel6.Size = new System.Drawing.Size(842, 78);
            this.uiTitlePanel6.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel6.StyleCustomMode = true;
            this.uiTitlePanel6.TabIndex = 140;
            this.uiTitlePanel6.Text = "结果文本";
            this.uiTitlePanel6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_OutStr
            // 
            this.tb_OutStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tb_OutStr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_OutStr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_OutStr.Location = new System.Drawing.Point(5, 40);
            this.tb_OutStr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_OutStr.Maximum = 2147483647D;
            this.tb_OutStr.MaximumSize = new System.Drawing.Size(880, 22);
            this.tb_OutStr.Minimum = -2147483648D;
            this.tb_OutStr.MinimumSize = new System.Drawing.Size(20, 22);
            this.tb_OutStr.Name = "tb_OutStr";
            this.tb_OutStr.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tb_OutStr.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.tb_OutStr.Size = new System.Drawing.Size(830, 22);
            this.tb_OutStr.Style = Rex.UI.UIStyle.Custom;
            this.tb_OutStr.TabIndex = 1;
            // 
            // uiTitlePanel7
            // 
            this.uiTitlePanel7.Controls.Add(this.btn_Down);
            this.uiTitlePanel7.Controls.Add(this.btn_Up);
            this.uiTitlePanel7.Controls.Add(this.btn_Delete);
            this.uiTitlePanel7.Controls.Add(this.btn_VarAdd);
            this.uiTitlePanel7.Controls.Add(this.dgv_Var);
            this.uiTitlePanel7.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel7.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel7.Location = new System.Drawing.Point(2, 2);
            this.uiTitlePanel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel7.Name = "uiTitlePanel7";
            this.uiTitlePanel7.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel7.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel7.Size = new System.Drawing.Size(506, 390);
            this.uiTitlePanel7.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel7.StyleCustomMode = true;
            this.uiTitlePanel7.TabIndex = 142;
            this.uiTitlePanel7.Text = "文本格式";
            this.uiTitlePanel7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Down
            // 
            this.btn_Down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Down.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Down.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Down.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Down.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Down.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Down.Location = new System.Drawing.Point(434, 151);
            this.btn_Down.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(66, 26);
            this.btn_Down.Style = Rex.UI.UIStyle.Custom;
            this.btn_Down.Symbol = 61539;
            this.btn_Down.SymbolSize = 22;
            this.btn_Down.TabIndex = 145;
            this.btn_Down.Text = "下移";
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Up.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Up.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Up.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Up.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Up.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Up.Location = new System.Drawing.Point(434, 119);
            this.btn_Up.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(66, 26);
            this.btn_Up.Style = Rex.UI.UIStyle.Custom;
            this.btn_Up.Symbol = 61538;
            this.btn_Up.SymbolSize = 22;
            this.btn_Up.TabIndex = 144;
            this.btn_Up.Text = "上移";
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Delete.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Delete.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Delete.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Delete.Location = new System.Drawing.Point(434, 87);
            this.btn_Delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(66, 26);
            this.btn_Delete.Style = Rex.UI.UIStyle.Custom;
            this.btn_Delete.Symbol = 61544;
            this.btn_Delete.SymbolSize = 22;
            this.btn_Delete.TabIndex = 143;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_VarAdd
            // 
            this.btn_VarAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VarAdd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_VarAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_VarAdd.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_VarAdd.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_VarAdd.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_VarAdd.Location = new System.Drawing.Point(434, 53);
            this.btn_VarAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_VarAdd.Name = "btn_VarAdd";
            this.btn_VarAdd.Size = new System.Drawing.Size(66, 26);
            this.btn_VarAdd.Style = Rex.UI.UIStyle.Custom;
            this.btn_VarAdd.Symbol = 61543;
            this.btn_VarAdd.SymbolSize = 22;
            this.btn_VarAdd.TabIndex = 142;
            this.btn_VarAdd.Text = "添加";
            this.btn_VarAdd.Click += new System.EventHandler(this.btn_VarAdd_Click);
            // 
            // CreateTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateTextForm";
            this.Load += new System.EventHandler(this.GetDataModForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Var)).EndInit();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel2.PerformLayout();
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel3.PerformLayout();
            this.uiTitlePanel4.ResumeLayout(false);
            this.uiTitlePanel4.PerformLayout();
            this.uiTitlePanel6.ResumeLayout(false);
            this.uiTitlePanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource textInfoBindingSource;
        private Rex.UI.UIDataGridView dgv_Var;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private Rex.UI.UIDoubleUpDownB tb_OutDouble;
        private Rex.UI.UILabel label4;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private Rex.UI.UILabel label1;
        private Rex.UI.UITitlePanel uiTitlePanel4;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private Rex.UI.UILabel label6;
        private Rex.UI.UITitlePanel uiTitlePanel7;
        private Rex.UI.UISymbolButton btn_Delete;
        private Rex.UI.UISymbolButton btn_VarAdd;
        private Rex.UI.UITitlePanel uiTitlePanel6;
        private Rex.UI.UITextBox tb_OutStr;
        private Rex.UI.UITextBox tb_OutStrSplit;
        private Rex.UI.UILabel label7;
        private Rex.UI.UITextBox tb_OutNGStr;
        private Rex.UI.UICheckBox uiCheckBox2;
        private Rex.UI.UITextBox tb_OutFalse;
        private Rex.UI.UITextBox tb_OutTrue;
        private Rex.UI.UILabel label5;
        private Rex.UI.UISymbolButton btn_Down;
        private Rex.UI.UISymbolButton btn_Up;
    }
}