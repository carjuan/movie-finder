using Microsoft.AspNetCore.Mvc;
using MovieFinder.Models;
using MovieFinder.Services;

namespace MovieFinder.Controllers
{
    public class SearchMovie : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Movie> model = new MovieService().GetAllMockMovies();

            return View(model);
        }
    }
}
