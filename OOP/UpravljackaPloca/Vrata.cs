using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravljackaPloca {
    public class Vrata : IOtvor {
        public string Oznaka { get;  set; }
        public StatusOtvora Status { get; set; }

        public bool Zakljucano { get; set; }

        public Vrata(string oznaka, bool zakljucano)
        {
            Zakljucano = zakljucano;
            Oznaka = oznaka;
        }

        public void Otvori() {
            Status = StatusOtvora.Otvoreno;
        }

        public void Zatvori() {
            Status = StatusOtvora.Zatvoreno;
        }
    }
}
