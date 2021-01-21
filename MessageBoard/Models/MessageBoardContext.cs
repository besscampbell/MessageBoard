using Microsoft.EntityFrameworkCore;
using System;

namespace MessageBoard.Models
{
  public class MessageBoardContext : DbContext
  {
    public MessageBoardContext(DbContextOptions<MessageBoardContext> options)
      : base(options)
    {
    }

    public DbSet<Message> Messages { get; set; }
    public DbSet<Group> Groups {get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Group>()
        .HasData(
          new Group { GroupId = 1, GroupName = "Baby Animals"},
          new Group { GroupId = 2, GroupName = "Secret Missions"},
          new Group { GroupId = 3, GroupName = "Phobias"}
        );
      builder.Entity<Message>()
        .HasData(
          new Message { MessageId = 1, GroupId = 1, MessageDate = DateTime.Now, MessagePost = "Kittens are my favorite baby animal", MessageAuthor = "Jessie Finks"},
          new Message { MessageId = 2, GroupId = 1, MessageDate = DateTime.Now, MessagePost = "Puppies are my favorite baby animal", MessageAuthor = "Arthur Aadvark"},
          new Message { MessageId = 3, GroupId = 3, MessageDate = DateTime.Now, MessagePost = "I'm afraid of feet", MessageAuthor = "Not-a-podiatrist" },
          new Message { MessageId = 4, GroupId = 2 , MessageDate = DateTime.Now, MessagePost = "When the minute hand strikes a tadpole's tail past the high-noon hour, meet me at the phantom clocktower behind O'Henry's for your secret mission", MessageAuthor = "Agent Anonymous"},
          new Message { MessageId = 5, GroupId = 3, MessageDate = DateTime.Now, MessagePost = "Balloons are scary", MessageAuthor = "FearOfClowns"}
        );
    }
  }
}