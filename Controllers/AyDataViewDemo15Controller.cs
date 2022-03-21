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
using Ay.Framework.WPF;
using Ay.Framework.WPF.Controls;

namespace AyTableViewDemo.Controllers
{
    public class AyDataViewDemo15Controller : Controller
    {
        private List<SelectListItemNoNotify> _SexCbo = new List<SelectListItemNoNotify>();

        public List<SelectListItemNoNotify> SexCbo
        {
            get { return _SexCbo; }
            set { Set(ref _SexCbo, value); }
        }
        public ObservableCollection<AyPerson> Datas { get; set; } = new ObservableCollection<AyPerson>();
        public AyDataViewDemo15Controller() : base()
        {
            for (int i = 0; i < 10000; i++)
            {
                AyPerson Model = new AyPerson();
                var _1 = (i + 1).ToString();
                Model.Name = "杨洋" + _1;
                Model.Sex = AyCommon.Rnd.Next(2);
                Model.Family = new Family { Father="AY爸爸"+ _1 ,Mother="AY妈妈"+ _1 };
                Model.Telphone = AyPhone.PhoneNumber();
                Model.Address = AyAddress.Address();
                Model.ShouRu = (AyCommon.Rnd.Next(1000, 10000));
                Model.GetDaXue = AyCommon.Rnd.NextBool();
                Datas.Add(Model);
            }


            SexCbo.Add(new SelectListItemNoNotify { Text = "男", Value = "0" });
            SexCbo.Add(new SelectListItemNoNotify { Text = "女", Value = "1" });


            //RowEditBeginAction = inParam =>
            //{
            //    var _1 = inParam as object[];
            //    var _2 = _1[2] as AyTableViewRowEventArgs;
            //    if (_2.IsNotNull())
            //    {
            //        var _3 = _2.Data as AyPerson;
            //        ViewBag.Remo = "ID:" + _3.AYID + ",正在处理:" + _3.Name+","+(_3.Sex==0?"男":"女")+","+_3.ShouRu+","+_3.Telphone+","+_3.GetDaXue+","+_3.Address;
            //    }
            //};


            //RowEditEndAction = inParam =>
            //{
            //    var _1 = inParam as object[];
            //    var _2 = _1[2] as AyTableViewRowEventArgs;
            //    if (_2.IsNotNull())
            //    {
            //        var _3 = _2.Data as AyPerson;
            //        ViewBag.Remo1 = "ID:" + _3.AYID + ",处理完成:" + _3.Name + "," + (_3.Sex == 0 ? "男" : "女") + "," + _3.ShouRu + "," + _3.Telphone + "," + _3.GetDaXue + "," + _3.Address;
            //    }
            //};

        }

        /// <summary>
        /// 无注释
        /// </summary>
        public ActionResult RowEditBeginAction { get; private set; }

        /// <summary>
        /// 无注释
        /// </summary>
        public ActionResult RowEditEndAction { get; private set; }



    }
}
