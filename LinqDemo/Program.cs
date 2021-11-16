// See https://aka.ms/new-console-template for more information

FIO[] peoples = new FIO[] {
    new FIO("Іван","Петренко","Іванович"),
    new FIO("Петро","Іванов","Іванович")


};


string[] st = new string[] {"Ivan;","Petro<","Semen","Guliana","Mar>ian","Pavlo"};

//var l = from s in st where s.StartsWith('P') select s.ToLower();
//var l = from s in st  orderby s, s.Length descending select new { Name = s };
var l =st.OrderBy(s=>s).ThenByDescending(sn=>sn.Length);

var an = new { Name = "Semen", FirstName = "Semenchenko" };

const string  WrongSimbols = ";<>";

//var m1 =l.ToArray();
// 

var m2 =st.Where(s=>s.Where(ss=>WrongSimbols.Contains(ss)).Count()!=0).ToArray();

var tp = LinqDemo.DemoTuple.GetTuple();
var tpr = LinqDemo.DemoTuple.GetTupleReal();    


foreach (var l1 in l)
{
    Console.WriteLine(l1.Name);
}

record FIO(string Name,string Surname,string SecondName);




