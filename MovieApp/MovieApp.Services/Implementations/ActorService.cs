using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApp.Database;
using MovieApp.Entities.Entities;
using MovieApp.Services.Interfaces;

namespace MovieApp.Services.Implementations
{
    public class ActorService:IActorService
    {
        private MovieDBContext db;

        public ActorService(MovieDBContext _db)
        {
            db = _db;
        }

        public async Task<List<Actor>> GettAllActorsAsync(CancellationToken cancelationToken)
        {
            return await db.Actors.ToListAsync(cancelationToken);
        }
    }
}
