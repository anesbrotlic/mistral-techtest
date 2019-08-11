using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MovieApp.Entities.Entities;
using MovieApp.Models;

namespace MovieApp.Services.Interfaces
{
    public interface IMovieService
    {
        Task<List<MovieModel>> GetMoviesAsync(MovieRequestModel movieRequestModel, int userId,
            CancellationToken cancellationToken);
        Task<MovieDetailModel> GetMovieByIdAsync(int movieId, int userId,
            CancellationToken cancellationToken);

        Task<MovieModel> RateMovieAsync(int movieId, int userId, int rating, CancellationToken cancellationToken);
    }
}
