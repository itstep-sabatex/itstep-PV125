using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public record ChessPoint(int Row, int Column);

    public abstract class Figure
    {
        public bool IsFirstMove { get; set; } = true;
        public FigureColor FigureColor { get; private set; }

        public Figure(FigureColor figureColor)
        {
            FigureColor = figureColor;    
        }


        //public abstract bool CheckMove(int x, int y, int destX, int destY, ChessDesk desk);
        public abstract bool CheckMove(ChessPoint source, ChessPoint destination, ChessDesk desk);

        public IEnumerable<ChessPoint> CanMove(ChessPoint position, ChessDesk desk)
        {
            for (int _row = 0; _row < 8; _row++)
            {
                for (int _column = 0; _column < 8; _column++)
                {
                    var destination = new ChessPoint(_row, _column);
                    if (CheckMove(position, destination, desk))
                    {
                        yield return destination;
                    }
                }
            }

        }

        
        public abstract int FigureOrder { get; }

    }



}
