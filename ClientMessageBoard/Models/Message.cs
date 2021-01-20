using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClientMessageBoard.Models
{
    public class Message
    {
      public int MessageId { get; set; }
      public DateTime MessageDate { get; set; }
      public string MessagePost { get; set;}
      public string MessageAuthor { get; set;}
      public string Group { get; set;}

      public static List<Message> GetMessages()
      {
        var apiCallTask = ApiHelper.GetAll();
        var result = apiCallTask.Result;

        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);

        List<Message> messageList = JsonConvert.DeserializeObject<List<Message>>(jsonResponse.ToString());

        return messageList;
      }
    }
}