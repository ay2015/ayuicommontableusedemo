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

namespace AyTableViewDemo.Views.AyDataViewDemo8
{
    /// <summary>
    /// AyDataViewDemo8View.xaml 
    /// 创建时间：2017/12/11 9:44:04
    /// </summary>
    public partial class AyDataViewDemo8View : AyPage
    {
        public AyDataViewDemo8View()
        {
            InitializeComponent();
        }

    }










































    public partial class AyDataViewDemo8View : AyPage
    {
        #region 控制器
        private Actions<AyDataViewDemo8Controller> _mvc;
        public Actions<AyDataViewDemo8Controller> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<AyDataViewDemo8Controller>(DataContext as AyDataViewDemo8Controller);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
