using System;
using System.Collections.Generic;
using System.Text;

namespace StrasInfo.Converter
{
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Data;

    public class StringDistanceToVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var val = value as string;

            if (val != null)
            {
                double distance = Double.Parse(val.Substring(0, val.IndexOf(" km", StringComparison.Ordinal)));

                if (0 < distance && distance < 30) return Visibility.Visible;

                return Visibility.Collapsed;
            }

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
