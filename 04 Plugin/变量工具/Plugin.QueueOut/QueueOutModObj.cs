
using HalconDotNet;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using VisionCore;

namespace Plugin.QueueOut
{
    [Category("变量工具")]
    [DisplayName("数据出队")]
    [Serializable]
    public class QueueOutModObj : ObjBase
    {
        public DataOut dataOut = new DataOut();//
        public override bool RunObj()
        {
            dataOut.Execute();//出队
            ModInfo.State = ModState.OK;
            return true;
        }
        public override void RunForm(ObjBase baseMod)
        {
            new QueueOutModForm((QueueOutModObj)baseMod).ShowDialog();
        }
        override public void SetInfo()
        {

        }
    }
}
