using Microsoft.AspNetCore.Mvc;

namespace WordCount.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
