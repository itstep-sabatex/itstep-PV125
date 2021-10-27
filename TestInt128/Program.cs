// See https://aka.ms/new-console-template for more information

using Int128;

UInt128 a = 0;
UInt128 b = 1;

ulong c = (ulong)b;
int ai = 1;
long al = ai;
int ae = (int)al;
ulong lo = a[0];
ulong hi = a[1];

if (a == 0)
{
    Console.WriteLine("Одинакові");
}
else
{
    Console.WriteLine("Різні");
}


Console.WriteLine("Hello, World!");
