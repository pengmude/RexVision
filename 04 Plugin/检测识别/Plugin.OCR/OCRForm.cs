using HalconDotNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using VisionCore;

using System.Windows.Forms;

using RexConst;
using RexHelps;

namespace Plugin.OCR
{
    public partial class OCRForm: FormBase
    {
        private OCRObj mObj;
        /// <summary>
        /// 屏蔽区域
        /// </summary>
        private ROI m_ModelRegion;
        /// <summary>
        /// 搜索区域
        /// </summary>
        private ROI m_SearchRegion;
        private List<string> omcFilelist = new List<string>();
        /// <summary>
        /// 补正坐标系
        /// </summary>
        [NonSerialized]
        public Coord_Info Coord = new Coord_Info();
        public OCRForm(OCRObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void ModForm_Load(object sender, EventArgs e)
        {
            mObj = (OCRObj)ObjBase;
            ObjToForm();
        }
        public override void ObjToForm()
        {
            mObj = (OCRObj)ObjBase;
            string m_FlowID = "U" + mObj.ModInfo.Encode.ToString("D4");
            Text = mObj.ModInfo.Name;
            //uicb_Roi.Checked = mObj.ShowROI;
            //uicb_Area.Checked = mObj.ShowArea;
            //uicb_Result.Checked = mObj.ShowResult;
            uitb_Remark.Text = mObj.ModInfo.Remarks;

            InitCurrentCmbImgList();
            InitCmb_Position();
            InitOCR();
            UpDate();
            UpdateParam();
            base.ObjToForm();
        }

        public override void  FormToObj()
        {
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            btn_Run.Enabled = false;
            mObj.RunObj();
            ShowHRoi();
            btn_Run.Enabled = true;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
        }

        private void bt_Draw1_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.Enabled = false;
                string color = RColor.ToHexColor(bt_Color1.BackColor);
                if (cmb_Shape1.SelectedIndex == 0)
                {
                    double _rowBegin, _colBegin, _rowEnd, _colEnd;
                    mWindow.DrawRectangle1(color, out _rowBegin, out _colBegin, out _rowEnd, out _colEnd);
                    m_SearchRegion = new Rect_Info(_rowBegin, _colBegin, _rowEnd, _colEnd);
                }
                else if (cmb_Shape1.SelectedIndex == 1)
                {
                    double _row, _column, _phi, _length1, _length2;
                    mWindow.DrawRectangle2(color, out _row, out _column, out _phi, out _length1, out _length2);
                    m_SearchRegion = new Rect2_Info(_row, _column, _phi, _length1, _length2);
                }
                else if (cmb_Shape1.SelectedIndex == 1)
                {
                    double _row, _column, _radius;
                    mWindow.DrawCircle(color, out _row, out _column, out _radius);
                    m_SearchRegion = new Circle_Info(_row, _column, _radius);
                }
                else if (cmb_Shape1.SelectedIndex == 3)
                {
                    double _row, _column, _phi, _radius1, _radius2;
                    mWindow.DrawEllipse(color, out _row, out _column, out _phi, out _radius1, out _radius2);
                    m_SearchRegion = new Ellipse_Info(_row, _column, _phi, _radius1, _radius2);
                }
                m_SearchRegion.sColor = color;
                //搜索范围
                HRoi roi搜索范围 = new HRoi(mObj.ModInfo.Encode, mObj.ModInfo.Name, mObj.ModInfo.Remarks,HRoiType.搜索范围, "red", new HObject(m_SearchRegion.genXLD()));
                mObj.mRImage.ShowHRoi(roi搜索范围);
                ShowHRoi();
                tabControl1.Enabled = true;
            }
            catch { }
        }









