using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConverter {
    public class CurrencyFactory {
        public List<Currency> CurrencyList { get; set; }
        public CurrencyFactory(){
            CurrencyList = new List<Currency> {
                new Currency("HRK", 1),
                new Currency("EUR", 7.4),
                new Currency("USD", 6.5),
                new Currency("GPB", 8.5),
                new Currency("CAD", 4.9),
            };
        }
    }
}
