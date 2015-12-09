using System;
using System.Collections.Generic;
using System.Text;

namespace StrasInfo.Models.GTFS
{
    public class Route
    {
        public string route_id { get; set; }

        public string route_short_name { get; set; }

        public string route_long_name { get; set; }

        public string route_desc { get; set; }

        public string route_type { get; set; }

        public string route_color { get; set; }

        public string route_text_color { get; set; }
    }
}
