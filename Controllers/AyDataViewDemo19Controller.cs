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

namespace AyTableViewDemo.Controllers
{
    public class AyDataViewDemo19Controller : Controller
    {
        public ObservableCollection<AyPerson> Datas { get; set; } = new ObservableCollection<AyPerson>();
        public AyDataViewDemo19Controller() : base()
        {
            //AyMessageBox.Show(AyCommon.Rnd.Next(1000,9999).ToString());
            var _edit = new DelegateCommand(inParam =>
            {
                var _rowValue = inParam as AyPerson;
                if (_rowValue.IsNotNull())
                {
                    AyMessageBox.ShowInformation("编辑" + _rowValue.Name);
                }
            });
            var _remove = new DelegateCommand(inParam =>
            {
                var _rowValue = inParam as AyPerson;
                if (_rowValue.IsNotNull())
                {
                    AyMessageBox.ShowInformation("删除" + _rowValue.Name);
                }
            });
            var _detail = new DelegateCommand(inParam =>
            {
                var _rowValue = inParam as AyPerson;
                if (_rowValue.IsNotNull())
                {
                    AyMessageBox.ShowInformation("详情" + _rowValue.Name);
                }
            });

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
                Model.ContextEditItem = _edit;
                Model.ContextRemoveItem = _remove;
                Model.ContextDetailItem = _detail;
                Datas.Add(Model);
            }

           

        }


      
    }
}
