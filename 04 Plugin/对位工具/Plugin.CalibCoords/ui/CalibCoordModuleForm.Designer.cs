using HalconControl;

namespace Plugin.CalibCoord
{
    partial class CalibCoordModuleForm
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
            this.bt_DisImage = new System.Windows.Forms.Button();
            this.cmb_Device = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_AxisCount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_Main = new System.Windows.Forms.TabControl();
            this.A = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_currPosiY = new System.Windows.Forms.TextBox();
            this.bt_AddData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_currPosiX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Col = new System.Windows.Forms.TextBox();
            this.txt_Row = new System.Windows.Forms.TextBox();
            this.bt_FindCircle = new System.Windows.Forms.Button();
            this.chkRbootMode = new System.Windows.Forms.CheckBox();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label_sx = new System.Windows.Forms.Label();
            this.Label_sy = new System.Windows.Forms.Label();
            this.Label_phi = new System.Windows.Forms.Label();
            this.Label_theta = new System.Windows.Forms.Label();
            this.Label_tx = new System.Windows.Forms.Label();
            this.Label_ty = new System.Windows.Forms.Label();
            this.dgv_Points = new System.Windows.Forms.DataGridView();
            this.B = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_addRow = new System.Windows.Forms.Button();
            this.chk_axisX = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_colS = new System.Windows.Forms.TextBox();
            this.txt_rowS = new System.Windows.Forms.TextBox();
            this.bt_MarkS = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CameraAxisPhi = new System.Windows.Forms.TextBox();
            this.dgv_SingleData = new System.Windows.Forms.DataGridView();
            this.measureControl1 = new DataGridView_ex.MeasureControl();
            this.measureControl2 = new DataGridView_ex.MeasureControl();
            this.hWindow_Fit = new HalconControl.HWindow_Fit();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            this.tab_Main.SuspendLayout();
            this.A.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.TableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Points)).BeginInit();
            this.B.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SingleData)).BeginInit();
            this.SuspendLayout();
            // 
            // button_run
            // 
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // button_save
            // 
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(894, 8);
            // 
            // panel_bottom
            // 
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_bottom.Size = new System.Drawing.Size(994, 44);
            // 
            // txt_UnitDescrible
            // 
            this.txt_UnitDescrible.Margin = new System.Windows.Forms.Padding(2);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.tab_Main);
            this.panel_center.Controls.Add(this.hWindow_Fit);
            this.panel_center.Controls.Add(this.bt_DisImage);
            this.panel_center.Controls.Add(this.cmb_Device);
            this.panel_center.Controls.Add(this.label10);
            this.panel_center.Controls.Add(this.cmb_AxisCount);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.Size = new System.Drawing.Size(994, 432);
            this.panel_center.Controls.SetChildIndex(this.txt_UnitDescrible, 0);
            this.panel_center.Controls.SetChildIndex(this.cmb_AxisCount, 0);
            this.panel_center.Controls.SetChildIndex(this.label10, 0);
            this.panel_center.Controls.SetChildIndex(this.cmb_Device, 0);
            this.panel_center.Controls.SetChildIndex(this.bt_DisImage, 0);
            this.panel_center.Controls.SetChildIndex(this.hWindow_Fit, 0);
            this.panel_center.Controls.SetChildIndex(this.tab_Main, 0);
            // 
            // bt_DisImage
            // 
            this.bt_DisImage.Location = new System.Drawing.Point(783, 5);
            this.bt_DisImage.Name = "bt_DisImage";
            this.bt_DisImage.Size = new System.Drawing.Size(75, 23);
            this.bt_DisImage.TabIndex = 11;
            this.bt_DisImage.Text = "采集图像";
            this.bt_DisImage.UseVisualStyleBackColor = true;
            this.bt_DisImage.Click += new System.EventHandler(this.bt_DisImage_Click);
            // 
            // cmb_Device
            // 
            this.cmb_Device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Device.FormattingEnabled = true;
            this.cmb_Device.Location = new System.Drawing.Point(701, 6);
            this.cmb_Device.Name = "cmb_Device";
            this.cmb_Device.Size = new System.Drawing.Size(76, 20);
            this.cmb_Device.TabIndex = 10;
            this.cmb_Device.SelectedIndexChanged += new System.EventHandler(this.cmb_Device_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(645, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "采集工具:";
            // 
            // cmb_AxisCount
            // 
            this.cmb_AxisCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AxisCount.FormattingEnabled = true;
            this.cmb_AxisCount.Items.AddRange(new object[] {
            "单轴标定",
            "双轴标定"});
            this.cmb_AxisCount.Location = new System.Drawing.Point(509, 6);
            this.cmb_AxisCount.Name = "cmb_AxisCount";
            this.cmb_AxisCount.Size = new System.Drawing.Size(121, 20);
            this.cmb_AxisCount.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "row:";
            // 
            // tab_Main
            // 
            this.tab_Main.Controls.Add(this.A);
            this.tab_Main.Controls.Add(this.B);
            this.tab_Main.Location = new System.Drawing.Point(505, 30);
            this.tab_Main.Name = "tab_Main";
            this.tab_Main.SelectedIndex = 0;
            this.tab_Main.Size = new System.Drawing.Size(486, 400);
            this.tab_Main.TabIndex = 14;
            // 
            // A
            // 
            this.A.Controls.Add(this.groupBox1);
            this.A.Location = new System.Drawing.Point(4, 22);
            this.A.Name = "A";
            this.A.Padding = new System.Windows.Forms.Padding(3);
            this.A.Size = new System.Drawing.Size(478, 374);
            this.A.TabIndex = 0;
            this.A.Text = "XY轴标定";
            this.A.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.measureControl1);
            this.groupBox1.Controls.Add(this.txt_currPosiY);
            this.groupBox1.Controls.Add(this.bt_AddData);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_currPosiX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Col);
            this.groupBox1.Controls.Add(this.txt_Row);
            this.groupBox1.Controls.Add(this.bt_FindCircle);
            this.groupBox1.Controls.Add(this.chkRbootMode);
            this.groupBox1.Controls.Add(this.GroupBox9);
            this.groupBox1.Controls.Add(this.dgv_Points);
            this.groupBox1.Location = new System.Drawing.Point(3, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_currPosiY
            // 
            this.txt_currPosiY.Location = new System.Drawing.Point(404, 59);
            this.txt_currPosiY.Name = "txt_currPosiY";
            this.txt_currPosiY.Size = new System.Drawing.Size(58, 21);
            this.txt_currPosiY.TabIndex = 33;
            // 
            // bt_AddData
            // 
            this.bt_AddData.Location = new System.Drawing.Point(344, 84);
            this.bt_AddData.Name = "bt_AddData";
            this.bt_AddData.Size = new System.Drawing.Size(119, 30);
            this.bt_AddData.TabIndex = 31;
            this.bt_AddData.Text = "<<  添加";
            this.bt_AddData.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "X,Y:";
            // 
            // txt_currPosiX
            // 
            this.txt_currPosiX.Location = new System.Drawing.Point(345, 59);
            this.txt_currPosiX.Name = "txt_currPosiX";
            this.txt_currPosiX.Size = new System.Drawing.Size(58, 21);
            this.txt_currPosiX.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "Col:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "Row:";
            // 
            // txt_Col
            // 
            this.txt_Col.Location = new System.Drawing.Point(345, 35);
            this.txt_Col.Name = "txt_Col";
            this.txt_Col.Size = new System.Drawing.Size(117, 21);
            this.txt_Col.TabIndex = 26;
            // 
            // txt_Row
            // 
            this.txt_Row.Location = new System.Drawing.Point(345, 11);
            this.txt_Row.Name = "txt_Row";
            this.txt_Row.Size = new System.Drawing.Size(117, 21);
            this.txt_Row.TabIndex = 25;
            // 
            // bt_FindCircle
            // 
            this.bt_FindCircle.Location = new System.Drawing.Point(397, 333);
            this.bt_FindCircle.Name = "bt_FindCircle";
            this.bt_FindCircle.Size = new System.Drawing.Size(67, 33);
            this.bt_FindCircle.TabIndex = 24;
            this.bt_FindCircle.Text = "拾取Mark";
            this.bt_FindCircle.UseVisualStyleBackColor = true;
            // 
            // chkRbootMode
            // 
            this.chkRbootMode.AutoSize = true;
            this.chkRbootMode.Location = new System.Drawing.Point(317, 343);
            this.chkRbootMode.Name = "chkRbootMode";
            this.chkRbootMode.Size = new System.Drawing.Size(84, 16);
            this.chkRbootMode.TabIndex = 23;
            this.chkRbootMode.Text = "机械手标定";
            this.chkRbootMode.UseVisualStyleBackColor = true;
            // 
            // GroupBox9
            // 
            this.GroupBox9.Controls.Add(this.TableLayoutPanel6);
            this.GroupBox9.Location = new System.Drawing.Point(4, 233);
            this.GroupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox9.Size = new System.Drawing.Size(306, 135);
            this.GroupBox9.TabIndex = 9;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "标定结果";
            // 
            // TableLayoutPanel6
            // 
            this.TableLayoutPanel6.ColumnCount = 2;
            this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayoutPanel6.Controls.Add(this.Label18, 0, 0);
            this.TableLayoutPanel6.Controls.Add(this.Label19, 0, 1);
            this.TableLayoutPanel6.Controls.Add(this.Label20, 0, 2);
            this.TableLayoutPanel6.Controls.Add(this.Label21, 0, 3);
            this.TableLayoutPanel6.Controls.Add(this.Label22, 0, 4);
            this.TableLayoutPanel6.Controls.Add(this.Label23, 0, 5);
            this.TableLayoutPanel6.Controls.Add(this.Label_sx, 1, 0);
            this.TableLayoutPanel6.Controls.Add(this.Label_sy, 1, 1);
            this.TableLayoutPanel6.Controls.Add(this.Label_phi, 1, 2);
            this.TableLayoutPanel6.Controls.Add(this.Label_theta, 1, 3);
            this.TableLayoutPanel6.Controls.Add(this.Label_tx, 1, 4);
            this.TableLayoutPanel6.Controls.Add(this.Label_ty, 1, 5);
            this.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel6.Location = new System.Drawing.Point(2, 16);
            this.TableLayoutPanel6.Name = "TableLayoutPanel6";
            this.TableLayoutPanel6.RowCount = 6;
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel6.Size = new System.Drawing.Size(302, 117);
            this.TableLayoutPanel6.TabIndex = 4;
            // 
            // Label18
            // 
            this.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label18.Location = new System.Drawing.Point(3, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(175, 19);
            this.Label18.TabIndex = 0;
            this.Label18.Text = "x轴像素当量";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label19
            // 
            this.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label19.Location = new System.Drawing.Point(3, 19);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(175, 19);
            this.Label19.TabIndex = 0;
            this.Label19.Text = "y轴像素当量";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label20
            // 
            this.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label20.Location = new System.Drawing.Point(3, 38);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(175, 19);
            this.Label20.TabIndex = 0;
            this.Label20.Text = "坐标系角度差(°)";
            this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label21
            // 
            this.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label21.Location = new System.Drawing.Point(3, 57);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(175, 19);
            this.Label21.TabIndex = 0;
            this.Label21.Text = "垂直角度差(°)";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label22
            // 
            this.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label22.Location = new System.Drawing.Point(3, 76);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(175, 19);
            this.Label22.TabIndex = 0;
            this.Label22.Text = "x轴偏移";
            this.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label23
            // 
            this.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label23.Location = new System.Drawing.Point(3, 95);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(175, 22);
            this.Label23.TabIndex = 0;
            this.Label23.Text = "y轴偏移";
            this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_sx
            // 
            this.Label_sx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_sx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_sx.Location = new System.Drawing.Point(184, 0);
            this.Label_sx.Name = "Label_sx";
            this.Label_sx.Size = new System.Drawing.Size(115, 19);
            this.Label_sx.TabIndex = 0;
            this.Label_sx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_sy
            // 
            this.Label_sy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_sy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_sy.Location = new System.Drawing.Point(184, 19);
            this.Label_sy.Name = "Label_sy";
            this.Label_sy.Size = new System.Drawing.Size(115, 19);
            this.Label_sy.TabIndex = 0;
            this.Label_sy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_phi
            // 
            this.Label_phi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_phi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_phi.Location = new System.Drawing.Point(184, 38);
            this.Label_phi.Name = "Label_phi";
            this.Label_phi.Size = new System.Drawing.Size(115, 19);
            this.Label_phi.TabIndex = 0;
            this.Label_phi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_theta
            // 
            this.Label_theta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_theta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_theta.Location = new System.Drawing.Point(184, 57);
            this.Label_theta.Name = "Label_theta";
            this.Label_theta.Size = new System.Drawing.Size(115, 19);
            this.Label_theta.TabIndex = 0;
            this.Label_theta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_tx
            // 
            this.Label_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_tx.Location = new System.Drawing.Point(184, 76);
            this.Label_tx.Name = "Label_tx";
            this.Label_tx.Size = new System.Drawing.Size(115, 19);
            this.Label_tx.TabIndex = 0;
            this.Label_tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_ty
            // 
            this.Label_ty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_ty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_ty.Location = new System.Drawing.Point(184, 95);
            this.Label_ty.Name = "Label_ty";
            this.Label_ty.Size = new System.Drawing.Size(115, 22);
            this.Label_ty.TabIndex = 0;
            this.Label_ty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Points
            // 
            this.dgv_Points.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Points.Location = new System.Drawing.Point(3, 11);
            this.dgv_Points.Name = "dgv_Points";
            this.dgv_Points.RowTemplate.Height = 23;
            this.dgv_Points.Size = new System.Drawing.Size(307, 217);
            this.dgv_Points.TabIndex = 1;
            // 
            // B
            // 
            this.B.Controls.Add(this.groupBox2);
            this.B.Location = new System.Drawing.Point(4, 22);
            this.B.Name = "B";
            this.B.Padding = new System.Windows.Forms.Padding(3);
            this.B.Size = new System.Drawing.Size(478, 374);
            this.B.TabIndex = 1;
            this.B.Text = "单轴标定";
            this.B.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.measureControl2);
            this.groupBox2.Controls.Add(this.bt_addRow);
            this.groupBox2.Controls.Add(this.chk_axisX);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_colS);
            this.groupBox2.Controls.Add(this.txt_rowS);
            this.groupBox2.Controls.Add(this.bt_MarkS);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_CameraAxisPhi);
            this.groupBox2.Controls.Add(this.dgv_SingleData);
            this.groupBox2.Location = new System.Drawing.Point(3, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 370);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // bt_addRow
            // 
            this.bt_addRow.Location = new System.Drawing.Point(368, 78);
            this.bt_addRow.Name = "bt_addRow";
            this.bt_addRow.Size = new System.Drawing.Size(86, 33);
            this.bt_addRow.TabIndex = 43;
            this.bt_addRow.Text = "<<  添加";
            this.bt_addRow.UseVisualStyleBackColor = true;
            // 
            // chk_axisX
            // 
            this.chk_axisX.AutoSize = true;
            this.chk_axisX.Location = new System.Drawing.Point(331, 334);
            this.chk_axisX.Name = "chk_axisX";
            this.chk_axisX.Size = new System.Drawing.Size(66, 16);
            this.chk_axisX.TabIndex = 42;
            this.chk_axisX.Text = "X轴移动";
            this.chk_axisX.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 41;
            this.label8.Text = "Col:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 40;
            this.label9.Text = "Row:";
            // 
            // txt_colS
            // 
            this.txt_colS.Location = new System.Drawing.Point(368, 49);
            this.txt_colS.Name = "txt_colS";
            this.txt_colS.Size = new System.Drawing.Size(86, 21);
            this.txt_colS.TabIndex = 39;
            // 
            // txt_rowS
            // 
            this.txt_rowS.Location = new System.Drawing.Point(368, 22);
            this.txt_rowS.Name = "txt_rowS";
            this.txt_rowS.Size = new System.Drawing.Size(86, 21);
            this.txt_rowS.TabIndex = 38;
            // 
            // bt_MarkS
            // 
            this.bt_MarkS.Location = new System.Drawing.Point(403, 326);
            this.bt_MarkS.Name = "bt_MarkS";
            this.bt_MarkS.Size = new System.Drawing.Size(63, 33);
            this.bt_MarkS.TabIndex = 37;
            this.bt_MarkS.Text = "拾取Mark";
            this.bt_MarkS.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "相机和轴夹角:";
            // 
            // txt_CameraAxisPhi
            // 
            this.txt_CameraAxisPhi.Location = new System.Drawing.Point(143, 332);
            this.txt_CameraAxisPhi.Name = "txt_CameraAxisPhi";
            this.txt_CameraAxisPhi.ReadOnly = true;
            this.txt_CameraAxisPhi.Size = new System.Drawing.Size(102, 21);
            this.txt_CameraAxisPhi.TabIndex = 35;
            // 
            // dgv_SingleData
            // 
            this.dgv_SingleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SingleData.Location = new System.Drawing.Point(3, 11);
            this.dgv_SingleData.Name = "dgv_SingleData";
            this.dgv_SingleData.RowTemplate.Height = 23;
            this.dgv_SingleData.Size = new System.Drawing.Size(310, 309);
            this.dgv_SingleData.TabIndex = 34;
            // 
            // measureControl1
            // 
            this.measureControl1.Location = new System.Drawing.Point(316, 129);
            this.measureControl1.Name = "measureControl1";
            this.measureControl1.Size = new System.Drawing.Size(147, 198);
            this.measureControl1.TabIndex = 34;
            // 
            // measureControl2
            // 
            this.measureControl2.Location = new System.Drawing.Point(319, 122);
            this.measureControl2.Name = "measureControl2";
            this.measureControl2.Size = new System.Drawing.Size(147, 198);
            this.measureControl2.TabIndex = 44;
            // 
            // hWindow_Fit
            // 
            this.hWindow_Fit.BackColor = System.Drawing.Color.Transparent;
            this.hWindow_Fit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hWindow_Fit.ForeColor = System.Drawing.SystemColors.Control;
            this.hWindow_Fit.Image = null;
            this.hWindow_Fit.Location = new System.Drawing.Point(3, 30);
            this.hWindow_Fit.Name = "hWindow_Fit";
            this.hWindow_Fit.Size = new System.Drawing.Size(500, 400);
            this.hWindow_Fit.TabIndex = 13;
            // 
            // CalibCoordModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 476);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalibCoordModuleForm";
            this.Text = "ModuleForm";
            this.Load += new System.EventHandler(this.ModuleForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            this.tab_Main.ResumeLayout(false);
            this.A.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.TableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Points)).EndInit();
            this.B.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SingleData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_DisImage;
        private System.Windows.Forms.ComboBox cmb_Device;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_AxisCount;
        private System.Windows.Forms.Label label1;
        private HalconControl.HWindow_Fit hWindow_Fit;
        public DataGridView_ex.MeasureControl measureControlXY;
        public DataGridView_ex.MeasureControl measureControlOneAxis;
        private System.Windows.Forms.TabControl tab_Main;
        private System.Windows.Forms.TabPage A;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_currPosiY;
        private System.Windows.Forms.Button bt_AddData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_currPosiX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Col;
        private System.Windows.Forms.TextBox txt_Row;
        private System.Windows.Forms.Button bt_FindCircle;
        private System.Windows.Forms.CheckBox chkRbootMode;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel6;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label_sx;
        internal System.Windows.Forms.Label Label_sy;
        internal System.Windows.Forms.Label Label_phi;
        internal System.Windows.Forms.Label Label_theta;
        internal System.Windows.Forms.Label Label_tx;
        internal System.Windows.Forms.Label Label_ty;
        private System.Windows.Forms.DataGridView dgv_Points;
        private System.Windows.Forms.TabPage B;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_addRow;
        private System.Windows.Forms.CheckBox chk_axisX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_colS;
        private System.Windows.Forms.TextBox txt_rowS;
        private System.Windows.Forms.Button bt_MarkS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CameraAxisPhi;
        private System.Windows.Forms.DataGridView dgv_SingleData;
        private DataGridView_ex.MeasureControl measureControl1;
        private DataGridView_ex.MeasureControl measureControl2;
    }
}