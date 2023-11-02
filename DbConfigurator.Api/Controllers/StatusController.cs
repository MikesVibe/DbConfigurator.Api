using DbConfigurator.Application.Contracts.Features.GetDetail;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        public ActionResult Ping()
        {
            return Ok();
        }
    }
}
