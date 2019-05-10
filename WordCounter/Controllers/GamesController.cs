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

        [HttpGet("/games/{id}")]
        public ActionResult Show(int id)
        {
            StringEval stringEval = StringEval.Find(id);
            return View(stringEval);
        }

        [HttpPost("/games")]
        public ActionResult Create(string word, string sentence)
        {
            StringEval stringEval =  new StringEval(word, sentence);
            stringEval.StringCleaner();
            return View("Show", stringEval);
        }

        [HttpPost("/games/delete")]
        public ActionResult ClearAll()
        {
            StringEval.ClearAll();
            return View();
        }
    }
}
