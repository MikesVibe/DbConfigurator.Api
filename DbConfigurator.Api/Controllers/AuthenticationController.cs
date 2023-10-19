using DbConfigurator.Application.Features.AuthenticationFeature;
using FluentResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DbConfigurator.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AuthenticationController(IConfiguration configuration)
        {
            _configuration = configuration 
                ?? throw new ArgumentNullException(nameof(configuration));
        }
        [HttpPost("authenticate")]
        public ActionResult<string> Authenticate([FromBody] AuthenticationRequestBody authenticationRequestBody)
        {
            //Validation 
            var response = ValidateUserCredentials(
                authenticationRequestBody.UserName,
                authenticationRequestBody.Password);

            if(response.IsFailed)
            {
                return Unauthorized();
            }
            var user = response.Value;

            //Create token
            var securityKey = new SymmetricSecurityKey(
                Encoding.ASCII.GetBytes(_configuration["Authentication:SecretForKey"]
                ?? throw new ArgumentNullException("Authentication:SecretForKey")));
            var signingCredentials = new SigningCredentials(
                securityKey, SecurityAlgorithms.HmacSha256);

            //The claims that
            var claimsForToken = new List<Claim>();
            claimsForToken.Add(new Claim("sub", user.UserId.ToString()));
            claimsForToken.Add(new Claim("given_name", user.FirstName));
            claimsForToken.Add(new Claim("family_name", user.LastName));

            var jwtSecurityToken = new JwtSecurityToken(
                _configuration["Authentication:Issuer"],
                _configuration["Authentication:Audience"],
                claimsForToken,
                DateTime.UtcNow,
                DateTime.UtcNow.AddHours(1),
                signingCredentials);

            var tokenToReturn = new JwtSecurityTokenHandler()
                .WriteToken(jwtSecurityToken);

            return Ok(tokenToReturn);
        }

        private Result<DbInfoUser> ValidateUserCredentials(string? userName, string? password)
        {
            if(userName == "miki")
            {
                return Result.Ok(new DbInfoUser(
                     1,
                     userName ?? "",
                     "Miki",
                     "Ikim"));
            }
            else
            {
                return Result.Fail("No such user in database.");
            }
        }
    }
}
