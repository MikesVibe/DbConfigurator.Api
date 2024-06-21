using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Create;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Delete;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Update;
using DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationDetails;
using DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    public class DistributionInformationController : GenericController<
        CreateDistributionInformationCommand, UpdateDistributionInformationCommand, DeleteDistributionInfomationCommand,
        CreateDistributionInformationDto, UpdateDistributionInformationDto,
        GetDistributionInformationDetailsQuery, GetDistributionInformationItemListQuery,
        DistributionInformationDto>
    {
        private IDistributionInformationRepository _repository;
        private readonly IMapper _mapper;

        public DistributionInformationController(IMediator mediator, IDistributionInformationRepository distributionInformationRepository, IMapper mapper)
            : base(mediator)
        {
            _repository = distributionInformationRepository;
            _mapper = mapper;
        }

        [HttpGet("json")]
        public async Task<ActionResult<IEnumerable<CreateDistributionInformationDto>>> GetJsonList()
        {
            var list = await _repository.GetAllAsync();
            var mapped = _mapper.Map<IEnumerable<CreateDistributionInformationDto>>(list);
            return Ok(mapped);
        }
    }
}
