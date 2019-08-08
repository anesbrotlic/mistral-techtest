using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieApp.Core.Helpers;
using MovieApp.Database;
using MovieApp.Entities.Entities;
using MovieApp.Models;
using MovieApp.Repositories.Interfaces;
using MovieApp.Services.Interfaces;
using Serilog;

namespace MovieApp.Services.Implementations
{
    public class MovieService: IMovieService
    {
        private IMovieRepository movieRepository;
        private IMapper mapper;

        public MovieService(IMovieRepository _movieRepository, IMapper _mapper)
        {
            movieRepository = _movieRepository;
            mapper = _mapper;
        }

        public async Task<List<MovieModel>> GetMoviesAsync(int page, bool tvShow, string search,
            ClaimsPrincipal userClaims, CancellationToken cancellationToken)
        {
            try
            {
                var movieList=await movieRepository.GetMoviesAsync(page, tvShow, search, cancellationToken);

                var mappedMovieList=mapper.Map<List<MovieModel>>(movieList);

                var userId = JWTHelper.GetUserIdFromToken(userClaims);
                for (int i = 0; i < movieList.Count; i++)
                {
                    mappedMovieList[i].RateByUser = movieList[i].MovieRatings.FirstOrDefault(mr => mr.UserId == userId)?.Rating??0;
                }

                return mappedMovieList;
            }
            catch (Exception ex)
            {
                Log.Error(ex,$"Error occurs in {nameof(GetMoviesAsync)}");
                throw;
            }
        }

        public async Task<MovieDetailModel> GetMovieByIdAsync(int movieId, ClaimsPrincipal userClaims,
            CancellationToken cancellationToken)
        {
            try
            {
                var movie = await movieRepository.GetMovieByIdAsync(movieId,cancellationToken);
                if (movie == null)
                    return null;
                var mappedMovie= mapper.Map<MovieDetailModel>(movie);

                var userId = JWTHelper.GetUserIdFromToken(userClaims);
                mappedMovie.RateByUser = movie.MovieRatings.FirstOrDefault(mr => mr.UserId==userId)?.Rating ?? 0;

                return mappedMovie;

            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Error occurs in {nameof(GetMovieByIdAsync)}");
                throw;
            }
        }
    }
}
