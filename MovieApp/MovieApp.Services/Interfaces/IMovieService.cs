﻿using System;
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
        Task<List<MovieModel>> GetMoviesAsync(int page, bool tvShow, string search, ClaimsPrincipal userClaims,
            CancellationToken cancellationToken);
        Task<MovieDetailModel> GetMovieByIdAsync(int movieId, ClaimsPrincipal userClaims,
            CancellationToken cancellationToken);
    }
}
