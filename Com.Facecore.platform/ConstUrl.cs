using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Facecore.platform
{
    public class ConstUrl
    {
        public static string URL_CN = "http://api.facecore.cn";
        //public static string URL_CN = "http://localhost:8011";
        //public static string URL_CN = "http://localhost:8080";


        /// <summary>
        /// 特征值检测URL
        /// </summary>
        public static string FaceDeteiveResouse = "/api/facedetect";

        /// <summary>
        /// 人脸相似度比对URL
        /// </summary>
        public static string FaceCompareResouse = "/api/facecompare";

        /// <summary>
        /// 特征值检测WebURL
        /// </summary>
        public static string UrlFaceDetect = "/api/urlfacedetect";
        /// <summary>
        /// 添加人脸信息
        /// </summary>
        public static string AddPersonFace = "/api/personface";
        /// <summary>
        /// 特征值检测（加年龄性别）
        /// </summary>
        public static string FaceDeteiveAgeAndSexResouse = "/api/facedetectageandsex";

    }
}