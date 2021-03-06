﻿using System;
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

        public async Task<List<MovieModel>> GetMoviesAsync(MovieRequestModel movieRequestModel,
            int userId, CancellationToken cancellationToken)
        {
            try
            {



                //get movies 
                var movieList =await movieRepository.GetMoviesAsync(movieRequestModel, cancellationToken);
                Log.Information($"Movies count:{movieList.Count} {nameof(GetMoviesAsync)}");

                if (!movieList.Any())
                    return null;

                // mapp Movie->MovieModel
                var mappedMovieList=mapper.Map<List<MovieModel>>(movieList);

                // get user rate for movies
                for (int i = 0; i < movieList.Count; i++)
                {
                    mappedMovieList[i].RatingByUser = movieList[i].MovieRatings.FirstOrDefault(mr => mr.UserId == userId)?.Rating??0;
                }

                return mappedMovieList;
            }
            catch (Exception ex)
            {
                Log.Error(ex,$"Error occurs in {nameof(GetMoviesAsync)}");
                throw;
            }
        }

        public async Task<MovieDetailModel> GetMovieByIdAsync(int movieId, int userId,
            CancellationToken cancellationToken)
        {
            try
            {
                // get movie
                var movie = await movieRepository.GetMovieByIdAsync(movieId,cancellationToken);

                if (movie == null)
                {
                    Log.Information($"Movie by id not found. {nameof(GetMovieByIdAsync)}");
                    return null;
                }

                Log.Information($"Movie by id  found. {nameof(GetMovieByIdAsync)}");


                // mapp Movie->MovieDetailsModel
                var mappedMovie = mapper.Map<MovieDetailModel>(movie);

                // get user rate for movie
                mappedMovie.RatingByUser = movie.MovieRatings.FirstOrDefault(mr => mr.UserId==userId)?.Rating ?? 0;

                return mappedMovie;

            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Error occurs in {nameof(GetMovieByIdAsync)}");
                throw;
            }
        }

        public async Task<MovieModel> RateMovieAsync(int movieId, int userId, int rating, CancellationToken cancellationToken)
        {
            try
            {
                // try to rate movie
                var ratedMovie=await movieRepository.RateMovieAsync(movieId, userId, rating, cancellationToken);

                if (ratedMovie == null)
                    return null;

                // mapp Movie->MovieModel
                var mappedRatedMovie=mapper.Map<MovieModel>(ratedMovie);

                // get user rate for movie
                mappedRatedMovie.RatingByUser = ratedMovie.MovieRatings.FirstOrDefault(mr => mr.UserId == userId)?.Rating??0;

                Log.Information($"Movie successfully rated. {nameof(RateMovieAsync)}");

                return mappedRatedMovie;

            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Error occurs in {nameof(RateMovieAsync)}");
                throw;
            }
        }
    }
}
