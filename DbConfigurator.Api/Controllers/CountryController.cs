using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Create;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Delete;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Update;
using DbConfigurator.Application.Features.CountriesFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.CountriesFeature.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
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

        [HttpGet("{countryId}", Name = "GetCountryById")]
        public async Task<ActionResult<CountryDto>> GetCountryById(int countryId)
        {
            var country = await _mediator.Send(new GetCountryDetailsQuery() { CountryId = countryId });
            return Ok(country);
        }

        [HttpPost(Name = "AddCountry")]
        public async Task<IActionResult> AddCountry([FromBody] CountryDto country)
        {
            var response = await _mediator.Send(new CreateCountryCommand() { Country = country });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCountry([FromBody] CountryDto country)
        {
            var response = await _mediator.Send(new DeleteCountryCommand() { Country = country });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCountry([FromBody] CountryDto country)
        {
            var response = await _mediator.Send(new UpdateCountryCommand() { Country = country });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
    }
}
