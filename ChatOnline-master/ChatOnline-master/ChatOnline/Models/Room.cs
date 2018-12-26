using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatOnline.Models
{
    public class Room
    {
        public Guid RoomId { get; set; }
        public string RoomName { get; set;}
        public List <User> UsersList { get; set; }
        public List<Message> MessagesList { get; set; }

        public Room (Guid _RoomId, string _RoomName)
        {
            RoomId = _RoomId;
            RoomName = _RoomName;
            UsersList = new List<User>();
            MessagesList = new List<Message>();
        }

        //metoda add to messages list i users list i remove

        public void RemoveUser(User _User)
        {
            UsersList.Remove(_User);
        }
    }
}
