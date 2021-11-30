namespace Dotnet6.TestArchitecture.Domain.Entities
{
    public class Customer
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }
    }
}
