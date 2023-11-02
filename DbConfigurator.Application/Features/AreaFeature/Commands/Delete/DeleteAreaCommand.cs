using DbConfigurator.Application.Contracts.Features.Delete;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.AreaFeature.Commands.Delete
{
    public class DeleteAreaCommand : IRequest<Result>, IDeleteCommand
    {
        public int Id { get; set; }
    }
}
