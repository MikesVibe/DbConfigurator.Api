using AutoMapper;
using DbConfigurator.Application.Contracts.Features.GetList;
using DbConfigurator.Application.Contracts.Persistence;

namespace DbConfigurator.Application.Common
{
    public class GetListQueryHandlerBase<TEntity, TEntityDto, TGetListQuery>
        where TEntity : class
        where TGetListQuery : IGetListQuery
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        public GetListQueryHandlerBase(
            IRepository<TEntity> repository,
            IMapper mapper)

        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TEntityDto>> Handle(TGetListQuery query, CancellationToken cancellationToken)
        {
            var list = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TEntityDto>>(list);
        }
    }
}
