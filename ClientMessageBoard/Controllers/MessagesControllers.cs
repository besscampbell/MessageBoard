using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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

    public IActionResult Details(int id)
    {
      var message = Message.GetDetails(id);
      return View(message);
    }

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(Message message)
    {
      Message.Post(message);
      return RedirectToAction("Index");
    }
  }
}



    // public IActionResult Index()
    // {
    //   var allAnimals = Animal.GetAnimals();
    //   return View(allAnimals);
    // }

    // [HttpPost]
    // public IActionResult Index(Animal animal)
    // {
    //   Animal.Post(animal);
    //   return RedirectToAction("Index");
    // }