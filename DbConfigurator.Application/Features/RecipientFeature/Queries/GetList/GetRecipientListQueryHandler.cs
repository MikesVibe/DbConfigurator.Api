using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using MediatR;

namespace DbConfigurator.Application.Features.RecipientFeature.Queries.GetList
{
    public class GetRecipientListQueryHandler : GetListQueryHandlerBase<Recipient, RecipientDto, GetRecipientListQuery>,
        IRequestHandler<GetRecipientListQuery, IEnumerable<RecipientDto>>
    {
        public GetRecipientListQueryHandler(
            IRecipientRepository recipientRepository,
            IMapper mapper) : base(recipientRepository, mapper)
        {
        }
    }
}
