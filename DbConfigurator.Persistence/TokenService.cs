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

        public TokenService(
            IConfiguration configuration
            )
        {
            _configuration = configuration
                ?? throw new ArgumentNullException(nameof(configuration));

            _key = new SymmetricSecurityKey(
                Encoding.ASCII.GetBytes(
                    Environment.GetEnvironmentVariable("Authentication_SecretForKey") ??
                    configuration["Authentication:SecretForKey"] ??
                    throw new ArgumentNullException("Authentication_SecretForKey")));
        }

        public string CreateToken(AppUser user)
        {
            //The claims that
            var claimsForToken = new List<Claim>();
            claimsForToken.Add(new Claim("sub", user.Id.ToString()));

            var signingCredentials = new SigningCredentials(
                _key, SecurityAlgorithms.HmacSha512);

            var jwtSecurityToken = new JwtSecurityToken(
                null, 
                null,
                claimsForToken,
                DateTime.UtcNow,
                DateTime.UtcNow.AddDays(1),
                signingCredentials);

            var tokenToReturn = new JwtSecurityTokenHandler()
                .WriteToken(jwtSecurityToken);

            return tokenToReturn;
        }
    }
}
