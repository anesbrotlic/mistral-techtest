using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CoverImgPath { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool TVShow { get; set; }

        public string Actors { get; set; }
        public float AvgRate { get; set; }

        public int RateByUser { get; set; }
    }
}
