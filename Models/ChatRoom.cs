using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer.Models
{
    public class ChatRoom
    {
        public long Id { get; set; }
        public string RoomName { get; set; }
        public List<User> Users { get; set; }
    }
}
