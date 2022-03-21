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

namespace AyTableViewDemo.Controllers
{
    public class DoubleClickController : Controller
    {
        public ObservableCollection<AyPerson> Datas { get; set; } = new ObservableCollection<AyPerson>();
        public DoubleClickController()
        {
            for (int i = 0; i < 6; i++)
            {
                AyPerson Model = new AyPerson();
                Model.Name = "杨洋" + i.ToString();

                Model.Sex = AyCommon.Rnd.Next(5);
                Model.Telphone = AyPhone.PhoneNumber();
                Model.Address = AyAddress.Address();
                Datas.Add(Model);

            }
            DoubleClick = inParam =>
            {
                var _2 = inParam.GetRouteArgs<AyTableViewRowEventArgs>();
                if (_2.IsNotNull())
                {
                    var _3 = _2.Data as AyPerson;
                    AyMessageBox.Show(_3.Name);

                    
                }
            };
        }



        public ActionResult DoubleClick { get; private set; }
    }
}
