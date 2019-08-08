using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using MovieApp.Entities.Entities;

namespace MovieApp.Core.Helpers
{
    public static class JWTHelper
    {
        public static string UserIdClaimType { get; set; } = "userId";

        public static string Issuer { get; set; } = "MovieApp";
        public static string Audience { get; set; } = "MovieApp";

        public static string SecretKey { get; set; } = "SECRETKEY_MistralMovieAppWebAPI__$$%%@!!!@###$$$#3";


        public static string GetToken(User user)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var tokeOptions = new JwtSecurityToken(
                issuer: Issuer,
                audience: Audience,
                claims: new List<Claim> { new Claim(UserIdClaimType, user.Id.ToString()) },
                expires: DateTime.UtcNow.AddMinutes(5),
                signingCredentials: signinCredentials
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

            return tokenString;
        }

        public static int GetUserIdFromToken(ClaimsPrincipal user)
        {
            var id = user.Claims.FirstOrDefault(c => c.Type == UserIdClaimType)?.Value??"0";
            return Int32.Parse(id);
        }

    }
}
