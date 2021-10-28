using VirtualDemo;

var b = new B();
var c = new C();
var ba = (A)b;
var ca = (A)c;
var circle = new Circle();

using (circle = new Circle())
{
    ICircle circle2 = circle;
}

Console.WriteLine(GetInternalID(ba));
Console.WriteLine(GetInternalID(ca));


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int GetInternalID(A value) => value.GetID();