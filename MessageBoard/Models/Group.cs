using System.Collections.Generic;
using System;

namespace MessageBoard.Models
{
  public class Group
  {
    public Group()
    {
      this.Messages = new HashSet<Message>();
    }

    public int GroupId { get; set;}
    public string GroupName { get; set; }
    public ICollection<Message> Messages { get; set; }
  }
}

