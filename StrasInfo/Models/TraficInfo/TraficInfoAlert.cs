using System;
using System.Collections.Generic;
using System.Text;

namespace StrasInfo.Models.TraficInfo
{
    using System.IO;
    using System.Net;
    using System.Threading.Tasks;

    using GalaSoft.MvvmLight;

    public static class TraficInfoAlert
    {
        private const string Url = @"http://carto.strasmap.eu/remote.amf.json/TraficAlert.status";

        public async static Task<RootObject> GetInfoJson()
        {
            RootObject root = new RootObject
                                  {
                                      s = new List<S>()
                                  };

            try
            {
                var client = WebRequest.CreateHttp(Url);
                var response = await client.GetResponseAsync();
                var stream = response.GetResponseStream();
                var reader = new StreamReader(stream);
                var content = reader.ReadToEnd();

                root = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(content);
            }
            catch (Exception) { }

            return root;
        }
        public class S : ObservableObject
        {
            public string id { get; set; }
            public string uid { get; set; }
            public string ic { get; set; }
            public string ds { get; set; }
            public string x { get; set; }
            public string dp { get; set; }
            public string dt { get; set; }
            public string tp { get; set; }
            public string tb { get; set; }
            public string te { get; set; }
            public string evt_carto { get; set; }
            public string evt_liste { get; set; }
            public string y { get; set; }

            public string Distance { get; set; }
        }

        public class RootObject
        {
            public List<object> d { get; set; }
            public List<S> s { get; set; }
            public int calltime { get; set; }
            public string datatime { get; set; }
        }
    }

}
