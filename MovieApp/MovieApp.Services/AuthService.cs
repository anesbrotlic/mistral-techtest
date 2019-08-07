using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using MovieApp.Database;
using MovieApp.Entities.Entities;
using MovieApp.Helpers;
using MovieApp.Models;

namespace MovieApp.Services
{
    public class AuthService
    {
        private MovieDBContext db;

        public AuthService(MovieDBContext _db)
        {
            db = _db;
        }

        public string TryLoginAndGenerateJWT(LoginModel loginModel)
        {
            var loggedUser = TryLogin(loginModel);

            if (loggedUser == null)
                return null;

            var token = JWTHelper.GetToken(loggedUser);

            return token;
        }

        private User TryLogin(LoginModel loginModel)
        {
            var users = db.Users.Where(u => u.Username.CompareTo(loginModel.Username) == 0);

            if (users.Count() == 0)
                return null;

            foreach (var user in users)
            {
                var hashedPass = PasswordHashingHelper.HashPassword(user.PasswordSalt, loginModel.Password);
                if (user.PasswordHash.CompareTo(hashedPass) == 0)
                    return user;
            }

            return null;

        }

        public int GetUserIdFromToken(ClaimsPrincipal httpContextUser)
        {
            return JWTHelper.GetUserIdFromToken(httpContextUser);
        }
    }
}
