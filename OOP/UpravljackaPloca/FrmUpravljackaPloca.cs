using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljackaPloca {
    public partial class FrmUpravljackaPloca : Form {
        private ElektronickiUpravljac elUpravljac = new ElektronickiUpravljac();
        public FrmUpravljackaPloca() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            var sve = elUpravljac.Otvori;
            dataGridView1.DataSource = sve.ToList();
        }

        private void btnOtvoriSve_Click(object sender, EventArgs e) {
            elUpravljac.OtvoriSve();
            RefreshGui();
        }

        private void btnZatvoriSve_Click(object sender, EventArgs e) {
            elUpravljac.ZatvoriSve();
            RefreshGui();
        }

        private void RefreshGui() {
            this.Update();
            this.Refresh();
        }

        private void btnOtvori_Click(object sender, EventArgs e) {
            var selected = dataGridView1.CurrentRow.DataBoundItem as IOtvor;
            elUpravljac.OtvoriOtvor(selected.Oznaka);
            RefreshGui();
        }

        private void btnZatvori_Click(object sender, EventArgs e) {
            var selected = dataGridView1.CurrentRow.DataBoundItem as IOtvor;
            elUpravljac.ZatvoriOtvor(selected.Oznaka);
            RefreshGui();
        }
    }
}
