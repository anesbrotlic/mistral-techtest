using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Models
{
    public class MovieRequestModel
    {
        public int Page { get; set; }
        public bool TvShow { get; set; }
        public SearchModel SearchObject { get; set; }
    }
}
