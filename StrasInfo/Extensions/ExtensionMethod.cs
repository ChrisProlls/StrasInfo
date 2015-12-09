using System;
using System.Collections.Generic;
using System.Text;

namespace StrasInfo.Extensions
{
    using System.Linq;
    using System.Reflection;

    using Windows.Devices.Geolocation;

    using StrasInfo.Models.Transport;
    using Windows.UI.Xaml.Controls.Maps;
    using System.Threading.Tasks;
    using Windows.Storage.Streams;
    using Windows.Foundation;
    using Windows.UI.Xaml.Media.Imaging;
    using Windows.UI.Xaml.Controls;
    using StrasServiceSoap;
    using System.Collections.ObjectModel;

    public static class ExtensionMethod
    {
        public static async Task ActivateUserPositionAsync(this MapControl map)
        {
            Geolocator myGeolocator = new Geolocator();
            Geoposition myGeoposition = await myGeolocator.GetGeopositionAsync();
            Geocoordinate myGeocoordinate = myGeoposition.Coordinate;

            var mapIcon = new Image();
            mapIcon.Source = new BitmapImage(new Uri("ms-appx:///Assets/GPSposition.png"));

            map.Children.Add(mapIcon);

            MapControl.SetNormalizedAnchorPoint(mapIcon, new Point(0.5, 1.0));
            MapControl.SetLocation(mapIcon, new Geopoint(new BasicGeoposition
            {
                Latitude = myGeocoordinate.Point.Position.Latitude,
                Longitude = myGeocoordinate.Point.Position.Longitude
            }));

            myGeolocator.PositionChanged += async (sender, args) =>
            {
                

                await GalaSoft.MvvmLight.Threading.DispatcherHelper.RunAsync(() => MapControl.SetLocation(mapIcon, new Geopoint(new BasicGeoposition
                {
                    Latitude = args.Position.Coordinate.Latitude,
                    Longitude = args.Position.Coordinate.Longitude
                })));
            };
        }

        public static bool HasItemByField<T>(this IEnumerable<T> list, string item, string field)
        {
            return list.Any(element => GetValueByStringField(element, field) == item);
        }

        private static string GetValueByStringField<T>(T item, string field)
        {
            return item.GetType().GetRuntimeProperty(field).GetValue(item, null) as string;
        }

        public static ArriveeModel ToArriveeModel(this Arrivee arrivee, IList<Ligne> Lignes)
        {
            var indexWhiteSpace = arrivee.Destination.IndexOf(' ') + 1;
            var destination = arrivee.Destination.Substring(indexWhiteSpace).Trim();
            var number = arrivee.Destination.Substring(0, indexWhiteSpace).Trim();

            return new ArriveeModel
            {
                Number = number,
                Destination = destination,
                EstApresMinuit = arrivee.EstApresMinuit,
                Horaire = TimeSpan.Parse(arrivee.Horaire).ToString(@"hh\:mm"),
                Mode = arrivee.Mode,
                Color = Lignes.Where(ligne => number.Contains(ligne.Number)).FirstOrDefault().Color
            };
        }

        #region Distance

        public static string StringDistanceInKmFrom(this Geocoordinate coord, double lat2, double lon2)
        {
            return Math.Round(DistanceInKmFrom(coord, lat2, lon2), 1) + " km";
        }

        public static double DistanceInKmFrom(this Geocoordinate coord, double lat2, double lon2)
        {
            char unit = 'K';
            double theta = coord.Point.Position.Longitude - lon2;
            double dist = Math.Sin(deg2rad(coord.Point.Position.Latitude)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(coord.Point.Position.Latitude)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta));
            dist = Math.Acos(dist);
            dist = rad2deg(dist);
            dist = dist * 60 * 1.1515;
            if (unit == 'K')
                dist = dist * 1.609344;
            else if (unit == 'N')
                dist = dist * 0.8684;

            return (dist);
        }

        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::  This function converts decimal degrees to radians             :::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private static double deg2rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }

        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::  This function converts radians to decimal degrees             :::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private static double rad2deg(double rad)
        {
            return (rad / Math.PI * 180.0);
        }

        #endregion

    }
}
