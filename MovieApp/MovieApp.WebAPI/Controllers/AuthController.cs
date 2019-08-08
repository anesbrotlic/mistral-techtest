using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
using MovieApp.Services;
using MovieApp.Services.Implementations;
using MovieApp.Services.Interfaces;
using Serilog;

namespace MovieApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IUserService userService;

        public AuthController(IUserService userService)
        {
            this.userService = userService;
        }


        [HttpPost("login")]
        public async Task<ActionResult<string>> LoginAsync([FromBody] LoginModel loginModel, CancellationToken cancellationToken)
        {
            try
            {
                var token = await userService.TryLoginAndGenerateJWTAsync(cancellationToken, loginModel);

                if (String.IsNullOrEmpty(token))
                    return BadRequest("User account not found!");

                return Ok(token);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Error occurs in {nameof(LoginAsync)}");
                return BadRequest("Something went wrong!");
            }
        }

    }
}