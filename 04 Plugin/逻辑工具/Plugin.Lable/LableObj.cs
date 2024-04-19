using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using VisionCore;

namespace Plugin.Lable
{
    [Category("逻辑工具")]
    [DisplayName("标签")]
    [Serializable]
    public class LableObj : ObjBase
    {
        public override bool RunObj()
        {
            SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.Double, ConstVar.Result, ModInfo.Name, "0", 1, ModInfo.Encode, DataAtrr.全局变量));
            ModInfo.State = ModState.OK;
            return false;
        }
        [OnDeserializing()]
        internal void OnDeSerializingMethod(StreamingContext context)
        {         
        }
        public override void RunForm(ObjBase baseMod)
        {
            new LableForm((LableObj)baseMod).ShowDialog();
        }
        override public void SetInfo()
        {
        }
    }
}
