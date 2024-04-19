using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using VisionCore;


using RexConst;
/*
参考halcon示例:find_text_dongle.hdev   
当前正邦软件ocr参数有 
1.字符宽度 
2.字符高度
3.笔画宽度
4.最小片段
5.行最大数量
6.字符数量
7.基线公差
8.黑色背景
9.存在标点符号
10.全大写
11.联通片段
12.去除背景横线
*/
namespace Plugin.OCR
{
    [Category("检测识别")]
    [DisplayName("字符识别")]
    [Serializable]
    public class OCRObj : ObjBase
    {
        /// <summary>
        /// 结果列表
        /// </summary>
        public List<Rect2_Info> m_Rectangle2List = new List<Rect2_Info>();
        /// <summary>
        /// OCR分类器
        /// </summary>
        enum Classifier
        {
            MPL,
            CNN
        }
        /// <summary>
        ///检测结果轮廓
        /// </summary>
        [NonSerialized]
        public HObject m_ResultXLD = new HObject();
        /// <summary>
        /// 文本读取,不支持序列化
        /// </summary>
        [NonSerialized]
        HTextModel textModel = new HTextModel();
        /// <summary>
        /// OCR分类器枚举
        /// </summary>
        [NonSerialized]
        Classifier m_ClassiFier;
        /// <summary>
        /// 查找到的文字结果
        /// </summary>
        [NonSerialized]
        private HObject textHObject;


        /// <summary>
        /// OCR分类器
        /// </summary>
        [NonSerialized]
        HOCRMlp ocrMpl = new HOCRMlp();
        /// <summary>
        /// OCR分类器
        /// </summary>
        [NonSerialized]
        HOCRCnn ocrCnn = new HOCRCnn();
        /// <summary>
        /// 字库路径
        /// </summary>
        public string m_OcrPath = "";
        /// <summary>
        /// 字库名称
        /// </summary>
        public string m_OcrName = "";
        /// <summary>
        /// 选取的处理图像
        /// </summary>
        public string mImages = "";
        /// <summary>
        /// 位置补正的单元ID
        /// </summary>
        public int mHomMatID = -1;
        /// <summary>
        /// 返回结果
        /// </summary>
        public string m_TextResultID = "";
        /// <summary>
        /// 模板区域
        /// </summary>
        public ROI m_ModelRegion;
        /// <summary>
        /// 搜索区域
        /// </summary>
        public ROI m_SearchRegion;
        public double m_ModelRegionSpaceX;
        public double m_ModelRegionSpaceY;


