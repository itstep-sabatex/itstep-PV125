using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpDemo;

    [Flags]
    public enum RegisterCPUI8080:byte
    {
        Sign = 0x1,     //0000 0001
        Zero = 0x2,     //0000 0010
        Auxiliary = 0x4,//0000 0100
        Parity= 0x8,    //0000 1000
        Carry = 0x10,   //0001 0000
        All = 0x1f      //0001 1111
    }

