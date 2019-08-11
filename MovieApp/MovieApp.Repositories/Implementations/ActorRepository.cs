using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApp.Database;
using MovieApp.Entities.Entities;
using MovieApp.Models;
using MovieApp.Repositories.Interfaces;

namespace MovieApp.Repositories.Implementations
{
    public class ActorRepository: IActorRepository
    {
        private MovieDBContext dbContext;

        public ActorRepository(MovieDBContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<Actor> GetByIdAsync(int actorId, CancellationToken cancelationToken)
        {
            return await dbContext.Actors
                .FirstOrDefaultAsync(a => a.Id == actorId, cancelationToken);
        }

        public async Task<List<Actor>> GetAllAsync(CancellationToken cancelationToken)
        {
            return await dbContext.Actors.ToListAsync(cancelationToken);
        }
    }
}
