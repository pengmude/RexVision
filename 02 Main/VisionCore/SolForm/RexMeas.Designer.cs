namespace VisionCore
{
    partial class RexMeas
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
            this.uiLabel1 = new Rex.UI.UILabel();
            this.uidd_MeasDis = new Rex.UI.UIDoubleUpDownB();
            this.uidd_VPT = new Rex.UI.UIDoubleUpDownB();
            this.label17 = new Rex.UI.UILabel();
            this.uidd_L2 = new Rex.UI.UIDoubleUpDownB();
            this.uicb_Filter = new Rex.UI.UIComboBox();
            this.label14 = new Rex.UI.UILabel();
            this.label12 = new Rex.UI.UILabel();
            this.uicb_Dir = new Rex.UI.UIComboBox();
            this.label11 = new Rex.UI.UILabel();
            this.label4 = new Rex.UI.UILabel();
            this.uicb_Mode = new Rex.UI.UIComboBox();
            this.label2 = new Rex.UI.UILabel();
            this.uidd_L1 = new Rex.UI.UIDoubleUpDownB();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(4, 37);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(35, 17);
            this.uiLabel1.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 52;
            this.uiLabel1.Text = "宽度:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uidd_MeasDis
            // 
            this.uidd_MeasDis.Decimal = 0;
            this.uidd_MeasDis.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_MeasDis.HasMaximum = true;
            this.uidd_MeasDis.HasMinimum = true;
            this.uidd_MeasDis.Location = new System.Drawing.Point(36, 91);
            this.uidd_MeasDis.Margin = new System.Windows.Forms.Padding(2);
            this.uidd_MeasDis.Maximum = 500D;
            this.uidd_MeasDis.Minimum = 0D;
            this.uidd_MeasDis.MinimumSize = new System.Drawing.Size(100, 0);
            this.uidd_MeasDis.Name = "uidd_MeasDis";
            this.uidd_MeasDis.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_MeasDis.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_MeasDis.Size = new System.Drawing.Size(174, 24);
            this.uidd_MeasDis.Step = 1D;
            this.uidd_MeasDis.StyleCustomMode = true;
            this.uidd_MeasDis.TabIndex = 48;
            this.uidd_MeasDis.Text = null;
            this.uidd_MeasDis.Value = 10D;
            this.uidd_MeasDis.ValueChanged += new Rex.UI.UIDoubleUpDownB.OnValueChanged(this.uidd_MeasDis_ValueChanged);
            // 
            // uidd_VPT
            // 
            this.uidd_VPT.Decimal = 0;
            this.uidd_VPT.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_VPT.HasMaximum = true;
            this.uidd_VPT.HasMinimum = true;
            this.uidd_VPT.Location = new System.Drawing.Point(36, 62);
            this.uidd_VPT.Margin = new System.Windows.Forms.Padding(2);
            this.uidd_VPT.Maximum = 500D;
            this.uidd_VPT.Minimum = 0D;
            this.uidd_VPT.MinimumSize = new System.Drawing.Size(100, 0);
            this.uidd_VPT.Name = "uidd_VPT";
            this.uidd_VPT.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_VPT.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_VPT.Size = new System.Drawing.Size(174, 24);
            this.uidd_VPT.Step = 1D;
            this.uidd_VPT.StyleCustomMode = true;
            this.uidd_VPT.TabIndex = 46;
            this.uidd_VPT.Text = null;
            this.uidd_VPT.Value = 30D;
            this.uidd_VPT.ValueChanged += new Rex.UI.UIDoubleUpDownB.OnValueChanged(this.uidd_MeasDis_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(4, 179);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 17);
            this.label17.Style = Rex.UI.UIStyle.Custom;
            this.label17.TabIndex = 51;
            this.label17.Text = "筛选:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uidd_L2
            // 
            this.uidd_L2.Decimal = 0;
            this.uidd_L2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_L2.HasMaximum = true;
            this.uidd_L2.HasMinimum = true;
            this.uidd_L2.Location = new System.Drawing.Point(36, 33);
            this.uidd_L2.Margin = new System.Windows.Forms.Padding(2);
            this.uidd_L2.Maximum = 500D;
            this.uidd_L2.Minimum = 0D;
            this.uidd_L2.MinimumSize = new System.Drawing.Size(100, 0);
            this.uidd_L2.Name = "uidd_L2";
            this.uidd_L2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_L2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_L2.Size = new System.Drawing.Size(174, 24);
            this.uidd_L2.Step = 1D;
            this.uidd_L2.StyleCustomMode = true;
            this.uidd_L2.TabIndex = 44;
            this.uidd_L2.Text = null;
            this.uidd_L2.Value = 5D;
            this.uidd_L2.ValueChanged += new Rex.UI.UIDoubleUpDownB.OnValueChanged(this.uidd_MeasDis_ValueChanged);
            // 
            // uicb_Filter
            // 
            this.uicb_Filter.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Filter.FormattingEnabled = true;
            this.uicb_Filter.Items.AddRange(new object[] {
            "第一点",
            "最末点",
            "所有点"});
            this.uicb_Filter.Location = new System.Drawing.Point(36, 176);
            this.uicb_Filter.Margin = new System.Windows.Forms.Padding(0);
            this.uicb_Filter.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicb_Filter.Name = "uicb_Filter";
            this.uicb_Filter.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicb_Filter.Radius = 2;
            this.uicb_Filter.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicb_Filter.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicb_Filter.Size = new System.Drawing.Size(173, 23);
            this.uicb_Filter.StyleCustomMode = true;
            this.uicb_Filter.TabIndex = 42;
            this.uicb_Filter.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uicb_Filter.TextChanged += new System.EventHandler(this.uicb_Filter_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(4, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 17);
            this.label14.Style = Rex.UI.UIStyle.Custom;
            this.label14.TabIndex = 50;
            this.label14.Text = "方向:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(4, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 17);
            this.label12.Style = Rex.UI.UIStyle.Custom;
            this.label12.TabIndex = 49;
            this.label12.Text = "模式:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uicb_Dir
            // 
            this.uicb_Dir.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Dir.FormattingEnabled = true;
            this.uicb_Dir.Items.AddRange(new object[] {
            "默认值",
            "顺时针",
            "逆时针"});
            this.uicb_Dir.Location = new System.Drawing.Point(36, 148);
            this.uicb_Dir.Margin = new System.Windows.Forms.Padding(0);
            this.uicb_Dir.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicb_Dir.Name = "uicb_Dir";
            this.uicb_Dir.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicb_Dir.Radius = 2;
            this.uicb_Dir.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicb_Dir.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicb_Dir.Size = new System.Drawing.Size(173, 23);
            this.uicb_Dir.StyleCustomMode = true;
            this.uicb_Dir.TabIndex = 41;
            this.uicb_Dir.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uicb_Dir.TextChanged += new System.EventHandler(this.uicb_Filter_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(4, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.Style = Rex.UI.UIStyle.Custom;
            this.label11.TabIndex = 47;
            this.label11.Text = "间隔:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(4, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.Style = Rex.UI.UIStyle.Custom;
            this.label4.TabIndex = 45;
            this.label4.Text = "阈值:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uicb_Mode
            // 
            this.uicb_Mode.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_Mode.FormattingEnabled = true;
            this.uicb_Mode.Items.AddRange(new object[] {
            "由白到黑",
            "由黑到白",
            "规格一致",
            "所有信息"});
            this.uicb_Mode.Location = new System.Drawing.Point(36, 120);
            this.uicb_Mode.Margin = new System.Windows.Forms.Padding(0);
            this.uicb_Mode.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicb_Mode.Name = "uicb_Mode";
            this.uicb_Mode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicb_Mode.Radius = 2;
            this.uicb_Mode.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicb_Mode.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicb_Mode.Size = new System.Drawing.Size(173, 23);
            this.uicb_Mode.StyleCustomMode = true;
            this.uicb_Mode.TabIndex = 40;
            this.uicb_Mode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uicb_Mode.TextChanged += new System.EventHandler(this.uicb_Filter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.Style = Rex.UI.UIStyle.Custom;
            this.label2.TabIndex = 39;
            this.label2.Text = "高度:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uidd_L1
            // 
            this.uidd_L1.Decimal = 0;
            this.uidd_L1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uidd_L1.HasMaximum = true;
            this.uidd_L1.HasMinimum = true;
            this.uidd_L1.Location = new System.Drawing.Point(36, 4);
            this.uidd_L1.Margin = new System.Windows.Forms.Padding(2);
            this.uidd_L1.Maximum = 500D;
            this.uidd_L1.Minimum = 0D;
            this.uidd_L1.MinimumSize = new System.Drawing.Size(100, 0);
            this.uidd_L1.Name = "uidd_L1";
            this.uidd_L1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uidd_L1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uidd_L1.Size = new System.Drawing.Size(174, 24);
            this.uidd_L1.Step = 1D;
            this.uidd_L1.StyleCustomMode = true;
            this.uidd_L1.TabIndex = 43;
            this.uidd_L1.Text = null;
            this.uidd_L1.Value = 10D;
            this.uidd_L1.ValueChanged += new Rex.UI.UIDoubleUpDownB.OnValueChanged(this.uidd_MeasDis_ValueChanged);
            // 
            // RexMeas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uidd_MeasDis);
            this.Controls.Add(this.uidd_VPT);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.uidd_L2);
            this.Controls.Add(this.uicb_Filter);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.uicb_Dir);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uicb_Mode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uidd_L1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RexMeas";
            this.Size = new System.Drawing.Size(216, 206);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Rex.UI.UILabel uiLabel1;
        private Rex.UI.UIDoubleUpDownB uidd_MeasDis;
        private Rex.UI.UIDoubleUpDownB uidd_VPT;
        private Rex.UI.UILabel label17;
        private Rex.UI.UIDoubleUpDownB uidd_L2;
        protected Rex.UI.UIComboBox uicb_Filter;
        private Rex.UI.UILabel label14;
        private Rex.UI.UILabel label12;
        protected Rex.UI.UIComboBox uicb_Dir;
        private Rex.UI.UILabel label11;
        private Rex.UI.UILabel label4;
        protected Rex.UI.UIComboBox uicb_Mode;
        private Rex.UI.UILabel label2;
        private Rex.UI.UIDoubleUpDownB uidd_L1;
    }
}
