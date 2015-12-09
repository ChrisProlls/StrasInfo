using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace StrasInfo.View.Phone
{
    using StrasInfo.Models.Transport;
    using StrasInfo.ViewModels;
    using System;
    using Windows.Foundation;
    using Windows.Phone.UI.Input;
    using Windows.UI.Core;
    using Windows.UI.Popups;
    using Windows.UI.Xaml.Controls.Maps;
    using Windows.UI.Xaml.Media.Imaging;

    public sealed partial class TransportView : UserControl
    {
        public TransportView()
        {
            this.InitializeComponent();
            this.Loaded += (sender, args) =>
            {
                var transportViewModel = this.DataContext as TransportViewModel;
                if (transportViewModel != null) transportViewModel.LoadDatas();

                SystemNavigationManager.GetForCurrentView().BackRequested += TransportView_BackRequested;

                if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons"))
                    HardwareButtons.BackPressed += HardwareButtonsOnBackPressed;

                if (transportViewModel.ShowArretDetail)
                {
                    SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
                    transportViewModel.ShowLigneList = false;
                }
            };

            this.Unloaded += (sender, args) => SystemNavigationManager.GetForCurrentView().BackRequested -= TransportView_BackRequested;

            this.LigneListView.Width = Window.Current.Bounds.Width;
            this.ArretListView.Width = Window.Current.Bounds.Width;
            this.ArriveeListView.Width = Window.Current.Bounds.Width;

            this.SizeChanged += (sender, args) =>
                {
                    var keyFrameValue = -1 * Window.Current.Bounds.Width;

                    this.HideListKeyFrame.Value = keyFrameValue;
                    this.ShowListKeyFrame.Value = keyFrameValue;
                    this.HideListKeyFrameListArret.Value = keyFrameValue;
                    this.ShowListKeyFrameListArret.Value = keyFrameValue;

                    this.LigneListView.Width = Window.Current.Bounds.Width;
                    this.ArretListView.Width = Window.Current.Bounds.Width;
                    this.ArriveeListView.Width = Window.Current.Bounds.Width;
                };
        }

        private void TransportView_BackRequested(object sender, BackRequestedEventArgs e)
        {
            HandleBackRequest();
        }

        private void HardwareButtonsOnBackPressed(object sender, BackPressedEventArgs backPressedEventArgs)
        {
            HandleBackRequest();
        }

        private void HandleBackRequest()
        {
            var transportViewModel = this.DataContext as TransportViewModel;
            
            if (transportViewModel.ShowArretDetail)
            {
                transportViewModel.ShowArretList = true;
                transportViewModel.ShowArretDetail = false;

                this.ShowListViewArret.Begin();
                transportViewModel.SelectLigneCommand.Execute(transportViewModel.SelectedLigne);
            }
            else if (transportViewModel.ShowArretList)
            {
                transportViewModel.ShowLigneList = true;
                transportViewModel.ShowArretList = false;
                this.ShowListViewLigne.Begin();

                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }

        }

        private void ListViewBase_OnItemClick(object sender, ItemClickEventArgs e)
        {
            var transportViewModel = this.DataContext as TransportViewModel;
            if (transportViewModel != null)
            {
                transportViewModel.SelectLigneCommand.Execute(e.ClickedItem as Ligne);

                this.HideListViewLigne.Completed += (o, o1) => transportViewModel.ShowLigneList = false;
                this.HideListViewLigne.Begin();

                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            }
        }

        private async void ArretListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var transportViewModel = this.DataContext as TransportViewModel;
            if (transportViewModel != null)
            {
                var arret = e.ClickedItem as Arret;

                if(arret.Code == "999")
                {
                    var messageDialog = new MessageDialog("Impossible de récupérer les horaires de l'arrêt sélectionné.");
                    messageDialog.Commands.Add(new UICommand("Fermer"));
                    messageDialog.DefaultCommandIndex = 0;
                    messageDialog.CancelCommandIndex = 0;
                    await messageDialog.ShowAsync();
                    return;
                }

                transportViewModel.SelectArretCommand.Execute(arret);

                this.HideListViewArret.Completed += (o, o1) => transportViewModel.ShowArretList = false;
                this.HideListViewArret.Begin();

                var position = new Windows.Devices.Geolocation.Geopoint(
                    new Windows.Devices.Geolocation.BasicGeoposition
                    {
                        Latitude = arret.Coordonnee.Latitude,
                        Longitude = arret.Coordonnee.Longitude
                    });

                this.StrasMapControl.Center = position;

                var mapIcon = new Image();
                mapIcon.Source = new BitmapImage(new Uri("ms-appx:///Assets/GPSposition.png"));

                this.StrasMapControl.Children.Add(mapIcon);

                MapControl.SetNormalizedAnchorPoint(mapIcon, new Point(0.5, 1.0));
                MapControl.SetLocation(mapIcon, position);

                await this.StrasMapControl.TrySetViewAsync(position, 18, 0, 0, MapAnimationKind.Bow);
            }
        }
    }
}
