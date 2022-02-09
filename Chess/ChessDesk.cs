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
            // rook
            _figures[0,0] = new Rock { FigureColor= FigureColor.Black };
            _figures[7,0] = new Rock { FigureColor= FigureColor.Black };
            _figures[0,7] = new Rock { FigureColor=FigureColor.White };
            _figures[7,7] = new Rock { FigureColor = FigureColor.White };

            _figures[1,0] = new House { FigureColor= FigureColor.Black };
            _figures[6, 0] = new House { FigureColor = FigureColor.Black };
            _figures[1, 7] = new House { FigureColor = FigureColor.White };
            _figures[6, 7] = new House { FigureColor = FigureColor.White };

            _figures[2, 0] = new Bishop { FigureColor = FigureColor.Black };
            _figures[5, 0] = new Bishop { FigureColor = FigureColor.Black };
            _figures[2, 7] = new Bishop { FigureColor = FigureColor.White };
            _figures[5, 7] = new Bishop { FigureColor = FigureColor.White };
            
            _figures[3, 0] = new King { FigureColor = FigureColor.Black };
            _figures[4, 0] = new Queen { FigureColor = FigureColor.Black };
            _figures[3, 7] = new King { FigureColor = FigureColor.White };
            _figures[4, 7] = new Queen{ FigureColor = FigureColor.White };


        }

        public Figure this[int x, int y]
        {
            get=>_figures[x, y];
        }

        public FigureColor ActiveColor { get; set; }
        void Move(int x,int y, int destX, int destY)
        {


        }

    }
}
