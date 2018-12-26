using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatOnline.Models
{
    public class User
    {
        Guid Id;
        string Username;
        string Password;
        //cos picture

            
         public User (Guid _Id, string _Username, string _Password)
        {
            Id = _Id;
            Username = _Username;
            Password = _Password;
        }

    }
}
