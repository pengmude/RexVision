namespace VisionCore
{
    partial class TcpControlS
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
            this.components = new System.ComponentModel.Container();
            this.textBox2 = new Rex.UI.UITextBox();
            this.label4 = new Rex.UI.UILabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Location = new System.Drawing.Point(62, 119);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Maximum = 2147483647D;
            this.textBox2.Minimum = -2147483648D;
            this.textBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.textBox2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.textBox2.Size = new System.Drawing.Size(128, 23);
            this.textBox2.Style = Rex.UI.UIStyle.Custom;
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(28, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "端口:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TcpControlS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "TcpControlS";
            this.Controls.SetChildIndex(this.uicb_Enable, 0);
            this.Controls.SetChildIndex(this.uilb_Key, 0);
            this.Controls.SetChildIndex(this.uitb_Remark, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Rex.UI.UITextBox textBox2;
        private Rex.UI.UILabel label4;
        private System.Windows.Forms.Timer timer1;
    }
}
