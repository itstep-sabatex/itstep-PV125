// See https://aka.ms/new-console-template for more information
using SerializeDemo;


var test = new ClassA
{
    Age = 21,
    FirstName = "Alise",
    LastName ="Dunli",
    IsAlive = false,
    Address = new Address()
    {
        City = "Uzhgorod",
        State = "Transcarpatia",
        PostalCode ="88015",
        StreetAddress = "Lenina 60"
    }

};

var json = System.Text.Json.JsonSerializer.Serialize(test);
File.WriteAllText("test.json",json);


var rjs = File.ReadAllText("test.json");
var newtest = System.Text.Json.JsonSerializer.Deserialize<ClassA>(rjs);

var a = 0;


