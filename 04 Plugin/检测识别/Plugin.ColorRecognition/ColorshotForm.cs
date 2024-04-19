using RexConst;
using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;


using RexHelps;

namespace Plugin.Colorshot
{
    public partial class ColorshotForm: FormBase
    {
        private ColorshotObj mObj;
        public ColorshotForm(ColorshotObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void CorrectPositionModForm_Load(object sender, EventArgs e)
        {
            InitCurrentCmbImgList();
            try
            {
                cmb_Shape1.SelectedIndex = 0;
                cmb_Shape2.SelectedIndex = 0;
                com_SubPixel.SelectedIndex = 2;
                cmb_ModelType.SelectedIndex = 0;
                uicb_Roi.Checked = mObj.ShowROI;
                uicb_Area.Checked = mObj.ShowArea;
                uicb_Result.Checked = mObj.ShowResult;

                cmb_CurrentImg.Text = mObj.mImages;
                chk_disableAngle.Checked = mObj.disableAngle;
                cmb_ModelType.Text = mObj.m_ModelType.ToString();

                num_StartPhi.Value = (decimal)mObj.m_StartPhi;
                num_EndPhi.Value = (decimal)mObj.m_EndPhi;

                num_ScaleMin.Value = (decimal)mObj.m_ScaleMin;
                num_ScaleMax.Value = (decimal)mObj.m_ScaleMax;
                num_MinScore.Value = (decimal)mObj.m_MinScore;
                num_NumMatch.Value = (decimal)mObj.m_MatchNum;
                num_MaxOverlap.Value = (decimal)mObj.m_MaxOverlap;
                com_SubPixel.Text = mObj.m_SubPixel;
                num_NumLevels.Value = (decimal)mObj.m_NumLevels;
                num_Greediness.Value = Convert.ToDecimal((mObj).m_Greediness);
                //阵列信息
                double _area, X, Y;
                Gen.GetAreaCenter(mObj.m_ArrayRegionA.genRegion(), out _area, out Y, out X);
                textBox_AXY.Text = X.ToString("F1") + "," + Y.ToString("F1");
                Gen.GetAreaCenter(mObj.m_ArrayRegionB.genRegion(), out _area, out Y, out X);
                textBox_BXY.Text = X.ToString("F1") + "," + Y.ToString("F1");
                chk_array.Checked = mObj.m_cbarray;
                num_arrayRow.Value = mObj.m_arrayRow;
                num_arrayCol.Value = mObj.m_arrayCol;
                num_StepX.Value = (decimal)mObj.m_arrayStepX;
                num_StepY.Value = (decimal)mObj.m_arrayStepY;
                //初始化下拉列表
                cmb_ModelType.Text = (mObj).m_ModelType.ToString();
                cmb_CurrentImg.Text = (mObj).mImages;

                if (mObj.mImages != null)
                {
                    mWindow.Image = ((RImage)Var.GetImage(mObj.mSloVar, mObj.mImages));
                    mObj.mRImage = ((RImage)Var.GetImage(mObj.mSloVar, mObj.mImages));
                    mWindow.DispImageFit();
                }
                if ((mObj).m_ModelRegion != null)
                {
                    bt_Color1.BackColor = ColorTranslator.FromHtml(mObj.m_ModelRegion.sColor);
                }
                if ((mObj).m_SearchRegion != null)
                {
                    bt_Color2.BackColor = ColorTranslator.FromHtml(mObj.m_SearchRegion.sColor);
                }
                mObj.mRImage.mHRoi.Clear();
                //检测范围
                HRoi roi检测范围 = new HRoi(mObj.ModInfo.Encode, mObj.ModInfo.Name,mObj.ModInfo.Remarks, HRoiType.检测范围, "green", new HObject((mObj).m_ModelRegion.genXLD()));
                mObj.mRImage.ShowHRoi(roi检测范围);
                //搜索范围
                HRoi roi搜索范围 = new HRoi(mObj.ModInfo.Encode, mObj.ModInfo.Name,mObj.ModInfo.Remarks, HRoiType.搜索范围, "red", new HObject((mObj).m_SearchRegion.genXLD()));
                mObj.mRImage.ShowHRoi(roi搜索范围);

                ShowHRoi();
            }
            catch (Exception ex)
            {

            }

            mWindow.RePaint += new RexView.DelegateRePaint(ShowHRoi);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if ((mObj).m_ModelRegion == null || (mObj).m_SearchRegion == null)
            {
                Update();
                MessageBox.Show("请设置模板区域和搜索区域");
                btn_Run.Enabled = true;
                return;
            }
            this.Close();
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            try
            {
                Update();
                btn_Run.Enabled = false;
                if ((mObj).m_ModelRegion == null || (mObj).m_SearchRegion == null)
                {
                    MessageBox.Show("请设置模板区域和搜索区域");
                    btn_Run.Enabled = true;
                    return;
                }
                if (!mObj.m_Model.IsInitialized())
                {
                    MessageBox.Show("未生成模板");
                    btn_Run.Enabled = true;
                    return;
                }
                mObj.RunObj();
                ShowHRoi();
                btn_Run.Enabled = true;
            }
            catch { }

        }

        /// <summary>
        /// 初始化当前图像列表
        /// </summary>
        protected void InitCurrentCmbImgList()
        {
            Var.GetImage(ObjBase.mSloVar, out List<string> imgList);
            cmb_CurrentImg.DataSource = imgList;
        }
        /// <summary>
        /// 单击单元时更新窗口 显示当前图片和检测内容
        /// </summary>
        /// <param name="cell"></param>
        public void ShowHRoi()
        {
            try
            {
                ColorshotObj cell = mObj;
                if (cell.mRImage != null && cell.mRImage.IsInitialized())
                {
                    List<HRoi> roiList = cell.mRImage.mHRoi.Where(c => c.CellID == cell.ModInfo.Encode).ToList();

                    List<HText> roiTextList = cell.mRImage.mHText.Where(c => c.CellID == cell.ModInfo.Encode).ToList();

                    DataCell data = mObj.mSloVar.FirstOrDefault(c => c.mDataName == "outCoord");//搜索结果中心数租


                    Dictionary<int, string> dictionary = new Dictionary<int, string>();

                    Coord_Info mCoord_INFO = new Coord_Info();
                    mCoord_INFO = ((List<Coord_Info>)data.mDataValue)[0];
                    if (((List<Coord_Info>)data.mDataValue).Count > 1)
                    {
                        string[] s = new string[((List<Coord_Info>)data.mDataValue).Count];
                        for (int i = 0; i < ((List<Coord_Info>)data.mDataValue).Count; ++i)
                        {
                            mCoord_INFO = ((List<Coord_Info>)data.mDataValue)[i];
                            s[i] =mCoord_INFO.X.ToString("F4") + "," +  mCoord_INFO.Y.ToString("F4") + ","+ mCoord_INFO.Phi.ToString("F4");
                            dictionary.Add(i,s[i]);
                        }
                    }
                    dataGridView1.DataSource = dictionary.ToList();
                    mWindow.Image = cell.mRImage;
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
                        if (roi != null && roi.hobject.IsInitialized())
                        {
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
        private void bt_Color1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true; //是否显示ColorDialog有半部分
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)//确定事件响应
            {
                bt_Color1.BackColor = colorDialog.Color;
            }
        }
        private void bt_Draw1_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = false;
            mObj.mRImage.mHRoi.Clear();
            mWindow.Image = mObj.mRImage;
            string color = RColor.ToHexColor(bt_Color1.BackColor);
            if (cmb_Shape1.SelectedIndex == 0)
            {
                double _rowBegin, _colBegin, _rowEnd, _colEnd;
                mWindow.DrawRectangle1(color, out _rowBegin, out _colBegin, out _rowEnd, out _colEnd);
                mObj.m_ModelRegion = new Rect_Info(_rowBegin, _colBegin, _rowEnd, _colEnd);

                mObj.m_ModelRegionSpaceX = (_rowEnd - _rowBegin) / 2;
                mObj.m_ModelRegionSpaceY = (_colEnd - _colBegin) / 2;
            }
            else if (cmb_Shape1.SelectedIndex == 1)
            {
                double _row, _column, _phi, _length1, _length2;
                mWindow.DrawRectangle2(color, out _row, out _column, out _phi, out _length1, out _length2);
                mObj.m_ModelRegion = new Rect2_Info(_row, _column, _phi, _length1, _length2);
                mObj.m_ModelRegionSpaceX = _length1;
                mObj.m_ModelRegionSpaceY = _length2;
            }
            else if (cmb_Shape1.SelectedIndex == 2)
            {
                double _row, _column, _radius;
                mWindow.DrawCircle(color, out _row, out _column, out _radius);
                mObj.m_ModelRegion = new Circle_Info(_row, _column, _radius);
                mObj.m_ModelRegionSpaceX = _radius;
            }
            else if (cmb_Shape1.SelectedIndex == 3)
            {
                double _row, _column, _phi, _radius1, _radius2;
                mWindow.DrawEllipse(color, out _row, out _column, out _phi, out _radius1, out _radius2);
                mObj.m_ModelRegion = new Ellipse_Info(_row, _column, _phi, _radius1, _radius2);
            }
            else if (cmb_Shape1.SelectedIndex == 4)
            {

                HRegion hregion;
                if (mObj.m_ModelRegion != null)//需要判断是否为null 20171102
                {
                    hregion = mWindow.SetROI(mObj.m_ModelRegion.genRegion());
                }
                else
                {
                    hregion = mWindow.SetROI(new HRegion());
                }

                mObj.m_ModelRegion = new DrawRoi_Info(hregion);

            }

            mObj.m_ModelRegion.sColor = color;
            //检测范围
            HRoi roi检测范围 = new HRoi(mObj.ModInfo.Encode, mObj.ModInfo.Name,mObj.ModInfo.Remarks, HRoiType.检测范围, "green", new HObject(mObj.m_ModelRegion.genXLD()));
            mObj.mRImage.ShowHRoi(roi检测范围);
            ShowHRoi();
            tabControl1.Enabled = true;
        }
        private void bt_Paint_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.Enabled = false;
                HRegion hregion = mWindow.SetROI(mObj.m_ModelRegion.genRegion());
                mObj.m_ModelRegion = new DrawRoi_Info(hregion);
                mObj.m_DisableRegion = new DrawRoi_Info(hregion);
                tabControl1.Enabled = true;
            }
            catch { }
        }
        private void bt_Draw2_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = false;
            string color = RColor.ToHexColor(bt_Color2.BackColor);
            if (cmb_Shape2.SelectedIndex == 0)
            {
                double _rowBegin, _colBegin, _rowEnd, _colEnd;
                mWindow.DrawRectangle1(color, out _rowBegin, out _colBegin, out _rowEnd, out _colEnd);
                mObj.m_SearchRegion = new Rect_Info(_rowBegin, _colBegin, _rowEnd, _colEnd);
            }
            else if (cmb_Shape2.SelectedIndex == 1)
            {
                double _row, _column, _phi, _length1, _length2;
                mWindow.DrawRectangle2(color, out _row, out _column, out _phi, out _length1, out _length2);
                mObj.m_SearchRegion = new Rect2_Info(_row, _column, _phi, _length1, _length2);
            }
            else if (cmb_Shape2.SelectedIndex == 2)
            {
                double _row, _column, _radius;
                mWindow.DrawCircle(color, out _row, out _column, out _radius);
                mObj.m_SearchRegion = new Circle_Info(_row, _column, _radius);
            }
            else if (cmb_Shape2.SelectedIndex == 3)
            {
                double _row, _column, _phi, _radius1, _radius2;
                mWindow.DrawEllipse(color, out _row, out _column, out _phi, out _radius1, out _radius2);
                mObj.m_SearchRegion = new Ellipse_Info(_row, _column, _phi, _radius1, _radius2);
            }

