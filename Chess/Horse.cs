using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Horse : Figure
    {
        public override int FigureOrder => 3;
        public Horse(FigureColor figureColor):base(figureColor)
        {

        }

 
        public override bool CheckMove(ChessPoint source, ChessPoint destination, ChessDesk desk)
        {
            if (FigureColor != desk.ActiveColor) return false;

            int deltaRow = Math.Abs(destination.Row - source.Row);
            int deltaCol = Math.Abs(destination.Column - source.Column);

            if ((deltaRow == 1 && deltaCol==2) || (deltaRow == 2 && deltaCol==1))
            {
                var figure = desk[destination];
                if (figure == null) return true;
                return figure.FigureColor != FigureColor;
            }
            return false;

        }
    }
}
