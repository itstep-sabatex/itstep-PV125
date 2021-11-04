using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld10
{
    public abstract class AbstractDemo
    {

        public abstract string Name { get; }
        public abstract DateTime GetTime();

    }

    public interface IAbstractDemo
    {
        string Name { get; }
        DateTime GetTime();

    }



}
