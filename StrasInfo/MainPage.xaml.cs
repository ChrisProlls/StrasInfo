using StrasInfo.View.Tablet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.Profile;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace StrasInfo
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;

            this.customSplashScreen.AnimationCompleted += (sender, args) => this.HideSplashScreen.Begin();
            this.HideSplashScreen.Completed += (sender, o) =>
            {
                this.customSplashScreen.Visibility = Visibility.Collapsed;

                if (AnalyticsInfo.VersionInfo.DeviceFamily.Contains("Desktop"))
                {
                    this.TabletPage.BottomAppBar.ClosedDisplayMode = AppBarClosedDisplayMode.Compact;
                    this.TabletPage.OnGoAboutPage += (control, args) => this.Frame.Navigate(typeof(About));
                }else if (AnalyticsInfo.VersionInfo.DeviceFamily.Contains("Mobile"))
                {
                    this.PhonePage.OnGoAboutPage += (control, args) => this.Frame.Navigate(typeof(About));
                }
            };

            this.SizeChanged += (sender, args) => this.HideSplashScreenFrame.Value =  -1 * Window.Current.Bounds.Width;
        }
    }
}
