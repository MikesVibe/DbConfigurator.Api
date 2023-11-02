using AutoMapper;
using DbConfigurator.Api.Services;
using DbConfigurator.Application.Contracts.Features.GetList;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.AreaFeature.Queries.GetAreaList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Common
{
    public class GetListQueryHandlerBase<TEntity, TEntityDto, TGetListQuery>
        where TEntity : class
        where TGetListQuery: IGetListQuery
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

        public async Task<IEnumerable<AreaDto>> Handle(TGetListQuery query, CancellationToken cancellationToken)
        {
            var list = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<AreaDto>>(list);
        }
    }
}
