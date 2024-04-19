
using DockContrl;
using Rex.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VisionCore;
namespace RexVision
{
    public delegate void SetCamearDg(CamerasBase mCamear,EComType type);
    public partial class CameraSet : DockForm
    {
        /// <summary>窗体加载不触发事件 </summary>
        bool mLoading = false;
        /// <summary>相机设置触发事件 </summary>
        public static event SetCamearDg SetCamearEvent;
        /// <summary>当前相机</summary>
        CamerasBase mCamerasBase;
        /// <summary>相机列表</summary>
        public static List<CamerasBase> mCamerasList;
        /// <summary>品牌列表</summary>
        private List<string> TypeList = PluginCamService.cPluginDic.Keys.ToList();
        public CameraSet()
        {
            Set_MinMax();
            InitializeComponent();
        }
        public void CameraFormSet_Load(object sender, EventArgs e)
        {
            dgv_CameraList.AutoGenerateColumns = false;
            cb_DeviceType.DataSource = TypeList.ToList();
            dgv_CameraList.DataSource = mCamerasList.ToList();
            uicb_TrigMode.DataSource= Enum.GetNames(typeof(TrigMode));
            uicb_TrigMode.SelectedIndex = 0;
            mLoading = true;
        }
        private void cmb_DeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_DeviceType.SelectedIndex < 0) { return; }
            PluginsInfo pluginsInfo = PluginCamService.cPluginDic[TypeList[cb_DeviceType.SelectedIndex]];
            CamerasBase ModObj = (CamerasBase)pluginsInfo.ModObjType.Assembly.CreateInstance(pluginsInfo.ModObjType.FullName);
            List<CamerasInfo> CamInfoList = ModObj.SearchCameras();
            cb_DeviceName.Items.Clear();
            foreach (CamerasInfo info in CamInfoList)
            {
                cb_DeviceName.Items.Add(info.m_SerialNO);
            }
        }
        private void bt_Add2List_Click(object sender, EventArgs e)
        {
            if (cb_DeviceName.SelectedIndex < 0) { return; }
            int index = mCamerasList.FindIndex(c => c.mSerialNo == cb_DeviceName.SelectedItem.ToString());
            if (index >= 0)
            {
                MessageBox.Show("该设备已经添加列表");
                return;
            }
            //根据选中的插件 new一个 模块
            PluginsInfo m_PluginsInfo = PluginCamService.cPluginDic[TypeList[cb_DeviceType.SelectedIndex]];
            CamerasBase ModObj = (CamerasBase)m_PluginsInfo.ModObjType.Assembly.CreateInstance(m_PluginsInfo.ModObjType.FullName);
            //确定新模块的不重名名称
            if (mCamerasList!=null)
            {
                if (mCamerasList.Count > 0)
                {
                    List<string> nameList = mCamerasList.Select(c => c.mCameraNo).ToList();
                    while (true)
                    {
                        if (!nameList.Contains("Dev"+ CamerasBase.mLastNo))
                        {
                            break;//没有重名就跳出循环
                        }
                        CamerasBase.mLastNo++;
                    }
                }else
                {
                    CamerasBase.mLastNo++;
                }
            }
            ModObj.mCameraNo = "Dev" + CamerasBase.mLastNo;
            ModObj.mSerialNo = cb_DeviceName.SelectedItem.ToString();//待验证
            ModObj.mRemark = "";
            mCamerasList.Add(ModObj);
            dgv_CameraList.DataSource = mCamerasList.ToList();
            SetCamearEvent(ModObj, EComType.Add);
        }
        private void bt_Remov_Click(object sender, EventArgs e)
        {
            if (mCamerasBase == null) { return; }
            CamerasBase.mLastNo = 0;
            mCamerasBase.DisConnectDev();
            CamerasBase RemovCamera = mCamerasList.Find(c => c.mSerialNo == mCamerasBase.mSerialNo);
            mCamerasList.Remove(RemovCamera);
            dgv_CameraList.DataSource = mCamerasList.ToList();
            SetCamearEvent(RemovCamera, EComType.Remov);
        }
        private void UpDateMaxMin(CamerasBase cameras)
        {
            //if (cameras == null) return;
            //uidu_Width.MaxValue = cameras.mWidthMax;
            //uidu_Height.MaxValue = cameras.mHeightMax;
            //uidu_Gain.MaxValue = (int)cameras.mGainMax;
            //uidu_Gain.MinValue = (int)cameras.mGainMin;
            //uidu_Timer.MaxValue = (int)cameras.mExposeTimeMax;
            //uidu_Timer.MinValue = (int)cameras.mExposeTimeMin;
        }
        private void UpDateSeting(CamerasBase cameras)
        {
            uitb_Camera.TextStr = cameras.mCameraNo;
            uidu_Height.Value = cameras.mHeight;
            uidu_Width.Value = cameras.mWidth;
            uidu_Timer.Value = cameras.mExposeTime;
            uidu_Gain.Value = cameras.mGain;
            uitb_CameraNote.TextStr = cameras.mRemark;
            uitb_SerialNo.TextStr = cameras.mSerialNo;
            uicb_TrigMode.SelectedIndex = (int)cameras.mTrigMode;
        }
        private void dgv_CameraList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_CameraList.CurrentCell == null) { return; }
            mCamerasBase = mCamerasList[dgv_CameraList.CurrentCell.RowIndex];
            UpDateSeting(mCamerasBase);
            UpDateMaxMin(mCamerasBase);

        }
        private void bt_Connect_Click(object sender, EventArgs e)
        {
            if (mCamerasBase == null) { return; }
            mCamerasBase.ConnectDev();
            dgv_CameraList.DataSource = mCamerasList.ToList();
        }
        private void bt_Disconnect_Click(object sender, EventArgs e)
        {
            if (mCamerasBase == null) { return; }
            mCamerasBase.DisConnectDev();
            dgv_CameraList.DataSource = mCamerasList.ToList();
        }
        private void bt_Series_Click(object sender, EventArgs e)
        {
            if (mCamerasBase == null) { return; }
            if (mCamerasBase.mConnected == false)
            {
                MessageBox.Show("相机未连接！");
                return;
            }
            mCamerasBase.CaptureImage(false);
        }
        private void uicb_TrigMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mCamerasBase == null) { return; }
            if (!mCamerasBase.mConnected) return;
             mCamerasBase.SetTriggerMode((TrigMode)uicb_TrigMode.SelectedIndex);
        }
        private void uitb_CameraNote_TextStrChanged(string textStr)
        {
            if (mCamerasBase == null) { return; }
            if (!mCamerasBase.mConnected) return;
            mCamerasBase.mRemark = uitb_CameraNote.TextStr;
        }
        private void uidu_Width_ValueChanged(object sender, double value)
        {
            if (!mLoading) { return; }
            if (mCamerasBase == null) { return; }
            if (!mCamerasBase.mConnected) return;
            mCamerasBase.mWidth = (int)uidu_Width.Value;
            mCamerasBase.CameraChanged(ChangType.宽度);
        }
        private void uidu_Height_ValueChanged(object sender, double value)
        {
            if (!mLoading) { return; }
            if (mCamerasBase == null) { return; }
            if (!mCamerasBase.mConnected) return;
            mCamerasBase.mHeight = (int)uidu_Height.Value;
            mCamerasBase.CameraChanged(ChangType.高度);
        }
        private void uidu_Timer_ValueChanged(object sender, double value)
        {
            if (!mLoading) { return; }
            if (mCamerasBase == null) { return; }
            if (!mCamerasBase.mConnected) return;
            mCamerasBase.mExposeTime = (int)uidu_Timer.Value;
            mCamerasBase.CameraChanged(ChangType.曝光);
        }
        private void uidu_Gain_ValueChanged(object sender, double value)
        {
            if (!mLoading) { return; }
            if (mCamerasBase == null) { return; }
            if (!mCamerasBase.mConnected) return;
            mCamerasBase.mGain = (int)uidu_Gain.Value;
            mCamerasBase.CameraChanged(ChangType.增益);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mCamerasBase == null) { return; }
            mWindow.Image = mCamerasBase.Image;
        }
        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (mCamerasBase == null) { return; }
            mCamerasBase.mRemark = uitb_CameraNote.TextStr;
            if (mCamerasBase.mConnected == false)
            {
                MessageBox.Show("相机未连接!");
                return;
            }
            mCamerasBase.mExposeTime = (int)uidu_Timer.Value;
            mCamerasBase.mGain = (int)uidu_Gain.Value;
            mCamerasBase.mRemark = uitb_CameraNote.TextStr;
        }
    }
}
