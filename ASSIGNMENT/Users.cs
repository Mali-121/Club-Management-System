using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Users
    {
        private string fullname, username, password, role;

        public string Fullname { get => fullname; set => fullname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public Users(string n, string u, string p, string r)
        {
            Fullname = n;
            Username = u;
            Password = p;
            Role = r;
        }
        public Users(string u, string p)
        {
            Username = u;
            Password = p;
        }
    
    }
}
