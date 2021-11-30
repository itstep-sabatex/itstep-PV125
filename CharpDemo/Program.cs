// See https://aka.ms/new-console-template for more information
using CharpDemo;
using System.IO;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

//Console.WriteLine("Hello, World!");
//XMLSerializeDemo.DesserializeDemo();


// Trace       - стан виконання
// Debug       - 
// Information -
// Warning     -
// Error       -
// Critical    -
//
//
//
//None        -  


var anonimous1 = new { name = "Petro" ,surname = "Stepa"};
var s = nameof(anonimous1);
var s1 = "anonimous";

string s2 = "string>anonimous1;";
var s3 = s2 + s1;
s2 = s2 + "rtetet";

var ba = new int[] { 2, 4, 5, 1, 0, 5, 6 };
for (int i = 0; i < ba.Length; i++)
{
    try
    {
        Div(10,ba[i]);

    }
    catch (Exception ex)
    {
        Console.WriteLine($"В рядку {i} - {ex}");
    }


}

try
{
     
    var a1 = 0;
    try
    {
        var b = 10 / a1;
    }
    catch (Exception ex)
    {
        throw new Exception("");
        Console.WriteLine(ex.ToString());
    }
}
catch (Exception ex) 
{
    Console.WriteLine($"2 - {ex}");
}



var config = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json")
             .Build();


var user = config.GetValue<string>("UserName");



using var loggerFactory = LoggerFactory.Create(builder=>
{
    var logginSection = config.GetSection("Logging").GetSection("LogLevel");
    foreach (var lg in logginSection.GetChildren())
    {
        var key = lg.Key;
        var value = lg.Value;
        builder.AddFilter(key, Enum.Parse<LogLevel>(value));
    }
    builder
        .AddConsole()
        .AddDebug();
});

ILogger logger = loggerFactory.CreateLogger<Program>();

logger.LogCritical("Critical log");
logger.LogError("Error log");
logger.LogWarning("Warning log");


logger.LogInformation("Programm start");
Console.ReadKey();


int Div(int a,int b){

    try
    {
        return a / b;
    }
    catch(Exception ex)
    {
        //Console.WriteLine("Аггумент b = 0");
        throw new Exception("Аггумент b = 0");
    }
    return 0;
}

