using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.SecurityEntities;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DbConfigurator.Persistence.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<AppUser> _userManager;

        public AccountRepository(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Result<AppUser>> CreateAsync(AppUser user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);

            if (result.Succeeded)
                return Result.Ok(user);
            else
                return Result.Fail($"{result.Errors.First()}");
        }

        public async Task<Result<AppUser>> GetUserAsync(string userName)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(u => u.UserName == userName.ToLower());
            //var user = await _userManager.Users
            //    .Include(u => u.UserRoles)
            //    .ThenInclude(u => u.)
            //    .SingleOrDefaultAsync(u => u.UserName == userName);

            if (user is null)
            {
                return Result.Fail("No such user in database.");
            }
            else
            {
                return Result.Ok(user);
            }
        }

        public async Task<string> GetUserRoleAsync(AppUser user)
        {
            var roles = await _userManager.GetRolesAsync(user);
            return roles.FirstOrDefault() ?? string.Empty;
        }

        public async Task<bool> UserExists(string userName)
        {
            return await _userManager.Users.AnyAsync(u => u.UserName == userName.ToLower());
        }

        public async Task<bool> CheckPasswordAsync(AppUser user, string password)
        {
            var result = await _userManager.CheckPasswordAsync(user, password);
            if (result == false)
            {
                await _userManager.AccessFailedAsync(user);
            }
            return result;
        }
    }
}
