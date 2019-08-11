using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Entities.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CoverImgPath { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool TVShow { get; set; }

        public virtual ICollection<MovieActor> MovieActors { get; set; }
        public virtual ICollection<MovieRatings> MovieRatings { get; set; }

    }
}
