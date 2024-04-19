using RexView;

namespace RexView
{
    partial class Frm_HEViewer
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_roiList = new System.Windows.Forms.GroupBox();
            this.dataGridView_roi = new System.Windows.Forms.DataGridView();
            this.CellID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roiType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hobject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox_fileName = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_selectfile = new System.Windows.Forms.Panel();
            this.button_openFile = new System.Windows.Forms.Button();
            this.button_openFolder = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton_he = new System.Windows.Forms.RadioButton();
            this.radioButton_image = new System.Windows.Forms.RadioButton();
            this.panel_export = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button_export_cloud = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hWindowHE1 = new HWindow_HE();
            this.panel1.SuspendLayout();
            this.groupBox_roiList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_roi)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_selectfile.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_export.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_roiList);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(743, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 693);
            this.panel1.TabIndex = 3;
            // 
            // groupBox_roiList
            // 
            this.groupBox_roiList.Controls.Add(this.dataGridView_roi);
            this.groupBox_roiList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_roiList.Location = new System.Drawing.Point(0, 269);
            this.groupBox_roiList.Name = "groupBox_roiList";
            this.groupBox_roiList.Size = new System.Drawing.Size(397, 424);
            this.groupBox_roiList.TabIndex = 2;
            this.groupBox_roiList.TabStop = false;
            this.groupBox_roiList.Text = "ROI列表";
            // 
            // dataGridView_roi
            // 
            this.dataGridView_roi.AllowUserToAddRows = false;
            this.dataGridView_roi.AllowUserToDeleteRows = false;
            this.dataGridView_roi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_roi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CellID,
            this.CellType,
            this.roiType,
            this.CellNote,
            this.drawColor,
            this.hobject});
            this.dataGridView_roi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_roi.Location = new System.Drawing.Point(3, 17);
            this.dataGridView_roi.Name = "dataGridView_roi";
            this.dataGridView_roi.ReadOnly = true;
            this.dataGridView_roi.RowTemplate.Height = 23;
            this.dataGridView_roi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_roi.Size = new System.Drawing.Size(391, 404);
            this.dataGridView_roi.TabIndex = 0;
            this.dataGridView_roi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_roi_CellClick);
            // 
            // CellID
            // 
            this.CellID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CellID.DataPropertyName = "CellID";
            this.CellID.HeaderText = "单元ID";
            this.CellID.Name = "CellID";
            this.CellID.ReadOnly = true;
            this.CellID.Width = 66;
            // 
            // CellType
            // 
            this.CellType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CellType.DataPropertyName = "CellType";
            this.CellType.HeaderText = "单元类型";
            this.CellType.Name = "CellType";
            this.CellType.ReadOnly = true;
            this.CellType.Width = 78;
            // 
            // roiType
            // 
            this.roiType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.roiType.DataPropertyName = "roiType";
            this.roiType.HeaderText = "轮廓分类";
            this.roiType.Name = "roiType";
            this.roiType.ReadOnly = true;
            this.roiType.Width = 78;
            // 
            // CellNote
            // 
            this.CellNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CellNote.DataPropertyName = "CellNote";
            this.CellNote.HeaderText = "单元描述";
            this.CellNote.Name = "CellNote";
            this.CellNote.ReadOnly = true;
            this.CellNote.Width = 78;
            // 
            // drawColor
            // 
            this.drawColor.DataPropertyName = "drawColor";
            this.drawColor.HeaderText = "drawColor";
            this.drawColor.Name = "drawColor";
            this.drawColor.ReadOnly = true;
            this.drawColor.Visible = false;
            // 
            // hobject
            // 
            this.hobject.DataPropertyName = "hobject";
            this.hobject.HeaderText = "hobject";
            this.hobject.Name = "hobject";
            this.hobject.ReadOnly = true;
            this.hobject.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 269);
            this.panel3.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox_fileName);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 269);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "图像列表";
            // 
            // listBox_fileName
            // 
            this.listBox_fileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_fileName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_fileName.FormattingEnabled = true;
            this.listBox_fileName.ItemHeight = 19;
            this.listBox_fileName.Location = new System.Drawing.Point(3, 59);
            this.listBox_fileName.Name = "listBox_fileName";
            this.listBox_fileName.Size = new System.Drawing.Size(223, 207);
            this.listBox_fileName.TabIndex = 3;
            this.listBox_fileName.SelectedIndexChanged += new System.EventHandler(this.listBox_fileName_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_selectfile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 42);
            this.panel2.TabIndex = 2;
            // 
            // panel_selectfile
            // 
            this.panel_selectfile.Controls.Add(this.button_openFile);
            this.panel_selectfile.Controls.Add(this.button_openFolder);
            this.panel_selectfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_selectfile.Location = new System.Drawing.Point(0, 0);
            this.panel_selectfile.Name = "panel_selectfile";
            this.panel_selectfile.Size = new System.Drawing.Size(223, 42);
            this.panel_selectfile.TabIndex = 0;
            // 
            // button_openFile
            // 
            this.button_openFile.Location = new System.Drawing.Point(3, 6);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(103, 30);
            this.button_openFile.TabIndex = 5;
            this.button_openFile.Text = "选择文件";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // button_openFolder
            // 
            this.button_openFolder.Location = new System.Drawing.Point(117, 6);
            this.button_openFolder.Name = "button_openFolder";
            this.button_openFolder.Size = new System.Drawing.Size(103, 30);
            this.button_openFolder.TabIndex = 6;
            this.button_openFolder.Text = "选择文件夹";
            this.button_openFolder.UseVisualStyleBackColor = true;
            this.button_openFolder.Click += new System.EventHandler(this.button_openFolder_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.panel_export);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(229, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 269);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton_he);
            this.groupBox2.Controls.Add(this.radioButton_image);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 165);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "显示模式";
            // 
            // radioButton8
            // 
            this.radioButton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton8.Location = new System.Drawing.Point(3, 127);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(156, 22);
            this.radioButton8.TabIndex = 5;
            this.radioButton8.Text = "显示搜索范围";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton7
            // 
            this.radioButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton7.Location = new System.Drawing.Point(3, 105);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(156, 22);
            this.radioButton7.TabIndex = 4;
            this.radioButton7.Text = "显示检测结果";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton6.Location = new System.Drawing.Point(3, 83);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(156, 22);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.Text = "显示检测点";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton5.Location = new System.Drawing.Point(3, 61);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(156, 22);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.Text = "显示检测范围";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton_he
            // 
            this.radioButton_he.Checked = true;
            this.radioButton_he.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton_he.Location = new System.Drawing.Point(3, 39);
            this.radioButton_he.Name = "radioButton_he";
            this.radioButton_he.Size = new System.Drawing.Size(156, 22);
            this.radioButton_he.TabIndex = 1;
            this.radioButton_he.TabStop = true;
            this.radioButton_he.Text = "显示效果图";
            this.radioButton_he.UseVisualStyleBackColor = true;
            this.radioButton_he.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton_image
            // 
            this.radioButton_image.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton_image.Location = new System.Drawing.Point(3, 17);
            this.radioButton_image.Name = "radioButton_image";
            this.radioButton_image.Size = new System.Drawing.Size(156, 22);
            this.radioButton_image.TabIndex = 0;
            this.radioButton_image.Text = "只显示原图";
            this.radioButton_image.UseVisualStyleBackColor = true;
            this.radioButton_image.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // panel_export
            // 
            this.panel_export.Controls.Add(this.groupBox5);
            this.panel_export.Controls.Add(this.button_export_cloud);
            this.panel_export.Controls.Add(this.button_export);
            this.panel_export.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_export.Location = new System.Drawing.Point(3, 17);
            this.panel_export.Name = "panel_export";
            this.panel_export.Size = new System.Drawing.Size(162, 84);
            this.panel_export.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton4);
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(162, 42);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "图片大小";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton4.Location = new System.Drawing.Point(120, 17);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(41, 22);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.Text = "0.1";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton3.Location = new System.Drawing.Point(73, 17);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 22);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "0.25";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton2.Location = new System.Drawing.Point(32, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 22);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "0.5";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton1.Location = new System.Drawing.Point(3, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(29, 22);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // button_export_cloud
            // 
            this.button_export_cloud.Location = new System.Drawing.Point(9, 48);
            this.button_export_cloud.Name = "button_export_cloud";
            this.button_export_cloud.Size = new System.Drawing.Size(64, 30);
            this.button_export_cloud.TabIndex = 0;
            this.button_export_cloud.Text = "导出点云";
            this.button_export_cloud.UseVisualStyleBackColor = true;
            this.button_export_cloud.Click += new System.EventHandler(this.button_export_cloud_Click);
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(89, 48);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(64, 30);
            this.button_export.TabIndex = 0;
            this.button_export.Text = "导出图片";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hWindowHE1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 693);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // hWindowHE1
            // 
            this.hWindowHE1.BackColor = System.Drawing.Color.Transparent;
            this.hWindowHE1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hWindowHE1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hWindowHE1.DrawModel = false;
            this.hWindowHE1.Image = null;
            this.hWindowHE1.Location = new System.Drawing.Point(3, 17);
            this.hWindowHE1.Margin = new System.Windows.Forms.Padding(4);
            this.hWindowHE1.Name = "hWindowHE1";
            this.hWindowHE1.Size = new System.Drawing.Size(737, 673);
            this.hWindowHE1.TabIndex = 2;
            // 
            // Frm_HEViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 693);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_HEViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HE查看器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_HEViewer_FormClosing);
            this.panel1.ResumeLayout(false);
            this.groupBox_roiList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_roi)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_selectfile.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel_export.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_roiList;
        private System.Windows.Forms.DataGridView dataGridView_roi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_openFolder;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private HWindow_HE hWindowHE1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_he;
        private System.Windows.Forms.RadioButton radioButton_image;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellType;
        private System.Windows.Forms.DataGridViewTextBoxColumn roiType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn hobject;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_selectfile;
        private System.Windows.Forms.Panel panel_export;
        private System.Windows.Forms.ListBox listBox_fileName;
        private System.Windows.Forms.Button button_export_cloud;
    }
}

