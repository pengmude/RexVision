using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using VisionCore;


namespace Plugin.CreateText
{
    [Category("变量工具")]
    [DisplayName("创建文本")]
    [Serializable]
    public class CreateTextObj : ObjBase
    {
        /// <summary>文本信息</summary>
        public List<Text_Info> mText_Info = new List<Text_Info>();
        /// <summary>输出Bool</summary>
        public string OutTrue  = "1";
        /// <summary>输出Bool</summary>
        public string OutFalse = "0";
        /// <summary>输出NG文本</summary>
        public string OutNGStr = "-999";
        /// <summary>输出Double</summary>
        public string OutDouble = "4";
        /// <summary>输出分割</summary>
        public string OutStrSplit = ",";
        /// <summary>输出文本</summary>
        public string OutStr = string.Empty;
        /// <summary> 输出格式</summary>
        public string OutFormat= string.Empty;
        Rtn_Info mRtn_Info = new Rtn_Info();
        public override bool RunObj()
        {
            try
            {
                string mDouble = "0";
                OutStr = string.Empty;
                foreach (Text_Info info in mText_Info)
                {
                    if(info.Likes.Contains("全局变量"))
                    {
                        info.Value = Var.GetLinkData(mSysVar, info.Likes).Split('|')[2];
                    }
                    else
                    {
                        info.Value = Var.GetLinkData(mSloVar, info.Likes).Split('|')[2];
                    }
                    if(IsNumber(info.Value))
                    {
                        double.TryParse(info.Value, out double mDbStr);
                        mDouble = mDbStr.ToString("F" + OutDouble);
                    }
                    else
                    {
                        mDouble = info.Value;
                    }

                    OutStr += mDouble + OutStrSplit;//通过分隔符链接文本
                }
                OutStr = OutStr.Replace("True", OutTrue).Replace("False", OutFalse);
                OutStr= OutStr.Substring(0, OutStr.Length - 1);
                mRtn_Info.Value = OutStr;
                mRtn_Info.Status = true;
                ModInfo.State = ModState.OK;
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.数组, DataMode.自定义, ConstVar.Result, ModInfo.Plugin, "0", 1, mRtn_Info, DataAtrr.全局变量));
                return true;
            }
            catch
            {
                mRtn_Info.Value=OutNGStr;
                mRtn_Info.Status = false;
                ModInfo.State = ModState.NG;
                return false;
            }
        }
        public override void RunForm(ObjBase BaseMod)
        {
          new CreateTextForm((CreateTextObj)BaseMod).ShowDialog();
        }
        override public void SetInfo(){}
    }
}
