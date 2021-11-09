using GenericDemo;
var t = new List<string>();
t.Add("wrwrew");
t.Add("24432");
t.Add("122313");
t.Sort();
t[4] = "45";
if (t.Contains("er")) { }
Console.WriteLine(t.Count);
Dictionary<string, string> englishdic = new Dictionary<string, string>();
englishdic.Add("one", "Один");
englishdic.Add("two", "Два");

var a = englishdic.GetValueOrDefault("two","...");

Stack<string> stack = new Stack<string>();
stack.Push("wwww");
var s =stack.Pop();


Queue<string> queue = new Queue<string>();

DateTime dt = DateTime.Now;
DateTime beinOfDay = new DateTime(dt.Year,dt.Month,dt.Day,0,0,0);
var bD = dt.BeginOfDay();






var list = new GenericList<int>();
for (int i = 0; i < 10; i++) list.AddHead(i);

foreach (int i in list) Console.Write(i+ " ");
