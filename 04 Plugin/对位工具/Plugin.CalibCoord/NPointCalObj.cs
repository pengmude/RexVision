using HalconDotNet;
using Rex.UI;
using RexView;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VisionCore;



namespace Plugin.NPointCal
{
    [Category("对位工具")]
    [DisplayName("九点标定")]
    [Serializable]
    public class NPointCalObj : ObjBase
    {
        /// <summary>点类型：3/9/14</summary>
        public PointType mPointType = PointType.Nine;
        /// <summary>标定:手动/自动 </summary>
        public CalType mCalType;
        /// <summary>相机:固定/移动 </summary>
        public CamerType mCamerType;
        /// <summary>角度:固定/变化 </summary>
        public AngleType mAngleType;
        /// <summary>相机:固定/变化 </summary>
        public bool mCamerFix = false;
        /// <summary>输入X</summary>
        public string mInputX = "数据链接";
        /// <summary>输入Y</summary>
        public string mInputY = "数据链接";
        /// <summary>采集设备 </summary>
        public string mDeviceID = "数据链接";
        /// <summary>链接队列 </summary>
        public string mLikeQueue = "数据链接";
        /// <summary>间距X</summary>
        public double mSpaceX = 0.0;
        /// <summary>间距Y</summary>
        public double mSpaceY = 0.0;
        /// <summary>基准X</summary>
        public double mBaseX = 0.0;
        /// <summary>基准Y </summary>
        public double mBaseY = 0.0;
        /// <summary>基准角度</summary>
        public double mBaseAngle = 0.0;
        /// <summary>角度取反</summary>
        public bool mAngleNot = false;
        /// <summary>是否启用旋转中心标定</summary>
        public bool mRotateCentre = true;
        /// <summary>MarkX</summary>
        public double mMarkX = 0.0;
        /// <summary>MarkY</summary>
        public double mMarkY = 0.0;
        /// <summary>旋转角度</summary>
        public double mRotateAngle = 0.0;
        /// <summary>是否自动清空</summary>
        public bool mAutoCleare = false;
        /// <summary>检查标定结果</summary>
        public bool mCheckCalResult = false;
        /// <summary>旋转中心X</summary>
        public double mRotateCenterX = 0.0;
        /// <summary>旋转中心Y</summary>
        public double mRotateCenterY = 0.0;
        ///<summary>相机和X轴的夹角 </summary>
        public double mPhiSingle = 0.0;
        ///<summary>标定RMS</summary>
        public double mCalibRms = 0.0;
        /// <summary>平移矩阵</summary>
        public HHomMat2D mHomMat2DTransl = new HHomMat2D();
        /// <summary>旋转矩阵</summary>
        public HHomMat2D mHomMat2DRotate = new HHomMat2D();
        //坐标集合-序列话也无所谓*****************************************
        /// <summary>像素坐标X</summary>
        public double[] ImageX_S = new double[14];
        /// <summary>像素坐标Y</summary>
        public double[] ImageY_S = new double[14];
        /// <summary>机械坐标X</summary>
        public double[] RobotX_S = new double[14];
        /// <summary>机械坐标Y</summary>
        public double[] RobotY_S = new double[14];
        /// <summary>自动标定计数</summary>
        public int mAutoCalCounter = 0;
        /// <summary>标定自动清零</summary>
        public bool mAutoClear = false;
        /// <summary>标定点信息</summary>
        public List<NPoint> mNPoint = new List<NPoint>();
        public override bool RunObj()
        {
            try
            {
                int CalLenght = 0;
                switch (mPointType)
                {
                    case PointType.Three:
                        {
                            CalLenght = 3;
                            break;
                        }
                    case PointType.Nine:
                        {
                            CalLenght = 9;
                            break;
                        }
                    case PointType.FourTeen:
                        {
                            CalLenght = 14;
                            break;
                        }
                }
                switch (mCalType)
                {
                    case CalType.手动:
                        {
                            int index = 0;
                            foreach (NPoint point in mNPoint)
                            {
                                ImageX_S[index] = point.ImageX;
                                ImageY_S[index] = point.ImageY;
                                RobotX_S[index] = point.RobotX;
                                RobotY_S[index] = point.RobotY;
                                ++index;
                            }
                            break;
                        }
                    case CalType.自动:
                        if (mAutoCalCounter < CalLenght)
                        {
                            if (mInputX.Contains("数据链接") || mInputY.Contains("数据链接"))
                            {
                                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + "数据异常,请检查!");
                                return false;
                            }
                            mNPoint[mAutoCalCounter].ImageX = double.Parse(Var.GetLinkData(mSloVar, mInputX).Split('|')[2]);
                            mNPoint[mAutoCalCounter].ImageY = double.Parse(Var.GetLinkData(mSloVar, mInputY).Split('|')[2]);
                            ++mAutoCalCounter;
                            Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":第" + mAutoCalCounter + "点!");
                            ModInfo.State = ModState.OK;
                            if (mAutoCalCounter < CalLenght)
                            {
                                ModInfo.Result = false;
                                return true;
                            }
                            mAutoCalCounter = 0;
                        }
                        else
                        {
                            mAutoCalCounter = 0;
                            Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + CalLenght + "点标定：" + mAutoCalCounter + "点采集完成!");
                        }
                        break;
                }
                switch (mPointType)
                {
                    case PointType.Three:
                        {
                            List<double> ImageX = new List<double>();
                            List<double> ImageY = new List<double>();
                            List<double> RobotX = new List<double>();
                            List<double> RobotY = new List<double>();
                            foreach (NPoint point in mNPoint)
                            {
                                if (point.Index < CalLenght + 1)
                                {
                                    ImageX.Add(point.ImageX);
                                    ImageY.Add(point.ImageY);
                                    RobotX.Add(point.RobotX);
                                    RobotY.Add(point.RobotY);
                                }
                            }
                            //直线角度 ±90度***********************************************************
                            Fit.FitLine(RobotX.ToList(), RobotY.ToList(), out ROILine Line);
                            HOperatorSet.LineOrientation(Line.StartY, Line.StartX, Line.EndY, Line.EndX, out HTuple angle);
                            mPhiSingle = angle > 0 ? (angle - Math.PI / 2).D : (angle + Math.PI / 2).D;
                            //标定矩阵 保存*************************************************************
                            mHomMat2DTransl.VectorToHomMat2d(new HTuple(ImageX.ToArray()), new HTuple(ImageY.ToArray()), new HTuple(RobotX.ToArray()), new HTuple(RobotY.ToArray()));//平移矩阵
                            mCalibRms = Dis.CalRMS(mHomMat2DTransl, ImageX.ToArray(), ImageY.ToArray(), RobotX.ToArray(), RobotY.ToArray());
                            //九点标定用法：拿到标定矩阵,将需要转换的像素丢进去转换出来即机械坐标
                            //HOperatorSet.AffineTransPoint2d(mHomMat2DTransl, new HTuple(1096.1500), new HTuple(1067.4149), out HTuple AX, out HTuple AY); //九点标定测试-OK
                            SetVarList(ref mCalVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.平移矩阵, ConstVar.HomMat2D, ModInfo.Plugin, "0", 1, new HHomMat2D(mHomMat2DTransl), DataAtrr.全局变量));
                            break;
                        }
                    case PointType.Nine:
                        {
                            List<double> ImageX = new List<double>();
                            List<double> ImageY = new List<double>();
                            List<double> RobotX = new List<double>();
                            List<double> RobotY = new List<double>();
                            foreach (NPoint point in mNPoint)
                            {
                                if (point.Index < CalLenght + 1)
                                {
                                    ImageX.Add(point.ImageX);
                                    ImageY.Add(point.ImageY);
                                    RobotX.Add(point.RobotX);
                                    RobotY.Add(point.RobotY);
                                }
                            }
                            //直线角度 ±90度***********************************************************
                            Fit.FitLine(RobotX.ToList(), RobotY.ToList(), out ROILine Line);
                            HOperatorSet.LineOrientation(Line.StartY, Line.StartX, Line.EndY, Line.EndX, out HTuple angle);
                            mPhiSingle = angle > 0 ? (angle - Math.PI / 2).D : (angle + Math.PI / 2).D;
                            //标定矩阵 //平移矩阵 保存*************************************************************
                            mHomMat2DTransl.VectorToHomMat2d(new HTuple(ImageX.ToArray()), new HTuple(ImageY.ToArray()), new HTuple(RobotX.ToArray()), new HTuple(RobotY.ToArray()));
                            //RMS计算
                            mCalibRms = Dis.CalRMS(mHomMat2DTransl, ImageX.ToArray(), ImageY.ToArray(), RobotX.ToArray(), RobotY.ToArray());
                            //九点标定用法：拿到标定矩阵,将需要转换的像素丢进去转换出来即机械坐标
                            //HOperatorSet.AffineTransPoint2d(mHomMat2DTransl, new HTuple(1096.1500), new HTuple(1067.4149), out HTuple AX, out HTuple AY); //九点标定测试-OK
                            SetVarList(ref mCalVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.平移矩阵, ConstVar.HomMat2D, ModInfo.Plugin, "0", 1, new HHomMat2D(mHomMat2DTransl), DataAtrr.全局变量));
                            break;
                        }
                    case PointType.FourTeen:
                        {
                            List<double> ImageX_9 = new List<double>();
                            List<double> ImageY_9 = new List<double>();
                            List<double> RobotX_9 = new List<double>();
                            List<double> RobotY_9 = new List<double>();
                            List<double> ImageX_14 = new List<double>();
                            List<double> ImageY_14 = new List<double>();
                            List<double> RobotX_14 = new List<double>();
                            List<double> RobotY_14 = new List<double>();
                            foreach (NPoint point in mNPoint)
                            {
                                if (point.Index < 10)
                                {
                                    ImageX_9.Add(point.ImageX);
                                    ImageY_9.Add(point.ImageY);
                                    RobotX_9.Add(point.RobotX);
                                    RobotY_9.Add(point.RobotY);
                                }
                                else
                                {
                                    ImageX_14.Add(point.ImageX);
                                    ImageY_14.Add(point.ImageY);
                                    RobotX_14.Add(point.RobotX);
                                    RobotY_14.Add(point.RobotY);

                                }
                            }
                            //直线角度 ±90度***********************************************************
                            Fit.FitLine(RobotX_9.ToList(), RobotY_9.ToList(), out ROILine Line);
                            HOperatorSet.LineOrientation(Line.StartY, Line.StartX, Line.EndY, Line.EndX, out HTuple angle);
                            mPhiSingle = angle > 0 ? (angle - Math.PI / 2).D : (angle + Math.PI / 2).D;
                            //标定矩阵 //平移矩阵保存*************************************************************
                            mHomMat2DTransl.VectorToHomMat2d(new HTuple(ImageX_9.ToArray()), new HTuple(ImageY_9.ToArray()), new HTuple(RobotX_9.ToArray()), new HTuple(RobotY_9.ToArray()));  
                            //RMS计算
                            mCalibRms = Dis.CalRMS(mHomMat2DTransl, ImageX_9.ToArray(), ImageY_9.ToArray(), RobotX_9.ToArray(), RobotY_9.ToArray());
                            //九点标定用法：拿到标定矩阵,将需要转换的像素丢进去转换出来即机械坐标
                            //HOperatorSet.AffineTransPoint2d(mHomMat2DTransl, new HTuple(1096.1500), new HTuple(1067.4149), out HTuple AX, out HTuple AY); //九点标定测试-OK
                            //SetVarList(ref mCalVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.平移矩阵, ConstVar.HomMat2D, ModInfo.Plugin, "0", 1, new HHomMat2D(mHomMat2DTransl), DataAtrr.全局变量));
                            Fit.FitCircle(ImageX_14.ToArray(), ImageY_14.ToArray(), out Circle_Info 拟合圆);
                            mRotateCenterX = 拟合圆.CenterX;
                            mRotateCenterY = 拟合圆.CenterY;
                            HTuple mHomMat2DRotate = new HTuple();
                            switch (mAngleType)
                            {
                                case AngleType.固定:
                                    mCamerFix = true;
                                    //mRotateCenterX = mBaseX + 旋转中心X;
                                    //mRotateCenterY = mBaseY + 旋转中心Y;
                                    HOperatorSet.VectorAngleToRigid(拟合圆.CenterX, 拟合圆.CenterY, 0, 拟合圆.CenterX, 拟合圆.CenterY, 0, out mHomMat2DRotate);//旋转矩阵
         
                                    break;
                                case AngleType.变化:
                                    mCamerFix = false;
                                    //mRotateCenterX = (mMarkX - mBaseX) + 旋转中心X;//探针X-相机X+旋转中心X
                                    //mRotateCenterY = (mMarkY - mBaseY) + 旋转中心Y;//探针Y-相机Y+旋转中心Y 
                                    HOperatorSet.VectorAngleToRigid(拟合圆.CenterX, 拟合圆.CenterY, 0, 拟合圆.CenterX, 拟合圆.CenterY, mBaseAngle, out mHomMat2DRotate);//旋转矩阵
                                    break;
                            }
                            {//测试
                                //1)A点绕旋转中心R点旋转,求出B点的坐标
                                // vector_angle_to_rigid(B.x, B.y, 0, A’.x, A’.y, 0, HomMat2D1)
                                //affine_trans_point_2d(HomMat2D1, 0, 0, 偏移.x, 偏移.y)
                                HOperatorSet.AffineTransPoint2d(mHomMat2DRotate, new HTuple(mBaseX), new HTuple(mBaseY), out HTuple 旋转中心X, out HTuple 旋转中心Y);
                                //2)求B点到A’点的偏移
                                //vector_angle_to_rigid(B.x, B.y, 0, A’.x, A’.y, 0, HomMat2D1)
                                //affine_trans_point_2d(HomMat2D1, 0, 0, 偏移.x, 偏移.y)
                                //求B点到A’点的偏移：//旋转矩阵
                                HOperatorSet.VectorAngleToRigid(旋转中心X, 旋转中心Y, 0, mBaseX, mBaseY, 0, out mHomMat2DRotate);
                                SetVarList(ref mCalVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.旋转矩阵, ConstVar.HomMat2D, ModInfo.Plugin, "0", 1, new HHomMat2D(mHomMat2DRotate), DataAtrr.全局变量));
                                //旋转测试
                                HOperatorSet.AffineTransPoint2d(mHomMat2DRotate, new HTuple(mBaseX), new HTuple(mBaseY), out HTuple 偏移X, out HTuple 偏移Y);
                            }
                            break;
                        }
                }
                //九点标定测试-OK
                // HOperatorSet.AffineTransPoint2d(mHomMat2DTransl, new HTuple(3000), new HTuple(3000), out HTuple AAAAX, out HTuple AAAAY);
                //获取标定结果信息
                HOperatorSet.HomMat2dToAffinePar(mHomMat2DTransl, out HTuple PixelX, out HTuple PixelY, out HTuple RotationAngle, out HTuple TiltAngle, out HTuple TranslateX, out HTuple TranslateY);
                //标定信息,方便其他流程取数据：平移X,平移Y,像素当量X,像素当量Y,旋转角度,倾斜角度,RMS,旋转中心X,旋转中心Y,旋转启用,方向一致,相机固定,MarkX,MarkY,基准X,基准Y,基准角度 
                Cal_Info mCalInfo = new Cal_Info(TranslateX.D, TranslateY.D, PixelX.D, PixelY.D, RotationAngle.TupleDeg().D, TiltAngle.TupleDeg().D, mCalibRms, mRotateCenterX, mRotateCenterY, mRotateCentre, false, mCamerFix, mMarkX, mMarkY, mBaseX, mBaseX, mBaseAngle); //标定信息
                SetVarList(ref mCalVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.标定信息, ConstVar.Corde2D, ModInfo.Plugin, "0", 1, new List<Cal_Info>() { mCalInfo }, DataAtrr.全局变量));
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":平移X=" + TranslateX.D.ToString("F6") + ",平移Y=" + TranslateY.D.ToString("F6") + ",像素X=" + PixelX.D.ToString("F6") + ",像素Y=" + PixelY.D.ToString("F6") + ",切斜角度=" + TiltAngle.TupleDeg().D.ToString("F6") + ",旋转角度=" + RotationAngle.TupleDeg().D.ToString("F6"));
                //UINotifierHelper.ShowInfoNotifier(Form.ActiveForm, mAutoCalCounter + "标定完成!");
                ModInfo.State = ModState.OK;
                return ModInfo.Result = true;
            }
            catch (Exception ex)
            {
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + ex.Message);
                //UINotifierHelper.ShowInfoNotifier(Form.ActiveForm, ex.Message);
                ModInfo.State = ModState.NG;
                return ModInfo.Result = false;
            }
        }
        public override void RunForm(ObjBase baseMod)
        {
            try
            {
                new NPointCalForm((NPointCalObj)baseMod).ShowDialog();
            }
            catch (Exception ex)
            {
                Log.Error(ModInfo.Name + ":" + ex.Message);
            }
        }
    }
}
