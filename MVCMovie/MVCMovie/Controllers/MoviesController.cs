using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCMovie.Entities;
using MVCMovie.Models;

namespace MVCMovie.Controllers
{
    public class MoviesController : Controller
    {

        private MovieContext db;

        public MoviesController(MovieContext context)
        {
            db = context;
        }



        public IActionResult Index()
        {
            return View(GetMovieItems());
        }



        private ICollection<MovieItemVM> GetMovieItems()
        {
            return db.Movie
                .Select(m => new Models.MovieItemVM
                {
                    Id = m.MovieId,
                    Title = m.Title,
                    Description = m.Description,
                    Year = m.Year,
                    Rating = m.Stars,
                    Director = $"{m.Director.LastName} {m.Director.FirstName}",
                    Actors = m.MovieActor.Select(ma => new MovieActorVM
                    {
                        Name = $"{ma.Actor.FirstName} {ma.Actor.LastName}"
                    }).ToList()
                }).ToList();
        }

    }
}