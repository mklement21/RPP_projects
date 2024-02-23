using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalnaBrava {
    public partial class FrmDigitalnaBrava : Form {
        private SigurnosnaKontrola sigurnosnaKontrola = new SigurnosnaKontrola();
        public FrmDigitalnaBrava() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var brKartice = txtBrKartice.Text;
            var pin = txtPIN.Text;
            var vrata = 501;

            var stanje = sigurnosnaKontrola.OtvoriVrata(int.Parse(brKartice), int.Parse(pin), vrata);

            Provjeri(stanje);
        }

        private void Provjeri(bool stanje) {
            if (stanje == true) {
                MessageBox.Show("Vrat otvorena");
            } else {
                MessageBox.Show("NE");
            }
        }

        private void btnVrata502_Click(object sender, EventArgs e) {
            var brKartice = txtBrKartice.Text;
            var pin = txtPIN.Text;
            var vrata = 502;

            var stanje = sigurnosnaKontrola.OtvoriVrata(int.Parse(brKartice), int.Parse(pin), vrata);

            Provjeri(stanje);
        }

        private void btnVrata503_Click(object sender, EventArgs e) {
            var brKartice = txtBrKartice.Text;
            var pin = txtPIN.Text;
            var vrata = 503;

            var stanje = sigurnosnaKontrola.OtvoriVrata(int.Parse(brKartice), int.Parse(pin), vrata);

            Provjeri(stanje);
        }
    }
}
