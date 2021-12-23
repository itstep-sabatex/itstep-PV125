// See https://aka.ms/new-console-template for more information

namespace CharpDemo { 

static class DelegateDemo
{
        delegate void Message(int a);

        static event Message MessageEvent;


        static void ShowMessage(int a)
        {
            Console.WriteLine("Hello, World!");
        }


    delegate int Compare(object a, object b);
    static object[] Sort(object[] source, Func< object, object,int> compare) 
    {
            object[] result = source.ToArray();

            for (int j=0; j<result.Length-1; j++) 
            {
                bool swap = false;
                for (int i=0; i < result.Length - j - 1; i++)
                {
                    if ((compare?.Invoke(result[i], result[i+1]) ?? 0)   >0)
                    {
                        swap = true;
                        var temp = result[i];
                        result[i] = result[i+1];
                        result[i+1] = temp;
                    }
                }
                if (!swap) break;
            }
            return result;
    }
  
    //static int CompareInt(object a,object b)
    //{
    //    if (a == null || b == null) throw new ArgumentNullException();
    //    return (int)a-(int)b;
    //}

    static void Demo(string[] args)
    {
            Compare compare = delegate (object a, object b)
            {
                if (a == null || b == null) throw new ArgumentNullException();
                return (int)a - (int)b;

            };
            compare +=delegate (object a, object b) 
            {
                return 0; 
            };

            var a =compare(10, 5);

            int? bb = null;
            int b;
            if (bb == null)
                b = 5;
            else
                b= bb.Value;



            var sortedarray = Sort(new object[] { 5, 2, 4, 9, 8, 0 }, null);
            foreach (var item in sortedarray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            foreach (var item in Sort(new object[] { 5.2, 2.3, 4.5, 9.1, 88.1, 0.1 }, (a, b) => 
            {
                var r = (double)a - (double)b;
                if (r > 0) return 1;
                if (r < 0) return -1;
                return 0;
            }))
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();


            Message message = ShowMessage;
            message(10);

    }    
    
}










}