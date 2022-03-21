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

namespace AyTableViewDemo.Views.RowDetail2
{
    /// <summary>
    /// RowDetail2View.xaml 
    /// 创建时间：2020/8/26 15:50:45
    /// </summary>
    public partial class RowDetail2View : AyPage
    {
        public RowDetail2View()
        {
            InitializeComponent();
        }

    }










































    public partial class RowDetail2View : AyPage
    {
        #region 控制器
        private Actions<RowDetail2Controller> _mvc;
        public Actions<RowDetail2Controller> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<RowDetail2Controller>(DataContext as RowDetail2Controller);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
