using System.Collections.Generic;
using Ay.Framework.WPF;

namespace TableTest
{
    public class ShiftData
    {
        public  string GetShiftTypeName(int shiftType)
        {
            if (shiftType == 1)
                return "上午";
            else if (shiftType == 2)
                return "下午";
            else if (shiftType == 3)
                return "晚上";
            else
                return "";
        }

        private static ShiftData _Singleton = null;
        private static object _Lock = new object();
        internal static ShiftData CreateInstance()
        {
            if (_Singleton == null) //双if +lock
            {
                lock (_Lock)
                {
                    if (_Singleton == null)
                    {
                        _Singleton = new ShiftData();
                    }
                }
            }
            return _Singleton;
        }
        /// <summary>
        /// 对外操作实例
        /// </summary>
        public static ShiftData Instance
        {
            get
            {
                return CreateInstance();
            }
        }

        public void Reset()
        {
            _ShangWu = null;
            _XiaWu = null;
            _WanShang = null;
        }
        private List<SelectListItem> _ShangWu;

        public List<SelectListItem> ShangWu
        {
            get
            {
                if (_ShangWu == null)
                {
                    _ShangWu = GetShangWus();
                }
                return _ShangWu;
            }
        }
        private List<SelectListItem> _XiaWu;

        public List<SelectListItem> XiaWu
        {
            get
            {
                if (_XiaWu == null)
                {
                    _XiaWu = GetXiaWus();
                }
                return _XiaWu;
            }
        }
        private List<SelectListItem> _WanShang;

        public List<SelectListItem> WanShang
        {
            get
            {
                if (_WanShang == null)
                {
                    _WanShang = GetWanShangs();
                }
                return _WanShang;
            }
        }

        public List<SelectListItem> GetShangWus()
        {
            List<SelectListItem> t = new List<SelectListItem>();
            t.Add(new SelectListItem { Text = "A1 (08:00-10:00)", Value = "123" });
            t.Add(new SelectListItem { Text = "A2 (09:00-12:00)", Value = "1223" });
            t.Add(new SelectListItem { Text = "A3 (10:00-12:00)", Value = "1323" });
            return t;
        }
        public List<SelectListItem> GetXiaWus()
        {
            List<SelectListItem> t = new List<SelectListItem>();
            t.Add(new SelectListItem { Text = "B1 (12:00-14:00)", Value = "124" });
            t.Add(new SelectListItem { Text = "B2 (13:00-17:00)", Value = "1224" });
            t.Add(new SelectListItem { Text = "B3 (14:00-18:00)", Value = "1324" });
            return t;
        }
        public List<SelectListItem> GetWanShangs()
        {
            List<SelectListItem> t = new List<SelectListItem>();
            t.Add(new SelectListItem { Text = "C1 (18:00-20:00)", Value = "125" });
            t.Add(new SelectListItem { Text = "C2 (19:00-22:00)", Value = "1225" });
            t.Add(new SelectListItem { Text = "C3 (19:00-23:59)", Value = "1325" });
            t.Add(new SelectListItem { Text = "C4 (00:00-05:00)", Value = "1425" });
            t.Add(new SelectListItem { Text = "C5 (02:00-06:00)", Value = "1525" });
            return t;
        }
    }
}
