using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dotnet6.TestArchitecture.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OptionsPatternController : ControllerBase
    {
        private readonly PatternOptions _patternOptions;
        private readonly LoggingOptions _loggingOptions;
        public OptionsPatternController(IOptions<PatternOptions> patternOptions, IOptions<LoggingOptions> loggingOptions)
        {
            _patternOptions = patternOptions.Value;
            _loggingOptions = loggingOptions.Value;
        }

        // GET: /<TestConfigController>
        [HttpGet("GetPatternOptions")]
        public PatternOptions GetPatternOptions()
        {
            return _patternOptions;
        }

        [HttpGet("GetLoggingOptions")]
        public LoggingOptions GetLoggingOptions()
        {
            return _loggingOptions;
        }
    }
}
