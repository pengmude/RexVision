using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using RexConst;
namespace VisionCore
{
    /// <summary>
    /// 模块抽象类
    /// </summary>
    [Serializable]
    public abstract class ObjBase
    {
        #region 字段
        /// <summary>模块图标 </summary>
        public Image Icon;
        /// <summary>模块名称 </summary>
        public string Name = "";
        /// <summary>是否启用</summary>
        public bool Enable = true;
        /// <summary>显示区域</summary>
        public bool ShowROI = true;
        /// <summary>显示范围 </summary>
        public bool ShowArea = true;
        /// <summary>显示结果 </summary>
        public bool ShowResult = true;
        /// <summary>标定变量</summary>
        public List<DataCell> mCalVar;
        /// <summary>局部变量</summary>
        public List<DataCell> mSloVar;
        /// <summary>当前图片</summary>
        [NonSerialized]
        public RImage mRImage = new RImage();
        /// <summary>系统变量</summary>
        [NonSerialized]
        public List<DataCell> mSysVar;
        /// <summary> 通信列表</summary>
        [NonSerialized]
        public List<ECom> mECom;
        /// <summary>设备列表</summary>
        [NonSerialized]
        public List<CamerasBase> mCamera;
        /// <summary>模块耗时</summary>
        [NonSerialized]
        public HTimer mHTimer = new HTimer();
        #endregion
        #region 属性
        /// <summary> 模块参数 </summary>
        private ModInfo mModInfo = new ModInfo();
        /// <summary>模块</summary>
        public ModInfo ModInfo
        {
            get
            {
                if (mModInfo == null)
                {
                    mModInfo = new ModInfo();
                }
                return mModInfo;
            }
            set
            {
                mModInfo = value;
                AfterSetModParam();//执行一个方法;
            }
        }
        /// <summary>限定访问-模块设置后执行,子类可用可不用</summary>
        virtual protected void AfterSetModParam() { }
        #endregion
        /// <summary> 抽象执行模块接口 </summary>
        abstract public bool RunObj();
        /// <summary> 模块设置界面</summary>
        virtual public void RunForm(ObjBase baseMod) { }
        /// <summary>初始化-反序列化未初始化的值</summary>
        virtual public void SetInfo() { }
        /// <summary>验证输入字符串为数字-返回一个bool类型的值</summary>
        /// <param name="strln">输入字符</param>
        public bool IsNumber(string strln)
        {
            Regex regex = new Regex("[^0-9.-]");
            Regex regex2 = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            Regex regex3 = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            string str = "^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$";
            string str2 = "^([-]|[0-9])[0-9]*$";
            Regex regex4 = new Regex("(" + str + ")|(" + str2 + ")");
            return !regex.IsMatch(strln) && !regex2.IsMatch(strln) && !regex3.IsMatch(strln) && regex4.IsMatch(strln);
        }
        #region  变量操作
        /// <summary>
        /// 更新全局变量列表中的值
        /// </summary>
        /// <param name="_CellID">单元ID</param>
        /// <param name="_DataName">变量名称</param>
        /// <param name="_ListValue">newValue</param>
        public void SetVarList(ref List<DataCell> imCalVar, string _DataName, object _ListValue)
        {
            int index = imCalVar.FindIndex(e => e.mDataName.ToUpper() == _DataName.Trim().ToUpper());
            if (index > -1)
            {
                DataCell datacell = imCalVar[index];
                datacell.mDataValue = _ListValue;
                imCalVar[index] = datacell;
            }
        }
        /// <summary>
        /// 更新全局变量列表中的值
        /// </summary>
        /// <param name="imCalVar">列表</param>
        /// <param name="data">值</param>
        public void SetVarList(ref List<DataCell> imCalVar, DataCell data)
        {
            int index = imCalVar.FindIndex(e => e.mModName == data.mModName && e.mDataName == data.mDataName);
            if (index > -1)
                imCalVar[index] = data;
            else
                imCalVar.Add(data);
        }
        /// <summary>
        /// 更新全局变量列表中的值
        /// </summary>
        /// <param name="imCalVar">列表</param>
        /// <param name="data">值</param>
        public void SetVarList(ref List<DataCell> imCalVar, List<DataCell> data)
        {
            imCalVar = data;
        }
        #endregion
    }
}
