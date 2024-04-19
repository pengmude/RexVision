namespace VisionCore
{
    partial class ProjSetForm
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
            this.dgv_ProjSet = new Rex.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bt_Enter = new Rex.UI.UIButton();
            this.bt_Close = new Rex.UI.UIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_SolName = new RexControl.CTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProjSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Image = global::VisionCore.Properties.Resources.Rex1;
            this.pbox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(498, 32);
            // 
            // titlelabel
            // 
            this.titlelabel.Size = new System.Drawing.Size(74, 21);
            this.titlelabel.Text = "流程设置";
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
            this.dgv_ProjSet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
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
            this.dgv_ProjSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_ProjSet.EnableHeadersVisualStyles = false;
            this.dgv_ProjSet.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.dgv_ProjSet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_ProjSet.Location = new System.Drawing.Point(0, 32);
            this.dgv_ProjSet.MultiSelect = false;
            this.dgv_ProjSet.Name = "dgv_ProjSet";
            this.dgv_ProjSet.RectColor = System.Drawing.Color.Gray;
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
            this.dgv_ProjSet.Size = new System.Drawing.Size(498, 333);
            this.dgv_ProjSet.StripeEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_ProjSet.Style = Rex.UI.UIStyle.Custom;
            this.dgv_ProjSet.StyleCustomMode = true;
            this.dgv_ProjSet.TabIndex = 51;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            this.Column1.FillWeight = 1F;
            this.Column1.HeaderText = "流程名称";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 2F;
            this.Column2.HeaderText = "执行方式";
            this.Column2.Items.AddRange(new object[] {
            "主动执行",
            "调用时执行",
            "停止时执行",
            "加载时执行"});
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "界面刷新";
            this.Column3.Name = "Column3";
            // 
            // bt_Enter
            // 
            this.bt_Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Enter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Enter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Enter.Location = new System.Drawing.Point(303, 369);
            this.bt_Enter.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_Enter.Name = "bt_Enter";
            this.bt_Enter.Size = new System.Drawing.Size(80, 26);
            this.bt_Enter.Style = Rex.UI.UIStyle.Custom;
            this.bt_Enter.TabIndex = 52;
            this.bt_Enter.Text = "确定";
            this.bt_Enter.Click += new System.EventHandler(this.bt_Enter_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Close.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Close.Location = new System.Drawing.Point(407, 369);
            this.bt_Close.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(80, 26);
            this.bt_Close.Style = Rex.UI.UIStyle.Custom;
            this.bt_Close.TabIndex = 53;
            this.bt_Close.Text = "关闭";
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "项目名称:";
            // 
            // tb_SolName
            // 
            this.tb_SolName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tb_SolName.DefaultText = "";
            this.tb_SolName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_SolName.Location = new System.Drawing.Point(59, 371);
            this.tb_SolName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_SolName.MaximumSize = new System.Drawing.Size(400, 22);
            this.tb_SolName.MinimumSize = new System.Drawing.Size(20, 22);
            this.tb_SolName.Name = "tb_SolName";
            this.tb_SolName.PasswordChar = false;
            this.tb_SolName.Size = new System.Drawing.Size(210, 22);
            this.tb_SolName.TabIndex = 55;
            this.tb_SolName.TextStr = "";
            // 
            // ProjSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(498, 398);
            this.Controls.Add(this.tb_SolName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_Enter);
            this.Controls.Add(this.dgv_ProjSet);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ProjSetForm";
            this.Title = "流程设置";
            this.TitleSize = new System.Drawing.Size(74, 21);
            this.Load += new System.EventHandler(this.ProjSetForm_Load);
            this.Controls.SetChildIndex(this.titlepanel, 0);
            this.Controls.SetChildIndex(this.dgv_ProjSet, 0);
            this.Controls.SetChildIndex(this.bt_Enter, 0);
            this.Controls.SetChildIndex(this.bt_Close, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tb_SolName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProjSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Rex.UI.UIDataGridView dgv_ProjSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private Rex.UI.UIButton bt_Enter;
        private Rex.UI.UIButton bt_Close;
        private System.Windows.Forms.Label label1;
        private RexControl.CTextBox tb_SolName;
    }
}