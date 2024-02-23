using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1tj {
    public class Repository {
        private List<User> UserList = new List<User> {
            new User("pero", "123", "Pero", "Peric", "Guest")
        };

        public void Provjeri(string username, string password) {
            var currentUser = UserList.FirstOrDefault(u => u.Username == username);
            if (currentUser == null) {
                MessageBox.Show("Potrebno se registrirati");
            } else if (currentUser.Password == password) {
                    MessageBox.Show("Uspješno");
            } else {
                MessageBox.Show("Pogrešni podatci");
            }
        }

        internal void Dodaj(string username, string password, string first, string last, RadioButton opcija) {
            UserList.Add(new User(username, password, first, last, opcija.ToString()));
        }
    }
}
