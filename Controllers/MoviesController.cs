using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;


namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Index()
        {
            var movie = GetMovies();

            return View(movie);
        }
        private List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Name = "Shrek"},
                new Movie {Name = "Wall-e"}
            };
        }
    }
}