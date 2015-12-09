using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using StrasInfo.CustomEnum;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Windows.ApplicationModel;
using Windows.UI.Core;

namespace StrasInfo.ViewModels
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public string Version { get; private set; }
        /// <summary>
        /// The current view.
        /// </summary>
        private ViewModelBase currentView;

        /// <summary>
        /// Gets or sets the current view.
        /// </summary>
        public ViewModelBase CurrentView
        {
            get { return this.currentView; }
            set
            {
                if (value != this.currentView)
                {
                    this.currentView = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        public ICommand SwitchViewsCommand { get; private set; }
        public ICommand ChangeSlideViewPositionCommand { get; private set; }

        public EnumType EnumType { get; private set; }

        private readonly ReadOnlyCollection<ViewModelBase> viewsModelBases;

        private bool isMenuOpened;

        public bool IsMenuOpened
        {
            get { return isMenuOpened; }
            set
            {
                this.isMenuOpened = value;
                this.RaisePropertyChanged();
            }
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        public MainViewModel()
        {
            var locator = App.Current.Resources["Locator"] as ViewModelLocator;

            this.EnumType = new EnumType();
            this.viewsModelBases = new ReadOnlyCollection<ViewModelBase>(new ViewModelBase[]
                                                                             {
                                                                                 locator.HomeModel,
                                                                                 locator.TraficModel,
                                                                                 locator.TransportModel
                                                                             });

            this.SwitchViewsCommand = new RelayCommand<EnumType>(
                enumType =>
                {
                    if (this.viewsModelBases.Any(viewsModelBase => viewsModelBase.GetType() == enumType.Value))
                    {
                        this.CurrentView = this.viewsModelBases.First(viewModelBase => viewModelBase.GetType() == enumType.Value);
                        this.OnChangeSlideViewPosition();
                    }
                });

            this.ChangeSlideViewPositionCommand = new RelayCommand(this.OnChangeSlideViewPosition);
            this.CurrentView = this.viewsModelBases.First();

            var versionTmp = Package.Current.Id.Version;
            this.Version = String.Format("Version : {0}.{1}.{2}.{3}",
                versionTmp.Major, versionTmp.Minor, versionTmp.Build, versionTmp.Revision);

            locator.HomeModel.ArretDetailRequested += (sender, arret) => {
                var transportModel = locator.TransportModel;

                transportModel.ShowLigneList = false;
                transportModel.ShowArretList = false;
                transportModel.SelectArretCommand.Execute(arret);

                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;

                this.CurrentView = transportModel;
            };
        }

        public event EventHandler ChangeSlideViewPosition;

        protected virtual void OnChangeSlideViewPosition()
        {
            EventHandler handler = this.ChangeSlideViewPosition;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
    }
}