using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.AffineTrans
{
    [Category("对位工具")]
    [DisplayName("仿射变换")]
    [Serializable]
    public class AffineTransObj : ObjBase
    {
        /// <summary>仿射矩阵</summary>
        public HHomMat2D m_HHomMat2D;
        /// <summary>映射方式</summary>
        public MapType mMapType;
        /// <summary>仿射方法</summary>
        public AffineType mAffineType;
        /// <summary>仿射前X</summary>
        public string mFormX = "数据链接";
        /// <summary>仿射前Y</summary>
        public string mFormY = "数据链接";
        /// <summary>仿射前R</summary>
        public string mFormR = "数据链接";
        /// <summary>仿射后X</summary>
        public string mToX = "数据链接";
        /// <summary>仿射后Y</summary>
        public string mToY = "数据链接";
        /// <summary>仿射后R</summary>
        public string mToR = "数据链接";
        /// <summary>映射点X</summary>
        public string mMapPointX = "数据链接";
        /// <summary>映射点Y</summary>
        public string mMapPointY = "数据链接";
        /// <summary>平移矩阵</summary>
        public HHomMat2D mHomMat2DTransl = new HHomMat2D();
        /// <summary>输出点</summary>
        public RPoint mRPoint = new RPoint();
        public override bool RunObj()
        {
            try
            {
                double Cx, Cy, Ax, Ay, Bx, By;
                //拿到数据
                //A是用探针戳这mark点时的机械坐标XY
                //B是当前拍照时的机械坐标XY
                //C是拍照得到的mark点,映射后的世界坐标XY
                //vector_angle_to_rigid(C.x, C.y, 0, A.x, A.y, 0, HomMat2D)
                //affine_trans_point_2d(HomMat2D, B.x, B.y, Qx, Qy)

                if (mFormX.Contains("全局变量"))
                {
                    Cx = IsNumber(mFormX) == true ? double.Parse(mFormX) : double.Parse(Var.GetLinkData(mSysVar, mFormX).Split('|')[2]);
                }
                else
                {
                    Cx = IsNumber(mFormX) == true ? double.Parse(mFormX) : double.Parse(Var.GetLinkData(mSloVar, mFormX).Split('|')[2]);
                }
                if (mFormY.Contains("全局变量"))
                {
                    Cy = IsNumber(mFormY) == true ? double.Parse(mFormY) : double.Parse(Var.GetLinkData(mSysVar, mFormY).Split('|')[2]);
                }
                else
                {
                    Cy = IsNumber(mFormY) == true ? double.Parse(mFormY) : double.Parse(Var.GetLinkData(mSloVar, mFormY).Split('|')[2]);
                }

                if (mToX.Contains("全局变量"))
                {
                    Ax = IsNumber(mToX) == true ? double.Parse(mToX) : double.Parse(Var.GetLinkData(mSysVar, mToX).Split('|')[2]);
                }
                else
                {
                    Ax = IsNumber(mToX) == true ? double.Parse(mToX) : double.Parse(Var.GetLinkData(mSloVar, mToX).Split('|')[2]);
                }
                if (mToY.Contains("全局变量"))
                {
                    Ay = IsNumber(mToY) == true ? double.Parse(mToY) : double.Parse(Var.GetLinkData(mSysVar, mToY).Split('|')[2]);
                }
                else
                {
                    Ay = IsNumber(mToY) == true ? double.Parse(mToY) : double.Parse(Var.GetLinkData(mSloVar, mToY).Split('|')[2]);
                }

                if (mMapPointX.Contains("全局变量"))
                {
                    Bx = IsNumber(mMapPointX) == true ? double.Parse(mMapPointX) : double.Parse(Var.GetLinkData(mSysVar, mMapPointX).Split('|')[2]);
                }
                else
                {
                    Bx = IsNumber(mMapPointX) == true ? double.Parse(mMapPointX) : double.Parse(Var.GetLinkData(mSloVar, mMapPointX).Split('|')[2]);
                }
                if (mMapPointY.Contains("全局变量"))
                {
                    By = IsNumber(mMapPointY) == true ? double.Parse(mMapPointY) : double.Parse(Var.GetLinkData(mSysVar, mMapPointY).Split('|')[2]);
                }
                else
                {
                    By = IsNumber(mMapPointY) == true ? double.Parse(mMapPointY) : double.Parse(Var.GetLinkData(mSloVar, mMapPointY).Split('|')[2]);
                }
                //建立仿射
                mHomMat2DTransl = Aff.AffHomMat2D(Cx, Cy, 0, Ax, Ay, 0);
                //仿射变换
                Aff.Affine2d(mHomMat2DTransl, Bx, By, out mRPoint.X, out mRPoint.Y);
                //写入变量
                mRPoint.Status = true;
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.点2D, ConstVar.Result, "仿射变换", "0", 1, mRPoint, DataAtrr.全局变量));
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + mRPoint.X + "," + mRPoint.Y);
                ModInfo.State = ModState.OK;
                return ModInfo.Result = true;
            }
            catch
            {
                //写入变量
                mRPoint = new RPoint();
                mRPoint.Status = false;
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.点2D, ConstVar.Result, "仿射变换", "0", 1, mRPoint, DataAtrr.全局变量));
                ModInfo.State = ModState.NG;
                return ModInfo.Result = false;
            }

        }
        public override void RunForm(ObjBase BaseMod)
        {
            new AffineTransForm((AffineTransObj)BaseMod).ShowDialog();
        }
        override public void SetInfo()
        {
        }
    }

}
