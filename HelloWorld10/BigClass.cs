using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld10
{
    public partial class BigClass
    {
        static int _b; //field
        protected int B { get; set; } //field


        public int Method1(int par /*parametr*/)
        {
            var a = 1; //varable
            return 1;
        }

    }

    interface ITest
    {
        void Paint();
    }


    


    internal class BigClass2 : ITest
    {
        public void Paint()
        {
            throw new NotImplementedException();
        }
    }
    class BigClass4:test.BigClass3
    {

    }

}
