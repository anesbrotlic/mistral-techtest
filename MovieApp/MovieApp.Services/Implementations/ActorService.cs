using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieApp.Database;
using MovieApp.Entities.Entities;
using MovieApp.Models;
using MovieApp.Repositories.Interfaces;
using MovieApp.Services.Interfaces;
using Serilog;

namespace MovieApp.Services.Implementations
{
    public class ActorService:IActorService
    {
        private IActorRepository actorRepository;
        private IMapper mapper;

        public ActorService(IActorRepository _actorRepository, IMapper _mapper)
        {
            actorRepository = _actorRepository;
            mapper = _mapper;
        }


        public async Task<ActorDetailsModel> GetByIdAsync(int actorId, CancellationToken cancelationToken)
        {
            try
            {
                var actor=await actorRepository.GetByIdAsync(actorId, cancelationToken);

                if (actor == null)
                    return null;

                return mapper.Map<ActorDetailsModel>(actor);

            }
            catch (Exception ex)
            {
                Log.Error(ex,$"Error occurs in {nameof(GetByIdAsync)}");
                throw;
            }
        }
    }
}
