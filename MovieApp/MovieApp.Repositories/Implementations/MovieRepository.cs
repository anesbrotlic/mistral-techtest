using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApp.Database;
using MovieApp.Entities.Entities;
using MovieApp.Models;
using MovieApp.Repositories.Interfaces;

namespace MovieApp.Repositories.Implementations
{
    public class MovieRepository : IMovieRepository
    {
        private MovieDBContext dbContext;

        public MovieRepository(MovieDBContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<List<Movie>> GetMoviesAsync(int page, bool tvShow, string search, CancellationToken cancellationToken)
        {
            if (!string.IsNullOrEmpty(search))
                search = search.Trim().ToLower();

            return await dbContext.Movies
                .Include(m => m.MovieActors)
                    .ThenInclude(ma => ma.Actor)
                .Include(mr => mr.MovieRatings)
                .Where(m => (m.TVShow == tvShow)
                          && (string.IsNullOrEmpty(search)
                                  || (m.Title.ToLower().Contains(search)
                                  || m.Description.ToLower().Contains(search)
                                  || m.MovieActors.Any(ma => ma.Actor.Name.ToLower().Contains(search)))))
                .OrderByDescending(m=>m.MovieRatings.Any()?m.MovieRatings.Average(mr=>mr.Rating):0)
                .Skip(10 * (page - 1))
                .Take(10)
                .ToListAsync(cancellationToken);

        }

        public async Task<Movie> GetMovieByIdAsync(int movieId, CancellationToken cancellationToken)
        {
            return await dbContext.Movies
                .Include(m=>m.MovieRatings)
                .Include(m=>m.MovieActors)
                .ThenInclude(ma=>ma.Actor)
                .FirstOrDefaultAsync(m => m.Id == movieId, cancellationToken);
        }

        public async Task<Movie> RateMovieAsync(int movieId, int userId, int rating, CancellationToken cancellationToken)
        {
            // ensure movie exists
            if (!await dbContext.Movies.AnyAsync(m=>m.Id==movieId,cancellationToken))
                return null;

            // rate movie
            var movieRating = await dbContext.MovieRatings.FirstOrDefaultAsync(mr => mr.UserId == userId && mr.MovieId == movieId,cancellationToken);
            if (movieRating == null)
            {
                await dbContext.MovieRatings.AddAsync(
                    new MovieRatings {UserId = userId, MovieId = movieId, Rating = rating}, cancellationToken);
            }
            else
            {
                movieRating.Rating = rating;
            }

            await dbContext.SaveChangesAsync(cancellationToken);

            // returns rated movie
            return await dbContext.Movies
                .Include(m=>m.MovieRatings)
                .Include(m=>m.MovieActors)
                    .ThenInclude(ma=>ma.Actor)
                .FirstOrDefaultAsync(m=>m.Id==movieId,cancellationToken);

        }
    }
}
