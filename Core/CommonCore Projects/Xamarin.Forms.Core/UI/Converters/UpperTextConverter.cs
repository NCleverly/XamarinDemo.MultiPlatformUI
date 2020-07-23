﻿using System;
using Xamarin.Forms;
using System.Globalization;

namespace Xamarin.Forms.Core
{
    [ValueConversion(typeof(string), typeof(string))]
    public class UpperTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            var text = ((string)value);

            return text.ToUpperInvariant();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}

