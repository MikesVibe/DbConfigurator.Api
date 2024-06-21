using DbConfigurator.Domain.SecurityEntities;

namespace DbConfigurator.Application.Contracts.Persistence
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
