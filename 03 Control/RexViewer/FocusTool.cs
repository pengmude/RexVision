using HalconDotNet;
using System;

namespace RexView
{
    public class FocusTool
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ho_Image"></param>
        /// <param name="hv_Method">
        /// *Tenegrad    Tenegrad函数法 对于高像素的图片,如2900W,该算法时间约为100ms,其他均大于200ss
        /// *Deviation   '方差法
        /// *laplace    '拉普拉斯能量函数
        /// *energy     '能量梯度函数  效果最好
        /// *Brenner    ' Brenner函数法
        /// </param>
        /// <param name="hv_Value"></param>
        public static double evaluate_definition(HObject ho_Image, HTuple hv_Method)
        {

            // Stack for temporary objects 
            HObject[] OTemp = new HObject[20];

            // Local iconic variables 

            HObject ho_ImageMean = null, ho_ImageSub = null;
            HObject ho_ImageResult = null, ho_ImageLaplace4 = null, ho_ImageLaplace8 = null;
            HObject ho_ImageResult1 = null, ho_ImagePart00 = null, ho_ImagePart01 = null;
            HObject ho_ImagePart10 = null, ho_ImageSub1 = null, ho_ImageSub2 = null;
            HObject ho_ImageResult2 = null, ho_ImagePart20 = null, ho_EdgeAmplitude = null;
            HObject ho_Region1 = null, ho_BinImage = null, ho_ImageResult4 = null;

            // Local copy input parameter variables 
            HObject ho_Image_COPY_INP_TMP;
            ho_Image_COPY_INP_TMP = ho_Image.CopyObj(1, -1);



            // Local control variables 
            HTuple hv_Value = new HTuple();
            HTuple hv_Width = null, hv_Height = null, hv_Deviation = new HTuple();
            HTuple hv_Min = new HTuple(), hv_Max = new HTuple(), hv_Range = new HTuple();
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_ImageMean);
            HOperatorSet.GenEmptyObj(out ho_ImageSub);
            HOperatorSet.GenEmptyObj(out ho_ImageResult);
            HOperatorSet.GenEmptyObj(out ho_ImageLaplace4);
            HOperatorSet.GenEmptyObj(out ho_ImageLaplace8);
            HOperatorSet.GenEmptyObj(out ho_ImageResult1);
            HOperatorSet.GenEmptyObj(out ho_ImagePart00);
            HOperatorSet.GenEmptyObj(out ho_ImagePart01);
            HOperatorSet.GenEmptyObj(out ho_ImagePart10);
            HOperatorSet.GenEmptyObj(out ho_ImageSub1);
            HOperatorSet.GenEmptyObj(out ho_ImageSub2);
            HOperatorSet.GenEmptyObj(out ho_ImageResult2);
            HOperatorSet.GenEmptyObj(out ho_ImagePart20);
            HOperatorSet.GenEmptyObj(out ho_EdgeAmplitude);
            HOperatorSet.GenEmptyObj(out ho_Region1);
            HOperatorSet.GenEmptyObj(out ho_BinImage);
            HOperatorSet.GenEmptyObj(out ho_ImageResult4);
            hv_Value = new HTuple();
            try
            {
                {
                    HObject ExpTmpOutVar_0;
                    HOperatorSet.ScaleImageMax(ho_Image_COPY_INP_TMP, out ExpTmpOutVar_0);
                    ho_Image_COPY_INP_TMP.Dispose();
                    ho_Image_COPY_INP_TMP = ExpTmpOutVar_0;
                }
                HOperatorSet.GetImageSize(ho_Image_COPY_INP_TMP, out hv_Width, out hv_Height);

                if ((int)(new HTuple(hv_Method.TupleEqual("Deviation"))) != 0)
                {
                    //方差法
                    ho_ImageMean.Dispose();
                    HOperatorSet.RegionToMean(ho_Image_COPY_INP_TMP, ho_Image_COPY_INP_TMP, out ho_ImageMean
                        );
                    {
                        HObject ExpTmpOutVar_0;
                        HOperatorSet.ConvertImageType(ho_ImageMean, out ExpTmpOutVar_0, "real");
                        ho_ImageMean.Dispose();
                        ho_ImageMean = ExpTmpOutVar_0;
                    }
                    {
                        HObject ExpTmpOutVar_0;
                        HOperatorSet.ConvertImageType(ho_Image_COPY_INP_TMP, out ExpTmpOutVar_0,
                            "real");
                        ho_Image_COPY_INP_TMP.Dispose();
                        ho_Image_COPY_INP_TMP = ExpTmpOutVar_0;
                    }
                    ho_ImageSub.Dispose();
                    HOperatorSet.SubImage(ho_Image_COPY_INP_TMP, ho_ImageMean, out ho_ImageSub,
                        1, 0);
                    ho_ImageResult.Dispose();
                    HOperatorSet.MultImage(ho_ImageSub, ho_ImageSub, out ho_ImageResult, 1, 0);
                    HOperatorSet.Intensity(ho_ImageResult, ho_ImageResult, out hv_Value, out hv_Deviation);

                }
                else if ((int)(new HTuple(hv_Method.TupleEqual("laplace"))) != 0)
                {
                    //拉普拉斯能量函数
                    ho_ImageLaplace4.Dispose();
                    HOperatorSet.Laplace(ho_Image_COPY_INP_TMP, out ho_ImageLaplace4, "signed",
                        3, "n_4");
                    ho_ImageLaplace8.Dispose();
                    HOperatorSet.Laplace(ho_Image_COPY_INP_TMP, out ho_ImageLaplace8, "signed",
                        3, "n_8");
                    ho_ImageResult1.Dispose();
                    HOperatorSet.AddImage(ho_ImageLaplace4, ho_ImageLaplace4, out ho_ImageResult1,
                        1, 0);
                    {
                        HObject ExpTmpOutVar_0;
                        HOperatorSet.AddImage(ho_ImageLaplace4, ho_ImageResult1, out ExpTmpOutVar_0,
                            1, 0);
                        ho_ImageResult1.Dispose();
                        ho_ImageResult1 = ExpTmpOutVar_0;
                    }
                    {
                        HObject ExpTmpOutVar_0;
                        HOperatorSet.AddImage(ho_ImageLaplace8, ho_ImageResult1, out ExpTmpOutVar_0,
                            1, 0);
                        ho_ImageResult1.Dispose();
                        ho_ImageResult1 = ExpTmpOutVar_0;
                    }
                    ho_ImageResult.Dispose();
                    HOperatorSet.MultImage(ho_ImageResult1, ho_ImageResult1, out ho_ImageResult,
                        1, 0);
                    HOperatorSet.Intensity(ho_ImageResult, ho_ImageResult, out hv_Value, out hv_Deviation);

                }
                else if ((int)(new HTuple(hv_Method.TupleEqual("energy"))) != 0)
                {
                    //能量梯度函数
                    ho_ImagePart00.Dispose();
                    HOperatorSet.CropPart(ho_Image_COPY_INP_TMP, out ho_ImagePart00, 0, 0, hv_Width - 1,
                        hv_Height - 1);
                    ho_ImagePart01.Dispose();
                    HOperatorSet.CropPart(ho_Image_COPY_INP_TMP, out ho_ImagePart01, 0, 1, hv_Width - 1,
                        hv_Height - 1);
                    ho_ImagePart10.Dispose();
                    HOperatorSet.CropPart(ho_Image_COPY_INP_TMP, out ho_ImagePart10, 1, 0, hv_Width - 1,
                        hv_Height - 1);
                    {
                        HObject ExpTmpOutVar_0;
                        HOperatorSet.ConvertImageType(ho_ImagePart00, out ExpTmpOutVar_0, "real");
                        ho_ImagePart00.Dispose();
                        ho_ImagePart00 = ExpTmpOutVar_0;
                    }
                    {
                        HObject ExpTmpOutVar_0;
                        HOperatorSet.ConvertImageType(ho_ImagePart10, out ExpTmpOutVar_0, "real");
                        ho_ImagePart10.Dispose();
                        ho_ImagePart10 = ExpTmpOutVar_0;
                    }
                    {
                        HObject ExpTmpOutVar_0;
                        HOperatorSet.ConvertImageType(ho_ImagePart01, out ExpTmpOutVar_0, "real");
                        ho_ImagePart01.Dispose();
                        ho_ImagePart01 = ExpTmpOutVar_0;
                    }
                    ho_ImageSub1.Dispose();
                    HOperatorSet.SubImage(ho_ImagePart10, ho_ImagePart00, out ho_ImageSub1, 1,
                        0);
                    ho_ImageResult1.Dispose();
                    HOperatorSet.MultImage(ho_ImageSub1, ho_ImageSub1, out ho_ImageResult1, 1,
                        0);
                    ho_ImageSub2.Dispose();
                    HOperatorSet.SubImage(ho_ImagePart01, ho_ImagePart00, out ho_ImageSub2, 1,
                        0);
                    ho_ImageResult2.Dispose();
                    HOperatorSet.MultImage(ho_ImageSub2, ho_ImageSub2, out ho_ImageResult2, 1,
                        0);
                    ho_ImageResult.Dispose();
                    HOperatorSet.AddImage(ho_ImageResult1, ho_ImageResult2, out ho_ImageResult,
                        1, 0);
                    HOperatorSet.Intensity(ho_ImageResult, ho_ImageResult, out hv_Value, out hv_Deviation);
                }
                else if ((int)(new HTuple(hv_Method.TupleEqual("Brenner"))) != 0)
                {
                    //Brenner函数法
                    ho_ImagePart00.Dispose();
                    HOperatorSet.CropPart(ho_Image_COPY_INP_TMP, out ho_ImagePart00, 0, 0, hv_Width,
                        hv_Height - 2);
                    {
                        HObject ExpTmpOutVar_0;
                        HOperatorSet.ConvertImageType(ho_ImagePart00, out ExpTmpOutVar_0, "real");
                        ho_ImagePart00.Dispose();
                        ho_ImagePart00 = ExpTmpOutVar_0;
                    }
                    ho_ImagePart20.Dispose();
                    HOperatorSet.CropPart(ho_Image_COPY_INP_TMP, out ho_ImagePart20, 2, 0, hv_Width,
                        hv_Height - 2);
                    {
                        HObject ExpTmpOutVar_0;
                        HOperatorSet.ConvertImageType(ho_ImagePart20, out ExpTmpOutVar_0, "real");
                        ho_ImagePart20.Dispose();
                        ho_ImagePart20 = ExpTmpOutVar_0;
                    }
                    ho_ImageSub.Dispose();
                    HOperatorSet.SubImage(ho_ImagePart20, ho_ImagePart00, out ho_ImageSub, 1,
                        0);
                    ho_ImageResult.Dispose();
                    HOperatorSet.MultImage(ho_ImageSub, ho_ImageSub, out ho_ImageResult, 1, 0);
                    HOperatorSet.Intensity(ho_ImageResult, ho_ImageResult, out hv_Value, out hv_Deviation);
                }
                else if ((int)(new HTuple(hv_Method.TupleEqual("Tenegrad"))) != 0)
                {
                    //Tenegrad函数法
                    ho_EdgeAmplitude.Dispose();
                    HOperatorSet.SobelAmp(ho_Image_COPY_INP_TMP, out ho_EdgeAmplitude, "sum_sqrt",
                        3);
                    HOperatorSet.MinMaxGray(ho_EdgeAmplitude, ho_EdgeAmplitude, 0, out hv_Min,
                        out hv_Max, out hv_Range);
                    ho_Region1.Dispose();
                    HOperatorSet.Threshold(ho_EdgeAmplitude, out ho_Region1, 11.8, 255);
                    ho_BinImage.Dispose();
                    HOperatorSet.RegionToBin(ho_Region1, out ho_BinImage, 1, 0, hv_Width, hv_Height);
                    ho_ImageResult4.Dispose();
                    HOperatorSet.MultImage(ho_EdgeAmplitude, ho_BinImage, out ho_ImageResult4,
                        1, 0);
                    ho_ImageResult.Dispose();
                    HOperatorSet.MultImage(ho_ImageResult4, ho_ImageResult4, out ho_ImageResult,
                        1, 0);
                    HOperatorSet.Intensity(ho_ImageResult, ho_ImageResult, out hv_Value, out hv_Deviation);

                }
                else if ((int)(new HTuple(hv_Method.TupleEqual("2"))) != 0)
                {

                }
                else if ((int)(new HTuple(hv_Method.TupleEqual("3"))) != 0)
                {

                }
                if (HDevWindowStack.IsOpen())
                {
                    HOperatorSet.DispObj(ho_ImageResult, HDevWindowStack.GetActive());
                }
                ho_Image_COPY_INP_TMP.Dispose();
                ho_ImageMean.Dispose();
                ho_ImageSub.Dispose();
                ho_ImageResult.Dispose();
                ho_ImageLaplace4.Dispose();
                ho_ImageLaplace8.Dispose();
                ho_ImageResult1.Dispose();
                ho_ImagePart00.Dispose();
                ho_ImagePart01.Dispose();
                ho_ImagePart10.Dispose();
                ho_ImageSub1.Dispose();
                ho_ImageSub2.Dispose();
                ho_ImageResult2.Dispose();
                ho_ImagePart20.Dispose();
                ho_EdgeAmplitude.Dispose();
                ho_Region1.Dispose();
                ho_BinImage.Dispose();
                ho_ImageResult4.Dispose();

                return Double.Parse(hv_Value.D.ToString("f3"));
            }
            catch (HalconException HDevExpDefaultException)
            {
                ho_Image_COPY_INP_TMP.Dispose();
                ho_ImageMean.Dispose();
                ho_ImageSub.Dispose();
                ho_ImageResult.Dispose();
                ho_ImageLaplace4.Dispose();
                ho_ImageLaplace8.Dispose();
                ho_ImageResult1.Dispose();
                ho_ImagePart00.Dispose();
                ho_ImagePart01.Dispose();
                ho_ImagePart10.Dispose();
                ho_ImageSub1.Dispose();
                ho_ImageSub2.Dispose();
                ho_ImageResult2.Dispose();
                ho_ImagePart20.Dispose();
                ho_EdgeAmplitude.Dispose();
                ho_Region1.Dispose();
                ho_BinImage.Dispose();
                ho_ImageResult4.Dispose();

                throw HDevExpDefaultException;
            }
        }
    }
}
