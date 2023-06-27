using AutoMapper;
using DbConfigurator.Api.Services.Repositories;
using System.Linq.Expressions;

namespace DbConfigurator.Api.Services
{
    public class DataService<TRepository, TEntity, TDto> : IDataService<TEntity, TDto>
            where TDto : IEntityDto 
            where TEntity : IEntity
            where TRepository : IRepository<TEntity>
    {
        protected readonly TRepository _repository;
        protected readonly IMapper _mapper;

        public DataService(TRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task AddAsync(TDto tDto)
        {
            var entity = _mapper.Map<TEntity>(tDto);
            await _repository.AddAsync(entity);
        }

        public bool Delete(int id)
        {
            var entity = _repository.GetById(id);
            if (entity is null)
                return false;

            _repository.Delete(entity);
            return true;
        }

        public async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

        public async Task<TDto> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<TDto>(entity);
        }

        public void Update(TDto entityTDto)
        {
            var entity = _mapper.Map<TEntity>(entityTDto);
            _repository.Update(entity);
        }
    }
}
