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

        public override bool CheckMove(int column, int row, int destColumn, int destRow, ChessDesk desk)
        {
            int deltaRow = destRow - row;
            int deltaCol = destColumn - column;

            if (deltaCol == 0)
            {
                // self
                if (deltaRow == 0) return false;
                // check direction
                if (deltaRow <0 && FigureColor == FigureColor.Black) return false;
                
                int direction = deltaRow > 0 ? 1 : -1;
                
                if (Math.Abs(deltaRow) == 1)
                {
                    if (desk[column, row + direction] == null)
                        return true;
                    else
                        return false;
                }

                if (Math.Abs(deltaRow) == 2)
                {
                    if (!IsFirstMove) return false;
                    if (desk[column, row + direction] == null && desk[column, row + 2*direction] == null)
                        return true;
                    else
                        return false;
                }
                return false;
            }
            
            if (Math.Abs(deltaRow) == 1 && Math.Abs(deltaCol)==1)
            {
                // check direction
                if (deltaRow < 0 && FigureColor == FigureColor.Black) return false;
                var figure = desk[destColumn, destRow];
                if (figure == null) return false;
                return figure.FigureColor != FigureColor;
            }

            return false;
         }
    }
}
