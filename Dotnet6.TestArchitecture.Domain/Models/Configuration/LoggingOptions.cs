namespace Dotnet6.TestArchitecture.Domain.Models.Configuration
{
    public class LoggingOptions
    {
        public const string Logging = "Logging";

        public LogLevel? LogLevel { get; set; }
    }

    public class LogLevel
    {
        [JsonPropertyName("Default")]
        public string? Default { get; set; }

        [JsonPropertyName("Microsoft.AspNetCore")]
        public string? MicrosoftAspNetCore { get; set; }
    }
}
