using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoard.Models;

namespace MessageBoard.Controllers
{
  [ApiController]
  [ApiVersion("2.0")]
  [Route("api/2/groups")]

  public class GroupsV2Controller : ControllerBase
  {
    private MessageBoardContext _db;
    
    public GroupsV2Controller(MessageBoardContext db)
    {
      _db = db;
    }

    // GET api/2/groups?name=Agent+anonymous
    [HttpGet]
    public ActionResult<IEnumerable<Group>> Get(string name)
    {
      var query = from n in _db.Groups select n;
      if (name != null)
      {
       query = query.Where(entry => entry.GroupName.Contains(name));
      }

      return query.ToList();
    }



  }
}