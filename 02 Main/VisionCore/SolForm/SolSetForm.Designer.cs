namespace VisionCore
{
    partial class SolSetForm
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
            this.dgv_SolList = new Rex.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Enter = new Rex.UI.UIButton();
            this.bt_Cancel = new Rex.UI.UIButton();
            this.bt_SelectOpen = new Rex.UI.UIButton();
            this.bt_StartSol = new Rex.UI.UIButton();
            this.bt_AddNow = new Rex.UI.UIButton();
            this.bt_AddExt = new Rex.UI.UIButton();
            this.bt_Delete = new Rex.UI.UIButton();
            this.bt_Down = new Rex.UI.UIButton();
            this.bt_Up = new Rex.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SolList)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Image = global::VisionCore.Properties.Resources.Rex1;
            this.pbox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(678, 32);
            // 
            // titlelabel
            // 
            this.titlelabel.Size = new System.Drawing.Size(74, 21);
            this.titlelabel.Text = "项目设置";
            // 
            // dgv_SolList
            // 
            this.dgv_SolList.AllowUserToAddRows = false;
            this.dgv_SolList.AllowUserToDeleteRows = false;
            this.dgv_SolList.AllowUserToResizeColumns = false;
            this.dgv_SolList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_SolList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SolList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_SolList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SolList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_SolList.ColumnHeadersHeight = 29;
            this.dgv_SolList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SolList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_SolList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_SolList.EnableHeadersVisualStyles = false;
            this.dgv_SolList.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.dgv_SolList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_SolList.Location = new System.Drawing.Point(0, 32);
            this.dgv_SolList.MultiSelect = false;
            this.dgv_SolList.Name = "dgv_SolList";
            this.dgv_SolList.RectColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SolList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_SolList.RowHeadersVisible = false;
            this.dgv_SolList.RowHeadersWidth = 25;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_SolList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_SolList.RowTemplate.Height = 29;
            this.dgv_SolList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_SolList.SelectedIndex = -1;
            this.dgv_SolList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SolList.ShowGridLine = true;
            this.dgv_SolList.Size = new System.Drawing.Size(587, 476);
            this.dgv_SolList.StripeEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_SolList.Style = Rex.UI.UIStyle.Custom;
            this.dgv_SolList.StyleCustomMode = true;
            this.dgv_SolList.TabIndex = 52;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Index";
            this.Column1.FillWeight = 1F;
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.FillWeight = 2F;
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "注释";
            this.Column3.Name = "Column3";
            this.Column3.TrueValue = "Note";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "File";
            this.Column4.HeaderText = "路径";
            this.Column4.Name = "Column4";
            // 
            // bt_Enter
            // 
            this.bt_Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Enter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Enter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Enter.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Enter.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Enter.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Enter.Location = new System.Drawing.Point(593, 441);
            this.bt_Enter.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_Enter.Name = "bt_Enter";
            this.bt_Enter.Size = new System.Drawing.Size(80, 26);
            this.bt_Enter.Style = Rex.UI.UIStyle.Custom;
            this.bt_Enter.TabIndex = 53;
            this.bt_Enter.Text = "确定";
            this.bt_Enter.Click += new System.EventHandler(this.bt_Enter_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Cancel.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Cancel.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Cancel.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Cancel.Location = new System.Drawing.Point(593, 475);
            this.bt_Cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(80, 26);
            this.bt_Cancel.Style = Rex.UI.UIStyle.Custom;
            this.bt_Cancel.TabIndex = 54;
            this.bt_Cancel.Text = "关闭";
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_SelectOpen
            // 
            this.bt_SelectOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_SelectOpen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_SelectOpen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_SelectOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_SelectOpen.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_SelectOpen.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_SelectOpen.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_SelectOpen.Location = new System.Drawing.Point(593, 73);
            this.bt_SelectOpen.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_SelectOpen.Name = "bt_SelectOpen";
            this.bt_SelectOpen.Size = new System.Drawing.Size(80, 26);
            this.bt_SelectOpen.Style = Rex.UI.UIStyle.Custom;
            this.bt_SelectOpen.TabIndex = 55;
            this.bt_SelectOpen.Text = "打开选择";
            this.bt_SelectOpen.Click += new System.EventHandler(this.bt_SelectOpen_Click);
            // 
            // bt_StartSol
            // 
            this.bt_StartSol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_StartSol.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_StartSol.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_StartSol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_StartSol.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_StartSol.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_StartSol.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_StartSol.Location = new System.Drawing.Point(593, 109);
            this.bt_StartSol.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_StartSol.Name = "bt_StartSol";
            this.bt_StartSol.Size = new System.Drawing.Size(80, 26);
            this.bt_StartSol.Style = Rex.UI.UIStyle.Custom;
            this.bt_StartSol.TabIndex = 56;
            this.bt_StartSol.Text = "默认启动";
            this.bt_StartSol.Click += new System.EventHandler(this.bt_StartSol_Click);
            // 
            // bt_AddNow
            // 
            this.bt_AddNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_AddNow.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_AddNow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_AddNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_AddNow.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_AddNow.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_AddNow.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_AddNow.Location = new System.Drawing.Point(593, 159);
            this.bt_AddNow.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_AddNow.Name = "bt_AddNow";
            this.bt_AddNow.Size = new System.Drawing.Size(80, 26);
            this.bt_AddNow.Style = Rex.UI.UIStyle.Custom;
            this.bt_AddNow.TabIndex = 57;
            this.bt_AddNow.Text = "添加当前";
            this.bt_AddNow.Click += new System.EventHandler(this.bt_AddNow_Click);
            // 
            // bt_AddExt
            // 
            this.bt_AddExt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_AddExt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_AddExt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_AddExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_AddExt.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_AddExt.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_AddExt.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_AddExt.Location = new System.Drawing.Point(593, 193);
            this.bt_AddExt.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_AddExt.Name = "bt_AddExt";
            this.bt_AddExt.Size = new System.Drawing.Size(80, 26);
            this.bt_AddExt.Style = Rex.UI.UIStyle.Custom;
            this.bt_AddExt.TabIndex = 58;
            this.bt_AddExt.Text = "添加现有";
            this.bt_AddExt.Click += new System.EventHandler(this.bt_AddExt_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Delete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Delete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Delete.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Delete.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Delete.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Delete.Location = new System.Drawing.Point(593, 227);
            this.bt_Delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(80, 26);
            this.bt_Delete.Style = Rex.UI.UIStyle.Custom;
            this.bt_Delete.TabIndex = 59;
            this.bt_Delete.Text = "删除选择";
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Down
            // 
            this.bt_Down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Down.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Down.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Down.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Down.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Down.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Down.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Down.Location = new System.Drawing.Point(593, 384);
            this.bt_Down.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_Down.Name = "bt_Down";
            this.bt_Down.Size = new System.Drawing.Size(80, 26);
            this.bt_Down.Style = Rex.UI.UIStyle.Custom;
            this.bt_Down.TabIndex = 61;
            this.bt_Down.Text = "下移";
            this.bt_Down.Click += new System.EventHandler(this.bt_Down_Click);
            // 
            // bt_Up
            // 
            this.bt_Up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Up.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Up.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Up.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Up.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Up.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Up.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Up.Location = new System.Drawing.Point(593, 346);
            this.bt_Up.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_Up.Name = "bt_Up";
            this.bt_Up.Size = new System.Drawing.Size(80, 26);
            this.bt_Up.Style = Rex.UI.UIStyle.Custom;
            this.bt_Up.TabIndex = 60;
            this.bt_Up.Text = "上移";
            this.bt_Up.Click += new System.EventHandler(this.bt_Up_Click);
            // 
            // SolSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(678, 508);
            this.Controls.Add(this.bt_Down);
            this.Controls.Add(this.bt_Up);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_AddExt);
            this.Controls.Add(this.bt_AddNow);
            this.Controls.Add(this.bt_StartSol);
            this.Controls.Add(this.bt_SelectOpen);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Enter);
            this.Controls.Add(this.dgv_SolList);
            this.MinimumSize = new System.Drawing.Size(680, 510);
            this.Name = "SolSetForm";
            this.Title = "项目设置";
            this.TitleSize = new System.Drawing.Size(74, 21);
            this.Load += new System.EventHandler(this.FormProj_Set_Load);
            this.Controls.SetChildIndex(this.titlepanel, 0);
            this.Controls.SetChildIndex(this.dgv_SolList, 0);
            this.Controls.SetChildIndex(this.bt_Enter, 0);
            this.Controls.SetChildIndex(this.bt_Cancel, 0);
            this.Controls.SetChildIndex(this.bt_SelectOpen, 0);
            this.Controls.SetChildIndex(this.bt_StartSol, 0);
            this.Controls.SetChildIndex(this.bt_AddNow, 0);
            this.Controls.SetChildIndex(this.bt_AddExt, 0);
            this.Controls.SetChildIndex(this.bt_Delete, 0);
            this.Controls.SetChildIndex(this.bt_Up, 0);
            this.Controls.SetChildIndex(this.bt_Down, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SolList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.UI.UIDataGridView dgv_SolList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Rex.UI.UIButton bt_Enter;
        private Rex.UI.UIButton bt_Cancel;
        private Rex.UI.UIButton bt_SelectOpen;
        private Rex.UI.UIButton bt_StartSol;
        private Rex.UI.UIButton bt_AddNow;
        private Rex.UI.UIButton bt_AddExt;
        private Rex.UI.UIButton bt_Delete;
        private Rex.UI.UIButton bt_Down;
        private Rex.UI.UIButton bt_Up;
    }
}