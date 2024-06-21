using DbConfigurator.Application.Contracts.Features.GetDetail;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Queries.GetDetails
{
    public class GetBusinessUnitDetailsQuery : IRequest<Result<BusinessUnitDto>>, IGetDetailQuery
    {
        public int Id { get; set; }
    }
}
