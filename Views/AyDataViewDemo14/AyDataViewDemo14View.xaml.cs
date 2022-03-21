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

namespace AyTableViewDemo.Views.AyDataViewDemo14
{
    /// <summary>
    /// AyDataViewDemo14View.xaml 
    /// 创建时间：2017/12/7 11:57:14
    /// </summary>
    public partial class AyDataViewDemo14View : AyPage
    {
        public AyDataViewDemo14View()
        {
            InitializeComponent();
        }

    }










































    public partial class AyDataViewDemo14View : AyPage
    {
        #region 控制器
        private Actions<AyDataViewDemo14Controller> _mvc;
        public Actions<AyDataViewDemo14Controller> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<AyDataViewDemo14Controller>(DataContext as AyDataViewDemo14Controller);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
