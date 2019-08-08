using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MovieApp.Models;

namespace MovieApp.Services.Interfaces
{
    public interface IUserService
    {
        Task<string> TryLoginAndGenerateJWTAsync(CancellationToken cancelToken, LoginModel loginModel);
    }
}
