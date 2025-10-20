namespace GROAN.Tests;

using System.Threading.Tasks;
using GROAN.Business;
using Xunit;

public class RandomUserClientTests
{
    [Fact]
    public async Task GetResultsFromApi_ShouldReturnSomeUsers()
    {
        // Arrange
        var client = new RandomUserClient();

        // Act
        var results = await client.GetResultsFromApi();

        // Assert
        Assert.NotNull(results);
        Assert.True(results.Count > 0, "Expected at least one user from the API");
    }
}