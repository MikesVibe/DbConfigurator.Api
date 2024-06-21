using DbConfigurator.Application.Contracts.Features.GetDetail;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.PriorityFeature.Queries.GetDetails
{
    public class GetPriorityDetailsQuery : IRequest<Result<PriorityDto>>, IGetDetailQuery
    {
        public int Id { get; set; }
    }
}
