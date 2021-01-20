using Microsoft.AspNetCore.Mvc;
using ClientMessageBoard.Models;


namespace ClientMessageBoard.Controllers
{
  public class MessagesController : Controller
  {
    public IActionResult Index()
    {
      var allMessages = Message.GetMessages();
      return View(allMessages);
    }
  }
}