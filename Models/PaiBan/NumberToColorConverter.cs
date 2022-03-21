using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace TableTest.Models
{
    //public class NumberToStringConverter : IValueConverter
    //{

    //    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        var _v = value.ToString();
    //        if (_v == "1")
    //        {
    //            return "班";
    //        }
    //        else if (_v == "2")
    //        {
    //            return "停";
    //        }
    //        else
    //        {
    //            return "";
    //        }
    //    }

    //    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    public class NumberToColorConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var _v = value as string;
            if(_v==null)return Brushes.Black;
            if (_v == "停诊")
            {
                return Brushes.Red;
            }
            else
            {
                return Brushes.Black;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}

