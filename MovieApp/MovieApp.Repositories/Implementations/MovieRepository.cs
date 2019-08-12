using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MovieApp.Database;
using MovieApp.Entities.Entities;
using MovieApp.Entities.Enums;
using MovieApp.Models;
using MovieApp.Repositories.Interfaces;

namespace MovieApp.Repositories.Implementations
{
    public class MovieRepository : IMovieRepository
    {
        private MovieDBContext dbContext;
        private IConfiguration configuration;

        public MovieRepository(MovieDBContext _dbContext, IConfiguration _configuration)
        {
            dbContext = _dbContext;
            configuration = _configuration;
        }

        public async Task<List<Movie>> GetMoviesAsync(MovieRequestModel movieRequestModel,
            CancellationToken cancellationToken)
        {
            try
            {

                /*
                 * PROPUST!!!
                 *
                 * u smislu performansi zato sto se prvo ucitavaju svi filmovi iz baze pa se onda ta lista pretrazuje..
                 *
                 * ideja je bila da napisem jedan jednostavan query i
                 * da u Where uslovu pozovem funkciju searchMovie te joj proslijedim objekat Movie (kao sto je i u trenutnoj implementaciji)
                 *
                 * medjutim trenutna verzija EF Core-a koju koristim ima problem s prosljedjivanjem parametara na taj nacin
                 * tacnije, prosljedjeni objekat iz Where uslova u funkciji ne sadrzi navigationProperty-e odnosno relatedEntities
                 * pokusavao sam i sa EF Core lazy loading i sa eager loading medjutim dobio sam isti rezultat
                 *
                 * posto nisam imao dovoljno vremena da ovo rijesim, odlucio sam se za ovakvu implementaciju
                 *
                 * 
                 *
                 */
                var list =await dbContext.Movies.ToListAsync(cancellationToken);

                return list
                .Where(m => m.TVShow==movieRequestModel.TvShow && searchMovie(m,movieRequestModel.SearchObject))
                .OrderByDescending(m => m.MovieRatings.Any() ? m.MovieRatings.Average(mr => mr.Rating) : 0)
                .Skip(Int32.Parse(configuration.GetSection("AppSettings")["ItemsPerPage"]) * (movieRequestModel.Page - 1))
                .Take(10)
                .ToList();

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private bool searchMovie(Movie movie, SearchModel searchModel)
        {
            if (searchModel == null)
            {
                return true;
            }
            else
            {

                searchModel.Value = searchModel.Value.ToLower();

                if (searchModel.RegularSearch)
                {
                    var x = movie.Title.ToLower().Contains(searchModel.Value) ||
                            movie.MovieActors.Any(ma => ma.Actor.Name.ToLower().Contains(searchModel.Value)) ||
                            movie.Description.Substring(0,movie.Description.Length>200?200:movie.Description.Length).ToLower().Contains(searchModel.Value);
                    return x;
                }
                else
                {
                    switch (searchModel.KeywordSearchObject.SearchType)
                    {
                        case SearchTypeEnum.Rating:
                            {
                                var movieAvgRating = movie.MovieRatings.Count>0?(int)movie.MovieRatings.Average(mr => mr.Rating):0;
                                var value = Int32.Parse(searchModel.Value);

                                return switchKeywordTypeEnumResults(searchModel.KeywordSearchObject.KeyWordType, movieAvgRating, value);
                            };

                        case SearchTypeEnum.ReleaseDate:
                            {
                                var movieReleaseYear = movie.ReleaseDate.Year;
                                var value = Int32.Parse(searchModel.Value);

                                return switchKeywordTypeEnumResults(searchModel.KeywordSearchObject.KeyWordType, movieReleaseYear, value);

                            };
                    }
                }
            }

            return true;
        }

        private bool switchKeywordTypeEnumResults(KeywordTypeEnum keywordType, int source, int value)
        {
            switch (keywordType)
            {
                case KeywordTypeEnum.More:
                    return source > value;
                case KeywordTypeEnum.Less:
                    return source < value;
                case KeywordTypeEnum.AtLeast:
                    return source >= value;
                case KeywordTypeEnum.AtMost:
                    return source <= value;
                case KeywordTypeEnum.Exact:
                    return source == value;

                default: return true;

            }
        }

        public async Task<Movie> GetMovieByIdAsync(int movieId, CancellationToken cancellationToken)
        {
            return await dbContext.Movies
                .FirstOrDefaultAsync(m => m.Id == movieId, cancellationToken);
        }

        public async Task<Movie> RateMovieAsync(int movieId, int userId, int rating, CancellationToken cancellationToken)
        {
            // ensure movie exists
            if (!await dbContext.Movies.AnyAsync(m => m.Id == movieId, cancellationToken))
                return null;

            // rate movie
            var movieRating = await dbContext.MovieRatings.FirstOrDefaultAsync(mr => mr.UserId == userId && mr.MovieId == movieId, cancellationToken);
            if (movieRating == null)
            {
                await dbContext.MovieRatings.AddAsync(
                    new MovieRatings { UserId = userId, MovieId = movieId, Rating = rating }, cancellationToken);
            }
            else
            {
                movieRating.Rating = rating;
            }

            await dbContext.SaveChangesAsync(cancellationToken);

            // returns rated movie
            return await dbContext.Movies
                .FirstOrDefaultAsync(m => m.Id == movieId, cancellationToken);

        }
    }
}
