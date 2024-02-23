using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalnaBrava {
    public class Repozitorij {
        public List<Korisnik> ListKorisnik = new List<Korisnik> {
            new Korisnik {BrojKartice = 10001, PIN = 1234, RazinaPrava=1},
            new Korisnik {BrojKartice = 10002, PIN = 0000, RazinaPrava=2},
            new Korisnik {BrojKartice = 10003, PIN = 9999, RazinaPrava=2},
        };

        public List<Vrata> ListVrata = new List<Vrata> {
            new Vrata {BrojVrata =501, RazinaPrava=1},
            new Vrata {BrojVrata =502, RazinaPrava=2},
            new Vrata {BrojVrata =503, RazinaPrava=2},
        };

        public Korisnik DohvatiKorisnika (int brKartice, int pin) {
            var korisnik = ListKorisnik.FirstOrDefault(k => k.BrojKartice == brKartice && k.PIN == pin);
            return korisnik;
        }

        public Vrata DohvatiVrata (int brVrata) {
            var vrata = ListVrata.FirstOrDefault( v=>v.BrojVrata == brVrata);
            return vrata;
        }
    }
}
