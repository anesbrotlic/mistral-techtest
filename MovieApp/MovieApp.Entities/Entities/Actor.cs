using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Entities.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProfileImgPath { get; set; }

        public ICollection<MovieActor> MovieActors { get; set; }
    }
}
