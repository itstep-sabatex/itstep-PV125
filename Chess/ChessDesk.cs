using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class ChessDesk
    {
        Figure[,] _figures = new Figure[8, 8];
        
        public List<Figure> KilledFigures { get;} = new List<Figure> { };
        
        public void Clear()
        {
            for (var i = 2;i < 6; i++)
            {
                for (var j = 0;j < 8; j++) 
                {
                    _figures[i, j] = null;
                }
            }
            // pawn
            for (var i = 0;i < 8; i++)
            {
                _figures[i, 1] = new Pawn(FigureColor.Black);
                _figures[i, 6] = new Pawn(FigureColor.White);
            }
            // rook
            _figures[0,0] = new Rock(FigureColor.Black);
            _figures[7,0] = new Rock(FigureColor.Black);
            _figures[0,7] = new Rock(FigureColor.White);
            _figures[7,7] = new Rock(FigureColor.White);

            _figures[1,0] = new House(FigureColor.Black);
            _figures[6, 0] = new House(FigureColor.Black);
            _figures[1, 7] = new House(FigureColor.White );
            _figures[6, 7] = new House(FigureColor.White);

            _figures[2, 0] = new Bishop(FigureColor.Black );
            _figures[5, 0] = new Bishop(FigureColor.Black);
            _figures[2, 7] = new Bishop(FigureColor.White );
            _figures[5, 7] = new Bishop(FigureColor.White);

            _figures[3, 0] = new King(FigureColor.Black );
            _figures[4, 0] = new Queen(FigureColor.Black );
            _figures[3, 7] = new King(FigureColor.White );
            _figures[4, 7] = new Queen(FigureColor.White );


        }

        public Figure this[int row, int column]
        {
            get=>_figures[row, column];
        }

        public Figure this[ChessPoint point]
        {
            get => _figures[point.Row, point.Column];
        }

        public FigureColor ActiveColor { get; set; }
        public void Move(ChessPoint source, ChessPoint destination)
        {
            var figure = _figures[source.Row, source.Column];
            if (figure == null)
                throw new Exception($"Figure not found in ({source.Row}.{source.Column}) ");
            if (figure.FigureColor != ActiveColor)
                throw new Exception($"Must be move figure color - {ActiveColor}");
            if (!figure.CheckMove(source, destination, this))
                throw new Exception("Figure can't move to position");
            var destinationFigure = _figures[destination.Row, destination.Column];
            if (destinationFigure != null)
            {
                KilledFigures.Add(destinationFigure);
            }
            figure.IsFirstMove = false;
            _figures[destination.Row, destination.Column] = figure;
            _figures[source.Row, source.Column] = null;

        }

    }
}
