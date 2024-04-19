namespace RexVision
{
    partial class VarSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VarSet));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uibt_AddInt = new Rex.UI.UIButton();
            this.uibt_AddDouble = new Rex.UI.UIButton();
            this.uibt_AddString = new Rex.UI.UIButton();
            this.uibt_AddBool = new Rex.UI.UIButton();
            this.uibt_Remov = new Rex.UI.UIButton();
            this.uibt_UP = new Rex.UI.UIButton();
            this.uibt_Down = new Rex.UI.UIButton();
            this.uibt_OK = new Rex.UI.UIButton();
            this.uibt_Esc = new Rex.UI.UIButton();
            this.uiPanel1 = new Rex.UI.UIPanel();
            this.dgv_VarList = new Rex.UI.UIDataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VarList)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pbox_Icon.Image")));
            this.pbox_Icon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbox_Icon.Size = new System.Drawing.Size(35, 32);
            this.pbox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(678, 32);
            // 
            // titlelabel
            // 
            this.titlelabel.Location = new System.Drawing.Point(40, 7);
            this.titlelabel.Size = new System.Drawing.Size(74, 21);
            this.titlelabel.Text = "变量设置";
            // 
            // uibt_AddInt
            // 
            this.uibt_AddInt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddInt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_AddInt.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_AddInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddInt.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddInt.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddInt.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddInt.Location = new System.Drawing.Point(591, 84);
            this.uibt_AddInt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uibt_AddInt.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_AddInt.Name = "uibt_AddInt";
            this.uibt_AddInt.Size = new System.Drawing.Size(82, 26);
            this.uibt_AddInt.Style = Rex.UI.UIStyle.Custom;
            this.uibt_AddInt.TabIndex = 21;
            this.uibt_AddInt.Text = " 添加Int";
            this.uibt_AddInt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uibt_AddInt.Click += new System.EventHandler(this.uibt_Add_Click);
            // 
            // uibt_AddDouble
            // 
            this.uibt_AddDouble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddDouble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_AddDouble.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_AddDouble.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddDouble.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddDouble.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddDouble.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddDouble.Location = new System.Drawing.Point(591, 161);
            this.uibt_AddDouble.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uibt_AddDouble.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_AddDouble.Name = "uibt_AddDouble";
            this.uibt_AddDouble.Size = new System.Drawing.Size(82, 26);
            this.uibt_AddDouble.Style = Rex.UI.UIStyle.Custom;
            this.uibt_AddDouble.TabIndex = 22;
            this.uibt_AddDouble.Text = " 添加Double";
            this.uibt_AddDouble.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uibt_AddDouble.Click += new System.EventHandler(this.uibt_Add_Click);
            // 
            // uibt_AddString
            // 
            this.uibt_AddString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddString.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_AddString.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_AddString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddString.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddString.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddString.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddString.Location = new System.Drawing.Point(591, 205);
            this.uibt_AddString.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uibt_AddString.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_AddString.Name = "uibt_AddString";
            this.uibt_AddString.Size = new System.Drawing.Size(82, 26);
            this.uibt_AddString.Style = Rex.UI.UIStyle.Custom;
            this.uibt_AddString.TabIndex = 23;
            this.uibt_AddString.Text = " 添加String";
            this.uibt_AddString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uibt_AddString.Click += new System.EventHandler(this.uibt_Add_Click);
            // 
            // uibt_AddBool
            // 
            this.uibt_AddBool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddBool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_AddBool.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_AddBool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddBool.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddBool.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddBool.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddBool.Location = new System.Drawing.Point(591, 118);
            this.uibt_AddBool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uibt_AddBool.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_AddBool.Name = "uibt_AddBool";
            this.uibt_AddBool.Size = new System.Drawing.Size(82, 26);
            this.uibt_AddBool.Style = Rex.UI.UIStyle.Custom;
            this.uibt_AddBool.TabIndex = 24;
            this.uibt_AddBool.Text = " 添加Bool";
            this.uibt_AddBool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uibt_AddBool.Click += new System.EventHandler(this.uibt_Add_Click);
            // 
            // uibt_Remov
            // 
            this.uibt_Remov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Remov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Remov.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_Remov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Remov.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Remov.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Remov.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Remov.Location = new System.Drawing.Point(591, 334);
            this.uibt_Remov.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uibt_Remov.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Remov.Name = "uibt_Remov";
            this.uibt_Remov.Size = new System.Drawing.Size(82, 26);
            this.uibt_Remov.Style = Rex.UI.UIStyle.Custom;
            this.uibt_Remov.TabIndex = 25;
            this.uibt_Remov.Text = "删除";
            this.uibt_Remov.Click += new System.EventHandler(this.列表操作);
            // 
            // uibt_UP
            // 
            this.uibt_UP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_UP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_UP.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_UP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_UP.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_UP.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_UP.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_UP.Location = new System.Drawing.Point(591, 382);
            this.uibt_UP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uibt_UP.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_UP.Name = "uibt_UP";
            this.uibt_UP.Size = new System.Drawing.Size(82, 26);
            this.uibt_UP.Style = Rex.UI.UIStyle.Custom;
            this.uibt_UP.TabIndex = 26;
            this.uibt_UP.Text = "上移";
            this.uibt_UP.Click += new System.EventHandler(this.列表操作);
            // 
            // uibt_Down
            // 
            this.uibt_Down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Down.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_Down.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Down.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Down.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Down.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Down.Location = new System.Drawing.Point(591, 416);
            this.uibt_Down.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uibt_Down.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Down.Name = "uibt_Down";
            this.uibt_Down.Size = new System.Drawing.Size(82, 26);
            this.uibt_Down.Style = Rex.UI.UIStyle.Custom;
            this.uibt_Down.TabIndex = 27;
            this.uibt_Down.Text = "下移";
            this.uibt_Down.Click += new System.EventHandler(this.列表操作);
            // 
            // uibt_OK
            // 
            this.uibt_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibt_OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_OK.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_OK.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_OK.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_OK.Location = new System.Drawing.Point(500, 7);
            this.uibt_OK.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_OK.Name = "uibt_OK";
            this.uibt_OK.Size = new System.Drawing.Size(82, 26);
            this.uibt_OK.Style = Rex.UI.UIStyle.Custom;
            this.uibt_OK.TabIndex = 28;
            this.uibt_OK.Text = "确定";
            this.uibt_OK.Click += new System.EventHandler(this.uibt_OK_Click);
            // 
            // uibt_Esc
            // 
            this.uibt_Esc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Esc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Esc.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_Esc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Esc.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Esc.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Esc.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Esc.Location = new System.Drawing.Point(591, 7);
            this.uibt_Esc.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Esc.Name = "uibt_Esc";
            this.uibt_Esc.Size = new System.Drawing.Size(82, 26);
            this.uibt_Esc.Style = Rex.UI.UIStyle.Custom;
            this.uibt_Esc.TabIndex = 37;
            this.uibt_Esc.Text = "取消";
            this.uibt_Esc.Click += new System.EventHandler(this.uibt_Esc_Click);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uibt_OK);
            this.uiPanel1.Controls.Add(this.uibt_Esc);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 468);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiPanel1.Size = new System.Drawing.Size(678, 40);
            this.uiPanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 56;
            this.uiPanel1.Text = null;
            // 
            // dgv_VarList
            // 
            this.dgv_VarList.AllowUserToAddRows = false;
            this.dgv_VarList.AllowUserToDeleteRows = false;
            this.dgv_VarList.AllowUserToResizeColumns = false;
            this.dgv_VarList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_VarList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_VarList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_VarList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VarList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_VarList.ColumnHeadersHeight = 25;
            this.dgv_VarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_VarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_VarList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_VarList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_VarList.EnableHeadersVisualStyles = false;
            this.dgv_VarList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_VarList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_VarList.Location = new System.Drawing.Point(0, 32);
            this.dgv_VarList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_VarList.MultiSelect = false;
            this.dgv_VarList.Name = "dgv_VarList";
            this.dgv_VarList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VarList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_VarList.RowHeadersWidth = 29;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_VarList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_VarList.RowTemplate.Height = 29;
            this.dgv_VarList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_VarList.SelectedIndex = -1;
            this.dgv_VarList.ShowGridLine = true;
            this.dgv_VarList.Size = new System.Drawing.Size(585, 436);
            this.dgv_VarList.StripeEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_VarList.Style = Rex.UI.UIStyle.Custom;
            this.dgv_VarList.StyleCustomMode = true;
            this.dgv_VarList.TabIndex = 57;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "mDataMode";
            this.Column4.HeaderText = "类型";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "mDataName";
            this.Column6.HeaderText = "名称";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "mDataValue";
            this.Column7.HeaderText = "值";
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "mDataTip0";
            this.Column5.HeaderText = "注释";
            this.Column5.Name = "Column5";
            // 
            // VarSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(678, 508);
            this.Controls.Add(this.dgv_VarList);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uibt_Down);
            this.Controls.Add(this.uibt_UP);
            this.Controls.Add(this.uibt_Remov);
            this.Controls.Add(this.uibt_AddBool);
            this.Controls.Add(this.uibt_AddString);
            this.Controls.Add(this.uibt_AddDouble);
            this.Controls.Add(this.uibt_AddInt);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(680, 510);
            this.MinimumSize = new System.Drawing.Size(680, 510);
            this.Name = "VarSet";
            this.Title = "变量设置";
            this.TitleSize = new System.Drawing.Size(74, 21);
            this.Load += new System.EventHandler(this.VarSetForm_Load);
            this.Controls.SetChildIndex(this.titlepanel, 0);
            this.Controls.SetChildIndex(this.uibt_AddInt, 0);
            this.Controls.SetChildIndex(this.uibt_AddDouble, 0);
            this.Controls.SetChildIndex(this.uibt_AddString, 0);
            this.Controls.SetChildIndex(this.uibt_AddBool, 0);
            this.Controls.SetChildIndex(this.uibt_Remov, 0);
            this.Controls.SetChildIndex(this.uibt_UP, 0);
            this.Controls.SetChildIndex(this.uibt_Down, 0);
            this.Controls.SetChildIndex(this.uiPanel1, 0);
            this.Controls.SetChildIndex(this.dgv_VarList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VarList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.UI.UIButton uibt_AddInt;
        private Rex.UI.UIButton uibt_AddDouble;
        private Rex.UI.UIButton uibt_AddString;
        private Rex.UI.UIButton uibt_AddBool;
        private Rex.UI.UIButton uibt_Remov;
        private Rex.UI.UIButton uibt_UP;
        private Rex.UI.UIButton uibt_Down;
        private Rex.UI.UIButton uibt_OK;
        private Rex.UI.UIButton uibt_Esc;
        private Rex.UI.UIPanel uiPanel1;
        private Rex.UI.UIDataGridView dgv_VarList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}