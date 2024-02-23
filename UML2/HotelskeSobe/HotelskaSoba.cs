using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskeSobe {
    public class HotelskaSoba {
        public int OznakaSobe { get; set; }
        public int Kapacitet { get; set; }
        public HotelskaSoba(int oznaka, int kapacitet)
        {
            OznakaSobe = oznaka;
            Kapacitet = kapacitet;
        }
    }
}
