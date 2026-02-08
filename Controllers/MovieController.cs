using Microsoft.AspNetCore.Mvc;
using HW3.Models;

namespace HW3.Controllers
{
    public class MovieController : Controller
    {
        MovieContext db;
        public MovieController(MovieContext context)
        { 
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Movie> movies = await Task.Run(() => db.Movies);
            return View(movies);
        }
    }
}