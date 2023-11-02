using AutoMapper;
using DbConfigurator.Application.Contracts.Features.Create;
using DbConfigurator.Application.Contracts.Features.GetDetail;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.AreaFeature.Queries.GetAreaDetails;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Common
{
    public class GetDetailQueryHandlerBase<TEntity, TEntityDto, TGetDetailQuery>
        where TEntity : class
        where TGetDetailQuery : IGetDetailQuery
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        public GetDetailQueryHandlerBase(
            IRepository<TEntity> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Result<AreaDto>> Handle(TGetDetailQuery query, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(query.Id);
            if (entity is null)
            {
                return Result.Fail($"{nameof(TEntity)} with specified Id is no longer present in database.");
            }
            return _mapper.Map<AreaDto>(entity);
        }
    }
}
