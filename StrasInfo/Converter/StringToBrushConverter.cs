using System;
using System.Collections.Generic;
using System.Text;

namespace StrasInfo.Converter
{
    using Windows.UI;
    using Windows.UI.Xaml.Data;
    using Windows.UI.Xaml.Media;

    public class StringToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var colorString = value as string;
            if (colorString == null) return null;

            return new SolidColorBrush(ColorHelper.FromArgb(255,
                byte.Parse(colorString.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
                byte.Parse(colorString.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
                byte.Parse(colorString.Substring(4, 2), System.Globalization.NumberStyles.HexNumber)));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
