using DbConfigurator.Domain.SecurityEntities;
using FluentResults;

namespace DbConfigurator.Application.Contracts.Persistence
{
    public interface IAccountRepository
    {
        Task<Result<AppUser>> CreateAsync(AppUser user, string password);
        Task<Result<AppUser>> GetUserAsync(string useName);
        Task<bool> UserExists(string userName);
        Task<bool> CheckPasswordAsync(AppUser user, string password);
        Task<string> GetUserRoleAsync(AppUser user);
    }
}
