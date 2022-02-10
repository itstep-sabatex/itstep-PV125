using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpDemo
{
    internal class StreamDemo
    {
        public static void Do()
        {
            // See https://aka.ms/new-console-template for more information

            MemoryStream ms = new MemoryStream();
            StreamWriter memoryStreamWriter = new StreamWriter(ms);

            memoryStreamWriter.WriteLine("Hello World");
            memoryStreamWriter.Flush();
            ms.Seek(0, SeekOrigin.Begin);
            StreamReader streamReader = new StreamReader(ms);


            var s = streamReader.ReadLine();

            FileStream fs = File.Open("t.txt", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(10);




            StreamWriter streamWriter = null;
            BinaryReader reader = null;
            BinaryWriter writer = null;
        }
    }
}
