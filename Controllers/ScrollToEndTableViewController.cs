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
using System.Windows.Controls;
using Ay.Framework.WPF.Controls;
using System.Threading;

namespace AyTableViewDemo.Controllers
{
    public class ScrollToEndTableViewController : Controller
    {
        public ObservableCollectionPlus<AyPerson> Datas { get; set; } = new ObservableCollectionPlus<AyPerson>();

        public ScrollToEndTableViewController()
        {
            Add60RowData();
            ScrollEndCommand = new DelegateCommand(x =>
            {
                if (_SV.ScrollableHeight > 0)//有时候不满一屏幕
                {
                    if (ScrollChangedLock)
                    {
                        ScrollChangedLock = false;
                        return;
                    }

                    if (TableIsBusy) return;
                    TableIsBusy = true;
                    _SV.ScrollToTop();
                    AyThread.Instance.RunNew<bool>(() =>
                    {
                        Thread.Sleep(500);
                        return true;
                    }, (d) =>
                    {
                        AyThread.Instance.RunUI(() =>
                        {
                            ScrollChangedLock = true;
                            Add60RowData();
                            _SV.ScrollToBottom();

                            TableIsBusy = false;
                        });
                    });
                }
            });
        }
        bool ScrollChangedLock = false;
        private bool _TableIsBusy = false;

        /// <summary>
        /// 表格是否繁忙
        /// </summary>
        public bool TableIsBusy
        {
            get { return _TableIsBusy; }
            set { Set(ref _TableIsBusy, value); }
        }

        public ICommand ScrollEndCommand { get; set; }
        private ScrollViewer _SV;
        public ScrollViewer SV
        {
            get { return _SV; }
            set
            {
                if (_SV != value)
                {
                    _SV = value;
                    if (_SV != null)
                    {
                        ScrollViewerHelper.SetEndOfVerticalScrollReachedCommand(_SV, ScrollEndCommand);
                    }
                    OnPropertyChanged("SV");
                }
            }
        }
        int i = 0;

        public void Add60RowData()
        {

            using (Datas.BeginMultiUpdate())
            {
                int maxi = i + 50;
                for (; i < maxi; i++)
                {
                    AyPerson Model = new AyPerson();
                    Model.Name = "杨洋" + i.ToString();

                    Model.Sex = AyCommon.Rnd.Next(5);
                    Model.Telphone = AyPhone.PhoneNumber();
                    Model.Address = AyAddress.Address();
                    Datas.Add(Model);
                }
                i = maxi;
            }

        }


    }
}
