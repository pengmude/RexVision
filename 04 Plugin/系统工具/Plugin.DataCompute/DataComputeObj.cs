using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using VisionCore;
namespace Plugin.DataCompute
{
    [Category("系统工具")]
    [DisplayName("数据计算")]
    [Serializable]
    public class DataComputeObj : ObjBase
    {
        /// <summary>保存信息</summary>
        public List<Char_Info> mChar_Info = new List<Char_Info>();
        public override bool RunObj()
        {
            try
            {
                string Link1 = string.Empty;
                string Link2 = string.Empty;
                foreach (var info in mChar_Info)
                {
                    if(info.Link1.Contains("全局变量"))
                    {
                        Link1 = Var.GetLinkData(mSysVar, info.Link1).Split('|')[2];
                    }
                    else
                    {
                        Link1 = Var.GetLinkData(mSloVar, info.Link1).Split('|')[2];
                    }
                    if (info.Link2.Contains("全局变量"))
                    {
                        Link2 = Var.GetLinkData(mSysVar, info.Link2).Split('|')[2];
                    }
                    else
                    {
                        Link2 = Var.GetLinkData(mSloVar, info.Link2).Split('|')[2];
                    }
                    switch (info.CharType)
                    {
                        case "加":
                            info.Result = (double.Parse(Link1) + double.Parse(Link2)).ToString("F6");
                            break;
                        case "减":
                            info.Result = (double.Parse(Link1) - double.Parse(Link2)).ToString("F6");
                            break;
                        case "乘":
                            info.Result = (double.Parse(Link1) * double.Parse(Link2)).ToString("F6");
                            break;
                        case "除":
                            info.Result = (double.Parse(Link1) / double.Parse(Link2)).ToString("F6");
                            break;
                    }
                }
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.String, ConstVar.Line, ModInfo.Plugin, "0", 1, mChar_Info, DataAtrr.全局变量));
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + "OK");
                ModInfo.State = ModState.OK;
                return ModInfo.Result = true;
            }
            catch (Exception ex)
            {
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + ex.Message);
                ModInfo.State = ModState.OK;
                return ModInfo.Result = false;
            }
        }
        /// <summary>删除指定日期前的日志</summary>
        public void RemovCsv(int dayNum)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log.Debug(ex.Message);
            }
        }
        public override void RunForm(ObjBase baseMod)
        {
            new DataComputeForm((DataComputeObj)baseMod).ShowDialog();
        }
        override public void SetInfo() { }
    }
}
