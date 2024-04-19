namespace RexControl.FormUI.Text
{
    partial class CLikeText
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
            this.BtnAdd = new RexControl.UCBtnExt();
            this.mText = new RexControl.CTextBox();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.BackColor = System.Drawing.Color.White;
            this.BtnAdd.BackgroundImage = global::RexControl.Properties.Resources.照片搜索;
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdd.BtnBackColor = System.Drawing.Color.White;
            this.BtnAdd.BtnFont = new System.Drawing.Font("微软雅黑", 9F);
            this.BtnAdd.BtnForeColor = System.Drawing.Color.White;
            this.BtnAdd.BtnText = "";
            this.BtnAdd.ConerRadius = 5;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.EnabledMouseEffect = false;
            this.BtnAdd.FillColor = System.Drawing.Color.White;
            this.BtnAdd.IsRadius = true;
            this.BtnAdd.IsShowRect = true;
            this.BtnAdd.IsShowTips = false;
            this.BtnAdd.Location = new System.Drawing.Point(128, 1);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Padding = new System.Windows.Forms.Padding(1);
            this.BtnAdd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.BtnAdd.RectWidth = 1;
            this.BtnAdd.Size = new System.Drawing.Size(23, 21);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.TabStop = false;
            this.BtnAdd.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.BtnAdd.TipsText = "";
            // 
            // mText
            // 
            this.mText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.mText.DefaultText = "";
            this.mText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mText.Location = new System.Drawing.Point(0, 0);
            this.mText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mText.MaximumSize = new System.Drawing.Size(400, 22);
            this.mText.MinimumSize = new System.Drawing.Size(20, 22);
            this.mText.Name = "mText";
            this.mText.PasswordChar = false;
            this.mText.Size = new System.Drawing.Size(152, 22);
            this.mText.TabIndex = 2;
            this.mText.TextStr = "";
            // 
            // CLikeText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.mText);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CLikeText";
            this.Size = new System.Drawing.Size(152, 22);
            this.ResumeLayout(false);

        }

        #endregion
        private UCBtnExt BtnAdd;
        public CTextBox mText;
    }
}
