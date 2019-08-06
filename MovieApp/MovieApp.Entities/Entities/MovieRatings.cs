using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Entities.Entities
{
    public class MovieRatings
    {
        public int Id { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int Rating { get; set; }
    }
}
