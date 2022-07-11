using Microsoft.AspNetCore.Mvc;

namespace MovieFinder.Controllers
{
    public class SearchMovie : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
