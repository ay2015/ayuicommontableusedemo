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

namespace AyTableViewDemo.Views.AyTableDemo23
{
    /// <summary>
    /// AyTableDemo23View.xaml 
    /// 创建时间：2019/5/28 15:50:17
    /// </summary>
    public partial class AyTableDemo23View : AyPage
    {
        public AyTableDemo23View()
        {
            InitializeComponent();
        }

    }










































    public partial class AyTableDemo23View : AyPage
    {
        #region 控制器
        private Actions<AyTableDemo23Controller> _mvc;
        public Actions<AyTableDemo23Controller> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<AyTableDemo23Controller>(DataContext as AyTableDemo23Controller);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
