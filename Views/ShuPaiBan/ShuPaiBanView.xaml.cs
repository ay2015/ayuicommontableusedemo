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

namespace AyTableViewDemo.Views.ShuPaiBan
{
    /// <summary>
    /// ShuPaiBanView.xaml 
    /// 创建时间：2020/8/26 16:14:55
    /// </summary>
    public partial class ShuPaiBanView : AyPage
    {
        public ShuPaiBanView()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }
        private ShuPaiBanController _Data;
        public ShuPaiBanController Data
        {
            get
            {
                if (_Data == null)
                {
                    _Data = this.DataContext as ShuPaiBanController;
                }
                return _Data;
            }
        }

        double DayColumnWidth = 140;
        string[] Day = new string[] { "日", "一", "二", "三", "四", "五", "六" };

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= MainWindow_Loaded;
            DataTemplate dt = this.Resources["fg"] as DataTemplate;
            List<AyTableViewColumn> atvcs = new List<AyTableViewColumn>();

            DateTime startTime = Data.StartDateTime;
            for (int j = 1; j <= Data.DateDiff; j++)
            {
                var _dfe = GetHeadColumn(startTime);
                var atvc = new AyTableViewColumn()
                {
                    Title = _dfe,
                    Width = DayColumnWidth,
                    CellTemplate = dt,
                    ResizeColumn = false,
                    Field = "Data[" + (j - 1) + "]",
                    HorizontalContentAlignment = HorizontalAlignment.Stretch,
                    VerticalContentAlignment = VerticalAlignment.Stretch,
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Stretch
                };
                atvcs.Add(atvc);
                startTime = startTime.AddDays(1);
            }

            tableView.ColumnsAddRange(atvcs);

        }


        public Grid GetHeadColumn(DateTime dt)
        {
            Grid d = new Grid();
            d.Width = DayColumnWidth;
            d.Background = Brushes.Transparent;
            d.HorizontalAlignment = HorizontalAlignment.Stretch;
            d.VerticalAlignment = VerticalAlignment.Stretch;
            d.RowDefinitions.Add(new RowDefinition());
            d.RowDefinitions.Add(new RowDefinition());
            d.IsHitTestVisible = false;

            Grid d1 = new Grid();
            d1.Background = Brushes.Gray;
            d1.HorizontalAlignment = HorizontalAlignment.Stretch;
            d1.VerticalAlignment = VerticalAlignment.Stretch;
            d1.IsHitTestVisible = false;

            TextBlock tb1 = new TextBlock();
            tb1.Text = Day[Convert.ToInt32(dt.DayOfWeek.ToString("d"))].ToString();
            tb1.Foreground = Brushes.Black;
            tb1.FontSize = 14;
            tb1.HorizontalAlignment = HorizontalAlignment.Center;
            tb1.VerticalAlignment = VerticalAlignment.Center;

            TextBlock tb2 = new TextBlock();
            tb2.Text = dt.ToString("MM-dd");
            tb2.Foreground = Brushes.Black;
            tb2.FontSize = 14;
            tb2.HorizontalAlignment = HorizontalAlignment.Center;
            tb2.VerticalAlignment = VerticalAlignment.Center;
            Grid.SetRow(tb2, 1);

            Rectangle t = new Rectangle();
            t.Height = 1;
            t.HorizontalAlignment = HorizontalAlignment.Stretch;
            t.VerticalAlignment = VerticalAlignment.Bottom;
            t.Fill = Brushes.Black;
            d1.Children.Add(tb1);
            d.Children.Add(d1);
            d.Children.Add(tb2);
            d.Children.Add(t);

            return d;
        }

    }










































    public partial class ShuPaiBanView : AyPage
    {
        #region 控制器
        private Actions<ShuPaiBanController> _mvc;
        public Actions<ShuPaiBanController> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<ShuPaiBanController>(DataContext as ShuPaiBanController);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
