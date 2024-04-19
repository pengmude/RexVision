namespace RexVision
{
    partial class FrmData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmData));
            this.dvg_Data = new Rex.UI.UIDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_Data
            // 
            this.dvg_Data.AllowUserToAddRows = false;
            this.dvg_Data.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_Data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_Data.BackgroundColor = System.Drawing.Color.White;
            this.dvg_Data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_Data.EnableHeadersVisualStyles = false;
            this.dvg_Data.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dvg_Data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dvg_Data.Location = new System.Drawing.Point(0, 0);
            this.dvg_Data.Margin = new System.Windows.Forms.Padding(2);
            this.dvg_Data.Name = "dvg_Data";
            this.dvg_Data.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dvg_Data.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_Data.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_Data.RowTemplate.Height = 29;
            this.dvg_Data.SelectedIndex = -1;
            this.dvg_Data.ShowGridLine = true;
            this.dvg_Data.Size = new System.Drawing.Size(644, 466);
            this.dvg_Data.StripeEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dvg_Data.Style = Rex.UI.UIStyle.Custom;
            this.dvg_Data.TabIndex = 0;
            // 
            // FrmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 466);
            this.Controls.Add(this.dvg_Data);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmData";
            this.Text = "数据栏";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.UI.UIDataGridView dvg_Data;
    }
}