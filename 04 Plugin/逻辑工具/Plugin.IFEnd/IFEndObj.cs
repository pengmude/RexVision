using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using VisionCore;

namespace Plugin.IFEnd
{
    [Category("逻辑工具")]
    [DisplayName("结束")]
    [Serializable]
    public class IFEndObj : ObjBase
    {
        public override bool RunObj()
        {
            ModInfo.State = ModState.None;
            return true;
        }
        [OnDeserializing()]
        internal void OnDeSerializingMethod(StreamingContext context)
        {         
        }
        public override void RunForm(ObjBase baseMod)
        {
            new IFEndForm((IFEndObj)baseMod).ShowDialog();
        }
        override public void SetInfo()
        {
        }
    }
}
