using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBook.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public Artist[] Artists { get; set; }     
        public string DisplayText
        {
            get
            {
                return Title + " #" + IssueNumber;
            }
            //set   //Contoh doang
            //{
            //    DisplayText = blablabla;
            //}
        }

        public string CoverImageFileName
        {
            get
            {
                return Title.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }
}