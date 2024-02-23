using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogometniSusret {
    public class KontrolaSusreta {
        private Repozitorij repozitorij = new Repozitorij();
        
        public Susret EvidentirajSusret (string OznakaDomacin, string OznakaGost, string Rezultat) {
            var nazivDomacin = repozitorij.DohvatiReprezentaciju(OznakaDomacin);
            var nazivGost = repozitorij.DohvatiReprezentaciju(OznakaGost);

            var rezultat = Rezultat.Split(':');
            var noDomacin = rezultat[0];
            var noGost = rezultat[1];

            Susret newSusret = new Susret();
            newSusret.Domacin = nazivDomacin;
            newSusret.Gost = nazivGost;
            newSusret.BrojPogodakaDomacin = int.Parse(noDomacin);
            newSusret.BrojPogodakaGost = int.Parse(noGost);
            return newSusret;
        }
    }
}
