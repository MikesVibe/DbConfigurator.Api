using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using MediatR;

namespace DbConfigurator.Application.Features.PriorityFeature.Queries.GetList
{
    public class GetPriorityListQueryHandler : GetListQueryHandlerBase<Priority, PriorityDto, GetPriorityListQuery>,
        IRequestHandler<GetPriorityListQuery, IEnumerable<PriorityDto>>
    {
        public GetPriorityListQueryHandler(
            IPriorityRepository priorityRepository,
            IMapper mapper) : base(priorityRepository, mapper)
        {
        }
    }
}
