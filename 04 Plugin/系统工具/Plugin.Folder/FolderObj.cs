﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using VisionCore;

namespace Plugin.Folder
{
    [Category("系统工具")]
    [DisplayName("文件夹")]
    [Serializable]
    public class FolderObj : ObjBase
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
            new FolderForm((FolderObj)baseMod).ShowDialog();
        }
        override public void SetInfo()
        {
        }
    }
}
