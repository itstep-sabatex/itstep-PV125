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
        private bool _firstMove = true;
        protected override bool CheckMove(int x, int y, int destX, int destY, Figure[,] desk)
        {

            if (FigureColor == FigureColor.Black)
            {
                // хід вперед 
                if (x == destX)
                {
                    var r = destY - y;

                    if (_firstMove)
                    {
                        if (r > 2) return false;
                        if (desk[destX, destY] == null && desk[destX, destY - 1] == null) return true;

                    }
                    else
                    {
                        if (r > 1) return false;
                        if (desk[destX, destY] == null) return true;
                    }
                    return false;
                }
                else
                {
                    // бити
                    // check coords
                    if (destY - y != 1) return false;
                    if ((destX - x) == 1 || (destX - x) == -1)
                    {
                        var figure = desk[destX, destY];
                        if (figure == null) return false;
                        // check color
                        if (FigureColor != figure.FigureColor) return true;
                    }
                    
                    return false;
                }
                
            }
            else
            {
                return false;
            }
        }
    }
}
