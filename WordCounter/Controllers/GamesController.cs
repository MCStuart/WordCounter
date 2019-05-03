using Microsoft.AspNetCore.Mvc;
using WordCount.Models;
using System.Collections.Generic;

namespace WordCount.Controllers
{
  public class GamesController : Controller
  {
    [HttpGet("/games")]
    public ActionResult Index(string word, string sentence)
    {
      StringEval myGame = new StringEval(word, sentence);
      return View("Index", myGame);
    }

    [HttpGet("/games/new")]
    public ActionResult New()
    {

      return View();
    }

    [HttpPost("/games")]
    public ActionResult StringEval(string word, string sentence)
    {

      StringEval stringEval = new StringEval(word, sentence);
      return RedirectToAction("Index", stringEval);
    }

  }
}
