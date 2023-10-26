using Azure;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Create;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Delete;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Update;
using DbConfigurator.Application.Features.CountriesFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.CountriesFeature.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    public class CountryController : AuthorizingController
    {
        private readonly IMediator _mediator;

        public CountryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetCountry")]
        public async Task<ActionResult<IEnumerable<CountryDto>>> GetCountry()
        {
            var country = await _mediator.Send(new GetCountryListQuery());
            return Ok(country);
        }

        [HttpGet("{id}", Name = "GetCountryById")]
        public async Task<ActionResult<CountryDto>> GetCountryById(int id)
        {
            var response = await _mediator.Send(new GetCountryDetailsQuery() { CountryId = id });
            if (response.IsFailed)
                return BadRequest();

            return Ok(response.Value);
        }

        [HttpPost(Name = "AddCountry")]
        public async Task<IActionResult> AddCountry([FromBody] CreateCountryDto country)
        {
            var response = await _mediator.Send(new CreateCountryCommand() { Country = country });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            var response = await _mediator.Send(new DeleteCountryCommand() { CountryId = id });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCountry([FromBody] UpdateCountryDto country)
        {
            var response = await _mediator.Send(new UpdateCountryCommand() { Country = country });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
    }
}
