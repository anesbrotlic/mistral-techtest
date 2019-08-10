using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Entities.Entities;
using MovieApp.Models;
using MovieApp.Services;
using MovieApp.Services.Implementations;
using MovieApp.Services.Interfaces;
using Serilog;

namespace MovieApp.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private IActorService actorService;

        public ActorController(IActorService _actorService)
        {
            actorService = _actorService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ActorModel>>> GetAllAsync(CancellationToken cancelationToken)
        {
            try
            {
                var actorList = await actorService.GetAllAsync(cancelationToken);

                if (actorList == null)
                    return NotFound();

                return Ok(actorList);

            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Error occurs in {nameof(GetAllAsync)}");
                return StatusCode(500, "Something went wrong!");
            }
        }


        [HttpGet("{actorId:int}")]
        public async Task<ActionResult<List<ActorDetailsModel>>> GetByIdAsync([FromRoute]int actorId, CancellationToken cancelationToken)
        {
            try
            {
                var actorDetails = await actorService.GetByIdAsync(actorId, cancelationToken);

                if (actorDetails == null)
                    return NotFound();

                return Ok(actorDetails);

            }
            catch (Exception ex)
            {
                Log.Error(ex,$"Error occurs in {nameof(GetByIdAsync)}");
                return StatusCode(500, "Something went wrong!");
            }
        }
    }
}