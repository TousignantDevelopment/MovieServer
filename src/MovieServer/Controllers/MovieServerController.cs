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
        public ActionResult Detail()
        {
            var movieDetails = new Movie() {
                MovieTitle = "The Amazing Spider-Man",
                MovieRating = 45,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Actors = new Actor[]
                {
                    new Actor() { Name = "Dan Slott", Character = "Script" },
                    new Actor() { Name = "Humberto Ramos", Character = "Pencils" },
                    new Actor() { Name = "Victor Olazaba", Character = "Inks" },
                    new Actor() { Name = "Edgar Delgado", Character = "Colors" },
                    new Actor() { Name = "Chris Eliopoulos", Character = "Letters" },


                }
            };

            return View(movieDetails);
            
        }
    }
}