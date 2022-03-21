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
using AyTableViewDemo.Models;

namespace AyTableViewDemo.Views.AyTableDemo25
{

    public partial class AyTableDemo25View : AyPage
    {
        public AyTableDemo25View()
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
