using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace faceView
{
    public class Download
    {
        public static  void DownloadFile(string URL, string filename, System.Windows.Forms.ProgressBar prog)
        {
            try
            {

                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                long totalBytes = myrp.ContentLength;
                if (prog != null)
                {
                    prog.Maximum = (int)totalBytes;
                }
                System.IO.Stream st = myrp.GetResponseStream();
                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;
                    System.Windows.Forms.Application.DoEvents();
                    so.Write(by, 0, osize);
                    if (prog != null)
                    {
                        prog.Value = (int)totalDownloadedByte;
                    }
                    osize = st.Read(by, 0, (int)by.Length);
                }
                so.Close();
                st.Close();
            }
            catch (System.Exception)
            {
                throw;
            }

        }
        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="URL">下载文件地址</param>
        /// <param name="Filename">下载后的存放地址</param>
        public static void DownloadFile(string URL, string filename)
        {
            DownloadFile(URL, filename, null);
        }
        public static bool IsUrl(string str_url)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str_url, @"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="fileExt"></param>
        /// <returns></returns>
        public static bool CheckFileTypeForImage(string fileExt)
        {
            List<string> skey = new List<string>() { ".jpg", ".jpeg", ".bmp", ".gif", ".png", ".tif" };
            return skey.Contains(fileExt.ToLower());
        }
    }
}
