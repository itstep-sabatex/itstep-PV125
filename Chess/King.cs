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

        protected override bool CheckMove(int x, int y, int destX, int destY, ChessDesk desk)
        {
            return false;
        }
    }
}
