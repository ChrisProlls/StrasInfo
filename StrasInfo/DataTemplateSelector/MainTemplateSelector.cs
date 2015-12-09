using System;
using System.Collections.Generic;
using System.Text;

namespace StrasInfo.DataTemplateSelector
{
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    using GalaSoft.MvvmLight;
    using StrasInfo.ViewModels;

    class MainTemplateSelector : DataTemplateSelector
    {
        public DataTemplate HomeTemplate { get; set; }
        public DataTemplate TraficTemplate { get; set; }
        public DataTemplate TransportTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            ViewModelBase value = item as ViewModelBase;

            if (value != null)
            {
                if (value is HomeViewModel)         return HomeTemplate;
                if (value is TraficViewModel)       return TraficTemplate;
                if (value is TransportViewModel)    return TransportTemplate;

                return base.SelectTemplateCore(item, container);
            }
            
            return base.SelectTemplateCore(item, container);
        }
    }
}
