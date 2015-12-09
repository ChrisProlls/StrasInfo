using StrasInfo.ViewModels;
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
    public sealed partial class MainPagePhone : UserControl
    {
        public static double HeaderHeight;
        public MainPagePhone()
        {
            this.InitializeComponent();

            MainViewModel viewModel = this.DataContext as MainViewModel;
            if (viewModel != null)
            {
                viewModel.ChangeSlideViewPosition += (sender, args) =>
                {
                    if (!viewModel.IsMenuOpened)
                        this.RightContentStoryboard.Begin();
                    else
                        this.RightContentStoryboardClosed.Begin();

                    viewModel.IsMenuOpened = !viewModel.IsMenuOpened;

                    this.ManageGrayBackground(viewModel.IsMenuOpened);
                };
            }

            this.Loaded += (sender, args) =>
            {
                HeaderHeight = this.HeaderGrid.ActualHeight;
            };

            this.rightContent.OnGoAboutPage += (sender, args) => this.OnGoAboutPage(sender, args);
        }

        private void ManageGrayBackground(bool isOpen)
        {
            this.gridGrayBackground.Visibility = isOpen ? Visibility.Visible : Visibility.Collapsed;
            if (isOpen)
                this.ToGrayBackground.Begin();
            else
                this.ToTransparentBackground.Begin();
        }

        public delegate void GoAboutPage(object source, EventArgs e);

        public event GoAboutPage OnGoAboutPage;
    }
}
