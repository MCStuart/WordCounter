using Microsoft.AspNetCore.Mvc;
using WordCount.Models;
using System.Collections.Generic;

namespace WordCount.Controllers
{
  public class GamesController : Controller
  {
    [HttpGet("/games")]
    public ActionResult Index()
    {
      StringEval allGame = new StringEval(word, sentence);
      return View(allGames);
    }

    [HttpGet("/games/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/games/show")]
    public ActionResult Show()
    {
      return View();
    }

    [HttpPost("/games")]
    public ActionResult Create(string word, string sentence)
    {
      StringEval stringEval =  new StringEval(word, sentence);
      return View("Show", stringEval);
    }

    [HttpPost("/games")]
    public ActionResult DeleteAll()
    {
      StringEval.ClearAll();
      return View();
    }
  }
}
