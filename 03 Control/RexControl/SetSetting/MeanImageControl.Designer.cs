namespace RexControl
{
    partial class MeanImageControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.ucNumTextBox1 = new RexControl.UCNumTextBox();
            this.ucNumTextBox2 = new RexControl.UCNumTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "高度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "宽度：";
            // 
            // ucNumTextBox1
            // 
            this.ucNumTextBox1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucNumTextBox1.InputType = RexControl.Text.TextInputType.Number;
            this.ucNumTextBox1.IsNumCanInput = true;
            this.ucNumTextBox1.KeyBoardType = RexControl.Text.KeyBoardType.UCKeyBorderNum;
            this.ucNumTextBox1.Location = new System.Drawing.Point(75, 28);
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
            this.ucNumTextBox1.Size = new System.Drawing.Size(178, 27);
            this.ucNumTextBox1.TabIndex = 2;
            this.ucNumTextBox1.AddClick += new System.EventHandler(this.ucNumTextBox_Numchanged);
            this.ucNumTextBox1.MinusClick += new System.EventHandler(this.ucNumTextBox_Numchanged);
            // 
            // ucNumTextBox2
            // 
            this.ucNumTextBox2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucNumTextBox2.InputType = RexControl.Text.TextInputType.Number;
            this.ucNumTextBox2.IsNumCanInput = true;
            this.ucNumTextBox2.KeyBoardType = RexControl.Text.KeyBoardType.UCKeyBorderNum;
            this.ucNumTextBox2.Location = new System.Drawing.Point(75, 71);
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
            this.ucNumTextBox2.Size = new System.Drawing.Size(178, 27);
            this.ucNumTextBox2.TabIndex = 3;
            this.ucNumTextBox2.AddClick += new System.EventHandler(this.ucNumTextBox_Numchanged);
            this.ucNumTextBox2.MinusClick += new System.EventHandler(this.ucNumTextBox_Numchanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(73, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "——————————————";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(73, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "——————————————";
            // 
            // MeanImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ucNumTextBox2);
            this.Controls.Add(this.ucNumTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MeanImageControl";
            this.Size = new System.Drawing.Size(320, 135);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RexControl.UCNumTextBox ucNumTextBox1;
        private RexControl.UCNumTextBox ucNumTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
