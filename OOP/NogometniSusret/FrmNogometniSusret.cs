using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NogometniSusret {
    public partial class FrmNogometniSusret : Form {
        private KontrolaSusreta kontrolaSusreta = new KontrolaSusreta();
        public FrmNogometniSusret() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var domacin = textBox1.Text;
            var gost = textBox2.Text;
            var rez = textBox3.Text;

            var susret = kontrolaSusreta.EvidentirajSusret(domacin, gost, rez);

            MessageBox.Show(susret.Domacin.Naziv + " " + susret.BrojPogodakaDomacin + " : " + susret.BrojPogodakaGost + " " +  susret.Gost.Naziv);
        }
    }
}
