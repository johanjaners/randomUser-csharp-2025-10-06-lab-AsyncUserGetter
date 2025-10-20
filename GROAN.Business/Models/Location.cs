using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace GROAN.Business;

public class Location
{
    [JsonPropertyName("city")]
    public string City { get; set; } = string.Empty;
    [JsonPropertyName("country")]
    public string Country { get; set; } = string.Empty;
}