        protected void UpDate()
        {
            try
            {
                cbxFileName.Text = mObj.m_OcrName;
                cbxOcrSelect.Text = mObj.m_polarity;

                UpDownMinContrast.Value = (decimal)mObj.m_minContrast;
                UpDownMinCharWidth.Value = (decimal)mObj.m_minCharWidth;
                UpDownMaxCharWidth.Value = (decimal)mObj.m_maxCharWidth;
                UpDownMinCharHeight.Value = (decimal)mObj.m_minCharHeight;
                UpDownMaxCharHeight.Value = (decimal)mObj.m_maxCharHeight;
                UpDownMinStrokeWidth.Value = (decimal)mObj.m_minStrokeWidth;
                UpDownMaxStrokeWidth.Value = (decimal)mObj.m_maxStrokeWidth;
                txtLineStructure.Text = mObj.m_textLineStructure;
                txtLineSeparators.Text = mObj.m_textLineSeparators;
                txtExpression.Text = mObj.m_expression;
                radioButtonDotPrint.Checked = mObj.m_isDotPrint.Contains("true");
                radioButtonFragments.Checked = mObj.m_isAddFragments.Contains("true");
            }
            catch { }
        }
        /// <summary>
        /// 更新参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void UpdateParam()
        {
            try { 
            //获取图像
            mObj.ModInfo.Remarks = uitb_Remark.Text.Trim();
            mObj.mImages = cmb_CurrentImg.Text;
            if ((mObj.mImages != null) && (mWindow.Image != null))
            {
                DataCell data = mObj.mSloVar.FirstOrDefault(c => c.mDataName == mObj.mImages);
                mWindow.Image = ((RImage)Var.GetImage(mObj.mSloVar, mObj.mImages));
            }
            //获取位置补正单元
            if (cmb_PositionUnitID.Text.Trim() == "无")
            {
                mObj.mHomMatID = -1;
                chkCorrect.Checked = false;
                chkCorrect.Enabled = false;
                Coord = new Coord_Info();
            }
            else
            {
                chkCorrect.Enabled = true;
                mObj.mHomMatID = int.Parse(cmb_PositionUnitID.Text.Substring(1));

                DataCell data = mObj.mSloVar.FirstOrDefault(c => c.mModIndex == (mObj.mHomMatID));
                Coord = ((List<Coord_Info>)data.mDataValue)[0];
            }
            //mObj.isCorrect = chkCorrect.Checked;
            mObj.RunObj();//再检测
            ObjToForm();
            ShowHRoi();
            }
            catch { }
        }
        /// <summary>
        /// 单击单元时更新窗口 显示当前图片和检测内容
        /// </summary>
        /// <param name="cell"></param>
        public void ShowHRoi()
        {
            try
            {
                OCRObj cell = mObj;
                if (cell.mRImage != null && cell.mRImage.IsInitialized())
                {
                    List<HRoi> roiList = cell.mRImage.mHRoi.Where(c => c.CellID == cell.ModInfo.Encode).ToList();
                    List<HText> roiTextList = cell.mRImage.mHText.Where(c => c.CellID == cell.ModInfo.Encode).ToList();
                    //dataGridView1.DataSource = roiList;
                    mWindow.Image = cell.mRImage;
                    // mWindow.DispImageFit();
                    int a = 0;
                    int b = 10;
                    foreach (HText roi in roiTextList)
                    {
                        if (roi != null && roi.roiType == HRoiType.文字显示)
                        {
                            HText roiText = (HText)roi;
                           ShowMsg.SetFont(mWindow.HWindowID, roiText.size, roiText.font, "false", "false");
                           ShowMsg.SetMsg(mWindow.HWindowID, roiText.text, "image", roiText.row, roiText.col, roiText.drawColor, "false");
                        }
                    }
                    foreach (HRoi roi in roiList)
                    {
                        b = b + 50;
                        if (roi != null && roi.hobject.IsInitialized())
                        {
                            if (roi.drawColor == "green")
                            {
                                //HalconControl.CHelper.SetFont(mWindow.HWindowID, 10, "mono", "false", "false");
                                //HalconControl.CHelper.SetMsg(mWindow.HWindowID, a++.ToString(), "image", 200, b, "red", "false");
                            }
                            mWindow.HWindowID.SetColor(roi.drawColor);
                            mWindow.HWindowID.DispObj(roi.hobject);
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        private void InitOCR()
        {
            #region 字库下拉框初始化
            string path = Environment.CurrentDirectory + "\\ocr";
            DirectoryInfo dir = new DirectoryInfo(path);

            if (dir.Exists)
            {
                FileInfo[] inf = dir.GetFiles();
                omcFilelist.Clear();
                foreach (var item in inf)
                {
                    if (item.Extension.Equals(".omc") || item.Extension.Equals(".occ"))
                    {
                        omcFilelist.Add(item.FullName);
                        cbxFileName.Items.Add(Path.GetFileNameWithoutExtension(item.FullName));
                    }
                }
            }
        }
        #endregion
        /// <summary>
        /// 初始化位置补正列表
        /// </summary>
        public void InitCmb_Position()
        {
            List<string> m_PositionList = new List<string>() { "无" };//直线单元ID列表
            IEnumerable<string> resultList = from datacell in mObj.mSloVar
                                             where datacell.mDataMode == DataMode.坐标系// ||datacell.mDataMode == DataMode.位置转换2D && datacell.mModIndex != HMeasSYS.U000
                                             select "U" + datacell.mModIndex.ToString("D4");
            m_PositionList.AddRange(resultList.ToList());
            cmb_PositionUnitID.DataSource = m_PositionList;
        }
        /// <summary>
        /// 初始化当前图像列表
        /// </summary>
        protected void InitCurrentCmbImgList()
        {
            Var.GetImage(ObjBase.mSloVar, out List<string> imgList);
            cmb_CurrentImg.DataSource = imgList;
        }
        private void cbxFileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFileName.SelectedIndex < 0)
            {
                return;
            }
            mObj.m_OcrPath = omcFilelist[cbxFileName.SelectedIndex];
        }
        private void ValueChanged控件值变更(object sender, EventArgs e)
        {
            try
            {
                NumericUpDown m_UpDown = (NumericUpDown)sender;
                switch (m_UpDown.Name)
                {
                    case "UpDownMinContrast":
                        mObj.m_minContrast = (double)UpDownMinContrast.Value;
                        break;
                    case "UpDownMinCharWidth":
                        mObj.m_minCharWidth = (int)UpDownMinCharWidth.Value;
                        break;
                    case "UpDownMaxCharWidth":
                        mObj.m_maxCharWidth = (int)UpDownMaxCharWidth.Value;
                        break;
                    case "UpDownMinCharHeight":
                        mObj.m_minCharHeight = (int)UpDownMinCharHeight.Value;
                        break;
                    case "UpDownMaxCharHeight":
                        mObj.m_maxCharHeight = (int)UpDownMaxCharHeight.Value;
                        break;
                    case "UpDownMinStrokeWidth":
                        mObj.m_minStrokeWidth = (int)UpDownMinStrokeWidth.Value;
                        break;
                    case "UpDownMaxStrokeWidth":
                        mObj.m_maxStrokeWidth = (int)UpDownMaxStrokeWidth.Value;
                        break;
                }
            }
            catch{ }

        }
    }
}
