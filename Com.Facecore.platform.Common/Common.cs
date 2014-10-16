using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Com.Facecore.platform.Common
{
    /// <summary>
    /// 公用方法类
    /// </summary>
    public class Common
    {
        /// <summary>
        /// 将指定位置矩形框绘制在图片上
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="with"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static Image DrawImage(Image bitmap, int x, int y, int with, int height)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                var rectangle = new Rectangle(x, y, with, height);
                g.DrawRectangle(new Pen(Color.Red, 2), rectangle);
            }
            return bitmap;
        }
        public static Image DrawImage(Image bitmap, Rectangle rect)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                var rectangle = rect;
                g.DrawRectangle(new Pen(Color.Red, 2), rectangle);
            }
            return bitmap;
        }

        public static Image DrawImage(Image bitmap, int x, int y, int with, int height, string strPrintInfo)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                var rectangle = new Rectangle(x, y, with, height);
                g.DrawRectangle(new Pen(Color.Red, 2), rectangle);
                Font f = new Font("宋体", 20, FontStyle.Bold, GraphicsUnit.Point);
                g.DrawString(strPrintInfo, f, Brushes.Green, new PointF(5, 5));
            }
            return bitmap;
        }
        public static Image DrawImage(Image bitmap, Rectangle rect, string strPrintInfo)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                var rectangle = rect;
                g.DrawRectangle(new Pen(Color.Red, 2), rectangle);
                Font f = new Font("宋体", 20, FontStyle.Bold, GraphicsUnit.Point);
                g.DrawString(strPrintInfo, f, Brushes.Green, new PointF(5, 5));
            }
            return bitmap;
        }
        /// <summary>
        /// 文件转换为BYTE
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static byte[] GetFilebyte(string filename)
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
        public static byte[] GetFilebyte(Image img)
        {
            MemoryStream stream = new MemoryStream();
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
            return stream.ToArray();
        }
        public static byte[] GetFilebyte(Image img, System.Drawing.Imaging.ImageFormat format)
        {
            MemoryStream stream = new MemoryStream();
            img.Save(stream, format);
            return stream.ToArray();
        }
        public static Image ConvertImage(string filename)
        {
            byte[] bts = GetFilebyte(filename);
            if (bts == null)
                return null;
            return Image.FromStream(new MemoryStream(bts));
        }
    }
}
