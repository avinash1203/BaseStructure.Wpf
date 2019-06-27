﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Structure.Converter
{
    class DateTimeNullConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DateTime.Now;
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
