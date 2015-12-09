using System;
using System.Collections.Generic;
using System.Text;

namespace StrasInfo.Converter
{
    using Windows.UI;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Data;
    using Windows.UI.Xaml.Media;

    public class BooleanToTransparentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (bool)value ? new SolidColorBrush(Colors.Transparent) : null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
