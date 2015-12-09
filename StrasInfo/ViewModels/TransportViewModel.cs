using GalaSoft.MvvmLight;
using System.Threading.Tasks;

namespace StrasInfo.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    using System.Net.Http;

    using Windows.Devices.Geolocation;
    using Windows.Networking.BackgroundTransfer;
    using Windows.Storage;
    using Windows.UI.Core;
    using Windows.UI.Popups;

    using CsvHelper;

    using GalaSoft.MvvmLight.Command;
    using GalaSoft.MvvmLight.Threading;

    using MoreLinq;

    using StrasInfo.Extensions;
    using StrasInfo.Models.GTFS;
    using StrasInfo.Models.Transport;
    using Service;
    using StrasServiceSoap;
    using System.ServiceModel;

    public class TransportViewModel : ViewModelBase
    {
        public ObservableCollection<Ligne> Lignes { get; set; }

        private bool showLigneList;

        public bool ShowLigneList
        {
            get { return this.showLigneList; }
            set
            {
                this.showLigneList = value;
                this.RaisePropertyChanged();
            }
        }

        private bool showArretList;

        public bool ShowArretList
        {
            get { return this.showArretList; }
            set
            {
                this.showArretList = value;
                this.RaisePropertyChanged();
            }
        }

        private bool showArretDetail;

        public bool ShowArretDetail
        {
            get { return showArretDetail; }
            set
            {
                showArretDetail = value;
                RaisePropertyChanged();
            }
        }

        private Models.Transport.Arret _selectedArret;

        public Models.Transport.Arret SelectedArret
        {
            get { return _selectedArret; }
            set
            {
                _selectedArret = value;
                RaisePropertyChanged();
            }
        }


        private Ligne _selectedLigne;
        public Ligne SelectedLigne
        {
            get { return this._selectedLigne; }
            set
            {
                this._selectedLigne = value;
                this.RaisePropertyChanged();
            }
        }
        private bool _isFavorite;

        public bool IsFavorite
        {
            get { return _isFavorite; }
            set {
                _isFavorite = value;
                this.RaisePropertyChanged();
            }
        }


        public RelayCommand<Ligne> SelectLigneCommand { get; set; }
        public RelayCommand<Models.Transport.Arret> SelectArretCommand { get; set; }
        public RelayCommand ToogleFavorite { get; set; }

        public TransportViewModel()
        {
            this.ShowLigneList = true;
            this.Lignes = new ObservableCollection<Ligne>();

            this.SelectLigneCommand = new RelayCommand<Ligne>(
                async ligne =>
                    {
                        Geolocator geo = new Geolocator();
                        Geoposition position = await geo.GetGeopositionAsync();

                        this.SelectedLigne = GetArretDistanceFromCurrentPosition(ligne, position);
                        this.ShowArretList = true;


                        foreach (var arret in this.SelectedLigne.Arrets)
                        {
                            if (this.ShowArretDetail)
                                return;

                            var nextDeparture = "Indisponible";

                            try
                            {
                                var arrets = await StrasService.GetArret(arret.Code);

                                if (arrets.Count > 0)
                                    nextDeparture = TimeSpan.Parse(arrets.First(item => item.Destination.Contains(this.SelectedLigne.Number)).Horaire).ToString(@"hh\:mm");
                            }
                            catch (FaultException e)
                            {
                                try
                                {
                                    var arrets = await StrasService.GetArretByLibelle(arret.Name);

                                    if (arrets.Count > 0)
                                        nextDeparture = TimeSpan.Parse(arrets.First().Horaire).ToString(@"hh\:mm");

                                }
                                catch { }
                            }
                            catch (InvalidOperationException invalid) {  }
                            finally
                            {
                                arret.NextDeparture = nextDeparture;
                            }
                        }

                    });

            this.SelectArretCommand = new RelayCommand<Models.Transport.Arret>(
                async arret =>
            {
                arret.Arrivees.Clear();

                this.SelectedArret = arret;
                this.ShowArretDetail = true;

                // If we go to the TransportView from the HomeView (favorite)
                if (this.SelectedLigne == null || !this.SelectedLigne.Arrets.Any(item => item.Id == arret.Id))
                    this.SelectedLigne = Ligne.GetAllLignes().First(ligne => ligne.Arrets.Any(item => item.Id == arret.Id));

                var arrivees = (await StrasService.GetArret(arret.Code)).OrderBy(arrivee => TimeSpan.Parse(arrivee.Horaire)).ToList();

                if (arrivees.Count() == 0)
                    return;

                arrivees = arrivees
                    .SkipWhile(arrive => arrive.EstApresMinuit)
                    .Concat(arrivees.TakeWhile(arrive => arrive.EstApresMinuit)).ToList();

                this.SelectedArret.NextArrivee = arrivees.First().ToArriveeModel(this.Lignes);

                foreach (var item in arrivees.Skip(1))
                    this.SelectedArret.Arrivees.Add(item.ToArriveeModel(this.Lignes));

                this.IsFavorite = IsArretInFavorite(arret);
            });

            this.ToogleFavorite = new RelayCommand(
                () => {
                    ApplicationDataContainer settingsRoaming = ApplicationData.Current.RoamingSettings;
                    ApplicationDataCompositeValue composite = new ApplicationDataCompositeValue();

                    var key = $"{this.SelectedArret.Code}/{this.SelectedArret.Name}";

                    composite["Code"] = this.SelectedArret.Code;
                    composite["Name"] = this.SelectedArret.Name;
                    composite["Id"] = this.SelectedArret.Id;

                    if (!settingsRoaming.Values.Keys.Contains(key))
                    {
                        settingsRoaming.Values[key] = composite;
                        this.IsFavorite = true;
                    }
                    else
                    {
                        settingsRoaming.Values.Remove(key);
                        this.IsFavorite = false;
                    }
                });
        }

        private bool IsArretInFavorite(Models.Transport.Arret arret)
        {
            ApplicationDataContainer settingsRoaming = ApplicationData.Current.RoamingSettings;
            return settingsRoaming.Values.Any(keyValue => {
                var composite = keyValue.Value as ApplicationDataCompositeValue;
                var code = composite["Code"] as string;

                return code == arret.Code;
            });
        }

        private Ligne GetArretDistanceFromCurrentPosition(Ligne ligne, Geoposition position)
        {
            ligne.Arrets.ForEach(
                arret => arret.Distance = position.Coordinate.StringDistanceInKmFrom(arret.Coordonnee.Latitude, arret.Coordonnee.Longitude));

            ligne.Arrets = ligne.Arrets.OrderBy(arret => arret.Distance).ToList();

            return ligne;
        }

        public void LoadDatas()
        {
            Task.Factory.StartNew(
                async () =>
                    {
                        try
                        {
                            foreach (var ligne in Ligne.GetAllLignes().OrderByDescending(ligne => ligne.Number))
                            {
                                Ligne ligne1 = ligne;
                                await DispatcherHelper.UIDispatcher.RunAsync(
                                                                    CoreDispatcherPriority.High,
                                                                    () => this.Lignes.Add(ligne1));
                            }

                            //await this.DownloadZip();
                            //await this.DecompressZip();

                            //var routes = await this.GetLignes();

                            //var trips = await
                            //     this.GetListLineByLineRelatingToField<Trip>(
                            //         "trips", 
                            //         "route_id", 
                            //         routes.Last().Id,
                            //         "trip_headsign");

                            //var stopTimes = await
                            //     this.GetListLineByLineRelatingToField<StopTime>(
                            //         "stop_times",
                            //         "trip_id",
                            //         trips.First().trip_id,
                            //         "stop_id");

                            //var stop = await
                            //     this.GetSingleLineByLineRelatingToField<Stop>(
                            //         "stops",
                            //         "stop_id",
                            //         stopTimes.First().stop_id);
                        }
                        catch (Exception e)
                        {
                            var messageDialog = new MessageDialog(string.Format("Une erreur est survenue pendant le chargement des lignes CTS : {0}", e.Message));

                            // Add commands and set their callbacks; both buttons use the same callback function instead of inline event handlers
                            messageDialog.Commands.Add(new UICommand(
                                "Fermer"));

                            // Set the command that will be invoked by default
                            messageDialog.DefaultCommandIndex = 0;

                            // Set the command to be invoked when escape is pressed
                            messageDialog.CancelCommandIndex = 0;

                            // Show the message dialog
                            await messageDialog.ShowAsync();
                        }
                    });
        }

        //private async Task<List<Ligne>> GetLignes()
        //{
        //    return (await this.GetList<Route>("routes")).Select(route => new Ligne()
        //                                      {
        //                                          Id = route.route_id,
        //                                          Number = route.route_short_name,
        //                                          Color = route.route_color,
        //                                          Name = route.route_long_name
        //                                      }).ToList();
        //}

        //private async Task<List<T>> GetList<T>(string fileName)
        //{
        //    return (await GetCsvReader(fileName)).GetRecords<T>().ToList();
        //}

        //private async Task<CsvReader> GetCsvReader(string fileName)
        //{
        //    var file = await ApplicationData.Current.LocalFolder.GetFileAsync("gtfs\\" + fileName + ".txt");
        //    return new CsvReader(new StringReader(await FileIO.ReadTextAsync(file)));
        //}

        //private async Task<T> GetSingleLineByLineRelatingToField<T>(
        //    string fileName,
        //    string field,
        //    string fieldValue) where T : new()
        //{
        //    var csv = await this.GetCsvReader(fileName);
        //    while (csv.Read())
        //    {

        //        if (csv.GetField<string>(field) == fieldValue)
        //            return csv.GetRecord<T>();
        //    }

        //    return new T();
        //}

        //private async Task<List<T>> GetListLineByLineRelatingToField<T>(string fileName, string field, string fieldValue, string distinctBy)
        //{
        //    var list = new List<T>();

        //    var csv = await this.GetCsvReader(fileName);
        //    while (csv.Read())
        //    {

        //        if (csv.GetField<string>(field) == fieldValue && !list.HasItemByField(csv.GetField<string>(distinctBy), distinctBy))
        //            list.Add(csv.GetRecord<T>());
        //        //else if (list.Any() && list.HasItemByField(csv.GetField<string>(distinctBy), distinctBy))
        //        //    return list;
        //    }

        //    return list;
        //}

        //private async Task DownloadZip()
        //{
        //    const string FileLocation = "http://opendata.cts-strasbourg.fr/fichiers/gtfs/google_transit.zip";

        //    var file = await ApplicationData.Current.LocalFolder.CreateFileAsync("gtfs\\gtfs.zip", CreationCollisionOption.ReplaceExisting);
        //    var downloader = new BackgroundDownloader();
        //    var download = downloader.CreateDownload(
        //        new Uri(FileLocation),
        //        file);

        //    await download.StartAsync(); 
        //}

        //private async Task DecompressZip()
        //{
        //    var zipFolder = await ApplicationData.Current.LocalFolder.GetFolderAsync("gtfs");
        //    await this.UnZipFile(zipFolder, "gtfs\\gtfs.zip");
        //}

        //private async Task UnZipFile(
        //    StorageFolder zipFileDirectory,
        //    string zipFilename,
        //    StorageFolder extractFolder = null)
        //{
        //    if (extractFolder == null) extractFolder = zipFileDirectory;

        //    var folder = ApplicationData.Current.LocalFolder;

        //    using (var zipStream = await folder.OpenStreamForReadAsync(zipFilename))
        //    {
        //        using (MemoryStream zipMemoryStream = new MemoryStream((int)zipStream.Length))
        //        {
        //            await zipStream.CopyToAsync(zipMemoryStream);

        //            using (var archive = new ZipArchive(zipMemoryStream, ZipArchiveMode.Read))
        //            {
        //                foreach (ZipArchiveEntry entry in archive.Entries)
        //                {
        //                    if (entry.Name != "")
        //                    {
        //                        using (Stream fileData = entry.Open())
        //                        {
        //                            StorageFile outputFile =
        //                                await
        //                                extractFolder.CreateFileAsync(
        //                                    entry.FullName,
        //                                    CreationCollisionOption.ReplaceExisting);
        //                            using (Stream outputFileStream = await outputFile.OpenStreamForWriteAsync())
        //                            {
        //                                await fileData.CopyToAsync(outputFileStream);
        //                                await outputFileStream.FlushAsync();
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
