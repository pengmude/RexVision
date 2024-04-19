namespace Plugin.Delay
{
    partial class DelayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelayForm));
            this.uidd_Time = new Rex.UI.UIDoubleUpDownB();
            this.label1 = new Rex.UI.UILabel();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Location = new System.Drawing.Point(1, 109);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_bottom.Size = new System.Drawing.Size(296, 38);
            // 
            // panel_center
            // 
            this.panel_center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.panel_center.Controls.Add(this.uidd_Time);
            this.panel_center.Controls.Add(this.label1);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.Size = new System.Drawing.Size(296, 76);
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Location = new System.Drawing.Point(-70, 8);
            this.uitb_Remark.Size = new System.Drawing.Size(35, 23);
            this.uitb_Remark.Visible = false;
            // 
            // uIlb_describle
            // 
            this.uIlb_describle.Location = new System.Drawing.Point(-4, 13);
            this.uIlb_describle.Visible = false;
            // 
            // cb_Enable
            // 
            this.cb_Enable.Location = new System.Drawing.Point(8, 11);
            this.cb_Enable.Size = new System.Drawing.Size(10, 21);
            this.cb_Enable.Visible = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(203, 6);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(109, 6);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(15, 6);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(296, 32);
            // 
            // uidd_Time
            // 
            this.uidd_Time.Decimal = 0;
            this.uidd_Time.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_Time.HasMaximum = true;
            this.uidd_Time.HasMinimum = true;
            this.uidd_Time.Location = new System.Drawing.Point(99, 28);
            this.uidd_Time.Margin = new System.Windows.Forms.Padding(0);
            this.uidd_Time.Maximum = 500000D;
            this.uidd_Time.Minimum = 10D;
            this.uidd_Time.MinimumSize = new System.Drawing.Size(100, 0);
            this.uidd_Time.Name = "uidd_Time";
            this.uidd_Time.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_Time.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_Time.Size = new System.Drawing.Size(100, 24);
            this.uidd_Time.Step = 100D;
            this.uidd_Time.StyleCustomMode = true;
            this.uidd_Time.TabIndex = 5;
            this.uidd_Time.Text = "uiDoubleUpDownA1";
            this.uidd_Time.Value = 500D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "延时时间(ms):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DelayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 148);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "DelayForm";
            this.Load += new System.EventHandler(this.DelayForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.UI.UILabel label1;
        private Rex.UI.UIDoubleUpDownB uidd_Time;
    }
}