using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld10
{
    internal class BigBigWheel : AbstractDemo,IDisposable
    {
        int _a = 10;
        int _b = 20;
        public BigBigWheel(int b)
        {
            _b = b;      
        }
        ~BigBigWheel()
        {
            Console.WriteLine();
        }
        public override string Name => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        sealed public override DateTime GetTime()
        {
            throw new NotImplementedException();
        }
    }

    sealed class BigSmallWheel : IAbstractDemo
    {
        public string Name => throw new NotImplementedException();

        public DateTime GetTime()
        {
            throw new NotImplementedException();
        }
    }

}
