using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Entities.Entities;

namespace MovieApp.Models
{
    public class MovieDetailModel
    {
        public string Title { get; set; }
        public string CoverImgPath { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public bool TVShow { get; set; }

        public List<ActorModel> Actors { get; set; }
        public float AvgRating { get; set; }

        public int RatingByUser { get; set; }

    }

}
