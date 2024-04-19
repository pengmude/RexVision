using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using System.IO;
using VisionCore;
using System.Windows.Forms;

using RexConst;

namespace Plugin.ShowImage
{
    [Category("图像处理")]
    [DisplayName("图像显示")]
    [Serializable]
    public class ShowImageModObj : ObjBase
    {
        /// <summary>
        /// 图像要显示的屏幕编号
        /// </summary>
        public int m_Screen= 1;
        /// <summary>
        ///  当前选择图像名称
        /// </summary>
        public string mImages;
        /// <summary>
        ///  工具输出图像名称
        /// </summary>
        [NonSerialized]
        public RImage m_OutImage=new RImage();
        public override bool RunObj()
        {
            try
            {
                if ((m_OutImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
                {
                    ModInfo.State = ModState.NoImage;
                    return false;
                }
                m_OutImage.Screen = m_Screen;
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode,DataType.单量, DataMode.图像,ConstVar.Image, ModInfo.Plugin,"0",1, m_OutImage,DataAtrr.全局变量));
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                ModInfo.State = ModState.NG;
                Debug.WriteLine(ex.Message);
                return false;
            }

        }
        public override void RunForm(ObjBase baseMod)
        {
            new ShowImageForm((ShowImageModObj)baseMod).ShowDialog();
        }
        override public void SetInfo()
        {

        }
    }
}
