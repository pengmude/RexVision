using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using RexConst;
using System.Collections.Concurrent;
using System.Windows.Forms;
namespace VisionCore
{
    public delegate void DelegateTrigger(int index);
    public delegate void RefreshSolView(int index);
    public delegate void CreateSol(List<Proj> mProjList);
    public delegate void SetCameraDg(CamerasBase mCamera, EComType eComType);
    /// <summary>流程控制</summary>
    [Serializable]
    public class Sol : IDisposable
    {
        public static event SetCameraDg SetCameraEvent;
        /// <summary>图框数量</summary>
        public int mScreenNum = 0;
        /// <summary>项目名称</summary>
        public string Name = "新建工程";
        /// <summary>当前项目</summary>
        public static Sol mSol = null;
        /// <summary>图像索引</summary>
        public static int mModIndex = 0;
        /// <summary>是否保存 </summary>
        public static bool mProjSave = false;
        /// <summary>方案路径</summary>
        public static string mSavePath = "";
        /// <summary>自动保存项目 </summary>
        public static bool mAutoSaveProj = false;
        /// <summary>是否自启</summary>
        public static bool mOpenStart = false;
        /// <summary>是否自动加载项目</summary>
        public static bool mStartLoadProj = false;
        /// <summary>是否启动后自动执行</summary>
        public static bool mAutoRun = false;
        /// <summary>运行间隔</summary>
        public static int mRunInterval = 100;
        /// <summary>通讯间隔</summary>
        public static int mNetInterval = 100;
        /// <summary>日志保存天数</summary>
        public static int mLogSaveDay = 10;
        /// <summary>日志保存等级</summary>
        public static LogLevel mLogLevel = LogLevel.Debug;
        /// <summary>通信列表</summary>
        public List<ECom> mEComList = new List<ECom>();
        /// <summary>系统变量</summary>
        public List<DataCell> mSysVar = new List<DataCell>();
        /// <summary>标定变量</summary>
        public List<DataCell> mCalVar = new List<DataCell>();
        /// <summary>流程信息</summary>
        public List<Proj> mProjList = new List<Proj>();
        /// <summary>采集设备</summary>
        public List<CamerasBase> mCamerasList = new List<CamerasBase>();
        /// <summary>绘制阻塞</summary>
        public static AutoResetEvent mDrawModSign = new AutoResetEvent(true);
        /// <summary>绘制禁止</summary>
        public static bool mDrawModFlag = false;
        /// <summary>停止标志位，提示程序已经处于停止状态需要跳出等待</summary>
        public static bool IsStop = true;
        /// <summary>检测冗余调用</summary>
        private bool mDispose = false;
        /// <summary>不能使用Queue Queue是线程不安全 会报错</summary>
        public static BlockingCollection<ModStateInfo> mModStateInfoQueue = new BlockingCollection<ModStateInfo>();
        /// <summary>模块状态</summary>
        private static void ModStatus()
        {
            if (mSol.mProjList.Count > 0)
            {
                if (mDrawModFlag == true)//控件正在绘制的时候 将不设置模块的状态,否则会出现多个正在运行的模块
                {
                    mDrawModSign.WaitOne();
                    ModStateInfo ms = mModStateInfoQueue.Take();
                    mSol.mProjList[ms.ProjIndex].mRunMode = ms.ModState;
                }
                else
                {
                    ModStateInfo ms = mModStateInfoQueue.Take();
                    mSol.mProjList[ms.ProjIndex].mRunMode = ms.ModState;
                }
            }
        }
        /// <summary>项目实例化</summary>
        public Sol()
        {
            mProjList = new List<Proj>();
            CreateProj();
        }
        /// <summary> 创建流程 获取新不重复的index,如果已经存在  1,2,4 那么获得的id 是 3 </summary>
        public int CreateProj()
        {
            int index = 0;
            Proj Proj = new Proj();
            do
            {
                bool flag = true;
                foreach (Proj mProj in mProjList)
                {
                    if (mProj.mProjInfo.Index == index)
                    {
                        ++index;
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            } while (true);
            Proj.mProjInfo.Index = index;
            Proj.mProjInfo.Name = "流程" + index.ToString();
            Proj.mCamera = mCamerasList;
            Proj.mSysVar = mSysVar;
            Proj.mCalVar = mCalVar;
            Proj.mECom = mEComList;
            mProjList.Add(Proj);
            return index;
        }
        /// <summary> 通过名字删除流程</summary>
        public static bool DeleteProj(string name)
        {
            mProjSave = false;//解决方案未保存
            Proj mProj = mSol.mProjList.FirstOrDefault(c => c.mProjInfo.Name == name);
            int index = mSol.mProjList.FindIndex(x =>
            {
                ProjInfo mProjInfo = x.mProjInfo;
                if (mProjInfo.Name == name)
                {
                    return true;
                }
                return false;
            });
            if (index != -1)
            {
                mProj.mAutoResetEvent.Reset();
                mSol.mProjList.Remove(mProj);
                return true;
            }
            return false;
        }
        /// <summary> 获取流程名称集合</summary>
        public List<string> GetNameList()
        {
            List<string> NameList = new List<string>();
            if (mProjList.Count > 0)
            {
                foreach (Proj mProj in mProjList)
                {
                    NameList.Add(mProj.mProjInfo.Name);
                }
            }
            return NameList;
        }
        /// <summary>根据索引获取对应的Proj</summary>
        public static Proj GetProj(int index)
        {
            return mSol.mProjList.FirstOrDefault(c => c.mProjInfo.Index == index);
        }
        /// <summary>通过名字检索流程</summary>
        public static ProjInfo GetProj(string name)
        {
            Proj mProj = mSol.mProjList.FirstOrDefault(x => x.mProjInfo.Name == name);
            if (mProj != null)
            {
                return mProj.mProjInfo;
            }
            throw new MemberAccessException($"流程不存在,请检查设置!");
        }
        /// <summary>设置流程名称</summary>
        public void SetProjName(string[] ProjName)
        {
            int index = 0;
            foreach (Proj mProj in mProjList)
            {
                mProj.mProjInfo.Name = ProjName[index];
                mProj.ShowName();
                ++index;
            }
        }
        /// <summary>修改流程信息</summary>
        public static bool ChangeProInfo(ProjInfo info)
        {
            mProjSave = false;//解决方案未保存
            Proj mProj = mSol.mProjList.FirstOrDefault(x => x.mProjInfo.Index == info.Index);
            if (mProj != null)
            {
                mProj.mProjInfo = info;
                return true;
            }
            return false;
        }
        /// <summary>获取当前选中项目的运行状态</summary>
        public static bool GetStates()
        {
            foreach (Proj mProj in mSol.mProjList)
            {
               return mProj.GetThreadStatus();
            }
            return false;
        }
        /// <summary>单次执行-指定</summary>
        public static void OnceRun(int index)
        {
            IsStop = false;
            mSol.mProjList.FirstOrDefault(c => c.mProjInfo.Index == index).mRunMode = RunMode.单次执行;
            mSol.mProjList.FirstOrDefault(c => c.mProjInfo.Index == index).Start();
        }
        /// <summary>循环执行-指定</summary>
        public static void StartRun(int index)
        {
            IsStop = false;
            mSol.mProjList.FirstOrDefault(c => c.mProjInfo.Index == index).mRunMode = RunMode.循环执行;
            mSol.mProjList.FirstOrDefault(c => c.mProjInfo.Index == index).Start();
        }
        /// <summary>停止执行-指定</summary>
        public static void StopRun(int index)
        {
            IsStop = true;
            //if(mSol.mProjList.FirstOrDefault(c => c.mProjInfo.Index == index).mRunMode != RunMode.循环执行)
            {
                mSol.mProjList.FirstOrDefault(c => c.mProjInfo.Index == index).Stop();
                mSol.mProjList.FirstOrDefault(c => c.mProjInfo.Index == index).mRunMode = RunMode.停止执行;//停止
            }
        }
        /// <summary>单次执行-所有</summary>
        public static void OnceRun()
        {
            IsStop = false;
            for (int i = 0; i < mSol.mProjList.Count; i++)
            {
                if (mSol.mProjList[i].mRunType == 0)
                {
                    OnceRun(i);
                }
            }
        }
        /// <summary>循环执行-所有</summary>
        public static void StartRun()
        {
            IsStop = false;
            for (int i = 0; i < mSol.mProjList.Count; i++)
            {
                if (mSol.mProjList[i].mRunType == 0)
                {
                    StartRun(i);
                }
            }
        }
        /// <summary>停止执行-所有</summary>
        public static void StopRun()
        {
            IsStop = true;
            for (int i = 0; i < mSol.mProjList.Count; i++)
            {
                StopRun(i);
            }
             //TODO: 流程停止时图像采集也停止阻塞
            //foreach (CamerasBase camera in mSol.mCamerasList)
            //{
            //    camera.EventWait = new AutoResetEvent(false);//采集信号
            //    camera.SignalWait = new AutoResetEvent(false);//软触发时信号同步
            //    camera.GetSignalWait = new AutoResetEvent(false);//软触收到图像信号
            //    camera.Image = new RImage();
            //}
        }
        /// <summary>
        /// 根据系统设置 更新一些变化
        /// </summary>
        public static void UpdateSys(double day, LogLevel level)
        {
            mLogSaveDay = (int)day;
            mLogLevel = level;
            //更改日志等级
            Log.UpLogLevel(level);
            //删除指定天数前的日志
            Log.DeleteLog((int)day);
        }
        #region 数据保存
        /// <summary>关闭项目</summary>
        public void CloseProj()
        {
            if (mProjList != null)
            {
                foreach (Proj Proj in mProjList)
                {
                    Proj.Stop();
                    if (Proj.mAutoResetEvent != null)
                        Proj.mAutoResetEvent.Reset();
                }
            }
            if (mEComList != null)
            {
                foreach (ECom mCom in mEComList)
                {
                    mCom.DisConnect();
                }
            }
            if (mCamerasList != null)
            {
                foreach (CamerasBase mCameras in mCamerasList)
                {
                    mCameras.DisConnectDev();
                }
            }
        }
        /// <summary> 保存项目</summary>
        public static Sol SaveData(string path, Sol Sol)
        {
            FileStream mStream = new FileStream(path, FileMode.Create);
            try
            {
                BinaryFormatter bFormat = new BinaryFormatter();
                bFormat.Serialize(mStream, Sol);
                foreach (Proj mProj in Sol.mProjList) { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                mStream.Close();
                mProjSave = true;
                Log.Info("项目:"+Sol.Name+"保存成功! " + path);
                GC.Collect();
            }
            return Sol;
        }
        /// <summary> 读取项目</summary>
        public static Sol ReadData(string path)
        {
            if (path.Length < 3) return null;
            FileStream mStream = null;
            try
            {
                mStream = new FileStream(path, FileMode.Open);
                BinaryFormatter BinFormat = new BinaryFormatter();
                mSol = (Sol)BinFormat.Deserialize(mStream);//反序列化得到的是一个object对象.必须做下类型转换
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand); }
            finally
            {
                if (mStream != null)
                {
                    mStream.Close();
                    try
                    {
                        foreach (Proj mProj in mSol.mProjList)
                        {
                            try
                            {
                                mProj.SetInfo();  //初始化未序列化的值
                            mProj.mIsShow = true;
                            mProj.mSysVar = mSol.mSysVar;
                            mProj.mCalVar = mSol.mCalVar;
                            mProj.mECom = mSol.mEComList;
                            mProj.mCamera = mSol.mCamerasList;
                            }
                            catch { }
                        }
                    }
                    catch { }
                    try
                    {
                        EComManageer.SetEcomList(mSol.mEComList);
                    }
                    catch { }
                }
                else
                {
                    mSol = new Sol();
                    mSol.mScreenNum = 0;
                }
                Sol.mProjSave = true;
                Log.Info("项目:" + mSol.Name + "加载成功! " + path);
            }
            return mSol;
        }
        #endregion
        #region 相机状态
        /// <summary>检查相机状态-全部在线为true </summary>
        public bool CheckCameraStatus()
        {
            foreach (CamerasBase dev in mCamerasList)
            {
                if (dev.mConnected == false)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>初始化相机状态</summary>
        public void InitCameraStatus()
        {
            foreach (CamerasBase camera in mCamerasList)
            {
                SetCameraEvent(camera, EComType.Add);
                if (camera.mConnected)
                {
                    camera.mConnected = false;
                    camera.ConnectDev();
                    if(camera.mConnected)
                    {
                        camera.SetSetting();
                    }
                }
                else
                {
                    camera.DisConnectDev();
                }
                camera.EventWait = new AutoResetEvent(false);//采集信号
                camera.Image = new RImage();
                camera.SignalWait = new AutoResetEvent(false);//软触发时信号同步
                camera.GetSignalWait = new AutoResetEvent(false);//软触收到图像信号
            }
        }
        #endregion
        #region IDisposable Support
        public void Dispose()
        {
            Dispose(true);  //添加此代码以正确实现可处置模式。
            // GC.SuppressFinalize(this);// 如果在以上内容中替代了终结器，则取消注释以下行。
        }
        public void DisposeCamera()
        {
            if (mCamerasList != null)
            {
                foreach (CamerasBase dev in mCamerasList)
                {
                    if (dev.mConnected)
                        dev.DisConnectDev();
                }
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!mDispose)
            {
                if (disposing)
                {
                    CloseProj();
                    mProjList.Clear(); // TODO: 释放托管状态(托管对象)。
                    DisposeCamera();   // TODO: 释放托管状态(托管对象)。
                }
                mDispose = true;       // 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。将大型字段设置为 null。
            }
        }
        #endregion
    }
}
