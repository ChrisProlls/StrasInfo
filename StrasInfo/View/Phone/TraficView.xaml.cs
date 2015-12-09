using System;
using System.Linq;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace StrasInfo.View.Phone
{
    using GalaSoft.MvvmLight.Threading;
    using Extensions;
    using StrasInfo.Models.TraficInfo;
    using StrasInfo.Popup;
    using System.Threading.Tasks;
    using ViewModels;
    using Windows.Devices.Geolocation;
    using Windows.Storage.Streams;
    using Windows.UI.Xaml.Controls.Maps;
    using Windows.UI.Core;

    public sealed partial class TraficView : UserControl
    {
        public static MapControl MapTraficControl { get; set; }
        public TraficView()
        {
            this.InitializeComponent();

            this.Loaded += (sender, args) =>
                {
                    SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;

                    this.StrasMapControl.Width = Window.Current.Bounds.Width;
                    this.StrasMapControl.Height = Window.Current.Bounds.Height - MainPagePhone.HeaderHeight;

                    ((TraficViewModel)this.DataContext).LoadDatas();

                    Windows.Services.Maps.MapService.ServiceToken = "1uXQY1wo39PWxZO66Xww~Gcr2KW6qG4caAtJMr4tH3A~Aq9FrcCWUZOkdaixiXx8S0q5e2epchPRvwTDTXcj0_YnaDZK4iFgpe0sKp3lhnCP";

                    Task.Run(
                    async () =>
                    {
                        await DispatcherHelper.RunAsync(async () => await this.StrasMapControl.ActivateUserPositionAsync());
                    });
                };

            this.StrasMapControl.Center = new Geopoint(new BasicGeoposition()
            {
                Latitude = 48.5836,
                Longitude = 7.74806
            });

            this.StrasMapControl.ZoomLevel = 12;
            this.StrasMapControl.LandmarksVisible = true;

            MapTraficControl = this.StrasMapControl;
        }

        private async void UIElement_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            this.DeleteAllPopup();

            Image image = sender as Image;

            if (image != null)
            {
                TraficInfoStatus.S context = image.DataContext as TraficInfoStatus.S;
                if (context != null)
                {
                    PopupInfoStatus popup = new PopupInfoStatus { DataContext = context };

                    this.StrasMapControl.Children.Add(popup);

                    Geopoint popupGeopoint = new Geopoint(new BasicGeoposition
                    {
                        Latitude = context.Geopoint.Position.Latitude,
                        Longitude = context.Geopoint.Position.Longitude
                    });

                    MapControl.SetLocation(popup, popupGeopoint);
                    MapControl.SetNormalizedAnchorPoint(popup, new Point(0.5, 0.55));

                    await this.StrasMapControl.TrySetViewAsync(popupGeopoint, 15, 0, 0, MapAnimationKind.Bow);
                }
            }
        }

        private void DeleteAllPopup()
        {
            foreach (PopupInfoStatus child in this.StrasMapControl.Children.OfType<PopupInfoStatus>())
                this.StrasMapControl.Children.Remove(child);
        }

        private void MapControl_OnMapTapped(MapControl sender, MapInputEventArgs args)
        {
            this.DeleteAllPopup();
        }
    }
}
