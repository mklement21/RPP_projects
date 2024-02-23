using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1tj {
    public partial class LogIn : Form {
        private Repository repository = new Repository();
        
        public LogIn() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text)) {
               MessageBox.Show("Unesite sve podatke.");
            } else {
                repository.Provjeri(username, password);
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e) {
            Registration frmReg = new Registration();
            this.Hide();
            frmReg.Show();
        }
    }
}
