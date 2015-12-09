using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace StrasInfo.View.Phone
{
    using StrasInfo.ViewModels;

    public sealed partial class RightContent : UserControl
    {
        public RightContent()
        {
            this.InitializeComponent();
        }

        private void UIElement_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            (this.DataContext as MainViewModel).ChangeSlideViewPositionCommand.Execute(null);
 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OnGoAboutPage(this, null);
        }

        public delegate void GoAboutPage(object source, EventArgs e);

        public event GoAboutPage OnGoAboutPage;
    }
}
