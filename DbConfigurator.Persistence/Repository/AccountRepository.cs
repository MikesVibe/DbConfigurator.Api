using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.SecurityEntities;
using DbConfigurator.Persistence.DatabaseContext;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Persistence.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DbConfiguratorApiDbContext _dbContext;

        public AccountRepository(DbConfiguratorApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result<AppUser>> AddAsync(AppUser user)
        {
            var userToReturn = await _dbContext.User.AddAsync(user);
            var result = await _dbContext.SaveChangesAsync();

            if (result > 0)
                return Result.Ok(user);
            else
                return Result.Fail("Adding user failed.");
        }

        public async Task<Result<AppUser>> GetUserAsync(string userName)
        {
            var user = await _dbContext.User.SingleOrDefaultAsync(u => u.UserName == userName.ToLower());
            if(user is null)
            {
                return Result.Fail("No such user in database.");
            }
            else
            {
                return Result.Ok(user);
            }
        }

        public async Task<bool> UserExists(string userName)
        {
            return await _dbContext.User.AnyAsync(u => u.UserName == userName.ToLower());
        }
    }
}
