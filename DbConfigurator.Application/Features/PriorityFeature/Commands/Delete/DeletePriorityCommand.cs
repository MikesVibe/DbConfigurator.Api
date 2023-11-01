using DbConfigurator.Application.Contracts;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.PriorityFeature.Commands.Delete
{
    public class DeletePriorityCommand : IRequest<Result>, IDeleteCommand
    {
        public int Id{ get; set; } 
    }
}
