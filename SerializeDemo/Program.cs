// See https://aka.ms/new-console-template for more information
using SerializeDemo;



if (File.Exists("test.json"))
{
    var state = File.ReadAllText("test.json");
    var newtest = System.Text.Json.JsonSerializer.Deserialize<ClassA>(state);
    Console.WriteLine(newtest);
}

Console.Write("Enter name:");
var result = new ClassA();
result.FirstName = Console.ReadLine();
Console.Write("Enter Last Name:");
result.LastName = Console.ReadLine();
result.Date = DateTime.Now;
var json = System.Text.Json.JsonSerializer.Serialize(result);
File.WriteAllText("test.json",json);





