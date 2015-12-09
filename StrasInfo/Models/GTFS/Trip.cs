using System;
using System.Collections.Generic;
using System.Text;

namespace StrasInfo.Models.GTFS
{
    class Trip
    {
        public string route_id { get; set; }

        public string trip_id { get; set; }

        public string trip_headsign { get; set; }
    }
}
