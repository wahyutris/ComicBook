using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBook.Data
{
    public class ComicBookRepository
    {
        public Models.ComicBook getComicBook()
        {
            return null;
        }

        private static Models.ComicBook[] _comicBooks = new Models.ComicBook[]
        {
            new Models.ComicBook()
            {
                Id = 0,
                Title = "The Amazing Spider-Man",
                IssueNumber = 700,
                Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, " +
                "great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
                Artists = new Models.Artist[]
                {
                    new Models.Artist() { Name = "Dan Slott", Role = "Script" },
                    new Models.Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Models.Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Models.Artist() { Name = "Edgar Delgado", Role = "Colors" },
                    new Models.Artist() { Name = "Chris Eliopoulos", Role = "Letters" },
                },
            },
            new Models.ComicBook()
            {
                Id = 1,
                Title = "The Amazing Spider-Man",
                IssueNumber = 657,
                Description = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private " +
                "wake--just for family.</p>",
                Artists = new Models.Artist[]
                {
                    new Models.Artist() { Name = "Dan Slott", Role = "Script" },
                    new Models.Artist() { Name = "Marcos Martin", Role = "Pencils" },
                    new Models.Artist() { Name = "Marcos Martin", Role = "Inks" },
                    new Models.Artist() { Name = "Muntsa Vicente", Role = "Colors" },
                    new Models.Artist() { Name = "Joe Caramagna", Role = "Letters" }
                },
            },
            new Models.ComicBook()
            {
                Id = 2,
                Title = "Bone",
                IssueNumber = 50,
                Description = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord " +
                "Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, " +
                "a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Models.Artist[]
                {
                    new Models.Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Models.Artist() { Name = "Jeff Smith", Role = "Pencils" },
                    new Models.Artist() { Name = "Jeff Smith", Role = "Inks" },
                    new Models.Artist() { Name = "Jeff Smith", Role = "Letters" }
                },                
            }
        };

        public Models.ComicBook getComicBook (int id)
        {
            Models.ComicBook comicBookClicked = new Models.ComicBook();

            foreach(var comic in _comicBooks)
            {
                if(comic.Id == id)
                {
                    comicBookClicked = comic;
                }
            }
            return comicBookClicked;
        }

        public Models.ComicBook[] getAllComicBook()
        {
            return _comicBooks;
        }
    }
}