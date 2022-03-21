using Ay.MvcFramework;
using System;
using System.Collections.Generic;

namespace TableTest.Models
{
    public class CellValue : Model
    {
        private List<Schedule> _Schedule;

        /// <summary>
        /// 单元格对象,如果空就没有设置
        /// </summary>
        public List<Schedule> Schedule
        {
            get { return _Schedule; }
            set { _Schedule = value; }
        }
        public string DoctorId { get; set; }
        public string DoctorName { get; set; }

        public DateTime Date { get; set; }
        private int _ShangWu;

        public int ShangWu
        {
            get { return _ShangWu; }
            set { Set(ref _ShangWu, value); }
        }

        private int _XiaWu;

        public int XiaWu
        {
            get { return _XiaWu; }
            set { Set(ref _XiaWu, value); }
        }
        private int _WanShang;

        public int WanShang
        {
            get { return _WanShang; }
            set { Set(ref _WanShang, value); }
        }

    }

}

