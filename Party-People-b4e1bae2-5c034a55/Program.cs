using System.Text.Json;
var jsonFile = File.ReadAllText("people.json");
var people = JsonSerializer.Deserialize<List<Person>>(jsonFile)!;
foreach(var item in people)
{
    Console.WriteLine(item.Introduction());
}