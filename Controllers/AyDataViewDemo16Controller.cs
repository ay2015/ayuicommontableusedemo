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
    public class AyDataViewDemo16Controller : Controller
    {
        private List<SelectListItemNoNotify> _SexCbo = new List<SelectListItemNoNotify>();

        public List<SelectListItemNoNotify> SexCbo
        {
            get { return _SexCbo; }
            set { Set(ref _SexCbo, value); }
        }
        public ObservableCollection<AyPerson> Datas { get; set; } = new ObservableCollection<AyPerson>();
        public AyDataViewDemo16Controller() : base()
        {
            for (int i = 0; i < 100; i++)
            {
                AyPerson Model = new AyPerson();
                Model.Name = "杨洋" + i.ToString();
                Model.Sex = AyCommon.Rnd.Next(2);

                Model.Telphone = AyPhone.PhoneNumber();
                Model.Address = AyAddress.Address();
                Model.ShouRu = (AyCommon.Rnd.Next(1000, 10000));
                Model.GetDaXue = AyCommon.Rnd.NextBool();
                Datas.Add(Model);
            }


            SexCbo.Add(new SelectListItemNoNotify { Text = "男", Value = "0" });
            SexCbo.Add(new SelectListItemNoNotify { Text = "女", Value = "1" });


            CellEditBeginAction = inParam =>
            {
                var _1 = inParam as object[];
                var _2 = _1[2] as AyTableViewCellEventArgs;
                if (_2.IsNotNull())
                {
                    var _3 = _2.Data as AyPerson;
                    var _4 = _2.Field;
                    Type type = _3.GetType();
                    System.Reflection.PropertyInfo propertyInfo = type.GetProperty(_4);
                    string value_Old = propertyInfo.GetValue(_3, null).ToObjectString();
                    ViewBag.Remo = "ID:" + _3.AYID + ",编辑开始了,字段为" + _4 + ":" + value_Old;
                }
            };

            CellEditEndAction = inParam =>
             {
                 var _1 = inParam as object[];
                 var _2 = _1[2] as AyTableViewCellEventArgs;
                 if (_2.IsNotNull())
                 {
                     var _3 = _2.Data as AyPerson;
                     var _4 = _2.Field;
                     Type type = _3.GetType();
                     System.Reflection.PropertyInfo propertyInfo = type.GetProperty(_4);
                     string value_Old = propertyInfo.GetValue(_3, null).ToObjectString();
                     ViewBag.Remo1 = "上一次==ID:" + _3.AYID+",编辑完成,字段为" + _4 + ":" + value_Old;
                 }
             };

        }

        /// <summary>
        /// 单元格编辑前
        /// </summary>
        public ActionResult CellEditBeginAction { get; private set; }

        /// <summary>
        /// 单元格编辑后
        /// </summary>
        public ActionResult CellEditEndAction { get; private set; } 


    }
}
