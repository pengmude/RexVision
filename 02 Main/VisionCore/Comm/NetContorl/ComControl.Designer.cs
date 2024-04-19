namespace VisionCore
{
    partial class ComControl
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
            this.comboBox1 = new Rex.UI.UIComboBox();
            this.label4 = new Rex.UI.UILabel();
            this.label5 = new Rex.UI.UILabel();
            this.comboBox2 = new Rex.UI.UIComboBox();
            this.label6 = new Rex.UI.UILabel();
            this.comboBox3 = new Rex.UI.UIComboBox();
            this.label7 = new Rex.UI.UILabel();
            this.comboBox4 = new Rex.UI.UIComboBox();
            this.label8 = new Rex.UI.UILabel();
            this.comboBox5 = new Rex.UI.UIComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // uilb_Key
            // 
            this.uilb_Key.Location = new System.Drawing.Point(70, 13);
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Location = new System.Drawing.Point(70, 81);
            this.uitb_Remark.Size = new System.Drawing.Size(128, 23);
            // 
            // uicb_Enable
            // 
            this.uicb_Enable.Location = new System.Drawing.Point(70, 44);
            this.uicb_Enable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uicb_Enable.Size = new System.Drawing.Size(21, 25);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.comboBox1.Location = new System.Drawing.Point(70, 110);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.MinimumSize = new System.Drawing.Size(73, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.comboBox1.Radius = 2;
            this.comboBox1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.comboBox1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.comboBox1.Size = new System.Drawing.Size(128, 23);
            this.comboBox1.StyleCustomMode = true;
            this.comboBox1.TabIndex = 5;
            this.comboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(14, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "串口号:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(14, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "波特率:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(70, 137);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox2.MinimumSize = new System.Drawing.Size(73, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.comboBox2.Radius = 2;
            this.comboBox2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.comboBox2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.comboBox2.Size = new System.Drawing.Size(128, 23);
            this.comboBox2.StyleCustomMode = true;
            this.comboBox2.TabIndex = 7;
            this.comboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(14, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "校验位:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBox3.Location = new System.Drawing.Point(70, 164);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox3.MinimumSize = new System.Drawing.Size(73, 0);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.comboBox3.Radius = 2;
            this.comboBox3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.comboBox3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.comboBox3.Size = new System.Drawing.Size(128, 23);
            this.comboBox3.StyleCustomMode = true;
            this.comboBox3.TabIndex = 9;
            this.comboBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(14, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "数据位:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox4.Location = new System.Drawing.Point(70, 191);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox4.MinimumSize = new System.Drawing.Size(73, 0);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.comboBox4.Radius = 2;
            this.comboBox4.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.comboBox4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.comboBox4.Size = new System.Drawing.Size(128, 23);
            this.comboBox4.StyleCustomMode = true;
            this.comboBox4.TabIndex = 11;
            this.comboBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(14, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "停止位:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "One",
            "Two",
            "OnePointFive"});
            this.comboBox5.Location = new System.Drawing.Point(70, 218);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox5.MinimumSize = new System.Drawing.Size(73, 0);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.comboBox5.Radius = 2;
            this.comboBox5.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.comboBox5.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.comboBox5.Size = new System.Drawing.Size(128, 23);
            this.comboBox5.StyleCustomMode = true;
            this.comboBox5.TabIndex = 13;
            this.comboBox5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ComControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ComControl";
            this.Size = new System.Drawing.Size(200, 250);
            this.Controls.SetChildIndex(this.uicb_Enable, 0);
            this.Controls.SetChildIndex(this.uilb_Key, 0);
            this.Controls.SetChildIndex(this.uitb_Remark, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.comboBox3, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.comboBox4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.comboBox5, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Rex.UI.UIComboBox comboBox1;
        private Rex.UI.UILabel label4;
        private Rex.UI.UILabel label5;
        private Rex.UI.UIComboBox comboBox2;
        private Rex.UI.UILabel label6;
        private Rex.UI.UIComboBox comboBox3;
        private Rex.UI.UILabel label7;
        private Rex.UI.UIComboBox comboBox4;
        private Rex.UI.UILabel label8;
        private Rex.UI.UIComboBox comboBox5;
        private System.Windows.Forms.Timer timer1;
    }
}
