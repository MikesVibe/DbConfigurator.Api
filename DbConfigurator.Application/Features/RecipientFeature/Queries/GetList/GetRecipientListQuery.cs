﻿using DbConfigurator.Application.Contracts.Features.GetList;
using DbConfigurator.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RecipientFeature.Queries.GetList
{
    public class GetRecipientListQuery : IRequest<IEnumerable<RecipientDto>>, IGetListQuery
    {
    }
}
