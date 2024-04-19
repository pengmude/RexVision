using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using VisionCore;

namespace Plugin.ReadCmd
{
    [Category("通讯工具")]
    [DisplayName("接收命令")]
    [Serializable]
    public class ReadCmdObj : ObjBase
    {
        /// <summary>通信类</summary>
        [NonSerialized]
        ECom IECom = null;
        /// <summary>通信名称</summary>
        public string mKey = "";
        /// <summary>指定字符</summary>
        public string mData = "T1";
        /// <summary>结束字符</summary>
        public string mEndChar = "";
        /// <summary>停止等待</summary>
        public void Stop()
        {
            try
            {
                if (mECom != null)
                {
                    IECom.StopRecStrSignal();
                }
            }
            catch(Exception ex)
            {
                Log.Error(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + ex.Message);
            }
        }
        public override bool RunObj()
        {
            IECom = mECom.FirstOrDefault(c => c.Key == mKey);
            if (mECom != null&mData.Length>0)
            {
                string m_GetData = string.Empty;
                do
                {
                    Thread.Sleep(10);
                    IECom.GetStr(out m_GetData);
                }
                while (!(m_GetData == mData) && !Sol.IsStop);
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.String, ConstVar.Result, ModInfo.Plugin, "0", 1, mData + mEndChar, DataAtrr.全局变量));
                ModInfo.State = ModState.OK;
                m_GetData = "";
                return true;
            }
            else
            {
                if (mECom==null)
                {
                    Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + "端口为空,请检查!");
                }
                else if(mData.Length==0)
                {
                    Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + "命令为空,请检查!");
                }
                ModInfo.State = ModState.NG;
                return false;
            }
        }
        public override void RunForm(ObjBase BaseMod)
        {
            new ReadtCmdForm((ReadCmdObj)BaseMod).ShowDialog();
        }
        override public void SetInfo(){}
    }
}
