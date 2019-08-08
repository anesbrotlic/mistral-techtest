using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MovieApp.Entities.Entities;
using MovieApp.Models;

namespace MovieApp.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetMoviesAsync(int page, bool tvShow, string search, CancellationToken cancellationToken);
        Task<Movie> GetMovieByIdAsync(int movieId, CancellationToken cancellationToken);
    }
}
