using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class King : Figure
    {
        public override int FigureOrder => 0;
        public King(FigureColor figureColor):base(figureColor)
        {

        }


        public override bool CheckMove(ChessPoint source, ChessPoint destination, ChessDesk desk)
        {
            return false;
        }
    }
}
