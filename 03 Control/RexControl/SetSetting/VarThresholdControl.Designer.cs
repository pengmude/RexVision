namespace RexControl
{
    partial class VarThresholdControl
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ucNumTextBox3 = new RexControl.UCNumTextBox();
            this.ucNumTextBox2 = new RexControl.UCNumTextBox();
            this.ucNumTextBox1 = new RexControl.UCNumTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(97, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 8);
            this.label7.TabIndex = 22;
            this.label7.Text = "———————————————";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(97, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 8);
            this.label6.TabIndex = 21;
            this.label6.Text = "———————————————";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(97, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 8);
            this.label5.TabIndex = 20;
            this.label5.Text = "———————————————";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "等于",
            "不等于",
            "小于等于",
            "大于等于"});
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.Items.AddRange(new object[] {
            "等于",
            "不等于",
            "小于等于",
            "大于等于"});
            this.comboBox1.Location = new System.Drawing.Point(97, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 25);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ucNumTextBox_Numchanged);
            // 
            // ucNumTextBox3
            // 
            this.ucNumTextBox3.BackColor = System.Drawing.Color.White;
            this.ucNumTextBox3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucNumTextBox3.InputType = RexControl.Text.TextInputType.Number;
            this.ucNumTextBox3.IsNumCanInput = true;
            this.ucNumTextBox3.KeyBoardType = RexControl.Text.KeyBoardType.UCKeyBorderNum;
            this.ucNumTextBox3.Location = new System.Drawing.Point(97, 66);
            this.ucNumTextBox3.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucNumTextBox3.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucNumTextBox3.Name = "ucNumTextBox3";
            this.ucNumTextBox3.Num = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucNumTextBox3.Padding = new System.Windows.Forms.Padding(2);
            this.ucNumTextBox3.Size = new System.Drawing.Size(185, 26);
            this.ucNumTextBox3.TabIndex = 18;
            this.ucNumTextBox3.AddClick += new System.EventHandler(this.ucNumTextBox_Numchanged);
            this.ucNumTextBox3.MinusClick += new System.EventHandler(this.ucNumTextBox_Numchanged);
            // 
            // ucNumTextBox2
            // 
            this.ucNumTextBox2.BackColor = System.Drawing.Color.White;
            this.ucNumTextBox2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucNumTextBox2.InputType = RexControl.Text.TextInputType.Number;
            this.ucNumTextBox2.IsNumCanInput = true;
            this.ucNumTextBox2.KeyBoardType = RexControl.Text.KeyBoardType.UCKeyBorderNum;
            this.ucNumTextBox2.Location = new System.Drawing.Point(97, 36);
            this.ucNumTextBox2.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucNumTextBox2.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucNumTextBox2.Name = "ucNumTextBox2";
            this.ucNumTextBox2.Num = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucNumTextBox2.Padding = new System.Windows.Forms.Padding(2);
            this.ucNumTextBox2.Size = new System.Drawing.Size(185, 26);
            this.ucNumTextBox2.TabIndex = 17;
            this.ucNumTextBox2.AddClick += new System.EventHandler(this.ucNumTextBox_Numchanged);
            this.ucNumTextBox2.MinusClick += new System.EventHandler(this.ucNumTextBox_Numchanged);
            // 
            // ucNumTextBox1
            // 
            this.ucNumTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucNumTextBox1.BackColor = System.Drawing.Color.White;
            this.ucNumTextBox1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucNumTextBox1.InputType = RexControl.Text.TextInputType.Number;
            this.ucNumTextBox1.IsNumCanInput = true;
            this.ucNumTextBox1.KeyBoardType = RexControl.Text.KeyBoardType.UCKeyBorderNum;
            this.ucNumTextBox1.Location = new System.Drawing.Point(97, 6);
            this.ucNumTextBox1.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucNumTextBox1.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucNumTextBox1.Name = "ucNumTextBox1";
            this.ucNumTextBox1.Num = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucNumTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.ucNumTextBox1.Size = new System.Drawing.Size(185, 26);
            this.ucNumTextBox1.TabIndex = 16;
            this.ucNumTextBox1.AddClick += new System.EventHandler(this.ucNumTextBox_Numchanged);
            this.ucNumTextBox1.MinusClick += new System.EventHandler(this.ucNumTextBox_Numchanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(22, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "比较类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "阈值偏移：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(46, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "宽度：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "高度：";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(97, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 8);
            this.label8.TabIndex = 23;
            this.label8.Text = "———————————————";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VarThresholdControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ucNumTextBox3);
            this.Controls.Add(this.ucNumTextBox2);
            this.Controls.Add(this.ucNumTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VarThresholdControl";
            this.Size = new System.Drawing.Size(320, 135);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private RexControl.UCNumTextBox ucNumTextBox3;
        private RexControl.UCNumTextBox ucNumTextBox2;
        private RexControl.UCNumTextBox ucNumTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}
