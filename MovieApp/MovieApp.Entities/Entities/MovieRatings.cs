using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Entities.Entities
{
    public class MovieRatings
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        public int Rating { get; set; }
    }
}
