using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noteHub
{
    internal class User
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string name, string username, string password)
        {
            this.Name = name;
            this.Username = username;
            this.Password = password;
        }

    }
}
