
using HalconDotNet;
using RexConst;
using RexForm;
using RexView;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using VisionCore;

namespace Plugin.SaveImage
{
    [Category("图像处理")]
    [DisplayName("图像保存")]
    [Serializable]
    public class SaveImageObj : ObjBase
    {
        public int ShowNo;
        /// <summary>图像链接</summary>
        public string mLinkImage = "数据链接";
        /// <summary>保存启用</summary>
        public bool mSaveEnable = true;
        /// <summary>保存图像文字</summary>
        public bool mSaveRoiTxt = true;
        /// <summary>保存离线图像</summary>
        public bool mSaveOffLine = true;
        /// <summary>存储路径</summary>
        public string mSavePath = @"D:\RexImage";
        /// <summary>存储格式</summary>
        public SaveType mSaveType = SaveType.jpg;
        /// <summary>文件名称</summary>
        public string mSaveName = "数据链接";
        /// <summary>保存天数</summary>
        public string mSaveDay = "10";
        /// <summary>自动添加日期</summary>
        public bool mAddTime = true;
        /// <summary>自动清理</summary>
        public bool mAutoRemov = true;
        /// <summary>自动归类</summary>
        public bool mAutoFileGroup = true;
        public override bool RunObj()
        {
            try
            {
                if (mAutoRemov)
                {
                    string day = IsNumber(mSaveDay) ? mSaveDay : Var.GetLinkData(mSloVar, mSaveDay).Split('|')[2];
                    RemovImage(int.Parse(day));
                }
                if ((mRImage = (RImage)Var.GetImage(mSloVar, mLinkImage)) == null)
                {
                    ModInfo.State = ModState.NoImage;
                    return false;
                }
                if (mSaveOffLine)
                {

                    string FileName = !mSaveName.Contains(":") ? mSaveName : Var.GetLinkData(mSloVar, mSaveName).Split('|')[2];
                    string FilePath = mSavePath + "\\" + DateTime.Now.ToString("yyyyMMd");
                    string TimePath = mAddTime ? DateTime.Now.ToString("HHmmss ") : "";
                    string SavePath = FilePath + "\\" + TimePath + FileName.Split('.')[0];
                    if (!Directory.Exists(FilePath))
                    {
                        Directory.CreateDirectory(FilePath); //在指定路径中创建所有目录。
                    }
                    switch (mSaveRoiTxt)
                    {
                        case false: //原图 
                            HOperatorSet.WriteImage(mRImage, mSaveType.ToString(), 0, SavePath);
                            break;
                        case true: //截图 
                            HWindow hv_window = ViewDic.GetView(mRImage.Screen).hControl.HalconWindow;
                            HOperatorSet.DumpWindow(hv_window, mSaveType.ToString(), SavePath);
                            break;
                    }
                    Log.Info( Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + mRImage.Name );
                }
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                Log.Info( Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + ex.Message );
                ModInfo.State = ModState.NG;
                return false;
            }
        }
        /// <summary>删除指定日期前的日志</summary>
        public void RemovImage(int dayNum)
        {
            Task.Run(() =>
            {
                try
                {
                    DateTime tempDate;
                    DirectoryInfo dir = new DirectoryInfo(mSavePath);
                    FileInfo[] fileInfo = dir.GetFiles();
                    foreach (FileInfo NextFile in fileInfo)// 遍历
                    {
                        tempDate = NextFile.LastWriteTime;
                        if ((DateTime.Now - tempDate).Days > dayNum)// Remov dayNum天前
                            File.Delete(NextFile.FullName);
                    }
                }
                catch (Exception ex)
                {
                    Log.Debug(ex.Message);
                }
            });
        }
        public override void RunForm(ObjBase baseMod)
        {
            new SaveImageForm((SaveImageObj)baseMod).ShowDialog();
        }
        public override void SetInfo() { }
    }
    public enum SaveType { jpg, png, bmp, tiff, gif, he }
}
