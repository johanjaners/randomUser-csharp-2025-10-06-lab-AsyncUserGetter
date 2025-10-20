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


// // {
//   "results": [
//     {
//       "name": {
//         "title": "Ms",
//         "first": "Rhonda",
//         "last": "Mitchelle"
//       },
//       "location": {
//         "street": {
//           "number": 2693,
//           "name": "Hillcrest Rd"
//         },
//         "city": "Amarillo",
//         "state": "Louisiana",
//         "country": "United States",
//         "postcode": 84604,
//         "coordinates": {
//           "latitude": "87.8237",
//           "longitude": "59.4734"
//         },
//         "timezone": {
//           "offset": "-2:00",
//           "description": "Mid-Atlantic"
//         }
//       },
//       "phone": "(385) 737-6421",
//       "nat": "US"
//     },