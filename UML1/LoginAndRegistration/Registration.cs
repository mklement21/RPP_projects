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
    public partial class Registration : Form {
        Repository repository = new Repository();
        private RadioButton selectedOption { get; set; } = null;

        public Registration() {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            foreach (Control control in groupBoxOpcije.Controls) {
                if (control is RadioButton radioButton) {
                    if (radioButton.Checked) {
                        selectedOption = radioButton;
                        break;
                    }
                }
            }

            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var last = txtFirstName.Text;
            var first = txtLastName.Text;
            var opcija = selectedOption;

            repository.Dodaj(username, password, first, last, opcija);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
