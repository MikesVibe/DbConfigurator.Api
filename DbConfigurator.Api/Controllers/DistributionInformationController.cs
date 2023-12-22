using AutoMapper;
using Azure;
using DbConfigurator.API.DataAccess.Repository;
using DbConfigurator.Application.Contracts.Features.GetList;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Create;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Delete;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Update;
using DbConfigurator.Application.Features.CountriesFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.CountriesFeature.Queries.GetList;
using DbConfigurator.Application.Features.DistributionInformationFeature;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Create;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Delete;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Update;
using DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationDetails;
using DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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
            :base(mediator) 
        {
            _repository = distributionInformationRepository;
            _mapper = mapper;
        }

        [HttpGet("json")]
        public async Task<ActionResult<IEnumerable<CreateDistributionInformationDto>>> GetJsonList()
        {
            var list = await _repository.GetAllAsync();
            var mapped =  _mapper.Map<IEnumerable<CreateDistributionInformationDto>>(list);
            return Ok(mapped);
        }
    }
}
