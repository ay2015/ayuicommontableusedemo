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

namespace AyTableViewDemo.Views.AyTableDemo20
{
    /// <summary>
    /// AyTableDemo20View.xaml 
    /// 创建时间：2018/5/3 10:12:41
    /// </summary>
    public partial class AyTableDemo20View : AyPage
    {
        public AyTableDemo20View()
        {
            InitializeComponent();
            //tableView.ContentScollViewer.ScrollToBottom();
            //tableView.ContentScollViewer.ScrollToTop();
        }

    }










































    public partial class AyTableDemo20View : AyPage
    {
        #region 控制器
        private Actions<AyTableDemo20Controller> _mvc;
        public Actions<AyTableDemo20Controller> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<AyTableDemo20Controller>(DataContext as AyTableDemo20Controller);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
