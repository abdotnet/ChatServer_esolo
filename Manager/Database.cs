using ChatServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer.Manager
{
    public class Database
    {
        public DbSet<ChatRoom> ChatRoom { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
