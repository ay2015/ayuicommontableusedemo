using Ay.MvcFramework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace AyTableViewDemo.Models
{
    public class CellValue : Model
    {
        private string _ID;

        /// <summary>
        /// ID
        /// </summary>
        public string ID
        {
            get { return _ID; }
            set { Set(ref _ID, value); }
        }

        private double _UserValue;

        /// <summary>
        /// 用户
        /// </summary>
        public double UserValue
        {
            get { return _UserValue; }
            set { Set(ref _UserValue, value); }
        }



    }
    public class Humans : AyTableViewRowModel
    {
        public ObservableCollection<CellValue> Data { get; set; }
        public string ID { get; set; }

        private string _UserName;

        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName
        {
            get { return _UserName; }
            set { Set(ref _UserName, value); }
        }
        public Humans()
        {
            Data = new ObservableCollection<CellValue>();
        }
    }

}

