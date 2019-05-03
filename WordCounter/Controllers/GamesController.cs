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
      List<StringEval> userInput = stringEval.GetAll();
      return View(userInput);
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
      stringEval.Word = word;
      stringEval.Sentence = sentence;
      return RedirectToAction("Index");
    }

  }
}
