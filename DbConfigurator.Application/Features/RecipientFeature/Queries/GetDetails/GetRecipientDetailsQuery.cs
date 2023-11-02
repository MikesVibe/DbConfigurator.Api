using DbConfigurator.Application.Contracts.Features.GetDetail;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RecipientFeature.Queries.GetDetails
{
    public class GetRecipientDetailsQuery : IRequest<Result<RecipientDto>>, IGetDetailQuery
    {
        public int Id { get; set; }
    }
}
