using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MovieApp.Entities.Entities;
using MovieApp.Helpers;
using Newtonsoft.Json;

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


            var random = new Random();


            #region User DataSeed
            var userList = new List<User>();

            for (int i = 1; i < 10; i++)
            {
                var salt = PasswordHashingHelper.GenerateSalt();
                var usernamePassword = "user" + i;

                userList.Add(new User
                {
                    Id = i,
                    Username = usernamePassword,
                    PasswordSalt = salt,
                    PasswordHash = PasswordHashingHelper.HashPassword(salt, usernamePassword)
                });
            }


            modelBuilder.Entity<User>().HasData(userList);
            #endregion

            #region Movie DataSeed

            var movieList = DBSeedHelper.GetMovies();
            modelBuilder.Entity<Movie>().HasData(movieList);

            #endregion

            #region Actor DataSeed

            var actorList = DBSeedHelper.GetActors();
            modelBuilder.Entity<Actor>().HasData(actorList);

            #endregion

            #region MovieActor DataSeed

            var movieActorList = new List<MovieActor>();
            var allActors = actorList.Count;
            for (int i = 0; i < movieList.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    var movieActorForAdd = new MovieActor
                    {
                        MovieId = movieList[i].Id,
                        ActorId = random.Next(1, allActors)
                    };

                    if (movieActorList.Find(ma => ma.ActorId == movieActorForAdd.ActorId && ma.MovieId == movieActorForAdd.MovieId) == null)
                        movieActorList.Add(movieActorForAdd);
                }
            }

            modelBuilder.Entity<MovieActor>().HasData(movieActorList);

            #endregion

            #region MovieRating DataSeed

            var movieRatingsList = new List<MovieRatings>();
            var allMovies = movieList.Count;
            var allUsers = userList.Count;
            for (int i = 0; i < allMovies * 3; i++)
            {
                var movieRatingForAdd = new MovieRatings
                {
                    MovieId = random.Next(1, allMovies),
                    UserId = random.Next(1, allUsers),
                    Rating = random.Next(0, 6)
                };

                if (movieRatingsList.Find(mr => mr.MovieId == movieRatingForAdd.MovieId && mr.UserId == movieRatingForAdd.UserId) == null)
                    movieRatingsList.Add(movieRatingForAdd);
            }

            modelBuilder.Entity<MovieRatings>().HasData(movieRatingsList);

            #endregion

        }
    }
}
