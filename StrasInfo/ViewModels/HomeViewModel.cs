using System;
using System.Collections.Generic;

namespace StrasInfo.ViewModels
{
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using GalaSoft.MvvmLight.Threading;
    using StrasInfo.Extensions;
    using StrasInfo.Models.Parking;
    using StrasInfo.Models.TraficInfo;
    using Models.Transport;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Windows.Devices.Geolocation;
    using Windows.Networking.Connectivity;
    using Windows.UI.Popups;
    using Windows.Storage;
    using Service;
    using System.Globalization;
    /// <summary>
    /// The home view model.
    /// </summary>
    public class HomeViewModel : ViewModelBase
    {
        public ObservableCollection<ParkingInfo> ParkingInfos { get; private set; }

        public ObservableCollection<TraficInfoStatus.S> TraficStatus { get; private set; }

        public ObservableCollection<TraficInfoAlert.S> TraficAlerts { get; private set; }

        public ObservableCollection<Arret> FavoriteHours { get; set; }

        #region Property

        private bool isAlertWhenLoadedComplete;

        public bool IsAlertWhenLoadedComplete
        {
            get { return isAlertWhenLoadedComplete; }
            set
            {
                isAlertWhenLoadedComplete = value;
                this.RaisePropertyChanged();
            }
        }

        private bool isAlert;

        public bool IsAlert
        {
            get { return isAlert; }
            set
            {
                isAlert = value;
                this.RaisePropertyChanged();
            }
        }

        private bool traficStatusLoaded;

        public bool TraficStatusLoaded
        {
            get { return traficStatusLoaded; }
            set
            {
                traficStatusLoaded = value;
                this.RaisePropertyChanged();
            }
        }

        private bool traficAlertLoaded;

        public bool TraficAlertLoaded
        {
            get { return traficAlertLoaded; }
            set
            {
                traficAlertLoaded = value;
                this.RaisePropertyChanged();
            }
        }

        private bool parkingsLoaded;

        public bool ParkingsLoaded
        {
            get { return parkingsLoaded; }
            set
            {
                parkingsLoaded = value;
                this.RaisePropertyChanged();
            }
        }

        private bool _isFavoriteHours;

        public bool IsFavoriteHours
        {
            get { return _isFavoriteHours; }
            set
            {
                _isFavoriteHours = value;
                this.RaisePropertyChanged();
            }
        }


        #endregion

        public ICommand ItineraireCommand { get; set; }

        public HomeViewModel()
        {
            this.TraficStatus = new ObservableCollection<TraficInfoStatus.S>();
            this.TraficAlerts = new ObservableCollection<TraficInfoAlert.S>();
            this.ParkingInfos = new ObservableCollection<ParkingInfo>();
            this.FavoriteHours = new ObservableCollection<Arret>();

            this.IsAlertWhenLoadedComplete = true;
        }

        private static bool IsConnectedToInternet()
        {
            ConnectionProfile connectionProfile = NetworkInformation.GetInternetConnectionProfile();
            return (connectionProfile != null
               && connectionProfile.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess);

        }

        public void RequestedDetailForArret(Arret arret)
        {
            this.OnArretDetailRequested(arret);
        }

        public async void LoadDatas()
        {
            if (!IsConnectedToInternet())
            {
                await ShowDialogBox("Aucune connexion internet.",
                    "Réessayer",
                    command => this.LoadDatas(),
                    "Fermer",
                    command =>
                    {
                        this.ParkingsLoaded = true;
                        this.TraficAlertLoaded = true;
                        this.traficStatusLoaded = true;
                    });

                return;
            }

            this.ParkingsLoaded = false;
            this.TraficAlertLoaded = false;
            this.traficStatusLoaded = false;

            await Task.Factory.StartNew(
                async () =>
                {
                    try
                    {
                        Geolocator geo = new Geolocator();
                        Geoposition position = await geo.GetGeopositionAsync();

                        await DispatcherHelper.RunAsync(
                            async () =>
                            {
                                this.TraficStatus.Clear();
                                this.TraficAlerts.Clear();
                                this.ParkingInfos.Clear();
                                this.FavoriteHours.Clear();

                                await LoadFavoriteHours();

                                foreach (var source in await this.LoadTraficInfoStatus(position)) this.TraficStatus.Add(source);
                                this.TraficStatusLoaded = true;

                                foreach (var source in await this.LoadTraficInfoAlert(position)) this.TraficAlerts.Add(source);
                                this.TraficAlertLoaded = true;

                                foreach (var source in await this.LoadParkingInfo(position)) this.ParkingInfos.Add(source);
                                this.ParkingsLoaded = true;

                                this.IsAlert = this.TraficAlerts.Count > 0;
                                this.IsAlertWhenLoadedComplete = this.IsAlert && this.TraficAlertLoaded;
                            });


                        this.ItineraireCommand =
                            new RelayCommand<ParkingInfo>(
                                info => this.RequestDirections(info.go.y.ToString(), info.go.x.ToString()));
                    }
                    catch (Exception e)
                    {
                        await ShowDialogBox("Erreur - géolocalisation impossible, avez-vous activé la géoloc. pour StrasInfo dans Paramètre -> Emplacement ?",
                            "Réessayer",
                            command => this.LoadDatas(),
                            "Fermer",
                            command =>
                            {
                                this.ParkingsLoaded = true;
                                this.TraficAlertLoaded = true;
                                this.traficStatusLoaded = true;
                            });
                    }

                });
        }

