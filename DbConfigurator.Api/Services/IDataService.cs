namespace DbConfigurator.Api.Services
{
    public interface IDataService<TEntity, TDto>
    {
        Task AddAsync(TDto tDto);
        bool Delete(int id);
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<TDto> GetByIdAsync(int id);
        void Update(TDto entityTDto);
    }
}