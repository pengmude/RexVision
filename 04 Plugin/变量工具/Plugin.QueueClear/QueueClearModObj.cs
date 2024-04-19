
using HalconDotNet;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using VisionCore;

namespace Plugin.QueueClear
{
    [Category("变量工具")]
    [DisplayName("清空队列")]
    [Serializable]
    public class QueueClearModObj : ObjBase
    {
        public override bool RunObj()
        {

            ModInfo.State = ModState.OK;
            return true;
        }
        public override void RunForm(ObjBase baseMod)
        {
           new QueueClearModForm((QueueClearModObj)baseMod).ShowDialog();
        }
        override public void SetInfo()
        {

        }
    }
}
