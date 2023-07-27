namespace DbConfigurator.Aplication.Contracts.Persistence
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T value);
        IEnumerable<T> GetAll();
        T? GetById(int id);
        void Update(T entity);

        Task AddAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
    }
}
