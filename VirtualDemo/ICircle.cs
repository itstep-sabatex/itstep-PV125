using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDemo
{
    internal interface ICircle
    {
        public double Diameter { get; set; }
        public double CalcLength();
    }
}
