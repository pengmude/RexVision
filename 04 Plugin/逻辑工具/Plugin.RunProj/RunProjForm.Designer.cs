namespace Plugin.RunProj
{
    partial class RunProjForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunProjForm));
            this.dgv_ProjSet = new Rex.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.ui_StpRun = new Rex.UI.UICheckBox();
            this.ui_ForRun = new Rex.UI.UICheckBox();
            this.ui_OneRun = new Rex.UI.UICheckBox();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProjSet)).BeginInit();
            this.uiTitlePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_bottom.Size = new System.Drawing.Size(446, 38);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.dgv_ProjSet);
            this.panel_center.Controls.Add(this.uiTitlePanel3);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.Size = new System.Drawing.Size(446, 476);
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Location = new System.Drawing.Point(35, 9);
            this.uitb_Remark.Size = new System.Drawing.Size(161, 23);
            this.uitb_Remark.Visible = false;
            // 
            // cb_Enable
            // 
            this.cb_Enable.Location = new System.Drawing.Point(205, 11);
            this.cb_Enable.Visible = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(358, 6);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(264, 6);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(264, 6);
            this.btn_Run.Visible = false;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(446, 32);
            // 
            // dgv_ProjSet
            // 
            this.dgv_ProjSet.AllowUserToAddRows = false;
            this.dgv_ProjSet.AllowUserToDeleteRows = false;
            this.dgv_ProjSet.AllowUserToResizeColumns = false;
            this.dgv_ProjSet.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_ProjSet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ProjSet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_ProjSet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ProjSet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProjSet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ProjSet.ColumnHeadersHeight = 29;
            this.dgv_ProjSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ProjSet.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ProjSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ProjSet.EnableHeadersVisualStyles = false;
            this.dgv_ProjSet.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.dgv_ProjSet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_ProjSet.Location = new System.Drawing.Point(1, 75);
            this.dgv_ProjSet.MultiSelect = false;
            this.dgv_ProjSet.Name = "dgv_ProjSet";
            this.dgv_ProjSet.RectColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProjSet.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ProjSet.RowHeadersVisible = false;
            this.dgv_ProjSet.RowHeadersWidth = 25;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_ProjSet.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ProjSet.RowTemplate.Height = 29;
            this.dgv_ProjSet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_ProjSet.SelectedIndex = -1;
            this.dgv_ProjSet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProjSet.ShowGridLine = true;
            this.dgv_ProjSet.ShowRect = false;
            this.dgv_ProjSet.Size = new System.Drawing.Size(444, 400);
            this.dgv_ProjSet.StripeEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_ProjSet.Style = Rex.UI.UIStyle.Custom;
            this.dgv_ProjSet.StyleCustomMode = true;
            this.dgv_ProjSet.TabIndex = 52;
            this.dgv_ProjSet.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_ProjSet_DataError);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            this.Column1.FillWeight = 1F;
            this.Column1.HeaderText = "流程";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 2F;
            this.Column2.HeaderText = "执行";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "等待";
            this.Column3.Name = "Column3";
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.ui_StpRun);
            this.uiTitlePanel3.Controls.Add(this.ui_ForRun);
            this.uiTitlePanel3.Controls.Add(this.ui_OneRun);
            this.uiTitlePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiTitlePanel3.Location = new System.Drawing.Point(1, 1);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.Padding = new System.Windows.Forms.Padding(3, 35, 3, 3);
            this.uiTitlePanel3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel3.RectColor = System.Drawing.Color.Gray;
            this.uiTitlePanel3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiTitlePanel3.Size = new System.Drawing.Size(444, 74);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.StyleCustomMode = true;
            this.uiTitlePanel3.TabIndex = 53;
            this.uiTitlePanel3.Text = "执行模式";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel3.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            // 
            // ui_StpRun
            // 
            this.ui_StpRun.BackColor = System.Drawing.Color.Transparent;
            this.ui_StpRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_StpRun.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ui_StpRun.Location = new System.Drawing.Point(280, 38);
            this.ui_StpRun.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_StpRun.Name = "ui_StpRun";
            this.ui_StpRun.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ui_StpRun.Size = new System.Drawing.Size(100, 18);
            this.ui_StpRun.Style = Rex.UI.UIStyle.Custom;
            this.ui_StpRun.StyleCustomMode = true;
            this.ui_StpRun.TabIndex = 4;
            this.ui_StpRun.Text = "停止执行";
            this.ui_StpRun.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ui_StopRun_MouseDown);
            // 
            // ui_ForRun
            // 
            this.ui_ForRun.BackColor = System.Drawing.Color.Transparent;
            this.ui_ForRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_ForRun.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ui_ForRun.Location = new System.Drawing.Point(160, 38);
            this.ui_ForRun.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_ForRun.Name = "ui_ForRun";
            this.ui_ForRun.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ui_ForRun.Size = new System.Drawing.Size(100, 18);
            this.ui_ForRun.Style = Rex.UI.UIStyle.Custom;
            this.ui_ForRun.StyleCustomMode = true;
            this.ui_ForRun.TabIndex = 3;
            this.ui_ForRun.Text = "循环执行";
            this.ui_ForRun.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ui_StopRun_MouseDown);
            // 
            // ui_OneRun
            // 
            this.ui_OneRun.BackColor = System.Drawing.Color.Transparent;
            this.ui_OneRun.Checked = true;
            this.ui_OneRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_OneRun.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ui_OneRun.Location = new System.Drawing.Point(54, 38);
            this.ui_OneRun.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_OneRun.Name = "ui_OneRun";
            this.ui_OneRun.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ui_OneRun.Size = new System.Drawing.Size(100, 18);
            this.ui_OneRun.Style = Rex.UI.UIStyle.Custom;
            this.ui_OneRun.StyleCustomMode = true;
            this.ui_OneRun.TabIndex = 2;
            this.ui_OneRun.Text = "单次执行";
            this.ui_OneRun.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ui_StopRun_MouseDown);
            // 
            // RunProjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(450, 550);
            this.MinimumSize = new System.Drawing.Size(450, 550);
            this.Name = "RunProjForm";
            this.Load += new System.EventHandler(this.RunProjForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProjSet)).EndInit();
            this.uiTitlePanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.UI.UIDataGridView dgv_ProjSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private Rex.UI.UICheckBox ui_StpRun;
        private Rex.UI.UICheckBox ui_ForRun;
        private Rex.UI.UICheckBox ui_OneRun;
    }
}