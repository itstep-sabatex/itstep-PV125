// See https://aka.ms/new-console-template for more information
using SerializeDemo;

var peopls = new List<ClassA>();

if (File.Exists("test.json"))
{
    var state = File.ReadAllText("test.json");
    peopls = System.Text.Json.JsonSerializer.Deserialize<List<ClassA>>(state);
    foreach (var test in peopls)
        Console.WriteLine(test);
}

Console.Write("Enter name:");
var result = new ClassA();
result.FirstName = Console.ReadLine();
Console.Write("Enter Last Name:");
result.LastName = Console.ReadLine();
result.Date = DateTime.Now;
peopls.Add(result);

var options = new System.Text.Json.JsonSerializerOptions
{
    WriteIndented = true,
    IncludeFields = true,
    PropertyNamingPolicy=System.Text.Json.JsonNamingPolicy.CamelCase
};

var json = System.Text.Json.JsonSerializer.Serialize(peopls,options);
File.WriteAllText("test.json",json);





