using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MovieApp.Entities.Entities;

namespace MovieApp.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersByUsernameAsync(CancellationToken cancelToken, string username);
    }
}
