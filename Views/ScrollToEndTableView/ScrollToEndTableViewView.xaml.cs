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

namespace AyTableViewDemo.Views.ScrollToEndTableView
{
    /// <summary>
    /// ScrollToEndTableViewView.xaml 
    /// 创建时间：2020/5/13 14:26:52
    /// </summary>
    public partial class ScrollToEndTableViewView : Page
    {
        public ScrollToEndTableViewView()
        {
            InitializeComponent();
        }


    }

























    public partial class ScrollToEndTableViewView : Page
    {
        #region 控制器
        private Actions<ScrollToEndTableViewController> _mvc;
        public Actions<ScrollToEndTableViewController> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<ScrollToEndTableViewController>(DataContext as ScrollToEndTableViewController);
                }
                return _mvc;
            }
        }
        #endregion
    }
}
