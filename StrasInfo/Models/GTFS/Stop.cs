using System;
using System.Collections.Generic;
using System.Text;

namespace StrasInfo.Models.GTFS
{
    public class Stop
    {
        public string stop_id { get; set; }

        public string stop_code { get; set; }

        public string stop_lat { get; set; }

        public string stop_lon { get; set; }

        public string stop_name { get; set; }

        public string stop_url { get; set; }

        public string stop_desc { get; set; }
    }
}
