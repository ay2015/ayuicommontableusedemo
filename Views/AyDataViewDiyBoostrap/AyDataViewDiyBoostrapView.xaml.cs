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

namespace AyTableViewDemo.Views.AyDataViewDiyBoostrap
{
    /// <summary>
    /// AyDataViewDiyBoostrapView.xaml 
    /// 创建时间：2017/12/15 15:41:29
    /// </summary>
    public partial class AyDataViewDiyBoostrapView : AyPage
    {
        public AyDataViewDiyBoostrapView()
        {
            InitializeComponent();
        }

    }










































    public partial class AyDataViewDiyBoostrapView : AyPage
    {
        #region 控制器
        private Actions<AyDataViewDiyBoostrapController> _mvc;
        public Actions<AyDataViewDiyBoostrapController> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<AyDataViewDiyBoostrapController>(DataContext as AyDataViewDiyBoostrapController);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
