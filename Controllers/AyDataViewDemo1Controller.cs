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
    public class AyDataViewDemo1Controller : Controller
    {
        private ObservableCollection<IAyCheckedItem> _GridLineModes = new ObservableCollection<IAyCheckedItem>();

        public ObservableCollection<IAyCheckedItem> GridLineModes
        {
            get { return _GridLineModes; }
            set { Set(ref _GridLineModes, value); }
        }

        private string _GridLineModesChecked;

        /// <summary>
        ///选中的值
        /// </summary>
        public string GridLineModesChecked
        {
            get { return _GridLineModesChecked; }
            set
            {
                if (_GridLineModesChecked != value)
                {
                    _GridLineModesChecked = value;

                    switch (value)
                    {
                        case "无网格":
                            ViewBag.GridLineHShow = false;
                            ViewBag.GridLineVShow = false;
                            break;
                        case "横竖网格":
                            ViewBag.GridLineHShow = true;
                            ViewBag.GridLineVShow = true;
                            break;
                        case "横网格":
                            ViewBag.GridLineHShow = true;
                            ViewBag.GridLineVShow = false;
                            break;
                        case "竖网格":
                            ViewBag.GridLineHShow = false;
                            ViewBag.GridLineVShow = true;
                            break;
                        default:
                            break;
                    }
                    Datas.Clear();
                    CreateShuJu();
                    //foreach (var item in Datas)
                    //{
                    //    Datas2.Add(item);
                    //}
                    //Datas.Clear();
                    //foreach (var item in Datas2)
                    //{
                    //    Datas.Add(item);
                    //}
                }
            }
        }

        //public ObservableCollection<AyDataViewDemo0Model> Datas2 { get; set; } = new ObservableCollection<AyDataViewDemo0Model>();
        private ObservableCollection<AyPerson> _Datas = new ObservableCollection<AyPerson>();
        /// <summary>
        /// 未填写
        /// </summary>
        public ObservableCollection<AyPerson> Datas
        {
            get { return _Datas; }
            set { Set(ref _Datas, value); }
        }

        public AyDataViewDemo1Controller() : base()
        {
            CreateShuJu();

            AyCheckBoxItemModel sm1 = new AyCheckBoxItemModel() { ItemText = "无网格", ItemValue = "无网格" };
            AyCheckBoxItemModel sm2 = new AyCheckBoxItemModel() { ItemText = "横竖网格", ItemValue = "横竖网格", IsChecked = true };
            AyCheckBoxItemModel sm3 = new AyCheckBoxItemModel() { ItemText = "横网格", ItemValue = "横网格" };
            AyCheckBoxItemModel sm4 = new AyCheckBoxItemModel() { ItemText = "竖网格", ItemValue = "竖网格" };
            GridLineModes.Add(sm1);
            GridLineModes.Add(sm2);
            GridLineModes.Add(sm3);
            GridLineModes.Add(sm4);

            ViewBag.GridLineHShow = true;
            ViewBag.GridLineVShow = true;

        }

        private void CreateShuJu()
        {
            for (int i = 0; i < 100; i++)
            {
                AyPerson Model = new AyPerson();
                Model.Name = AyUserName.UserName();
                Model.Sex = AyCommon.Rnd.Next(5);
                Model.Telphone = AyPhone.PhoneNumber();
                Model.Address = AyAddress.Address();
                Datas.Add(Model);
            }
        }

    }
}
