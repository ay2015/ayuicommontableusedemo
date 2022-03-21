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

namespace AyTableViewDemo.Views.AyDataViewDemo11
{
    /// <summary>
    /// AyDataViewDemo11View.xaml 
    /// 创建时间：2017/12/8 10:24:27
    /// </summary>
    public partial class AyDataViewDemo11View : AyPage
    {
        public AyDataViewDemo11View()
        {
            InitializeComponent();
        }

    }










































    public partial class AyDataViewDemo11View : AyPage
    {
        #region 控制器
        private Actions<AyDataViewDemo11Controller> _mvc;
        public Actions<AyDataViewDemo11Controller> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<AyDataViewDemo11Controller>(DataContext as AyDataViewDemo11Controller);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
