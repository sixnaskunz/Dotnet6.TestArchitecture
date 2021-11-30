using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dotnet6.TestArchitecture.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoggerController : ControllerBase
    {
        private readonly ILogger _logger;
        public LoggerController(ILogger logger)
        {
            _logger = logger;
        }

        // GET: /<LoggerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInformation("Test");
            return new string[] { "value1", "value2" };
        }
    }
}
