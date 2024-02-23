using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1tj {
    public class User {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Opcija { get; set; }

        public User(string username, string password, string firstName, string lastName, string opcija) {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Opcija = opcija;
        }
    }
}
