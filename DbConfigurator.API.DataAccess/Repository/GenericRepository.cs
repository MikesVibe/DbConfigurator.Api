using DbConfigurator.Api.Services;
using DbConfigurator.Api.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DbConfigurator.API.DataAccess.Repository
{
    public class GenericRepository<T> : IRepository<T>, IRepositoryAsync<T> 
        where T : class, IEntity
        
    {
        private readonly DbConfiguratorApiDbContext _dbContext;

        public GenericRepository(DbConfiguratorApiDbContext dbContext)
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
        public async Task AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().AsNoTracking().ToListAsync();
        }
        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
