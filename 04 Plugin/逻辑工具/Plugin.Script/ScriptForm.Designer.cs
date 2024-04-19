namespace Plugin.Script
{
    partial class ScriptForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("GetBool(string key)");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("GetString(string key)");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("GetInt(string key)");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("GetDouble(string key)");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("GetBoolList(string key)");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("GetStringList(string key)");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("GetIntList(string key)");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("GetDoubleList(string key)");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("获取变量值", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("SetBool(string key, bool value)");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("SetString(string key,string value)");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("SetDouble(string key, double value)");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("SetInt(string key, int value)");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("SetBoolList(string key, List<bool> value)");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("SetStringList(string key, List<string> value)");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("SetIntList(string key, List<int> value)");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("SetDoubleList(string key, List<double> value)");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("保存值到变量列表", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("SaveObj2File(T obj, string path)");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("GetObjFromFile(string path)S");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("SaveCSV(string filePath, string dataStr, string header )");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("文件操作", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Sleep(int millisecond)");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Show(string msg)");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("LogInfo(string log)");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("LogDebug(string log)");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("系统功能", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("计算函数");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("函数", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode18,
            treeNode22,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("sColor");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("genRegion()");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("genXLD()");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("getTuple()");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("ROI", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("StartY");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("StartX");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("EndY");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Ny");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Nx");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode(" Dist");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Phi");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("MidY");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("MidX");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Line_Info(double m_start_Row, double m_start_Col, double m_end_Row, double m_end_" +
        "Col)");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("genXLD()");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("getTuple()");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Line_Info", new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("x, y, z");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("ax, by, cz, d");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Angle");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("xAn, yAn, zAn");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Flat, MinFlat, MaxFlat");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("MinZ, MaxZ;");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Plane_Info", new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51,
            treeNode52,
            treeNode53});
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("a, b, c;");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("tagVector", new System.Windows.Forms.TreeNode[] {
            treeNode55});
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("CenterY, CenterX, Radius;");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("StartPhi , EndPhi ");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("PointOrder");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Circle_Info()");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Circle_Info(double m_Row_center, double m_Column_center, double m_Radius)");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Circle_Info(double m_Row_center, double m_Column_center, double m_Radius, double " +
        "m_StartPhi, double m_EndPhi, string m_PointOrder)");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("genRegion()");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("genXLD()");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("getTuple()");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Clone()");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Circle_Info", new System.Windows.Forms.TreeNode[] {
            treeNode57,
            treeNode58,
            treeNode59,
            treeNode60,
            treeNode61,
            treeNode62,
            treeNode63,
            treeNode64,
            treeNode65,
            treeNode66});
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("CenterY, CenterX, Phi, Radius1, Radius2");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("StartPhi , EndPhi ");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("PointOrder");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Ellipse_Info()");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Ellipse_Info(double m_Row_center, double m_Column_center, double m_Phi, double m_" +
        "Radius1, double m_Radius2)");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("genRegion()");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("genXLD()");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Clone()");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("getTuple()");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Ellipse_Info", new System.Windows.Forms.TreeNode[] {
            treeNode68,
            treeNode69,
            treeNode70,
            treeNode71,
            treeNode72,
            treeNode73,
            treeNode74,
            treeNode75,
            treeNode76});
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("mHRegion");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("DrawRoi_Info()");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("DrawRoi_Info(HRegion hregion)");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("genRegion()");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("genXLD()");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("getTuple()");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("DrawRoi_Info", new System.Windows.Forms.TreeNode[] {
            treeNode78,
            treeNode79,
            treeNode80,
            treeNode81,
            treeNode82,
            treeNode83});
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("StartY, StartX, EndY, EndX");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Rect_Info()");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Rect_Info(double m_Row_Start, double m_Column_Start, double m_Row_End, double m_C" +
        "olumn_End)");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("genRegion()");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("genXLD()");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("getTuple()");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Rect_Info", new System.Windows.Forms.TreeNode[] {
            treeNode85,
            treeNode86,
            treeNode87,
            treeNode88,
            treeNode89,
            treeNode90});
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("CenterY");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode(" CenterX");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode(" Phi");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Length1");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Length2");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("Rect2_Info()");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Rect2_Info(double m_Row_center, double m_Column_center, double m_Phi, double m_Le" +
        "ngth1, double m_Length2)");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("genRegion()");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("genXLD()");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("getTuple()");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Clone()");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Rect2_Info", new System.Windows.Forms.TreeNode[] {
            treeNode92,
            treeNode93,
            treeNode94,
            treeNode95,
            treeNode96,
            treeNode97,
            treeNode98,
            treeNode99,
            treeNode100,
            treeNode101,
            treeNode102});
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("X");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("Y");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("Z");
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("Point3DF(float _x, float _y, float _z)");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("Point3DF", new System.Windows.Forms.TreeNode[] {
            treeNode104,
            treeNode105,
            treeNode106,
            treeNode107});
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("X");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("Y");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("Value_Avg");
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("Value_Median");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("Value_Max");
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("Value_Min");
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("X_List");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("Y_List");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("Value_List");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("Rect_Info(double _x, double _y, double _avg, double _median, double _max, double " +
        "_min, List<double> _xList, List<double> _yList, List<double> _valueList)");
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("Rect_Info", new System.Windows.Forms.TreeNode[] {
            treeNode109,
            treeNode110,
            treeNode111,
            treeNode112,
            treeNode113,
            treeNode114,
            treeNode115,
            treeNode116,
            treeNode117,
            treeNode118});
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("Y, X, Phi");
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("Coord_Info(double _row, double _col, double _phi)");
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("Coord_Info", new System.Windows.Forms.TreeNode[] {
            treeNode120,
            treeNode121});
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("Length1, Length2, Threshold, MeasDis");
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("ParamName, ParamValue");
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("PointsOrder");
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("Meas_Info(double _length1, double _length2, double _threshold, double _measureDis" +
        ", HTuple _paraName, HTuple _paraValue, int _pointsOrder)");
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("Meas_Info", new System.Windows.Forms.TreeNode[] {
            treeNode123,
            treeNode124,
            treeNode125,
            treeNode126});
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("mModName");
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("mModIndex");
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("节点115");
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("节点116");
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("节点117");
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("节点118");
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("DataCell", new System.Windows.Forms.TreeNode[] {
            treeNode128,
            treeNode129,
            treeNode130,
            treeNode131,
            treeNode132,
            treeNode133});
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("数据结构", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode47,
            treeNode54,
            treeNode56,
            treeNode67,
            treeNode77,
            treeNode84,
            treeNode91,
            treeNode103,
            treeNode108,
            treeNode119,
            treeNode122,
            treeNode127,
            treeNode134});
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("流程变量");
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("全局变量");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptForm));
            this.MethodTreeView = new System.Windows.Forms.TreeView();
            this.btn_Compile = new Rex.UI.UIButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Compile = new System.Windows.Forms.ListBox();
            this.scintilla = new ScintillaNET.Scintilla();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.findReplace1 = new RexFind.FindReplace();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.btn_Compile);
            this.panel_bottom.Controls.SetChildIndex(this.cb_Enable, 0);
            this.panel_bottom.Controls.SetChildIndex(this.uIlb_describle, 0);
            this.panel_bottom.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.panel_bottom.Controls.SetChildIndex(this.btn_Save, 0);
            this.panel_bottom.Controls.SetChildIndex(this.btn_Run, 0);
            this.panel_bottom.Controls.SetChildIndex(this.uitb_Remark, 0);
            this.panel_bottom.Controls.SetChildIndex(this.btn_Compile, 0);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.splitContainer2);
            this.panel_center.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(653, 5);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(546, 5);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // titlelabel
            // 
            this.titlelabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.titlelabel.Size = new System.Drawing.Size(64, 17);
            // 
            // MethodTreeView
            // 
            this.MethodTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MethodTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MethodTreeView.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.MethodTreeView.Location = new System.Drawing.Point(3, 3);
            this.MethodTreeView.Name = "MethodTreeView";
            treeNode1.Name = "节点10";
            treeNode1.Text = "GetBool(string key)";
            treeNode2.Name = "节点11";
            treeNode2.Text = "GetString(string key)";
            treeNode3.Name = "节点12";
            treeNode3.Text = "GetInt(string key)";
            treeNode4.Name = "节点13";
            treeNode4.Text = "GetDouble(string key)";
            treeNode5.Name = "节点14";
            treeNode5.Text = "GetBoolList(string key)";
            treeNode6.Name = "节点15";
            treeNode6.Text = "GetStringList(string key)";
            treeNode7.Name = "节点16";
            treeNode7.Text = "GetIntList(string key)";
            treeNode8.Name = "节点17";
            treeNode8.Text = "GetDoubleList(string key)";
            treeNode9.Name = "节点1";
            treeNode9.Text = "获取变量值";
            treeNode10.Name = "节点19";
            treeNode10.Text = "SetBool(string key, bool value)";
            treeNode11.Name = "节点18";
            treeNode11.Text = "SetString(string key,string value)";
            treeNode12.Name = "节点20";
            treeNode12.Text = "SetDouble(string key, double value)";
            treeNode13.Name = "节点21";
            treeNode13.Text = "SetInt(string key, int value)";
            treeNode14.Name = "节点22";
            treeNode14.Text = "SetBoolList(string key, List<bool> value)";
            treeNode15.Name = "节点23";
            treeNode15.Text = "SetStringList(string key, List<string> value)";
            treeNode16.Name = "节点24";
            treeNode16.Text = "SetIntList(string key, List<int> value)";
            treeNode17.Name = "节点25";
            treeNode17.Text = "SetDoubleList(string key, List<double> value)";
            treeNode18.Name = "节点2";
            treeNode18.Text = "保存值到变量列表";
            treeNode19.Name = "节点26";
            treeNode19.Text = "SaveObj2File(T obj, string path)";
            treeNode20.Name = "节点27";
            treeNode20.Text = "GetObjFromFile(string path)S";
            treeNode21.Name = "节点28";
            treeNode21.Text = "SaveCSV(string filePath, string dataStr, string header )";
            treeNode22.Name = "节点6";
            treeNode22.Text = "文件操作";
            treeNode23.Name = "节点7";
            treeNode23.Text = "Sleep(int millisecond)";
            treeNode24.Name = "节点29";
            treeNode24.Text = "Show(string msg)";
            treeNode25.Name = "节点30";
            treeNode25.Text = "LogInfo(string log)";
            treeNode26.Name = "节点31";
            treeNode26.Text = "LogDebug(string log)";
            treeNode27.Name = "节点8";
            treeNode27.Text = "系统功能";
            treeNode28.Name = "节点9";
            treeNode28.Text = "计算函数";
            treeNode29.Name = "节点0";
            treeNode29.Text = "函数";
            treeNode30.Name = "节点3";
            treeNode30.Text = "sColor";
            treeNode31.Name = "节点4";
            treeNode31.Text = "genRegion()";
            treeNode32.Name = "节点5";
            treeNode32.Text = "genXLD()";
            treeNode33.Name = "节点6";
            treeNode33.Text = "getTuple()";
            treeNode34.Name = "节点0";
            treeNode34.Text = "ROI";
            treeNode35.Name = "节点7";
            treeNode35.Text = "StartY";
            treeNode36.Name = "节点8";
            treeNode36.Text = "StartX";
            treeNode37.Name = "节点9";
            treeNode37.Text = "EndY";
            treeNode38.Name = "节点10";
            treeNode38.Text = "Ny";
            treeNode39.Name = "节点11";
            treeNode39.Text = "Nx";
            treeNode40.Name = "节点12";
            treeNode40.Text = " Dist";
            treeNode41.Name = "节点13";
            treeNode41.Text = "Phi";
            treeNode42.Name = "节点14";
            treeNode42.Text = "MidY";
            treeNode43.Name = "节点15";
            treeNode43.Text = "MidX";
            treeNode44.Name = "节点16";
            treeNode44.Text = "Line_Info(double m_start_Row, double m_start_Col, double m_end_Row, double m_end_" +
    "Col)";
            treeNode45.Name = "节点17";
            treeNode45.Text = "genXLD()";
            treeNode46.Name = "节点18";
            treeNode46.Text = "getTuple()";
            treeNode47.Name = "节点1";
            treeNode47.Text = "Line_Info";
            treeNode48.Name = "节点19";
            treeNode48.Text = "x, y, z";
            treeNode49.Name = "节点20";
            treeNode49.Text = "ax, by, cz, d";
            treeNode50.Name = "节点21";
            treeNode50.Text = "Angle";
            treeNode51.Name = "节点22";
            treeNode51.Text = "xAn, yAn, zAn";
            treeNode52.Name = "节点23";
            treeNode52.Text = "Flat, MinFlat, MaxFlat";
            treeNode53.Name = "节点24";
            treeNode53.Text = "MinZ, MaxZ;";
            treeNode54.Name = "节点2";
            treeNode54.Text = "Plane_Info";
            treeNode55.Name = "节点26";
            treeNode55.Text = "a, b, c;";
            treeNode56.Name = "节点25";
            treeNode56.Text = "tagVector";
            treeNode57.Name = "节点30";
            treeNode57.Text = "CenterY, CenterX, Radius;";
            treeNode58.Name = "节点31";
            treeNode58.Text = "StartPhi , EndPhi ";
            treeNode59.Name = "节点32";
            treeNode59.Text = "PointOrder";
            treeNode60.Name = "节点33";
            treeNode60.Text = "Circle_Info()";
            treeNode61.Name = "节点34";
            treeNode61.Text = "Circle_Info(double m_Row_center, double m_Column_center, double m_Radius)";
            treeNode62.Name = "节点36";
            treeNode62.Text = "Circle_Info(double m_Row_center, double m_Column_center, double m_Radius, double " +
    "m_StartPhi, double m_EndPhi, string m_PointOrder)";
            treeNode63.Name = "节点37";
            treeNode63.Text = "genRegion()";
            treeNode64.Name = "节点38";
            treeNode64.Text = "genXLD()";
            treeNode65.Name = "节点35";
            treeNode65.Text = "getTuple()";
            treeNode66.Name = "节点39";
            treeNode66.Text = "Clone()";
            treeNode67.Name = "节点27";
            treeNode67.Text = "Circle_Info";
            treeNode68.Name = "节点40";
            treeNode68.Text = "CenterY, CenterX, Phi, Radius1, Radius2";
            treeNode69.Name = "节点41";
            treeNode69.Text = "StartPhi , EndPhi ";
            treeNode70.Name = "节点42";
            treeNode70.Text = "PointOrder";
            treeNode71.Name = "节点43";
            treeNode71.Text = "Ellipse_Info()";
            treeNode72.Name = "节点44";
            treeNode72.Text = "Ellipse_Info(double m_Row_center, double m_Column_center, double m_Phi, double m_" +
    "Radius1, double m_Radius2)";
            treeNode73.Name = "节点45";
            treeNode73.Text = "genRegion()";
            treeNode74.Name = "节点46";
            treeNode74.Text = "genXLD()";
            treeNode75.Name = "节点47";
            treeNode75.Text = "Clone()";
            treeNode76.Name = "节点48";
            treeNode76.Text = "getTuple()";
            treeNode77.Name = "节点28";
            treeNode77.Text = "Ellipse_Info";
            treeNode78.Name = "节点49";
            treeNode78.Text = "mHRegion";
            treeNode79.Name = "节点50";
            treeNode79.Text = "DrawRoi_Info()";
            treeNode80.Name = "节点51";
            treeNode80.Text = "DrawRoi_Info(HRegion hregion)";
            treeNode81.Name = "节点52";
            treeNode81.Text = "genRegion()";
            treeNode82.Name = "节点53";
            treeNode82.Text = "genXLD()";
            treeNode83.Name = "节点54";
            treeNode83.Text = "getTuple()";
            treeNode84.Name = "节点29";
            treeNode84.Text = "DrawRoi_Info";
            treeNode85.Name = "节点58";
            treeNode85.Text = "StartY, StartX, EndY, EndX";
            treeNode86.Name = "节点59";
            treeNode86.Text = "Rect_Info()";
            treeNode87.Name = "节点60";
            treeNode87.Text = "Rect_Info(double m_Row_Start, double m_Column_Start, double m_Row_End, double m_C" +
    "olumn_End)";
            treeNode88.Name = "节点61";
            treeNode88.Text = "genRegion()";
            treeNode89.Name = "节点62";
            treeNode89.Text = "genXLD()";
            treeNode90.Name = "节点63";
            treeNode90.Text = "getTuple()";
            treeNode91.Name = "节点56";
            treeNode91.Text = "Rect_Info";
            treeNode92.Name = "节点69";
            treeNode92.Text = "CenterY";
            treeNode93.Name = "节点70";
            treeNode93.Text = " CenterX";
            treeNode94.Name = "节点71";
            treeNode94.Text = " Phi";
            treeNode95.Name = "节点72";
            treeNode95.Text = "Length1";
            treeNode96.Name = "节点73";
            treeNode96.Text = "Length2";
            treeNode97.Name = "节点74";
            treeNode97.Text = "Rect2_Info()";
            treeNode98.Name = "节点75";
            treeNode98.Text = "Rect2_Info(double m_Row_center, double m_Column_center, double m_Phi, double m_Le" +
    "ngth1, double m_Length2)";
            treeNode99.Name = "节点76";
            treeNode99.Text = "genRegion()";
            treeNode100.Name = "节点77";
            treeNode100.Text = "genXLD()";
            treeNode101.Name = "节点78";
            treeNode101.Text = "getTuple()";
            treeNode102.Name = "节点79";
            treeNode102.Text = "Clone()";
            treeNode103.Name = "节点57";
            treeNode103.Text = "Rect2_Info";
            treeNode104.Name = "节点80";
            treeNode104.Text = "X";
            treeNode105.Name = "节点81";
            treeNode105.Text = "Y";
            treeNode106.Name = "节点82";
            treeNode106.Text = "Z";
            treeNode107.Name = "节点83";
            treeNode107.Text = "Point3DF(float _x, float _y, float _z)";
            treeNode108.Name = "节点66";
            treeNode108.Text = "Point3DF";
            treeNode109.Name = "节点87";
            treeNode109.Text = "X";
            treeNode110.Name = "节点88";
            treeNode110.Text = "Y";
            treeNode111.Name = "节点89";
            treeNode111.Text = "Value_Avg";
            treeNode112.Name = "节点90";
            treeNode112.Text = "Value_Median";
            treeNode113.Name = "节点91";
            treeNode113.Text = "Value_Max";
            treeNode114.Name = "节点92";
            treeNode114.Text = "Value_Min";
            treeNode115.Name = "节点93";
            treeNode115.Text = "X_List";
            treeNode116.Name = "节点94";
            treeNode116.Text = "Y_List";
            treeNode117.Name = "节点95";
            treeNode117.Text = "Value_List";
            treeNode118.Name = "节点96";
            treeNode118.Text = "Rect_Info(double _x, double _y, double _avg, double _median, double _max, double " +
    "_min, List<double> _xList, List<double> _yList, List<double> _valueList)";
            treeNode119.Name = "节点67";
            treeNode119.Text = "Rect_Info";
            treeNode120.Name = "节点102";
            treeNode120.Text = "Y, X, Phi";
            treeNode121.Name = "节点103";
            treeNode121.Text = "Coord_Info(double _row, double _col, double _phi)";
            treeNode122.Name = "节点68";
            treeNode122.Text = "Coord_Info";
            treeNode123.Name = "节点108";
            treeNode123.Text = "Length1, Length2, Threshold, MeasDis";
            treeNode124.Name = "节点109";
            treeNode124.Text = "ParamName, ParamValue";
            treeNode125.Name = "节点110";
            treeNode125.Text = "PointsOrder";
            treeNode126.Name = "节点111";
            treeNode126.Text = "Meas_Info(double _length1, double _length2, double _threshold, double _measureDis" +
    ", HTuple _paraName, HTuple _paraValue, int _pointsOrder)";
            treeNode127.Name = "节点97";
            treeNode127.Text = "Meas_Info";
            treeNode128.Name = "节点113";
            treeNode128.Text = "mModName";
            treeNode129.Name = "节点114";
            treeNode129.Text = "mModIndex";
            treeNode130.Name = "节点115";
            treeNode130.Text = "节点115";
            treeNode131.Name = "节点116";
            treeNode131.Text = "节点116";
            treeNode132.Name = "节点117";
            treeNode132.Text = "节点117";
            treeNode133.Name = "节点118";
            treeNode133.Text = "节点118";
            treeNode134.Name = "节点98";
            treeNode134.Text = "DataCell";
            treeNode135.Name = "节点1";
            treeNode135.Text = "数据结构";
            treeNode136.Name = "节点2";
            treeNode136.Text = "流程变量";
            treeNode137.Name = "节点3";
            treeNode137.Text = "全局变量";
            this.MethodTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode135,
            treeNode136,
            treeNode137});
            this.MethodTreeView.Size = new System.Drawing.Size(300, 355);
            this.MethodTreeView.TabIndex = 9;
            this.MethodTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MethodTreeView_NodeMouseClick);
            this.MethodTreeView.Click += new System.EventHandler(this.MethodTreeView_Click);
            this.MethodTreeView.DoubleClick += new System.EventHandler(this.MethodTreeView_DoubleClick);
            // 
            // btn_Compile
            // 
            this.btn_Compile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Compile.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Compile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Compile.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Compile.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Compile.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Compile.Location = new System.Drawing.Point(437, 5);
            this.btn_Compile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Compile.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Compile.Name = "btn_Compile";
            this.btn_Compile.Size = new System.Drawing.Size(82, 26);
            this.btn_Compile.Style = Rex.UI.UIStyle.Custom;
            this.btn_Compile.TabIndex = 14;
            this.btn_Compile.Text = "编译";
            this.btn_Compile.Click += new System.EventHandler(this.btn_Compile_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tb_Compile, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.scintilla, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(534, 471);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tb_Compile
            // 
            this.tb_Compile.BackColor = System.Drawing.Color.White;
            this.tb_Compile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Compile.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tb_Compile.FormattingEnabled = true;
            this.tb_Compile.ItemHeight = 17;
            this.tb_Compile.Location = new System.Drawing.Point(3, 301);
            this.tb_Compile.Name = "tb_Compile";
            this.tb_Compile.ScrollAlwaysVisible = true;
            this.tb_Compile.Size = new System.Drawing.Size(528, 138);
            this.tb_Compile.TabIndex = 13;
            // 
            // scintilla
            // 
            this.scintilla.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.scintilla.CaretLineBackColor = System.Drawing.Color.LightBlue;
            this.scintilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla.EdgeColor = System.Drawing.Color.LightBlue;
            this.scintilla.FontQuality = ScintillaNET.FontQuality.LcdOptimized;
            this.scintilla.Location = new System.Drawing.Point(3, 3);
            this.scintilla.Name = "scintilla";
            this.scintilla.Size = new System.Drawing.Size(528, 292);
            this.scintilla.TabIndex = 14;
            this.scintilla.Enter += new System.EventHandler(this.genericScintilla1_Enter);
            this.scintilla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.genericScintilla_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 717);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 23);
            this.panel1.TabIndex = 15;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MethodTreeView);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.scintilla1);
            this.splitContainer1.Size = new System.Drawing.Size(306, 474);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // scintilla1
            // 
            this.scintilla1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scintilla1.CaretLineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.scintilla1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla1.Location = new System.Drawing.Point(0, 0);
            this.scintilla1.Margins.Capacity = 0;
            this.scintilla1.Margins.Left = 0;
            this.scintilla1.Margins.Right = 0;
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.ScrollWidth = 100;
            this.scintilla1.Size = new System.Drawing.Size(306, 108);
            this.scintilla1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.splitContainer2.Location = new System.Drawing.Point(1, 1);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(844, 474);
            this.splitContainer2.SplitterDistance = 532;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 15;
            // 
            // findReplace1
            // 
            this.findReplace1._lastReplaceHighlight = false;
            this.findReplace1._lastReplaceLastLine = 0;
            this.findReplace1._lastReplaceMark = false;
            this.findReplace1.Scintilla = this.scintilla;
            // 
            // ScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "ScriptForm";
            this.TitleFont = new System.Drawing.Font("微软雅黑", 9F);
            this.TitleSize = new System.Drawing.Size(64, 17);
            this.Load += new System.EventHandler(this.ModForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.TreeView MethodTreeView;
        private Rex.UI.UIButton btn_Compile;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox tb_Compile;
        private ScintillaNET.Scintilla scintilla;
        private ScintillaNET.Scintilla scintilla1;
        private System.Windows.Forms.Panel panel1;
        private RexFind.FindReplace findReplace1;

        #endregion
    }
}