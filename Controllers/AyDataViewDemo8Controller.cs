using AyTableViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Ay.MvcFramework;
using Ay.Framework.DataCreaters;
using Ay.Framework.WPF;
using Ay.Framework.WPF.Controls;

namespace AyTableViewDemo.Controllers
{

    public class AyDataViewDemo8Controller : Controller
    {
        public class AyDataViewDemo8SearchModel : Model
        {
            private string _OrderCondition;

            /// <summary>
            /// 未填写
            /// </summary>
            public string OrderCondition
            {
                get { return _OrderCondition; }
                set { Set(ref _OrderCondition, value); }
            }

            private int _CboSexSelect = -1;

            /// <summary>
            /// 性别选择
            /// </summary>
            public int CboSexSelect
            {
                get { return _CboSexSelect; }
                set { Set(ref _CboSexSelect, value); }
            }
            private string _SearchName;

            /// <summary>
            /// 未填写
            /// </summary>
            public string SearchName
            {
                get { return _SearchName; }
                set { Set(ref _SearchName, value); }
            }
            private int _PageSize = 30;

            /// <summary>
            /// 未填写
            /// </summary>
            public int PageSize
            {
                get { return _PageSize; }
                set { Set(ref _PageSize, value); }
            }
            private int _PageIndex = 1;

            /// <summary>
            /// 未填写
            /// </summary>
            public int PageIndex
            {
                get { return _PageIndex; }
                set { Set(ref _PageIndex, value); }
            }
        }

        public ObservableCollection<AyPerson> AllDatas { get; set; } = new ObservableCollection<AyPerson>();
        public AyDataViewDemo8SearchModel SearchModel { get; set; } = new AyDataViewDemo8SearchModel();

        private AyPagingDto<AyPerson> _Result;

        public AyPagingDto<AyPerson> Result
        {
            get { return _Result; }
            set { Set(ref _Result, value); }
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


        public AyDataViewDemo8Controller() : base()
        {
            ;
            Result = new AyPagingDto<AyPerson>();

            for (int i = 0; i < 1000; i++)
            {
                AyPerson Model = new AyPerson();
                Model.Name = i == 0 ? "杨洋AY" : AyUserName.UserName();
                Model.Sex = AyCommon.Rnd.Next(2);
                Model.Telphone = AyPhone.PhoneNumber();
                Model.ShouRu = (AyCommon.Rnd.Next(1000, 10000));
                Model.Address = AyAddress.Address();
                AllDatas.Add(Model);
            }

            AyCheckBoxItemModel sm0 = new AyCheckBoxItemModel() { ItemText = "请选择", ItemValue = "-1" };
            AyCheckBoxItemModel sm1 = new AyCheckBoxItemModel() { ItemText = "男", ItemValue = "0" };
            AyCheckBoxItemModel sm2 = new AyCheckBoxItemModel() { ItemText = "女", ItemValue = "1" };
            SexCbo.Add(sm0);
            SexCbo.Add(sm1);
            SexCbo.Add(sm2);

            Search = inParam =>
            {
                var o = inParam.ToObjectString();
                if (o == "1")
                {
                    SearchModel.PageIndex = 1;
                }
                else
                {

                }

                SearchEmployee();
            };


        }



        public void SearchEmployee()
        {
            IEnumerable<AyPerson> ap = AllDatas;
            if (!SearchModel.SearchName.IsNullAndTrimAndEmpty())
            {
                ap = ap.Where(x => x.Name.IndexOf(SearchModel.SearchName) > -1);
            }
            if (SearchModel.CboSexSelect != -1)
            {
                ap = ap.Where(x => x.Sex == SearchModel.CboSexSelect);
            }
            //值
            if (SearchModel.OrderCondition != null)
            {
                var _2 = OrderConditions.Convert(SearchModel.OrderCondition);
                if (_2.Item1 == "Name")
                {
                    if (_2.Item2 == "asc")
                    {
                        ap = ap.OrderBy(x => x.Name);
                    }
                    else
                    if (_2.Item2 == "desc")
                    {
                        ap = ap.OrderByDescending(x => x.Name);
                    }
                }
                else if (_2.Item1 == "Sex")
                {
                    if (_2.Item2 == "asc")
                    {
                        ap = ap.OrderBy(x => x.Sex);
                    }
                    else
                    if (_2.Item2 == "desc")
                    {
                        ap = ap.OrderByDescending(x => x.Sex);
                    }
                }
            }

            Result.Total = ap == null ? 0 : ap.Count();
            Result.Data = ap == null ? new ObservableCollection<AyPerson>() :
                ap.Skip((SearchModel.PageIndex - 1) * SearchModel.PageSize).Take(SearchModel.PageSize).ToList().ToObservableCollection();
        }







    }
}
