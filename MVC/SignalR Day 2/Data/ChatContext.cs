using Microsoft.EntityFrameworkCore;
using SignalR_Day_2.Entity;

namespace SignalR_Day_2.Data
{
    public class ChatContext : DbContext
    {
        public ChatContext(DbContextOptions<ChatContext> options) : base(options)
        {

        }

       public virtual DbSet<ChatMessage> ChatMessages { get; set; } 
    }
}
