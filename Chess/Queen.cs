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
        bool CheckMoveRock(ChessPoint source, ChessPoint destination, ChessDesk desk)
        {
            if (FigureColor != desk.ActiveColor) return false;

            int deltaRow = destination.Row - source.Row;
            int deltaCol = destination.Column - source.Column;
            if (deltaRow == 0 && deltaCol == 0) return false;
            var figure = desk[destination];
            if (figure != null)
            {
                if (figure.FigureColor == this.FigureColor) return false;
            }
            if (deltaRow == 0)
            {
                int directionCol = deltaCol > 0 ? 1 : -1;
                // check path
                int iteration = Math.Abs(deltaCol);
                while (iteration > 1)
                {
                    ChessPoint point = new ChessPoint(source.Row, source.Column + directionCol * (iteration - 1));
                    figure = desk[point];
                    if (figure != null) return false;
                    iteration--;
                }
                return true;
            }

            if (deltaCol == 0)
            {
                int directionRow = deltaRow > 0 ? 1 : -1;
                // check path
                int iteration = Math.Abs(deltaRow);
                while (iteration > 1)
                {
                    ChessPoint point = new ChessPoint(source.Row + directionRow * (iteration - 1), source.Column);
                    figure = desk[point];
                    if (figure != null) return false;
                    iteration--;
                }
                return true;
            }


            return false;
        }
        bool CheckMoveBishop(ChessPoint source, ChessPoint destination, ChessDesk desk)
        {
            if (FigureColor != desk.ActiveColor) return false;

            int deltaRow = destination.Row - source.Row;
            int deltaCol = destination.Column - source.Column;
            if (Math.Abs(deltaRow) != Math.Abs(deltaCol)) return false;

            var figure = desk[destination];
            if (figure != null)
            {
                if (figure.FigureColor == this.FigureColor) return false;
            }

            int directionCol = deltaCol > 0 ? 1 : -1;
            int directionRow = deltaRow > 0 ? 1 : -1;

            // check path
            int iteration = Math.Abs(deltaCol);
            while (iteration > 1)
            {
                ChessPoint point = new ChessPoint(source.Row + directionRow * (iteration - 1), source.Column + directionCol * (iteration - 1));
                figure = desk[point];
                if (figure != null) return false;
                iteration--;
            }
            return true;
        }

        public override bool CheckMove(ChessPoint source, ChessPoint destination, ChessDesk desk)
        {
            if (CheckMoveRock(source,destination,desk))
                return true;
            else
                return CheckMoveBishop(source,destination,desk);
        }


        //public override bool CheckMove(ChessPoint source, ChessPoint destination, ChessDesk desk)
        //{
        //    if (FigureColor != desk.ActiveColor) return false;

        //    int deltaRow = destination.Row - source.Row;
        //    int deltaCol = destination.Column - source.Column;
        //    if (deltaRow == 0 && deltaCol == 0) return false;
        //    var figure = desk[destination];
        //    if (figure != null)
        //    {
        //        if (figure.FigureColor == this.FigureColor) return false;
        //    }
        //    int directionCol = deltaCol > 0 ? 1 : -1;
        //    int directionRow = deltaRow > 0 ? 1 : -1;

        //    int iteration = Math.Abs(deltaCol);
        //    if (deltaRow == 0)
        //    {
        //        // check path
        //        while (iteration > 1)
        //        {
        //            ChessPoint point = new ChessPoint(source.Row, source.Column + directionCol * (iteration - 1));
        //            figure = desk[point];
        //            if (figure != null) return false;
        //            iteration--;
        //        }
        //        return true;
        //    }

        //    if (deltaCol == 0)
        //    {
        //        // check path
        //        iteration = Math.Abs(deltaRow);
        //        while (iteration > 1)
        //        {
        //            ChessPoint point = new ChessPoint(source.Row + directionRow * (iteration - 1), source.Column);
        //            figure = desk[point];
        //            if (figure != null) return false;
        //            iteration--;
        //        }
        //        return true;
        //    }
        //    if (Math.Abs(deltaRow) != Math.Abs(deltaCol)) return false;

        //    // check path
        //    iteration = Math.Abs(deltaCol);
        //    while (iteration > 1)
        //    {
        //        ChessPoint point = new ChessPoint(source.Row + directionRow * (iteration - 1), source.Column + directionCol * (iteration - 1));
        //        figure = desk[point];
        //        if (figure != null) return false;
        //        iteration--;
        //    }
        //    return true;

        //}
    }
}
