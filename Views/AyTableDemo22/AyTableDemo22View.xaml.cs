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

namespace AyTableViewDemo.Views.AyTableDemo22
{
    /// <summary>
    /// AyTableDemo22View.xaml 
    /// 创建时间：2018/5/8 15:50:11
    /// </summary>
    public partial class AyTableDemo22View : AyPage
    {
        public AyTableDemo22View()
        {

            InitializeComponent();

            Loaded += AyTableDemo22View_Loaded;
        }

        private void AyTableDemo22View_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= AyTableDemo22View_Loaded;
            DateTime now = DateTime.Now;
            DataTemplate dt = this.Resources["fg"] as DataTemplate;
            List<AyTableViewColumn> atvcs = new List<AyTableViewColumn>();
            for (int j = 1; j <= 56; j++)
            {
                var atvc = new AyTableViewColumn()
                {
                    Title = now.ToString("yyyy-MM-dd"),
                    Width = 110,
                    CellTemplate = dt,
                    ResizeColumn = false,
                    Field = "Data[0]"
                };
                atvcs.Add(atvc);
                now = now.AddDays(1);
            }

            tableView.ColumnsAddRange(atvcs);

        }
    }










































    public partial class AyTableDemo22View : AyPage
    {
        #region 控制器
        private Actions<AyTableDemo22Controller> _mvc;
        public Actions<AyTableDemo22Controller> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<AyTableDemo22Controller>(DataContext as AyTableDemo22Controller);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
