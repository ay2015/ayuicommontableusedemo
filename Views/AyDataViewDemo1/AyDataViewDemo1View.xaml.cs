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

namespace AyTableViewDemo.Views.AyDataViewDemo1
{
    /// <summary>
    /// AyDataViewDemo1View.xaml 
    /// 创建时间：2017/11/27 16:30:20
    /// </summary>
    public partial class AyDataViewDemo1View : AyPage
    {
        public AyDataViewDemo1View()
        {
            InitializeComponent();
        }

    }










































    public partial class AyDataViewDemo1View : AyPage
    {
        #region 控制器
        private Actions<AyDataViewDemo1Controller> _mvc;
        public Actions<AyDataViewDemo1Controller> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<AyDataViewDemo1Controller>(DataContext as AyDataViewDemo1Controller);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
