using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Core.Helpers;
using MovieApp.Entities.Entities;
using MovieApp.Models;
using MovieApp.Services;
using MovieApp.Services.Implementations;
using MovieApp.Services.Interfaces;
using Serilog;

namespace MovieApp.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IMovieService movieService;

        public MovieController(IMovieService _movieService)
        {
            movieService = _movieService;
        }


        [HttpGet]
        public async Task<ActionResult<List<MovieModel>>> GetMoviesAsync([FromQuery] int page, [FromQuery] bool tvShow, [FromQuery] string search, CancellationToken cancellationToken)
        {
            try
            {
                var userId = JWTHelper.GetUserIdFromToken(HttpContext.User);

                var list = await movieService.GetMoviesAsync(page, tvShow, search,userId, cancellationToken);

                if (!list.Any())
                    return NotFound();

                return Ok(list);
            }
            catch (Exception ex)
            {
                Log.Error(ex,$"Error occurs in {nameof(GetMoviesAsync)}");
                return StatusCode(500,"Something went wrong!");
            }
        }


        [HttpGet("{movieId:int}")]
        public async Task<ActionResult<MovieDetailModel>> GetMovieByIdAsync([FromRoute] int movieId, CancellationToken cancellationToken)
        {
            try
            {
                var userId = JWTHelper.GetUserIdFromToken(HttpContext.User);

                var movie = await movieService.GetMovieByIdAsync(movieId,userId, cancellationToken);

                if (movie == null)
                    return NotFound();

                return Ok(movie);

            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Error occurs in {nameof(GetMovieByIdAsync)}");
                return StatusCode(500,"Something went wrong!");
            }
        }


        [HttpPost("rate/{movieId:int}")]
        public async Task<ActionResult<MovieModel>> RateMovieAsync([FromRoute] int movieId, [FromBody] int rating, CancellationToken cancellationToken)
        {
            try
            {
                //var userId = JWTHelper.GetUserIdFromToken(HttpContext.User);
                var userId = 4;

                var updatedMovie = await movieService.RateMovieAsync(movieId, userId, rating, cancellationToken);

                if (updatedMovie==null)
                    return BadRequest("Movie is not rated!");

                return Ok(updatedMovie);


            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Error occurs in {nameof(RateMovieAsync)}");
                return StatusCode(500, "Something went wrong!");

            }
        }


    }
}