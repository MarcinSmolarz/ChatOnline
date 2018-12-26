using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatOnline.Models
{
    public class Room
    {
        Guid RoomId;
        string RoomName;
        List <User> UsersList;
        List<Message> MessagesList;

        public Room (Guid _RoomId, string _RoomName)
        {
            RoomId = _RoomId;
            RoomName = _RoomName;
        }

    }
}
