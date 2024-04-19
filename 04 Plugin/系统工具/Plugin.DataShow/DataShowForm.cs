using Rex.UI;
using RexConst;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.DataShow
{
    public partial class DataShowForm : FormBase
    {
        private DataShowObj mObj;
        public DataShowForm(DataShowObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void DataShowForm_Load(object sender, EventArgs e) { }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            ObjToForm();
            ShowHRoi();
        }
        public override void  FormToObj()
        {
            mObj.mImages = uilk_Image.Values.Text;
            mObj.mRImage = ((RImage)Var.GetImage(mObj.mSloVar, mObj.mImages));
            mObj.ModInfo.Remarks = uitb_Remark.Text.Trim();

            mObj.mMsgDic = (int)uidd_Dic.Value;
            mObj.mMsgSize = (int)uidd_Size.Value;
            mObj.mMsgOK = uitb_OK.TextStr;
            mObj.mMsgNG = uitb_NG.TextStr;
            ShowHRoi();
        }
        public override void ObjToForm()
        {
            try
            {
                uilk_Image.Values.Text = mObj.mImages;
                uidd_Dic.Value = mObj.mMsgDic;
                uidd_Size.Value = mObj.mMsgSize;
                uitb_OK.TextStr = mObj.mMsgOK;
                uitb_NG.TextStr = mObj.mMsgNG;
                int index = 0;
                dgv_File.Rows.Clear();
                foreach (Set_Info info in mObj.mShow_Info)
                {
                    dgv_File.Rows.Add();
                    dgv_File.Rows[index].Cells[0].Value = index;
                    dgv_File.Rows[index].Cells[1].Value = info.Msg;
                    ++index;
                }
            }
            catch (Exception ex)
            {
                Log.Error( mObj.ModInfo.Name + ex.Message );
            }
        }
        /// <summary>显示当前图片和检测内容</summary>
        public void ShowHRoi()
        {
            if (mObj.mRImage != null)
            {
                mWindowH.HobjectToHimage(mObj.mRImage);
                List<HRoi> roiList = mObj.mRImage.mHRoi.Where(c => c.CellID == mObj.ModInfo.Encode).ToList();
                List<HText> txtList = mObj.mRImage.mHText.Where(c => c.CellID == mObj.ModInfo.Encode).ToList();
                foreach (HRoi roi in roiList)
                {
                    if (roi.CellType.Contains(mObj.ModInfo.Plugin))
                    {
                        mWindowH.WindowH.DispHobject(roi.hobject, roi.drawColor);
                    }
                }
                mObj.mRImage.mHText.Clear();
                foreach (HText roi in txtList)
                {
                    if (roi.CellType.Contains(mObj.ModInfo.Plugin))
                    {
                        ShowTool.SetFont(mWindowH.hControl.HalconWindow, roi.size, roi.font, "false", "false");
                        ShowTool.SetMsg(mWindowH.hControl.HalconWindow, roi.text, "image", roi.row, roi.col, roi.drawColor, "false");
                    }
                }
            }
        }
        private void ShowSet(int index, string str)
        {
            DataSet mDataSet = new DataSet(mObj, index, str);
            mDataSet.ShowDialog();
            dgv_File.Rows[index].Cells[1].Value = mObj.mShow_Info[index].Msg;
        }
        private void dgv_File_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = mObj.index = dgv_File.CurrentRow.Index;
            string str = dgv_File.Rows[index].Cells[1].Value == null ? " " : dgv_File.Rows[index].Cells[1].Value.ToString();
            ShowSet(index, str);
        }
        private void uibt_Click(object sender, EventArgs e)
        {
            UIButton btn = sender as UIButton;
            switch (btn.Text)
            {
                case "添加":
                    dgv_Add(dgv_File.RowCount);
                    break;
                case "删除":
                    dgv_Remov();
                    break;
                case "修改":
                    ShowSet(dgv_File.CurrentRow.Index, dgv_File.Rows[dgv_File.CurrentRow.Index].Cells[1].Value.ToString());
                    break;
            }
        }
        private void dgv_Add(int index)
        {
            dgv_File.Rows.Add();
            mObj.mShow_Info.Add(new Set_Info());
            dgv_File.Rows[index].Cells[0].Value = index;
            dgv_File.Rows[index].Cells[1].Value = " ";
        }
        private void dgv_Remov()
        {
            int indexs = dgv_File.CurrentRow.Index;
            foreach (Set_Info info in mObj.mShow_Info)
            {
                if(info.Msg== dgv_File.Rows[indexs].Cells[1].Value.ToString())
                {
                    mObj.mShow_Info.Remove(info);
                }
            }
            indexs = 0;
            dgv_File.Rows.Clear();
            foreach (Set_Info info in mObj.mShow_Info)
            {
                dgv_File.Rows.Add();
                dgv_File.Rows[indexs].Cells[0].Value = indexs;
                dgv_File.Rows[indexs].Cells[1].Value = info.Msg;
                ++indexs;
            }
        }
        private void uilk_BtnAdd(object sender, EventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.Name, mObj.ModInfo.Name, VarType.IntVar, LinkDataForm.Script);
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                UISymbolButton UIBtn = (UISymbolButton)sender;
                if (UIBtn != null)
                {
                    switch (UIBtn.Parent.GetType().Name)
                    {
                        case "UILinkText":
                            UILinkText mUILinkText = (UILinkText)UIBtn.Parent;
                            mUILinkText.Values.Text = m_IntStr[0] + ":" + m_IntStr[1];
                            break;
                    }
                    FormToObj();
                    return;
                }
            }
        }
        private void uilk_BtnDec(object sender, EventArgs e)
        {
            UISymbolButton UIBtn = (UISymbolButton)sender;
            if (UIBtn != null)
            {
                switch (UIBtn.Parent.GetType().Name)
                {
                    case "UILinkData":
                        UILinkData mUILinkData = (UILinkData)UIBtn.Parent;
                        mUILinkData.Values.Text = "数据链接";
                        break;
                    case "UILinkText":
                        UILinkText mUILinkText = (UILinkText)UIBtn.Parent;
                        mUILinkText.Values.Text = "数据链接";
                        break;
                }
                return;
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
            ObjToForm();
            this.Close();
        }
    }
}
