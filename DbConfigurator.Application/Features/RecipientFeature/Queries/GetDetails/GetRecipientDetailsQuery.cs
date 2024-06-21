using DbConfigurator.Application.Contracts.Features.GetDetail;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.RecipientFeature.Queries.GetDetails
{
    public class GetRecipientDetailsQuery : IRequest<Result<RecipientDto>>, IGetDetailQuery
    {
        public int Id { get; set; }
    }
}
