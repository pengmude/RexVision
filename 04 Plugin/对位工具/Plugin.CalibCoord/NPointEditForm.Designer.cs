namespace Plugin.NPointCal
{
    partial class NPointEditForm
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
            this.tb_Point = new System.Windows.Forms.TextBox();
            this.uibt_OK = new Rex.UI.UIButton();
            this.uibt_NO = new Rex.UI.UIButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(528, 32);
            // 
            // tb_Point
            // 
            this.tb_Point.AcceptsReturn = true;
            this.tb_Point.AcceptsTab = true;
            this.tb_Point.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tb_Point.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Point.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_Point.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Point.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Point.Location = new System.Drawing.Point(0, 32);
            this.tb_Point.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tb_Point.Multiline = true;
            this.tb_Point.Name = "tb_Point";
            this.tb_Point.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Point.Size = new System.Drawing.Size(528, 483);
            this.tb_Point.TabIndex = 2;
            // 
            // uibt_OK
            // 
            this.uibt_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_OK.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uibt_OK.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_OK.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_OK.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_OK.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_OK.Location = new System.Drawing.Point(340, 3);
            this.uibt_OK.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_OK.Name = "uibt_OK";
            this.uibt_OK.Size = new System.Drawing.Size(70, 26);
            this.uibt_OK.Style = Rex.UI.UIStyle.Custom;
            this.uibt_OK.TabIndex = 125;
            this.uibt_OK.Text = "确认";
            this.uibt_OK.Click += new System.EventHandler(this.uibt_OK_Click);
            // 
            // uibt_NO
            // 
            this.uibt_NO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_NO.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uibt_NO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_NO.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_NO.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_NO.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_NO.Location = new System.Drawing.Point(435, 3);
            this.uibt_NO.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_NO.Name = "uibt_NO";
            this.uibt_NO.Size = new System.Drawing.Size(70, 26);
            this.uibt_NO.TabIndex = 126;
            this.uibt_NO.Text = "取消";
            this.uibt_NO.Click += new System.EventHandler(this.uibt_NO_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uibt_NO);
            this.panel2.Controls.Add(this.uibt_OK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 33);
            this.panel2.TabIndex = 127;
            // 
            // PointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 548);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tb_Point);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(530, 550);
            this.MinimumSize = new System.Drawing.Size(530, 550);
            this.Name = "PointForm";
            this.Controls.SetChildIndex(this.titlepanel, 0);
            this.Controls.SetChildIndex(this.tb_Point, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Point;
        private Rex.UI.UIButton uibt_OK;
        private Rex.UI.UIButton uibt_NO;
        private System.Windows.Forms.Panel panel2;
    }
}