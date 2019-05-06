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
          List<StringEval> allGames = StringEval.GetAll();
          return View(allGames);
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
            return View("Show", myGame);
        }

        [HttpGet("/games/show")]
        public ActionResult Show()
        {
            return View();
        }

    }
}
