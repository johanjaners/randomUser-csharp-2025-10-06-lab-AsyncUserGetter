using GROAN.Business;

Console.WriteLine("here are the arguments");
foreach (var arg in args)
{
  Console.WriteLine($"{arg}");
}

var client = new RandomUserClient();
var results = await client.GetResultsFromApi();

foreach (var r in results)
{
  Console.WriteLine("First name: " + r.Name.First);
  Console.WriteLine("City: " + r.Location.City);
}

Console.WriteLine("No of persons: " + results.Count);