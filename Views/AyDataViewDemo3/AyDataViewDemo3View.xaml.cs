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

namespace AyTableViewDemo.Views.AyDataViewDemo3
{
    /// <summary>
    /// AyDataViewDemo3View.xaml 
    /// 创建时间：2017/12/6 11:20:24
    /// </summary>
    public partial class AyDataViewDemo3View : AyPage
    {
        public AyDataViewDemo3View()
        {
            InitializeComponent();
        }

    }










































    public partial class AyDataViewDemo3View : AyPage
    {
        #region 控制器
        private Actions<AyDataViewDemo3Controller> _mvc;
        public Actions<AyDataViewDemo3Controller> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<AyDataViewDemo3Controller>(DataContext as AyDataViewDemo3Controller);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