            mObj.m_SearchRegion.sColor = color;
            //搜索范围
            HRoi roi搜索范围 = new HRoi(mObj.ModInfo.Encode, mObj.ModInfo.Name,mObj.ModInfo.Remarks, HRoiType.搜索范围, "red", new HObject(mObj.m_SearchRegion.genXLD()));
            mObj.mRImage.ShowHRoi(roi搜索范围);
            ShowHRoi();
            tabControl1.Enabled = true;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cmb_CurrentImg_SelectedIndexChanged(object sender, EventArgs e)
        {
            mObj.mImages = cmb_CurrentImg.Text;
            if (mObj.mImages != null)
            {
                // DataCell data = mObj.mSloVar.FirstOrDefault(c => c.mDataName == (mObj.mImages));

                mWindow.Image = ((RImage)Var.GetImage(mObj.mSloVar, mObj.mImages));
                mObj.mRImage = ((RImage)Var.GetImage(mObj.mSloVar, mObj.mImages));
                mWindow.DispImageFit();
            }
            else
            {
                MessageBox.Show("未选择图像");
            }
        }
        private void cmb_ModelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            mObj.m_ModelType = (ModelType)cmb_ModelType.SelectedIndex;
        }
        private void show_roi_CheckedChanged(object sender, EventArgs e)
        {
            mObj.ShowROI = uicb_Roi.Checked;
        }
        private void uicb_Area_CheckedChanged(object sender, EventArgs e)
        {
            mObj.ShowArea = uicb_Area.Checked;
        }
        private void uicb_Result_CheckedChanged(object sender, EventArgs e)
        {
            mObj.ShowResult = uicb_Result.Checked;
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            Update();
            if ((mObj).m_ModelType == ModelType.形状模板)
                (mObj).m_Model = new HShapeModel();
            else
                (mObj).m_Model = new HNCCModel();
            mObj.CreateModel();
        }
        private void Update()
        {
            (mObj).mImages = cmb_CurrentImg.Text;
            (mObj).m_ModelType = (ModelType)Enum.Parse(typeof(ModelType), cmb_ModelType.Text);
            (mObj).m_StartPhi = (double)num_StartPhi.Value;
            (mObj).m_EndPhi = (double)num_EndPhi.Value;
            (mObj).m_ScaleMin = (double)num_ScaleMin.Value;
            (mObj).m_ScaleMax = (double)num_ScaleMax.Value;
            (mObj).m_MinScore = (double)num_MinScore.Value;
            (mObj).m_MatchNum = (int)num_NumMatch.Value;
            (mObj).m_MaxOverlap = (double)num_MaxOverlap.Value;
            (mObj).m_SubPixel = com_SubPixel.Text;
            (mObj).m_NumLevels = (int)num_NumLevels.Value;
            (mObj).m_Greediness = (double)num_Greediness.Value;
            //阵列信息
            mObj.m_arrayRow = (int)num_arrayRow.Value;
            mObj.m_arrayCol = (int)num_arrayCol.Value;
        }

