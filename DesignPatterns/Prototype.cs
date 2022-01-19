using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Prototype : ICloneable
    {
        public double X;
        public double Y;
        public double Z;    
        public object Clone()
        {
            return new Prototype { X=this.X,Y=this.Y,Z=this.Z};
        }
    }
}
