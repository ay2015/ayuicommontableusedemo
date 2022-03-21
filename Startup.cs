using System;
using Ay.MvcFramework;
using AyTableViewDemo.Views;

namespace AyTableViewDemo
{
    public class Startup
    {
        [STAThread]
        static void Main()
        {

            new AYUIApplication<_ViewStart>(new Global(), true).Run();

        }

    }
}
