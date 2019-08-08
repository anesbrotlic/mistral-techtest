using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Entities.Entities;
using MovieApp.Services;
using MovieApp.Services.Implementations;

namespace MovieApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private ActorService ActorService;

        public ActorController(ActorService actorSer)
        {
            ActorService = actorSer;
        }


        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        public async Task<ActionResult<List<Actor>>> GetAll(CancellationToken cancelationToken)
        {
            var list = await ActorService.GettAllActorsAsync(cancelationToken);
            return Ok(list);
        }
    }
}