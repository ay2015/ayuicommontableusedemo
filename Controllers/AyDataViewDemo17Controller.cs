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
    public class AyDataViewDemo17Controller : Controller
    {
        private List<SelectListItemNoNotify> _SexCbo = new List<SelectListItemNoNotify>();

        public List<SelectListItemNoNotify> SexCbo
        {
            get { return _SexCbo; }
            set { Set(ref _SexCbo, value); }
        }
        private AyTableViewStatuss _TableStatus;
        public AyTableViewStatuss TableStatus
        {
            get { return _TableStatus; }
            set { Set(ref _TableStatus, value); }
        }

        public ObservableCollection<AyPerson> Datas { get; set; } = new ObservableCollection<AyPerson>();
        public AyDataViewDemo17Controller() : base()
        {
            #region 创造数据
            for (int i = 0; i < 1000; i++)
            {
                AyPerson Model = new AyPerson();
                //if (i == 0)
                //{
                //    Model.Name = "杨洋AY";
                //}
                //else
                //{
                //    Model.Name = AyUserName.UserName();
                //}
                Model.Name = "杨洋" + (i + 1).ToString();
                Model.Sex = AyCommon.Rnd.Next(2);

                Model.Telphone = AyPhone.PhoneNumber();
                Model.Address = AyAddress.Address();
                Model.ShouRu = (AyCommon.Rnd.Next(1000, 10000));
                Model.GetDaXue = AyCommon.Rnd.NextBool();
                Datas.Add(Model);
            }


            SexCbo.Add(new SelectListItemNoNotify { Text = "男", Value = "0" });
            SexCbo.Add(new SelectListItemNoNotify { Text = "女", Value = "1" });
            #endregion
            DeleteItem = inParam =>
            {
                var _3 = inParam as AyPerson;
                if (_3.IsNotNull())
                {
                    if (AyMessageBox.ShowDelete("确定删除\"" + _3.Name + "\"这条记录吗?", "删除提示") == MessageBoxResult.OK)
                    {
                        var _1 = Datas.FirstOrDefault(x => x.AYID == _3.AYID);
                        if (_1.IsNotNull())
                        {
                            Datas.Remove(_1);
                        }
                    }

                }

            };
            SaveItem = inParam =>
            {
       
                RowOldNewValue _13 = AyTableViewService.GetRowObject(inParam.ToObjectString());
                if (_13 == null) return;
                if (_13.RowStatus == AyTableViewStatuss.Append)
                {
                    _13.Validate(() =>
                    {
                        TableStatus = AyTableViewStatuss.Normal;
                        //保存
                        //var _3 = _13.OldValue as AyPerson;
                        //var _4 = _13.NewValue as AyPerson;
                        AyMessageBox.ShowRight("新增成功!");

                    });
                }
                else
                {
                    if (_13.HasChanged())
                    {
                        //前台验证
                        _13.Validate(() =>
                        {
  
                            //保存
                            //var _3 = _13.OldValue as AyPerson;
                            //var _4 = _13.NewValue as AyPerson;
                            AyMessageBox.ShowRight("保存成功!");

                        });

                        //    //        AyMessageBox.ShowInformation("旧值== ID:" + _3.AYID + "," + _3.Name + "," + (_3.Sex == 0 ? "男" : "女") + "," + _3.ShouRu + "," + _3.Telphone + "," + _3.GetDaXue + "," + _3.Address + "\r\n"
                        //    //+ "新值== ID:" + _4.AYID + "," + _4.Name + "," + (_4.Sex == 0 ? "男" : "女") + "," + _4.ShouRu + "," + _4.Telphone + "," + _4.GetDaXue + "," + _4.Address
                        //    //);
                        //}
                        //else
                        //{
                        //    _13.SetRowCompleted();
                        //}
                    }
                }

            };

            AddNew = inParam =>
            {
                if (TableStatus == AyTableViewStatuss.Append)
                {
                    AyMessageBox.ShowRight("当前表格有新增行未保存,请先保存");
                }
                else
                {
                    AyPerson Model = new AyPerson();
                    Datas.Add(Model);
                    AddObject = Model;
                }


            };
            AppendCancelAction = inParam =>
            {
                var _1 = inParam as object[];
                var _2 = _1[2] as AyTableViewRowEventArgs;
                if (_2.IsNotNull())
                {
                    Datas.Remove(_2.Data as AyPerson);
                }

            };


        }
        private AyPerson _AddObject;

        /// <summary>
        /// 新增行对象
        /// </summary>
        public AyPerson AddObject
        {
            get { return _AddObject; }
            set { Set(ref _AddObject, value); }
        }


        /// <summary>
        /// 保存
        /// </summary>
        public ActionResult SaveItem { get; private set; }

        /// <summary>
        /// 新增
        /// </summary>
        public ActionResult AddNew { get; private set; }

        /// <summary>
        /// 查看
        /// </summary>
        public ActionResult LookItem { get; private set; } = inParam =>
        {
            var _3 = inParam as AyPerson;
            if (_3.IsNotNull())
            {
                AyMessageBox.ShowInformation("ID:" + _3.AYID + "," + _3.Name + "," + (_3.Sex == 0 ? "男" : "女") + "," + _3.ShouRu + "," + _3.Telphone + "," + _3.GetDaXue + "," + _3.Address);
            }

        };

        public ActionResult DeleteItem { get; private set; }

        public ActionResult AppendCancelAction { get; private set; }



    }
}