        /// <summary>
        /// 最小对比度,默认值15
        /// </summary>
        public double m_minContrast = 15;
        /// <summary>
        /// 文字极性 默认为both
        /// </summary>
        public string m_polarity = "dark_on_light";
        /// <summary>
        /// 最小文字宽度 
        /// </summary>
        public int m_minCharWidth = 5;
        /// <summary>
        /// 最大文字宽度 
        /// </summary>
        public int m_maxCharWidth = 15;
        /// <summary>
        /// 最小文字高度 
        /// </summary>
        public int m_minCharHeight = 10;
        /// <summary>
        /// 最大文字g高度 
        /// </summary>
        public int m_maxCharHeight = 50;
        /// <summary>
        /// 最小笔画
        /// </summary>
        public int m_minStrokeWidth = 6;
        /// <summary>
        /// 最大笔画
        /// </summary>
        public int m_maxStrokeWidth = 4;
        /// <summary>
        /// 文本结构
        /// </summary>
        public string m_textLineStructure = "2 2 2";
        /// <summary>
        /// 分隔符
        /// </summary>
        public string m_textLineSeparators = "";
        /// <summary>
        /// 正则表达式
        /// </summary>
        public string m_expression = "([A-Z]{2}[0-9]{6}/[0-9]{4})";
        /// <summary>
        /// 是否点阵字体
        /// </summary>
        public string m_isDotPrint = "false";
        /// <summary>
        /// 是否识别I
        /// </summary>
        public string m_isAddFragments = "false";
        public override bool RunObj()
        {
            //Circle_Info tempCircle = new Circle_Info();
            HRegion tempDisableRegion = new HRegion();//仿射变换后的屏蔽区域
            try
            {
                if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
                {
                    ModInfo.State = ModState.NoImage;
                    return false;
                }

                Coord_Info coord = new Coord_Info();
                if (mHomMatID != -1)
                {
                    coord = ((List<Coord_Info>)mSloVar.FirstOrDefault(c => c.mModIndex == mHomMatID).mDataValue)[0];
                    HHomMat2D homMat2D = new HHomMat2D();
                    homMat2D = homMat2D.HomMat2dRotateLocal(-coord.Phi);
                    homMat2D = homMat2D.HomMat2dTranslate(coord.X, coord.Y);
                    HXLDCont CoordXLD = Gen.GetCoord(mRImage, coord);
                    HRoi roi坐标系 = new HRoi(this.ModInfo.Encode, this.ModInfo.Name.ToString(), ModInfo.Remarks,HRoiType.参考坐标, "green", new HObject(CoordXLD));
                    mRImage.ShowHRoi(roi坐标系);
                }
                else
                {
                    coord = new Coord_Info();
                }
                //执行检测
                CreateOCRTool();

                RImage hImage = mRImage;
                //HOperatorSet.BinaryThreshold(hImage, out HObject region, "max_separability", "dark", out HTuple usedThreshold);
                //HOperatorSet.FindText(mRImage, textModel, out HTuple TextResultID); /*m_TextResultID*/

                HTextResult textResult = textModel.FindText(mRImage);
                //判断查找到的文字的行数来判断是否找到文字
                HTuple numLines = textResult.GetTextResult("class");
                if (textHObject != null && textHObject.IsInitialized())
                {
                    textHObject.Dispose();
                }
                //使用正则表达式来筛选文字
                textHObject = textResult.GetTextObject("all_lines");
                HTuple r1 = textResult.GetTextResult("class");
                HTuple confidence = null;

                //查找到的字符串
                HTuple resultClass = "";
                HTuple word = null, score = null;
                switch (m_ClassiFier)
                {
                    case Classifier.MPL:
                        HOperatorSet.DoOcrWordMlp(textHObject, hImage, ocrMpl, m_expression.Trim(),
               3, 5, out resultClass, out confidence, out word, out score);
                        break;
                    case Classifier.CNN:
                        HOperatorSet.DoOcrWordCnn(textHObject, hImage, ocrCnn, m_expression.Trim(),
               3, 5, out resultClass, out confidence, out word, out score);
                        break;
                    default:
                        break;
                }
                //取信心与正则表达式的最小值来作为最后识别结果的分值
                HTuple scoreTmp = new HTuple(confidence, score);
                //结果分数
                string Result = scoreTmp.TupleMin().D.ToString("f2");
                if (word.Length > 0)
                {
                    m_TextResultID = word;
                }
               Log.Info( ModInfo.Name + "内容：" + m_TextResultID );

                //ToDO:ROI显示
                HTuple Area, Row, Column;
                HOperatorSet.AreaCenter(textHObject, out Area, out Row, out Column);

                HXLDCont m_cross = new HXLDCont();
                mRImage.mHRoi.Clear();
                mRImage.mHText.Clear();
                HRoi[] roi检测结果 = new HRoi[Area.Length];
                HRoi[] roi检测中心 = new HRoi[Area.Length];
                HRoi[] roi检测范围 = new HRoi[Area.Length];
                HText[] roi文字显示 = new HText[Area.Length];

                for (int i = 0; i < Area.Length; i++)
                {
                    roi检测结果[i] = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks,HRoiType.检测结果, "red", new HObject(textHObject), true);
                    //roi检测中心----------------------------------------------------------------------------------------------------------------------------------------------------------
                    m_cross.GenCrossContourXld(Row.DArr[i], Column.DArr[i], 6, Area.LArr[i]);
                    roi检测中心[i] = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测中心,"red", new HObject(m_cross), true);
                    //roi检测范围----------------------------------------------------------------------------------------------------------------------------------------------------------
                    Rect2_Info m_ArrarRegion = new Rect2_Info(Row.DArr[i], Column.DArr[i], Area.LArr[i], Math.Abs(m_ModelRegionSpaceY), Math.Abs(m_ModelRegionSpaceX));
                    roi检测范围[i] = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测范围,"green", new HObject(hImage), true);
                    //if (m_cbarray)
                    {
                        //roi文字显示----------------------------------------------------------------------------------------------------------------------------------------------------------
                        roi文字显示[i] = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示,"red", resultClass.SArr[i].ToString(), "mono", Row.DArr[i], Column.DArr[i], 30, new HObject(textHObject), true);
                    }
                }
                if (ShowResult)
                {
                    for (int j = 0; j < roi检测结果.Length; ++j)
                    {
                        //mRImage.ShowHRoi(roi检测结果[j]);
                    }
                }
                if (ShowArea)
                {
                    for (int j = 0; j < roi检测范围.Length; ++j)
                    {
                        //mRImage.ShowHRoi(roi检测中心[j]);
                        mRImage.ShowHText(roi文字显示[j]);
                    }
                }
                this.ModInfo.State = ModState.OK;
            }
            catch (Exception ex)
            {
               Log.Error( ModInfo.Name + ex.Message);
                this.ModInfo.State = ModState.NG;
            }
            try
            {
                //    runStatu = Configuration.language == Language.English ? OCRToolRunStatu.Not_Succeed : OCRToolRunStatu.失败;
                //    if (inputImage == null)
                //    {
                //        runStatu = Configuration.language == Language.English ? OCRToolRunStatu.Character_Untrained : OCRToolRunStatu.未指定输入图像;
                //        return;
                //    }
                //    if (!isCreated)
                //    {
                //        runStatu = Configuration.language == Language.English ? OCRToolRunStatu.Character_Untrained : OCRToolRunStatu.未训练字符;
                //        return;
                //    }

                //    HOperatorSet.ReduceDomain(standardImage, searchRegion, out imageReduced);
                //    HObject region;
                //    HOperatorSet.Threshold(imageReduced, out region, 0, 128);
                //    HObject ConnectedRegions;
                //    HOperatorSet.Connection(region, out ConnectedRegions);
                //    HObject SelectedRegions;
                //    HOperatorSet.SelectShape(ConnectedRegions, out SelectedRegions, new HTuple("area"), "and", 10, 99999);
                //    HObject RegionUnion1;
                //    HOperatorSet.Union1(SelectedRegions, out RegionUnion1);
                //    HObject RegionDilation;
                //    HOperatorSet.DilationCircle(RegionUnion1, out RegionDilation, 1);
                //    HObject RegionUnion;
                //    HOperatorSet.Union1(RegionDilation, out RegionUnion);
                //    HObject ConnectedRegions1;
                //    HOperatorSet.Connection(RegionUnion, out ConnectedRegions1);
                //    HObject RegionIntersection;
                //    HOperatorSet.Intersection(ConnectedRegions1, RegionUnion1, out RegionIntersection);
                //    HObject SortedRegions;
                //    HOperatorSet.SortRegion(RegionIntersection, out SortedRegions, "character", "true", "column");

                //    HTuple charList = new HTuple();
                //    HTuple confidence = new HTuple();
                //    try
                //    {
                //        HOperatorSet.DoOcrMultiClassMlp(SortedRegions, imageReduced, modelID, out charList, out confidence);
                //    }
                //    catch
                //    {
                //        Train();        //程序重启句柄会失效，需要重新训练字符
                //    }

                //    string result = string.Empty;
                //    for (int i = 0; i < charList.Length; i++)
                //    {
                //        result += charList[i];
                //    }

                //    Frm_OCRTool.Instance.tbx_resultStr.Text = result;
                //    HOperatorSet.SetColor(GetWindowHandle(jobName), new HTuple("blue"));
                //    if (searchRegion != null)
                //        ShowObj(jobName, searchRegion);

                //    outputStr = result;
                //    runStatu = Configuration.language == Language.English ? OCRToolRunStatu.Succeed : OCRToolRunStatu.成功;
            }
            catch (Exception ex)
            {
                //LogHelper.SaveErrorInfo(ex);
            }
          
            return true;

        }

        /// <summary>
        /// 训练字符
        /// </summary>
        public void Train()
        {
            try
            {
                //HOperatorSet.ClearWindow(Frm_ImageWindow.Instance.WindowHandle);
                //HOperatorSet.DispObj(inputImage, Frm_ImageWindow.Instance.WindowHandle);
                //if (templateRegion != null)
                //{
                //    HOperatorSet.SetColor(Frm_ImageWindow.Instance.WindowHandle, new HTuple("green"));
                //    HOperatorSet.DispObj(templateRegion, Frm_ImageWindow.Instance.WindowHandle);
                //}

                //    HOperatorSet.ReduceDomain(inputImage, templateRegion, out imageReduced);
                //    HObject region;
                //    if (charType == CharType.BlackChar)
                //        HOperatorSet.Threshold(imageReduced, out region, 0, threshold);
                //    else
                //        HOperatorSet.Threshold(imageReduced, out region, threshold, 255);
                //    HObject ConnectedRegions;
                //    HOperatorSet.Connection(region, out ConnectedRegions);
                //    HObject SelectedRegions;
                //    HOperatorSet.SelectShape(ConnectedRegions, out SelectedRegions, new HTuple("area"), "and", 10, 99999);
                //    HObject RegionUnion1;
                //    HOperatorSet.Union1(SelectedRegions, out RegionUnion1);
                //    HObject RegionDilation;
                //    if (dilationSize > 0)
                //        HOperatorSet.DilationCircle(RegionUnion1, out RegionDilation, dilationSize);
                //    else
                //        RegionDilation = RegionUnion1;
                //    HObject RegionUnion;
                //    HOperatorSet.Union1(RegionDilation, out RegionUnion);
                //    HObject ConnectedRegions1;
                //    HOperatorSet.Connection(RegionUnion, out ConnectedRegions1);
                //    HObject SortedRegions;
                //    HOperatorSet.SortRegion(ConnectedRegions1, out SortedRegions, "character", "true", "column");
                //    //////HOperatorSet.SetColored(Frm_ImageWindow .Instance .WindowHandle ,new HTuple ( 20));
                //    HOperatorSet.SetColor(Frm_ImageWindow.Instance.WindowHandle, new HTuple("orange"));
                //    HOperatorSet.DispObj(SortedRegions, Frm_ImageWindow.Instance.WindowHandle);
                //    HTuple charArray = StringToHTupleList(standardCharList);
                //    try
                //    {
                //        HOperatorSet.WriteOcrTrainf(SortedRegions, imageReduced, charArray, "train_ocr");
                //    }
                //    catch
                //    {
                //        Frm_Main.Instance.OutputMsg("训练失败，原因：分割出的区域个数与输入的字符文本个数不相等", Color.Red);
                //        return;
                //    }

                //    HTuple CharacterNames, CharacterCount;
                //    HOperatorSet.ReadOcrTrainfNames("train_ocr", out CharacterNames, out CharacterCount);
                //    HOperatorSet.CreateOcrClassMlp(8, 10, "constant", "default", CharacterNames, 80, "none", 10, 42, out modelID);
                //    HTuple Error, ErrorLog;
                //    HOperatorSet.TrainfOcrClassMlp(modelID, "train_ocr", 100, 0.01, 0.01, out Error, out ErrorLog);

                //    Frm_Main.Instance.OutputMsg("字符训练成功", Color.Green);
                //    isCreated = true;
            }
            catch (Exception ex)
            {
                //LogHelper.SaveErrorInfo(ex);
            }
        }

        /// <summary>
        /// 字库加载
        /// </summary>
        public void CreateOCRTool()
        {
            #region 字库加载判断分类器
            if (m_OcrPath == null || m_OcrPath.Length < 1 || System.IO.File.Exists(m_OcrPath) == false)
            {
               Log.Info( Name + ":" + ModInfo.Name + ":字库文件加载异常！" );
            }
            if (m_OcrPath.EndsWith("omc"))
            {
                m_ClassiFier = Classifier.MPL;
            }
            else if (m_OcrPath.EndsWith("occ"))
            {
                m_ClassiFier = Classifier.CNN;
            }
            else
            {
               Log.Error( Name + ":" + ModInfo.Name + ":字库文件加载异常！" );
                return;
            }
            #endregion
            switch (m_ClassiFier)
             {
                case Classifier.MPL:
                    if (ocrMpl != null)
                    {

                        ocrMpl.Dispose();
                    }
                    ocrMpl = new HOCRMlp();
                    ocrMpl.ReadOcrClassMlp(m_OcrPath);

                    if (textModel != null)
                    {
                        textModel.Dispose();
                    }
                    textModel = new HTextModel();
                    //字符库选择后使用
                    textModel.CreateTextModelReader("auto", ocrMpl);
                    break;
                case Classifier.CNN:
                    if (ocrCnn != null)
                    {

                        ocrCnn.Dispose();
                    }
                    ocrCnn = new HOCRCnn();
                    ocrCnn.ReadOcrClassCnn(m_OcrPath);
                    if (textModel != null)
                    {
                        textModel.Dispose();
                    }
                    textModel = new HTextModel();
                    //字符库选择后使用
                    textModel.CreateTextModelReader("auto", ocrCnn);
                    break;
                default:
                    break;
            }
            //最小对比度
            //textModel.SetTextModelParam("min_contrast", m_minContrast);
            ////字符极性
            //textModel.SetTextModelParam("polarity", m_polarity);
            ////丢弃边界
            //textModel.SetTextModelParam("eliminate_border_blobs", "true");
            ////最小宽度
            //textModel.SetTextModelParam("min_char_width", m_minCharWidth);
            ////最大宽度
            //textModel.SetTextModelParam("max_char_width", m_maxCharWidth);
            ////最小高度
            //textModel.SetTextModelParam("min_char_height", m_minCharHeight);
            ////最大高度-文字方向时候也使用
            //textModel.SetTextModelParam("max_char_height", m_maxCharHeight);
            ////最小笔画
            //textModel.SetTextModelParam("min_stroke_width", m_minStrokeWidth);
            ////最大笔画
            //textModel.SetTextModelParam("max_stroke_width", m_maxStrokeWidth);
            ////分隔符
            //textModel.SetTextModelParam("text_line_separators", m_textLineSeparators.Trim());
            ////文本结构
            //textModel.SetTextModelParam("text_line_structure", m_textLineStructure.Trim());
            ////不返回标点符号
            //textModel.SetTextModelParam("return_punctuation", "false");
            ////不返回分隔符
            //textModel.SetTextModelParam("return_separators", "false");
            ////点阵字体
            //textModel.SetTextModelParam("dot_print", m_isDotPrint);
            ////是否识别i
            //textModel.SetTextModelParam("add_fragments", m_isAddFragments);

        }

















        [OnDeserializing()]
        internal void OnDeSerializingMethod(StreamingContext context)
        {

        }
        public override void RunForm(ObjBase baseMod)
        {
          new OCRForm((OCRObj)baseMod).ShowDialog();
        }
        override public void SetInfo()
        {

        }
    }
}
