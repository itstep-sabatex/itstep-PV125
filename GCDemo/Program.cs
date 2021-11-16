// See https://aka.ms/new-console-template for more information

using GCDemo;


Test();
//GC.Collect(0);



//var start = DateTime.Now;
//for (int i = 0; i < 100; i++) 
//{   
//    var list = new List<DemoClass>();
//    for (int j = 0; j < 10000000; j++)
//    {
//            list.Add(new DemoClass { FirstName="Petrenco",GroupId=10,Name="Petro"});
//    }
//    Console.WriteLine($"{GC.GetTotalMemory(false)}");
    
//} 
//var end = DateTime.Now;
//Console.WriteLine($"elapsad time {end-start}");

Console.ReadKey();

void Test()
{
using (var demoClass = new DemoClass())
{
   
}
}
