using System;
using System.Collections.Generic;
using System.Text;

namespace StrasInfo.Converter
{
    using Windows.UI;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Data;
    using Windows.UI.Xaml.Media;

    using GalaSoft.MvvmLight;

    using StrasInfo.CustomEnum;

    public class ViewModelToBackgroundConverter : DependencyObject, IValueConverter
    {
        public EnumType CurrentEnumType
        {
            get { return (EnumType)GetValue(CurrentEnumTypeProperty); }
            set { SetValue(CurrentEnumTypeProperty, value); }
        }

        private static readonly DependencyProperty CurrentEnumTypeProperty =
            DependencyProperty.Register("CurrentEnumType",
                                        typeof(EnumType),
                                        typeof(ViewModelToBackgroundConverter),
                                        new PropertyMetadata(null));

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value.GetType() == this.CurrentEnumType.Value ? Application.Current.Resources["ApplicationMainColor"] : null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
