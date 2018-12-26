using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatOnline.Models
{
    public class User
    {
        public Guid Id { get; set;}
        public string Username { get; set; }
        public string Password { get; set; }
        //cos picture


        public User (Guid _Id, string _Username, string _Password)
        {
            Id = _Id;
            Username = _Username;
            Password = _Password;
        }

    }
}
