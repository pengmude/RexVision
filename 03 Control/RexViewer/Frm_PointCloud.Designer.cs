namespace RexView
{
    partial class Frm_PointCloud
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_XScale = new System.Windows.Forms.NumericUpDown();
            this.num_YScale = new System.Windows.Forms.NumericUpDown();
            this.ckb_roi = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num_ZRef = new System.Windows.Forms.NumericUpDown();
            this.button_export_cloud = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_XScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_YScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ZRef)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.num_XScale, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.num_YScale, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ckb_roi, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.num_ZRef, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(179, 148);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "X当量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y当量";
            // 
            // num_XScale
            // 
            this.num_XScale.DecimalPlaces = 7;
            this.num_XScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            458752});
            this.num_XScale.Location = new System.Drawing.Point(92, 3);
            this.num_XScale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_XScale.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num_XScale.Name = "num_XScale";
            this.num_XScale.Size = new System.Drawing.Size(84, 21);
            this.num_XScale.TabIndex = 1;
            this.num_XScale.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // num_YScale
            // 
            this.num_YScale.DecimalPlaces = 7;
            this.num_YScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            458752});
            this.num_YScale.Location = new System.Drawing.Point(92, 27);
            this.num_YScale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_YScale.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num_YScale.Name = "num_YScale";
            this.num_YScale.Size = new System.Drawing.Size(84, 21);
            this.num_YScale.TabIndex = 1;
            this.num_YScale.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // ckb_roi
            // 
            this.ckb_roi.AutoSize = true;
            this.ckb_roi.Checked = true;
            this.ckb_roi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_roi.Location = new System.Drawing.Point(92, 75);
            this.ckb_roi.Name = "ckb_roi";
            this.ckb_roi.Size = new System.Drawing.Size(66, 16);
            this.ckb_roi.TabIndex = 2;
            this.ckb_roi.Text = "提取ROI";
            this.ckb_roi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Z补偿值";
            // 
            // num_ZRef
            // 
            this.num_ZRef.DecimalPlaces = 7;
            this.num_ZRef.Increment = new decimal(new int[] {
            1,
            0,
            0,
            458752});
            this.num_ZRef.Location = new System.Drawing.Point(92, 51);
            this.num_ZRef.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_ZRef.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num_ZRef.Name = "num_ZRef";
            this.num_ZRef.Size = new System.Drawing.Size(84, 21);
            this.num_ZRef.TabIndex = 1;
            // 
            // button_export_cloud
            // 
            this.button_export_cloud.Location = new System.Drawing.Point(225, 113);
            this.button_export_cloud.Name = "button_export_cloud";
            this.button_export_cloud.Size = new System.Drawing.Size(90, 47);
            this.button_export_cloud.TabIndex = 1;
            this.button_export_cloud.Text = "导出点云";
            this.button_export_cloud.UseVisualStyleBackColor = true;
            this.button_export_cloud.Click += new System.EventHandler(this.button_export_cloud_Click);
            // 
            // Frm_PointCloud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 176);
            this.Controls.Add(this.button_export_cloud);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PointCloud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_PointCloud";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_XScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_YScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ZRef)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_XScale;
        private System.Windows.Forms.NumericUpDown num_YScale;
        private System.Windows.Forms.CheckBox ckb_roi;
        private System.Windows.Forms.Button button_export_cloud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_ZRef;
    }
}