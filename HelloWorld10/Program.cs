// See https://aka.ms/new-console-template for more information
using HelloWorld10;



var fl1 = RegisterCPUI8080.Carry | RegisterCPUI8080.Parity | RegisterCPUI8080.Auxiliary;

var fl = RegisterCPUI8080.All | RegisterCPUI8080.Carry;
var br = fl.HasFlag(RegisterCPUI8080.Sign);
// 0000 1011 & 0001 0000 = 0000 0000
// |
// 0000 0010 
// 

//<< 4
//>> 7
var hen = Hender.Man;
if (hen == Hender.Man)
{

}
var dddd = Days.Вівторок;


string days = "Понеділок";//Вівторок
switch (days)
{
    case "Понеділок":
        break;
    case "вівторок":
        break;
    case "середа":
        break;
    case "апр":
        break;


}

Days edays = Days.Понеділок;
int edaysInt = (int)edays;

var sd = edays.ToString();

    var p =Enum.Parse(typeof(Days), "Понеділок");
switch (edays)
{
    case Days.Понеділок:
        break;
    case Days.Пятниця:
        break;
}



int r = 1234567;
var tp = r.GetType().FullName;


var revers = new string(r.ToString().ToArray().Reverse().ToArray());

var startDate = DateTime.Now;


var endDate = DateTime.Now;
var dtr = DateTime.Now - startDate;
Console.WriteLine($"Час виконання - {endDate - startDate}");

var a = new MyClass();
a.Person = $"3424{r}234{revers}";
a.MyProperty = 10;
 //HelloWorld10.MyClass.Student = "254545";
double v = 10;

var c =  a.Add(34,2);

c = a.Add(10, 15, 16, 17, 23,true,"Ivan");
var b = MyClass.Name;


var bigClass = new BigClass();
var dc = new DemoClass();
dc.Add(10)


//for (int i=0;i<10;i++)
Console.WriteLine("Hello, World!");
