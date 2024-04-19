using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using VisionCore;

namespace Plugin.IF
{
    [Category("逻辑工具")]
    [DisplayName("如果")]
    [Serializable]
    public class IFObj : ObjBase
    {
        /// <summary>对比链接</summary>
        public string mFuncStr1 = "数据链接";
        /// <summary>对比链接</summary>
        public string mFuncStr2 = "数据链接";
        /// <summary>对比条件</summary>
        public FuncType mFuncType1 = FuncType.等于;
        /// <summary>对比条件</summary>
        public FuncType mFuncType2 = FuncType.等于;
        /// <summary>对比数据</summary>
        public string mFuncData1 = "true";
        /// <summary>对比数据</summary>
        public string mFuncData2 = "true";
        public override bool RunObj()
        {
            string FuncStr = string.Empty;
            bool RetBool = false;
            bool RetBool1 = false;
            bool RetBool2 = false;
            try
            {
                switch (mFuncStr1)
                {
                    case "":
                    case "数据链接":
                        Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + "判断条件为空,请检查!");
                        return false;
                    default:
                        if (mFuncStr1.Contains("全局"))
                        {
                            FuncStr = Var.GetLinkData(mSysVar, mFuncStr1).Split('|')[2];
                        }
                        else
                        {
                            FuncStr = Var.GetLinkData(mSloVar, mFuncStr1).Split('|')[2];
                        }
                        break;
                }
                switch (mFuncType1)
                {
                    case 0://等于
                        RetBool1 = FuncStr.ToLower() == mFuncData1.ToLower();
                        break;
                    case (FuncType)1://不等于
                        RetBool1 = FuncStr.ToLower() != mFuncData1.ToLower();
                        break;
                    case (FuncType)2://大于
                        RetBool1 = (double.Parse(FuncStr) > double.Parse(mFuncData1));
                        break;
                    case (FuncType)3://大于等于
                        RetBool1 = (double.Parse(FuncStr) >= double.Parse(mFuncData1));
                        break;
                    case (FuncType)4://小于
                        RetBool1 = (double.Parse(FuncStr) < double.Parse(mFuncData1));
                        break;
                    case (FuncType)5://小于等于
                        RetBool1 = (double.Parse(FuncStr) <= double.Parse(mFuncData1));
                        break;
                    case (FuncType)6://包含
                        RetBool1 = FuncStr.ToLower().Contains(mFuncData1.ToLower());
                        break;
                    case (FuncType)7://不包含
                        RetBool1 = !FuncStr.ToLower().Contains(mFuncData1.ToLower());
                        break;
                    default://等于
                        RetBool1 = FuncStr.ToLower() == mFuncData1.ToLower();
                        break;
                }
                switch (mFuncStr2)
                {
                    case "":
                    case "数据链接":
                        Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + "判断条件为空,请检查!");
                        return false;
                    default:
                        if (mFuncStr1.Contains("全局"))
                        {
                            FuncStr = Var.GetLinkData(mSysVar, mFuncStr2).Split('|')[2];
                        }
                        else
                        {
                            FuncStr = Var.GetLinkData(mSloVar, mFuncStr2).Split('|')[2];
                        }
                        break;
                }
                switch (mFuncType2)
                {
                    case 0://等于
                        RetBool2 = FuncStr.ToLower() == mFuncData2.ToLower();
                        break;
                    case (FuncType)1://不等于
                        RetBool2 = FuncStr.ToLower() != mFuncData2.ToLower();
                        break;
                    case (FuncType)2://大于
                        RetBool2 = (double.Parse(FuncStr) > double.Parse(mFuncData2));
                        break;
                    case (FuncType)3://大于等于
                        RetBool2 = (double.Parse(FuncStr) >= double.Parse(mFuncData2));
                        break;
                    case (FuncType)4://小于
                        RetBool2 = (double.Parse(FuncStr) < double.Parse(mFuncData2));
                        break;
                    case (FuncType)5://小于等于
                        RetBool2 = (double.Parse(FuncStr) <= double.Parse(mFuncData2));
                        break;
                    case (FuncType)6://包含
                        RetBool2 = FuncStr.ToLower().Contains(mFuncData2.ToLower());
                        break;
                    case (FuncType)7://不包含
                        RetBool2 = !FuncStr.ToLower().Contains(mFuncData2.ToLower());
                        break;
                    default://等于
                        RetBool2 = FuncStr.ToLower() == mFuncData2.ToLower();
                        break;
                }
                RetBool = RetBool1 & RetBool2;
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.Bool, ConstVar.Circle, ModInfo.Plugin, "0", 1, RetBool, DataAtrr.全局变量));
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + RetBool);
                ModInfo.State = ModState.OK;
                return ModInfo.Result = RetBool;
            }
            catch
            {
                ModInfo.State = ModState.NG;
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.Bool, ConstVar.Circle, ModInfo.Plugin, "0", 1, RetBool, DataAtrr.全局变量));
                return ModInfo.Result = false;
            }
        }

        public override void RunForm(ObjBase baseMod)
        {
            new IFForm((IFObj)baseMod).ShowDialog();
        }
        override public void SetInfo()
        {
        }
    }
}
