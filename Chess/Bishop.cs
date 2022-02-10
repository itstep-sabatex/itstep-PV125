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
            return false;
        }
    }
}
