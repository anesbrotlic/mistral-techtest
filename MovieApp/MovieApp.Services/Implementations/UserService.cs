using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MovieApp.Core.Helpers;
using MovieApp.Entities.Entities;
using MovieApp.Models;
using MovieApp.Repositories.Interfaces;
using MovieApp.Services.Interfaces;
using Serilog;

namespace MovieApp.Services.Implementations
{
    public class UserService: IUserService
    {
        private IUserRepository userRepository;
        private ILogger<IUserRepository> Logger;

        public UserService(IUserRepository _userRepository)
        {
            this.userRepository = _userRepository;
        }

        public async Task<string> TryLoginAndGenerateJWTAsync(CancellationToken cancelToken, LoginModel loginModel)
        {
            try
            {
                var loggedUser = await TryLoginAsync(cancelToken, loginModel);

                if (loggedUser == null)
                    return null;

                var token = JWTHelper.GetToken(loggedUser);

                return token;
            }
            catch (Exception ex)
            {
                Log.Error(ex,$"Error occurs in {nameof(TryLoginAndGenerateJWTAsync)}");
                throw;
            }
        }

        private async Task<User> TryLoginAsync(CancellationToken cancelToken, LoginModel loginModel)
        {
            var usersWithSameUsername = await userRepository.GetUsersByUsernameAsync(cancelToken, loginModel.Username);

            if (!usersWithSameUsername.Any())
                return null;

            foreach (var user in usersWithSameUsername)
            {
                var hahsedPassword = PasswordHashingHelper.HashPassword(user.PasswordSalt, loginModel.Password);
                if (user.PasswordHash.CompareTo(hahsedPassword) == 0)
                    return user;
            }

            return null;
        }
    }
}
