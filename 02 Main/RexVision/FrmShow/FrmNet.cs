using Rex.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VisionCore;
using WeifenLuo.WinFormsUI.Docking;

namespace RexVision
{
    [Serializable]
    public partial class FrmNet : DockContent
    {
        public List<UISymbolButton> mBtnList = new List<UISymbolButton>();
        public FrmNet()
        {
            InitializeComponent();
            NetSet.SetEComEvent += EComEvent;
            FormMain.SetEComEvent += EComEvent;
            EComManageer.SetEComEvent += EComEvent;
            CameraSet.SetCamearEvent += CamearEvent;
            Sol.SetCameraEvent += CamearEvent;

        }
        public void EComEvent(ECom mECom, EComType type)
        {

            switch (type)
            {
                case EComType.Add:
                    AddButton(mECom, type);
                    break;
                case EComType.Remov:
                    foreach (Control mBtn in uipl_EComEvent.Controls)
                    {
                        if (mBtn.Text == mECom.Key)
                        {
                            uipl_EComEvent.Controls.Remove(mBtn);
                        }
                    }
                    break;
                case EComType.Clear:
                    uipl_EComEvent.Controls.Clear();
                    break;
            }
        }
        public void CamearEvent(CamerasBase mCamear, EComType type)
        {

            switch (type)
            {
                case EComType.Add:
                    AddButton(mCamear);
                    break;
                case EComType.Remov:
                    foreach (Control mBtn in uipl_EComEvent.Controls)
                    {
                        if (mCamear!=null)
                        {
                            if (mBtn.Text == mCamear.mCameraNo)
                            {
                                uipl_EComEvent.Controls.Remove(mBtn);
                            }
                        }
                    }
                    break;
                case EComType.Clear:
                   
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (uipl_EComEvent.Controls.Count>0)
            {
                foreach (UISymbolButton mBtn in uipl_EComEvent.Controls)
                {
                    if (mBtn.Text.StartsWith("Dev"))
                    {
                        if (CameraSet.mCamerasList != null)
                        {
                            CamerasBase mCamerasBase = CameraSet.mCamerasList.Find(c => c.mCameraNo == mBtn.Text);
                            if (mCamerasBase != null)
                            {
                                if (mCamerasBase.mConnected)
                                {
                                    mBtn.RectColor = Color.FromArgb(80, 160, 255);
                                    mBtn.FillColor = Color.FromArgb(80, 160, 255);
                                }
                                else
                                {
                                    mBtn.RectColor = Color.FromArgb(255, 128, 128);
                                    mBtn.FillColor = Color.FromArgb(255, 128, 128);
                                }
                            }
                        }
                    }
                    else
                    {
                        ECom mECom =Sol.mSol.mEComList.Find(c => c.Key == mBtn.Text);
                        if (mECom != null)
                        {
                            if (mECom.IsConnected)
                            {
                                mBtn.RectColor = Color.FromArgb(80, 160, 255);
                                mBtn.FillColor = Color.FromArgb(80, 160, 255);
                            }
                            else
                            {
                                mBtn.RectColor = Color.FromArgb(255, 128, 128);
                                mBtn.FillColor = Color.FromArgb(255, 128, 128);
                            }
                        }
                    }
                }
            }
        }
        public void AddButton(ECom mECom, EComType type)
        {
            foreach(Control btn in uipl_EComEvent.Controls)
            {
                if(btn.Text== mECom.Key)
                {
                    return;
                }
            }
            UISymbolButton aButton = new UISymbolButton();
            aButton.Text = mECom.Key;
            aButton.Symbol = 57567;
            aButton.UseDoubleClick = true;
            aButton.BringToFront();
            aButton.Size = new Size(120, 24);
            aButton.Font = new Font("微软雅黑", 9F);
            aButton.Click += new EventHandler(ClickHandler);
            mBtnList.Add(aButton);
            uipl_EComEvent.Controls.Add(aButton);
            ArrangeButtons();
        }
        public void AddButton(CamerasBase mCamerasBase)
        {
            foreach (Control btn in uipl_EComEvent.Controls)
            {
                if (btn.Text == mCamerasBase.mCameraNo)
                {
                    return;
                }
            }
            UISymbolButton aButton = new UISymbolButton();
            aButton.Text = mCamerasBase.mCameraNo;
            aButton.Symbol = 61488;
            aButton.UseDoubleClick = true;
            aButton.BringToFront();
            aButton.Size = new Size(120, 24);
            aButton.Font = new Font("微软雅黑", 9F);
            aButton.Click += new EventHandler(ClickHandler);
            mBtnList.Add(aButton);
            uipl_EComEvent.Controls.Add(aButton);
            ArrangeButtons();
        }
        public void ClickHandler(object sender, EventArgs e)
        {
            UISymbolButton UIBtn = sender as UISymbolButton;
            if (UIBtn.Text.StartsWith("Dev"))
            {
                CameraSet mCameraFormSet = new CameraSet();
                CameraSet.mCamerasList = Sol.mSol.mCamerasList;
                mCameraFormSet.ShowDialog();
            }
            else
            {
                NetSet mCommunicationSet = new NetSet(Sol.mSol.mEComList);
                mCommunicationSet.ShowDialog();
            }
        }
        private void FrmNet_SizeChanged(object sender, EventArgs e)
        {
            ArrangeButtons();
        }
        /// <summary>
        /// 设置Panel容器中的Button自动排序
        /// </summary>
        /// <param name="panel">Panel控件</param>
        public void ArrangeButtons()
        {
            int x = 0, y = 0;
            Control.ControlCollection ct = uipl_EComEvent.Controls;
            for (int i = ct.Count - 1; i >= 0; i--)
            {
                ct[i].Location = new Point(x+10, y);
                x = x + ct[i].Width + 10;
                if (x + ct[i].Width > uipl_EComEvent.Width)
                {
                    x = 0;
                    y = y + ct[i].Height + 1;
                }
            }
        }
    }
}

