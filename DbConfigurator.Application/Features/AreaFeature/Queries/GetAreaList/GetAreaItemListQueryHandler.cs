using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using MediatR;

namespace DbConfigurator.Application.Features.AreaFeature.Queries.GetAreaList
{
    public class GetAreaItemListQueryHandler : GetListQueryHandlerBase<Area, AreaDto, GetAreaItemListQuery>,
        IRequestHandler<GetAreaItemListQuery, IEnumerable<AreaDto>>
    {
        public GetAreaItemListQueryHandler(
            IAreaRepository areaRepository,
            IMapper mapper) : base(areaRepository, mapper)
        {
        }
    }
}
