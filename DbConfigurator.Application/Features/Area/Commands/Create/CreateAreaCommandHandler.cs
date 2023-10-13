using AutoMapper;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.Area
{
    public class CreateAreaCommandHandler : IRequestHandler<CreateAreaCommand, Result<AreaDto>>
    {
        public CreateAreaCommandHandler()
        {
        }

        public async Task<Result<AreaDto>> Handle(CreateAreaCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
