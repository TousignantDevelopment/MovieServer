using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieServer.Models
{
    public class MovieServer
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public int MovieRating { get; set; }
        public string DescriptionHtml { get; set; }
        public Actors[] Actors { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            get
            {
                return MovieTitle + " - " + MovieRating;
            }
        }
        public string CoverImageFileName
        {
            get
            {
                return MovieTitle.Replace(" ", "-").ToLower() +
                       "-" + MovieRating + ".jpg";
            }
        }
    }
}