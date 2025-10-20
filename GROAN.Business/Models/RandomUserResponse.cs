using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace GROAN.Business;

public class RandomUserResponse
{
    [JsonPropertyName("results")]
    public List<Result> Results { get; set; } = new();
}