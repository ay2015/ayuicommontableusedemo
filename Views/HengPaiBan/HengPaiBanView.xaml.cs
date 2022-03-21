using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ay.MvcFramework;
using Ay.MvcFramework.AyMarkupExtension;
using AyTableViewDemo.Controllers;
using Ay.Framework.WPF.Controls;

namespace AyTableViewDemo.Views.HengPaiBan
{
    /// <summary>
    /// HengPaiBanView.xaml 
    /// 创建时间：2020/8/26 16:03:01
    /// </summary>
    public partial class HengPaiBanView : AyPage
    {
        public HengPaiBanView()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }
        private HengPaiBanController _Data;
        public HengPaiBanController Data
        {
            get
            {
                if (_Data == null)
                {
                    _Data = this.DataContext as HengPaiBanController;
                }
                return _Data;
            }
        }

        double DayColumnWidth = 104; //每个140
        string[] Day = new string[] { "日", "一", "二", "三", "四", "五", "六" };

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= MainWindow_Loaded;
            DataTemplate dt = this.Resources["fg"] as DataTemplate;
            List<AyTableViewColumn> atvcs = new List<AyTableViewColumn>();

            DateTime startTime = Data.StartDateTime;
            for (int j = 1; j <= Data.DateDiff; j++)
            {
                int o = j * 3;
                string groupname = startTime.ToString("MM-dd") + "(" + Day[Convert.ToInt32(startTime.DayOfWeek.ToString("d"))].ToString() + ")";
                var atvcGroup = new AyTableViewColumn()
                {
                    GroupName = groupname,
                    ParentTableView = tableView,
                    IsGroup = true
                };
                var atvc1 = new AyTableViewColumn()
                {
                    Title = "上午",
                    Width = DayColumnWidth,
                    CellTemplate = dt,
                    ParentTableView = tableView,
                    Field = "Data[" + (o - 2) + "]",
                    HorizontalContentAlignment = HorizontalAlignment.Stretch,
                    VerticalContentAlignment = VerticalAlignment.Stretch,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };
                var atvc2 = new AyTableViewColumn()
                {
                    Title = "下午",
                    Width = DayColumnWidth,
                    CellTemplate = dt,
                    ParentTableView = tableView,
                    Field = "Data[" + (o - 1) + "]",
                    HorizontalContentAlignment = HorizontalAlignment.Stretch,
                    VerticalContentAlignment = VerticalAlignment.Stretch,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };
                var atvc3 = new AyTableViewColumn()
                {
                    Title = "晚上",
                    Width = DayColumnWidth,
                    CellTemplate = dt,
                    ParentTableView = tableView,
                    Field = "Data[" + o + "]",
                    HorizontalContentAlignment = HorizontalAlignment.Stretch,
                    VerticalContentAlignment = VerticalAlignment.Stretch,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };
                atvcGroup.Columns.Add(atvc1);
                atvcGroup.Columns.Add(atvc2);
                atvcGroup.Columns.Add(atvc3);
                atvcs.Add(atvcGroup);
                startTime = startTime.AddDays(1);
            }
            tableView.ColumnsAddRange(atvcs);
            foreach (var item in atvcs)
            {
                tableView.ColumnsHead.Add(item);
            }

            tableView.RefreshColumnInfo();
            //tableView.ItemsSource = Data.Datas;
            //tableView.ItemsCount = Data.Datas.Count;
            //tableView.isUpdateColumns = true;
            //tableView.isUpdateColumns
        }

    }










































    public partial class HengPaiBanView : AyPage
    {
        #region 控制器
        private Actions<HengPaiBanController> _mvc;
        public Actions<HengPaiBanController> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<HengPaiBanController>(DataContext as HengPaiBanController);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
