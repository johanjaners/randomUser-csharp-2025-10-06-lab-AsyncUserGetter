using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace GROAN.Business;

public class Result
{
    [JsonPropertyName("name")]
    public Name Name { get; set; } = new();
    [JsonPropertyName("location")]
    public Location Location { get; set; } = new();
    [JsonPropertyName("phone")]
    public string Phone { get; set; } = string.Empty;
}
