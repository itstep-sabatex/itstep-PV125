using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDemo
{
    internal class B:A
    {
        public new void Show() { }


        public override int GetID()
        {
            return 20;
        }
    }
}
