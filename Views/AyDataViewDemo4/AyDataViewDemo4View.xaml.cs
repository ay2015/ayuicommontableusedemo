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

namespace AyTableViewDemo.Views.AyDataViewDemo4
{
    /// <summary>
    /// AyDataViewDemo4View.xaml 
    /// 创建时间：2017/12/6 16:54:27
    /// </summary>
    public partial class AyDataViewDemo4View : AyPage
    {
        public AyDataViewDemo4View()
        {
            InitializeComponent();
        }

    }










































    public partial class AyDataViewDemo4View : AyPage
    {
        #region 控制器
        private Actions<AyDataViewDemo4Controller> _mvc;
        public Actions<AyDataViewDemo4Controller> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<AyDataViewDemo4Controller>(DataContext as AyDataViewDemo4Controller);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
