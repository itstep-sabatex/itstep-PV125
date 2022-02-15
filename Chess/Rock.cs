using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Rock : Figure
    {
        public override int FigureOrder => 4;
        public Rock(FigureColor figureColor):base(figureColor)
        {
                
        }

 
        public override bool CheckMove(ChessPoint source, ChessPoint destination, ChessDesk desk)
        {
            if (FigureColor != desk.ActiveColor) return false;

            int deltaRow = destination.Row - source.Row;
            int deltaCol = destination.Column - source.Column;
            if (deltaRow == 0 && deltaCol == 0) return false;
            var figure = desk[destination];
            if (figure != null)
            {
                if (figure.FigureColor == this.FigureColor) return false;
            }
            if (deltaRow == 0)
            {
                int directionCol = deltaCol > 0 ? 1 : -1;
                // check path
                int iteration = Math.Abs(deltaCol);
                while (iteration > 1)
                {
                    ChessPoint point = new ChessPoint(source.Row,source.Column + directionCol*(iteration - 1));
                    figure = desk[point];
                    if (figure != null) return false;
                    iteration--;
                }
                return true;
            }

            if (deltaCol == 0)
            {
                int directionRow = deltaRow > 0 ? 1 : -1;
                // check path
                int iteration = Math.Abs(deltaRow);
                while (iteration > 1)
                {
                    ChessPoint point = new ChessPoint(source.Row +directionRow *(iteration-1), source.Column);
                    figure = desk[point];
                    if (figure != null) return false;
                    iteration--;
                }
                return true;
            }


            return false;
        }
    }
}
