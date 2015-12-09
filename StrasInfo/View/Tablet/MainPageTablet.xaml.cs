using StrasInfo.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Hub Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=321224

namespace StrasInfo.View.Tablet
{
    using Windows.Devices.Geolocation;
    using Windows.UI;


    using StrasInfo.Models.TraficInfo;
    using StrasInfo.Popup;
    using StrasInfo.ViewModels;
    using Windows.UI.Xaml.Controls.Maps;
    using System.Threading.Tasks;
    using GalaSoft.MvvmLight.Threading;
    using Windows.Storage.Streams;
    using Extensions;

    /// <summary>
    /// A page that displays a grouped collection of items.
    /// </summary>
    public sealed partial class MainPageTablet : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        public MainPageTablet()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;

            this.Loaded += (sender, args) =>
            {
                var homeViewModel = TraficStatusSection.DataContext as HomeViewModel;
                var traficViewModel = TraficSection.DataContext as TraficViewModel;

                if (traficViewModel != null) traficViewModel.LoadDatas();
                if (homeViewModel != null) homeViewModel.LoadDatas();
            };
        }


        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private MapControl map;
        private void Map_OnLoaded(object sender, RoutedEventArgs e)
        {
            map = sender as MapControl;

            if (map != null)
            {
                map.Width = Window.Current.Bounds.Width * 0.5;
                map.Height = Window.Current.Bounds.Height * 0.9;

                map.Center = new Geopoint(new BasicGeoposition {
                    Latitude = 48.5836,
                    Longitude = 7.74806
                });

                map.ZoomLevel = 13;

                Task.Run(
                    async () =>
                    {
                        await DispatcherHelper.RunAsync(async () => await map.ActivateUserPositionAsync());
                    });   
            }
        }

        private bool IsItemTapped;
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

                    Geopoint location = new Geopoint(new BasicGeoposition
                    {
                        Latitude = context.go.y,
                        Longitude = context.go.x
                    });

                    MapControl.SetLocation(popup, location);
                    MapControl.SetNormalizedAnchorPoint(popup, new Point(0.55, 0.70));

                    map.Children.Add(popup);
                    map.TrySetViewAsync(location, 15);

                    this.IsItemTapped = true;
                }
            }
        }

        private void DeleteAllPopup()
        {
            foreach (PopupInfoStatus child in map.Children.OfType<PopupInfoStatus>().ToArray())
                map.Children.Remove(child);
        }

        private void Map_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            if (this.IsItemTapped)
            {
                this.IsItemTapped = false;
                return;
            }

            this.DeleteAllPopup();
        }

        private void ListViewBase_OnItemClick(object sender, ItemClickEventArgs e)
        {
            var senderElement = sender as FrameworkElement;
            MenuFlyout flyoutBase = (MenuFlyout)FlyoutBase.GetAttachedFlyout(senderElement);

            if (flyoutBase.Items != null)
            {
                flyoutBase.Items[0].Tag = e.ClickedItem;
                flyoutBase.ShowAt(senderElement);
            }
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            OnGoAboutPage(this, null);
        }

        public delegate void GoAboutPage(object source, EventArgs e);

        public event GoAboutPage OnGoAboutPage;
    }
}
