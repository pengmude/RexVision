namespace RexVision
{
    partial class FrmFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFeedback));
            this.label1 = new Rex.UI.UILabel();
            this.tbx_feedBackMessage = new Rex.UI.UITextBox();
            this.btn_submit = new Rex.UI.UIButton();
            this.tbx_emailAddress = new Rex.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbox_Icon.BackgroundImage")));
            this.pbox_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(403, 32);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 36);
            this.label1.TabIndex = 106;
            this.label1.Text = "      感谢您对此产品提出宝贵意见，我们将认真汲取并改进，从而更好的服务用户，请在下面的文本框内填写您的反馈信息后提交。";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx_feedBackMessage
            // 
            this.tbx_feedBackMessage.BackColor = System.Drawing.Color.White;
            this.tbx_feedBackMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_feedBackMessage.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tbx_feedBackMessage.Location = new System.Drawing.Point(11, 85);
            this.tbx_feedBackMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_feedBackMessage.Maximum = 2147483647D;
            this.tbx_feedBackMessage.Minimum = -2147483648D;
            this.tbx_feedBackMessage.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbx_feedBackMessage.Multiline = true;
            this.tbx_feedBackMessage.Name = "tbx_feedBackMessage";
            this.tbx_feedBackMessage.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tbx_feedBackMessage.Size = new System.Drawing.Size(380, 119);
            this.tbx_feedBackMessage.StyleCustomMode = true;
            this.tbx_feedBackMessage.TabIndex = 107;
            this.tbx_feedBackMessage.Watermark = "请输入你要反馈的信息!";
            // 
            // btn_submit
            // 
            this.btn_submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_submit.BackgroundImage")));
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_submit.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_submit.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_submit.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_submit.Location = new System.Drawing.Point(321, 213);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_submit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(70, 22);
            this.btn_submit.Style = Rex.UI.UIStyle.Custom;
            this.btn_submit.TabIndex = 108;
            this.btn_submit.Text = "提交";
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // tbx_emailAddress
            // 
            this.tbx_emailAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tbx_emailAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_emailAddress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_emailAddress.Location = new System.Drawing.Point(12, 213);
            this.tbx_emailAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_emailAddress.Maximum = 2147483647D;
            this.tbx_emailAddress.MaximumSize = new System.Drawing.Size(400, 22);
            this.tbx_emailAddress.Minimum = -2147483648D;
            this.tbx_emailAddress.MinimumSize = new System.Drawing.Size(20, 22);
            this.tbx_emailAddress.Name = "tbx_emailAddress";
            this.tbx_emailAddress.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tbx_emailAddress.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.tbx_emailAddress.Size = new System.Drawing.Size(295, 22);
            this.tbx_emailAddress.TabIndex = 109;
            this.tbx_emailAddress.Watermark = "请输入您的邮箱地址，便于我们回复（可不填）";
            // 
            // FrmFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(403, 256);
            this.Controls.Add(this.tbx_emailAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_feedBackMessage);
            this.Controls.Add(this.btn_submit);
            this.Name = "FrmFeedback";
            this.Controls.SetChildIndex(this.titlepanel, 0);
            this.Controls.SetChildIndex(this.btn_submit, 0);
            this.Controls.SetChildIndex(this.tbx_feedBackMessage, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbx_emailAddress, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.UI.UILabel label1;
        private Rex.UI.UITextBox tbx_feedBackMessage;
        public Rex.UI.UIButton btn_submit;
        private Rex.UI.UITextBox tbx_emailAddress;
    }
}