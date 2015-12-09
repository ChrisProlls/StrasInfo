using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrasInfo.Models.Transport
{
    public class ArriveeModel
    {
        public string Mode { get; set; }
        public string Destination { get; set; }
        public string Horaire { get; set; }
        public bool EstApresMinuit { get; set; }
        public string Color { get; set; }
        public string Number { get; set; }
    }
}
