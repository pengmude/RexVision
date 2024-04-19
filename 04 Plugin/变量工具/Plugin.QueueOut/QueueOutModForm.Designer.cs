namespace Plugin.QueueOut
{
    partial class QueueOutModForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_VaviableList = new System.Windows.Forms.DataGridView();
            this.mModIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mModName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDataName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDataMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_Wait = new System.Windows.Forms.CheckBox();
            this.cb_Delete = new System.Windows.Forms.CheckBox();
            this.cb_Lenght = new System.Windows.Forms.CheckBox();
            this.num_Lenght = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel_center.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VaviableList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Lenght)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.button8);
            this.panel_center.Controls.Add(this.button9);
            this.panel_center.Controls.Add(this.button10);
            this.panel_center.Controls.Add(this.button11);
            this.panel_center.Controls.Add(this.label1);
            this.panel_center.Controls.Add(this.num_Lenght);
            this.panel_center.Controls.Add(this.cb_Lenght);
            this.panel_center.Controls.Add(this.cb_Delete);
            this.panel_center.Controls.Add(this.cb_Wait);
            this.panel_center.Controls.Add(this.dgv_VaviableList);
            this.panel_center.Controls.Add(this.button7);
            this.panel_center.Controls.Add(this.button6);
            this.panel_center.Controls.Add(this.button5);
            this.panel_center.Controls.Add(this.button4);
            this.panel_center.Controls.Add(this.button3);
            this.panel_center.Controls.Add(this.button2);
            this.panel_center.Controls.Add(this.button1);
            this.panel_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_center.Location = new System.Drawing.Point(0, 32);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.Size = new System.Drawing.Size(848, 516);
            // 
            // btn_Run
            // 
            this.btn_Run.Visible = false;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(650, 5);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // panel_bottom
            // 
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // txt_UnitDescrible
            // 
            this.uitb_Remark.Margin = new System.Windows.Forms.Padding(2);
            // 
            // dgv_VaviableList
            // 
            this.dgv_VaviableList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_VaviableList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_VaviableList.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VaviableList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_VaviableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VaviableList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mModIndex,
            this.mModName,
            this.mDataName,
            this.mDataType,
            this.mDataMode});
            this.dgv_VaviableList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_VaviableList.Location = new System.Drawing.Point(2, 34);
            this.dgv_VaviableList.Name = "dgv_VaviableList";
            this.dgv_VaviableList.ReadOnly = true;
            this.dgv_VaviableList.RowTemplate.Height = 23;
            this.dgv_VaviableList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_VaviableList.Size = new System.Drawing.Size(630, 440);
            this.dgv_VaviableList.TabIndex = 58;
            // 
            // mModIndex
            // 
            this.mModIndex.DataPropertyName = "mModIndex";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mModIndex.DefaultCellStyle = dataGridViewCellStyle2;
            this.mModIndex.FillWeight = 50F;
            this.mModIndex.HeaderText = "索引";
            this.mModIndex.Name = "mModIndex";
            this.mModIndex.ReadOnly = true;
            this.mModIndex.ToolTipText = "单元";
            this.mModIndex.Width = 80;
            // 
            // mModName
            // 
            this.mModName.DataPropertyName = "mModName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mModName.DefaultCellStyle = dataGridViewCellStyle3;
            this.mModName.HeaderText = "类型";
            this.mModName.Name = "mModName";
            this.mModName.ReadOnly = true;
            this.mModName.Width = 80;
            // 
            // mDataName
            // 
            this.mDataName.DataPropertyName = "mDataName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mDataName.DefaultCellStyle = dataGridViewCellStyle4;
            this.mDataName.HeaderText = "名称";
            this.mDataName.Name = "mDataName";
            this.mDataName.ReadOnly = true;
            this.mDataName.ToolTipText = "名称";
            this.mDataName.Width = 150;
            // 
            // mDataType
            // 
            this.mDataType.DataPropertyName = "mDataType";
            this.mDataType.HeaderText = "值";
            this.mDataType.Name = "mDataType";
            this.mDataType.ReadOnly = true;
            this.mDataType.Width = 150;
            // 
            // mDataMode
            // 
            this.mDataMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mDataMode.DataPropertyName = "mDataMode";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mDataMode.DefaultCellStyle = dataGridViewCellStyle5;
            this.mDataMode.HeaderText = "注释";
            this.mDataMode.Name = "mDataMode";
            this.mDataMode.ReadOnly = true;
            this.mDataMode.ToolTipText = "类型";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(704, 260);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 23);
            this.button7.TabIndex = 57;
            this.button7.Text = "下移";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btn_Chang_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(704, 231);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 23);
            this.button6.TabIndex = 56;
            this.button6.Text = "上移";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btn_Chang_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(704, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 23);
            this.button5.TabIndex = 55;
            this.button5.Text = "删除";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btn_Chang_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(650, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 23);
            this.button4.TabIndex = 54;
            this.button4.Text = "添加Bool";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_AddData_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(650, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 53;
            this.button3.Text = "添加String";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btn_AddData_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(650, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 52;
            this.button2.Text = "添加Double";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_AddData_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(650, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "添加Int";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_AddData_Click);
            // 
            // cb_Wait
            // 
            this.cb_Wait.AutoSize = true;
            this.cb_Wait.Location = new System.Drawing.Point(39, 10);
            this.cb_Wait.Name = "cb_Wait";
            this.cb_Wait.Size = new System.Drawing.Size(72, 16);
            this.cb_Wait.TabIndex = 62;
            this.cb_Wait.Text = "阻塞等待";
            this.cb_Wait.UseVisualStyleBackColor = true;
            this.cb_Wait.CheckStateChanged += new System.EventHandler(this.cb_Wait_CheckStateChanged);
            // 
            // cb_Delete
            // 
            this.cb_Delete.AutoSize = true;
            this.cb_Delete.Location = new System.Drawing.Point(117, 10);
            this.cb_Delete.Name = "cb_Delete";
            this.cb_Delete.Size = new System.Drawing.Size(96, 16);
            this.cb_Delete.TabIndex = 63;
            this.cb_Delete.Text = "删除出队数据";
            this.cb_Delete.UseVisualStyleBackColor = true;
            this.cb_Delete.CheckStateChanged += new System.EventHandler(this.cb_Wait_CheckStateChanged);
            // 
            // cb_Lenght
            // 
            this.cb_Lenght.AutoSize = true;
            this.cb_Lenght.Location = new System.Drawing.Point(265, 10);
            this.cb_Lenght.Name = "cb_Lenght";
            this.cb_Lenght.Size = new System.Drawing.Size(72, 16);
            this.cb_Lenght.TabIndex = 64;
            this.cb_Lenght.Text = "长度限制";
            this.cb_Lenght.UseVisualStyleBackColor = true;
            this.cb_Lenght.CheckStateChanged += new System.EventHandler(this.cb_Wait_CheckStateChanged);
            // 
            // num_Lenght
            // 
            this.num_Lenght.Location = new System.Drawing.Point(408, 8);
            this.num_Lenght.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Lenght.Name = "num_Lenght";
            this.num_Lenght.Size = new System.Drawing.Size(68, 21);
            this.num_Lenght.TabIndex = 66;
            this.num_Lenght.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Lenght.ValueChanged += new System.EventHandler(this.cb_Wait_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 67;
            this.label1.Text = "限制长度:";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(744, 187);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 23);
            this.button8.TabIndex = 71;
            this.button8.Text = "添加Bool[]";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btn_AddData_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(744, 145);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 23);
            this.button9.TabIndex = 70;
            this.button9.Text = "添加String[]";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btn_AddData_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(744, 102);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(85, 23);
            this.button10.TabIndex = 69;
            this.button10.Text = "添加Double[]";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.btn_AddData_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(744, 58);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(85, 23);
            this.button11.TabIndex = 68;
            this.button11.Text = "添加Int[]";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.btn_AddData_Click);
            // 
            // QueueOutModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QueueOutModForm";
            this.Load += new System.EventHandler(this.DelayModForm_Load);
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VaviableList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Lenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_VaviableList;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mModIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn mModName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDataName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDataMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_Lenght;
        private System.Windows.Forms.CheckBox cb_Lenght;
        private System.Windows.Forms.CheckBox cb_Delete;
        private System.Windows.Forms.CheckBox cb_Wait;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}