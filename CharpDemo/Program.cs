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

