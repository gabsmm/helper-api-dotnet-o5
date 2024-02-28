using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace helper_api_dotnet_o5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRateController : ControllerBase
    {
        private readonly ILogger<ExchangeRateController> _logger;

        public ExchangeRateController(ILogger<ExchangeRateController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetExchangeRateController")]
        public string Get()
        {
            return "teste";
        }
    }
}
