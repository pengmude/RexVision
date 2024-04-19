using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using VisionCore;

namespace Plugin.Goto
{
    [Category("逻辑工具")]
    [DisplayName("跳转")]
    [Serializable]
    public class GotoObj : ObjBase
    {
        public string mGoStr = "数据链接";
        /// <summary>对比链接</summary>
        public string mFuncStr = "数据链接";
        /// <summary>对比条件</summary>
        public FuncType mFuncType = FuncType.等于;
        /// <summary>对比数据</summary>
        public string mFuncData = "true";
        public override bool RunObj()
        {
            string FuncStr = string.Empty;
            bool RetBool = false;
            try
            {
                switch (mFuncStr)
                {
                    case "":
                    case "数据链接":
                        Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + "判断条件为空,请检查!");
                        return false;
                    default:
                        if (mFuncStr.Contains("全局"))
                        {
                            FuncStr = Var.GetLinkData(mSysVar, mFuncStr).Split('|')[2];
                        }
                        else
                        {
                            FuncStr = Var.GetLinkData(mSloVar, mFuncStr).Split('|')[2];
                        }
                        break;
                }
                switch (mFuncType)
                {
                    case 0://等于
                        RetBool = FuncStr.ToLower() == mFuncData.ToLower();
                        break;
                    case (FuncType)1://不等于
                        RetBool = FuncStr.ToLower() != mFuncData.ToLower();
                        break;
                    case (FuncType)2://大于
                        RetBool = (double.Parse(FuncStr) > double.Parse(mFuncData));
                        break;
                    case (FuncType)3://大于等于
                        RetBool = (double.Parse(FuncStr) >= double.Parse(mFuncData));
                        break;
                    case (FuncType)4://小于
                        RetBool = (double.Parse(FuncStr) < double.Parse(mFuncData));
                        break;
                    case (FuncType)5://小于等于
                        RetBool = (double.Parse(FuncStr) <= double.Parse(mFuncData));
                        break;
                    case (FuncType)6://包含
                        RetBool = FuncStr.ToLower().Contains(mFuncData.ToLower());
                        break;
                    case (FuncType)7://不包含
                        RetBool = !FuncStr.ToLower().Contains(mFuncData.ToLower());
                        break;
                    default://等于
                        RetBool = FuncStr.ToLower() == mFuncData.ToLower();
                        break;
                }
                ModInfo.GoLable = mGoStr != "数据链接" ? mGoStr.Split(':')[0] : "None";
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + RetBool);
                ModInfo.State = ModState.OK;
                return ModInfo.Result = RetBool; ;
            }
            catch
            {
                return ModInfo.Result = false;
            }
        }
        public override void RunForm(ObjBase baseMod)
        {
            new GotoForm((GotoObj)baseMod).ShowDialog();
        }
        override public void SetInfo()
        {
        }
    }
}
