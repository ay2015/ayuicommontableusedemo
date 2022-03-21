using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableTest
{
    public class Schedule
    {
        /// <summary>
        /// 排班的唯一ID
        /// </summary>
        public int ScheduleId { get; set; }
        /// <summary>
        /// 排班日期
        /// </summary>
        public DateTime ScheduleTime { get; set; }
        /// <summary>
        /// 医生ID
        /// </summary>
        public int DoctorId { get; set; }
        /// <summary>
        /// 医生姓名
        /// </summary>
        public string DoctorName { get; set; }
        /// <summary>
        /// 班次类型：1 上午 2 下午 3 晚上
        /// </summary>
        public int ShiftType { get; set; }

        /// <summary>
        /// 班次类型：1 上午 2 下午 3 晚上
        /// </summary>
        public string ShiftTypeName { get; set; }
        /// <summary>
        /// 班次ID
        /// </summary>
        public int ShiftId { get; set; }
        /// <summary>
        /// 班次名称
        /// </summary>
        public string ShiftName { get; set; }

        /// <summary>
        /// 是否停诊
        /// </summary>
        public bool IsStop { get; set; }
    }
}
