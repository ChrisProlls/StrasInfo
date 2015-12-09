using System;
using System.Collections.Generic;
using System.Text;

namespace StrasInfo.Models.Parking
{
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;

    using Windows.UI;
    using Windows.UI.Xaml.Media;

    public class ParkingInfo
    {
        public string id { get; set; }

        public string distance { get; set; }

        public ParkingHelper.Go go { get; set; }

        public string nom { get; set; }

        public string status { get; set; }

        public Color statusColor { get; set; }

        public double placesDisponibles { get; set; }

        public double placesTotal { get; set; }

    }
    public static class ParkingHelper
    {
        private const string UrlGeometry = @"http://carto.strasmap.eu/remote.amf.json/Parking.geometry";
        private const string UrlStatus = @"http://carto.strasmap.eu/remote.amf.json/Parking.status";

        public async static Task<List<ParkingInfo>> GetInfoJson()
        {
            List<ParkingInfo> list = new List<ParkingInfo>();

            try
            {
                var client = WebRequest.CreateHttp(UrlGeometry);
                var response = await client.GetResponseAsync();
                var stream = response.GetResponseStream();
                var reader = new StreamReader(stream);
                var content = reader.ReadToEnd();

                RootObjectGeometry geometry = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObjectGeometry>(content);

                client = WebRequest.CreateHttp(UrlStatus);
                response = await client.GetResponseAsync();
                stream = response.GetResponseStream();
                reader = new StreamReader(stream);
                content = reader.ReadToEnd();

                RootObjectStatus listStatus = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObjectStatus>(content);

                list.AddRange(from geo in geometry.s 
                              let status = listStatus.s.FirstOrDefault(item => item.id == geo.id) 
                              select new ParkingInfo
                                         {
                                             id = geo.id, 
                                             nom = geo.ln, 
                                             status = GetStatus(status.ds),
                                             statusColor = status.ds == "status_1" ? Colors.LimeGreen : Colors.Red,
                                             placesDisponibles = Double.Parse(status.df), 
                                             placesTotal = Double.Parse(status.dt),
                                             go = geo.go
                                         });
            }
            catch (Exception) { }

            return list;
        }

        private static string GetStatus(string p)
        {
            var status = "";

            switch (p)
            {
                case "status_1" :
                    status = "Ouvert";
                    break;
                case "status_2":
                    status = "Complet";
                    break;
                case "status_3":
                    status = "Indisponible";
                    break;
                case "status_4":
                    status = "Fermé";
                    break;
            }

            return status;
        }

        public class Go
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class SGeometry
        {
            public string id { get; set; }
            public Go go { get; set; }
            public string ic { get; set; }
            public string ln2 { get; set; }
            public string ln { get; set; }
            public string pr { get; set; }
            public string price_fr { get; set; }
            public string price_en { get; set; }
            public string price_de { get; set; }
        }

        public class RootObjectGeometry
        {
            public List<object> d { get; set; }
            public List<SGeometry> s { get; set; }
        }

        public class SStatus
        {
            public string id { get; set; }
            public string ds { get; set; }
            public string df { get; set; }
            public string dt { get; set; }
        }

        public class RootObjectStatus
        {
            public List<object> d { get; set; }
            public List<SStatus> s { get; set; }
            public int calltime { get; set; }
            public string datatime { get; set; }
        }
    }
}
