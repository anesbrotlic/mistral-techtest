using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApp.Database;
using MovieApp.Entities.Entities;
using MovieApp.Repositories.Interfaces;

namespace MovieApp.Repositories.Implementations
{
    public class UserRepository:IUserRepository
    {
        private MovieDBContext db;

        public UserRepository(MovieDBContext _db)
        {
            db = _db;
        }

        public async Task<List<User>> GetUsersByUsernameAsync(CancellationToken cancelToken, string username)
        {
            return await db.Users.Where(u => u.Username.CompareTo(username) == 0).ToListAsync(cancelToken);
        }
    }
}
