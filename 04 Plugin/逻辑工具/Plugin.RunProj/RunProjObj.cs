using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.RunProj
{
    [Category("逻辑工具")]
    [DisplayName("执行流程")]
    [Serializable]
    public class RunProjObj : ObjBase
    {   
        /// <summary>执行模式</summary>
        public RunMode mRunMode = RunMode.停止执行;
        /// <summary>流程信息</summary>
        public List<Proj> mRunProj = new List<Proj>();
        /// <summary>执行模式</summary>
        public List<RunMode> mRunModeList = new List<RunMode>();
        public override bool RunObj()
        {
            int index = 0;
            foreach(Proj proj in mRunProj)
            {
                //Proj mProj= Sol.mSol.mProjList.Find(c => c.mProjInfo.Index == proj.mProjInfo.Index);
                switch(mRunModeList[index])
                {
                    case RunMode.单次执行:
                        Sol.OnceRun(proj.mProjInfo.Index);
                        break;
                    case RunMode.循环执行:
                        Sol.StartRun(proj.mProjInfo.Index);
                        break;
                    case RunMode.停止执行:
                        Sol.StopRun(proj.mProjInfo.Index);
                        break;
                }
                ++index;
            }
            ModInfo.State = ModState.OK;
            return true;
        }
        public override void RunForm(ObjBase baseMod)
        {
           new RunProjForm((RunProjObj)baseMod).ShowDialog();
        }
        override public void SetInfo(){}
    }
}
