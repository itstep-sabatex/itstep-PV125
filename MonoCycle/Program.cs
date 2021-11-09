// See https://aka.ms/new-console-template for more information
using MonoCycle;

Console.WriteLine("Hello, World!");

var circle = new Circle();
circle.ChangeAngle += (a, b) => Console.WriteLine($"Angle new {a} old {b}");
circle.ChangeAngle += (a, b) => Console.WriteLine($"Кут новий {a} старий {b}");
circle.Angle = 10;
circle.Angle = 23;
