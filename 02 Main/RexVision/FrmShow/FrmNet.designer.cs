namespace RexVision
{
    partial class FrmNet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNet));
            this.uipl_EComEvent = new Rex.UI.UIPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // uipl_EComEvent
            // 
            this.uipl_EComEvent.AutoScroll = true;
            this.uipl_EComEvent.BackColor = System.Drawing.Color.White;
            this.uipl_EComEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uipl_EComEvent.FillColor = System.Drawing.Color.Transparent;
            this.uipl_EComEvent.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uipl_EComEvent.Location = new System.Drawing.Point(3, 3);
            this.uipl_EComEvent.Margin = new System.Windows.Forms.Padding(0);
            this.uipl_EComEvent.MinimumSize = new System.Drawing.Size(1, 1);
            this.uipl_EComEvent.Name = "uipl_EComEvent";
            this.uipl_EComEvent.Padding = new System.Windows.Forms.Padding(3);
            this.uipl_EComEvent.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uipl_EComEvent.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uipl_EComEvent.Size = new System.Drawing.Size(474, 387);
            this.uipl_EComEvent.Style = Rex.UI.UIStyle.Custom;
            this.uipl_EComEvent.TabIndex = 0;
            this.uipl_EComEvent.Text = null;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(480, 393);
            this.Controls.Add(this.uipl_EComEvent);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNet";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "设备状态";
            this.SizeChanged += new System.EventHandler(this.FrmNet_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.UI.UIPanel uipl_EComEvent;
        private System.Windows.Forms.Timer timer1;
    }
}