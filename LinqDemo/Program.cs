// See https://aka.ms/new-console-template for more information

FIO[] peoples = new FIO[] {
    new FIO("Ivan", "Ivanovich","Ivanov"),
    new FIO("Petro", "Petrovich","Ivanov"),
    new FIO("Semen", "Semenovich","Ivanov"),
    new FIO("Ivan", "Ivanovich","Petrenko"),
    new FIO("Petro", "Petrovich","Petrenko"),
    new FIO("Semen", "Semenovich","Petrenko"),
    new FIO("Ivan", "Ivanovich","Semenenko"),
    new FIO("Petro", "Petrovich","Semenenko"),
    new FIO("Semen", "Semenovich","Semenenko"),
    new FIO("Ivan", "Ivanovich","Nazarenko"),
    new FIO("Petro", "Petrovich","Nazarenko"),
    new FIO("Semen", "Semenovich","Nazarenko")

};

CarsFIO[] cars = new CarsFIO[] { 
    new CarsFIO("Abdulov",5),
    new CarsFIO("Geyts",150),
    new CarsFIO("Putin",70),
    new CarsFIO("Ivanov",15),
    new CarsFIO("Nazarenko",15)
};


var c = cars.Count();
var max = cars.Max(s=>s.Count);
var min = cars.Min(s=>s.Count);
var sum = cars.Sum(s => s.Count);

var exist = cars.Contains(new CarsFIO("Abdulov", 5));
var all = cars.All(item => item.Count == 15);
var any = cars.Any(item => item.Count == 15);

string[] st = new string[] { "Ivan;", "Petro", "Semen", "Guliana", "Marian", "Pavlo", "Petro", "Guliana","Danilo" };

string[] st2 = new string[] {"Ivan;","Petro","Semen","Guliana","Marian","Pavlo", "Petro", "Guliana" };
var rc = st.Union(st2);


var s = File.ReadAllText("task.txt")
        .Split(' ', '.', ';', ':', '(', ')', '\r', '\n', '=', ',', '/')
        .Where(s => s.Length > 0 && !Char.IsDigit(s.First())).GroupBy(s=>s)
        .Select(w=>new {word=w.Key,count=w.Count()}).ToArray();





//var rc = from person in peoples
//         join carFio in cars on person.Surname equals carFio.Surname
//         select new { person.Name, person.SecondName, person.Surname, carFio.Count };

foreach (var car in rc)
    Console.WriteLine(car);




//

////var l = from s in st from r in ff where s.StartsWith('P') select s.ToLower();
////var l = from s in st  orderby s, s.Length descending select new { Name = s };
//var l =st.OrderBy(s=>s).ThenByDescending(sn=>sn.Length);

//var an = new { Name = "Semen", FirstName = "Semenchenko" };

//const string  WrongSimbols = ";<>";

////var m1 =l.ToArray();
//// 

//var m2 =st.Where(s=>s.Where(ss=>WrongSimbols.Contains(ss)).Count()!=0).ToArray();

//var tp = LinqDemo.DemoTuple.GetTuple();
//var tpr = LinqDemo.DemoTuple.GetTupleReal();    


//foreach (var l1 in l)
//{
//    Console.WriteLine(l1);
//}

record FIO(string Name,string SecondName,string Surname);
record CarsFIO(string Surname,int Count);



