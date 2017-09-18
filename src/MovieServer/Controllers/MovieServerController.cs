using MovieServer.Data;
using MovieServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieServer.Controllers
{
    public class MovieServerController : Controller
    {
        private MovieRepository _movieRepository = null;

        public MovieServerController()
        {
            _movieRepository = new MovieRepository();
        }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }

            var movieDetails = _movieRepository.GetMovie((int)id);

            return View(movieDetails);
            
        }
    }
}