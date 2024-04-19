namespace VisionCore
{
    partial class PluginDataLinkForm
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
            this.dgv_VarList = new Rex.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tre_ModList = new Rex.UI.UITreeView();
            this.uibt_OK = new Rex.UI.UIButton();
            this.uibt_NO = new Rex.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VarList)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Image = global::VisionCore.Properties.Resources.bianliang;
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(678, 32);
            // 
            // titlelabel
            // 
            this.titlelabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titlelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titlelabel.Size = new System.Drawing.Size(74, 21);
            this.titlelabel.Text = "模块列表";
            // 
            // dgv_VarList
            // 
            this.dgv_VarList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_VarList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_VarList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_VarList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VarList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_VarList.ColumnHeadersHeight = 30;
            this.dgv_VarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_VarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_VarList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_VarList.EnableHeadersVisualStyles = false;
            this.dgv_VarList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_VarList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_VarList.Location = new System.Drawing.Point(187, 33);
            this.dgv_VarList.Name = "dgv_VarList";
            this.dgv_VarList.ReadOnly = true;
            this.dgv_VarList.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_VarList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_VarList.RowTemplate.Height = 29;
            this.dgv_VarList.SelectedIndex = -1;
            this.dgv_VarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_VarList.ShowGridLine = true;
            this.dgv_VarList.Size = new System.Drawing.Size(490, 442);
            this.dgv_VarList.Style = Rex.UI.UIStyle.Custom;
            this.dgv_VarList.StyleCustomMode = true;
            this.dgv_VarList.TabIndex = 23;
            this.dgv_VarList.SelectIndexChange += new Rex.UI.UIDataGridView.OnSelectIndexChange(this.dgv_VarList_SelectIndexChange);
            this.dgv_VarList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_VarList_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Type";
            this.Column1.FillWeight = 88F;
            this.Column1.HeaderText = "类型";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 88;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.FillWeight = 88F;
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 88;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Result";
            this.Column3.HeaderText = "值";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tre_ModList
            // 
            this.tre_ModList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.tre_ModList.FillColor = System.Drawing.Color.White;
            this.tre_ModList.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tre_ModList.Location = new System.Drawing.Point(1, 33);
            this.tre_ModList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tre_ModList.MinimumSize = new System.Drawing.Size(1, 1);
            this.tre_ModList.Name = "tre_ModList";
            this.tre_ModList.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tre_ModList.SelectedNode = null;
            this.tre_ModList.Size = new System.Drawing.Size(187, 442);
            this.tre_ModList.Style = Rex.UI.UIStyle.Custom;
            this.tre_ModList.StyleCustomMode = true;
            this.tre_ModList.TabIndex = 18;
            this.tre_ModList.Text = null;
            this.tre_ModList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tre_ModList_AfterSelect);
            // 
            // uibt_OK
            // 
            this.uibt_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uibt_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_OK.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_OK.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_OK.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uibt_OK.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uibt_OK.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uibt_OK.Location = new System.Drawing.Point(499, 478);
            this.uibt_OK.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_OK.Name = "uibt_OK";
            this.uibt_OK.Size = new System.Drawing.Size(70, 26);
            this.uibt_OK.Style = Rex.UI.UIStyle.Custom;
            this.uibt_OK.StyleCustomMode = true;
            this.uibt_OK.TabIndex = 123;
            this.uibt_OK.Text = "确认";
            this.uibt_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // uibt_NO
            // 
            this.uibt_NO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uibt_NO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_NO.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_NO.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_NO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_NO.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uibt_NO.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uibt_NO.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uibt_NO.Location = new System.Drawing.Point(594, 478);
            this.uibt_NO.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_NO.Name = "uibt_NO";
            this.uibt_NO.Size = new System.Drawing.Size(70, 26);
            this.uibt_NO.Style = Rex.UI.UIStyle.Custom;
            this.uibt_NO.StyleCustomMode = true;
            this.uibt_NO.TabIndex = 124;
            this.uibt_NO.Text = "取消";
            this.uibt_NO.Click += new System.EventHandler(this.btn_NO_Click);
            // 
            // PluginDataLinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(678, 508);
            this.Controls.Add(this.uibt_OK);
            this.Controls.Add(this.uibt_NO);
            this.Controls.Add(this.dgv_VarList);
            this.Controls.Add(this.tre_ModList);
            this.MaximumSize = new System.Drawing.Size(680, 510);
            this.MinimumSize = new System.Drawing.Size(680, 510);
            this.Name = "PluginDataLinkForm";
            this.Opacity = 0.9D;
            this.Title = "模块列表";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleSize = new System.Drawing.Size(74, 21);
            this.Controls.SetChildIndex(this.titlepanel, 0);
            this.Controls.SetChildIndex(this.tre_ModList, 0);
            this.Controls.SetChildIndex(this.dgv_VarList, 0);
            this.Controls.SetChildIndex(this.uibt_NO, 0);
            this.Controls.SetChildIndex(this.uibt_OK, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VarList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.UI.UITreeView tre_ModList;
        private Rex.UI.UIDataGridView dgv_VarList;
        private Rex.UI.UIButton uibt_OK;
        private Rex.UI.UIButton uibt_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}