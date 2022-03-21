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


namespace AyTableViewDemo.Controllers
{
    public class AyTableDemo21Controller : Controller
    {
        public ObservableCollection<AyPerson> Datas { get; set; } = new ObservableCollection<AyPerson>();
        public AyTableDemo21Controller() : base()
        {
            for (int i = 0; i < 100; i++)
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
                Model.ShouRu = (AyCommon.Rnd.Next(1000, 10000));
                Model.Address = AyAddress.Address();
                Datas.Add(Model);
            }
        }


    }
}
