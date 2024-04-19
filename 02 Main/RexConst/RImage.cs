using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Diagnostics;
using HalconDotNet;
/// <summary>
/// 公有类型定义
/// </summary>
namespace RexConst
{
    [Serializable]
    public class RImage : HImage, ISerializable
    {
        /// <summary>状态</summary>
        public bool Status = true;
        /// <summary> 名称 </summary>
        public string Name = string.Empty;
        /// <summary>窗体索引</summary>
        public int Screen = 0;
        /// <summary>宽</summary>
        public int Width = 0;
        /// <summary>高</summary>
        public int Height = 0;
        /// <summary>采集当前图像时候的位置X </summary>
        public double X = 0;
        /// <summary> 采集当前图像时候的位置X</summary>
        public double Y = 0;
        /// <summary>采集当前图像时候的位置X</summary>
        public double Z = 0;
        /// <summary> X轴和直角坐标系X轴夹角 </summary>
        public double PhiX = 0;
        /// <summary> X轴和直角坐标系旋转重叠后 Y轴和直角坐标系Y轴夹角 </summary>
        public double PhiY = 0;
        /// <summary> X方向像素比率</summary>
        public double ScaleX = 1;
        /// <summary> Y方向像素比率</summary>
        public double ScaleY = 1;
        #region 区域标定映射
        /// <summary> 标定板行坐标</summary>
        public HTuple BoardRow { get; set; }
        /// <summary> 标定板列坐标 </summary>
        public HTuple BoardCol { get; set; }
        /// <summary>标定板X坐标 </summary>
        public HTuple BoardX { get; set; }
        /// <summary> 标定板列坐标</summary>
        public HTuple BoardY { get; set; }
        /// <summary> 标定标记</summary>
        public bool IsCal { get; set; }
        #endregion
        #region 构造函数
        public RImage() : base() { }
        public RImage(HObject obj) : base(obj) { }
        public RImage(string fileName) : base(fileName) { }
        public RImage(IntPtr key, bool copy) : base(key, copy) { }
        public RImage(string type, int width, int height, IntPtr pixelPointer) : base(type, width, height, pixelPointer) { }
        public RImage(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }
            this.X = info.GetDouble("X");
            this.Y = info.GetDouble("Y");
            this.Z = info.GetDouble("Z");
            this.PhiX = info.GetDouble("PhiX");
            this.PhiY = info.GetDouble("PhiY");
            this.ScaleX = info.GetDouble("ScaleX");
            this.ScaleY = info.GetDouble("ScaleY");
            this.Status = info.GetBoolean("Status");
            try
            {
                this.mHRoi = (List<HRoi>)info.GetValue("mHRoi", typeof(List<HRoi>));
                this.mHText = (List<HText>)info.GetValue("mHText", typeof(List<HText>));
            }
            catch (Exception ex) { /*Log.Error(ex.ToString()); */}
        }
        ///<summary>序列化</summary>
        ///<param name="info"></param>
        ///<param name="context"></param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                if (info == null)
                {
                    throw new System.ArgumentNullException("info");
                }
                info.AddValue("X", X);
                info.AddValue("Y", Y);
                info.AddValue("Z", Z);
                info.AddValue("PhiX", PhiX);
                info.AddValue("PhiY", PhiY);
                info.AddValue("ScaleX", ScaleX);
                info.AddValue("ScaleY", ScaleY);
                info.AddValue("Status", Status);
                info.AddValue("mHRoi", mHRoi);
                info.AddValue("mHText", mHText);
                HSerializedItem item = this.SerializeImage();//Himage 内部函数 反编译得到的
                byte[] buffer = item;
                item.Dispose();
                info.AddValue("data", buffer, typeof(byte[]));
            }
            catch (Exception ex) {/* Log.Error(ex.ToString()); */}
        }
        #endregion
        /// <summary>图片缩放</summary>
        public HHomMat2D GetHome()
        {
            HHomMat2D hom = new HHomMat2D();
            hom = hom.HomMat2dScaleLocal(ScaleX, ScaleY);
            return hom;
        }
        /// <summary> 获取校正相机夹角和校正轴矩阵</summary>
        public HHomMat2D GetAngle()
        {
            HHomMat2D homA = new HHomMat2D();
            homA = homA.HomMat2dRotateLocal(PhiX);//校正相机和轴夹角
            //homA = homA.HomMat2dSlantLocal(Y * Math.Sin(PhiY), "x");//校正XY轴夹角
            return homA;
        }
        /// <summary>保存RImage</summary>
        public void SaveRImage(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            if (ext == ".he")
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    BinaryFormatter binaryFmt = new BinaryFormatter();
                    fs.Seek(0, SeekOrigin.Begin);
                    binaryFmt.Serialize(fs, this);
                }
            }
            else if (ext == "") //当没有传入有后缀的fileName,默认保存png magical 20170822
            {
                if (GetImageType().ToString().Contains("real"))
                {
                    this.WriteImage("tiff", 0, fileName);
                }
                else
                {
                    this.WriteImage("png best", 0, fileName);
                }
            }
            else
            {
                this.WriteImage(ext.Substring(1), 0, fileName);
            }
        }
        /// <summary>HImageToRImage</summary>
        public static RImage ToRImage(HObject image)
        {
            return new RImage(image);
        }
        /// <summary> 从文件中获取RImage对象</summary>
        public static RImage ReadRImage(string fileName)
        {
            RImage ImgExt = null;
            try
            {
                if (Path.GetExtension(fileName).ToLower() == ".he")
                {
                    using (FileStream fs = new FileStream(fileName, FileMode.Open))//作为语句：用于定义一个范围，在此范围的末尾将释放对象。 请参阅 using 语句。 by:longteng
                    {
                        fs.Seek(0, SeekOrigin.Begin);
                        BinaryFormatter binaryFmt = new BinaryFormatter();
                        ImgExt = (RImage)binaryFmt.Deserialize(fs);
                    }
                }
                else
                {
                    ImgExt = ToRImage(new HImage(fileName));
                    ImgExt.Name = Path.GetFileName(fileName);
                }
                GC.Collect();
                return ImgExt;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.ToString());
                return ImgExt;
            }
        }
        /// <summary>显示的ROI</summary>
        public List<HRoi> mHRoi = new List<HRoi>();
        /// <summary>显示的信息</summary>
        public List<HText> mHText = new List<HText>();
        /// <summary>显示Roi</summary>
        public void ShowHRoi(HRoi ROI)
        {
            try
            {
                int index = mHRoi.FindIndex(e => e.CellID == ROI.CellID && e.roiType == ROI.roiType && e.CellType == ROI.CellType);
                if (ROI.fors == true)
                {
                    mHRoi.Add(ROI);
                    return;
                }
                if (index > -1)
                    mHRoi[index] = ROI;
                else
                    mHRoi.Add(ROI);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        /// <summary>显示文本 </summary>
        public void ShowHText(HText ROI)
        {
            try
            {
                int index = mHText.FindIndex(e => e.CellType == ROI.CellType && e.roiType == ROI.roiType && e.CellType == ROI.CellType);
                if (ROI.fors == true)
                {
                    mHText.Add(ROI);
                    return;
                }
                if (index > -1)
                    mHText[index] = ROI;
                else
                    mHText.Add(ROI);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        /// <summary>深拷贝</summary>
        public new RImage Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                mHRoi = mHRoi.Where(c => c != null && (c.hobject == null || c.hobject.IsInitialized())).ToList();
                mHText = mHText.Where(c => c != null && (c.hobject == null || c.hobject.IsInitialized())).ToList();
                formatter.Serialize(stream, this);
                stream.Position = 0;
                return formatter.Deserialize(stream) as RImage;
            }
        }
        [OnSerializing()]
        internal void OnSerializingMethod(StreamingContext context)
        {
            foreach (HRoi ROI in mHRoi)
            {
                if (ROI.hobject == null || !ROI.hobject.IsInitialized())//修复为null 错误 magical 20171103
                {
                    ROI.hobject = null;
                }
            }
            foreach (HText ROI in mHText)
            {
                if (ROI.hobject == null || !ROI.hobject.IsInitialized())//修复为null 错误 magical 20171103
                {
                    ROI.hobject = null;
                }
            }
        }
        [OnDeserialized()]
        internal void OnDeSerializedMethod(StreamingContext context)
        {
            //如果he为老版本没有x y比例 手动设置为1,否则离线读取数据计算时候会出现异常   yoga 20180824
            if (ScaleX == 0)
            {
                ScaleX = 1;
            }
            if (ScaleY == 0)
            {
                ScaleY = 1;
            }
        }
    }
}
