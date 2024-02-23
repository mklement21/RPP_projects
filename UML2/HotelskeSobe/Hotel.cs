using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskeSobe {
    public class Hotel {
        public List<HotelskaSoba> HotelskeSobe = new List<HotelskaSoba> {
            new HotelskaSoba(501, 3),
            new HotelskaSoba(502, 2),
            new HotelskaSoba (503, 5),
            new HotelskaSoba(504, 2),
        };

        public List<HotelskaSoba> DohvatiSveSobe() {
            return HotelskeSobe.ToList();
        }
    }
}
