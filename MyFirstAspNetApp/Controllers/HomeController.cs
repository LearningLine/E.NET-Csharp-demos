using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MyFirstAspNetApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hello()
        {
            return Content("Hello, how are you?");
        }

        public ActionResult Foo()
        {
            return View();
        }

        public async Task<ActionResult> Movies()
        {
            var context = new MoviesEntities();
            List<Movie> movies = (await context.Movies.ToListAsync());
            ViewBag.Studios = await context.Studios.ToListAsync();
            return View(movies);
        }

        public async Task<ViewResult> Movie(int id)
        {
            var context = new MoviesEntities();
            var movie = await context.Movies.FirstAsync(m => m.Id == id);

            return View(movie);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}