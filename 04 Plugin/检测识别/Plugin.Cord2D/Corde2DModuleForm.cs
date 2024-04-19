using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VisionCore;
using HalconDotNet;


using RexConst;

namespace Plugin.Corde2D
{
    public partial class Corde2DModForm: FormBase
    {

        private Corde2DModObj mObj;
        protected Meas_Info mMeasInfo = new Meas_Info();
        [NonSerialized]
        protected HRegion disableRegion = new HRegion();//屏蔽区域 magical 20171028
        [NonSerialized]
        protected HRegion tempDisableRegion = new HRegion();
        /// <summary>
        /// 补正坐标系
        /// </summary>
        [NonSerialized]
        public Coord_Info Coord = new Coord_Info();
        public Corde2DModForm(Corde2DModObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void ModForm_Load(object sender, EventArgs e)
        {
            if (ObjBase == null) return;
            //com_CordNum.SelectedIndex = 0;
            uicb_Roi.Checked = mObj.ShowROI;
            uicb_Area.Checked = mObj.ShowArea;
            uicb_Result.Checked = mObj.ShowResult;

            FormToObj();
            UpdateParam(sender, e);

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            mObj.RunObj();
            ShowHRoi();
        }

        private void bt_Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true; //是否显示ColorDialog有半部分
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)//确定事件响应
            {
                Color color_from = colorDialog.Color;

                string m_DrawColor = color_from.ToArgb().ToString("X02");
                m_DrawColor = m_DrawColor.Substring(2);
                m_DrawColor = m_DrawColor.Insert(0, "#");
                mObj.m_drawColor = m_DrawColor;
            }
        }
        /// <summary>
        /// 读取文本框中的Metrology信息
        /// </summary>
        private void setMetrologInfo()
        {
            try
            {

                mMeasInfo.ParamName = new HTuple();
                mMeasInfo.ParamName.Append("measure_transition");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 更新参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void UpdateParam(object sender, EventArgs e)
        {
            setMetrologInfo();
            mObj.ModInfo.Remarks = uitb_Remark.Text.Trim();
            mObj.mMeasInfo = this.mMeasInfo;
            mObj.mImages = cmb_CurrentImg.Text;
            if ((mObj.mImages != null) && (mWindow.Image != null))
            {
                // string[] name = mObj.mImages.Split(':');
                DataCell data = mObj.mSloVar.FirstOrDefault(c => c.mDataName == mObj.mImages);
                //  mObj.mSloVar.
                mWindow.Image = ((RImage)Var.GetImage(mObj.mSloVar, mObj. mImages));
            }
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
            mObj.isCorrect = chkCorrect.Checked;
            //mObj.RunObj();//再检测
            //FormToData();
            // ShowHRoi();
            //PaintMetrology();
        }
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

        private void bt_Paint_Click(object sender, EventArgs e)
        {

            if (disableRegion == null || !disableRegion.IsInitialized())
            {
                disableRegion = new HRegion();
            }
            disableRegion = mWindow.SetROI(disableRegion);
            if (disableRegion != null && disableRegion.IsInitialized())
            {
                double row, col, x, y, phi;
                //disableRegion.EllipticAxis(out x, out phi);
                disableRegion.AreaCenter(out row, out col);
                Aff.Points2WorldPlane(mObj.mRImage, row, col, out x, out y);
                HHomMat2D hom = Aff.RstHomMat2D(Coord.X, Coord.Y, -Coord.Phi);
                x = hom.AffineTransPoint2d(x, y, out y);
                mObj.RegCoor = new Coord_Info(y, x, Coord.Phi);
                mObj.disableRegion = disableRegion;

            }
        }

        private void bt_draw_Click(object sender, EventArgs e)
        {
            Circle_Info m_DrawCircle = new Circle_Info();
            mWindow.DrawCircle(mObj.m_drawColor, out m_DrawCircle.CenterY, out m_DrawCircle.CenterX, out m_DrawCircle.Radius);
            //像素坐标转世界坐标
            m_DrawCircle = Aff.Circle2WorldPlane(mObj.mRImage, m_DrawCircle);
            ////世界坐标转当前相对坐标
            HHomMat2D hom = Aff.RstHomMat2D(Coord.X, Coord.Y, -Coord.Phi);
            m_DrawCircle.CenterX = hom.AffineTransPoint2d(m_DrawCircle.CenterX, m_DrawCircle.CenterY, out m_DrawCircle.CenterY);
        }

        /// <summary>
        /// 单击单元时更新窗口 显示当前图片和检测内容
        /// </summary>
        /// <param name="cell"></param>
        public void ShowHRoi()
        {
            try
            {
                Corde2DModObj cell = mObj;

                if (cell.mRImage != null && cell.mRImage.IsInitialized())
                {
                    List<HText> roiTeatList = cell.mRImage.mHText.Where(c => c.CellID == cell.ModInfo.Encode).ToList();
                    List<HRoi> roiList = cell.mRImage.mHRoi.Where(c => c.CellID == cell.ModInfo.Encode).ToList();
                    //roiTeatList[0].hobject = roiList[0].hobject;
                    mWindow.Image = cell.mRImage;
                    foreach (HText roi in roiTeatList)
                    {
                        if (roi != null && roi.roiType == HRoiType.文字显示)
                        {
                            HText roiText = (HText)roi;
                           ShowMsg.SetFont(mWindow.HWindowID, roiText.size, roiText.font, "true", "false");
                           ShowMsg.SetMsg(mWindow.HWindowID, roiText.text, "image", roiText.row, roiText.col, roiText.drawColor, "true");
                        }
                    }
                    foreach (HRoi roi in roiList)
                    {
                        if (roi != null && roi.roiType == HRoiType.文字显示)
                        {
                            HText roiText = (HText)roi;
                           ShowMsg.SetFont(mWindow.HWindowID, roiText.size, roiText.font, "false", "false");
                           ShowMsg.SetMsg(mWindow.HWindowID, roiText.text, "image", roiText.row, roiText.col, roiText.drawColor, "false");
                        }
                        else
                        {

                            if (roi != null && roi.hobject != null)
                            {
                                mWindow.HWindowID.SetColor(roi.drawColor);
                                mWindow.HWindowID.DispObj(roi.hobject);
                            }
                        }
                    }

                }
            }
            catch { }
        }

        public override void  FormToObj()
        {
            InitCurrentCmbImgList();
            InitCmb_Position();
            string m_FlowID = "U" + mObj.ModInfo.Encode.ToString("D4");
            this.Text = mObj.ModInfo.Name;
            uitb_Remark.Text = mObj.ModInfo.Remarks;
            ///初始化文本框
            
          
            cmbFindMode.DataSource = Enum.GetNames(typeof(Corde2DModObj.FindMode));
            cmbFindMode.SelectedIndex =(int) mObj.m_FindMode; //与上面代码是相同的结果
            com_CordNum.SelectedIndex = (int)mObj.m_CordeNum;
            //条码类型
            int _Num = 0;
            switch(mObj.m_WandCodeType)
            {
                case "auto":
                    _Num = 0;
                    break;
             case "QR Code":
                    _Num = 1;
                    break;
             case "Data Matrix ECC 200":
                    _Num = 2;
                    break;
             case "Aztec Code":
                    _Num = 3;
                    break;
             case "GS1 Aztec Code":
                    _Num = 4;
                    break;
             case "GS1 DataMatrix":
                    _Num = 5;
                    break;
             case "GS1 QR Code":
                    _Num = 6;
                    break;
             case "Micro QR Code":
                    _Num = 7;
                    break;
             case "PDF417":
                    _Num = 8;
                    break;
            }
            cbxCodeTypeWant.SelectedIndex = _Num;

            cmb_PositionUnitID.SelectedIndex = 0;
            string temp_color = mObj.m_drawColor.Substring(1, 2);
            int r = Convert.ToInt32(temp_color, 16);
            temp_color = mObj.m_drawColor.Substring(3, 2);
            int g = Convert.ToInt32(temp_color, 16);
            temp_color = mObj.m_drawColor.Substring(5, 2);
            int b = Convert.ToInt32(temp_color, 16);

            this.cmb_CurrentImg.SelectedIndexChanged += new System.EventHandler(this.UpdateParam);
            this.cmb_PositionUnitID.SelectedIndexChanged += new System.EventHandler(this.UpdateParam);

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
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

        private void cmbFindMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            mObj.m_FindMode = (Corde2DModObj.FindMode)Enum.Parse(typeof(Corde2DModObj.FindMode), cmbFindMode.SelectedItem.ToString(), false);
        }

        private void btnModelCreate_Click(object sender, EventArgs e)
        {
            if (cbxCodeTypeWant.SelectedIndex == 0)
            {
                MessageBox.Show("生成编码模板时编码格式不能选定auto", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                mObj.TrainDataCodeMode();
                if (!mObj.DataCode2DDic.ContainsKey(mObj.m_WandCodeType))
                {
                    mObj.DataCode2DDic.Add(mObj.m_WandCodeType, mObj.DataCode2d);
                }
                else
                {
                    if (MessageBox.Show($"编码格式为{mObj.m_WandCodeType}的编码模板已存在，是否替换？",
                        "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        mObj.DataCode2DDic[mObj.m_WandCodeType] = mObj.DataCode2d;
                    }
                    else
                        return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"生成编码格式为{mObj.m_WandCodeType}的编码模板失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show($"编码格式为{mObj.m_WandCodeType}的编码模板生成成功", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            txtModelKeyName.Text = mObj.m_WandCodeType + " Model";
            txtModelKeyName.BackColor = System.Drawing.SystemColors.ControlLight;
        }

        private void cbxCodeTypeWant_SelectedIndexChanged(object sender, EventArgs e)
        {


            mObj.m_WandCodeType = cbxCodeTypeWant.Text;
            if (mObj.DataCode2DDic.ContainsKey(mObj.m_WandCodeType))
            {
                mObj.DataCode2d = mObj.DataCode2DDic[mObj.m_WandCodeType];
                txtModelKeyName.Text = mObj.m_WandCodeType + " Model";
                txtModelKeyName.BackColor = SystemColors.ControlLight;
            }
            else
            {
                txtModelKeyName.Text = "";
                txtModelKeyName.BackColor =Color.Red;
            }
        }

        private void com_CordNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            mObj.m_CordeNum = com_CordNum.SelectedIndex+1;
        }
    }
}
