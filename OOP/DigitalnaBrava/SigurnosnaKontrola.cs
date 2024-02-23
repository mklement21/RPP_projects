using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalnaBrava {
    public class SigurnosnaKontrola {
        private Repozitorij repozitorij = new Repozitorij();
        public bool OtvoriVrata (int brKartice, int pin, int brVrata) {
            var korisnik = repozitorij.DohvatiKorisnika(brKartice, pin);
            var vrata = repozitorij.DohvatiVrata(brVrata);
            return ImaPrava(korisnik, vrata);
        }

        private bool ImaPrava(Korisnik korisnik, Vrata vrata) {
            return korisnik?.RazinaPrava >= vrata.RazinaPrava;
        }
    }
}
