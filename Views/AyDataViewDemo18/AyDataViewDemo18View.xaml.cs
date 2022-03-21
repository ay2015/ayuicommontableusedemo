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

namespace AyTableViewDemo.Views.AyDataViewDemo18
{
    /// <summary>
    /// AyDataViewDemo18View.xaml 
    /// 创建时间：2017/12/7 15:09:15
    /// </summary>
    public partial class AyDataViewDemo18View : AyPage
    {
        public AyDataViewDemo18View()
        {
            InitializeComponent();
        }

    }










































    public partial class AyDataViewDemo18View : AyPage
    {
        #region 控制器
        private Actions<AyDataViewDemo18Controller> _mvc;
        public Actions<AyDataViewDemo18Controller> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<AyDataViewDemo18Controller>(DataContext as AyDataViewDemo18Controller);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
