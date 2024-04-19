using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;

[Serializable]
public class HTimer
{
    [DllImport("Kernel32.dll")]
    private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);   //查询高精度计数器该时刻的实际值
    [DllImport("Kernel32.dll")]
    private static extern bool QueryPerformanceFrequency(out long lpFrequency);        //查询高精度计数器每秒的计数次数
    private long mStartTime, mStopTime;
    private readonly long mFrequency;
    /// <summary>
    /// 构造函数
    /// </summary>
    public HTimer()
    {
        mStopTime = 0;
        mStartTime = 0;
        if (QueryPerformanceFrequency(out mFrequency) == false)
        {
            throw new Win32Exception();// 不支持高性能计数器
        }
    }
    /// <summary>
    /// 构造函数
    /// </summary>
    public HTimer(bool start)
    {
        mStopTime = 0;
        mStartTime = 0;
        if (QueryPerformanceFrequency(out mFrequency) == false)
        {
            throw new Win32Exception();// 不支持高性能计数器
        }
        Start();
    }
    /// <summary>
    /// 开始计时器
    /// </summary>
    public void Start()
    {
        Thread.Sleep(1);  // 来让等待线程工作
        QueryPerformanceCounter(out mStartTime);
    }
    /// <summary>
    /// 停止计时器
    /// </summary>
    public void Stop()
    {
        QueryPerformanceCounter(out mStopTime);
    }
    /// <summary>
    /// 返回计时器经过时间(单位：秒)
    /// </summary>
    public double GetSecond
    {
        get{return Math.Round((double)(mStopTime - mStartTime) / mFrequency, 4);}
    }
    /// <summary>
    /// 返回计时器经过时间(单位：耗秒)
    /// </summary>
    public double GetMilliSecond
    {
        get { return Math.Round((double)(mStopTime - mStartTime) * 1000 / mFrequency, 4); }
    }
    /// <summary>
    /// 返回计时器经过时间(单位：微秒)
    /// </summary>
    public double GetMicroSecond
    {
        get { return Math.Round((double)(mStopTime - mStartTime) * 1000000 / mFrequency, 4); }
    }
}