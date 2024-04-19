using RexControl.Text;

namespace RexControl
{
    /// <summary>
    /// Class UCNumTextBox.
    /// Implements the <see cref="System.Windows.Forms.UserControl" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    partial class UCNumTextBox
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNumTextBox));
            this.btnMinus = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Panel();
            this.txtNum = new RexControl.Text.TextBoxEx();
            this.SuspendLayout();
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinus.BackgroundImage")));
            this.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinus.Location = new System.Drawing.Point(86, 2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(32, 23);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMinus_MouseDown);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.Location = new System.Drawing.Point(118, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAdd_MouseDown);
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum.DecLength = 3;
            this.txtNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNum.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum.InputType = RexControl.Text.TextInputType.Number;
            this.txtNum.Location = new System.Drawing.Point(2, 2);
            this.txtNum.Margin = new System.Windows.Forms.Padding(0);
            this.txtNum.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtNum.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNum.Multiline = true;
            this.txtNum.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtNum.Name = "txtNum";
            this.txtNum.OldText = null;
            this.txtNum.PromptColor = System.Drawing.Color.Gray;
            this.txtNum.PromptFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum.PromptText = "";
            this.txtNum.RegexPattern = "";
            this.txtNum.Size = new System.Drawing.Size(84, 23);
            this.txtNum.TabIndex = 9;
            this.txtNum.Text = "1";
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum.FontChanged += new System.EventHandler(this.txtNum_FontChanged);
            this.txtNum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtNum_MouseDown);
            // 
            // UCNumTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAdd);
            this.Name = "UCNumTextBox";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(152, 27);
            this.Load += new System.EventHandler(this.UCNumTextBox_Load);
            this.BackColorChanged += new System.EventHandler(this.UCNumTextBox_BackColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The BTN add
        /// </summary>
        private System.Windows.Forms.Panel btnAdd;
        /// <summary>
        /// The BTN minus
        /// </summary>
        private System.Windows.Forms.Panel btnMinus;
        /// <summary>
        /// The text number
        /// </summary>
        private TextBoxEx txtNum;
    }
}
