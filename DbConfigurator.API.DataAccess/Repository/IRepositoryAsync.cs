using System.Linq.Expressions;

namespace DbConfigurator.Api.Services
{
    public interface IRepositoryAsync<TEntity> where TEntity : IEntity
    {
        Task AddAsync(TEntity entity);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(int id);
    }
}