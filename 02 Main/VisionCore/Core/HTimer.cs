using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;

[Serializable]
public class HTimer
{
    [DllImport("Kernel32.dll")]
    private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);   //��ѯ�߾��ȼ�������ʱ�̵�ʵ��ֵ
    [DllImport("Kernel32.dll")]
    private static extern bool QueryPerformanceFrequency(out long lpFrequency);        //��ѯ�߾��ȼ�����ÿ��ļ�������
    private long mStartTime, mStopTime;
    private readonly long mFrequency;
    /// <summary>
    /// ���캯��
    /// </summary>
    public HTimer()
    {
        mStopTime = 0;
        mStartTime = 0;
        if (QueryPerformanceFrequency(out mFrequency) == false)
        {
            throw new Win32Exception();// ��֧�ָ����ܼ�����
        }
    }
    /// <summary>
    /// ���캯��
    /// </summary>
    public HTimer(bool start)
    {
        mStopTime = 0;
        mStartTime = 0;
        if (QueryPerformanceFrequency(out mFrequency) == false)
        {
            throw new Win32Exception();// ��֧�ָ����ܼ�����
        }
        Start();
    }
    /// <summary>
    /// ��ʼ��ʱ��
    /// </summary>
    public void Start()
    {
        Thread.Sleep(1);  // ���õȴ��̹߳���
        QueryPerformanceCounter(out mStartTime);
    }
    /// <summary>
    /// ֹͣ��ʱ��
    /// </summary>
    public void Stop()
    {
        QueryPerformanceCounter(out mStopTime);
    }
    /// <summary>
    /// ���ؼ�ʱ������ʱ��(��λ����)
    /// </summary>
    public double GetSecond
    {
        get{return Math.Round((double)(mStopTime - mStartTime) / mFrequency, 4);}
    }
    /// <summary>
    /// ���ؼ�ʱ������ʱ��(��λ������)
    /// </summary>
    public double GetMilliSecond
    {
        get { return Math.Round((double)(mStopTime - mStartTime) * 1000 / mFrequency, 4); }
    }
    /// <summary>
    /// ���ؼ�ʱ������ʱ��(��λ��΢��)
    /// </summary>
    public double GetMicroSecond
    {
        get { return Math.Round((double)(mStopTime - mStartTime) * 1000000 / mFrequency, 4); }
    }
}