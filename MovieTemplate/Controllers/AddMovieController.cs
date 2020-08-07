using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieTemplate.Controllers
{
    public class AddMovieController : Controller
    {
        // GET: AddMovie
        public ActionResult Index()
        {
            // var moviesInput = new List<AddMovieController>();
            //
            // return View(moviesInput);

            return View();
        }

        public ActionResult SetMovieDetails(string movie_name, string director, string producer, string cast, string genre, string duration)  {

            Models.MovieDets dets = new Models.MovieDets();
            dets.movie_name = movie_name;
            dets.director = director;
            dets.producer = producer;
            dets.cast = cast;
            dets.genre = genre;
            dets.duration = duration;

            return View(dets);
        }

     
    }

}