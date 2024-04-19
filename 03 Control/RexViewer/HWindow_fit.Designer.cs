namespace RexView
{
    partial class HWindow_Fit
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
                hv_MenuStrip.Dispose();

                mCtrl_HWindow.HMouseMove -= HWindowControl_HMouseMove;
                mCtrl_HWindow.HMouseWheel -= HWindowControl_HMouseWheel;
            }
            if (disposing && hv_image != null)
            {
                hv_image.Dispose();
            }
            if (disposing && hv_window != null)
            {
                hv_window.Dispose();
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
            this.mCtrl_HWindow = new HalconDotNet.HWindowControl();
            this.m_CtrlHStatusLabelCtrl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar_limitDown = new System.Windows.Forms.TrackBar();
            this.trackBar_limitUp = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_limitDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_limitUp)).BeginInit();
            this.SuspendLayout();
            // 
            // mCtrl_HWindow
            // 
            this.mCtrl_HWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mCtrl_HWindow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mCtrl_HWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mCtrl_HWindow.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.mCtrl_HWindow.Location = new System.Drawing.Point(0, 0);
            this.mCtrl_HWindow.Margin = new System.Windows.Forms.Padding(0);
            this.mCtrl_HWindow.Name = "mCtrl_HWindow";
            this.mCtrl_HWindow.Padding = new System.Windows.Forms.Padding(1);
            this.mCtrl_HWindow.Size = new System.Drawing.Size(611, 440);
            this.mCtrl_HWindow.TabIndex = 0;
            this.mCtrl_HWindow.WindowSize = new System.Drawing.Size(611, 440);
            this.mCtrl_HWindow.HMouseMove += new HalconDotNet.HMouseEventHandler(this.HWindowControl_HMouseMove);
            this.mCtrl_HWindow.HMouseDown += new HalconDotNet.HMouseEventHandler(this.mCtrl_HWindow_HMouseDown);
            this.mCtrl_HWindow.HMouseUp += new HalconDotNet.HMouseEventHandler(this.mCtrl_HWindow_HMouseUp);
            this.mCtrl_HWindow.HMouseWheel += new HalconDotNet.HMouseEventHandler(this.HWindowControl_HMouseWheel);
            // 
            // m_CtrlHStatusLabelCtrl
            // 
            this.m_CtrlHStatusLabelCtrl.AutoSize = true;
            this.m_CtrlHStatusLabelCtrl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_CtrlHStatusLabelCtrl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_CtrlHStatusLabelCtrl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.m_CtrlHStatusLabelCtrl.Location = new System.Drawing.Point(0, 423);
            this.m_CtrlHStatusLabelCtrl.Margin = new System.Windows.Forms.Padding(3);
            this.m_CtrlHStatusLabelCtrl.Name = "m_CtrlHStatusLabelCtrl";
            this.m_CtrlHStatusLabelCtrl.Size = new System.Drawing.Size(112, 17);
            this.m_CtrlHStatusLabelCtrl.TabIndex = 1;
            this.m_CtrlHStatusLabelCtrl.Text = "NO INPUTIMAGE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBar_limitDown);
            this.panel1.Controls.Add(this.trackBar_limitUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(569, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 423);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // trackBar_limitDown
            // 
            this.trackBar_limitDown.AutoSize = false;
            this.trackBar_limitDown.Dock = System.Windows.Forms.DockStyle.Right;
            this.trackBar_limitDown.Location = new System.Drawing.Point(0, 0);
            this.trackBar_limitDown.Maximum = 100000;
            this.trackBar_limitDown.Minimum = 72000;
            this.trackBar_limitDown.Name = "trackBar_limitDown";
            this.trackBar_limitDown.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_limitDown.Size = new System.Drawing.Size(21, 423);
            this.trackBar_limitDown.TabIndex = 3;
            this.trackBar_limitDown.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_limitDown.Value = 92000;
            this.trackBar_limitDown.Scroll += new System.EventHandler(this.trackBar_limitDown_Scroll);
            // 
            // trackBar_limitUp
            // 
            this.trackBar_limitUp.AutoSize = false;
            this.trackBar_limitUp.Dock = System.Windows.Forms.DockStyle.Right;
            this.trackBar_limitUp.Location = new System.Drawing.Point(21, 0);
            this.trackBar_limitUp.Maximum = 108000;
            this.trackBar_limitUp.Minimum = 72000;
            this.trackBar_limitUp.Name = "trackBar_limitUp";
            this.trackBar_limitUp.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_limitUp.Size = new System.Drawing.Size(21, 423);
            this.trackBar_limitUp.TabIndex = 2;
            this.trackBar_limitUp.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_limitUp.Value = 82000;
            this.trackBar_limitUp.Scroll += new System.EventHandler(this.trackBar_limitUp_Scroll);
            // 
            // HWindow_Fit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_CtrlHStatusLabelCtrl);
            this.Controls.Add(this.mCtrl_HWindow);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "HWindow_Fit";
            this.Size = new System.Drawing.Size(611, 440);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_limitDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_limitUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HalconDotNet.HWindowControl mCtrl_HWindow;
        private System.Windows.Forms.Label m_CtrlHStatusLabelCtrl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar_limitDown;
        private System.Windows.Forms.TrackBar trackBar_limitUp;
    }
}
