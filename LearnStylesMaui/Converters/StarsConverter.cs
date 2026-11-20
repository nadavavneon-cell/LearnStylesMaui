using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LearnStylesMaui.Converters
{
    internal class StarsConverter:IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {

            int score = value is int d ? d :0;
            if (score == 1)
                return "★☆☆☆☆";
            if (score == 2)
                return "★★☆☆☆";
            if (score == 3)
                return "★★★☆☆";
            if (score == 4)
                return "★★★★☆";
            if (score == 5)
                return "★★★★★";
            return "☆☆☆☆☆";
        }
        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
