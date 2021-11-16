using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    internal class DemoTuple
    {
        static public (int,string,int) GetTuple()
        {
            //return new Tuple<int, string>(0, "2342342");
            return (10, "2345",11);
        }
        static public Tuple<int,string,string> GetTupleReal()
        {
            return new Tuple<int, string,string>(0, "2342342","ewrwr");
            //return (10, "2345");
        }
    }
}
