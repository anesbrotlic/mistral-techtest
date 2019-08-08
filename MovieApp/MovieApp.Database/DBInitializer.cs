using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;
using MovieApp.Core.Helpers;
using MovieApp.Database.Helpers;
using MovieApp.Entities.Entities;

namespace MovieApp.Database
{
    public static class DbInitializer
    {
        public static void Initialize(MovieDBContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (EnumerableExtensions.Any(context.Users))
            {
                return; // DB has been seeded
            }


            var random = new Random();


            #region User DataSeed

            var userList = new List<User>();

            for (int i = 0; i < 10; i++)
            {
                var salt = PasswordHashingHelper.GenerateSalt();
                var usernamePassword = "user" + i;

                userList.Add(new User
                {
                    Username = usernamePassword,
                    PasswordSalt = salt,
                    PasswordHash = PasswordHashingHelper.HashPassword(salt, usernamePassword)
                });
            }


            context.Users.AddRange(userList);
            context.SaveChanges();

            userList = userList.OrderBy(u => u.Id).ToList();
            var userIdMin = userList.First().Id;
            var userIdMax = userList.Last().Id;

            #endregion

            #region Movie DataSeed

            var movieList = DBSeedHelper.GetMovies();
            context.Movies.AddRange(movieList);
            context.SaveChanges();

            movieList = movieList.OrderBy(m => m.Id).ToList();
            var movieIdMin = movieList.First().Id;
            var movieIdMax = movieList.Last().Id;
            #endregion

            #region Actor DataSeed

            var actorList = DBSeedHelper.GetActors();
            context.Actors.AddRange(actorList);
            context.SaveChanges();

            actorList = actorList.OrderBy(a => a.Id).ToList();
            var actorIdMin = actorList.First().Id;
            var actorIdMax = actorList.Last().Id;
            #endregion

            #region MovieActor DataSeed

            var movieActorList = new List<MovieActor>();
            for (int i = 0; i < movieList.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    var movieActorForAdd = new MovieActor
                    {
                        MovieId = movieList[i].Id,
                        ActorId = random.Next(actorIdMin, actorIdMax+1)
                    };

                    if (movieActorList.Find(ma => ma.ActorId == movieActorForAdd.ActorId && ma.MovieId == movieActorForAdd.MovieId) == null)
                        movieActorList.Add(movieActorForAdd);
                }
            }

            context.MovieActors.AddRange(movieActorList);
            context.SaveChanges();
            #endregion

            #region MovieRating DataSeed

            var movieRatingsList = new List<MovieRatings>();
            var allMovies = movieList.Count;
            var allUsers = userList.Count;
            for (int i = 0; i < allMovies * 3; i++)
            {
                var movieRatingForAdd = new MovieRatings
                {
                    MovieId = random.Next(movieIdMin, movieIdMax+1),
                    UserId = random.Next(userIdMin, userIdMax+1),
                    Rating = random.Next(1, 6)
                };

                if (movieRatingsList.Find(mr => mr.MovieId == movieRatingForAdd.MovieId && mr.UserId == movieRatingForAdd.UserId) == null)
                    movieRatingsList.Add(movieRatingForAdd);
            }

            context.MovieRatings.AddRange(movieRatingsList);
            context.SaveChanges();
            #endregion

        }
    }
}

