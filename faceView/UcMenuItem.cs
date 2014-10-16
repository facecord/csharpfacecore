using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace faceView
{
    public partial class UcMenuItem : UserControl
    {
        public UcMenuItem()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 鼠标进入时
        /// </summary>
        public Image EnterImage { get; set; }
        /// <summary>
        /// 鼠标离开时
        /// </summary>
        public Image LeaveImage { get; set; }
        private void pic_MouseEnter(object sender, EventArgs e)
        {//移入
            pic.Image = EnterImage;
        }
        private void pic_MouseLeave(object sender, EventArgs e)
        {//离开
            pic.Image = LeaveImage;
        }

        private void pic_Click(object sender, EventArgs e)
        {
            if (Click != null)
                Click(this);
        }

        public event OnItemClick Click;

        private void UcMenuItem_Click(object sender, EventArgs e)
        {
            pic_Click(null, null);
        }

        private void UcMenuItem_Load(object sender, EventArgs e)
        {
            pic.Image = LeaveImage;
        }

    }
    public delegate void OnItemClick(object sender);
}
