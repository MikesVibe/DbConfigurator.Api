using DbConfigurator.Api.Services;
using DbConfigurator.Aplication.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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

        //IRepository
        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }
        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }
        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().AsNoTracking().ToList();
        }
        public T? GetById(int id)
        {
            return _dbContext.Set<T>().FirstOrDefault(e => e.Id == id);
        }
        public void Update(T entity)
        {
            _dbContext.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        //IRepositoryAsync
        public virtual async Task AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
        }
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().AsNoTracking().ToListAsync();
        }
        public virtual async Task<T?> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
