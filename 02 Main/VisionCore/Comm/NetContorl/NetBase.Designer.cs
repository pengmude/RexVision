namespace VisionCore
{
    partial class NetBase
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.uilb_Key = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uitb_Remark = new Rex.UI.UITextBox();
            this.uicb_Enable = new Rex.UI.UICheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "名称:";
            // 
            // uilb_Key
            // 
            this.uilb_Key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uilb_Key.AutoSize = true;
            this.uilb_Key.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uilb_Key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uilb_Key.Location = new System.Drawing.Point(62, 13);
            this.uilb_Key.Name = "uilb_Key";
            this.uilb_Key.Size = new System.Drawing.Size(38, 17);
            this.uilb_Key.TabIndex = 2;
            this.uilb_Key.Text = "COM";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(28, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "备注:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(28, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "启用:";
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uitb_Remark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitb_Remark.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitb_Remark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uitb_Remark.Location = new System.Drawing.Point(62, 81);
            this.uitb_Remark.Margin = new System.Windows.Forms.Padding(0);
            this.uitb_Remark.Maximum = 2147483647D;
            this.uitb_Remark.Minimum = -2147483648D;
            this.uitb_Remark.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitb_Remark.Name = "uitb_Remark";
            this.uitb_Remark.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitb_Remark.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitb_Remark.Size = new System.Drawing.Size(128, 23);
            this.uitb_Remark.Style = Rex.UI.UIStyle.Custom;
            this.uitb_Remark.TabIndex = 6;
            this.uitb_Remark.TextChanged += new System.EventHandler(this.uitb_Remark_TextChanged);
            // 
            // uicb_Enable
            // 
            this.uicb_Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicb_Enable.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uicb_Enable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uicb_Enable.Location = new System.Drawing.Point(62, 44);
            this.uicb_Enable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uicb_Enable.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicb_Enable.Name = "uicb_Enable";
            this.uicb_Enable.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicb_Enable.Size = new System.Drawing.Size(21, 25);
            this.uicb_Enable.Style = Rex.UI.UIStyle.Custom;
            this.uicb_Enable.TabIndex = 7;
            this.uicb_Enable.ValueChanged += new Rex.UI.UICheckBox.OnValueChanged(this.uicb_Enable_ValueChanged);
            // 
            // NetBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.uicb_Enable);
            this.Controls.Add(this.uitb_Remark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uilb_Key);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(200, 250);
            this.MinimumSize = new System.Drawing.Size(200, 250);
            this.Name = "NetBase";
            this.Size = new System.Drawing.Size(200, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label uilb_Key;
        public Rex.UI.UITextBox uitb_Remark;
        public Rex.UI.UICheckBox uicb_Enable;
    }
}
