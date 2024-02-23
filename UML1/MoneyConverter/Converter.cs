using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConverter {
    public class Converter {
        public double ConverterCurrency(double first, double second, double value) {
            return value * first / second;
        }
    }
}
