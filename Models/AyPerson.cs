using Ay.MvcFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace AyTableViewDemo.Models
{
    public class AyPerson : AyTableViewRowModel
    {
        private string _Name;

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { Set(ref _Name, value); }
        }
        private bool _GetDaXue;

        /// <summary>
        /// 上过大学
        /// </summary>
        public bool GetDaXue
        {
            get { return _GetDaXue; }
            set { Set(ref _GetDaXue, value); }
        }


        private int _Sex;

        /// <summary>
        /// 性别
        /// </summary>
        public int Sex
        {
            get { return _Sex; }
            set { Set(ref _Sex, value); }
        }

        private string _Address;

        /// <summary>
        /// 地址
        /// </summary>
        public string Address
        {
            get { return _Address; }
            set { Set(ref _Address, value); }
        }

        private string _Telphone;

        /// <summary>
        /// 电话号码
        /// </summary>
        public string Telphone
        {
            get { return _Telphone; }
            set { Set(ref _Telphone, value); }
        }

        private double _ShouRu;

        /// <summary>
        /// 收入
        /// </summary>
        public double ShouRu
        {
            get { return _ShouRu; }
            set { Set(ref _ShouRu, value); }
        }

        private Family _Family;

        /// <summary>
        /// 未填写
        /// </summary>
        public Family Family
        {
            get { return _Family; }
            set { Set(ref _Family, value); }
        }


        //
        /// <summary>
        /// 无注释
        /// </summary>
        public ICommand ContextEditItem { get;  set; }
        public ICommand ContextRemoveItem { get;  set; }
        public ICommand ContextDetailItem { get;  set; }

    }

    public class Family:Model
    {
        private string _Father;

        /// <summary>
        /// 未填写
        /// </summary>
        public string Father
        {
            get { return _Father; }
            set { Set(ref _Father, value); }
        }

        private string _Mother;

        /// <summary>
        /// 未填写
        /// </summary>
        public string Mother
        {
            get { return _Mother; }
            set { Set(ref _Mother, value); }
        }



    }
}
