using RexConst;
using HalconDotNet;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using VisionCore;


namespace Plugin.Matching
{
    [Category("检测识别")]
    [DisplayName("模板匹配")]
    [Serializable]
    public class MatchingObj : ObjBase
    {
        /// <summary> 图像名称</summary>
        public string mImages = "数据链接";
        /// <summary> 链接区域</summary>
        public string mLinkRoi = "数据链接";
        /// <summary> 链接区域</summary>
        public string mStarX = "0";
        /// <summary> 链接区域</summary>
        public string mStarY = "0";
        /// <summary> 链接区域</summary>
        public string mEndX = "100";
        /// <summary> 链接区域</summary>
        public string mEndY = "100";

        /// <summary> 模板图像 </summary>
        public HHandle mModelImage;
        /// <summary> 模板类型 </summary>
        public ModelType mModelType;
        /// <summary> 链接类型 </summary>
        public LinkType mLinkType;
        /// <summary> 排序类型 </summary>
        public SortType mSortType;
        /// <summary> 匹配坐标</summary>
        public Coord_Info mMathCoord = new Coord_Info();
        /// <summary> 模板坐标</summary>
        public Coord_Info mModeCoord = new Coord_Info();
        /// <summary> 修改坐标</summary>
        public Coord_Info mChangCoord = new Coord_Info();
        /// <summary> 最小分数 </summary>
        public double mMinScore = 0.5;
        /// <summary> 匹配个数 </summary>
        public int mMathNumb = 1;
        /// <summary>最大重叠</summary>
        public double mMaxOverl = 0.5;
        /// <summary>贪心算法</summary>
        public double mGreedDeg = 0.9;


        /// <summary>金字塔起始层</summary>
        public int mStarLevels = 0;
        /// <summary>金字塔结束层</summary>
        public int mOverLevels = 0;

        /// <summary> 梯度阈值</summary>
        public int mThreshold = 30;
        /// <summary>最小长度</summary>
        public double mMinLenght = 20;
        /// <summary> 起始角度 </summary>
        public double mStarPhi = -180f;
        /// <summary> 结束角度</summary>
        public double mOverPhi = 180f;

        /// <summary>最小缩放比率</summary>
        public double mMinScale = 0.8;
        /// <summary>最大缩放比率</summary>
        public double mMaxScale = 1.1;
        /// <summary>对比极性</summary>        // ignore_color_polarity 忽略颜色极性,ignore_global_polarity 忽视全球极性,ignore_local_polarity 无视当地的极性
        public CompType mCompType = CompType.一致; //"use_polarity";//'ignore_color_polarity', 'ignore_global_polarity', 'ignore_local_polarity',
        /// <summary>编辑模式</summary>
        public EditType mEditType = EditType.正常显示;
        /// <summary>亚像素模式</summary>
        public string mSubPixel = "least_squares";//least_squares least_squares_high  least_squares_very_high
        /// <summary> 区域列表 </summary>
        public Dictionary<string, RexView.ROI> mRoiList = new Dictionary<string, RexView.ROI>();
        /// <summary> 生成模板</summary>
        public void CreateModel()
        {
            if (mImages == null)
            {
                Log.Info( ModInfo.Name + ":无图像！" );
                return;
            }
            RexView.ROI ModelSearch = mRoiList[ModInfo.Name + ROIDefine.Search];
            RexView.ROI ModelTemplet = mRoiList[ModInfo.Name + ROIDefine.Templet];
            Find.CreateModel(mModelType, mRImage.ReduceDomain(ModelSearch.GetRegion()), ModelTemplet, mThreshold, mStarLevels, mStarPhi, mOverPhi,mMinScale, mMaxScale, mCompType, ref mModelImage);
            Find.FindModel(mModelType, mRImage.ReduceDomain(ModelSearch.GetRegion()), mModelImage,mMinScore, mMathNumb, mMaxOverl, mGreedDeg, out mModeCoord);
            Log.Info( ModInfo.Name + ":创建模板成功！" );
        }
        public override bool RunObj()
        {
            try
            {
                if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
                {
                    ModInfo.State = ModState.NoImage;
                    return false;
                }
                RexView.ROI ModelSearch = mRoiList[ModInfo.Name + ROIDefine.Search];
                RexView.ROI ModelTemplet = mRoiList[ModInfo.Name + ROIDefine.Templet];
                if (Find.FindModel(mModelType, mRImage.ReduceDomain(ModelSearch.GetRegion()), mModelImage, mMinScore, mMathNumb, mMaxOverl, mGreedDeg, out mMathCoord) > 0)
                {
                    //仿射变换-检测结果
                    HTuple tempMat2D = new HTuple();
                    HOperatorSet.VectorAngleToRigid(0, 0, 0, mMathCoord.Y, mMathCoord.X, mMathCoord.Phi, out tempMat2D);
                    //检测结果-对XLD应用任意加法 2D 变换
                    HXLDCont contour_xld = ((HShapeModel)mModelImage).GetShapeModelContours(1).AffineTransContourXld(new HHomMat2D(tempMat2D));


                    //检测中心-为输入点生成一个十字形状的 XLD 轮廓
                    HOperatorSet.GenCrossContourXld(out HObject cross, mMathCoord.Y, mMathCoord.X, 10, mMathCoord.Phi);
                    //仿射变换-检测范围
                    HOperatorSet.VectorAngleToRigid(mModeCoord.Y, mModeCoord.X, mModeCoord.Phi, mMathCoord.Y, mMathCoord.X,mMathCoord.Phi, out HTuple homMat2D);
                    //检测范围-对XLD应用任意加法 2D 变换
                    HXLDCont modelRegionXLD = ModelTemplet.GetXLD().AffineTransContourXld(new HHomMat2D(homMat2D));
                    //roi显示----------------------------------------------------------------------------------------------------------------------------------------------------------
                    mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Plugin, ModInfo.Remarks, HRoiType.参考坐标, "red", new HObject(Gen.GetCoord(mRImage, mMathCoord))));
                    if (ShowROI)
                    {
                        mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测中心, "cyan", new HObject(cross)));
                        mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, "green", new HObject(contour_xld)));
                        mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.搜索范围, "blue", new HObject(ModelSearch.GetRegion())));
                    }
                    mMathCoord.Phi = mMathCoord.Phi - mModeCoord.Phi;
                    mMathCoord.Status = true;
                    SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.坐标系, ConstVar.Coord, ModInfo.Plugin, "0", 1, mMathCoord, DataAtrr.全局变量));
                    Log.Info( Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + mMathCoord.X + "," + mMathCoord.Y + "," + mMathCoord.Phi );
                    ModInfo.State = ModState.OK;
                }
                else
                {
                    mMathCoord.Status = false;
                    mRImage.mHRoi.Clear();
                    SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.坐标系, ConstVar.Coord, ModInfo.Plugin, "0", 1, mMathCoord, DataAtrr.全局变量));
                    ModInfo.State = ModState.NG;
                }
            }
            catch (Exception ex)
            {
                mMathCoord.Status = false;
                ModInfo.State = ModState.NG;
                Log.Error( ModInfo.Name + ex.Message );
            }
            return true;
        }
        public override void RunForm(ObjBase BaseMod)
        {
            try
            {
                new MatchingForm((MatchingObj)BaseMod).ShowDialog();
            }
            catch (Exception ex)
            {
                Log.Error(ModInfo.Name + ":" + ex.Message);
            }
        }
        override public void SetInfo() { }
    }
}
