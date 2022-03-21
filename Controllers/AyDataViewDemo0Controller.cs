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
    public class AyDataViewDemo0Controller : Controller
    {
        /// <summary>
        /// 编辑
        /// </summary>
        public ActionResult Edit { get; private set; } = inParam =>
        {
            var _1 = inParam as AyPerson;
            if (_1.IsNotNull())
            {
                AyMessageBox.Show(_1.Name);
            }
        };
        public ActionResult PDelete { get; private set; }

        /// <summary>
        /// 无注释
        /// </summary>
        public ActionResult DoubleRow { get; private set; } = inParam =>
        {
            var _1 = inParam as AyPerson;
            if (_1.IsNotNull())
            {
                AyMessageBox.Show(_1.Name);
            }
        };

        public ObservableCollection<AyPerson> Datas { get; set; } = new ObservableCollection<AyPerson>();
        public ObservableCollection<AyTableViewSelectionMode> SelectionMode { get; set; } = new ObservableCollection<AyTableViewSelectionMode>();
        public AyDataViewDemo0Controller() : base()
        {
            for (int i = 0; i < 6; i++)
            {
                AyPerson Model = new AyPerson();
                Model.Name = "杨洋" + i.ToString();
                //if (i == 0)
                //{
                //    Model.Name = "杨洋AY";
                //}
                //else
                //{
                //    Model.Name = AyUserName.UserName();
                //}


                Model.Sex = AyCommon.Rnd.Next(5);
                Model.Telphone = AyPhone.PhoneNumber();
                Model.Address = AyAddress.Address();
                Datas.Add(Model);
            }

            foreach (AyTableViewSelectionMode mode in Enum.GetValues(typeof(AyTableViewSelectionMode)))
            {
                SelectionMode.Add(mode);
            }

            PDelete = inParam =>
        {
            var _1 = inParam as List<object>;
            var _2 = _1.Select(x => (x as AyPerson)).ToList();
            if (_2.IsNotNull())
            {
                string s = "";
                int _ss = _2.Count();
                for (int i = 0; i < _ss; i++)
                {
                    s += _2[i].Name + ",";
                    Datas.Remove(_2[i]);
                }
           
                //Ay.Framework.WPF.AyMessageBox.Show(s);


            }
        };
            //AyTime.setTimeout(3000, () =>
            //{
            //    //AyDataViewDemo0Model Model = new AyDataViewDemo0Model();
            //    //Model.Name = AyUserName.UserName();
            //    //Model.Sex = AyCommon.Rnd.Next(5);
            //    //Model.Telphone = AyPhone.PhoneNumber();
            //    //Model.Address = AyAddress.Address();
            //    //Datas.Add(Model);
            //    Datas.Clear();
            //    for (int i = 0; i < 1000; i++)
            //    {
            //        AyDataViewDemo0Model Model = new AyDataViewDemo0Model();
            //        Model.Name = AyUserName.UserName();
            //        Model.Sex = AyCommon.Rnd.Next(5);
            //        Model.Telphone = AyPhone.PhoneNumber();
            //        Model.Address = AyAddress.Address();
            //        Datas.Add(Model);
            //    }
            //    AyTime.setTimeout(2000, () =>
            //    {
            //        //AyDataViewDemo0Model Model = new AyDataViewDemo0Model();
            //        //Model.Name = AyUserName.UserName();
            //        //Model.Sex = AyCommon.Rnd.Next(5);
            //        //Model.Telphone = AyPhone.PhoneNumber();
            //        //Model.Address = AyAddress.Address();
            //        //Datas.Add(Model);
            //        Datas.Clear();

            //    });
            //});

        }


    }
}
