using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace GROAN.Business;

public class Name
{
    [JsonPropertyName("first")]
    public string First { get; set; } = string.Empty;
    [JsonPropertyName("last")]
    public string Last { get; set; } = string.Empty;
}
