using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace AyTableViewDemo.Views.Shared
{
    public class ShouRuDataConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double _1 = value.ToDouble();
            if (_1 > 50000)
            {
                return "(牛)" + _1.ToString("#0.00");
            }
            else if (_1 < 10000)
            {
                return "(" + _1.ToString("#0.00") + ")";
            }
            return _1.ToString("#0.00");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ShouRuDataForegroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double _1 = value.ToDouble();
            if (_1 > 50000)
            {
                return SolidColorBrushConverter.From16JinZhi("#F02511");
            }
            else if (_1 < 10000)
            {
                return SolidColorBrushConverter.From16JinZhi("#1C9E50");
            }
            return SolidColorBrushConverter.From16JinZhi("#000000");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
