using FluentResults;

namespace DbConfigurator.Application.Contracts.Persistence
{
    public interface IRepository<T> where T : class
    {
        Task<Result<T>> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task DeleteAsync(T value);

        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<bool> ExistsAsync(int id);
    }
}
