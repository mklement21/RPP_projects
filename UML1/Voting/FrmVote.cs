using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting {
    public partial class FrmVote : Form {

        private List<User> UserList = new List<User>();
        private int votesFor = 0;
        private int votesAgainst = 0;
        private int votesAbstained = 0;
        
        public FrmVote() {
            InitializeComponent();
            LoadVotes();
            LoadOptions();
        }
        private void LoadVotes() {
            lblFor.Text = votesFor.ToString();
            lblAgainst.Text = votesAgainst.ToString();
            lblAbstained.Text = votesAbstained.ToString();
        }

        private void LoadOptions() {
            comboBox1.Items.Add("FOR");
            comboBox1.Items.Add("AGAINST");
            comboBox1.Items.Add("ABSTAINED");
        }

        private void CheckUser() {
            var OIB = int.Parse(txtOIB.Text);
            var user = UserList.FirstOrDefault(u => u.OIB == OIB);

            if (user == null) {
                var option = comboBox1.SelectedItem.ToString();

                if (option == "FOR") {
                    votesFor++;
                    LoadVotes();
                }

                if (option == "AGAINST") {
                    votesAgainst++;
                    LoadVotes();
                }

                if (option == "ABSTAINED") {
                    votesAbstained++;
                    LoadVotes();
                }

                UserList = new List<User> {
                    new User(OIB)
                };
            } else {
                MessageBox.Show("You already voted.");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            CheckUser();
        }
    }
}
