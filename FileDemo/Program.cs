// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Stream stream = null;
var file = File.ReadAllBytes(@"C:\Users\sabat\OneDrive\Шаг\Ужгород\ПВ125\DZ_C__week_1_1490359617.pdf");
var fs =File.Create(@"C:\Users\sabat\OneDrive\Шаг\Ужгород\ПВ125\test.txt");

for (int j = 0; j < 10; j++)
{
    for (int i = 0; i < 100; i++)
    {
        fs.WriteByte(((byte)'A'));
    }
    fs.WriteByte(10);
    fs.WriteByte(13);
}
fs.Close();

//var txt =File.OpenText(@"C:\Users\sabat\OneDrive\Шаг\Ужгород\ПВ125\test.txt");
var s = File.ReadAllText(@"C:\Users\sabat\OneDrive\Шаг\Ужгород\ПВ125\test.txt");




Console.ReadKey();