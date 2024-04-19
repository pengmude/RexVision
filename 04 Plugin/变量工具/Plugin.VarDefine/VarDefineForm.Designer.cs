namespace Plugin.VarDefine
{
    partial class VarDefineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VarDefineForm));
            this.button7 = new Rex.UI.UIButton();
            this.button6 = new Rex.UI.UIButton();
            this.button5 = new Rex.UI.UIButton();
            this.uibt_AddBool = new Rex.UI.UIButton();
            this.uibt_AddString = new Rex.UI.UIButton();
            this.uibt_AddDouble = new Rex.UI.UIButton();
            this.uibt_AddInt = new Rex.UI.UIButton();
            this.dgv_VarList = new Rex.UI.UIDataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VarList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // panel_center
            // 
            this.panel_center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.panel_center.Controls.Add(this.dgv_VarList);
            this.panel_center.Controls.Add(this.button7);
            this.panel_center.Controls.Add(this.button6);
            this.panel_center.Controls.Add(this.button5);
            this.panel_center.Controls.Add(this.uibt_AddBool);
            this.panel_center.Controls.Add(this.uibt_AddString);
            this.panel_center.Controls.Add(this.uibt_AddDouble);
            this.panel_center.Controls.Add(this.uibt_AddInt);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(755, 6);
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
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button7.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button7.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button7.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button7.Location = new System.Drawing.Point(755, 422);
            this.button7.MinimumSize = new System.Drawing.Size(1, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 26);
            this.button7.Style = Rex.UI.UIStyle.Custom;
            this.button7.TabIndex = 44;
            this.button7.Text = "下移";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button6.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button6.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button6.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button6.Location = new System.Drawing.Point(755, 381);
            this.button6.MinimumSize = new System.Drawing.Size(1, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 26);
            this.button6.Style = Rex.UI.UIStyle.Custom;
            this.button6.TabIndex = 43;
            this.button6.Text = "上移";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button5.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button5.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button5.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button5.Location = new System.Drawing.Point(755, 337);
            this.button5.MinimumSize = new System.Drawing.Size(1, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 26);
            this.button5.Style = Rex.UI.UIStyle.Custom;
            this.button5.TabIndex = 42;
            this.button5.Text = "删除";
            // 
            // uibt_AddBool
            // 
            this.uibt_AddBool.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uibt_AddBool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_AddBool.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_AddBool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddBool.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddBool.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddBool.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddBool.Location = new System.Drawing.Point(755, 88);
            this.uibt_AddBool.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_AddBool.Name = "uibt_AddBool";
            this.uibt_AddBool.Size = new System.Drawing.Size(82, 26);
            this.uibt_AddBool.Style = Rex.UI.UIStyle.Custom;
            this.uibt_AddBool.TabIndex = 41;
            this.uibt_AddBool.Text = " 添加Bool";
            this.uibt_AddBool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uibt_AddBool.Click += new System.EventHandler(this.uibt_Add_Click);
            // 
            // uibt_AddString
            // 
            this.uibt_AddString.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uibt_AddString.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_AddString.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_AddString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddString.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddString.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddString.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddString.Location = new System.Drawing.Point(755, 128);
            this.uibt_AddString.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_AddString.Name = "uibt_AddString";
            this.uibt_AddString.Size = new System.Drawing.Size(82, 26);
            this.uibt_AddString.Style = Rex.UI.UIStyle.Custom;
            this.uibt_AddString.TabIndex = 40;
            this.uibt_AddString.Text = " 添加String";
            this.uibt_AddString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uibt_AddString.Click += new System.EventHandler(this.uibt_Add_Click);
            // 
            // uibt_AddDouble
            // 
            this.uibt_AddDouble.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uibt_AddDouble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_AddDouble.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_AddDouble.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddDouble.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddDouble.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddDouble.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddDouble.Location = new System.Drawing.Point(755, 168);
            this.uibt_AddDouble.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_AddDouble.Name = "uibt_AddDouble";
            this.uibt_AddDouble.Size = new System.Drawing.Size(82, 26);
            this.uibt_AddDouble.Style = Rex.UI.UIStyle.Custom;
            this.uibt_AddDouble.TabIndex = 39;
            this.uibt_AddDouble.Text = " 添加Double";
            this.uibt_AddDouble.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uibt_AddDouble.Click += new System.EventHandler(this.uibt_Add_Click);
            // 
            // uibt_AddInt
            // 
            this.uibt_AddInt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uibt_AddInt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_AddInt.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_AddInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddInt.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddInt.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddInt.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddInt.Location = new System.Drawing.Point(755, 48);
            this.uibt_AddInt.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_AddInt.Name = "uibt_AddInt";
            this.uibt_AddInt.Size = new System.Drawing.Size(82, 26);
            this.uibt_AddInt.Style = Rex.UI.UIStyle.Custom;
            this.uibt_AddInt.TabIndex = 38;
            this.uibt_AddInt.Text = " 添加Int";
            this.uibt_AddInt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uibt_AddInt.Click += new System.EventHandler(this.uibt_Add_Click);
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
            this.dgv_VarList.Location = new System.Drawing.Point(1, 1);
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
            this.dgv_VarList.Size = new System.Drawing.Size(735, 474);
            this.dgv_VarList.StripeEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_VarList.Style = Rex.UI.UIStyle.Custom;
            this.dgv_VarList.StyleCustomMode = true;
            this.dgv_VarList.TabIndex = 58;
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
            // VarDefineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VarDefineForm";
            this.Load += new System.EventHandler(this.VarDefineModForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VarList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.UI.UIButton button7;
        private Rex.UI.UIButton button6;
        private Rex.UI.UIButton button5;
        private Rex.UI.UIButton uibt_AddBool;
        private Rex.UI.UIButton uibt_AddString;
        private Rex.UI.UIButton uibt_AddDouble;
        private Rex.UI.UIButton uibt_AddInt;
        private Rex.UI.UIDataGridView dgv_VarList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}