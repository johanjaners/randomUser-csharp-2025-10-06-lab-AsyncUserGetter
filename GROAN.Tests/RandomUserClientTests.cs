namespace GROAN.Tests;

using System.Threading.Tasks;
using GROAN.Business;
using Xunit;

public class RandomUserClientTests
{

    [Fact]
    public async Task GetResultsFromApi_ShouldReturn50Users()
    {
        // Arrange
        var client = new RandomUserClient();

        // Act
        var results = await client.GetResultsFromApi();

        // Assert
        Assert.NotNull(results);
        Assert.True(results.Count == 50);
    }
}