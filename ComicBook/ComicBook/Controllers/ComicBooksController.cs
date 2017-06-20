using ComicBook.Data;
using ComicBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBook.Controllers
{
    public class ComicBooksController : Controller //gunanya untuk menerima, memproses dan menampilkan data
    {
        private ComicBookRepository _comicBookRepository = new ComicBookRepository();

        public ActionResult Detail(int? id) //Harus public karena diakses di semua class, di kasih tanda tanya biar bisa ngakses null
        {
            if (id == null)
                return HttpNotFound();

            var selectedComicBook = _comicBookRepository.getComicBook((int)id);
            return View(selectedComicBook);

            /*
             * Dipindahin ke Repository
             */ 
            //var comicBook = new Models.ComicBook()
            //{
            //    Title = "The Amazing Spider-Man",
            //    IssueNumber = 700,
            //    Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, " +
            //    "great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
            //    Artists = new Artist[]
            //    {
            //        new Artist {Name = "Dan Slott", Role = "Script"},
            //        new Artist {Name = "Humberto Ramos", Role = "Pencils"},
            //        new Artist {Name = "Victor Olazaba", Role = "Inks"},
            //        new Artist {Name = "Edgar Delgado", Role = "Colors"},
            //        new Artist {Name = "Chris Eliopoulos", Role = "Letters"}
            //    }
            //};
            //return View(comicBook);

            /*
             * AWALNYA GINI, Pake ViewBag untuk convert ke html nantinya
             * DIGANTI sama yang ATAS
             */
            //ViewBag.Title = "The Amazing Spider-Man";
            //ViewBag.issueNumber = 700;
            //ViewBag.description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            //ViewBag.artists = new string[]
            //{
            //    "Script: Dan Slott",
            //    "Pencils: Humberto Ramos",
            //    "Inks: Victor Olazaba",
            //    "Colors: Edgar Delgado",
            //    "Letters: Chris Eliopoulos"
            //}; 
            //return View(); //yang dipanggil Detail.cshtml
        }

        public ActionResult Index()
        {
            var allComicBook = _comicBookRepository.getAllComicBook();
            return View(allComicBook);
        }
    }
}