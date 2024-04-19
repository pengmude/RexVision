using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;
using VisionCore;

using RexConst;

namespace Plugin.DistortionCalib
{
    [Category("标定工具")]
    [DisplayName("畸变标定")]
    [Serializable]
    public class DistortionCalibObj : ObjBase
    {        
        /// <summary>需要畸变标定的图像名称</summary>
        public string mImages;
        #region 区域标定映射

        /// <summary>采集当前图像时候的位置X</summary>
        public double X { get; set; }
        /// <summary>采集当前图像时候的位置Y</summary>
        public double Y { get; set; }
        /// <summary>采集当前图像时候的位置Z</summary>
        public double Z { get; set; }
        /// <summary>是否标定</summary>
        public bool Calibrated { get; set; }
        public bool DistortionCalib { get; set; }
        /// <summary>畸变模式</summary>
        public string DistortionMode { get; set; }
        /// <summary>标定用的图像</summary>
        public HImage DistortionImage = new HImage();
        /// <summary>显示轮廓</summary>
        [NonSerialized]
        public HXLDCont xldMark;
        public List<HRoi> mHRoi = new List<HRoi>();
        #endregion
        /// <summary>
        /// 生成标定数据
        /// </summary>
        public override bool RunObj()
        {
            try
            {
                if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
                {
                    ModInfo.State = ModState.NoImage;
                    return false;
                }
                //edges_sub_pix(Image, Edges, 'canny', 1, 20, 40)
                //segment_contours_xld(Edges, ContoursSplit, 'lines_circles', 5, 4, 2)
                //select_shape_xld(ContoursSplit, SelectedXLD, 'contlength', 'and', 60, 99999)
                //get_image_size(Image, Width, Height)
                //* DistortionModel 重点能修改这两个参数
                // * PrincipalPointVar 修改为1后,明显会提高成功率
                //radial_distortion_self_calibration(SelectedXLD, SelectedContours, Width, Height, 0.05, 42, 'division', 'variable', 0, CameraParam3)
                //get_domain(Image, Domain)
                //change_radial_distortion_cam_par('fixed', CameraParam3, 0, CamParamOut3)
                //change_radial_distortion_image(Image, Domain, ImageRectified3, CameraParam3, CamParamOut3)
                HTuple Width, Height, CameraParam3, CamParamOut3;
                HObject GrayImage, Edges, ContoursSplit, SelectedXLD, SelectedContours = null, Domain, ImageRectified3;
                HOperatorSet.Rgb1ToGray(mRImage, out GrayImage);
                HOperatorSet.EdgesSubPix(GrayImage, out Edges, "sobel_fast", 1, 20, 40);//canny-sobel_fast

                HOperatorSet.SegmentContoursXld(Edges, out ContoursSplit, "lines_circles", 5, 4, 2);
                HOperatorSet.SelectShapeXld(ContoursSplit, out SelectedXLD, "contlength", "and", 60, 99999);
                HOperatorSet.GetImageSize(GrayImage, out Width, out Height);
                //* DistortionModel 重点能修改这两个参数:polynomial-division
                // * PrincipalPointVar 修改为1后,明显会提高成功率
                HOperatorSet.RadialDistortionSelfCalibration(SelectedXLD, out SelectedContours, Width, Height, 0.05, 42, "division", "variable", 1, out CameraParam3);
                HOperatorSet.GetDomain(GrayImage, out Domain);

                HOperatorSet.ChangeRadialDistortionCamPar(DistortionMode.ToString(), CameraParam3, 0, out CamParamOut3);
                HOperatorSet.ChangeRadialDistortionImage(GrayImage, Domain, out ImageRectified3, CameraParam3, CamParamOut3);
                Find.ToHImage(ImageRectified3, out DistortionImage);
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.图像, ConstVar.Image, ModInfo.Plugin, "0", 1, DistortionImage, DataAtrr.系统变量));
                DistortionCalib = true;
                ModInfo.State = ModState.OK;
            }
            catch (Exception ex)
            {
                ModInfo.State = ModState.NG;
               Log.Error(Name + ":" + ModInfo.Name + ex.ToString() );
                return false;
            }
            return true;
        }
        public override void RunForm(ObjBase baseMod)
        {
           new DistortionCalibForm((DistortionCalibObj)baseMod).ShowDialog();
        }
    }
}
