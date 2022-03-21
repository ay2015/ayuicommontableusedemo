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

namespace AyTableViewDemo.Views.AyTableDemo21
{
    /// <summary>
    /// AyTableDemo21View.xaml 
    /// 创建时间：2018/5/7 14:45:34
    /// </summary>
    public partial class AyTableDemo21View : AyPage
    {
        public AyTableDemo21View()
        {
            InitializeComponent();
        }

    }










































    public partial class AyTableDemo21View : AyPage
    {
        #region 控制器
        private Actions<AyTableDemo21Controller> _mvc;
        public Actions<AyTableDemo21Controller> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<AyTableDemo21Controller>(DataContext as AyTableDemo21Controller);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