        private async Task LoadFavoriteHours()
        {
            var settingsRoaming = ApplicationData.Current.RoamingSettings;
            var allLines = Ligne.GetAllLignes();

            foreach (var keyValue in settingsRoaming.Values)
            {
                ApplicationDataCompositeValue item = keyValue.Value as ApplicationDataCompositeValue;

                var arret = new Arret
                {
                    Name = item["Name"] as string,
                    Code = item["Code"] as string,
                    Id = item["Id"] as string
                };

                try
                {
                    await AddFavoriteHours(arret, allLines);
                }
                catch { await AddFavoriteHours(arret, allLines); }
            }

            this.IsFavoriteHours = this.FavoriteHours.Count > 0;
        }

        private async Task AddFavoriteHours(Arret arret, List<Ligne> allLines)
        {
            var arrivees = (await StrasService.GetArret(arret.Code)).OrderBy(arrivee => TimeSpan.Parse(arrivee.Horaire)).ToList();


            if (arrivees.Count() == 0)
                return;

            arrivees = arrivees
                .SkipWhile(arrive => arrive.EstApresMinuit)
                .Concat(arrivees.TakeWhile(arrive => arrive.EstApresMinuit)).ToList();

            foreach (var tmpArrivee in arrivees.Take(3))
                arret.Arrivees.Add(tmpArrivee.ToArriveeModel(allLines));

            this.FavoriteHours.Add(arret);
        }

        private async Task ShowDialogBox(string text, string firstButtonText, UICommandInvokedHandler firstButtonAction, string secondButtonText, UICommandInvokedHandler secondButtonAction)
        {
            // Create the message dialog and set its content
            var messageDialog = new MessageDialog(text);

            // Add commands and set their callbacks; both buttons use the same callback function instead of inline event handlers
            messageDialog.Commands.Add(new UICommand(
                firstButtonText,
                firstButtonAction));
            messageDialog.Commands.Add(new UICommand(
                secondButtonText,
                secondButtonAction));

            // Set the command that will be invoked by default
            messageDialog.DefaultCommandIndex = 0;

            // Set the command to be invoked when escape is pressed
            messageDialog.CancelCommandIndex = 1;

            // Show the message dialog
            await messageDialog.ShowAsync();
        }

        private async Task<IList<ParkingInfo>> LoadParkingInfo(Geoposition position)
        {
            List<ParkingInfo> tmpParkingInfo = await ParkingHelper.GetInfoJson();

            foreach (var item in tmpParkingInfo)
                item.distance =
                    position.Coordinate.StringDistanceInKmFrom(item.go.y, item.go.x);

            return new List<ParkingInfo>(tmpParkingInfo.OrderBy(s => s.distance));
        }

        private async Task<IList<TraficInfoAlert.S>> LoadTraficInfoAlert(Geoposition position)
        {
            TraficInfoAlert.RootObject traficInfoAlert = await TraficInfoAlert.GetInfoJson();

            foreach (var item in traficInfoAlert.s.Where(s => s.x != "0.00" && s.y != "0.00"))
                item.Distance =
                    position.Coordinate.StringDistanceInKmFrom(
                            double.Parse(item.y, CultureInfo.InvariantCulture),
                            double.Parse(item.x, CultureInfo.InvariantCulture));

            return new List<TraficInfoAlert.S>(traficInfoAlert.s.OrderBy(s => s.Distance));
        }

        private async Task<IList<TraficInfoStatus.S>> LoadTraficInfoStatus(Geoposition position)
        {
            TraficInfoStatus.RootObject traficInfoStatus = await TraficInfoStatus.GetInfoJson();

            foreach (var item in traficInfoStatus.s)
                item.Distance =
                    position.Coordinate.StringDistanceInKmFrom(
                            item.go.y,
                            item.go.x);

            return new List<TraficInfoStatus.S>(traficInfoStatus.s.OrderBy(s => s.Distance));
        }

        async void RequestDirections(string latitude, string longitude)
        {

            // Assemble the Uri to launch.
            Uri uri = new Uri("ms-drive-to:?destination.latitude=" + latitude.Replace(',', '.') +
                "&destination.longitude=" + longitude.Replace(',', '.'));

            // Launch the Uri.
            await Windows.System.Launcher.LaunchUriAsync(uri);

            /*if (!success)
            {
                var dialog = new MessageDialog("Impossible de lancer la navigation");
                await dialog.ShowAsync();
            }*/
        }

        #region Event

        public delegate void ArretDetailRequestedEventHandler(object sender, Arret arret);
        public event ArretDetailRequestedEventHandler ArretDetailRequested;

        private void OnArretDetailRequested(Arret arret)
        {
            var eh = ArretDetailRequested;
            if (eh != null) ArretDetailRequested(this, arret);
        }

        #endregion
    }
}
