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

    public class AyTableDemo22Controller : Controller
    {
        public ObservableCollection<Humans> Datas { get; set; } = new ObservableCollection<Humans>();
  

        public AyTableDemo22Controller() : base()
        {
            for (int i = 0; i < 10000; i++)
            {
                Humans humans = new Humans();
                humans.ID = AyCommon.GetGuidNoSplit;  
                humans.UserName = "杨洋" + i.ToString();

          
                for (int j = 1; j<= 30; j++)
                {  
                    CellValue cv = new CellValue();
                    cv.ID = humans.ID;
                    cv.UserValue = Math.Round(AyCommon.Rnd.NextDouble(1,1000),2);
                    humans.Data.Add(cv);
                }
     

                Datas.Add(humans);
            }




        }


    }
}
