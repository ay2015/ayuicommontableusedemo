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
    public class TestScrollviewerController : Controller
    {
        public TestScrollviewerModel Model { get; set; } = new TestScrollviewerModel();
        public TestScrollviewerController() : base()
        {


        }


    }
}
