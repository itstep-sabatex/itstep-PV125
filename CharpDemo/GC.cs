using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpDemo
{
    internal class GC : IDisposable
    {
        public string FirstName { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int GroupId { get; set; }
        private bool _disposed = false;
        ~GC()
        {
            Dispose();

        }


        public void Dispose()
        {
            if (!_disposed)
            {
                // dispose resurce
                Name = null;

                _disposed = true;

            }
        }
        public static void Do()
        {
            //GC.Collect(0);



            //var start = DateTime.Now;
            //for (int i = 0; i < 100; i++) 
            //{   
            //    var list = new List<DemoClass>();
            //    for (int j = 0; j < 10000000; j++)
            //    {
            //            list.Add(new DemoClass { FirstName="Petrenco",GroupId=10,Name="Petro"});
            //    }
            //    Console.WriteLine($"{GC.GetTotalMemory(false)}");

            //} 
            //var end = DateTime.Now;
            //Console.WriteLine($"elapsad time {end-start}");

            Console.ReadKey();

            void Test()
            {
                using (var demoClass = new GC())
                {

                }
            }
        }
    }
}
