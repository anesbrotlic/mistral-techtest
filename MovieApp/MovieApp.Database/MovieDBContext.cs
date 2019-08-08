using Microsoft.EntityFrameworkCore;
using MovieApp.Entities.Entities;

namespace MovieApp.Database
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<MovieRatings> MovieRatings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // movieActor composite key configuration
            modelBuilder.Entity<MovieActor>().HasKey(ma => new { ma.ActorId, ma.MovieId });

            // movieRating composite key configuration
            modelBuilder.Entity<MovieRatings>().HasKey(mr => new { mr.MovieId, mr.UserId });

        }
    }
}
