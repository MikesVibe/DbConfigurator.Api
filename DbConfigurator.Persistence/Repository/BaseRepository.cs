using DbConfigurator.Api.Models;
using DbConfigurator.Api.Services;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DbConfigurator.API.DataAccess.Repository
{
    public class BaseRepository<T> : IRepository<T>
        where T : class, IEntity

    {
        protected readonly DbConfiguratorApiDbContext _dbContext;

        public BaseRepository(DbConfiguratorApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public virtual async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
        public virtual async Task<bool> UpdateAsync(T entity)
        {
            _dbContext.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            var result = await _dbContext.SaveChangesAsync();

            return result > 0;
        }
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await GetAllQueryable().ToListAsync();
        }
        public virtual async Task<T?> GetByIdAsync(int id)
        {
            return await GetAllQueryable().SingleOrDefaultAsync(e => e.Id == id);
        }
        public virtual async Task<bool> ExistsAsync(int id)
        {
            var entity = await _dbContext.Set<T>()
                .Where(entity => entity.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
            return entity is not null;
        }

        protected virtual IQueryable<T> GetAllQueryable()
        {
            return _dbContext.Set<T>().AsNoTracking().AsQueryable();
        }
    }
}
