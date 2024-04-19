using RexControl.Text;

namespace RexControl
{
    /// <summary>
    /// Class UCCombox.
    /// Implements the <see cref="HZH_Controls.RexControl.UCControlBase" />
    /// </summary>
    /// <seealso cref="HZH_Controls.RexControl.UCControlBase" />
    partial class UCCombox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCombox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInput = new RexControl.Text.TextBoxEx();
            this.lblInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(136, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 25);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.click_MouseDown);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Window;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.DecLength = 2;
            this.txtInput.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInput.InputType = RexControl.Text.TextInputType.NotControl;
            this.txtInput.Location = new System.Drawing.Point(0, 0);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.txtInput.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtInput.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtInput.Multiline = true;
            this.txtInput.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtInput.Name = "txtInput";
            this.txtInput.OldText = null;
            this.txtInput.PromptColor = System.Drawing.Color.Silver;
            this.txtInput.PromptFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInput.PromptText = "";
            this.txtInput.RegexPattern = "";
            this.txtInput.Size = new System.Drawing.Size(137, 25);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInput.Location = new System.Drawing.Point(3, 6);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(0, 12);
            this.lblInput.TabIndex = 2;
            this.lblInput.Visible = false;
            this.lblInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.click_MouseDown);
            // 
            // UCCombox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ConerRadius = 5;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.IsRadius = true;
            this.Name = "UCCombox";
            this.Size = new System.Drawing.Size(173, 25);
            this.Load += new System.EventHandler(this.UCComboBox_Load);
            this.SizeChanged += new System.EventHandler(this.UCComboBox_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.click_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The panel1
        /// </summary>
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// The text input
        /// </summary>
        public TextBoxEx txtInput;
        /// <summary>
        /// The label input
        /// </summary>
        private System.Windows.Forms.Label lblInput;
    }
}
