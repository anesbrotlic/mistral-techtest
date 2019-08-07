using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
using MovieApp.Services;

namespace MovieApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private AuthService AuthService;

        public AuthController(AuthService authSer)
        {
            AuthService = authSer;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            var token = AuthService.TryLoginAndGenerateJWT(loginModel);

            if (String.IsNullOrEmpty(token))
                return BadRequest();

            return Ok(token);
        }

        [Authorize]
        [HttpPost("login2")]
        public IActionResult Login2()
        {
            var id=AuthService.GetUserIdFromToken(HttpContext.User);
            return Ok(id);
        }
    }
}