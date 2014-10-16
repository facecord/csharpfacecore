using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Com.Facecore.platform
{
    public static class ImageHelper
    {
        /// <summary>
        /// 将byte[]类型转换为Image类型
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static Bitmap ByteToImage(byte[] arr)
        {
            Bitmap image = null;
            if (arr != null)
            {
                MemoryStream mymemorystream = new MemoryStream(arr);
                image = (Bitmap)Bitmap.FromStream(mymemorystream);
                mymemorystream.Dispose();
            }
            return image;
        }

        /// <summary>
        /// 将Image类型转换为byte[]类型
        /// </summary>
        /// <param name="pic"></param>
        /// <returns></returns>
        public static byte[] ImageToByte(Bitmap image)
        {
            if (image != null)
            {
                var newImage = new Bitmap(image);
                MemoryStream ms = new MemoryStream();
                newImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                newImage.Dispose();
                return ms.ToArray();
            }
            else
            {
                return null;
            }
        }
    }
}
