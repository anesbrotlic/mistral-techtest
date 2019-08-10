using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MovieApp.Models;

namespace MovieApp.Services.Interfaces
{
    public interface IActorService
    {
        Task<ActorDetailsModel> GetByIdAsync(int actorId, CancellationToken cancelationToken);
        Task<List<ActorModel>> GetAllAsync(CancellationToken cancelationToken);
    }
}
