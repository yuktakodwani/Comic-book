using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comic_books_gallery.Controllers
{
    public class ComicBookscontroller : Controller
    {

        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "  The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p> Final issue! Witness the final hour </ p >";
            ViewBag.Artists = new string[]
            {
                "Script: dan scott",
            "Pencils: humberto ramos ",
            "Inks: victor olazaba",
            "Colors: edger delgado",
            "Letters: chris eliopoulos"
            };

            return View();

        }
    }
}