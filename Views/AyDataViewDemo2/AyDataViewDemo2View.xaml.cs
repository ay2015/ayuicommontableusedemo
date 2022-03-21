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

namespace AyTableViewDemo.Views.AyDataViewDemo2
{
    /// <summary>
    /// AyDataViewDemo2View.xaml 
    /// 创建时间：2017/12/5 19:14:15
    /// </summary>
    public partial class AyDataViewDemo2View : AyPage
    {
        public AyDataViewDemo2View()
        {
            InitializeComponent();
        }

    }










































    public partial class AyDataViewDemo2View : AyPage
    {
        #region 控制器
        private Actions<AyDataViewDemo2Controller> _mvc;
        public Actions<AyDataViewDemo2Controller> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<AyDataViewDemo2Controller>(DataContext as AyDataViewDemo2Controller);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
