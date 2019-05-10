using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidley2015.Models;
using Vidley2015.ViewModels;

namespace Vidley2015.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek"};
            var customers = new List<Customers>
            {
                new Customers {Name = "Customer 1"},
                new Customers {Name = "Customer 2"}

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
        // supply constraints to attribute routing 
        //min,max,minlength,int,float,guid
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        
        public ActionResult ByReleaseYear(int? year, string month)
        {
            return Content(year + "/" + month);
        }   
    }
}