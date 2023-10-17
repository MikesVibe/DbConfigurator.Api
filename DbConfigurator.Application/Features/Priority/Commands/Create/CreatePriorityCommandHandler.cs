using AutoMapper;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.Feature
{
    public class CreatePriorityCommandHandler : IRequestHandler<CreatePriorityCommand, Result<PriorityDto>>
    {
        public CreatePriorityCommandHandler()
        {
        }

        public async Task<Result<PriorityDto>> Handle(CreatePriorityCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
