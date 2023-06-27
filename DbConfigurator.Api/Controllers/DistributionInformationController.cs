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
            //var distributionInformation = new List<DistributionInformationDto>
            //{
            //    new DistributionInformationDto
            //    {
            //        Id = 1,
            //        Region = new RegionDto
            //        {
            //            Id = 1,
            //            Area = new AreaDto{ Id = 1, Name = "America" },
            //            BuisnessUnit = new BuisnessUnitDto{ Id = 1, Name = "NAO" },
            //            Country = new CountryDto{ Id = 1, CountryName = "Canada", CountryCode= "CA" }
            //        },
            //        Priority=new PriorityDto{ Id = 1, Name="P1"}
            //    }
            //};

            var distributionInformation = await _distributionInformationService.GetAllAsync();

            return Ok(distributionInformation.ToList());
        }
    }
}
