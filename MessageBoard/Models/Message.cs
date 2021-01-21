using System;

namespace MessageBoard.Models
{
    public class Message
    {
      public int MessageId { get; set; }
      public DateTime MessageDate { get; set; }
      public string MessagePost { get; set;}
      public string MessageAuthor { get; set;}
      public int GroupId { get; set; }
      public Group Group { get; set;}
    }
}