        private void chk_array_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (mObj.m_ArrayRegionA == null || mObj.m_ArrayRegionB == null)
                {
                    chk_array.Checked = false;
                    MessageBox.Show("阵列矩阵为空，请设置！");
                    return;
                }
                mObj.m_Rectangle2List = new List<Rect2_Info>();
                mObj.m_cbarray = chk_array.Checked;



                num_arrayRow.Value = (decimal)mObj.m_arrayRow;
                num_arrayCol.Value = (decimal)mObj.m_arrayCol;
                mObj.m_arrayRow = (int)num_arrayRow.Value;
                mObj.m_arrayCol = (int)num_arrayCol.Value;


                mObj.m_arrayStepX = (double)num_StepX.Value;
                mObj.m_arrayStepY = (double)num_StepY.Value;

                int rowNum = (int)num_arrayRow.Value;
                int colNum = (int)num_arrayCol.Value;
                double Length1 = (double)num_StepX.Value;
                double Length2 = (double)num_StepY.Value;
                double Phi = 0;
                double _area, X, Y;
                Gen.GetAreaCenter(mObj.m_ArrayRegionA.genRegion(), out _area, out Y, out X);
                textBox_AXY.Text = X.ToString("F1") + "," + Y.ToString("F1");
                double firstPointX = X;
                double firstPointY = Y;
                Gen.GetAreaCenter(mObj.m_ArrayRegionB.genRegion(), out _area, out Y, out X);
                textBox_BXY.Text = X.ToString("F1") + "," + Y.ToString("F1");
                double secondPointX = X;
                double secondPointY = Y;

