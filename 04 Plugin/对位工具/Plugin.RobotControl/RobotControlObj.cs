
using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using VisionCore;



namespace Plugin.RobotControl
{
    [Category("对位工具")]
    [DisplayName("手臂控制")]
    [Serializable]
    public class RobotControlObj : ObjBase
    {      
        /// <summary>拍照方式</summary>
        public CaptureMode mCaptureMode;
        /// <summary>机械手X</summary>
        public string mRobotX;
        /// <summary>机械手Y</summary>
        public string mRobotY;
        /// <summary>机械手R</summary>
        public string mRobotR;
        /// <summary>输入坐标X(pix)</summary>
        public string mFormX;
        /// <summary>输入坐标Y(pix)</summary>
        public string mFormY;
        /// <summary>输入角度R</summary>
        public string mFormR;
        /// <summary>平移坐标X</summary>
        public string mParallelX;
        /// <summary>平移坐标Y</summary>
        public string mParallelY;
        /// <summary>补偿角度R</summary>
        public string mCompensationR;
        /// <summary>参考坐标X</summary>
        public string mReferX;
        /// <summary>参考坐标Y</summary>
        public string mReferY;
        /// <summary>参考角度R</summary>
        public string mReferR;
        /// <summary>参考角度R</summary>
        public string mAngleOffset ;

        /// <summary>输出坐标点</summary>
        public RPoint mRPoint = new RPoint();
        /// <summary>标准位置X</summary>
        public string mStandardX;
        /// <summary>标准位置Y</summary>
        public string mStandardY;
        /// <summary>标准位置R</summary>
        public string mStandardR;

        /// <summary>最大偏差X</summary>
        public string mMaxOffsetX;
        /// <summary>最大偏差Y</summary>
        public string mMaxOffsetY;
        /// <summary>最大偏差R</summary>
        public string mMaxOffsetR;
        /// <summary>矩阵链接</summary>
        public string mNPointHomMat;
        /// <summary>平移矩阵</summary>
        public HHomMat2D mNPointHHomMat2D;
        /// <summary>旋转矩阵</summary>
        public HHomMat2D mRotateHHomMat2D;
        /// <summary>位置限制</summary>
        public bool mPositionLimit = false;

