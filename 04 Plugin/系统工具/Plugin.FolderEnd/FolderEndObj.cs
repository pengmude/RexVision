using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using VisionCore;

namespace Plugin.FolderEnd
{
    [Category("系统工具")]
    [DisplayName("文件夹结束")]
    [Serializable]
    public class FolderEndObj : ObjBase
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
           new FolderEndForm((FolderEndObj)baseMod).ShowDialog();
        }
        override public void SetInfo()
        {

        }
    }
}
