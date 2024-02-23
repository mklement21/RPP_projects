using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelskeSobe {
    public partial class FrmHotelskeSobe : Form {
        public Recepcija recepcija = new Recepcija();
        public Rezervacija rezervacija = new Rezervacija();
        public FrmHotelskeSobe() {
            InitializeComponent();
        }

        private void btnPrikaziSlobodne_Click(object sender, EventArgs e) {
            var datum = dateTimePicker1.Value;
            DohvatiSlobodneSobe();
        }

        private void DohvatiSlobodneSobe() {
            List<HotelskaSoba> sveSobe = recepcija.DohvatiSlobodneSobe();
            dgvSlobodneSobe.DataSource = sveSobe.ToList();
        }

        private void Rezervirajj(HotelskaSoba selectedSoba, DateTime datum) {
            recepcija.Rezerviraj(selectedSoba, datum);
            DohvatiSlobodneSobe(); 
        }

        private void btnRezerviraj_Click(object sender, EventArgs e) {
            var datum = dateTimePicker1.Value;
            var selectedSoba = dgvSlobodneSobe.CurrentRow.DataBoundItem as HotelskaSoba;
            Rezervirajj(selectedSoba, datum);
        }
    }
}
