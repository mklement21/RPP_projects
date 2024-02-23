using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravljackaPloca {
    internal class ElektronickiUpravljac {
        public List<IOtvor> Otvori;

        public ElektronickiUpravljac()
        {
            Otvori = new List<IOtvor> {
                new Prozor("Prozor 1 JZ"),
                new Prozor("Prozor 2 JZ"),
                new Prozor("Prozor 3 JZ"),
                new Vrata("Balkonska vrata", false),
                new Vrata("Ulazna", true),
            };
        }

        public void OtvoriOtvor(string oznaka) {
            var selected = Otvori.FirstOrDefault( o=> o.Oznaka == oznaka);
            selected.Otvori();
        }
        public void ZatvoriOtvor(string oznaka) {
            var selected = Otvori.FirstOrDefault(o => o.Oznaka == oznaka);
            selected.Zatvori();
        }

        public void OtvoriSve() {
            foreach (var otvor in Otvori) {
                otvor.Otvori();
            }
        }

        public void ZatvoriSve() {
            foreach (var otvor in Otvori) {
                otvor.Zatvori();
            }
        }
    }
}
