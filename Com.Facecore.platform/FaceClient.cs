using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using FaceCore.OpenPlatform.DTO;

namespace Com.Facecore.platform
{
    public class FaceClient
    {
        private string faceKey = string.Empty;
        private string faceUrlbase = string.Empty;
        public FaceClient(string key)
        {
            faceKey = key;
        }

        #region 特征值检测
        /// <summary>
        /// 特征值检测
        /// </summary>
        /// <param name="filePath">文件地址</param>
        /// <returns></returns>
        public FaceDetectResponse FaceDetect(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))//空
                return null;
            if (!File.Exists(Path.GetFullPath(filePath))) //文件不存在
                return null;
            FileStream fs = new FileStream(Path.GetFullPath(filePath), FileMode.Open);
            byte[] bs = new byte[fs.Length];
            fs.Read(bs, 0, bs.Length);
            fs.Close();
            fs.Dispose();
            return FaceDetect(bs);
        }
        /// <summary>
        /// 特征值检测
        /// </summary>
        /// <param name="img">包含人脸的Image对象</param>
        /// <returns></returns>
        public FaceDetectResponse FaceDetect(Image img)
        {
            if (img == null)
                return null;
            var newImage = new Bitmap(img);
            MemoryStream ms = new MemoryStream();
            newImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            newImage.Dispose();

            return FaceDetect(ms.ToArray());

        }
        /// <summary>
        /// 特征值检测
        /// </summary>
        /// <param name="bts">图片对象的byte数组</param>
        /// <returns></returns>
        public FaceDetectResponse FaceDetect(byte[] bts)
        {
            FaceHttp http = new FaceHttp();
            string image = Convert.ToBase64String(bts);
            //http.HttpPost("", "");
            FaceDetectRequest request = new FaceDetectRequest() { faceimage = image };
            string url = ConstUrl.URL_CN + ConstUrl.FaceDeteiveResouse + "?appkey=" + faceKey;
            var value = http.HttpPost(url, Newtonsoft.Json.JsonConvert.SerializeObject(request));
            return Newtonsoft.Json.JsonConvert.DeserializeObject<FaceDetectResponse>(value);
        }
        #endregion

        #region 特征值检测包含年龄性别
        /// <summary>
        /// 特征值检测
        /// </summary>
        /// <param name="filePath">文件地址</param>
        /// <returns></returns>
        public FaceDetectResponse FaceDetectAgeAndSex(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))//空
                return null;
            if (!File.Exists(Path.GetFullPath(filePath))) //文件不存在
                return null;
            FileStream fs = new FileStream(Path.GetFullPath(filePath), FileMode.Open);
            byte[] bs = new byte[fs.Length];
            fs.Read(bs, 0, bs.Length);
            fs.Close();
            fs.Dispose();
            return FaceDetectAgeAndSex(bs);
        }
        /// <summary>
        /// 特征值检测
        /// </summary>
        /// <param name="img">包含人脸的Image对象</param>
        /// <returns></returns>
        public FaceDetectResponse FaceDetectAgeAndSex(Image img)
        {
            if (img == null)
                return null;
            var newImage = new Bitmap(img);
            MemoryStream ms = new MemoryStream();
            newImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            newImage.Dispose();

            return FaceDetectAgeAndSex(ms.ToArray());

        }
        /// <summary>
        /// 特征值检测
        /// </summary>
        /// <param name="bts">图片对象的byte数组</param>
        /// <returns></returns>
        public FaceDetectResponse FaceDetectAgeAndSex(byte[] bts)
        {
            FaceHttp http = new FaceHttp();
            string image = Convert.ToBase64String(bts);
            //http.HttpPost("", "");
            FaceDetectRequest request = new FaceDetectRequest() { faceimage = image };
            string url = ConstUrl.URL_CN + ConstUrl.FaceDeteiveAgeAndSexResouse + "?appkey=" + faceKey;
            var value = http.HttpPost(url, Newtonsoft.Json.JsonConvert.SerializeObject(request));
            return Newtonsoft.Json.JsonConvert.DeserializeObject<FaceDetectResponse>(value);
        }
        #endregion

        #region 特征值比较
        /// <summary>
        /// 特征值比较
        /// </summary>
        /// <param name="facetrue1">特征值返回串</param>
        /// <param name="facetrue2">特征值返回串</param>
        public FaceCompareResponse FaceContrast(string facetrue1, string facetrue2)
        {
            FaceCompareRequest request = new FaceCompareRequest();
            request.facefeature1 = facetrue1;
            request.facefeature2 = facetrue2;
            string url = ConstUrl.URL_CN + ConstUrl.FaceCompareResouse + "?appkey=" + faceKey;
            FaceHttp http = new FaceHttp();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<FaceCompareResponse>(http.HttpPost(url, Newtonsoft.Json.JsonConvert.SerializeObject(request)));
        }
        #endregion
    }
}
