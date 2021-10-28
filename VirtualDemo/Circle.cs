using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDemo
{
    internal class Circle : object, ICircle, IDisposable
    {
        public double Radius;
        public double Diameter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double CalcLength()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
