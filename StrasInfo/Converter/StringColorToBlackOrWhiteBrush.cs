using System;
using System.Collections.Generic;
using System.Text;

namespace StrasInfo.Converter
{
    using Windows.UI;
    using Windows.UI.Xaml.Data;
    using Windows.UI.Xaml.Media;

    public class StringColorToBlackOrWhiteBrush : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var colorString = value as string;
            if (colorString == null) return null;

            var colorToCompare =  new SolidColorBrush(ColorHelper.FromArgb(255,
                byte.Parse(colorString.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
                byte.Parse(colorString.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
                byte.Parse(colorString.Substring(4, 2), System.Globalization.NumberStyles.HexNumber)));

            return new SolidColorBrush(this.ContrastColor(colorToCompare));
        }

        Color ContrastColor(SolidColorBrush color)
        {
            byte d = 0;

            // Counting the perceptive luminance - human eye favors green color... 
            double a = 1 - (0.299 * color.Color.R + 0.587 * color.Color.G + 0.114 * color.Color.B) / 255;

            if (a < 0.5)
                d = 0; // bright colors - black font
            else
                d = 255; // dark colors - white font

            return Color.FromArgb(255, d, d, d);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
