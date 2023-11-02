using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.SecurityEntities;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Persistence
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;
        private readonly SymmetricSecurityKey _key;

        //private readonly UserManager<DbInfoUser> _userManager;

        public TokenService(
            IConfiguration configuration
            //, UserManager<DbInfoUser> userManager
            )
        {
            _configuration = configuration
                ?? throw new ArgumentNullException(nameof(configuration));
            //_userManager = userManager;

            _key = new SymmetricSecurityKey(
                Encoding.ASCII.GetBytes(
                    Environment.GetEnvironmentVariable("Authentication_SecretForKey") ??
                    configuration["Authentication:SecretForKey"] ??
                    throw new ArgumentNullException("Authentication_SecretForKey")));

        }
        public string CreateToken(AppUser user)
        {
            ////Validation 
            //var response = ValidateUserCredentials(
            //    user.UserName,
            //    user.PasswordHash);

            //if (response.IsFailed)
            //{
            //    return Unauthorized();
            //}
            //var userValue = response.Value;



            //The claims that
            var claimsForToken = new List<Claim>();
            claimsForToken.Add(new Claim("sub", user.Id.ToString()));
            //claimsForToken.Add(new Claim("given_name", user.));
            //claimsForToken.Add(new Claim("family_name", user.LastName));

            var signingCredentials = new SigningCredentials(
                _key, SecurityAlgorithms.HmacSha512);

            //var jwtSecurityToken = new JwtSecurityToken(
            //    _configuration["Authentication:Issuer"],
            //    _configuration["Authentication:Audience"],
            //    claimsForToken,
            //    DateTime.UtcNow,
            //    DateTime.UtcNow.AddDays(1),
            //    signingCredentials);
            var jwtSecurityToken = new JwtSecurityToken(
                null, null,
                //_configuration["Authentication:Issuer"],
                //_configuration["Authentication:Audience"],
                claimsForToken,
                DateTime.UtcNow,
                DateTime.UtcNow.AddDays(1),
                signingCredentials);

            var tokenToReturn = new JwtSecurityTokenHandler()
                .WriteToken(jwtSecurityToken);

            return tokenToReturn;
        }

        //private Result<AppUser> ValidateUserCredentials(string? userName, string? password)
        //{
        //    if (userName == "miki")
        //    {
        //        return Result.Ok(new AppUser(
        //             1,
        //             userName ?? "",
        //             "Miki",
        //             "Ikim"));
        //    }
        //    else
        //    {
        //        return Result.Fail("No such user in database.");
        //    }
        //}
    }
}
