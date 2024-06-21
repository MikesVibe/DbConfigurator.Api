using DbConfigurator.Application.Contracts.Features.GetDetail;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.AreaFeature.Queries.GetAreaDetails
{
    public class GetAreaDetailsQuery : IRequest<Result<AreaDto>>, IGetDetailQuery
    {
        public int Id { get; set; }
    }
}
