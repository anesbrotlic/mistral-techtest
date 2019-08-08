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
        public DateTime ReleaseDate { get; set; }
        public bool TVShow { get; set; }

        public List<ActorModel> Actors { get; set; }
        public float AvgRate { get; set; }

        public int RateByUser { get; set; }

    }

    public class ActorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProfileImgPath { get; set; }

    }
}
