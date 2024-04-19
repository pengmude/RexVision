using System;
using System.Linq;
using System.Windows.Forms;
using VisionCore;
using System.IO;
using Ookii.Dialogs.WinForms;
using System.Collections.Generic;
using RexConst;
using Rex.UI;
using RexView;
using System.Drawing;
using HalconDotNet;
using RexHelps;

namespace Plugin.Camera
{
    public partial class CameraForm : FormBase
    {
        CameraObj mObj;
        public CameraForm(CameraObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void ModForm_Load(object sender, EventArgs e)
        {
            InitPanle((int)mObj.mImageSource);
            btn_Run_Click(null, null);
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
            ObjToForm();
            ShowHRoi();
            Close();
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            ObjToForm();
            ShowHRoi();
        }
        public override void FormToObj()
        {
            mObj.mScreen = ui_SelectScreen.SelectedIndex;
            mObj.mCamerasBase = mObj.mCamera.FirstOrDefault(c => c.mCameraNo == ui_SelectCamera.Text);
            mObj.mCameraNo = ui_SelectCamera.Text;
            mObj.mForRead = ui_ForRead.Checked;
            mObj.mFilePath = uiLink_FilePath.Values.Text;
            mObj.mImagePath = uiLink_ImagePath.Values.Text;
            InitFile(mObj.mFilePath);
            mObj.mLikeMeasCal = ui_LikeMeasCal.Values.Text != "数据链接" ? ui_LikeMeasCal.Values.Text : "数据链接";
            mObj.mLikeDistCal = ui_LikeDistCal.Values.Text != "数据链接" ? ui_LikeDistCal.Values.Text : "数据链接";
            mObj.mImageSource = (ImageSource)uirb_ImageSource.SelectedIndex;
            mObj.mHText = new HText(ColorTranslator.ToHtml(uitx_Color.Value), uitx_Prefix.Text, "", uitx_X.Value, uitx_Y.Value, (int)uitx_Size.Value);
            mObj.mShowHText = uicb_ShowText.Checked;
        }
        public override void ObjToForm()
        {
            ui_SelectScreen.SelectedIndex = mObj.mScreen;
            ui_SelectCamera.DataSource = mObj.mCamera.ToList();
            ui_SelectCamera.DisplayMember = "mCameraNo";
            ui_SelectCamera.Text = mObj.mCameraNo;
            ui_ForRead.Checked = mObj.mForRead;
            ui_LikeDistCal.Values.Text = mObj.mLikeDistCal;
            ui_LikeMeasCal.Values.Text = mObj.mLikeMeasCal;
            uiLink_FilePath.Values.Text = mObj.mFilePath;
            uiLink_ImagePath.Values.Text = mObj.mImagePath;
            if (mObj.mFileInfo != null)
            {
                dgv_File.Rows.Clear();
                for (int i = 0; i < mObj.mFileInfo.Count; ++i)
                {
                    if (dgv_File.RowCount <= i)
                    {
                        dgv_File.Rows.Add();
                    }
                    dgv_File.Rows[i].Cells[0].Value = i;
                    dgv_File.Rows[i].Cells[1].Value = mObj.mFileInfo[i];
                }
                if (dgv_File.RowCount > 0)
                {
                    dgv_File.FirstDisplayedScrollingRowIndex = mObj.index < 1 ? 0 : mObj.index - 1;
                }
            }
            uirb_ImageSource.SelectedIndex = (int)mObj.mImageSource;
            uitx_X.Value = mObj.mHText.row;
            uitx_Y.Value = mObj.mHText.col;
            uitx_Size.Value = mObj.mHText.size;
            uitx_Prefix.Text = mObj.mHText.text;
            uitx_Color.Value = ColorTranslator.FromHtml(mObj.mHText.drawColor);
            uicb_ShowText.Checked = mObj.mShowHText;
        }
        private void ui_SelectCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ui_SelectCamera.SelectedIndex < 0) { return; }
            mObj.mCamerasBase = mObj.mCamera.FirstOrDefault(c => c.mCameraNo == ui_SelectCamera.Text);
        }
        private void dgv_File_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mObj.index = dgv_File.CurrentRow.Index;
            btn_Run_Click(null, null);
        }
        private void ui_LikeMeasCal_BtnAdd(object sender, EventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.Name, mObj.ModInfo.Name, VarType.IntVar, LinkDataForm.Script);
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');;
                UISymbolButton UIBtn = (UISymbolButton)sender;
                UILinkText mUILinkData = (UILinkText)UIBtn.Parent;
                if (UIBtn != null & m_IntStr.Length > 1)
                {
                    switch (UIBtn.Parent.Name)
                    {
                        case "ui_LikeDistCal":
                            mUILinkData.Values.Text = m_IntStr[0] + ":" + m_IntStr[1];
                            break;
                        case "ui_LikeMeasCal":
                            mUILinkData.Values.Text = m_IntStr[0] + ":" + m_IntStr[1] + ":" + m_IntStr[2];
                            break;
                    }
                }
            }
        }
        private void ui_LikeMeasCal_BtnDec(object sender, EventArgs e)
        {
            UISymbolButton UIBtn = (UISymbolButton)sender;
            UILinkText mUILinkData = (UILinkText)UIBtn.Parent;
            if (UIBtn != null)
            {
                switch (UIBtn.Parent.Name)
                {
                    case "ui_LikeDistCal":
                        mUILinkData.Values.Text = "数据链接";
                        break;
                    case "ui_LikeMeasCal":
                        mUILinkData.Values.Text = "数据链接";
                        break;
                }
            }
        }
        /// <summary>显示当前图片内容</summary>
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

        private void uirb_ImageSource_ValueChanged(object sender, int index, string text)
        {
            InitPanle(uirb_ImageSource.SelectedIndex);
        }
        private void InitPanle(int index)
        {
            switch (index)
            {
                case 0:
                    pl_Path.Visible = true;
                    pl_File.Visible = false;
                    break;
                case 1:
                    pl_Path.Visible = false;
                    pl_File.Visible = true;
                    break;
                case 2:
                    pl_Path.Visible = false;
                    pl_File.Visible = false;
                    break;
            }
        }

        private void ui_LikeFile_BtnAdd(object sender, EventArgs e)
        {

            VistaFolderBrowserDialog mFolder = new VistaFolderBrowserDialog();
            if (mFolder.ShowDialog() == DialogResult.OK)
            {
                uiLink_FilePath.Values.Text = mFolder.SelectedPath;
                InitFile(mFolder.SelectedPath);
            }
            mObj.index = 0;
        }
        private void uiLink_ImagePath_BtnAdd(object sender, EventArgs e)
        {
            if (OpenImage.ShowDialog() == DialogResult.OK)
                uiLink_ImagePath.Values.Text = OpenImage.FileName;
            mObj.index = 0;
        }
        private void OpenImage_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        private void InitFile(string path)
        {
            if (Directory.Exists(path))
            {

                var filess = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".jpg") || s.EndsWith(".gif") || s.EndsWith(".png") || s.EndsWith(".bmp") || s.EndsWith(".jpg") || s.EndsWith(".he") || s.EndsWith(".tiff"));
                mObj.mFileInfo = filess.ToList();
                for (int i = 0; i < mObj.mFileInfo.Count; ++i)
                {
                    dgv_File.Rows.Add();
                    dgv_File.Rows[i].Cells[0].Value = i;
                    dgv_File.Rows[i].Cells[1].Value = mObj.mFileInfo[i];
                }
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
