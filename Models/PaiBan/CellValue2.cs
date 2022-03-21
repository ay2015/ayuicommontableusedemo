using Ay.MvcFramework;
using System;

namespace TableTest.Models
{
    public class CellValue2 : Model
    {
        private Schedule _Schedule;

        /// <summary>
        /// 单元格对象,如果空就没有设置
        /// </summary>
        public Schedule Schedule
        {
            get { return _Schedule; }
            set { _Schedule = value; }
        }
        public string DoctorId { get; set; }
        public string DoctorName { get; set; }

        public DateTime Date { get; set; }
        private int _Value;

        public int Value
        {
            get { return _Value; }
            set { Set(ref _Value, value); }
        }
        public int ShiftType { get; set; }
    }

}

