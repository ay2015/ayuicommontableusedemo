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

namespace AyTableViewDemo.Views.DoubleClick
{
    /// <summary>
    /// DoubleClickView.xaml 
    /// 创建时间：2020/3/15 10:51:34
    /// </summary>
    public partial class DoubleClickView : Page
    {
        public DoubleClickView()
        {
            InitializeComponent();
        }


    }

























    public partial class DoubleClickView : Page
    {
        #region 控制器
        private Actions<DoubleClickController> _mvc;
        public Actions<DoubleClickController> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<DoubleClickController>(DataContext as DoubleClickController);
                }
                return _mvc;
            }
        }
        #endregion
    }
}
