
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Ay.MvcFramework;
using TableTest;
using Ay.Framework.WPF;
using TableTest.Models;

namespace AyTableViewDemo.Controllers
{
    public class ShuPaiBanController : Controller
    {

        public ObservableCollection<Humans> Datas { get; set; } = new ObservableCollection<Humans>();

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartDateTime { get; set; }
        public int DateDiff { get; set; }
        int doctornumber = 10;

        public ShuPaiBanController()
        {
            StartDateTime = DateTime.Today;
            DateDiff = 7;

            var _sechedules = GetSchedules();
            //获得所有医生
            var _doctors = GetDoctors();

            foreach (var item in _doctors)
            {
                var _getpaiban = _sechedules.Where(x => x.DoctorId.Equals(item.DoctorId)).OrderBy(x => x.ScheduleTime).ToList();

                Humans humans = new Humans();
                humans.ID = item.DoctorId.ToString();
                humans.UserName = item.DoctorName;

                for (int j = 1; j <= DateDiff; j++) //保证每天都有对象
                {
                    CellValue cv = new CellValue();
                    cv.DoctorId = item.DoctorId.ToString();
                    cv.DoctorName = item.DoctorName.ToString();
                    var _gday = StartDateTime.AddDays(j);
                    cv.Date = _gday;
                    humans.Data.Add(cv);
                    var _getdatedatas = _getpaiban.Where(x => x.ScheduleTime == _gday);
                    cv.Schedule = new List<Schedule>();
                    foreach (var schedule in _getdatedatas)
                    {
                        cv.Schedule.Add(schedule);
                        if (schedule.ShiftType == 1)
                        {
                            cv.ShangWu = schedule.ShiftId;
                        }
                        else if (schedule.ShiftType == 2)
                        {
                            cv.XiaWu = schedule.ShiftId;
                        }
                        else if (schedule.ShiftType == 3)
                        {
                            cv.WanShang = schedule.ShiftId;
                        }
                    }
                }
                Datas.Add(humans);
            }

        }


        #region 模拟和创造数据

        private List<Doctor> GetDoctors()
        {
            List<Doctor> LstDoctor = new List<Doctor>();
            for (int i = 0; i < doctornumber; i++)
            {
                Doctor d = new Doctor();
                d.DoctorId = i;
                d.DoctorName = "杨洋" + i.ToString();
                LstDoctor.Add(d);
            }
            return LstDoctor;
        }
        private List<Schedule> GetSchedules()
        {
            List<Schedule> LstSchedule = new List<Schedule>();
            Random ds = new Random();
            for (int i = 0; i < doctornumber; i++)
            {
                for (int j = 1; j <= DateDiff; j++)
                {
                    Schedule schedule = new Schedule();
                    schedule.ScheduleId = ds.Next(1, 10000);
                    schedule.DoctorName = "杨洋" + i.ToString();
                    schedule.DoctorId = i;
                    var scheduleTime = StartDateTime.AddDays(j);
                    schedule.ScheduleTime = scheduleTime;

                    var shiftType = ds.Next(1, 4);

                    schedule.ShiftType = shiftType;
                    schedule.ShiftTypeName = ShiftData.Instance.GetShiftTypeName(shiftType);

                    var shift = GetRandomShift(shiftType);
                    schedule.ShiftId = shift.Value.ToInt();
                    schedule.ShiftName = shift.Text;

                    int x = ds.Next();
                    schedule.IsStop = (x % 2 == 0);
                    if (schedule.IsStop)
                    {
                        schedule.ShiftId = -1;
                        schedule.ShiftName = "停诊";
                    }
                    LstSchedule.Add(schedule);
                }
            }
            return LstSchedule;
        }
        private SelectListItem GetRandomShift(int shiftType)
        {
            if (shiftType == 1)
            {
                Random ds = new Random();
                //获得随机班次的类型，上午随便哪种排班
                var _1 = ds.Next(0, ShiftData.Instance.ShangWu.Count);
                return ShiftData.Instance.ShangWu[_1];
            }
            else if (shiftType == 2)
            {
                Random ds = new Random();
                //获得随机班次的类型，上午随便哪种排班
                var _1 = ds.Next(0, ShiftData.Instance.XiaWu.Count);
                return ShiftData.Instance.XiaWu[_1];
            }
            else if (shiftType == 3)
            {
                Random ds = new Random();
                //获得随机班次的类型，上午随便哪种排班
                var _1 = ds.Next(0, ShiftData.Instance.WanShang.Count);
                return ShiftData.Instance.WanShang[_1];
            }
            else
            {
                return new SelectListItem { Text = "", Value = "0" };
            }
        }

        #endregion
        /// <summary>
        /// 暂时用不上
        /// </summary>
        /// <param name="shiftType"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private SelectListItem GetShift(int shiftType, string value)
        {
            if (shiftType == 1)
            {
                return ShiftData.Instance.ShangWu?.FirstOrDefault(x => x.Value.Equals(value));
            }
            else if (shiftType == 2)
            {
                return ShiftData.Instance.XiaWu?.FirstOrDefault(x => x.Value.Equals(value));
            }
            else if (shiftType == 3)
            {
                return ShiftData.Instance.WanShang?.FirstOrDefault(x => x.Value.Equals(value));
            }
            else
            {
                return new SelectListItem { Text = "", Value = "0" };
            }
        }

     


    }
}
