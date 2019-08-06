using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using MovieApp.Entities.Entities;
using MovieApp.Helpers;
using Newtonsoft.Json;

namespace MovieApp.Database
{
    public class MovieDBContext: DbContext
    {
        public MovieDBContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<MovieRatings> MovieRatings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // movieActor composite key configuration
            modelBuilder.Entity<MovieActor>().HasKey(ma => new { ma.ActorId, ma.MovieId });


            // adding user username:user pass:user
            var user = new User();
            user.Username = "user";
            var salt=PasswordHashingHelper.GenerateSalt();
            user.PasswordSalt = salt;
            user.PasswordHash = PasswordHashingHelper.HashPassword(salt, "user");

            modelBuilder.Entity<User>().HasData(user);

            //maknuti ovo u helper
            using (StreamReader r=new StreamReader("..\\Database\\Actors.json"))
            {
                string json = r.ReadToEnd();
                var list = JsonConvert.DeserializeObject<List<Actor>>(json);
            }






        }
    }
}
