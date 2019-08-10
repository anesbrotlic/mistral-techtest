using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MovieApp.Entities.Entities;
using MovieApp.Models;

namespace MovieApp.Repositories.Interfaces
{
    public interface IActorRepository
    {
        Task<Actor> GetByIdAsync(int actorId, CancellationToken cancelationToken);
        Task<List<Actor>> GetAllAsync(CancellationToken cancelationToken);
    }
}
