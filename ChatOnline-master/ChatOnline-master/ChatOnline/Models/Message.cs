using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ChatOnline.Models
{
    public class Message
    {
        public Guid MessageId { get; set; }
        public Guid OwnerId { get; set; }
        public string MessageText { get; set; }
        public DateTime SendTime { get; set; }

        public Message(Guid _MessageId, Guid _OwnerId, string _MessageText)
        {
            MessageId = _MessageId;
            OwnerId = _OwnerId;
            MessageText = _MessageText;
            SendTime = DateTime.Now; 
        }



    }
}
