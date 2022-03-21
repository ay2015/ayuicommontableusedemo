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

namespace AyTableViewDemo.Views.AyDataViewDemo12
{
    /// <summary>
    /// AyDataViewDemo12View.xaml 
    /// 创建时间：2017/12/7 11:38:52
    /// </summary>
    public partial class AyDataViewDemo12View : AyPage
    {
        public AyDataViewDemo12View()
        {
            InitializeComponent();
        }

    }










































    public partial class AyDataViewDemo12View : AyPage
    {
        #region 控制器
        private Actions<AyDataViewDemo12Controller> _mvc;
        public Actions<AyDataViewDemo12Controller> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<AyDataViewDemo12Controller>(DataContext as AyDataViewDemo12Controller);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
