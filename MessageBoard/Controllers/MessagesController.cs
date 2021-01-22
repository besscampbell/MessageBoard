using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoard.Models;

namespace MessageBoard.Controllers
{
  [ApiController]
  [ApiVersion("1.0")]
  [Route("api/1/messages")]
  public class MessagesV1Controller : ControllerBase
  {
    private MessageBoardContext _db;
    public MessagesV1Controller(MessageBoardContext db)
    {
      _db = db;
    }

    // GET api/messages
    [HttpGet]
    public ActionResult<IEnumerable<Message>> Get(string post, string author)
    {
      var query = from q in _db.Messages select q;
      if (post != null)
      {
        query = query.Where(entry => entry.MessagePost.Contains(post));
      }
      if (author != null)
      {
        query = query.Where(entry => entry.MessageAuthor.Contains(author));
      }
      return query.ToList();
    }

    //POST api/messages
    [HttpPost]
    public void Post([FromBody] Message message)
    {

      _db.Messages.Add(message);
      _db.SaveChanges();
    }

    // GET api/messages/1
    [HttpGet("{id}")]
    public ActionResult<Message> Get(int id)
    {
      var message = _db.Messages.FirstOrDefault(entry => entry.MessageId == id);
      return message;
    }

    //PUT api/messages/1
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Message message)
    {
      message.MessageId = id;
      _db.Entry(message).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/messages/1
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var messageToDelete = _db.Messages.FirstOrDefault(entry => entry.MessageId == id);
      _db.Messages.Remove(messageToDelete);
      _db.SaveChanges();
    }
  }

  [ApiController]
  [ApiVersion("2.0")]
  [Route("api/2/messages")]
  
  public class MessagesV2Controller : ControllerBase
  {
    private MessageBoardContext _db;
    public MessagesV2Controller(MessageBoardContext db)
    {
      _db = db;
    }

    // GET api/messages
    [HttpGet]
    public ActionResult<IEnumerable<Message>> Get(string post, string author, Group group)
    {
      var query = from q in _db.Messages select q;
      if (post != null)
      {
        query = query.Where(entry => entry.MessagePost.Contains(post));
      }
      if (author != null)
      {
        query = query.Where(entry => entry.MessageAuthor.Contains(author));
      }
      if (group != null)
      {
        query = query.Where(entry => entry.Group.GroupName.Contains(group.GroupName));
      }
      return query.ToList();
    }
  }
}