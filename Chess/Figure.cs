using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public record ChessPoint(int Row, int Column);

    public abstract class Figure
    {
        public bool IsFirstMove { get; set; } = true;
        public FigureColor FigureColor { get; private set; }

        public Figure(FigureColor figureColor)
        {
            FigureColor = figureColor;    
        }


        public abstract bool CheckMove(int x, int y, int destX, int destY, ChessDesk desk);
        public bool CheckMove(ChessPoint source, ChessPoint destination, ChessDesk desk)=>
            CheckMove(source.Row,source.Column,destination.Row,destination.Column,desk);

        public IEnumerable<ChessPoint> CanMove(ChessPoint position, ChessDesk desk)
        {
            return CanMove(position.Row, position.Column, desk);
        }

        public IEnumerable<ChessPoint> CanMove(int row, int column, ChessDesk desk)
        {
            for (int _row = 0; _row < 8; _row++)
            {
                for (int _column = 0; _column < 8; _column++)
                {
                    if (row == _row && column == _column) continue;
                    if (CheckMove(row, column, _row, _column, desk))
                    {
                        
                        yield return new ChessPoint(_row,_column);
                    }
                }
            }
        }
        
        public abstract int FigureOrder { get; }

    }



}
