namespace DbConfigurator.Aplication.Contracts.Persistence
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task DeleteAsync(T value);

        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
    }
}
