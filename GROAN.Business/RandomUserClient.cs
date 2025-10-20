using System.Text.Json;

namespace GROAN.Business;

public class RandomUserClient
{
    
    public async Task<List<Result>> GetResultsFromApi()
    {
        var client = new HttpClient();
        var url = "https://randomuser.me/api/?results=50&inc=name,location,phone,nat";
        var json = await client.GetStringAsync(url);

        var response = JsonSerializer.Deserialize<RandomUserResponse>(json);

        return response.Results;
    }
}