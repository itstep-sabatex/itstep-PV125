using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Queen : Figure
    {
        public override int FigureOrder => 5;
        public Queen(FigureColor figureColor):base(figureColor)
        {

        }


        public override bool CheckMove(ChessPoint source, ChessPoint destination, ChessDesk desk)
        {
            return false;
        }
    }
}