        public override bool RunObj()
        {
            try
            {
                //vector_angle_to_rigid(0, 偏心距, 0, 物料.x, 物料.y, 物料.角度, HomMat2D)
                //标定信息
                Cal_Info mCalInfo = ((List<Cal_Info>)mCalVar.FindLast(c => c.mDataMode == DataMode.标定信息 & c.mModName == mNPointHomMat).mDataValue)[0];
                switch (mCaptureMode)
                {
                    case CaptureMode.固定相机一先抓取后拍照:
                        {
                            //图像图标转世界坐标？
                            //手眼转换？
                            //使用           
                            DataCell data2 = mCalVar.FindLast(c => c.mDataMode == DataMode.平移矩阵 & c.mModName == mNPointHomMat);
                            HOperatorSet.VectorAngleToRigid(mCalInfo.RrotationCenterX, mCalInfo.RrotationCenterY, mCalInfo.RotationAngle, new HTuple(GetStr(mFormX)), new HTuple(GetStr(mFormY)), new HTuple(GetStr(mFormR)), out HTuple mat2D);//旋转矩阵
                            HOperatorSet.AffineTransPoint2d(mat2D, 0, 0, out HTuple 偏移X, out HTuple 偏移Y);//Test
                            mRPoint.X =/*CCD位置X +*/   GetStr(mParallelX) - 偏移X;
                            mRPoint.Y =/*CCD位置Y +*/   GetStr(mParallelY) - 偏移Y;
                            mRPoint.R =/*CCD位置R +*/  mCalInfo.RotationAngle - GetStr(mFormR);
                            mRPoint.Status = true;
                            SetVarList(ref mSloVar, new DataCell(this.ModInfo.Name, this.ModInfo.Encode, DataType.单量, DataMode.点2D, ConstVar.Result, ModInfo.Plugin, "0", 1, mRPoint, DataAtrr.全局变量));
                            break;
                        }
                    case CaptureMode.固定相机一先拍照再取放:
                        {
                            //九点标定测试-OK  平移未加：加平移需要单独转换
                            mNPointHHomMat2D = (HHomMat2D)mCalVar.FindLast(c => c.mDataMode == DataMode.平移矩阵 & c.mModName == mNPointHomMat).mDataValue;
                            HOperatorSet.AffineTransPoint2d(mNPointHHomMat2D, new HTuple(GetStr(mFormX)), new HTuple(GetStr(mFormY)), out HTuple XXX, out HTuple YYY);
                            HOperatorSet.AffineTransPoint2d(mNPointHHomMat2D, new HTuple(GetStr(mFormX) + GetStr(mParallelX)), new HTuple(GetStr(mFormY)), out HTuple XXX1, out HTuple YYY1);
                            HOperatorSet.AffineTransPoint2d(mNPointHHomMat2D, new HTuple(GetStr(mFormX)), new HTuple(GetStr(mFormY) + GetStr(mParallelY)), out HTuple XXX2, out HTuple YYY2);
                            HOperatorSet.AffineTransPoint2d(mNPointHHomMat2D, new HTuple(GetStr(mFormX) - GetStr(mParallelX)), new HTuple(GetStr(mFormY) - GetStr(mParallelY)), out HTuple XXX3, out HTuple YYY3);
                            mRPoint.X = (GetStr(mRobotX)) + XXX;
                            mRPoint.Y = (GetStr(mRobotY)) + YYY;
                            mRPoint.R = 0;
                            mRPoint.Status = true;
                            SetVarList(ref mSloVar, new DataCell(this.ModInfo.Name, this.ModInfo.Encode, DataType.单量, DataMode.点2D, ConstVar.Result, ModInfo.Plugin, "0", 1, mRPoint, DataAtrr.全局变量));
                            break;
                        }
                    case CaptureMode.移动相机一先拍照再取放:
                        {
                            //九点标定测试-OK  平移未加：加平移需要单独转换
                            DataCell cell = mCalVar.FindLast(c => c.mDataMode == DataMode.平移矩阵 & c.mModName == mNPointHomMat);
                            HHomMat2D mHomMat2DTransl = (HHomMat2D)mCalVar.FindLast(c => c.mDataMode == DataMode.平移矩阵 & c.mModName == mNPointHomMat).mDataValue;
                            HOperatorSet.AffineTransPoint2d(mHomMat2DTransl, new HTuple(GetStr(mFormX)), new HTuple(GetStr(mFormY)), out HTuple XXX, out HTuple YYY);
                            HOperatorSet.AffineTransPoint2d(mHomMat2DTransl, new HTuple(GetStr(mFormX) + GetStr(mParallelX)), new HTuple(GetStr(mFormY)), out HTuple XXX1, out HTuple YYY1);
                            HOperatorSet.AffineTransPoint2d(mHomMat2DTransl, new HTuple(GetStr(mFormX)), new HTuple(GetStr(mFormY) + GetStr(mParallelY)), out HTuple XXX2, out HTuple YYY2);
                            HOperatorSet.AffineTransPoint2d(mHomMat2DTransl, new HTuple(GetStr(mFormX) - GetStr(mParallelX)), new HTuple(GetStr(mFormY) - GetStr(mParallelY)), out HTuple XXX3, out HTuple YYY3);
                            mRPoint.X = (GetStr(mRobotX))+ GetStr(mParallelX) - XXX;
                            mRPoint.Y = (GetStr(mRobotY))+ GetStr(mParallelY) - YYY;
                            mRPoint.R = 0;
                            mRPoint.Status = true;
                            SetVarList(ref mSloVar, new DataCell(this.ModInfo.Name, this.ModInfo.Encode, DataType.单量, DataMode.点2D, ConstVar.Result, ModInfo.Plugin, "0", 1, mRPoint, DataAtrr.全局变量));
                            break;
                        }
                }

                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + mRPoint .X + "," + mRPoint.Y + mRPoint.R);
                ModInfo.State = ModState.OK;
                return true;
            }
            catch(Exception ex)
            {
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + mRPoint.X + "," + mRPoint.Y + mRPoint.R + ex.Message);
                ModInfo.State = ModState.NG;
                return mRPoint.Status = false;
            }
        }
        public double GetStr(string str)
        {
            if (str == null||str.Length==0|| str.Contains("数据链接"))
            {
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":链接的数据为空! "+ str+"使用默认值：0");
                return 0.0;
            }
            if (IsNumber(str)){return double.Parse(str);}
            string m_OutLinkData = "0|0|0";
            if (str.Contains("全局变量"))
            {
                m_OutLinkData = Var.GetLinkData(mSysVar, str);
            }
            else
            {
                m_OutLinkData = Var.GetLinkData(mSloVar, str);
            }

            return double.Parse(m_OutLinkData.Split('|')[2]);
        }
        public override  void RunForm(ObjBase baseMod)
        {
          new RobotControlForm((RobotControlObj)baseMod).ShowDialog();
        }
        public override  void SetInfo()
        {

        }
    }
}
