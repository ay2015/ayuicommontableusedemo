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
using Ay.Framework.DataCreaters;
using Ay.Framework.DataCreaters.AY;

namespace AyTableViewDemo.Views.AyDataViewDemo0
{
    /// <summary>
    /// AyDataViewDemo0View.xaml 
    /// 创建时间：2017/11/27 15:42:45
    /// </summary>
    public partial class AyDataViewDemo0View : AyPage
    {
        public AyDataViewDemo0View()
        {
            InitializeComponent();
        }


    }












































    public partial class AyDataViewDemo0View : AyPage
    {
        #region 控制器
        private Actions<AyDataViewDemo0Controller> _mvc;
        public Actions<AyDataViewDemo0Controller> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<AyDataViewDemo0Controller>(DataContext as AyDataViewDemo0Controller);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
