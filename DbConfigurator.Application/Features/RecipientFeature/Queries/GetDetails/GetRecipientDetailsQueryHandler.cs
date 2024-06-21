using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.RecipientFeature.Queries.GetDetails
{
    public class GetRecipientDetailsQueryHandler : GetDetailQueryHandlerBase<Recipient, RecipientDto, GetRecipientDetailsQuery>,
        IRequestHandler<GetRecipientDetailsQuery, Result<RecipientDto>>
    {
        public GetRecipientDetailsQueryHandler(
            IRecipientRepository recipientRepository,
            IMapper mapper) : base(recipientRepository, mapper)
        {
        }
    }
}
