using DbConfigurator.Application.Contracts.Features.GetList;
using DbConfigurator.Application.Dtos;
using MediatR;

namespace DbConfigurator.Application.Features.RecipientFeature.Queries.GetList
{
    public class GetRecipientListQuery : IRequest<IEnumerable<RecipientDto>>, IGetListQuery
    {
    }
}
