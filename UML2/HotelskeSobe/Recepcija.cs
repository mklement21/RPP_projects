using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskeSobe {
    public class Recepcija {
        private Hotel hotel = new Hotel();
        public List<Rezervacija> ListRezervacija = new List<Rezervacija>();
        public List<HotelskaSoba> sveSobe;

        public List<HotelskaSoba> DohvatiSlobodneSobe() {
            sveSobe = hotel.DohvatiSveSobe();
            var rezervacije = ListRezervacija;

            foreach (var soba in rezervacije) {
                var rezerviranaSoba = sveSobe.FirstOrDefault(s => s.OznakaSobe == soba.Soba.OznakaSobe);
                sveSobe.Remove(rezerviranaSoba);
            }
            return sveSobe;
        }

        public void Rezerviraj(HotelskaSoba soba, DateTime datum){
            Rezervacija novaRezervacija = new Rezervacija {
                Soba = soba, 
                Datum = datum 
            };
            ListRezervacija.Add(novaRezervacija);
        }
    }
}
