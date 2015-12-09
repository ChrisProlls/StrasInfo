using System;
using System.Collections.Generic;
using System.Text;

namespace StrasInfo.Models.Transport
{
    using StrasServiceSoap;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class Arret : INotifyPropertyChanged
    {
        public Arret()
        {
            this.NextDeparture = "en cours ...";
            this.Arrivees = new ObservableCollection<ArriveeModel>();
        }
        public string Id { get; set; }

        public string Code  { get; set; }

        public GeoCoordinate Coordonnee { get; set; }

        public ObservableCollection<ArriveeModel> Arrivees { get; set; }
        private ArriveeModel nextArrivee;

        public ArriveeModel NextArrivee
        {
            get { return nextArrivee; }
            set {
                nextArrivee = value;
                this.OnPropertyChanged();
            }
        }


        public string Name { get; set; }

        public string Distance { get; set; }

        private string _nextDeparture;

        public string NextDeparture
        {
            get { return _nextDeparture; }
            set
            {
                _nextDeparture = value;
                this.OnPropertyChanged();
            }
        }


        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }

    public struct GeoCoordinate
    {
        private readonly double latitude;
        private readonly double longitude;

        public double Latitude { get { return latitude; } }
        public double Longitude { get { return longitude; } }

        public GeoCoordinate(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", Latitude, Longitude);
        }
    }
}
