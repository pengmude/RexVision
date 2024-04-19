using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
namespace Plugin.VarDefine
{
    [Category("变量工具")]
    [DisplayName("变量定义")]
    [Serializable]
    public class VarDefineObj : ObjBase
    {
       public List<DataCell> mVarList = new List<DataCell>();//变量列表
        public override bool RunObj()
        {
            try
            {
                if (mVarList.Count>0)
                {
                    foreach(DataCell data in mVarList)
                    {
                        SetVarList(ref mSloVar, data);
                    }
                }
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + "OK");
                ModInfo.State = ModState.OK;
                return ModInfo.Result = true;
            }
            catch
            {
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + "NG");
                ModInfo.State = ModState.NG;
                return ModInfo.Result = false;
            }
        }

        public override void RunForm(ObjBase baseMod)
        {
           new VarDefineForm((VarDefineObj)baseMod).ShowDialog();
        }

        override public void SetInfo()
        {

        }
    }
}
