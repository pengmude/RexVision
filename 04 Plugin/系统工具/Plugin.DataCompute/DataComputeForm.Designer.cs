namespace Plugin.DataCompute
{
    partial class DataComputeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataComputeForm));
            this.uiPanel1 = new Rex.UI.UIPanel();
            this.uiTitlePanel4 = new Rex.UI.UITitlePanel();
            this.uibt_Down = new Rex.UI.UIButton();
            this.dgv_File = new Rex.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uibt_Up = new Rex.UI.UIButton();
            this.uibt_Remov = new Rex.UI.UIButton();
            this.uibt_Add = new Rex.UI.UIButton();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.uiTitlePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_File)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.uiPanel1);
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
            this.uiPanel1.Controls.Add(this.uiTitlePanel4);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiPanel1.Location = new System.Drawing.Point(1, 1);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiPanel1.Size = new System.Drawing.Size(844, 474);
            this.uiPanel1.TabIndex = 146;
            this.uiPanel1.Text = null;
            // 
            // uiTitlePanel4
            // 
            this.uiTitlePanel4.Controls.Add(this.uibt_Down);
            this.uiTitlePanel4.Controls.Add(this.dgv_File);
            this.uiTitlePanel4.Controls.Add(this.uibt_Up);
            this.uiTitlePanel4.Controls.Add(this.uibt_Remov);
            this.uiTitlePanel4.Controls.Add(this.uibt_Add);
            this.uiTitlePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTitlePanel4.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel4.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel4.Name = "uiTitlePanel4";
            this.uiTitlePanel4.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel4.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel4.Size = new System.Drawing.Size(844, 474);
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
            this.uibt_Down.Location = new System.Drawing.Point(768, 204);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
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
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_File.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_File.RowHeadersVisible = false;
            this.dgv_File.RowHeadersWidth = 25;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_File.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_File.RowTemplate.Height = 29;
            this.dgv_File.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_File.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_File.SelectedIndex = -1;
            this.dgv_File.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_File.ShowGridLine = true;
            this.dgv_File.Size = new System.Drawing.Size(762, 449);
            this.dgv_File.StripeEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_File.Style = Rex.UI.UIStyle.Custom;
            this.dgv_File.StyleCustomMode = true;
            this.dgv_File.TabIndex = 51;
            this.dgv_File.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_File_CellMouseDoubleClick);
            this.dgv_File.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_File_DataError);
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
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Link1";
            this.Column3.HeaderText = "链接";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CharType";
            this.Column4.HeaderText = "计算";
            this.Column4.Items.AddRange(new object[] {
            "加",
            "减",
            "乘",
            "除"});
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Link2";
            this.Column5.HeaderText = "链接";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Result";
            this.Column6.HeaderText = "结果";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Remark";
            this.Column7.HeaderText = "注释";
            this.Column7.Name = "Column7";
            // 
            // uibt_Up
            // 
            this.uibt_Up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Up.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_Up.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Up.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Up.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Up.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Up.Location = new System.Drawing.Point(768, 157);
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
            this.uibt_Remov.Location = new System.Drawing.Point(768, 102);
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
            this.uibt_Add.Location = new System.Drawing.Point(768, 57);
            this.uibt_Add.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Add.Name = "uibt_Add";
            this.uibt_Add.Size = new System.Drawing.Size(71, 24);
            this.uibt_Add.Style = Rex.UI.UIStyle.Custom;
            this.uibt_Add.TabIndex = 0;
            this.uibt_Add.Text = "添加";
            this.uibt_Add.Click += new System.EventHandler(this.uibt_Click);
            // 
            // DataComputeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataComputeForm";
            this.Load += new System.EventHandler(this.DataSaveForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiPanel1.ResumeLayout(false);
            this.uiTitlePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_File)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.UI.UIPanel uiPanel1;
        private Rex.UI.UITitlePanel uiTitlePanel4;
        private Rex.UI.UIDataGridView dgv_File;
        private Rex.UI.UIButton uibt_Up;
        private Rex.UI.UIButton uibt_Remov;
        private Rex.UI.UIButton uibt_Add;
        private Rex.UI.UIButton uibt_Down;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}