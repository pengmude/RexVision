namespace VisionCore
{
    partial class FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.uitb_Remark = new Rex.UI.UITextBox();
            this.uIlb_describle = new Rex.UI.UILabel();
            this.cb_Enable = new Rex.UI.UICheckBox();
            this.btn_Cancel = new Rex.UI.UIButton();
            this.btn_Save = new Rex.UI.UIButton();
            this.btn_Run = new Rex.UI.UIButton();
            this.label_line = new System.Windows.Forms.Label();
            this.panel_center = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Image = global::VisionCore.Properties.Resources.Rex1;
            this.pbox_Icon.Location = new System.Drawing.Point(1, 1);
            this.pbox_Icon.Margin = new System.Windows.Forms.Padding(0);
            this.pbox_Icon.Size = new System.Drawing.Size(30, 30);
            this.pbox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // titlepanel
            // 
            this.titlepanel.Location = new System.Drawing.Point(1, 1);
            this.titlepanel.Margin = new System.Windows.Forms.Padding(1);
            this.titlepanel.Padding = new System.Windows.Forms.Padding(1);
            this.titlepanel.Size = new System.Drawing.Size(846, 32);
            // 
            // titlelabel
            // 
            this.titlelabel.Location = new System.Drawing.Point(36, 7);
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel_bottom.Controls.Add(this.uitb_Remark);
            this.panel_bottom.Controls.Add(this.uIlb_describle);
            this.panel_bottom.Controls.Add(this.cb_Enable);
            this.panel_bottom.Controls.Add(this.btn_Cancel);
            this.panel_bottom.Controls.Add(this.btn_Save);
            this.panel_bottom.Controls.Add(this.btn_Run);
            this.panel_bottom.Controls.Add(this.label_line);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(1, 509);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(0);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(846, 38);
            this.panel_bottom.TabIndex = 5;
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uitb_Remark.BackColor = System.Drawing.Color.Transparent;
            this.uitb_Remark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitb_Remark.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.uitb_Remark.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uitb_Remark.Location = new System.Drawing.Point(37, 8);
            this.uitb_Remark.Margin = new System.Windows.Forms.Padding(0);
            this.uitb_Remark.Maximum = 2147483647D;
            this.uitb_Remark.Minimum = -2147483648D;
            this.uitb_Remark.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitb_Remark.Name = "uitb_Remark";
            this.uitb_Remark.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uitb_Remark.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uitb_Remark.Size = new System.Drawing.Size(150, 23);
            this.uitb_Remark.Style = Rex.UI.UIStyle.Custom;
            this.uitb_Remark.TabIndex = 13;
            // 
            // uIlb_describle
            // 
            this.uIlb_describle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uIlb_describle.AutoSize = true;
            this.uIlb_describle.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uIlb_describle.Location = new System.Drawing.Point(3, 11);
            this.uIlb_describle.Name = "uIlb_describle";
            this.uIlb_describle.Size = new System.Drawing.Size(35, 17);
            this.uIlb_describle.TabIndex = 12;
            this.uIlb_describle.Text = "描述:";
            this.uIlb_describle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_Enable
            // 
            this.cb_Enable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Enable.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cb_Enable.ImageSize = 14;
            this.cb_Enable.Location = new System.Drawing.Point(197, 9);
            this.cb_Enable.MinimumSize = new System.Drawing.Size(1, 1);
            this.cb_Enable.Name = "cb_Enable";
            this.cb_Enable.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cb_Enable.Size = new System.Drawing.Size(58, 21);
            this.cb_Enable.TabIndex = 11;
            this.cb_Enable.Text = "屏蔽";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Cancel.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Cancel.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Cancel.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Cancel.Location = new System.Drawing.Point(752, 6);
            this.btn_Cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(82, 26);
            this.btn_Cancel.Style = Rex.UI.UIStyle.Custom;
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "取消";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Save.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Save.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Save.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Save.Location = new System.Drawing.Point(654, 6);
            this.btn_Save.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(82, 26);
            this.btn_Save.Style = Rex.UI.UIStyle.Custom;
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "确定";
            // 
            // btn_Run
            // 
            this.btn_Run.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Run.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Run.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Run.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Run.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Run.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Run.Location = new System.Drawing.Point(556, 6);
            this.btn_Run.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(82, 26);
            this.btn_Run.Style = Rex.UI.UIStyle.Custom;
            this.btn_Run.TabIndex = 8;
            this.btn_Run.Text = "执行";
            // 
            // label_line
            // 
            this.label_line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_line.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_line.Location = new System.Drawing.Point(0, 0);
            this.label_line.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_line.Name = "label_line";
            this.label_line.Size = new System.Drawing.Size(846, 1);
            this.label_line.TabIndex = 3;
            // 
            // panel_center
            // 
            this.panel_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_center.Location = new System.Drawing.Point(1, 33);
            this.panel_center.Margin = new System.Windows.Forms.Padding(0);
            this.panel_center.Name = "panel_center";
            this.panel_center.Padding = new System.Windows.Forms.Padding(1);
            this.panel_center.Size = new System.Drawing.Size(846, 476);
            this.panel_center.TabIndex = 8;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Controls.Add(this.panel_center);
            this.Controls.Add(this.panel_bottom);
            this.MaximumSize = new System.Drawing.Size(850, 550);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBase";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.Controls.SetChildIndex(this.titlepanel, 0);
            this.Controls.SetChildIndex(this.panel_bottom, 0);
            this.Controls.SetChildIndex(this.panel_center, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Label label_line;
        public System.Windows.Forms.Panel panel_center;
        public Rex.UI.UITextBox uitb_Remark;
        public Rex.UI.UILabel uIlb_describle;
        public Rex.UI.UICheckBox cb_Enable;
        public Rex.UI.UIButton btn_Cancel;
        public Rex.UI.UIButton btn_Save;
        public Rex.UI.UIButton btn_Run;
    }
}