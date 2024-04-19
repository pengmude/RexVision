namespace VisionCore
{
    partial class SolView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbt_ProjAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbt_ProjDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbt_ProjSet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbt_ProjRun = new System.Windows.Forms.ToolStripButton();
            this.tsbt_ProjFor = new System.Windows.Forms.ToolStripButton();
            this.tsbt_ProjStop = new System.Windows.Forms.ToolStripButton();
            this.TabProj = new Rex.CTabControl();
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TabProj, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 575);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbt_ProjAdd,
            this.tsbt_ProjDelete,
            this.tsbt_ProjSet,
            this.toolStripSeparator1,
            this.tsbt_ProjRun,
            this.tsbt_ProjFor,
            this.tsbt_ProjStop});
            this.toolStrip1.Location = new System.Drawing.Point(2, 2);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(266, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbt_ProjAdd
            // 
            this.tsbt_ProjAdd.AutoSize = false;
            this.tsbt_ProjAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbt_ProjAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbt_ProjAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_ProjAdd.Image")));
            this.tsbt_ProjAdd.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbt_ProjAdd.Margin = new System.Windows.Forms.Padding(0);
            this.tsbt_ProjAdd.Name = "tsbt_ProjAdd";
            this.tsbt_ProjAdd.Padding = new System.Windows.Forms.Padding(1);
            this.tsbt_ProjAdd.Size = new System.Drawing.Size(36, 36);
            this.tsbt_ProjAdd.Text = "添加流程";
            this.tsbt_ProjAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbt_ProjAdd.Click += new System.EventHandler(this.tsbt_ProjAdd_Click);
            // 
            // tsbt_ProjDelete
            // 
            this.tsbt_ProjDelete.AutoSize = false;
            this.tsbt_ProjDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbt_ProjDelete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbt_ProjDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_ProjDelete.Image")));
            this.tsbt_ProjDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt_ProjDelete.Margin = new System.Windows.Forms.Padding(0);
            this.tsbt_ProjDelete.Name = "tsbt_ProjDelete";
            this.tsbt_ProjDelete.Padding = new System.Windows.Forms.Padding(1);
            this.tsbt_ProjDelete.Size = new System.Drawing.Size(36, 36);
            this.tsbt_ProjDelete.Text = "删除流程";
            this.tsbt_ProjDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbt_ProjDelete.Click += new System.EventHandler(this.tsbt_ProjDelete_Click);
            // 
            // tsbt_ProjSet
            // 
            this.tsbt_ProjSet.AutoSize = false;
            this.tsbt_ProjSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbt_ProjSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbt_ProjSet.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_ProjSet.Image")));
            this.tsbt_ProjSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt_ProjSet.Margin = new System.Windows.Forms.Padding(0);
            this.tsbt_ProjSet.Name = "tsbt_ProjSet";
            this.tsbt_ProjSet.Padding = new System.Windows.Forms.Padding(1);
            this.tsbt_ProjSet.Size = new System.Drawing.Size(36, 36);
            this.tsbt_ProjSet.Text = "流程设置";
            this.tsbt_ProjSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbt_ProjSet.Click += new System.EventHandler(this.tsbt_ProjSet_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbt_ProjRun
            // 
            this.tsbt_ProjRun.AutoSize = false;
            this.tsbt_ProjRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbt_ProjRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbt_ProjRun.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbt_ProjRun.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_ProjRun.Image")));
            this.tsbt_ProjRun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbt_ProjRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt_ProjRun.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tsbt_ProjRun.Name = "tsbt_ProjRun";
            this.tsbt_ProjRun.Padding = new System.Windows.Forms.Padding(1);
            this.tsbt_ProjRun.Size = new System.Drawing.Size(36, 36);
            this.tsbt_ProjRun.Text = "tool_Start";
            this.tsbt_ProjRun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbt_ProjRun.ToolTipText = "单次运行";
            this.tsbt_ProjRun.Click += new System.EventHandler(this.tsbt_ProjRun_Click);
            // 
            // tsbt_ProjFor
            // 
            this.tsbt_ProjFor.AutoSize = false;
            this.tsbt_ProjFor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbt_ProjFor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbt_ProjFor.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_ProjFor.Image")));
            this.tsbt_ProjFor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbt_ProjFor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt_ProjFor.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tsbt_ProjFor.Name = "tsbt_ProjFor";
            this.tsbt_ProjFor.Padding = new System.Windows.Forms.Padding(1);
            this.tsbt_ProjFor.Size = new System.Drawing.Size(36, 36);
            this.tsbt_ProjFor.ToolTipText = "循环运行";
            this.tsbt_ProjFor.Click += new System.EventHandler(this.tsbt_ProjFor_Click);
            // 
            // tsbt_ProjStop
            // 
            this.tsbt_ProjStop.AutoSize = false;
            this.tsbt_ProjStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbt_ProjStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbt_ProjStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_ProjStop.Image")));
            this.tsbt_ProjStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbt_ProjStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt_ProjStop.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tsbt_ProjStop.Name = "tsbt_ProjStop";
            this.tsbt_ProjStop.Padding = new System.Windows.Forms.Padding(1);
            this.tsbt_ProjStop.Size = new System.Drawing.Size(36, 36);
            this.tsbt_ProjStop.Text = "toolStripButton3";
            this.tsbt_ProjStop.ToolTipText = "停止运行";
            this.tsbt_ProjStop.Click += new System.EventHandler(this.tsbt_ProjStop_Click);
            // 
            // TabProj
            // 
            this.TabProj.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.TabProj.BackColor = System.Drawing.Color.AliceBlue;
            this.TabProj.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.TabProj.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.TabProj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabProj.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabProj.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.TabProj.ItemSize = new System.Drawing.Size(150, 20);
            this.TabProj.Location = new System.Drawing.Point(2, 45);
            this.TabProj.Margin = new System.Windows.Forms.Padding(2);
            this.TabProj.Name = "TabProj";
            this.TabProj.SelectedIndex = 0;
            this.TabProj.Size = new System.Drawing.Size(266, 528);
            this.TabProj.TabIndex = 0;
            this.TabProj.SelectedIndexChanged += new System.EventHandler(this.TabProj_SelectedIndexChanged);
            // 
            // timer_refresh
            // 
            this.timer_refresh.Enabled = true;
            this.timer_refresh.Interval = 1;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // SolView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SolView";
            this.Size = new System.Drawing.Size(270, 575);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Rex.CTabControl TabProj;
        private System.Windows.Forms.ToolStripButton tsbt_ProjAdd;
        private System.Windows.Forms.ToolStripButton tsbt_ProjDelete;
        private System.Windows.Forms.ToolStripButton tsbt_ProjSet;
        private System.Windows.Forms.Timer timer_refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbt_ProjRun;
        private System.Windows.Forms.ToolStripButton tsbt_ProjFor;
        private System.Windows.Forms.ToolStripButton tsbt_ProjStop;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}
