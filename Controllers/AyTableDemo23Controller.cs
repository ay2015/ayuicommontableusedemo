using AyTableViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Ay.MvcFramework;
using Ay.Framework.WPF.Controls;
using Ay.Framework.DataCreaters;

namespace AyTableViewDemo.Controllers
{
    public class AyTableDemo23Controller : Controller
    {
        public ObservableCollection<AyPerson> Datas { get; set; } = new ObservableCollection<AyPerson>();
        public AyTableDemo23Controller()
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
            TestCopy = inParam =>
            {
                var _2 = inParam.GetRouteArgs<AyTableViewRowsEventArgs>();
                if (_2.IsNotNull())
                {
                    var _3 = _2.Datas as List<object>;
                    StringBuilder sb = new StringBuilder();
                    foreach (var item in _3)
                    {
                        if (item is AyPerson p)
                        {
                            if (p.Sex == 0 || p.Sex == 1)
                                sb.AppendFormat("{0}\t{1}\t{2}\t{3}", p.Name, "男", p.Telphone, p.Address);
                            else if (p.Sex == 2)
                                sb.AppendFormat("{0}\t{1}\t{2}\t{3}", p.Name, "女", p.Telphone, p.Address);
                            else if (p.Sex == 3)
                                sb.AppendFormat("{0}\t{1}\t{2}\t{3}", p.Name, "不男不女", p.Telphone, p.Address);
                            else
                                sb.AppendFormat("{0}\t{1}\t{2}\t{3}", p.Name, "未知", p.Telphone, p.Address);
                        }

                    }
                    Clipboard.Clear();
                    Clipboard.SetData(DataFormats.Text, sb);
                }
            };
        }



        public ActionResult TestCopy { get; private set; }
    }
}