using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachersProjects {
    public partial class FrmTeacherProjects : Form {
        private ProjectReport projectReport = new ProjectReport();
        public FrmTeacherProjects() {
            InitializeComponent();
            LoadCombo();
        }

        private void LoadCombo() {
            cbTeachers.Items.Add("Ivo Ivic");
            cbTeachers.Items.Add("Pero Peric");
        }

        private void button1_Click(object sender, EventArgs e) {
            var selected = cbTeachers.SelectedItem as String;
            txtReports.Text = projectReport.GenerateReport(selected);
        }
    }
}
