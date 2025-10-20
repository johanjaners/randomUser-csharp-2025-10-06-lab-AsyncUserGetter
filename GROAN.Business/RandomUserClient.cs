using System.Text.Json;

namespace GROAN.Business;

public class RandomUserClient
{
    
    public async Task<RandomUserResponse> GetResultsFromApi()
    {
        var client = new HttpClient();
        var url = "https://randomuser.me/api/?results=50&inc=name,location,phone,nat";
        var json = await client.GetStringAsync(url);

        var data = JsonSerializer.Deserialize<RandomUserResponse>(json);
        
        return data;
    }
}