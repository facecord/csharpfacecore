using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Com.Facecore.platform;
using AForge.Video.DirectShow;
using Com.Facecore.platform.Common;
using AForge.Video;
using System.Threading;
using FaceCore.OpenPlatform.DTO.Models;
using System.IO;

namespace faceView.UcControl
{
    public partial class UcDynamicCom : UserControl
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
        private string facetrue1 = string.Empty;//照片的人脸信息
        public UcDynamicCom()
        {
            InitializeComponent();
        }
        private Image ImgLoad { get; set; }
        private Image ImgLoad_Click { get; set; }
        private Image ImgPhoto { get; set; }
        private Image ImgPhoto_Click { get; set; }
        private Image ImgSelect { get; set; }
        private Image ImgSelect_Click { get; set; }
        private Image ImgCompar { get; set; }
        private Image ImgCompar_Click { get; set; }
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
            ImgLoad = Common.ConvertImage(Path.GetFullPath("Images\\button\\加载摄像头.png"));
            ImgLoad_Click = Common.ConvertImage(Path.GetFullPath("Images\\button\\加载摄像头-点击.png"));
            ImgPhoto = Common.ConvertImage(Path.GetFullPath("Images\\button\\拍照-动态人脸比对.png"));
            ImgPhoto_Click = Common.ConvertImage(Path.GetFullPath("Images\\button\\拍照-点击-动态人脸比对.png"));
            ImgSelect = Common.ConvertImage(Path.GetFullPath("Images\\button\\选择照片-动态人脸比对.png"));
            ImgSelect_Click = Common.ConvertImage(Path.GetFullPath("Images\\button\\选择照片-点击-动态人脸比对.png"));
            ImgCompar = Common.ConvertImage(Path.GetFullPath("Images\\button\\开始比对-动态人脸比对.png"));
            ImgCompar_Click = Common.ConvertImage(Path.GetFullPath("Images\\button\\开始比对-点击-动态人脸比对.png"));
            picLoad.Image = ImgLoad;
            picPhoto.Image = ImgPhoto;
            picSelect.Image = ImgSelect;
            picCompar.Image = ImgCompar;
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
                        imgobj = args.Frame.Clone() as Image;
                    }
                }));

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
                    return;
                }
                Image bitmap = null;
                float avalue = 0;
                int imgIndex = 0;
                FaceModel facemodel = null;
                for (int i = 0; i < faceDetectResponse.facemodels.Count; i++)
                {
                    var model = faceDetectResponse.facemodels[i];
                    float o = client.FaceContrast(facetrue1, model.base64feature).similar;
                    if (o > avalue)
                    {
                        avalue = o;
                        facemodel = model;
                    }
                    //bitmap = Common.DrawImage(_bitmap as Image, model.facerectanglex, model.facerectangley, model.facerectanglewidth, model.facerectangleheight);

                }
                bitmap = Common.DrawImage(_bitmap as Image, facemodel.facerectanglex, facemodel.facerectangley, facemodel.facerectanglewidth, facemodel.facerectangleheight);
                Send(bitmap, avalue);
            }

        }
        private void Send(Image img, float value)
        {
            if (this.picTemp.InvokeRequired)
            {
                SendMess mess = new SendMess(Send);
                this.picTemp.Invoke(mess, img, value);
            }
            else
            {
                this.picTemp.Image = img;
                lblCom.Text = string.Format("相似度{0}%", (value * 100).ToString("0.00"));
            }
        }
        public delegate void SendMess(Image img, float value);
        int waittime = 10;
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
                waittime = 10;
                if (imgobj != null)
                    StartCheck(imgobj);
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            if (imgobj == null)
                return;
            Image _bitmap = imgobj.Clone() as Image;
            var faceDetectResponse = client.FaceDetect(_bitmap);
            if (faceDetectResponse.facemodels.Count == 0)
            {
                MessageBox.Show("未检测到人脸信息！");
                return;
            }
            Image bitmap = null;
            foreach (var model in faceDetectResponse.facemodels)
            {
                bitmap = Common.DrawImage(_bitmap as Image, model.facerectanglex, model.facerectangley, model.facerectanglewidth, model.facerectangleheight);
                facetrue1 = model.base64feature;
                break;
            }
            picFeature.Image = bitmap;
        }
        private void btnCompar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(facetrue1))
            {
                MessageBox.Show("无比对人员照片");
                return;
            }
            this.timer1.Enabled = true;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string filename = SelectPicture();
            if (!string.IsNullOrEmpty(filename))
            {
                byte[] bts = Common.GetFilebyte(filename);
                var request = client.FaceDetect(bts);
                if (request != null && request.facemodels.Count > 0)
                {
                    var model = request.facemodels[0];
                    facetrue1 = model.base64feature;
                    Image img = Image.FromStream(new MemoryStream(bts));
                    Image imgphoto = Common.DrawImage(img, model.facerectanglex, model.facerectangley, model.facerectanglewidth, model.facerectangleheight);
                    picFeature.Image = imgphoto;
                }
                else
                {
                    facetrue1 = string.Empty;
                    picFeature.Image = null;
                    MessageBox.Show("选择的照片上未发现人脸！");
                    return;
                }
            }

        }
        private string SelectPicture()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter =
                "JPEG File Interchange Format (*.jpg)|*.jpg;*.jpeg|" +
                "Windows Bitmap(*.bmp)|*.bmp|" +
                "Graphics Interchange Format (*.gif)|(*.gif)|" +
                "Portable Network Graphics (*.png)|*.png|" +
                "Tag Image File Format (*.tif)|*.tif;*.tiff";
            openFileDialog.ShowDialog();
            return openFileDialog.FileName;
        }

        private void picLoad_MouseEnter(object sender, EventArgs e)
        {
            picLoad.Image = ImgLoad_Click;
        }
        private void picLoad_MouseLeave(object sender, EventArgs e)
        {
            picLoad.Image = ImgLoad;
        }
        private void picPhoto_MouseEnter(object sender, EventArgs e)
        {
            picPhoto.Image = ImgPhoto_Click;
        }
        private void picPhoto_MouseLeave(object sender, EventArgs e)
        {
            picPhoto.Image = ImgPhoto;
        }
        private void picSelect_MouseEnter(object sender, EventArgs e)
        {
            picSelect.Image = ImgSelect_Click;
        }
        private void picSelect_MouseLeave(object sender, EventArgs e)
        {
            picSelect.Image = ImgSelect;
        }
        private void picCompar_MouseEnter(object sender, EventArgs e)
        {
            picCompar.Image = ImgCompar_Click;
        }
        private void picCompar_MouseLeave(object sender, EventArgs e)
        {
            picCompar.Image = ImgCompar;
        }
    }
}
