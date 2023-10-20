using DbConfigurator.Domain.SecurityEntities;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Contracts.Persistence
{
    public interface IAccountRepository
    {
        Task<Result<AppUser>> AddAsync(AppUser user);
        Task<Result<AppUser>> GetUserAsync(string useName);
        Task<bool> UserExists(string userName);
    }
}
