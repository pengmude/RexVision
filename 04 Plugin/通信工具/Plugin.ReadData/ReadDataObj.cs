using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using VisionCore;

namespace Plugin.ReadData
{
    [Category("通讯工具")]
    [DisplayName("接收文本")]
    [Serializable]
    public class ReadDataObj : ObjBase
    {
        /// <summary>通信类</summary>
        [NonSerialized]
        ECom IECom = null;
        /// <summary>通信名称</summary>
        public string mKey = "";
        /// <summary>获取数据</summary>
        public string mData;
        /// <summary>结束符</summary>
        public string mEndChar;
        /// <summary>停止等待</summary>
        public void Stop()
        {
            try
            {
                if (IECom != null)
                {
                    IECom.StopRecStrSignal();
                }
            }
            catch (Exception ex)
            {
                Log.Error(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + ex.Message);
            }
        }
        public override bool RunObj()
        {
            IECom = mECom.FirstOrDefault(c => c.Key == mKey);
            if (mECom != null)
            {
                IECom.GetStr(out mData);
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.String, ConstVar.Result, ModInfo.Plugin, "0", 1, mData+ mEndChar, DataAtrr.全局变量));
                ModInfo.State = ModState.OK;
                return true;
            }
            else
            {
               Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + "端口为空,请检查!");
                ModInfo.State = ModState.NG;
                return false;
            }
        }
        public override void RunForm(ObjBase BaseMod)
        {
           new ReadDataForm((ReadDataObj)BaseMod).ShowDialog();
        }
        override public void SetInfo(){}
    }
}
