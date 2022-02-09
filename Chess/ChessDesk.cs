using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class ChessDesk
    {
        Figure[,] _figures = new Figure[8, 8];
        public void Clear()
        {
            for (var i = 2;i < 6; i++)
            {
                for (var j = 0;j < 8; j++) 
                {
                    _figures[i, j] = null;
                }
            }
            // pawn
            for (var i = 0;i < 8; i++)
            {
                _figures[i, 1] = new Pawn { FigureColor = FigureColor.Black };
                _figures[i, 6] = new Pawn { FigureColor = FigureColor.White };
            }
        }
    
        public Figure this[int x, int y]
        {
            get=>_figures[x, y];
        }
    
    }
}
