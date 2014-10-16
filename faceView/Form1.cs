using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using faceView.UcControl;
using Com.Facecore.platform.Common;
using System.IO;

namespace faceView
{
    public partial class Form1 : Form
    {
        private int mouseX = 0; private int mouseY = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.pnlLeftMenu.Controls.Clear();
            this.pnlLeftMenu.BackColor = Color.FromArgb(42, 57, 80); //左侧背景色
            this.pnlTitle.BackColor = Color.FromArgb(54, 72, 96); //标题栏颜色
            this.pnlContent.BackColor = Color.FromArgb(238,241,248);
            InitImg();
            bindItem();
            pictureBox1.Image = ImgClose;
            FormMove move = new FormMove();
            move.AddMoveForm(this.pnlTitle);

            UcIndex ucIndex = new UcIndex();
            this.pnlContent.Controls.Add(ucIndex);
            ucIndex.Show();

        }
        private void InitImg()
        {
            ImgDFaceCheck = Common.ConvertImage(Path.GetFullPath("Images/dfacecheck.png"));
            ImgDFaceCheck_Click = Common.ConvertImage(Path.GetFullPath("Images/dfacecheck_click.png"));
            ImgDFaceCompar = Common.ConvertImage(Path.GetFullPath("Images/dfacecom.png"));
            ImgDFaceCompar_Click = Common.ConvertImage(Path.GetFullPath("Images/dfacecom_click.png"));
            ImgFaceCheck = Common.ConvertImage(Path.GetFullPath("Images/facecheck.png"));
            ImgFaceCheck_Click = Common.ConvertImage(Path.GetFullPath("Images/facecheck_click.png"));
            ImgFaceCompar = Common.ConvertImage(Path.GetFullPath("Images/facecom.png"));
            ImgFaceCompar_Click = Common.ConvertImage(Path.GetFullPath("Images/facecom_click.png"));
            ImgOfflineHigh = Common.ConvertImage(Path.GetFullPath("Images/offlinehigh.png"));
            ImgOfflineHigh_Click = Common.ConvertImage(Path.GetFullPath("Images/offlinehigh_click.png"));
            ImgClose = Common.ConvertImage(Path.GetFullPath("Images/button/关闭.png"));
            ImgClose_Click = Common.ConvertImage(Path.GetFullPath("Images/button/关闭-点击.png"));
        }
        private Image ImgDFaceCheck { get; set; }
        private Image ImgDFaceCheck_Click { get; set; }
        private Image ImgDFaceCompar { get; set; }
        private Image ImgDFaceCompar_Click { get; set; }
        private Image ImgFaceCheck { get; set; }
        private Image ImgFaceCheck_Click { get; set; }
        private Image ImgFaceCompar { get; set; }
        private Image ImgFaceCompar_Click { get; set; }
        private Image ImgOfflineHigh { get; set; }
        private Image ImgOfflineHigh_Click { get; set; }
        private Image ImgClose { get; set; }
        private Image ImgClose_Click { get; set; }
        private void bindItem()
        {
            Common.GetFilebyte(Path.GetFullPath("facecheck.png"));
            Common.GetFilebyte(Path.GetFullPath("facecheck_click.png"));
            UcMenuItem itemface = new UcMenuItem();
            itemface.Name = "facecheck";
            itemface.EnterImage = ImgFaceCheck;
            itemface.LeaveImage = ImgFaceCheck_Click;
            itemface.Click += itemface_Click;
            UcMenuItem itemCom = new UcMenuItem();
            itemCom.Name = "facecompar";
            itemCom.EnterImage = ImgFaceCompar;
            itemCom.LeaveImage = ImgFaceCompar_Click;
            itemCom.Click += itemface_Click;
            UcMenuItem itemDynamic = new UcMenuItem();
            itemDynamic.Name = "facedynamic";
            itemDynamic.EnterImage = ImgDFaceCheck;
            itemDynamic.LeaveImage = ImgDFaceCheck_Click;
            itemDynamic.Click += itemface_Click;

            UcMenuItem itemDynamicCom = new UcMenuItem();
            itemDynamicCom.Name = "facedynamiccom";
            itemDynamicCom.EnterImage = ImgDFaceCompar;
            itemDynamicCom.LeaveImage = ImgDFaceCompar_Click;
            itemDynamicCom.Click += itemface_Click;

            UcMenuItem itemvideo = new UcMenuItem();
            itemvideo.Name = "Video";
            itemvideo.EnterImage = ImgOfflineHigh;
            itemvideo.LeaveImage = ImgOfflineHigh_Click;
            itemvideo.Click += itemface_Click;
            this.pnlLeftMenu.Controls.Add(itemface);
            this.pnlLeftMenu.Controls.Add(itemCom);
            this.pnlLeftMenu.Controls.Add(itemDynamic);
            this.pnlLeftMenu.Controls.Add(itemDynamicCom);
            this.pnlLeftMenu.Controls.Add(itemvideo);
        }
        string focusKey = string.Empty;
        void itemface_Click(object sender)
        {
            UcMenuItem item = sender as UcMenuItem;
            switch (item.Name)
            {
                case "facecheck"://人脸检测
                    if (focusKey != item.Name)
                    {
                        if (pnlContent.Controls.Count > 0)
                        {
                            UserControl uc = (UserControl)pnlContent.Controls[0];
                            uc.Dispose();
                        }
                        focusKey = item.Name;
                        UcFaceCheck compar = new UcFaceCheck();
                        this.pnlContent.Controls.Add(compar);
                        compar.Show();
                    }
                    break;
                case "facecompar": //人脸比对
                    if (focusKey != item.Name)
                    {
                        if (this.pnlContent .Controls.Count > 0)
                        {
                            UserControl uc = (UserControl)pnlContent.Controls[0];
                            uc.Dispose();
                        }
                        focusKey = item.Name;
                        UcCompar compar = new UcCompar();
                        this.pnlContent.Controls.Add(compar);
                        compar.Show();
                    }
                    break;
                case "facedynamic": //对态人脸
                    if (focusKey != item.Name)
                    {
                        if (this.pnlContent .Controls.Count > 0)
                        {
                            UserControl uc = (UserControl)pnlContent.Controls[0];
                            uc.Dispose();
                        }
                        focusKey = item.Name;
                        UcDynamic compar = new UcDynamic();
                        this.pnlContent.Controls.Add(compar);
                        compar.Show();
                    }
                    break;
                case "facedynamiccom": //对态人脸
                    if (focusKey != item.Name)
                    {
                        if (this.pnlContent .Controls.Count > 0)
                        {
                            UserControl uc = (UserControl)pnlContent.Controls[0];
                            uc.Dispose();
                        }
                        focusKey = item.Name;
                        UcDynamicCom compar = new UcDynamicCom();
                        this.pnlContent.Controls.Add(compar);
                        compar.Show();
                    }
                    break;
                case "Video":
                    MessageBox.Show("请和FaceCore取得联系，从而获得更佳的人脸识别技术体验~~~");
                    break;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pnlContent.Controls.Count > 0 )
            {
                pnlContent.Controls[0].Dispose();  
            }
            this.Close();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = ImgClose_Click;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = ImgClose;
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            //mouseX = e.X; mouseY = e.Y;
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left) 
            //{ 
            //    this.Location = new Point(Control.MousePosition.X - mouseX, Control.MousePosition.Y - mouseY); 
            //}
        }
    }
}
