using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConverter {
    public class Currency {
        public string Name { get; set; }
        public double Value { get; set; }
        public Currency(string name, double value) {
            Name = name;
            Value = value;
        }
    }
}
