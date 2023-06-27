using AutoMapper;
using System.Linq.Expressions;

namespace DbConfigurator.Api.Services
{
    public class ServiceAsync<TEntity, TDto> : IServiceAsync<TEntity, TDto>
            where TDto : IEntityDto where TEntity : IEntity
    {
        protected readonly IRepositoryAsync<TEntity> _repository;
        protected readonly IMapper _mapper;

        public ServiceAsync(IRepositoryAsync<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task AddAsync(TDto tDto)
        {
            var entity = _mapper.Map<TEntity>(tDto);
            await _repository.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(await _repository.GetByIdAsync(id));
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

        public async Task UpdateAsync(TDto entityTDto)
        {
            var entity = _mapper.Map<TEntity>(entityTDto);
            await _repository.UpdateAsync(entity);
        }
    }
}
