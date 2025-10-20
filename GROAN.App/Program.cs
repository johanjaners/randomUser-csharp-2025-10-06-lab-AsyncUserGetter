using GROAN.Business;

Console.WriteLine("GROAN console app that loads 50 people from API randomuser.me/api");

Console.WriteLine("===");
if (args.Length > 0)
{
  Console.WriteLine("here are the arguments: ");
  foreach (var arg in args)
  {
    Console.WriteLine($"{arg}");
  }
}
var client = new RandomUserClient();
var people = await client.GetResultsFromApi();

// foreach (var person in people)
// {
//   Console.WriteLine($"Name: {person.Name.First} {person.Name.Last}");
//   Console.WriteLine("City: " + person.Location.City);
//   Console.WriteLine("Country: " + person.Location.Country);
//   Console.WriteLine();
// }

Console.WriteLine("No of people: " + people.Count);

var peopleGroupedByCountry = people
  .GroupBy(person => person.Location.Country);

Console.WriteLine("No of countries: " + peopleGroupedByCountry.Count());
Console.WriteLine();

// foreach(var countryGroup in peopleGroupedByCountry)
// {
//   Console.WriteLine("Country: " + countryGroup.Key);
//   foreach (var person in countryGroup)
//   {
//     Console.WriteLine($"Name: {person.Name.First} {person.Name.Last}");
//   }
//   Console.WriteLine();
// }

string? lastNameForFilter = "";
if (args.Length > 0)
{
  lastNameForFilter = args[0];

  var filteredPeople = people
    .Where(p => p.Name.Last.Contains(lastNameForFilter))
    .ToList();

  Console.WriteLine($"Filtering by: {lastNameForFilter}, Total found: {filteredPeople.Count}");
  Console.WriteLine("===");
  foreach (var person in filteredPeople)
  {
    Console.WriteLine($"{person.Name.First} {person.Name.Last}");
    Console.WriteLine("City: " + person.Location.City);
    Console.WriteLine("Country: " + person.Location.Country);
    Console.WriteLine("===");
  }
}