using DbConfigurator.Api.IService;
using DbConfigurator.Model.DTOs.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributionInformationController : ControllerBase
    {
        private readonly IDistributionInformationService _distributionInformationService;

        public DistributionInformationController(IDistributionInformationService distributionInformationService)
        {
            this._distributionInformationService = distributionInformationService;
        }


        [HttpGet(Name = "GetDistributionInformation")]
        public async Task<IActionResult> GetDistributionInformation()
        {
            var distributionInformation = await _distributionInformationService.GetAllAsync();
            return Ok(distributionInformation.ToList());
        }
    }
}
