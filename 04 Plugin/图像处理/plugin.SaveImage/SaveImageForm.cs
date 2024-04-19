using Ookii.Dialogs.WinForms;
using Rex.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.SaveImage
{
    public partial class SaveImageForm : FormBase
    {
        private SaveImageObj mObj;
        public SaveImageForm(SaveImageObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void DelayModForm_Load(object sender, EventArgs e) { }
        public override void FormToObj()
        {
            mObj.mLinkImage = uiLink_Image.Values.Text;
            mObj.mSaveEnable = uicb_SaveEnable.Checked;
            mObj.mSaveOffLine = uicb_SaveOffLine.Checked;
            mObj.mSaveRoiTxt = uicb_SaveRoiTxt.Checked;
            mObj.mSavePath = uiLink_FilePath.Values.Text;
            mObj.mSaveType = (SaveType)Enum.Parse(typeof(SaveType), uicb_SaveType.Text);
            mObj.mSaveName = uiLink_SaveName.Values.Text;
            mObj.mSaveDay = uiLink_SaveDay.Values.Text;
            mObj.mAddTime = uicb_AddTime.Checked;
            mObj.mAutoRemov = uicb_AutoRemov.Checked;
            mObj.mAutoFileGroup = uicb_AutoFileGroup.Checked;

        }
        public override void ObjToForm()
        {
            uiLink_Image.Values.Text = mObj.mLinkImage;
            uicb_SaveEnable.Checked = mObj.mSaveEnable;
            uicb_SaveOffLine.Checked = mObj.mSaveOffLine;
            uicb_SaveRoiTxt.Checked = mObj.mSaveRoiTxt;
            uiLink_FilePath.Values.Text = mObj.mSavePath;
            uicb_SaveType.Text = mObj.mSaveType.ToString();
            uiLink_SaveName.Values.Text = mObj.mSaveName;
            uiLink_SaveDay.Values.Text = mObj.mSaveDay;
            uicb_AddTime.Checked = mObj.mAddTime;
            uicb_AutoRemov.Checked = mObj.mAutoRemov;
            uicb_AutoFileGroup.Checked = mObj.mAutoFileGroup;
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            ObjToForm();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void uiLink_BtnAdd(object sender, EventArgs e)
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
                    default:
                        UILinkText mUILinkTexts = (UILinkText)UIBtn.Parent;
                        mUILinkTexts.Values.Text = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                }
                FormToObj();
                return;
            }
        }
        }
        private void uiLink_BtnDec(object sender, EventArgs e)
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
        private void uiLink_SavePath_BtnAdd(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog mFolder = new VistaFolderBrowserDialog();
            if (mFolder.ShowDialog() == DialogResult.OK)
            {
                uiLink_FilePath.Values.Text = mFolder.SelectedPath;
                InitFile(mFolder.SelectedPath);
            }
        }
        private void InitFile(string path)
        {
            var filess = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Where
         (s => s.EndsWith(".jpg") || s.EndsWith(".gif") || s.EndsWith(".png") || s.EndsWith(".bmp") || s.EndsWith(".jpg") || s.EndsWith(".he") || s.EndsWith(".tiff"));
        }
    }
}
