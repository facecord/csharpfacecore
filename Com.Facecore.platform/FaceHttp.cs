using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Com.Facecore.platform
{
    public class FaceHttp
    {

        public string HttpPost(string url, string data)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/json";
            byte[] bs = Encoding.UTF8.GetBytes(data);
            Stream reqStream = request.GetRequestStream();
            reqStream.Write(bs, 0, bs.Length);
            reqStream.Close();

            string responseString = null;
            try
            {
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    responseString = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception exception)
            {
                //请求错误
            }
           
            return responseString;
        }
    }
}
