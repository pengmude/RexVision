namespace EasyVision.EVControl.EVForms
{
    partial class SolutionView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolutionView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabProject = new System.Windows.Forms.TabControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddProject = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteProject = new System.Windows.Forms.ToolStripButton();
            this.tsbSettingProject = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.timer_refreshModuleState = new System.Windows.Forms.Timer(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tool_Start = new System.Windows.Forms.ToolStripButton();
            this.tool_StartFor = new System.Windows.Forms.ToolStripButton();
            this.tool_Stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabProject, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 575);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabProject
            // 
            this.tabProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProject.Location = new System.Drawing.Point(2, 82);
            this.tabProject.Margin = new System.Windows.Forms.Padding(2);
            this.tabProject.Name = "tabProject";
            this.tabProject.SelectedIndex = 0;
            this.tabProject.Size = new System.Drawing.Size(255, 491);
            this.tabProject.TabIndex = 0;
            this.tabProject.SelectedIndexChanged += new System.EventHandler(this.tabProject_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddProject,
            this.btnDeleteProject,
            this.tsbSettingProject,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(259, 40);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddProject
            // 
            this.btnAddProject.AutoSize = false;
            this.btnAddProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddProject.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProject.Image")));
            this.btnAddProject.ImageTransparentColor = System.Drawing.Color.White;
            this.btnAddProject.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(40, 40);
            this.btnAddProject.Text = "添加流程";
            this.btnAddProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.AutoSize = false;
            this.btnDeleteProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteProject.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProject.Image")));
            this.btnDeleteProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteProject.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteProject.Text = "删除流程";
            this.btnDeleteProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // tsbSettingProject
            // 
            this.tsbSettingProject.AutoSize = false;
            this.tsbSettingProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSettingProject.Image = ((System.Drawing.Image)(resources.GetObject("tsbSettingProject.Image")));
            this.tsbSettingProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSettingProject.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.tsbSettingProject.Name = "tsbSettingProject";
            this.tsbSettingProject.Size = new System.Drawing.Size(40, 40);
            this.tsbSettingProject.Text = "流程设置";
            this.tsbSettingProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSettingProject.Click += new System.EventHandler(this.tsbSettingProject_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // timer_refreshModuleState
            // 
            this.timer_refreshModuleState.Enabled = true;
            this.timer_refreshModuleState.Interval = 200;
            this.timer_refreshModuleState.Tick += new System.EventHandler(this.timer_refreshModuleState_Tick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tool_Start,
            this.toolStripLabel3,
            this.tool_StartFor,
            this.toolStripLabel1,
            this.tool_Stop});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(259, 40);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tool_Start
            // 
            this.tool_Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_Start.Image = ((System.Drawing.Image)(resources.GetObject("tool_Start.Image")));
            this.tool_Start.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tool_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_Start.Name = "tool_Start";
            this.tool_Start.Size = new System.Drawing.Size(36, 37);
            this.tool_Start.Text = "tool_Start";
            this.tool_Start.Click += new System.EventHandler(this.tool_Start_Click);
            // 
            // tool_StartFor
            // 
            this.tool_StartFor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_StartFor.Image = ((System.Drawing.Image)(resources.GetObject("tool_StartFor.Image")));
            this.tool_StartFor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tool_StartFor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_StartFor.Name = "tool_StartFor";
            this.tool_StartFor.Size = new System.Drawing.Size(36, 37);
            this.tool_StartFor.Click += new System.EventHandler(this.tool_StartFor_Click);
            // 
            // tool_Stop
            // 
            this.tool_Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_Stop.Image = ((System.Drawing.Image)(resources.GetObject("tool_Stop.Image")));
            this.tool_Stop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tool_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_Stop.Name = "tool_Stop";
            this.tool_Stop.Size = new System.Drawing.Size(36, 37);
            this.tool_Stop.Text = "toolStripButton3";
            this.tool_Stop.Click += new System.EventHandler(this.tool_Stop_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(10, 37);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(10, 37);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(10, 37);
            // 
            // SolutionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SolutionView";
            this.Size = new System.Drawing.Size(259, 575);
            this.Load += new System.EventHandler(this.SolutionView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tabProject;
        private System.Windows.Forms.ToolStripButton btnAddProject;
        private System.Windows.Forms.ToolStripButton btnDeleteProject;
        private System.Windows.Forms.ToolStripButton tsbSettingProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer timer_refreshModuleState;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tool_Start;
        private System.Windows.Forms.ToolStripButton tool_StartFor;
        private System.Windows.Forms.ToolStripButton tool_Stop;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}
