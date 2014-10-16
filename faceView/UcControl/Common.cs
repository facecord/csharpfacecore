using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace faceView.UcControl
{
    public class FaceCommon
    {
        #region 方法
        /// <summary>
        /// 获取已插USB摄像头硬件Id
        /// </summary>
        /// <returns></returns>
        public static List<string> GetCameraDeviceId()
        {
            List<string> _cameraList = new List<string>();
            FilterInfoCollection _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);//获取所有已插USB摄像头驱动信息
            if (_filterInfoCollection != null && _filterInfoCollection.Count > 0)
            {
                for (int i = 0; i < _filterInfoCollection.Count; i++)
                {
                    _cameraList.Add(_filterInfoCollection[i].MonikerString); //向集合中添加USB摄像头硬件Id
                }
                _cameraList.Remove(""); //移出空项
                return _cameraList;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
