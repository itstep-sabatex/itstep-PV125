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

        protected override bool CheckMove(int x, int y, int destX, int destY, ChessDesk desk)
        {
            return false;
        }
    }
}
