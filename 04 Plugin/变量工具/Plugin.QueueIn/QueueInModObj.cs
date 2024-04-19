
using HalconDotNet;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using VisionCore;

namespace Plugin.QueueIn
{
    [Category("变量工具")]
    [DisplayName("数据入队")]
    [Serializable]
    public class QueueInModObj : ObjBase
    {
        DataIn dataIn = new DataIn();
        public override bool RunObj()
        {
            dataIn.Execute();//入队
            ModInfo.State = ModState.OK;
            return true;
        }
        public override void RunForm(ObjBase baseMod)
        {
           new QueueInModForm((QueueInModObj)baseMod).ShowDialog();
        }
        override public void SetInfo()
        {

        }
    }
}
