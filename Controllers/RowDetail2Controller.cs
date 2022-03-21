using AyTableViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Ay.MvcFramework;

namespace AyTableViewDemo.Controllers
{
    public class RowDetail2Controller : Controller
    {
        public RowDetail2Model Model { get; set; } = new RowDetail2Model();
        public RowDetail2Controller() : base()
        {


        }


    }
}
