using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyConverter {
    public partial class Form1 : Form {
        private CurrencyFactory currencyFactory = new CurrencyFactory();
        private Converter currency = new Converter();

        public Form1() {
            InitializeComponent();
            LoadCurrency();
        }

        private void LoadCurrency() {
            foreach(Currency currency in currencyFactory.CurrencyList) {
                var name = currency.Name;
                cmbFirstCurrency.Items.Add(name);
                cmbSecondCurrency.Items.Add(name);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e) {
            //load selected
            var first = cmbFirstCurrency.SelectedItem;
            var second = cmbSecondCurrency.SelectedItem;
            var value = double.Parse(textBox1.Text);

            //find value of combos
            var firstCurr = currencyFactory.CurrencyList.FirstOrDefault(c => c.Name == first.ToString()).Value;
            var secondCurr = currencyFactory.CurrencyList.FirstOrDefault(c => c.Name == second.ToString()).Value;
            double converted = currency.ConverterCurrency(firstCurr, secondCurr, value);
            textBox2.Text = converted.ToString();
        }
    }
}
