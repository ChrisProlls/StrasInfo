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
    using System.Threading.Tasks;

    public sealed partial class CustomSplashScreen : UserControl
    {
        public event EventHandler AnimationCompleted;

        private void OnAnimationCompleted()
        {
            EventHandler handler = this.AnimationCompleted;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        public CustomSplashScreen()
        {
            this.InitializeComponent();

            this.MoveText.Begin();
            this.ChangeColor.Begin();

            this.ChangeColor.Completed += (sender, o) => this.OnAnimationCompleted();
        }
    }
}
