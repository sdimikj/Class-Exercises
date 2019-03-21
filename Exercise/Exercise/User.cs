using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public User()
        {

        }
        public User (string username, string password, Role role)
        {
            UserName = username;
            Password = password;
            Role = role;
        }



    }
}
