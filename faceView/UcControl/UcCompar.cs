using System;
using System.Drawing;
using System.Windows.Forms;
using Com.Facecore.platform;
using System.IO;
using Com.Facecore.platform.Common;

namespace faceView.UcControl
{
    public partial class UcCompar : UserControl
    {
        public UcCompar()
        {
            InitializeComponent();
            ImgSelect = Common.ConvertImage(Path.GetFullPath("Images\\button\\选择照片-人脸比对认证.png"));
            ImgSelect_Click = Common.ConvertImage(Path.GetFullPath("Images\\button\\选择照片-点击-人脸比对认证.png"));
            ImgCompar = Common.ConvertImage(Path.GetFullPath("Images\\button\\开始比对-人脸比对认证.png"));
            ImgCompar_Click = Common.ConvertImage(Path.GetFullPath("Images\\button\\开始比对-点击-人脸比对认证.png"));
            pic1Select.Image = ImgSelect;
            pic2Select.Image = ImgSelect;
            picCompar.Image = ImgCompar;
        }
        private Image ImgSelect { get; set; }
        private Image ImgSelect_Click { get; set; }
        private Image ImgCompar { get; set; }
        private Image ImgCompar_Click { get; set; }
        string face1true = string.Empty;
        string face2true = string.Empty;
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
        private void btn1Select_Click(object sender, EventArgs e)
        {
            string filename = SelectPicture();
            if (!string.IsNullOrEmpty(filename))
            {               
                FaceClient client = new FaceClient("8c1be718fa976083a6940009f36c056e");
                byte[] bt = GetFilebyte(filename);
                var face = client.FaceDetect(filename);//获取特征值
                pic1.Image = Image.FromStream(new MemoryStream(bt));
                if (face != null && face.facemodels.Count > 0)
                {
                    face1true = face.facemodels[0].base64feature;
                }
                else
                {
                    MessageBox.Show("未读取到人脸信息");
                    pic1.Image = null;
                    face1true = string.Empty;
                }
            }
            else
            {
                pic1.Image = null;
                face1true = string.Empty;
            }

        }
        private byte[] GetFilebyte(string filename)
        {
            if (File.Exists(filename))
            {
                FileStream stream = new FileStream(filename, FileMode.Open);
                byte[] bts = new byte[stream.Length];
                stream.Read(bts, 0, bts.Length);
                stream.Close();
                stream.Dispose();
                return bts;
            }
            return null;
        }
        private void btn2Select_Click(object sender, EventArgs e)
        {
            string filename = SelectPicture();
            if (!string.IsNullOrEmpty(filename))
            {
                FaceClient client = new FaceClient("8c1be718fa976083a6940009f36c056e");
                byte[] bt = GetFilebyte(filename);
                var face = client.FaceDetect(bt);//获取特征值
                pic2.Image = Image.FromStream(new MemoryStream(bt));
                if (face != null && face.facemodels.Count > 0)
                {
                    face2true = face.facemodels[0].base64feature;
                }
                else
                {
                    MessageBox.Show("未读取到人脸信息");
                    pic2.Image = null;
                    face2true = string.Empty;
                }

            }
            else
            {
                pic2.Image = null;
                face2true = string.Empty;
            }
        }
        private void btnCompar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(face1true) || string.IsNullOrEmpty(face2true))
            {
                MessageBox.Show("缺少人脸信息");
                return;
            }
            FaceClient client = new FaceClient("8c1be718fa976083a6940009f36c056e");
            var contrast = client.FaceContrast(face1true, face2true);
            if (contrast != null)
            {
                lblCompar.Text = "相似度" + (contrast.similar * 100).ToString("0.00") + "%";
            }
        }

        private void pic2Select_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.Image = ImgSelect_Click;
        }

        private void pic2Select_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.Image = ImgSelect;

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
