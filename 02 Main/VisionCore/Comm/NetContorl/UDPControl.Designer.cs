namespace VisionCore
{
    partial class UDPControl
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
            this.textBox3 = new Rex.UI.UITextBox();
            this.label5 = new Rex.UI.UILabel();
            this.textBox4 = new Rex.UI.UITextBox();
            this.label6 = new Rex.UI.UILabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Location = new System.Drawing.Point(62, 113);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Maximum = 2147483647D;
            this.textBox2.Minimum = -2147483648D;
            this.textBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.textBox2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.textBox2.Size = new System.Drawing.Size(128, 23);
            this.textBox2.Style = Rex.UI.UIStyle.Custom;
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(4, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "本地端口:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.Location = new System.Drawing.Point(62, 141);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Maximum = 2147483647D;
            this.textBox3.Minimum = -2147483648D;
            this.textBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBox3.Name = "textBox3";
            this.textBox3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.textBox3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.textBox3.Size = new System.Drawing.Size(128, 23);
            this.textBox3.Style = Rex.UI.UIStyle.Custom;
            this.textBox3.TabIndex = 12;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(4, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "目标地址:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox4.Location = new System.Drawing.Point(62, 170);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Maximum = 2147483647D;
            this.textBox4.Minimum = -2147483648D;
            this.textBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBox4.Name = "textBox4";
            this.textBox4.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.textBox4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.textBox4.Size = new System.Drawing.Size(128, 23);
            this.textBox4.Style = Rex.UI.UIStyle.Custom;
            this.textBox4.TabIndex = 14;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(4, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "目标端口:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UDPControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "UDPControl";
            this.Controls.SetChildIndex(this.uicb_Enable, 0);
            this.Controls.SetChildIndex(this.uilb_Key, 0);
            this.Controls.SetChildIndex(this.uitb_Remark, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.textBox4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Rex.UI.UITextBox textBox2;
        private Rex.UI.UILabel label4;
        private Rex.UI.UITextBox textBox3;
        private Rex.UI.UILabel label5;
        private Rex.UI.UITextBox textBox4;
        private Rex.UI.UILabel label6;
        private System.Windows.Forms.Timer timer1;
    }
}
