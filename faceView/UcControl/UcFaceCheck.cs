using System;
using System.Drawing;
using System.Windows.Forms;
using Com.Facecore.platform;
using Com.Facecore.platform.Common;
using System.IO;
using System.Text.RegularExpressions;

namespace faceView.UcControl
{
    public partial class UcFaceCheck : UserControl
    {
        private Image ImgSelect { get; set; }
        private Image ImgSelect_Click { get; set; }
        private Image ImgLoading { get; set; }
        private Image ImgLoading_Click { get; set; }
        public UcFaceCheck()
        {
            InitializeComponent();
            ImgSelect = Common.ConvertImage(Path.GetFullPath("Images\\button\\选择图片.png"));
            ImgSelect_Click = Common.ConvertImage(Path.GetFullPath("Images\\button\\选择图片-点击.png"));
            ImgLoading = Common.ConvertImage(Path.GetFullPath("Images\\button\\加载-人脸检测.png"));
            ImgLoading_Click = Common.ConvertImage(Path.GetFullPath("Images\\button\\加载-点击-人脸检测.png"));
            //btnSelect.BackgroundImage = ImgSelect;
            //btnLoad.BackgroundImage = ImgLoading;
            picSelect.Image = ImgSelect;
            picLoad.Image = ImgLoading;
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
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string filename = SelectPicture();
            txtFilePath.Text = filename;
            
        }
        private void loadImage(string filename)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                FaceClient client = new FaceClient("8c1be718fa976083a6940009f36c056e");
                byte[] bt = Common.GetFilebyte(filename);
                var face = client.FaceDetect(bt);//获取特征值
                //var face = client.FaceDetectAgeAndSex(bt);
                picSource.Image = Image.FromStream(new MemoryStream(bt));
                if (face != null && face.facemodels.Count > 0)
                {
                    Image img = Image.FromStream(new MemoryStream(bt));
                    foreach (var model in face.facemodels)
                    {
                        img = Common.DrawImage(img, model.facerectanglex, model.facerectangley, model.facerectanglewidth, model.facerectangleheight);
                    }
                    picCheck.Image = img;
                }
                else
                {
                    MessageBox.Show("未读取到人脸信息");
                }

            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text))
                return;
            Regex regEx = new Regex("^(http|https|ftp)\\://([a-zA-Z0-9\\.\\-]+(\\:[a-zA-" + "Z0-9\\.&%\\$\\-]+)*@)?((25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{" + "2}|[1-9]{1}[0-9]{1}|[1-9])\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}" + "[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\\.(25[0-5]|2[0-4][0-9]|" + "[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\\.(25[0-5]|2[0-" + "4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])|([a-zA-Z0" + "-9\\-]+\\.)*[a-zA-Z0-9\\-]+\\.[a-zA-Z]{2,4})(\\:[0-9]+)?(/" + "[^/][a-zA-Z0-9\\.\\,\\?\\'\\\\/\\+&%\\$\\=~_\\-@]*)*$");
            if (regEx.IsMatch(txtFilePath.Text))
            {//URL验证
                string filepath = AppDomain.CurrentDomain.BaseDirectory+"\\DownFile";
                if(!Directory.Exists(filepath))
                    Directory.CreateDirectory(filepath);
                string filename = filepath+"\\"+DateTime.Now.ToString("yyyyMMddHHmmss")+".jpg";
                try
                {
                    Download.DownloadFile(txtFilePath.Text, filename);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("下载文件失败");
                    return;
                }
                if (File.Exists(filename))
                {
                    loadImage(filename);
                }

            }
            else
                loadImage(txtFilePath.Text);
        }
        private void pnlbg_Click(object sender, EventArgs e)
        {
            Panel pnl = sender as Panel;
            if (pnl != null)
            {
                //byte[] bts = Common.GetFilebyte(pnl.BackgroundImage);
                picSource.Image = pnl.BackgroundImage;
                FaceClient client = new FaceClient("8c1be718fa976083a6940009f36c056e");
                var face = client.FaceDetect(picSource.Image);//获取特征值
                //var face = client.FaceDetectAgeAndSex(picSource.Image);//获取特征值
                if (face != null && face.facemodels.Count > 0)
                {
                    byte[] bts = Common.GetFilebyte(pnl.BackgroundImage);
                    Image img = Image.FromStream(new MemoryStream(bts));

                    foreach (var model in face.facemodels)
                    {
                        string strInfo = string.Format("左眼坐标(X:{0},Y{1}) 右眼坐标(X:{2},Y{3})", model.lefteye.x, model.lefteye.y
                                                                    , model.righteye.x, model.righteye.y);
                        //string strInfo = string.Format("性别:{0},年龄{1}", model.ageandsex.sex == "Female" ? "女" : "男", model.ageandsex.age.ToString("0.00"));
                        img = Common.DrawImage(img, model.facerectanglex, model.facerectangley, model.facerectanglewidth, model.facerectangleheight);
                       
                    }
                    picCheck.Image = img;
                }
            }
        }
        private void btnSelect_Enter(object sender, EventArgs e)
        {
            //btnSelect.BackgroundImage = ImgSelect_Click;
            picSelect.Image = ImgSelect_Click;
        }
        private void btnSelect_Leave(object sender, EventArgs e)
        {
            //btnSelect.BackgroundImage = ImgSelect;
            picSelect.Image = ImgSelect;
        }

        private void btnLoad_Enter(object sender, EventArgs e)
        {
            //btnLoad.BackgroundImage = ImgLoading_Click;
            picLoad.Image = ImgLoading_Click;
        }

        private void btnLoad_Leave(object sender, EventArgs e)
        {
            //btnLoad.BackgroundImage = ImgLoading;
            picLoad.Image = ImgLoading;
        }
    }
}
