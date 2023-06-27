namespace DbConfigurator.Api.Services.Repositories
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        void Add(TEntity entity);
        void Delete(TEntity value);
        IEnumerable<TEntity> GetAll();
        TEntity? GetById(int id);
        void Update(TEntity entity);
    }
}
