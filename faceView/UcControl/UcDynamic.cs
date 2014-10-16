using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Com.Facecore.platform;
using AForge.Video.DirectShow;
using Com.Facecore.platform.Common;
using AForge.Video;
using System.Threading;
using System.IO;

namespace faceView.UcControl
{
    public partial class UcDynamic : UserControl
    {
        FaceClient client = new FaceClient("2d7d715aaf2110973132cabbb4e11393");
        /// <summary>
        /// USB摄像头硬件Id集合
        /// </summary>
        private List<string> _cameraList = new List<string>();
        /// <summary>
        /// 视频驱动
        /// </summary>
        private VideoCaptureDevice _videoCaptureDevice;
        private Image imgobj;
        private Image ImgLoad { get; set; }
        private Image ImgLoad_Click { get; set; }

        public UcDynamic()
        {
            InitializeComponent();
            ImgLoad = Common.ConvertImage(Path.GetFullPath("Images\\button\\加载摄像头.png"));
            ImgLoad_Click = Common.ConvertImage(Path.GetFullPath("Images\\button\\加载摄像头-点击.png"));
            picLoad.Image = ImgLoad;
        }

        private void UcDynamic_Load(object sender, EventArgs e)
        {
            #region 填充摄像头下拉框
            _cameraList = FaceCommon.GetCameraDeviceId();//获取所有USB摄像头硬件Id集合
            if (_cameraList != null && _cameraList.Count > 0)
            {
                foreach (var item in _cameraList)
                {
                    cobxCameraList.Items.Add(item);//向下拉框中添加摄像头列表
                }
            }
            else
            {
                //如何未获取到USB摄像头则禁用此选择
                cobxCameraList.Enabled = false;
            }
            #endregion
        }
        /// <summary>
        /// 开启播放
        /// </summary>
        private void StartCamera()
        {
            if (_videoCaptureDevice != null)
            {
                _videoCaptureDevice.Start();
            }
        }
        /// <summary>
        /// 停止播放
        /// </summary>
        private void StopCamera()
        {
            if (_videoCaptureDevice != null)
            {
                _videoCaptureDevice.SignalToStop();
            }
        }

        /// <summary>
        /// 初始化摄像头
        /// </summary>
        private void InitialCamera()
        {
            if (this.cobxCameraList.SelectedItem != null)
            {
                _videoCaptureDevice = new VideoCaptureDevice(this.cobxCameraList.SelectedItem.ToString());
                _videoCaptureDevice.NewFrame += HandNewFrame;
            }
        }
        /// <summary>
        /// 播放事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void HandNewFrame(object sender, NewFrameEventArgs args)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    if (args != null)
                    {
                        this.picCamera.Image = args.Frame.Clone() as Image;
                        //GetPic(args.Frame.Clone() as Image);
                        imgobj = args.Frame.Clone() as Image;
                        //StartCheck(args.Frame.Clone() as Image);
                    }
                }));
                //this.picCamera.Image = args.Frame.Clone() as Image;
                //StartCheck(args.Frame.Clone() as Image);
            }
            catch (Exception exception)
            {
                //throw;
            }

        }
        private void btnLoading_Click(object sender, EventArgs e)
        {
            InitialCamera();
            StartCamera();
        }
        Thread th = null;
        private void StartCheck(Image _bitmap)
        {
            th = new Thread(new ParameterizedThreadStart(GetPic));
            th.Start(_bitmap);
        }
        object obj = new object();
        private void GetPic(object _bitmap)
        {
            //var image = Convert.ToBase64String(Common.GetFilebyte(_bitmap as Image));
            lock (obj)
            {
                var faceDetectResponse = client.FaceDetect(_bitmap as Image);
                if (faceDetectResponse.facemodels.Count == 0)
                {
                    Send(_bitmap as Image);
                    return;
                }
                Image bitmap = null;
                foreach (var model in faceDetectResponse.facemodels)
                {
                    bitmap = Common.DrawImage(_bitmap as Image, model.facerectanglex, model.facerectangley, model.facerectanglewidth, model.facerectangleheight);
                }
                Send(bitmap);
            }

        }
        private void Send(Image img)
        {
            if (this.picFeature.InvokeRequired)
            {
                SendMess mess = new SendMess(Send);
                this.picFeature.Invoke(mess, img);
            }
            else
            {
                this.picFeature.Image = img;
            }
        }
        public delegate void SendMess(Image img);
        int waittime = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (waittime > 0)
            {
                lblSpeed.Text = string.Format("检测倒计时{0}秒", waittime);
                waittime -= 1;
            }
            else
            {
                lblSpeed.Text = string.Format("检测倒计时{0}秒", waittime);
                waittime = 5;
                if (imgobj != null)
                    StartCheck(imgobj);
            }
        }

        private void picLoad_MouseEnter(object sender, EventArgs e)
        {
            picLoad.Image = ImgLoad_Click;
        }

        private void picLoad_MouseLeave(object sender, EventArgs e)
        {
            picLoad.Image = ImgLoad;
        }
        
    }
}
