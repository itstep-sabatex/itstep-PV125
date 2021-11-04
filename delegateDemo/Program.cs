// See https://aka.ms/new-console-template for more information

namespace delegateDemo { 

static class Programm
{
        delegate void Message(int a);
        static void ShowMessage(int a)
        {
            Console.WriteLine("Hello, World!");
        }


    delegate int Compare(object a, object b);
    static object[] Sort(object[] source,Compare compare) 
    {
            object[] result = source.ToArray();

            if (compare == null) throw new Exception();
            if (compare(result[0],result[1]) ==0)
            {

            }
            return result;
       
    }
  
    static int CompareInt(object a,object b)
    {
        if (a == null || b == null) throw new ArgumentNullException();
        return (int)a-(int)b;
    }

    static void Main(string[] args)
    {
            var sortedarray = Sort(new object[] { 5, 2, 4, 9, 8, 0 }, CompareInt);



            Message message = ShowMessage;
            message(10);

    }    
    
}










}