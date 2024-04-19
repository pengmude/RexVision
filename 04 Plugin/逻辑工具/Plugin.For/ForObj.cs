using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using VisionCore;

namespace Plugin.For
{
    [Category("逻辑工具")]
    [DisplayName("循环开始")]
    [Serializable]
    public class ForObj : ObjBase
    {
        public ForMode mForMode = ForMode.递增;
        public string mStarStr = "数据链接";
        public string mOverStr = "数据链接";
        public double mNowStr = 0.0;
        public override bool RunObj()
        {
            string ForStarStr = string.Empty;
            string ForOverStr = string.Empty;
            try
            {
                if (mStarStr.Contains("数据链接") || mOverStr.Contains("数据链接"))
                {
                    Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + "条件为空,请检查!");
                    return false;
                }
                if(mStarStr.Contains("全局"))
                {
                    ForStarStr = IsNumber(mStarStr) ? mStarStr : Var.GetLinkData(mSysVar, mStarStr).Split('|')[2];
                }
                else
                {
                    ForStarStr = IsNumber(mStarStr) ? mOverStr : Var.GetLinkData(mSloVar, mStarStr).Split('|')[2];
                }
                if (mOverStr.Contains("全局"))
                {
                    ForOverStr = IsNumber(mOverStr) ? mOverStr : Var.GetLinkData(mSysVar, mOverStr).Split('|')[2];
                }
                else
                {
                    ForOverStr = IsNumber(mOverStr) ? mOverStr : Var.GetLinkData(mSloVar, mOverStr).Split('|')[2];
                }
                switch (mForMode)
                {
                    case ForMode.递增:
                        {
                            Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + mNowStr);
                            SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.Double, ConstVar.Result, ModInfo.Plugin, "0", 1, mNowStr, DataAtrr.全局变量));
                            ModInfo.State = ModState.OK;
                            if (mNowStr < double.Parse(ForOverStr))
                            {
                                ++mNowStr;
                                return ModInfo.Result = false;
                            }
                            else
                            {
                                mNowStr = double.Parse(ForStarStr);
                                return ModInfo.Result = true;
                            }
                        }
                    case ForMode.递减:
                        {
                            Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + mNowStr);
                            SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.Double, ConstVar.Result, ModInfo.Plugin, "0", 1, mNowStr, DataAtrr.全局变量));
                            ModInfo.State = ModState.OK;
                            if (mNowStr > double.Parse(ForStarStr))
                            {
                                --mNowStr;
                                return ModInfo.Result = false;
                            }
                            else
                            {
                                mNowStr = double.Parse(ForOverStr);
                                return ModInfo.Result = true;
                            }
                        }
                    case ForMode.无限:
                        {
                            mNowStr = -1.00;
                            Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + mNowStr);
                            SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.Double, ConstVar.Result, ModInfo.Plugin, "0", 1, mNowStr, DataAtrr.全局变量));
                            return ModInfo.Result = true;
                        }
                }
            }
            catch (Exception ex)
            {
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + mNowStr + ":" + ex.Message);
                ModInfo.State = ModState.NG;
                return ModInfo.Result = false;
            }
            ModInfo.State = ModState.NG;
            return ModInfo.Result = false;
        }
        public override void RunForm(ObjBase baseMod)
        {
            new ForForm((ForObj)baseMod).ShowDialog();
        }
        override public void SetInfo(){}
    }
}
