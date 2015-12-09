using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace StrasInfo.View.Phone
{
    using Models.Transport;
    using StrasInfo.ViewModels;
    using Windows.UI.Core;

    public sealed partial class HomeView : UserControl
    {
        public HomeView()
        {
            this.InitializeComponent();
            this.Loaded += (sender, args) =>
                {
                    SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;

                    var homeViewModel = this.DataContext as HomeViewModel;
                    if (homeViewModel != null) homeViewModel.LoadDatas();
                };
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

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var homeViewModel = this.DataContext as HomeViewModel;
            homeViewModel.RequestedDetailForArret(e.ClickedItem as Arret);
        }
    }
}
