using System;
using VisionCore;

namespace RexVision
{
    partial class FrmShow
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
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch(Exception ex)
            {
                Log.Error("FrmShowDispose:" + ex.Message);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainDockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.SuspendLayout();
            // 
            // MainDockPanel
            // 
            this.MainDockPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainDockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDockPanel.DockBackColor = System.Drawing.SystemColors.Control;
            this.MainDockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.MainDockPanel.Location = new System.Drawing.Point(0, 0);
            this.MainDockPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainDockPanel.Name = "MainDockPanel";
            this.MainDockPanel.RightToLeftLayout = true;
            this.MainDockPanel.Size = new System.Drawing.Size(994, 682);
            this.MainDockPanel.TabIndex = 42;
            // 
            // FrmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 682);
            this.Controls.Add(this.MainDockPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainShow_FormClosed);
            this.Load += new System.EventHandler(this.MainShow_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private WeifenLuo.WinFormsUI.Docking.DockPanel MainDockPanel;
    }
}