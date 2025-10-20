using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace GROAN.Business;

public class RandomUserResponse
{
    [JsonPropertyName("results")]
    public List<Result> Results { get; set; } = new();
}

public class Result
{
    [JsonPropertyName("name")]
    public Name Name { get; set; } = new();
    [JsonPropertyName("location")]
    public Location Location { get; set; } = new();
    [JsonPropertyName("phone")]
    public string Phone { get; set; } = string.Empty;
}

public class Name
{
    [JsonPropertyName("first")]
    public string First { get; set; } = string.Empty;
    [JsonPropertyName("last")]
    public string Last { get; set; } = string.Empty;
}
public class Location
{
    [JsonPropertyName("city")]
    public string City { get; set; } = string.Empty;
    [JsonPropertyName("country")]
    public string Country { get; set; } = string.Empty;
}