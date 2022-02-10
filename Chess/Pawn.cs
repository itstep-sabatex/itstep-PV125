using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public sealed class Pawn : Figure
    {
        public override int FigureOrder => 1;
        public Pawn(FigureColor figureColor):base(figureColor)
        {

        }


        public override bool CheckMove(ChessPoint source, ChessPoint destination, ChessDesk desk)
        {
            if (FigureColor != desk.ActiveColor) return false;

            int deltaRow = destination.Row - source.Row;
            int deltaCol = destination.Column- source.Column;

            if (deltaCol == 0)
            {
                // self
                if (deltaRow == 0) return false;
                // check direction
                if (deltaRow < 0 && FigureColor == FigureColor.Black) return false;
                if (deltaRow > 0 && FigureColor == FigureColor.White) return false;

                int direction = deltaRow > 0 ? 1 : -1;

                if (Math.Abs(deltaRow) == 1)
                {
                    if (desk[source.Row + direction,source.Column] == null)
                        return true;
                    else
                        return false;
                }

                if (Math.Abs(deltaRow) == 2)
                {
                    if (!IsFirstMove) return false;
                    if (desk[source.Row + direction,source.Column] == null && desk[source.Row + 2*direction, source.Column] == null)
                        return true;
                    else
                        return false;
                }
                return false;
            }

            if (Math.Abs(deltaRow) == 1 && Math.Abs(deltaCol) == 1)
            {
                // check direction
                if (deltaRow < 0 && FigureColor == FigureColor.Black) return false;
                if (deltaRow > 0 && FigureColor == FigureColor.White) return false;
                var figure = desk[destination];
                if (figure == null) return false;
                return figure.FigureColor != FigureColor;
            }

            return false;
        }
    }
}
