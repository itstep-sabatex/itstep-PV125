// See https://aka.ms/new-console-template for more information

FIO[] peoples = new FIO[] {
    new FIO("Іван","Петренко","Іванович"),
    new FIO("Петро","Іванов","Іванович")


};


string[] st = new string[] {"Ivan","Petro","Semen","Guliana","Marian","Pavlo"};

//var l = from s in st where s.StartsWith('P') select s.ToLower();
var l = from s in st  orderby s, s.Length descending select s;
//var l =st.OrderByDescending(s=>s.Length);

var an = new { Name = "Semen", FirstName = "Semenchenko" };



//var m1 =l.ToArray();

//var m2 =st.Where(s=>s.StartsWith('P')).ToArray();



foreach (var l1 in l)
{
    Console.WriteLine(l1);
}

record FIO(string Name,string Surname,string SecondName);


