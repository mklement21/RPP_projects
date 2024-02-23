using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogometniSusret {
    public class Repozitorij {
        public Reprezerntacija[] reprezentacija = new Reprezerntacija[] {
            new Reprezerntacija{Naziv = "Hrvatska", Oznaka = "HRV" },
            new Reprezerntacija{Naziv = "Njemačka", Oznaka = "GER" },
            new Reprezerntacija{Naziv = "Francuska", Oznaka = "FRA" },
        };

        public Reprezerntacija DohvatiReprezentaciju(string oznaka) {
            var repka = reprezentacija;
            var trazenaRepka = repka.FirstOrDefault(r => r.Oznaka == oznaka);
            return trazenaRepka;
        }
    }
}