                double xstep = 0;
                double ystep = 0;
                if (colNum > 1)
                {
                    xstep = (secondPointX - firstPointX) / (colNum - 1);
                }
                if (rowNum > 1)
                {
                    ystep = (secondPointY - firstPointY) / (rowNum - 1);
                }

                HRoi roi检测范围a = new HRoi();
                HRoi[] roi检测范围 = new HRoi[rowNum * colNum];
                for (int i = 0; i < rowNum; i++)
                {
                    for (int j = 0; j < colNum; j++)
                    {
                        {
                            Rect2_Info rect = new Rect2_Info();
                            rect.CenterX = firstPointX + (j * xstep);
                            rect.CenterY = firstPointY + (i * ystep);

                            rect.Length1 = Length1;
                            rect.Length2 = Length2;
                            rect.Phi = Phi;
                            mObj.m_Rectangle2List.Add(rect);
                        }
                    }
                }

                dataGridView_array.DataSource = new BindingList<Rect2_Info>(mObj.m_Rectangle2List);


                for (int i = 0; i < mObj.m_Rectangle2List.Count; i++)
                {
                    roi检测范围[i] = roi检测范围a;
                    roi检测范围[i] = new HRoi(mObj.ModInfo.Encode, mObj.ModInfo.Name, mObj.ModInfo.Remarks,HRoiType.检测范围, "green", new HObject(mObj.m_Rectangle2List[i].genXLD()), true);
                    mObj.mRImage.ShowHRoi(roi检测范围[i]);
                }
            }
            catch { }
        }
        private void bt_Draw0_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = false;
            string color = RColor.ToHexColor(bt_Color1.BackColor);
            if (cmb_Shape1.SelectedIndex == 0)
            {
                double _rowBegin, _colBegin, _rowEnd, _colEnd;
                mWindow.DrawRectangle1(color, out _rowBegin, out _colBegin, out _rowEnd, out _colEnd);
                mObj.m_ArrayRegionA = new Rect_Info(_rowBegin, _colBegin, _rowEnd, _colEnd);

                mObj.m_ArrayRegionSpaceX = (_rowEnd - _rowBegin) / 2;
                mObj.m_ArrayRegionSpaceY = (_colEnd - _colBegin) / 2;
            }
            else if (cmb_Shape1.SelectedIndex == 1)
            {
                double _row, _column, _phi, _length1, _length2;
                mWindow.DrawRectangle2(color, out _row, out _column, out _phi, out _length1, out _length2);
                mObj.m_ArrayRegionA = new Rect2_Info(_row, _column, _phi, _length1, _length2);
                mObj.m_ArrayRegionSpaceX = _length1;
                mObj.m_ArrayRegionSpaceY = _length2;
            }
            else if (cmb_Shape1.SelectedIndex == 2)
            {
                double _row, _column, _radius;
                mWindow.DrawCircle(color, out _row, out _column, out _radius);
                mObj.m_ArrayRegionA = new Circle_Info(_row, _column, _radius);
                mObj.m_ArrayRegionSpaceX = _radius;
            }
            else if (cmb_Shape1.SelectedIndex == 3)
            {
                double _row, _column, _phi, _radius1, _radius2;
                mWindow.DrawEllipse(color, out _row, out _column, out _phi, out _radius1, out _radius2);
                mObj.m_ArrayRegionA = new Ellipse_Info(_row, _column, _phi, _radius1, _radius2);
            }
            else if (cmb_Shape1.SelectedIndex == 4)
            {

                HRegion hregion;
                if (mObj.m_ArrayRegionA != null)//需要判断是否为null 20171102
                {
                    hregion = mWindow.SetROI(mObj.m_ArrayRegionA.genRegion());
                }
                else
                {
                    hregion = mWindow.SetROI(new HRegion());
                }

                mObj.m_ArrayRegionA = new DrawRoi_Info(hregion);

            }

            mObj.m_ArrayRegionA.sColor = color;
            //检测范围
            HRoi roi检测范围 = new HRoi(mObj.ModInfo.Encode, mObj.ModInfo.Name,mObj.ModInfo.Remarks, HRoiType.检测范围, "green", new HObject(mObj.m_ArrayRegionA.genXLD()));
            mObj.mRImage.ShowHRoi(roi检测范围);
            ShowHRoi();
            tabControl1.Enabled = true;
        }
        private void bt_DrawB_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = false;
            string color = RColor.ToHexColor(bt_Color1.BackColor);
            if (cmb_Shape1.SelectedIndex == 0)
            {
                double _rowBegin, _colBegin, _rowEnd, _colEnd;
                mWindow.DrawRectangle1(color, out _rowBegin, out _colBegin, out _rowEnd, out _colEnd);
                mObj.m_ArrayRegionB = new Rect_Info(_rowBegin, _colBegin, _rowEnd, _colEnd);

                mObj.m_ArrayRegionSpaceX = (_rowEnd - _rowBegin) / 2;
                mObj.m_ArrayRegionSpaceY = (_colEnd - _colBegin) / 2;
            }
            else if (cmb_Shape1.SelectedIndex == 1)
            {
                double _row, _column, _phi, _length1, _length2;
                mWindow.DrawRectangle2(color, out _row, out _column, out _phi, out _length1, out _length2);
                mObj.m_ArrayRegionB = new Rect2_Info(_row, _column, _phi, _length1, _length2);
                mObj.m_ArrayRegionSpaceX = _length1;
                mObj.m_ArrayRegionSpaceY = _length2;
            }
            else if (cmb_Shape1.SelectedIndex == 2)
            {
                double _row, _column, _radius;
                mWindow.DrawCircle(color, out _row, out _column, out _radius);
                mObj.m_ArrayRegionB = new Circle_Info(_row, _column, _radius);
                mObj.m_ArrayRegionSpaceX = _radius;
            }
            else if (cmb_Shape1.SelectedIndex == 3)
            {
                double _row, _column, _phi, _radius1, _radius2;
                mWindow.DrawEllipse(color, out _row, out _column, out _phi, out _radius1, out _radius2);
                mObj.m_ArrayRegionB = new Ellipse_Info(_row, _column, _phi, _radius1, _radius2);
            }
            else if (cmb_Shape1.SelectedIndex == 4)
            {

                HRegion hregion;
                if (mObj.m_ArrayRegionB != null)//需要判断是否为null 20171102
                {
                    hregion = mWindow.SetROI(mObj.m_ArrayRegionA.genRegion());
                }
                else
                {
                    hregion = mWindow.SetROI(new HRegion());
                }

                mObj.m_ArrayRegionB = new DrawRoi_Info(hregion);

            }

            mObj.m_ArrayRegionA.sColor = color;
            //检测范围
            HRoi roi检测范围 = new HRoi(mObj.ModInfo.Encode, mObj.ModInfo.Name,mObj.ModInfo.Remarks, HRoiType.检测范围, "green", new HObject(mObj.m_ArrayRegionB.genXLD()));
            mObj.mRImage.ShowHRoi(roi检测范围);
            ShowHRoi();
            tabControl1.Enabled = true;
        }
    }
}

