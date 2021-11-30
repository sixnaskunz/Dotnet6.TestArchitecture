namespace Dotnet6.TestArchitecture.Domain.Models.Configuration
{
    public class LoggingOptions
    {
        public const string Logging = "Logging";

        
        public LogLevel? LogLevel { get; set; }
    }

    public class LogLevel
    {
        public string? Default { get; set; }

        /// <summary>
        /// Ref: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging/?view=aspnetcore-6.0#configure-logging
        /// </summary>
        public string? Microsoft { get; set; }
    }
}
