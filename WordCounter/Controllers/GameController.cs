using Microsoft.AspNetCore.Mvc;
using WordCount.Models;
using System.Collections.Generic;

namespace WordCount.Controllers
{
  public class GameController : Controller
  {
    [HttpGet("/games")]
    public ActionResult Index()
    {
      
      return View();
    }

    [HttpGet("/games/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/games")]
    public ActionResult Create(string word, string sentence)
    {
      StringEval myGame = new StringEval(word, sentence);
      myGame.StringCleaner();
      myGame.RepeatCounter();
      return RedirectToAction("Index");
    }

    [HttpPost("/games/delete")]
    public ActionResult DeleteAll()
    {

      return View();
    }

    [HttpGet("/games/{id}")]
     public ActionResult Show(int id)
     {

       return View();
     }

  }
}
