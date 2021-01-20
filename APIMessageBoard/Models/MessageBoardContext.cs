using Microsoft.EntityFrameworkCore;

namespace APIMessageBoard.Models
{
  public class MessageBoardContext : DbContext
  {
    public MessageBoardContext(DbContextOptions<MessageBoardContext> options)
      : base(options)
    {
    }

    public DbSet<Message> Messages { get; set; }
  }
}