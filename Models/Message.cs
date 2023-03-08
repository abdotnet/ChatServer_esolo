using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer.Models
{
    public class Message
    {
        public long Id { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string MessageContent { get; set; }
    }
}
