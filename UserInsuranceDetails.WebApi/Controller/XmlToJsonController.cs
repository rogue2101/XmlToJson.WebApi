using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using UserInsuranceDetails.WebApi.Services.XmlToJsonService.Interface;

namespace UserInsuranceDetails.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class XmlToJsonController : ControllerBase
    {
        private readonly IXmlToJsonService _xmlToJsonService;

        public XmlToJsonController(IXmlToJsonService userDetailService)
        {
            _xmlToJsonService = userDetailService;
        }

        [HttpGet("{configCode}")]
        public async Task<IActionResult> GetJsonAsync(string configCode)
        {
            return Ok(await _xmlToJsonService.GetJsonDataAsync(configCode));
        }
    }
}
