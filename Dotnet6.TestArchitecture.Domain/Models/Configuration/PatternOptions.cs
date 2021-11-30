using System;
using System.Collections.Generic;
namespace Dotnet6.TestArchitecture.Domain.Models.Configuration
{
    /// <summary>
    /// Example Class of Options Pattern
    /// </summary>
    public class PatternOptions
    {
        public const string OptionsPattern = "OptionsPattern";

        public string? SingleField { get; set; }

        public ObjectFieldOptions? ObjectField { get; set; }
    }

    public class ObjectFieldOptions
    {
        public const string ObjectField = "ObjectField";

        public string? Prop1 { get; set; }

        public string? Prop2 { get; set; }
    }
}
