using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.RecipientFeature.Queries.GetDetails;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RecipientFeature.Queries.GetList
{
    public class GetRecipientListQueryHandler : GetListQueryHandlerBase<Recipient, RecipientDto, GetRecipientListQuery>,
        IRequestHandler<GetRecipientListQuery, IEnumerable<RecipientDto>>
    {
        public GetRecipientListQueryHandler(
            IRecipientRepository recipientRepository,
            IMapper mapper): base(recipientRepository, mapper) 
        {
        }
    }
}
