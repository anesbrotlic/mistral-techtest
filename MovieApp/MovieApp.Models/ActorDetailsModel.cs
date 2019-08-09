using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Models
{
    public class ActorDetailsModel
    {
        public string Name { get; set; }
        public string ProfileImgPath { get; set; }

        public List<MovieModel2> MoviesOfActor { get; set; }
    }

    public class MovieModel2
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
    }
}
