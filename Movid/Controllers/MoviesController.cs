using Movid.Models;
using Movid.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movid.Controllers
{
    public class MoviesController : Controller
    {
        //movies
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = GetMovies().ToList().SingleOrDefault(m => m.Id == id) ;

            return View(movie);
        }

        private List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{Id = 1, Name = "Shrek" },
                new Movie{Id = 2, Name = "The Terminator" },
                new Movie{Id = 3, Name = "Gladiator" },
                new Movie{Id = 4, Name = "Mission Impossible" },
                new Movie{Id = 5, Name = "Face Off" }

            };
            
        }


        // GET: Movies/Random
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Shrek" };

            var customers = new List<Customer>
            {
                new Customer{Name = "Arthur" },
                new Customer{Name = "Emilie" },
                new Customer{Name = "Serge" },
                new Customer{Name = "Mario" }

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }


        /*movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("PageIndex = {0} and SortBy = {1}", pageIndex, sortBy));

        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        */

    }
}