using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsHelloWorld
{
    internal enum ChessFigureType
    {
        none = 0,
        King = 1,
        Quin = 2,
        Rock = 4,
        Bishop = 8,
        Hourse = 16,
        Pawn = 32,

    }

    internal record ChessFigure(ChessFigureType FigureType,bool Black);
}
