using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.CountriesFeature.Commands.Delete
{
    public class DeleteCountryCommandHandler : IRequestHandler<DeleteCountryCommand, Result<CountryDto>>
    {
        public async Task<Result<CountryDto>> Handle(DeleteCountryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
