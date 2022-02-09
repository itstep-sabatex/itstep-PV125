using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public abstract class Figure
    {
        protected abstract bool CheckMove(int x, int y, int destX, int destY, ChessDesk desk);
 
        //public Tuple<int,int>[] CanMove(int x, int y, Figure[,] desk)
        //{
        //    var result = new List<Tuple<int, int>>();
        //    for (int i = 0; i < 8; i++)
        //    {
        //        for (int j = 0; j < 8; j++)
        //        {
        //            if (CheckMove(x, y, i,j, desk))
        //            {
        //                result.Add(new Tuple<int, int>(i, j));
        //            }
        //        }
        //    }
        //    return result.ToArray();
        //}
        public IEnumerable<Tuple<int, int>> CanMove(int x, int y, ChessDesk desk)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (x == i && y == j) continue;
                    if (CheckMove(x, y, i, j, desk))
                    {
                        
                        yield return new Tuple<int, int>(i,j);
                    }
                }
            }
        }
        public FigureColor FigureColor { get; set; }
        public abstract int FigureOrder { get; }

    }



}
