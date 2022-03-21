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
    public class AyTableDemo20Controller : Controller
    {
        public ObservableCollection<AyPerson> Datas { get; set; } = new ObservableCollection<AyPerson>();
        public AyTableDemo20Model Model { get; set; } = new AyTableDemo20Model();
        public AyTableDemo20Controller()
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
   
        
        }




    }
}
