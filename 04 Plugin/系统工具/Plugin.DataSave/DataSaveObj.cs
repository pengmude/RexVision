using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using VisionCore;
namespace Plugin.DataSave
{
    [Category("系统工具")]
    [DisplayName("数据保存")]
    [Serializable]
    public class DataSaveObj : ObjBase
    {
        /// <summary>True</summary>
        public string mTrueStr = "OK";
        /// <summary>Fale</summary>
        public string mFaleStr = "NG";
        /// <summary>小数点</summary>
        public int mDic = 4;
        /// <summary>文件名称</summary>
        public string mFileName = "数据记录";
        /// <summary>文件路径</summary>
        public string mFilePath = @"D:\RexData";
        /// <summary>自动添加时间</summary>
        public bool mAutoAddTime = true;
        /// <summary>自动清理</summary>
        public bool mAutoRemov = true;
        /// <summary>保存天数</summary>
        public int mSaveDay = 10;
        /// <summary>保存信息</summary>
        public List<Save_Info> mSave_Info = new List<Save_Info>();
        public override bool RunObj()
        {
            if (mAutoRemov) { RemovCsv(mSaveDay); }
            try
            {
                string WriteRow = mAutoAddTime ? "时间,":"";
                string WriteCol = mAutoAddTime ? DateTime.Now.ToString("yyyy-MM-d hh:mm:ss:ms") +",": "";
                string FileName = !mFileName.Contains(":") ? mFileName : Var.GetLinkData(mSloVar, mFileName).Split('|')[2];
                foreach (var info in mSave_Info)
                {
                    WriteRow += info.Name + ",";
                    string str = Var.GetLinkData(mSloVar, info.Msg).Split('|')[2].Replace("True", mTrueStr).Replace("False", mFaleStr);
                    WriteCol += (IsNumber(str) ? double.Parse(str).ToString("F" + mDic) : str) + ",";
                }
                Csv.Save(mFilePath, FileName,WriteRow.Substring(0, WriteRow.Length - 1), WriteCol.Substring(0, WriteCol.Length - 1));
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + mFilePath + "\\" +FileName);
                ModInfo.State = ModState.OK;
                return true;
            }
            catch { ModInfo.State = ModState.NG; return false; }
        }
        /// <summary>删除指定日期前的日志</summary>
        public void RemovCsv(int dayNum)
        {
            Task.Run(() =>
            {
                try
                {
                    DateTime tempDate;
                    DirectoryInfo dir = new DirectoryInfo(mFilePath);
                    FileInfo[] fileInfo = dir.GetFiles();
                    foreach (FileInfo NextFile in fileInfo)// 遍历
                    {
                        tempDate = NextFile.LastWriteTime;
                        if ((DateTime.Now - tempDate).Days > dayNum)// 删除dayNum天前
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
            new DataSaveForm((DataSaveObj)baseMod).ShowDialog();
        }
        override public void SetInfo() { }
    }
}
