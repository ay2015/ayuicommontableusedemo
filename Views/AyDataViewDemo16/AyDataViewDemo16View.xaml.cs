﻿using System;
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

namespace AyTableViewDemo.Views.AyDataViewDemo16
{
    public partial class AyDataViewDemo16View : AyPage
    {
        public AyDataViewDemo16View()
        {
            InitializeComponent();
        }

    }










































    public partial class AyDataViewDemo15View : AyPage
    {
        #region 控制器
        private Actions<AyDataViewDemo15Controller> _mvc;
        public Actions<AyDataViewDemo15Controller> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<AyDataViewDemo15Controller>(DataContext as AyDataViewDemo15Controller);
                }
                return _mvc;
            }
        }
        #endregion
    }


}
