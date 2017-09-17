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
            ViewBag.SeriesTitle = "The Amazing Spider-Main";
            ViewBag.ReleaseDate = "December, 20, 2012";
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Actors = new string[]
                {
                    "Script: Dan Slott",
                    "Pencils: Humberto Ramos",
                    "Inks: Victor Olazaba",
                    "Colors: Edgar Delgado",
                    "Letters: Chris Eliopoulos"
                };

            return View();
            
        }
    }
}