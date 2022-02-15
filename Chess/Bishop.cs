using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Bishop : Figure
    {
        public override int FigureOrder => 2;
        public Bishop(FigureColor figureColor):base(figureColor)
        {

        }

 
        public override bool CheckMove(ChessPoint source, ChessPoint destination, ChessDesk desk)
        {
            if (FigureColor != desk.ActiveColor) return false;

            int deltaRow = destination.Row - source.Row;
            int deltaCol = destination.Column - source.Column;
            if (Math.Abs(deltaRow) != Math.Abs(deltaCol)) return false;

            var figure = desk[destination];
            if (figure != null)
            {
                if (figure.FigureColor == this.FigureColor) return false;
            }

            int directionCol = deltaCol > 0 ? 1 : -1;
            int directionRow = deltaRow > 0 ? 1 : -1;

            // check path
            int iteration = Math.Abs(deltaCol);
            while (iteration > 1)
            {
                ChessPoint point = new ChessPoint(source.Row +directionRow *(iteration-1), source.Column + directionCol * (iteration - 1));
                figure = desk[point];
                if (figure != null) return false;
                iteration--;
            }
            return true;
         }
    }
}
