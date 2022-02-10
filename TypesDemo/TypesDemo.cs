using System;
using System.Collections.Generic;
using System.Text;

namespace TypesDemo
{
    internal class TypesDemo
    {
        static int Add(int a,int b) { return a + b; }


        static void Main(string[] args)
        {
            byte b;// = 10;
            
            sbyte sb = -10;
            short sh = -1000;
            Int16 sh16 = -234;
            ushort ush = 1000;
            int i = -1;
            uint u = 1;
            long l = -125;
            ulong r = 123;

            var number = double.Parse("234");

            double d = 0; //8 byte 15-17
            float f = 0;  //4 byte
            decimal c = 0;// 16 byte 28-29

            bool t = 10 < 2;

            string s = "start"; // 1 
            string s1 = s;
            char ch = 'e';
            for (int ix = 0;i<100000;i++)
            {
                s=s+" "+ix.ToString();
            }
            string result = s;

            StringBuilder sb1 = new StringBuilder(1000000);
            sb1.Append("eyycyyc");
            result = sb1.ToString();


            DateTime dt = DateTime.Now;

            Guid guid = new Guid("394dbdf6-4867-4009-aced-659491cc3149");//128bit
            var an = Guid.NewGuid();

            var rtte = sb1;

            var ssss = 1000.ToString();

            Console.WriteLine("Hello World!");
            Console.Write("4324343");
            Console.Write("tretret");
            // + - * / %
            // == != <= < > 
            //&& ||
            //++ -- 
            // += -=  a= a +10 
            // ! & &&  | ^ >> <<

            var sss = 23424 & 0x80;
            
            if (sss == 0)
            {
                Console.WriteLine("4535");
            }
            else
            {
                Console.WriteLine("gfdgxg");
            }

            switch (sss)
            {
                case 0:
                    Console.WriteLine("www");
                    break;
                case 1:
                    Console.WriteLine("ddd");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
            var ut5 = true ? 34 : 25;  

            for (int i34 = 0;i<ut5;i++) {
                // 
                continue;
                //
                break;
                //
            }
            goto label1;

            while (true) { }
            do { } while (true); 
label1:
            foreach (var s3 in ssss)
            {
                var c1 = 10;
                Console.WriteLine(s3);
            }
             var nnn = nameof(ut5);
             var nnnn = "ut";

            int[] b233;


            b233 = new int[10];
            b233[0] = 1;
            int[] a = new int[] { 10, 20, 30 };
            List<int> dunamicArray = new List<int>(a);
            int[] intArray = dunamicArray.ToArray();
            int[,] twoDimensio = new int[10,5];
            twoDimensio[1,4] = 1;
            int[][] jaggedArray = new int[10][];
            jaggedArray[0] = new int[5];
            jaggedArray[1]=new int[10];

            string[] stringArray = new string[10];

            if (stringArray != null) Console.WriteLine(stringArray ?? new string[] {""});

            var res =stringArray?.GetValue(10)?.ToString();

            int? pointerInt = null;
            int er = (short)10;
            short er2 = (short)10000;
        }
    }
}
