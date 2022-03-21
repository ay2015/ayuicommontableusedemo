using AyTableViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Ay.MvcFramework;
using Ay.Framework.DataCreaters;
using Ay.Framework.WPF.Controls;
using Ay.Framework.WPF;

namespace AyTableViewDemo.Controllers
{
    public class AyDataViewDemo5Controller : Controller
    {
        private ObservableCollection<AyPerson> _Datas;

        /// <summary>
        /// 未填写
        /// </summary>
        public ObservableCollection<AyPerson> Datas
        {
            get { return _Datas; }
            set { Set(ref _Datas, value); }
        }


        private ObservableCollection<IAyCheckedItem> _SexCbo = new ObservableCollection<IAyCheckedItem>();

        public ObservableCollection<IAyCheckedItem> SexCbo
        {
            get { return _SexCbo; }
            set { Set(ref _SexCbo, value); }
        }

        /// <summary>
        /// 搜索
        /// </summary>
        public ActionResult Search { get; private set; }
        private DateTime? _DateFrom;

        /// <summary>
        /// 起始日期
        /// </summary>
        public DateTime? DateFrom
        {
            get { return _DateFrom; }
            set { Set(ref _DateFrom, value); }
        }

        private DateTime? _DateTo;

        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime? DateTo
        {
            get { return _DateTo; }
            set { Set(ref _DateTo, value); }
        }


        public AyDataViewDemo5Controller() : base()
        {
            ViewBag.CboSexSelect = "0";
            ViewBag.T1Busy = true;
            AyThread.Instance.RunNew<List<AyPerson>>(() =>
            {
                List<AyPerson> list = new List<AyPerson>();
                for (int i = 0; i < 20000; i++)
                {
                    AyPerson Model = new AyPerson();
                    if (i == 0)
                    {
                        Model.Name = "杨洋AY";
                    }
                    else
                    {
                        Model.Name = AyUserName.UserName();
                    }
                    Model.Sex = AyCommon.Rnd.Next(2);
                    Model.Telphone = AyPhone.PhoneNumber();
                    Model.Address = AyAddress.Address();
                    list.Add(Model);
                }

                return list;
            }, (returnDto) =>
            {
               Datas = returnDto.ToObservableCollection();
                ViewBag.T1Busy = false;
            });


            AyCheckBoxItemModel sm1 = new AyCheckBoxItemModel() { ItemText = "男", ItemValue = "0" };
            AyCheckBoxItemModel sm2 = new AyCheckBoxItemModel() { ItemText = "女", ItemValue = "1" };
            SexCbo.Add(sm1);
            SexCbo.Add(sm2);

          
            Search = inParam =>
            {

                StringBuilder sb = new StringBuilder();
                if (DateFrom.HasValue)
                {
                    sb.Append(DateFrom.Value.GetYYYYMMddDateTime() + "    ");
                }
                if (DateTo.HasValue)
                {
                    sb.Append(DateTo.Value.GetYYYYMMddDateTime() + "    ");
                }
                sb.Append(ViewBag.CboSexSelect.ItemText);
                AyMessageBox.ShowInformation(sb.ToString());
            };

        }

    }
}
