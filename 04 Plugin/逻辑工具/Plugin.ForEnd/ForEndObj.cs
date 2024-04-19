using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using VisionCore;

namespace Plugin.ForEnd
{
    [Category("逻辑工具")]
    [DisplayName("循环结束")]
    [Serializable]
    public class ForEndObj : ObjBase
    {
        public override bool RunObj()
        {
           string mNowStr = Var.GetLinkData(mSloVar, ModInfo.Name.Replace("结束","开始")+":"+"Result").Split('|')[2];
            Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + mNowStr);
            ModInfo.State = ModState.OK;
            return true;
        }
        [OnDeserializing()]
        internal void OnDeSerializingMethod(StreamingContext context)
        {         
        }
        public override void RunForm(ObjBase baseMod)
        {
           new ForEndForm((ForEndObj)baseMod).ShowDialog();
        }
        override public void SetInfo()
        {

        }
    }
}
